using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Fotos
{
    public partial class frmRelCompSemFoto : Form
    {
        public frmRelCompSemFoto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelCompSemFoto_Load(object sender, EventArgs e)
        {
            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            cmbCampeonato.DisplayMember = "nome";
            cmbCampeonato.ValueMember = "id";
            cmbCampeonato.DataSource = contexto.Campeonato.OrderByDescending(c => c.favorito).ThenByDescending(c => c.dataInicio).ToList();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (cmbCampeonato.SelectedIndex != -1)
            {
                Funcoes.Relatorios.relatorioCompetidoresSemFoto(Convert.ToInt32(cmbCampeonato.SelectedValue));
            }
        }
    }
}
