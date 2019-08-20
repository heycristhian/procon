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
    public partial class frmGoldNota : Form
    {
        int goldMontariaID;

        public frmGoldNota()
        {
            InitializeComponent();
        }

        public frmGoldNota(int goldMontariaID)
        {
            InitializeComponent();
            this.goldMontariaID = goldMontariaID;
        }

        private void frmGoldNota_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldMontaria goldMontaria = contexto.GoldMontaria.Find(this.goldMontariaID);
            carregarMontaria();
            controlesDinamico(goldMontaria.etapaCompetidor.etapa);
        }

        private void controlesDinamico(Modelo.Etapa etapa)
        {
            List<Modelo.Equipe> lstJuizes = etapa.equipe.Where(e => e.profissonal.tipoProfissonal.descricao.ToLower() == "juiz").OrderBy(j => j.profissonal.nome).ToList();
            this.Font = new Font("Arial", 13, FontStyle.Regular);
            this.Size = new Size(1280, 730);
            int alt = 100;
            Label lblCabTouro = new Label();
            lblCabTouro.Text = "Touro";
            lblCabTouro.Location = new Point(350, alt + 20);
            Label lblCabCompetidor = new Label();
            lblCabCompetidor.Text = "Comp";
            lblCabCompetidor.Location = new Point(435, alt + 20);
            lblCabCompetidor.AutoSize = true;
            Label lblCabTotal = new Label();
            lblCabTotal.Text = "Totais";
            lblCabTotal.Location = new Point(520, alt + 20);
            Label lblCabJuiz = new Label();
            lblCabJuiz.Text = "Juizes";
            lblCabJuiz.Location = new Point(20, alt + 20);
            this.Controls.Add(lblCabCompetidor);
            this.Controls.Add(lblCabTouro);
            this.Controls.Add(lblCabTotal);
            this.Controls.Add(lblCabJuiz);
            for (int i = 0; i < lstJuizes.Count; i++)
            {
                Label lblJuiz = new Label();
                lblJuiz.Text = (lstJuizes[i].profissonal.apelido + ":").ToUpper();
                lblJuiz.Size = new Size(300, 30);
                lblJuiz.TextAlign = ContentAlignment.MiddleRight;
                lblJuiz.Location = new Point(20, (alt + 45 * (i + 1)));
                lblJuiz.BorderStyle = BorderStyle.FixedSingle;
                TextBox txtNotaTouro = new TextBox();
                txtNotaTouro.Name = "txtNotaTouro" + lstJuizes[i].id;
                txtNotaTouro.Location = new Point(350, (alt + 45 * (i + 1)));
                txtNotaTouro.Size = new Size(65, 30);
                txtNotaTouro.TextAlign = HorizontalAlignment.Center;
                //txtNotaTouro.Leave += new EventHandler(TextBox_Leave);
                //txtNotaTouro.KeyPress += new KeyPressEventHandler(txtNota_KeyPress);
                //txtNotaTouro.KeyDown += new KeyEventHandler(txtNota_KeyDown);
                TextBox txtNotaCompetidor = new TextBox();
                txtNotaCompetidor.Name = "txtNotaCompetidor" + lstJuizes[i].id;
                txtNotaCompetidor.Location = new Point(435, (alt + 45 * (i + 1)));
                txtNotaCompetidor.Size = new Size(65, 30);
                txtNotaCompetidor.TextAlign = HorizontalAlignment.Center;
                //txtNotaCompetidor.Leave += new EventHandler(TextBox_Leave);
                //txtNotaCompetidor.KeyPress += new KeyPressEventHandler(txtNota_KeyPress);
                //txtNotaCompetidor.KeyDown += new KeyEventHandler(txtNota_KeyDown);
                Label lblTotalJuiz = new Label();
                lblTotalJuiz.Name = "lblTotalJuiz" + lstJuizes[i].id;
                lblTotalJuiz.Size = new Size(65, 30);
                lblTotalJuiz.TextAlign = ContentAlignment.MiddleCenter;
                lblTotalJuiz.Location = new Point(520, (alt + 45 * (i + 1)));
                lblTotalJuiz.BorderStyle = BorderStyle.FixedSingle;
                Control[] controles = { lblJuiz, txtNotaTouro, txtNotaCompetidor, lblTotalJuiz };
                this.Controls.AddRange(controles);
            }
            Label lblTotalTouro = new Label();
            lblTotalTouro.Name = "lblTotalTouro";
            lblTotalTouro.Size = new Size(65, 30);
            lblTotalTouro.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalTouro.Location = new Point(350, (alt + 45 * (lstJuizes.Count + 1)));
            lblTotalTouro.BorderStyle = BorderStyle.FixedSingle;
            Label lblTotalCompetidor = new Label();
            lblTotalCompetidor.Name = "lblTotalCompetidor";
            lblTotalCompetidor.Size = new Size(65, 30);
            lblTotalCompetidor.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalCompetidor.Location = new Point(435, (alt + 45 * (lstJuizes.Count + 1)));
            lblTotalCompetidor.BorderStyle = BorderStyle.FixedSingle;
            Label lblTotal = new Label();
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 30);
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Location = new Point(520, alt + 45 * (lstJuizes.Count + 1));
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            Control[] controls = { lblTotalTouro, lblTotalCompetidor, lblTotal };
            this.Controls.AddRange(controls);
            //pnlPosCkb.Location = new Point(20, alt + 45 * (lstJuizes.Count + 2));
        }

        private void carregarMontaria()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldMontaria goldMontaria = contexto.GoldMontaria.Find(goldMontariaID);
            string tipo;
            if (goldMontaria.roundGold.tipo == 0)
                tipo = goldMontaria.ord + "° DUELO - ";
            else
                tipo = goldMontaria.ord + "° MONTARIA - ";
            lblTitulo.Text = tipo + goldMontaria.etapaCompetidor.apelidoCompetidor + " | " + goldMontaria.goldTouro.touro.nome;
        }

        private void btnConfirmarNota_Click(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.GoldMontaria goldMontaria = contexto.GoldMontaria.Find(goldMontariaID);
            if (verificarCampos(goldMontaria.etapaCompetidor.etapa))
            {
                if (goldMontaria.notaGold.Count > 0)
                {
                    removerNota(goldMontaria);
                }
                atribuirNota(goldMontaria);
                this.Close();
            }
            else
            {
                MessageBox.Show("É necessário atribuir a nota de todos os juízes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atribuirNota(Modelo.GoldMontaria goldMontaria)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            List<Modelo.Equipe> lstJuiz = goldMontaria.etapaCompetidor.etapa.equipe.Where(t => t.profissonal.tipoProfissonal.descricao.ToLower() == "juiz").ToList();
            for (int i = 0; i < lstJuiz.Count; i++)
            {
                Modelo.NotaGold notaGold = new Modelo.NotaGold();
                int juizID = lstJuiz[i].id;
                notaGold.juizID = juizID;
                TextBox txtNotaTouro = this.Controls.Find("txtNotaTouro" + lstJuiz[i].id, true).FirstOrDefault() as TextBox;
                notaGold.notaTouro = Convert.ToSingle(txtNotaTouro.Text);
                notaGold.goldMontariaID = goldMontaria.id;
                TextBox txtNotaCompetidor = this.Controls.Find("txtNotaCompetidor" + lstJuiz[i].id, true).FirstOrDefault() as TextBox;
                notaGold.notaCompetidor = Convert.ToSingle(txtNotaCompetidor.Text);
                contexto.NotaGold.Add(notaGold);
            }
            contexto.SaveChanges();
        }

        private void removerNota(Modelo.GoldMontaria goldMontaria)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            List<Modelo.NotaGold> lstNotaGold = goldMontaria.notaGold.ToList();
            for (int i = 0; i < lstNotaGold.Count; i++)
            {
                Modelo.NotaGold notaGold = contexto.NotaGold.Find(lstNotaGold[i].id);
                contexto.NotaGold.Remove(notaGold);
            }
            contexto.SaveChanges();
        }

        private bool verificarCampos(Modelo.Etapa etapa)
        {
            bool camposVerif = true;
            foreach (Modelo.Equipe equipe in etapa.equipe.Where(e => e.profissonal.tipoProfissonal.descricao.ToLower() == "juiz"))
            {
                TextBox txtNotaTouro = this.Controls.Find("txtNotaTouro" + equipe.id, true).FirstOrDefault() as TextBox;
                if (txtNotaTouro.Text == "")
                {
                    camposVerif = false;
                    break;
                }
                TextBox txtNotaCompetidor = this.Controls.Find("txtNotaCompetidor" + equipe.id, true).FirstOrDefault() as TextBox;
                if (txtNotaCompetidor.Text == "")
                {
                    camposVerif = false;
                    break;
                }
            }
            return camposVerif;
        }
    }
}
