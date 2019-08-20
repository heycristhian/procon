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
    public partial class frmGoldDuelo : Form
    {
        private int rGoldID;

        //Vou utilziar um dictionary como uma estrutura para informa ao combox o display da montaria futura, logo com a ordem.

        public frmGoldDuelo()
        {
            InitializeComponent();
        }

        public frmGoldDuelo(int roundGoldID)
        {
            InitializeComponent();
            this.rGoldID = roundGoldID;
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
                if (Convert.ToInt32(cmbCompetidor1.SelectedValue) != Convert.ToInt32(cmbCompetidor2.SelectedValue))
                {
                    if (Convert.ToInt32(cmbTouro1.SelectedValue) != Convert.ToInt32(cmbTouro2.SelectedValue))
                    {
                        gravarDuelo();
                    }
                    else
                    {
                        MessageBox.Show("Não é possível gravar um duelo como dois touros iguais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível gravar um duelo com dois competidores iguais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gravarDuelo()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldMontaria goldMontaria1 = new Modelo.GoldMontaria();
            Modelo.GoldMontaria goldMontaria2 = new Modelo.GoldMontaria();
            Modelo.RoundGold roundGold = contexto.RoundGold.Find(rGoldID);
            int ord = roundGold.goldMontaria.Count == 0 ? 1 : roundGold.goldMontaria.Max(m => m.ord) + 1;
            goldMontaria1.ord = ord;
            goldMontaria1.goldTouroID = Convert.ToInt32(cmbTouro1.SelectedValue);
            goldMontaria1.roundGoldID = roundGold.id;
            atualizarGoldTouro(Convert.ToInt32(goldMontaria1.goldTouroID));
            goldMontaria2.ord = ord;
            goldMontaria2.goldTouroID = Convert.ToInt32(cmbTouro2.SelectedValue);
            goldMontaria2.roundGoldID = roundGold.id;
            atualizarGoldTouro(Convert.ToInt32(goldMontaria2.goldTouroID));
            if (roundGold.num == 1)
            {
                goldMontaria1.etapaCompetidorID = Convert.ToInt32(cmbCompetidor1.SelectedValue);
                goldMontaria1.recebeOrd = 0;
                goldMontaria2.etapaCompetidorID = Convert.ToInt32(cmbCompetidor2.SelectedValue);
                goldMontaria2.recebeOrd = 0;
            }
            else
            {
                goldMontaria1.etapaCompetidorID = null;
                goldMontaria1.recebeOrd = Convert.ToInt32(cmbCompetidor1.SelectedValue);
                goldMontaria2.etapaCompetidorID = null;
                goldMontaria2.recebeOrd = Convert.ToInt32(cmbCompetidor2.SelectedValue);
            }
            contexto.GoldMontaria.Add(goldMontaria1);
            contexto.GoldMontaria.Add(goldMontaria2);
            contexto.SaveChanges();
            this.Close();
        }

        private void atualizarGoldTouro(int touroGoldID)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldTouro goldTouro = contexto.GoldTouro.Find(touroGoldID);
            goldTouro.selecionado = !goldTouro.selecionado;
            contexto.Entry(goldTouro).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        private void frmGoldDuelo_Load(object sender, EventArgs e)
        {
            
            cmbTouro1.ValueMember = "id";
            cmbTouro1.DisplayMember = "touroNome";
            cmbTouro2.ValueMember = "id";
            cmbTouro2.DisplayMember = "touroNome";
            carregarComboBox();
        }

        private void carregarComboBox()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.RoundGold rGold = contexto.RoundGold.Find(this.rGoldID);
            if (rGold.num == 1)
            {
                cmbCompetidor1.ValueMember = "id";
                cmbCompetidor1.DisplayMember = "apelidoCompetidor";
                cmbCompetidor2.ValueMember = "id";
                cmbCompetidor2.DisplayMember = "apelidoCompetidor";
                cmbCompetidor1.DataSource = rGold.goldCowboy.etapa.etapaCompetidor.OrderBy(e => e.apelidoCompetidor).ToList();
                cmbCompetidor2.DataSource = rGold.goldCowboy.etapa.etapaCompetidor.OrderBy(e => e.apelidoCompetidor).ToList();
            }
            else
            {
                cmbCompetidor1.ValueMember = "Key";
                cmbCompetidor1.DisplayMember = "Value";
                cmbCompetidor2.ValueMember = "Key";
                cmbCompetidor2.DisplayMember = "Value";
                Dictionary<int, string> dicCombo = new Dictionary<int, string>();
                Modelo.RoundGold rAnt = roundAnt(rGold);
                if (rAnt.tipo == 0)
                {
                    int qtdRound = rAnt.goldMontaria.Count / 2;
                    for (int i = 0; i < qtdRound; i++)
                    {
                        if (rGold.goldMontaria.Count(m => m.recebeOrd == i + 1) == 0)
                            dicCombo.Add(i + 1, "Vencedor do " + (i + 1) + "° Duelo");
                    }
                    cmbCompetidor1.DataSource = dicCombo.ToList();
                    cmbCompetidor2.DataSource = dicCombo.ToList();
                }
            }
            cmbTouro1.DataSource = rGold.goldCowboy.goldTouro.Where(t => !t.selecionado).OrderBy(t => t.touro.nome).ToList();
            cmbTouro2.DataSource = rGold.goldCowboy.goldTouro.Where(t => !t.selecionado).OrderBy(t => t.touro.nome).ToList();
        }

        private Modelo.RoundGold roundAnt(Modelo.RoundGold rGold)
        {
            return rGold.goldCowboy.roundGold.First(r => r.num == rGold.num - 1);
        }
    }
}
