using SGAP.Modelo;
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
    public partial class frmLogin : Form
    {
        frmMenu menu;

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmLogin(frmMenu frmMenu)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            string aux = "verificacao";
            menu = new frmMenu(aux);
            menu = frmMenu;
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Digite seu usuário...";
            txtSenha.Text = "Digite sua senha...";
            btnLogin.Focus();
            SGAPContexto contexto = new SGAPContexto();
            List<Cidade> lstCidade = new List<Cidade>();

            lstCidade = contexto.Cidade.ToList();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Digite seu usuário...")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                txtUsuario.Text = "Digite seu usuário...";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if(txtSenha.Text == "Digite sua senha...")
            {
                txtSenha.Text = "";
                txtSenha.PasswordChar = '*';
                txtSenha.ForeColor = Color.Black;
            }
            
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                txtSenha.PasswordChar = '\0';
                txtSenha.Text = "Digite sua senha...";
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            Login login = new Login();
            SGAPContexto contexto = new SGAPContexto();
            login.usuario = txtUsuario.Text;
            login.senha = txtSenha.Text;

            Login verificaLogin = new Login();

            verificaLogin = contexto.Login.FirstOrDefault(x => x.usuario.Equals(login.usuario) && x.senha.Equals(login.senha));
            
            if(verificaLogin == null)
            {
                MessageBox.Show("O usuário ou senha são inválidos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                menu.usuario = verificaLogin.usuario;
                this.Close();                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
