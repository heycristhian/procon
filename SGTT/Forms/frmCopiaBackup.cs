
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.IO;
using SGAP.Modelo;

namespace SGCRP.Forms
{
    public partial class frmCopiaBackup : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public frmCopiaBackup()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        
        public void ChooseFolder()
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
            }
        }



        private void frmCopiaBackup_Load(object sender, EventArgs e)
        {
            SGAPContexto contexto = new SGAPContexto();
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
            fbd.SelectedPath = folder;
            txtPath.Text = folder;

            DateTime data = DateTime.Today;
            txtNomeArquivo.Text = "BACKUP_" + "PROCON" + "_" + data.Day + "." + data.Month + "." + data.Year;


        }

        private void enviarEmail(string end)
        {/*
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 25;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("simpletechnologyassis@gmail.com", "#573ch#2016");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("simpletechnologyassis@gmail.com", "carlos");
            mail.From = new MailAddress("simpletechnologyassis@gmail.com");
            mail.To.Add(new MailAddress("simpletechnologyassis@gmail.com"));
            mail.Subject = "Dados";
            //mail.Attachments.Add(new Attachment(end));
            mail.Body = "DADOS CRP";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch
            {
                MessageBox.Show("ERRO");
            }
            finally
            {
                mail = null;
            }*/
        }

        private void picPath_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void picDone_MouseEnter(object sender, EventArgs e)
        {
            picDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
        }

        private void picDone_MouseLeave(object sender, EventArgs e)
        {
            picDone.BackColor = Color.White;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picDone_Click(object sender, EventArgs e)
        {
            
            if (txtNomeArquivo.Text != "")
            {
                if (txtPath.Text != "")
                {
                    string arquivo = txtPath.Text + "\\" + txtNomeArquivo.Text + ".sql";
                    string comando = (@"@C:\xampp\mysql\bin\mysqldump  -uroot --add-drop-database --database sgap > " + arquivo);
                    if(File.Exists(arquivo))
                    {
                        DialogResult result; 
                        result = MessageBox.Show("Arquivo já existe! Deseja sobrescrever?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if(result == DialogResult.Yes)
                        {
                            using (Process processo = new Process())
                            {
                                processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");

                                // Formata a string para passar como argumento para o cmd.exe
                                processo.StartInfo.Arguments = string.Format("/c {0}", comando);

                                processo.StartInfo.RedirectStandardOutput = true;
                                processo.StartInfo.UseShellExecute = false;
                                processo.StartInfo.CreateNoWindow = true;
                                processo.Start();
                                processo.WaitForExit();
                                MessageBox.Show("Cópia dos dados gerado com sucesso.", "Cópia gerada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        using (Process processo = new Process())
                        {
                            processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");

                            // Formata a string para passar como argumento para o cmd.exe
                            processo.StartInfo.Arguments = string.Format("/c {0}", comando);

                            processo.StartInfo.RedirectStandardOutput = true;
                            processo.StartInfo.UseShellExecute = false;
                            processo.StartInfo.CreateNoWindow = true;
                            processo.Start();
                            processo.WaitForExit();
                            MessageBox.Show("Cópia dos dados gerado com sucesso.", "Cópia gerada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    
                    enviarEmail(arquivo);
                }
                else
                {
                    MessageBox.Show("É necessário informar o local do arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }

            }
            else
            {
                MessageBox.Show("É necessário informar o nome do arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }
    }
}