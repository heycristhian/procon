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
    public partial class frmClassifTropeiros : Form
    {

        int etapaID;

        public frmClassifTropeiros(int etapaID)
        {
            InitializeComponent();
            this.etapaID = etapaID;
        }

        private void frmClassifTropeiros_Load(object sender, EventArgs e)
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Etapa etapa = contexto.Etapa.Find(etapaID);
            int qtdTropeiro = etapa.qtdTropeiro;
            if (qtdTropeiro > 0)
            {
                int qtd = qtdTropeiro % 5 == 0 ? qtdTropeiro / 5 : qtdTropeiro / 5 + 1;
                for (int i = 0; i < qtd; i++)
                {
                    cmbPosicao.Items.Add((i * 5 + 1) + "º ATÉ O " + ((i * 5 + 5) + "º"));
                }
            }
        }

        private void btnLancarTela_Click(object sender, EventArgs e)
        {
            Funcoes.Banner.bannerClassifTropeiros(etapaID, cmbPosicao.SelectedIndex * 5 + 1, true);
   
        }
    }
}
