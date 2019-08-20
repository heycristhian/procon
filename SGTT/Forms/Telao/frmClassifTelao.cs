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
    public partial class frmClassifTelao : Form
    {
        int etapaID; //A etapa ID pode ser tbm o roundID
        int pos = -4;
        bool classifEtapa; //True == etapa || false == round
        char tipo='E'; 

        public frmClassifTelao()
        {
            InitializeComponent();
            
        }

        public frmClassifTelao(int etapaID, bool classifEtapa)
        {
            InitializeComponent();
            this.etapaID = etapaID;
            this.classifEtapa = classifEtapa;
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;

        }

        public frmClassifTelao(int etapaID, bool classifEtapa, char tipo)
        {
            InitializeComponent();
            this.etapaID = etapaID;
            this.classifEtapa = classifEtapa;
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
            this.tipo = tipo;
        }

        private void frmClassifTelao_Load(object sender, EventArgs e)
        {
            if (classifEtapa)
            {
                if (tipo == 'E')
                    lblTitulo.Text = "Classificação Etapa"; 
                loadEtapa();
            }
            else
            {
                lblTitulo.Text = "Classificação Round";
                loadRound();
            }
        }

        private void loadRound()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Round round = contexto.Round.Find(this.etapaID);
            int qtd = round.montaria.Count(t => t.notas.Count > 0 && t.rep != "R" && t.pulo);
            if (qtd != 0)
            {
                qtd = qtd % 5 == 0 ? qtd / 5 : qtd / 5 + 1;
                for (int i = 0; i < qtd; i++)
                {
                    cmbPosicao.Items.Add((i * 5 + 1) + "º ATÉ O " + ((i * 5 + 5) + "º"));
                }
            }
        }

        private void loadEtapa()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Etapa etapa = contexto.Etapa.Find(etapaID);
            List<Modelo.EtapaCompetidor> lstEtapaCompetidor = etapa.etapaCompetidor.Where(t => t.montarias.Count(m => m.notas.Count > 0 && m.rep != "R" && m.pulo) > 0).ToList();
            if (lstEtapaCompetidor.Count > 0)
            {
                int qtd = lstEtapaCompetidor.Count() % 5 == 0 ? lstEtapaCompetidor.Count() / 5: lstEtapaCompetidor.Count() / 5 + 1;
                for (int i = 0; i < qtd; i++)
                {
                    cmbPosicao.Items.Add((i * 5 + 1) + "º ATÉ O " + ((i * 5 + 5) + "º"));
                }
            }
        }

        private void btnLancarTela_Click(object sender, EventArgs e)
        {
            if (this.classifEtapa)
                Funcoes.Banner.bannerClassificacaoEtapa(etapaID, true, cmbPosicao.SelectedIndex * 5 + 1);
            else
                Funcoes.Banner.bannerClassificacaoRound(etapaID, true, cmbPosicao.SelectedIndex * 5 + 1);
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            proxClick();
        }

        private void proxClick()
        {
            if (classifEtapa)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                Modelo.Etapa etapa = contexto.Etapa.Find(etapaID);
                if (pos < etapa.etapaCompetidor.Count)
                {
                    pos += 5;
                    Funcoes.Banner.bannerClassificacaoEtapa(etapaID, true, pos);
                    lblWarning.Text = "";
                }
                else
                {
                    lblWarning.Text = "Não possui página posterior";
                }
            }
            else
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                Modelo.Round round = contexto.Round.Find(etapaID);
                if (pos < round.montaria.Count(t => t.notas.Count > 0 && t.rep != "R" && t.pulo))
                {
                    pos += 5;
                    Funcoes.Banner.bannerClassificacaoRound(etapaID, true, pos);
                    lblWarning.Text = "";
                }
                else
                {
                    lblWarning.Text = "Não possui página posterior";
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            montariaAnterior();
        }

        private void montariaAnterior()
        {
            if (this.classifEtapa)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                Modelo.Etapa etapa = contexto.Etapa.Find(etapaID);
                if (pos > 6)
                {
                    pos -= 10;
                    Funcoes.Telao.gerarClassificacao(etapaID, pos);
                    lblWarning.Text = "";
                }
                else
                {
                    lblWarning.Text = "*Não possui página anterior";
                }
            }
            else
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                Modelo.Round round = contexto.Round.Find(etapaID);
                if (pos > 6)
                {
                    pos -= 10;
                    Funcoes.Telao.gerarClassificacao(etapaID, pos);
                    lblWarning.Text = "";
                }
                else
                {
                    lblWarning.Text = "*Não possui página anterior";
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
