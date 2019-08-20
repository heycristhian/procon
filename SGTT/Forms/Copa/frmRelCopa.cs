using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Copa
{
    public partial class frmRelCopa : Form
    {
        public frmRelCopa()
        {
            InitializeComponent();
        }

        private void frmRelCopa_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            cmbCampeonato.DisplayMember = "nome";
            cmbCampeonato.ValueMember = "id";
            cmbCopa.DisplayMember = "descr";
            cmbCopa.ValueMember = "id";
            List<Modelo.Campeonato> lstCampeonato = contexto.Campeonato.OrderByDescending(c => c.favorito).ThenByDescending(c => c.dataInicio).ToList();
            cmbCampeonato.DataSource = lstCampeonato;

            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox1.Image = img1;
            pictureBox2.Image = img2;
        }

        private void cmbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampeonato.SelectedIndex != -1)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                cmbCopa.DataSource = contexto.Campeonato.Find(Convert.ToInt32(cmbCampeonato.SelectedValue)).copas.OrderByDescending(t => t.dataInicio).ToList();
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if (cmbCampeonato.SelectedIndex > -1 && cmbCopa.SelectedIndex > -1)
            {
                int campeonatoID = Convert.ToInt32(cmbCampeonato.SelectedValue), copaID = Convert.ToInt32(cmbCopa.SelectedValue);

                switch (cmbRel.SelectedIndex)
                {
                    case 0: DialogResult result = MessageBox.Show("Deseja calcular o bônus do ultimo Round lançado?", "Calcular ultimo bônus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        Funcoes.Relatorios.rankingCopa(copaID, result == DialogResult.Yes);
                        break;
                    case 1: Funcoes.Relatorios.relPremioCopa(copaID);
                        break;
                    default: break;
                }
            }
            else
            {
                MessageBox.Show("Não é possível gerar o relatório", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
