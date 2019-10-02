using SGAP.Funcoes;
using SGAP.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGAP.Forms
{
    public partial class frmAndamentos : Form
    {
        frmAtendimento frmAtendimento = new frmAtendimento();

        public frmAndamentos()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmAndamentos(frmAtendimento atendimento)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmAtendimento = atendimento;
        }

        private void frmAndamentos_Load(object sender, EventArgs e)
        {
            ToolModeladas.dgvTransformation(dgvAndamentos);
            this.dgvAndamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carregaGrid(Convert.ToInt32(frmAtendimento.txtId.Text));
            dgvAndamentos.Height += 67;
            int medida1 = Convert.ToInt32(dgvAndamentos.Location.X.ToString());
            int medida2 = Convert.ToInt32(dgvAndamentos.Location.Y.ToString());
            this.dgvAndamentos.Location = new System.Drawing.Point(medida1, (medida2 - 67));
            limparCampos();

        }

        private void carregaGrid(int id)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from andamento in contexto.Andamento.Where(x => x.atendimentoID == id).OrderByDescending(x => x.data)
                        select new
                        {
                            id = andamento.id,
                            descricao = andamento.descricao,
                            data = andamento.data,
                            atendimentoID = andamento.atendimentoID,
                            atendimento = andamento.Atendimento.numeroProcon,
                            prazo = andamento.prazo
                        };
            dgvAndamentos.DataSource = dados.ToList();
        }

        private void redimensionarGride()
        {
            txtAndamento.Visible = !txtAndamento.Visible;
            dtpPrazo.Visible = !dtpPrazo.Visible;
            lblPrazo.Visible = !lblPrazo.Visible;
            lblAndamento.Visible = !lblAndamento.Visible;
            btnLimpar.Visible = !btnLimpar.Visible;


            if (txtAndamento.Visible)
            {
                dgvAndamentos.Height -= 67;
                int medida1 = Convert.ToInt32(dgvAndamentos.Location.X.ToString());
                int medida2 = Convert.ToInt32(dgvAndamentos.Location.Y.ToString());
                this.dgvAndamentos.Location = new System.Drawing.Point(medida1, (medida2 + 67));                
            }
            else
            {
                dgvAndamentos.Height += 67;
                int medida1 = Convert.ToInt32(dgvAndamentos.Location.X.ToString());
                int medida2 = Convert.ToInt32(dgvAndamentos.Location.Y.ToString());
                this.dgvAndamentos.Location = new System.Drawing.Point(medida1, (medida2 - 67));                
            }
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtAndamento.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            redimensionarGride();

            if (txtAndamento.Visible)
            {
                limparCampos();
            }

            btnEditar.Enabled = !btnEditar.Enabled;
            btnRemover.Enabled = !btnRemover.Enabled;


            txtAndamento.Focus();

            //aqui que salva no banco
            if (txtAndamento.Text != "")
            {
                SGAPContexto contexto = new SGAPContexto();
                Andamento andamento = new Andamento();

                andamento.descricao = txtAndamento.Text;
                andamento.data = DateTime.Now;
                andamento.atendimentoID = Convert.ToInt32(frmAtendimento.txtId.Text);
                try
                {
                    if (dtpPrazo.Text == "  /  /")
                    {
                        andamento.prazo = null;
                    }
                    else
                    {
                        andamento.prazo = Convert.ToDateTime(dtpPrazo.Text);
                    }
                }
                catch (System.FormatException)
                {
                    andamento.prazo = null;
                }

                contexto.Andamento.Add(andamento);
                contexto.SaveChanges();
                carregaGrid(andamento.atendimentoID);

                MessageBox.Show("Andamento incluído com sucesso", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            redimensionarGride();

            btnAdicionar.Enabled = true;
            btnRemover.Enabled = true;
            btnEditar.Enabled = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                redimensionarGride();
                btnAdicionar.Enabled = !btnAdicionar.Enabled;
                btnRemover.Enabled = !btnRemover.Enabled;

                if (txtAndamento.Visible == false)
                {
                    SGAPContexto contexto = new SGAPContexto();
                    Andamento andamento = new Andamento();

                    andamento.id = Convert.ToInt32(txtId.Text);
                    andamento.descricao = txtAndamento.Text;
                    andamento.data = Convert.ToDateTime(dgvAndamentos.SelectedRows[0].Cells["data"].Value.ToString());
                    andamento.atendimentoID = Convert.ToInt32(dgvAndamentos.SelectedRows[0].Cells["atendimentoID"].Value.ToString());
                    try
                    {
                        if (dtpPrazo.Text == "  /  /")
                        {
                            andamento.prazo = null;
                        }
                        else
                        {
                            andamento.prazo = Convert.ToDateTime(dtpPrazo.Text);
                        }
                    }
                    catch (System.FormatException)
                    {
                        andamento.prazo = null;
                    }



                    contexto.Entry(andamento).State = EntityState.Modified;
                    contexto.SaveChanges();
                    carregaGrid(andamento.atendimentoID);
                    MessageBox.Show("Andamento editado com sucesso", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                else
                {
                    txtAndamento.Select(txtAndamento.Text.Length, 0);
                    txtAndamento.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro foi selecionado para edição", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvAndamentos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAndamentos.SelectedRows.Count > 0)
            {
                txtId.Text = dgvAndamentos.SelectedRows[0].Cells["id"].Value.ToString();
                txtAndamento.Text = dgvAndamentos.SelectedRows[0].Cells["descricao"].Value.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Andamento andamento = new Modelo.Andamento();


            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                andamento = contexto.Andamento.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do atendimento?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Andamento.Remove(andamento);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Atendimento removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Nenhum registro foi selecionado para remoção", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            carregaGrid(Convert.ToInt32(frmAtendimento.txtId.Text));

            limparCampos();
        }

        private void frmAndamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnAdicionar.Enabled == true)
            {
                e.SuppressKeyPress = true;
                btnAdicionar_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2 && btnEditar.Enabled == true)
            {
                e.SuppressKeyPress = true;
                btnEditar_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3 && btnRemover.Enabled == true)
            {
                e.SuppressKeyPress = true;
                btnRemover_Click(sender, e);
            }

            if (e.Alt && e.KeyCode == Keys.X)
                this.Dispose();
        }

        private void informacoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
