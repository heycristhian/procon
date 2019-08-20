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
    public partial class frmMelhoresMontariaEmpate : Form
    {
        List<Modelo.Montaria> lstMontaria = new List<Modelo.Montaria>();


        public frmMelhoresMontariaEmpate(List<Modelo.Montaria> lstMontaria)
        {
            InitializeComponent();
            this.lstMontaria = lstMontaria;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMelhoresMontariaEmpate_Load(object sender, EventArgs e)
        {
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            cmbMontariasEmpatadas.DataSource = lstMontaria.ToList();
            cmbMontariasEmpatadas.ValueMember = "id";
            cmbMontariasEmpatadas.DisplayMember = "mostrarNome";
        }

        private void btnLancarTela_Click(object sender, EventArgs e)
        {
            if (cmbMontariasEmpatadas.SelectedIndex > -1)
            {
                Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
                Modelo.Montaria montaria = contexto.Montaria.Find(Convert.ToInt32(cmbMontariasEmpatadas.SelectedValue));
                Funcoes.Banner.bannerMelhorMontariaRound(montaria.roundID, montaria.id, true);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
