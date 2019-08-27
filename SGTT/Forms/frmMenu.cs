using SGAP.Modelo;
using SGCRP.Forms;
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
    public partial class frmMenu : Form
    {
        public string usuario { get; set; }

        public frmMenu()
        {
            this.Hide();
            InitializeComponent();

            frmLogin login = new frmLogin(this);
            login.ShowDialog();

            this.Show();

        }

        public frmMenu(string aux)
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }             
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;

            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];
            ctlMDI.BackColor = System.Drawing.Color.White;

            tssUser.Text += usuario;

        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade formcid = new frmCidade();
            formcid.ShowDialog();
        }

        private void consumidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsumidor frmCons = new frmConsumidor();
            frmCons.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor frmForn = new frmFornecedor();
            frmForn.ShowDialog();
        }

        private void entidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntidade frmEnt = new frmEntidade();
            frmEnt.ShowDialog();
        }

        

        private void tipoReclamaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoReclamacao frmReclama = new frmTipoReclamacao();
            frmReclama.ShowDialog();
        }

        private void problemaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProblemaPrincipal frmProblema = new frmProblemaPrincipal();
            frmProblema.ShowDialog();
        }

        private void tipoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoAtendimento frmTipoAte = new frmTipoAtendimento();
            frmTipoAte.ShowDialog();
        }

        private void novoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento frmAtend = new frmAtendimento(this);
            frmAtend.MdiParent = this;
            frmAtend.Show();
        } 

        private void atendimentoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {           
            atendimentoToolStripMenuItem.ForeColor = Color.Black;            
        }

        private void atendimentoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            atendimentoToolStripMenuItem.ForeColor = Color.White;
        }

        private void cadastrosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            cadastrosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void cadastrosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            cadastrosToolStripMenuItem.ForeColor = Color.White;
        }

        private void sairToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            sairToolStripMenuItem.ForeColor = Color.Black;
        }

        private void sairToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            sairToolStripMenuItem.ForeColor = Color.White;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopiaBackup copia = new frmCopiaBackup();
            copia.ShowDialog();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestauraBackup rest = new frmRestauraBackup();
            rest.ShowDialog();
        }
    }
}
