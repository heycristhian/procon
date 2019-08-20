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
    public partial class frmTouroTelao : Form
    {

        int roundID;

        public frmTouroTelao()
        {
            InitializeComponent();
        }

        public frmTouroTelao(int roundID)
        {
            InitializeComponent();
           this.roundID = roundID;
        }

        private void frmTouroTelao_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Round round = contexto.Round.Find(roundID);
            int qtdTouro = round.montaria.Count(n => n.touroID != null && n.notas.Count > 0 && n.pulo && n.mediaBoiada);
            if (qtdTouro > 0)
            {
                int qtd = qtdTouro % 5 == 0 ? qtdTouro/ 5 : qtdTouro / 5 + 1;
                for (int i = 0; i < qtd; i++)
                {
                    cmbPosicao.Items.Add((i * 5 + 1) + "º ATÉ O " + ((i * 5 + 5) + "º"));
                }
            }
        }

        private void cmbPosicao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLancarTela_Click(object sender, EventArgs e)
        {
            Funcoes.Banner.bannerClassifMelhoresTouros(this.roundID,0, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
