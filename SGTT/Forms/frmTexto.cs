using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Forms
{
    public partial class frmTexto : Form
    {
        public string descricao { get; set; }
        frmAtendimento frmAtendimento = new frmAtendimento();

        public frmTexto()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmTexto(string descricaoTexto, frmAtendimento atendimento)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            descricao = descricaoTexto;
            frmAtendimento = atendimento;
            txtDescricao.Text = descricaoTexto;
            txtDescricao.Select(txtDescricao.Text.Length, 0);
        }

        private void frmTexto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbMovimentar_MouseEnter(object sender, EventArgs e)
        {
            lblFeito.BackColor = Color.FromArgb(0, 89, 168);
            lblFeito.ForeColor = Color.White;
        }

        private void lbMovimentar_MouseLeave(object sender, EventArgs e)
        {
            lblFeito.BackColor = Color.FromArgb(133, 203, 248);
            lblFeito.ForeColor = Color.Black;
        }

        private void lblFeito_Click(object sender, EventArgs e)
        {
            frmAtendimento.descricao = txtDescricao.Text;
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
