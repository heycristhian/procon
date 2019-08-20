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
    public partial class frmRankTelao : Form
    {
        int campeonatoID;

        public frmRankTelao(int campeonatoID)
        {
            InitializeComponent();
            this.campeonatoID = campeonatoID;
        }

        private void frmRankTelao_Load(object sender, EventArgs e)
        {
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox1.Image = img1;
            pictureBox2.Image = img2;

            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            int qtdCompetidor = contexto.Campeonato.Find(campeonatoID).campeonatoCompetidor.Count - 1;
            for (int i = 0; i < qtdCompetidor / 4; i++)
            {
                cmbPos.Items.Add(((i * 4) + 2) + "º até a posição " + ((i * 4) + 5) + "º");
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Funcoes.Banner.bannerClassifRanking(this.campeonatoID, (cmbPos.SelectedIndex * 4) + 2, true, (cmbTipoFoto.SelectedIndex == 0 ? "frente" : "perfil"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
