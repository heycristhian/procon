using SGCRP.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SGCRP.Forms.Fotos
{
    public partial class frmCadastroFotoCompetidor : Form
    {
        public frmCadastroFotoCompetidor()
        {
            InitializeComponent();
        }

        private void frmCadastroFotoCompetidor_Load(object sender, EventArgs e)
        {
            cmbCompetidor.ValueMember = "id";
            cmbCompetidor.DisplayMember = "apelido";
            Modelo.SGCRPContexto contexto = new Modelo.SGCRPContexto();
            List<Modelo.Competidor> lstCompetidor = contexto.Competidor.Where(t => t.apelido != "").ToList();
            atualizarComboBox(lstCompetidor);
            cmbCompetidor.SelectedIndex = -1;
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.InitialImage = null;

            Bitmap img1 = new Bitmap(@".\Logos\logo1.png");
            Bitmap img2 = new Bitmap(@".\Logos\logo2.png");
            pictureBox2.Image = img1;
            pictureBox1.Image = img2;


        }

     

        private void verifCampos()
        {
            if (cmbCompetidor.SelectedIndex > -1 && cmbTipoFoto.SelectedIndex > -1)
            {
                btnAltImagem.Visible = true;
                carregarFoto();
            }
        }

        private void carregarFoto()
        {
            switch (cmbTipoFoto.SelectedIndex)
            {
                case 0:
                    carregrFotoTipo("frente");
                    break;
                case 1:
                    carregrFotoTipo("perfil");
                    break;
                default: break;
            }
        }

        private void carregrFotoTipo(string tipo)
        {
            string arq = @"Banner\img\" + tipo + @"\" + Convert.ToInt32(cmbCompetidor.SelectedValue) + ".png";
            if (File.Exists(arq))
            {
                statusFotos(true);
                pcbFoto.Load(arq);
            }
            else
            {
                statusFotos(false);
            }
        }

        private void statusFotos(bool exist)
        {
            pcbFoto.Visible = exist;
            if (exist)
            {
                btnAltImagem.Text = "Alterar Imagem";
                btnExcluir.Visible = true;
                btnAltImagem.Location = new Point(524, 536);
            }
            else
            {
                btnAltImagem.Text = "Adicionar Imagem";
                btnExcluir.Visible = false;
                btnAltImagem.Location = new Point(824, 195);
            }
        }

        private void cmbCompetidor_SelectedValueChanged(object sender, EventArgs e)
        {
            verifCampos();
        }

        private void cmbTipoFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifCampos();
        }

        private void btnAltImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string tipo = "";
                switch (cmbTipoFoto.SelectedIndex)
                {
                    case 0: tipo = "frente";
                        break;
                    case 1: tipo = "perfil";
                        break;
                    default: break;
                }
                pcbFoto.Load(openFile.FileName);
                System.IO.File.Copy(openFile.FileName, @"Banner\img\" + tipo +@"\" + Convert.ToInt32(cmbCompetidor.SelectedValue) + ".png", true);
                pcbFoto.Load(@"Banner\img\" + tipo + @"\" + Convert.ToInt32(cmbCompetidor.SelectedValue) + ".png");
                statusFotos(true);
            }
        }

        private void pcbFoto_Paint(object sender, PaintEventArgs e)
        {
        }

        public void Draw(Graphics g, ref List<double> arr)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompetidoresSemFoto_Click(object sender, EventArgs e)
        {
            frmRelCompSemFoto frmRelComp = new frmRelCompSemFoto();
            frmRelComp.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você deseja Remover a Imagem do Competidor?", "Remover Imagem", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
            {
                string tipo = "";
                switch (cmbTipoFoto.SelectedIndex)
                {
                    case 0:
                        tipo = "frente";
                        break;
                    case 1:
                        tipo = "perfil";
                        break;
                    default: break;
                }
                System.IO.File.Delete(@"Banner\img\" + tipo + @"\" + Convert.ToInt32(cmbCompetidor.SelectedValue));
                statusFotos(false);
                
            }
        }
    }
}
