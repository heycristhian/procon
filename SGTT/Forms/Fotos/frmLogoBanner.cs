using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCRP.Forms.Fotos
{
    public partial class frmLogoBanner : Form
    {
        public frmLogoBanner()
        {
            InitializeComponent();
        }

        private void frmLogoBanner_Load(object sender, EventArgs e)
        {
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.InitialImage = null;
            pcbLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo2.InitialImage = null;
            carregarFotoBanner();

            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;
        }

        private void carregarFotoBanner()
        {
            string logo1 = @"Banner/img/logo1.png";
            if (File.Exists(logo1))
            {
                pcbLogo.Load(logo1);
            }
            string logo2 = @"Banner/img/logo2.png";
            if (File.Exists(logo2))
            {
                pcbLogo2.Load(logo2);
            }
        }

        private void btnAltImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcbLogo.Load(openFile.FileName);
                    System.IO.File.Copy(openFile.FileName, @"Banner/img/logo1.png", true);
                    System.IO.File.Copy(openFile.FileName, @"C:/Relatorio/Telao/img/logo1.png", true);
                    pcbLogo.Load(@"Banner/img/logo1.png");
                }
                catch
                {
                    MessageBox.Show("As imagens estão sendo utilizadas em algum processo aberto do sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcbLogo2.Load(openFile.FileName);
                    System.IO.File.Copy(openFile.FileName, @"Banner/img/logo2.png", true);
                    System.IO.File.Copy(openFile.FileName, @"C:\Relatorio\Telao\img\logo2.png", true);
                    pcbLogo2.Load(@"Banner/img/logo2.png");
                }
                catch
                {
                    MessageBox.Show("As imagens estão sendo utilizadas em algum processo aberto do sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}