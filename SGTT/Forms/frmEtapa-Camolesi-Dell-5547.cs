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
    public partial class frmEtapa : Form
    {
        public frmEtapa()
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

            cmbCampeonato.Enabled = status;
            txtNumero.Enabled = status;
            dtpInicio.Enabled = status;
            dtpFim.Enabled = status;
            txtDescricao.Enabled = status;
            cmbCidade.Enabled = status;
            txtContratante.Enabled = status;
            txtPremio.Enabled = status;
            txtPremiados.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = string.Empty;
            cmbCampeonato.Text = "";
            txtNumero.Text = "";
            dtpInicio.Text = "";
            dtpFim.Text = "";
            txtDescricao.Text = "";
            cmbCidade.Text = "";
            txtContratante.Text = "";
            txtPremio.Text = "";
            txtPremiados.Text = "";
        }

        private void frmEtapa_Load(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            ToolModeladas.dgvTransformation(dgvEtapa);
            dgvEtapa.DataSource = "";
            dgvEtapa.DataSource = contexto.Etapa.ToList();

            cmbCampeonato.DisplayMember = "descricao";
            cmbCampeonato.ValueMember = "id";
            cmbCampeonato.DataSource = contexto.Campeonato.ToList();

            cmbCidade.DisplayMember = "nome";
            cmbCidade.ValueMember = "id";
            cmbCidade.DataSource = contexto.Cidade.ToList();

            habilitaCampos(false);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            lblId.Text = "-1";
            cmbCampeonato.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            cmbCampeonato.Focus();
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
                Modelo.Etapa etapa = new Modelo.Etapa();

                if (id != -1)
                    etapa = contexto.Etapa.Find(id);

                //popular o objeto com os valores do formulário
                etapa.id = id;
                etapa.campeonatoID = Convert.ToInt32(cmbCampeonato.SelectedValue);
                etapa.numero = Convert.ToInt32(txtNumero.Text);
                etapa.dataInicio = Convert.ToDateTime(dtpInicio.Text);
                etapa.dataFim = Convert.ToDateTime(dtpFim.Text);
                etapa.descricao = txtDescricao.Text;
                etapa.cidadeID = Convert.ToInt32(cmbCidade.SelectedValue);
                 
                etapa.contratante = Convert.ToString(txtContratante.Text);
                etapa.premio = Convert.ToSingle(txtPremio.Text);
                etapa.qtdePremiados = Convert.ToInt32(txtPremiados.Text);

                if (etapa.id == -1) // se for inserir
                    contexto.Etapa.Add(etapa);
                else  // se for editar 
                    contexto.Entry(etapa).State = EntityState.Modified;

                contexto.SaveChanges();
                MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Dados não gravado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            habilitaCampos(false);
            dgvEtapa.DataSource = "";
            dgvEtapa.DataSource = contexto.Etapa.ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitaCampos(false);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            Modelo.Etapa etapa = new Modelo.Etapa();
            if (lblId.Text == "")
                lblId.Text = "0";  //só foi feito para não dar erro qdo campo em branco. 

            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                etapa = contexto.Etapa.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção da Etapa?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Etapa.Remove(etapa);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Competidor removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não Há Registo para Remoção!!!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvEtapa.DataSource = "";
            dgvEtapa.DataSource = contexto.Etapa.ToList();
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
            List<Modelo.Etapa> lstEtapas = new List<Modelo.Etapa>();
            lstEtapas = contexto.Etapa.ToList();

            dgvEtapa.DataSource = "";
            dgvEtapa.DataSource = lstEtapas;
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Informe o ID:";
            lblMensagem.Visible = true;
            txtFiltrar.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltrar.Focus();
        }

        private void rdbPremio_CheckedChanged(object sender, EventArgs e)
        {
            lblMensagem.Text = "Informe o Premio:";
            lblMensagem.Visible = true;
            txtFiltrar.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltrar.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Modelo.SGTTContexto contexto = new Modelo.SGTTContexto();
            List<Modelo.Etapa> lstEtapas = new List<Modelo.Etapa>();

            if (rdbId.Checked)
            {
                int id = Convert.ToInt32(txtFiltrar.Text);
                Modelo.Etapa etapa = new Modelo.Etapa();
                etapa = contexto.Etapa.Find(id);
                lstEtapas.Add(etapa);
            }
            else if (rdbPremio.Checked)
            {
                int premio = Convert.ToInt32(txtFiltrar.Text);
                Modelo.Etapa etapa = new Modelo.Etapa();
                etapa = contexto.Etapa.Find(premio);
                lstEtapas.Add(etapa);
            }

            dgvEtapa.DataSource = "";
            dgvEtapa.DataSource = lstEtapas;
        }

        private void dgvEtapa_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEtapa.SelectedRows.Count > 0)
            {
                lblId.Text = dgvEtapa.SelectedRows[0].Cells["id"].Value.ToString();
                cmbCampeonato.SelectedValue = dgvEtapa.SelectedRows[0].Cells["campeonato"].Value;
                txtNumero.Text = dgvEtapa.SelectedRows[0].Cells["numero"].Value.ToString();
                dtpInicio.Text = dgvEtapa.SelectedRows[0].Cells["dataInicio"].Value.ToString();
                dtpFim.Text = dgvEtapa.SelectedRows[0].Cells["dataFim"].Value.ToString();
                txtDescricao.Text = dgvEtapa.SelectedRows[0].Cells["descricao"].Value.ToString();
                cmbCidade.SelectedValue = dgvEtapa.SelectedRows[0].Cells["cidade"].Value;
                txtContratante.Text = dgvEtapa.SelectedRows[0].Cells["contratante"].Value.ToString();
                txtPremio.Text = dgvEtapa.SelectedRows[0].Cells["premio"].Value.ToString();
                txtPremiados.Text = dgvEtapa.SelectedRows[0].Cells["qtdepremiados"].Value.ToString();
            }
        }

        private void cmbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lblIdCampeonato.Text = cmbCampeonato.SelectedValue.ToString();
        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lblIdCidade.Text = cmbCidade.SelectedValue.ToString();
        }

        private void dgvEtapa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
