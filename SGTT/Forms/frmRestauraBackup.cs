using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Forms
{
    public partial class frmRestauraBackup : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();

        public frmRestauraBackup()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void frmRestauraBackup_Load(object sender, EventArgs e)
        {
            ofd.Filter = "Arquivos SQL|*.sql";
            ofd.Title = "Selecione um arquivo de dados";
            string folder = @"C:\Relatorio\";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            folder += "Copia";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            ofd.InitialDirectory = folder;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDone_MouseEnter(object sender, EventArgs e)
        {
            picDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
        }

        private void picDone_MouseLeave(object sender, EventArgs e)
        {
            picDone.BackColor = Color.White;
        }

        private void picPath_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
            }
        }

        private void picDone_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Todos os dados serão substituidos! Tem certeza que deseja restaurar os dados?", "Restaurar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2))
                {
                    pbStatus.Visible = true;
                    string arquivo = txtPath.Text;
                    string comando = (@"C:\xampp\mysql\bin\mysql -uroot < " + arquivo);
                    using (Process processo = new Process())
                    {
                        picDone.Visible = false;
                        processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");
                        processo.StartInfo.Arguments = string.Format("/c {0}", comando);
                        processo.StartInfo.RedirectStandardOutput = true;
                        processo.StartInfo.UseShellExecute = false;
                        processo.StartInfo.CreateNoWindow = true;
                        processo.Start();
                        processo.WaitForExit();
                        pbStatus.Value = 100;
                        lbStatus.Visible = true;
                        MessageBox.Show("Dados restaurados com sucesso.", "Dados restaurados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um arquivo SQL para restaurar os dados.", "Erro ao Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                lblFile.ForeColor = Color.Red;
                FileInfo file = new FileInfo(txtPath.Text);
                DateTime dt = file.CreationTime;
                lblFile.Text = "Este arquivo foi gerado na data " + dt.Day + "/" + dt.Month.ToString("00") + "/" + dt.Year + " (" + dt.Hour + ":" + dt.Minute.ToString("00") + ")";
            }
            else
            {
                lblFile.Text = "";
            }
        }
    }
}
