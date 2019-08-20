using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SGAP.Funcoes;

namespace SGAP.Forms
{
    public partial class frmMovimento : Form
    {
        public int idAtendimento { get ; set; }

        public frmMovimento()
        {
            InitializeComponent();
        }

        public frmMovimento(int atendimento)
        {
            InitializeComponent();
            idAtendimento = atendimento; 
        }

        private void carregarGridMovimento()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from movimento in contexto.Movimento.OrderBy(movimento => movimento.id)
                        select new
                        {
                            id = movimento.id,
                            tipoAtendimentoID = movimento.tipoAtendimentoID,
                            tipoAtendimento = movimento.TipoAtendimento.descricao,
                            atendimentoID = movimento.atendimentoID,
                            numeroProcon = movimento.Atendimento.numeroProcon,                            
                            dataInicio = movimento.Atendimento.dataInicio,
                            dataEncerramento = movimento.Atendimento.dataEncerramento,
                            historico = movimento.historico,
                            resultado = movimento.resultado,                            
                            consumidorID = movimento.Atendimento.consumidorID,
                            nomeConsumidor = movimento.Atendimento.Consumidor.nome,
                            tipoReclamacaoID = movimento.Atendimento.tipoReclamacaoID,
                            tipoReclamacao = movimento.Atendimento.TipoReclamacao.descricao,
                            problemaPrincipalID = movimento.Atendimento.problemaPrincipalID,
                            problemaPrincipal = movimento.Atendimento.ProblemaPrincipal.descricao,
                            fornecedorID = movimento.Atendimento.fornecedorID,
                            fornecedor = movimento.Atendimento.Fornecedor.razaoSocial,
                            data = movimento.data
                        };
            dgvMovimento.DataSource = dados.ToList();
        }

        private void habilitaCampos(bool status)
        {
            lbNovo.Enabled = !status;
            lbEditar.Enabled = !status;
            lbRemover.Enabled = !status;
            lbSalvar.Enabled = status;
            lbCancelar.Enabled = status;

            cmbAtendimento.Enabled = false;
            cmbTipoAtendimento.Enabled = status;
            dtpData.Enabled = status;
            txtHistorico.Enabled = status;
            txtResultado.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            cmbAtendimento.Text = "";
            cmbTipoAtendimento.Text = "";
            dtpData.Text = "";
            txtHistorico.Text = "";
            txtResultado.Text = "";
        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {
            this.dgvMovimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvMovimento);
            habilitaCampos(true);            

            carregarGridMovimento();

            cmbAtendimento.DisplayMember = "numeroProcon";
            cmbAtendimento.ValueMember = "id";
            cmbAtendimento.DataSource = contexto.Atendimento.ToList();
            cmbAtendimento.SelectedValue = idAtendimento; 

            cmbTipoAtendimento.DisplayMember = "descricao";
            cmbTipoAtendimento.ValueMember = "id";
            cmbTipoAtendimento.DataSource = contexto.TipoAtendimento.ToList();
        }

        private void dgvMovimento_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMovimento.SelectedRows.Count > 0)
            {
                txtId.Text = dgvMovimento.SelectedRows[0].Cells["id"].Value.ToString();
                cmbAtendimento.SelectedValue = dgvMovimento.SelectedRows[0].Cells["atendimentoID"].Value;
                cmbTipoAtendimento.SelectedValue = dgvMovimento.SelectedRows[0].Cells["tipoAtendimentoID"].Value;
                dtpData.Text = dgvMovimento.SelectedRows[0].Cells["data"].Value.ToString();
                txtHistorico.Text = dgvMovimento.SelectedRows[0].Cells["historico"].Value.ToString();
                txtResultado.Text = dgvMovimento.SelectedRows[0].Cells["resultado"].Value.ToString();
                habilitaCampos(false);
            }
        }

        private void lbNovo_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelCorEnter(lbNovo);
        }

        private void lbNovo_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelCorLeave(lbNovo);
        }

        private void lbEditar_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelCorEnter(lbEditar);
        }

        private void lbEditar_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelCorLeave(lbEditar);
        }

        private void lbRemover_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelCorEnter(lbRemover);
        }

        private void lbRemover_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelCorLeave(lbRemover);
        }

        private void lbSalvar_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelCorEnter(lbSalvar);
        }

        private void lbSalvar_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelCorLeave(lbSalvar);
        }

        private void lbCancelar_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelCorEnter(lbCancelar);
        }

        private void lbCancelar_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelCorLeave(lbCancelar);
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            txtId.Text = "-1";
            cmbAtendimento.Focus();
        }

        private void lbEditar_Click(object sender, EventArgs e)
        {

            habilitaCampos(true);
            cmbAtendimento.Focus();
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Movimento movimento = new Modelo.Movimento();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                movimento = contexto.Movimento.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do movimento?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Movimento.Remove(movimento);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Movimento removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvMovimento.DataSource = "";
            dgvMovimento.DataSource = contexto.Movimento.ToList();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            DialogResult result;
            result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);
                Modelo.Movimento movimento = new Modelo.Movimento();

                if (id != -1)
                {
                    movimento = contexto.Movimento.Find(id);
                }
                movimento.id = id;
                movimento.atendimentoID = Convert.ToInt32(cmbAtendimento.SelectedValue);
                movimento.tipoAtendimentoID = Convert.ToInt32(cmbTipoAtendimento.SelectedValue);
                movimento.data = dtpData.Value;
                movimento.historico = txtHistorico.Text;
                movimento.resultado = txtResultado.Text;

                if (movimento.id == -1)
                    contexto.Movimento.Add(movimento);
                else
                    contexto.Entry(movimento).State = EntityState.Modified;

                contexto.SaveChanges();
                MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            habilitaCampos(false);
            dgvMovimento.DataSource = "";
            dgvMovimento.DataSource = contexto.Movimento.ToList();
            carregarGridMovimento();
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitaCampos(false);
        }

        private void lbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMovimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && lbNovo.Enabled == true)
            {
                e.SuppressKeyPress = true;
                lbNovo_Click(sender, e);
            }

            if (e.KeyCode == Keys.F2 && lbEditar.Enabled == true)
            {
                e.SuppressKeyPress = true;
                lbEditar_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3 && lbRemover.Enabled == true)
            {
                e.SuppressKeyPress = true;
                lbRemover_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4 && lbSalvar.Enabled == true)
            {
                e.SuppressKeyPress = true;
                lbSalvar_Click(sender, e);
            }

            if (e.KeyCode == Keys.F5 && lbCancelar.Enabled == true)
            {
                e.SuppressKeyPress = true;
                lbCancelar_Click(sender, e);
            }
            if (e.Alt && e.KeyCode == Keys.X)
                this.Dispose();
        }

        private void lbFechar_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelFecharCorEnter(lbFechar);
        }

        private void lbFechar_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelFecharCorLeave(lbFechar);
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from movimento in contexto.Movimento.ToList().Where(p => (p.Atendimento.Consumidor.nome.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.Atendimento.Fornecedor.razaoSocial.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = movimento.id,
                            tipoAtendimentoID = movimento.tipoAtendimentoID,
                            tipoAtendimento = movimento.TipoAtendimento.descricao,
                            atendimentoID = movimento.atendimentoID,
                            numeroProcon = movimento.Atendimento.numeroProcon,
                            dataInicio = movimento.Atendimento.dataInicio,
                            dataEncerramento = movimento.Atendimento.dataEncerramento,
                            historico = movimento.historico,
                            resultado = movimento.resultado,
                            consumidorID = movimento.Atendimento.consumidorID,
                            nomeConsumidor = movimento.Atendimento.Consumidor.nome,
                            tipoReclamacaoID = movimento.Atendimento.tipoReclamacaoID,
                            tipoReclamacao = movimento.Atendimento.TipoReclamacao.descricao,
                            problemaPrincipalID = movimento.Atendimento.problemaPrincipalID,
                            problemaPrincipal = movimento.Atendimento.ProblemaPrincipal.descricao,
                            fornecedorID = movimento.Atendimento.fornecedorID,
                            fornecedor = movimento.Atendimento.Fornecedor.razaoSocial,
                            data = movimento.data
                        };
            dgvMovimento.DataSource = "";
            dgvMovimento.DataSource = dados.ToList();
        }
    }
}
