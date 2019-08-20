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
    public partial class frmClassifTouro : Form
    {

        int roundID;

        public frmClassifTouro(int roundID)
        {
            this.roundID = roundID;
            InitializeComponent();
        }

        private void frmClassifTouro_Load(object sender, EventArgs e)
        {
            carregarComboBox();
        }


        private void carregarComboBox()
        {
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            Modelo.Round round = contexto.Round.Find(roundID);
            int qtdTouros = round.montaria.Count(n => n.touroID != null && n.notas.Count > 0 && n.pulo && n.mediaBoiada);
            if (qtdTouros > 0)
            {
                int qtd = qtdTouros % 5 == 0 ? qtdTouros / 5 : qtdTouros / 5 + 1;
                for (int i = 0; i < qtd; i++)
                {
                    cmbPosicao.Items.Add((i * 5 + 1) + "º ATÉ O " + ((i * 5 + 5) + "º"));
                }
            }
        }

        private void btnLancarTela_Click(object sender, EventArgs e)
        {
            Funcoes.Banner.bannerClassifMelhoresTouros(roundID, cmbPosicao.SelectedIndex * 5 + 1, true);
        }
    }
}
