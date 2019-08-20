using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Copa
{
    public partial class frmBannerTelao : Form
    {

        List<Modelo.CopaCompetidor> lstCopaCompetidor = new List<Modelo.CopaCompetidor>();
        int copaID;
        int etapaID;
        bool calcUltRound; 
        public frmBannerTelao()
        {
            InitializeComponent();
        }

        public frmBannerTelao(int copaID, int etapaID, bool calcUltRound)
        {
            this.copaID = copaID;
            this.etapaID = etapaID;
            this.calcUltRound = calcUltRound;
            InitializeComponent();
        }

        private void frmBannerTelao_Load(object sender, EventArgs e)
        {
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox1.Image = img1;
            pictureBox2.Image = img2;
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Copa copa = contexto.Copa.Find(4);
            lstCopaCompetidor = copa.getCompetidores(false);
            //Modelo.Copa copa = contexto.Copa.Find(copaID);
            //Funcoes.finalizarRound.calculoBonus(this.etapaID, false);
            //lstCopaCompetidor = copa.getCompetidores(this.calcUltRound);
            difRanking();
            int qtdBanners = lstCopaCompetidor.Count % 5 == 0 ? lstCopaCompetidor.Count / 5 : lstCopaCompetidor.Count / 5 + 1;
            for (int i = 0; i < qtdBanners - 1; i++)
            {
                cmbPosicao.Items.Add((i * 5 + 1) + "º ATÉ O " + ((i * 5 + 5) + "º"));
            }
        }

        private void btnLancarNota_Click(object sender, EventArgs e)
        {
            if (cmbPosicao.SelectedIndex > -1)
            {
                int pos = cmbPosicao.SelectedIndex * 5 + 1;
                Funcoes.Banner.bannerClassificacaoCopa(this.etapaID, this.copaID, lstCopaCompetidor.GetRange(pos - 1, 5), pos,true, true);
            }
        }

        private void difRanking()
        {
            for (int i = 1; i < lstCopaCompetidor.Count; i++)
            {
                lstCopaCompetidor[i].pontos = lstCopaCompetidor[0].pontos - lstCopaCompetidor[i].pontos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
