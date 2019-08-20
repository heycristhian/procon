using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.GoldCowboy
{
    public partial class frmGoldClassificacao : Form
    {
        int rGoldID;

        public frmGoldClassificacao(int rGoldID)
        {
            this.rGoldID = rGoldID;
            InitializeComponent();
        }


        private void frmGoldClassificacao_Load(object sender, EventArgs e)
        {
            cmbTouro.ValueMember = "id";
            cmbTouro.DisplayMember = "touroNome";
            carregarComboBox();
        }

        private void carregarComboBox()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.RoundGold rGold = contexto.RoundGold.Find(rGoldID);
            if (rGold.num == 1)
            {
                cmbCompetidor.ValueMember = "id";
                cmbCompetidor.DisplayMember = "apelidoCompetidor";
                cmbCompetidor.DataSource = rGold.goldCowboy.etapa.etapaCompetidor.OrderBy(e => e.apelidoCompetidor).ToList();
            }
            else
            {
                cmbCompetidor.ValueMember = "Key";
                cmbCompetidor.DisplayMember = "Value";
                Dictionary<int, string> dicCombo = new Dictionary<int, string>();
                if (rGold.tipo == 1)
                {
                    Modelo.RoundGold rAnt = getRoundGoldAnt(rGold);
                    for (int i = 0; i < rAnt.goldMontaria.Count; i++)
                    {
                        if (rGold.goldMontaria.Count(m => m.recebeOrd == (i +1 )) == 0)
                        {
                            dicCombo.Add(i + 1, (i + 1) + "° Colocado");
                        }
                    }
                    cmbCompetidor.DataSource = dicCombo.ToList();
                }
            }
            cmbTouro.DataSource = rGold.goldCowboy.goldTouro.Where(t => !t.selecionado).OrderBy(t => t.touro.nome).ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bool op = true;
            if (op)
            {
                if (cmbCompetidor.SelectedIndex > -1)
                {
                    if (cmbTouro.SelectedIndex > -1)
                    {
                        gravarDuelo();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("É necessário selecionar um touro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário selecionar um competidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gravarDuelo()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldMontaria goldMontaria = new Modelo.GoldMontaria();
            Modelo.RoundGold roundGold = contexto.RoundGold.Find(rGoldID);
            int ord = roundGold.goldMontaria.Count == 0 ? 1 : roundGold.goldMontaria.Max(m => m.ord) + 1;
            goldMontaria.ord = ord;
            goldMontaria.goldTouroID = Convert.ToInt32(cmbTouro.SelectedValue);
            goldMontaria.roundGoldID = roundGold.id;
            atualizarGoldTouro(Convert.ToInt32(goldMontaria.goldTouroID));
            if (roundGold.num == 1)
            {
                goldMontaria.etapaCompetidorID = Convert.ToInt32(cmbCompetidor.SelectedValue);
                goldMontaria.recebeOrd = 0;
            }
            else
            {
                goldMontaria.etapaCompetidorID = null;
                goldMontaria.recebeOrd = Convert.ToInt32(cmbCompetidor.SelectedValue);
            }
            contexto.GoldMontaria.Add(goldMontaria);
            contexto.SaveChanges();
        }

        private void atualizarGoldTouro(int touroGoldID)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldTouro goldTouro = contexto.GoldTouro.Find(touroGoldID);
            goldTouro.selecionado = !goldTouro.selecionado;
            contexto.Entry(goldTouro).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        private Modelo.RoundGold getRoundGoldAnt(Modelo.RoundGold rGold)
        {
            return rGold.goldCowboy.roundGold.First(r => r.num == rGold.num - 1);
        }
      
    }
}
