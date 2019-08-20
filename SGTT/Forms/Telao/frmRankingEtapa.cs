using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Telao
{
    public partial class frmRankingEtapa : Form
    {
        //0 = etapa | 1 = copa
        int eventoID;
        int tipo;

        public frmRankingEtapa(int eventoID, int tipo)
        {
            InitializeComponent();
            this.eventoID = eventoID;
            this.tipo = tipo;
        }

        private void btnLancarTela_Click(object sender, EventArgs e)
        {
            switch (this.tipo)
            {
                case 0:
                    Funcoes.Banner.bannerClassifEtapaNovo(eventoID, true, (cmbPosicao.SelectedIndex * 9) + 2);
                    break;
                default: break;
            }

        }

        private void frmRankingEtapa_Load(object sender, EventArgs e)
        {
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox1.Image = img1;
            pictureBox2.Image = img2;
            int qtdCompetidor = 0;
            switch (this.tipo)
            {
                case 0:
                    qtdCompetidor = prepararEtapa();
                    break;
                default: break;
            }
            for (int i = 0; i < qtdCompetidor / 9; i++)
            {
                cmbPosicao.Items.Add(((i * 9) + 2) + "º até a posição " + ((i * 9) + 10) + "º");                
            }
        }

        int prepararEtapa()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Etapa etapa = contexto.Etapa.Find(eventoID);
            return etapa.etapaCompetidor.Where(t => (t.ativo || t.calculo) && t.montarias.Count(m => m.notas.Count > 0 && m.rep != "R" && m.pulo) > 0).Count() - 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
