using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Banners
{
    public partial class frmQuantidadeCompetidores : Form
    {
        int banner;
        int campeonatoID;

        public frmQuantidadeCompetidores(int banner, int campeonatoID)
        {
            this.banner = banner;
            this.campeonatoID = campeonatoID;
            InitializeComponent();
        }

        public frmQuantidadeCompetidores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int quantidade;
            if (int.TryParse(txtQuantidade.Text, out quantidade))
            {
                switch (this.banner)
                {
                    case 0:
                        Funcoes.Banner.bannerClassifRanking(campeonatoID, quantidade, false, "perfil");
                        MessageBox.Show("Banner Gerado com Sucesso!", "Banner gerado na pasta Banner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default: break;
                }
            }
            else
            {
                MessageBox.Show("É necessário informar um valor para a quantidade de Competidores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuantidadeCompetidores_Load(object sender, EventArgs e)
        {
            txtQuantidade.Text = "0";
        }
    }
}
