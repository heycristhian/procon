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
using SGTT.Funcoes;

namespace SGTT.Forms
{
    public partial class frmEtapaCategoria : Form
    {
        public frmEtapaCategoria()
        {
            InitializeComponent();
        }

        private void habilitaCampos(bool status)
        {
            btnNovo.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnPesquisar.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;

            cmbEtapa.Enabled = status;
            cmbCategoria.Enabled = status;
            txtDias.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = string.Empty;
            cmbEtapa.Text = "";
            cmbCategoria.Text = "";
            txtDias.Text = "";
        }

        private void frmEtapaCategoria_Load(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            dgvEtapaCategoria.DataSource = "";
            ToolModeladas.dgvTransformation(dgvEtapaCategoria);
            dgvEtapaCategoria.DataSource = contexto.EtapaCategoria.ToList();

            cmbEtapa.DisplayMember = "id";
            cmbEtapa.SelectedValue = "etapa";
            cmbEtapa.DataSource = contexto.Etapa.ToList();

            cmbCategoria.DisplayMember = "id";
            cmbCategoria.SelectedValue = "categoria";
            cmbCategoria.DataSource = contexto.Categoria.ToList();

            habilitaCampos(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            lblId.Text = "-1";
            cmbEtapa.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            cmbEtapa.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            DialogResult result;
            result = MessageBox.Show("Confirma Gravação?", "Salvar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {


                int id = Convert.ToInt32(lblId.Text);
                Modelo.EtapaCategoria etapacategoria = new Modelo.EtapaCategoria();

                if (id != -1)
                    etapacategoria = contexto.EtapaCategoria.Find(id);

                //popular o objeto com os valores do formulário
                etapacategoria.id = id;
                etapacategoria.etapaID = Convert.ToInt32(cmbEtapa.SelectedValue);
                etapacategoria.categoriaID = Convert.ToInt32(cmbCategoria.SelectedValue);
                etapacategoria.numdias = Convert.ToInt32(txtDias.Text);

                if (etapacategoria.id == -1) // se for inserir
                    contexto.EtapaCategoria.Add(etapacategoria);
                else  // se for editar 
                    contexto.Entry(etapacategoria).State = EntityState.Modified;

                contexto.SaveChanges();
                MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Dados não gravado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            habilitaCampos(false);
            dgvEtapaCategoria.DataSource = "";
            dgvEtapaCategoria.DataSource = contexto.EtapaCategoria.ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitaCampos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            Modelo.EtapaCategoria etapacategoria = new Modelo.EtapaCategoria();
            if (lblId.Text == "")
                lblId.Text = "0";  //só foi feito para não dar erro qdo campo em branco. 

            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                etapacategoria = contexto.EtapaCategoria.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção da Etapa da Categoria?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.EtapaCategoria.Remove(etapacategoria);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Competidor removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não Há Registo para Remoção!!!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvEtapaCategoria.DataSource = "";
            dgvEtapaCategoria.DataSource = contexto.EtapaCategoria.ToList();
            limparCampos();
            habilitaCampos(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbFiltrar.Visible = !gpbFiltrar.Visible;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
            txtFiltrar.Visible = false;
            btnFiltrar.Visible = false;

            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            List<Modelo.EtapaCategoria> lstEtapasCategoria = new List<Modelo.EtapaCategoria>();
            lstEtapasCategoria = contexto.EtapaCategoria.ToList();

            dgvEtapaCategoria.DataSource = "";
            dgvEtapaCategoria.DataSource = lstEtapasCategoria;
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Informe o ID:";
            lblMensagem.Visible = true;
            txtFiltrar.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltrar.Focus();
        }

        private void rdbEtapa_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Informe a Etapa:";
            lblMensagem.Visible = true;
            txtFiltrar.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltrar.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            List<Modelo.EtapaCategoria> lstEtapasCategoria = new List<Modelo.EtapaCategoria>();

            if (rdbId.Checked)
            {
                int id = Convert.ToInt32(txtFiltrar.Text);
                Modelo.EtapaCategoria etapacategoria = new Modelo.EtapaCategoria();
                etapacategoria = contexto.EtapaCategoria.Find(id);
                lstEtapasCategoria.Add(etapacategoria);
            }
            else if (rdbEtapa.Checked)
            {
                int etapa = Convert.ToInt32(txtFiltrar.Text);
                Modelo.EtapaCategoria etapacategoria = new Modelo.EtapaCategoria();
                etapacategoria = contexto.EtapaCategoria.Find(etapacategoria);
               
                lstEtapasCategoria.Add(etapacategoria);
            }

            dgvEtapaCategoria.DataSource = "";
            dgvEtapaCategoria.DataSource = lstEtapasCategoria;
        }

        private void dgvEtapaCategoria_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEtapaCategoria.SelectedRows.Count > 0)
            {
                lblId.Text = dgvEtapaCategoria.SelectedRows[0].Cells["id"].Value.ToString();
                cmbEtapa.Text = dgvEtapaCategoria.SelectedRows[0].Cells["etapa"].ToString();
                cmbCategoria.Text = dgvEtapaCategoria.SelectedRows[0].Cells["categoria"].ToString();
                txtDias.Text = dgvEtapaCategoria.SelectedRows[0].Cells["numdias"].Value.ToString();
            }
        }
    }
}
