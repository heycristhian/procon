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
    public partial class frmEncaminhamento : Form
    {
        public frmEncaminhamento()
        {
            InitializeComponent();
        }

        private void habilitaCampos(bool status)
        {
            lbNovo.Enabled = !status;
            lbEditar.Enabled = !status;
            lbRemover.Enabled = !status;
            lbSalvar.Enabled = status;
            lbCancelar.Enabled = status;

            cmbMovimento.Enabled = status;
            cmbEntidade.Enabled = status;
            txtObs.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            cmbMovimento.Text = "";
            cmbEntidade.Text = "";
            txtObs.Text = "";
        }

        private void carregarGridEcaminhamento()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from encaminhamento in contexto.Encaminhamento.OrderBy(encaminhamento => encaminhamento.id)
                        select new
                        {
                            id = encaminhamento.id,
                            movimentoID = encaminhamento.movimentoID,
                            movimento = encaminhamento.Movimento.id,
                            entidadeID = encaminhamento.entidadeID,
                            entidade = encaminhamento.Entidade.nome,
                            obs = encaminhamento.obs
                        };
            dgvEncaminhamento.DataSource = dados.ToList();
        }

        private void frmEncaminhamento_Load(object sender, EventArgs e)
        {
            this.dgvEncaminhamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            habilitaCampos(false);
            ToolModeladas.dgvTransformation(dgvEncaminhamento);

            carregarGridEcaminhamento();

            cmbMovimento.DisplayMember = "numeroProcon";
            cmbMovimento.ValueMember = "id";
            cmbMovimento.DataSource = contexto.Atendimento.ToList();

            cmbEntidade.DisplayMember = "nome";
            cmbEntidade.ValueMember = "id";
            cmbEntidade.DataSource = contexto.Entidade.ToList();
        }

        private void dgvEncaminhamento_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEncaminhamento.SelectedRows.Count > 0)
            {
                txtId.Text = dgvEncaminhamento.SelectedRows[0].Cells["id"].Value.ToString();
                cmbMovimento.SelectedValue = dgvEncaminhamento.SelectedRows[0].Cells["movimentoID"].Value;
                cmbEntidade.SelectedValue = dgvEncaminhamento.SelectedRows[0].Cells["entidadeID"].Value;
                txtObs.Text = dgvEncaminhamento.SelectedRows[0].Cells["obs"].Value.ToString();
                habilitaCampos(false);
            }
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            txtId.Text = "-1";
            cmbMovimento.Focus();
        }

        private void lbEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            cmbMovimento.Focus();
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Encaminhamento encaminhamento = new Modelo.Encaminhamento();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                encaminhamento = contexto.Encaminhamento.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do encaminhamento?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Encaminhamento.Remove(encaminhamento);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Encaminhamento removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvEncaminhamento.DataSource = "";
            dgvEncaminhamento.DataSource = contexto.Encaminhamento.ToList();
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
                Modelo.Encaminhamento encaminhamento = new Modelo.Encaminhamento();

                if (id != -1)
                {
                    encaminhamento = contexto.Encaminhamento.Find(id);
                }
                encaminhamento.id = id;
                encaminhamento.movimentoID = Convert.ToInt32(cmbMovimento.SelectedValue);
                encaminhamento.entidadeID = Convert.ToInt32(cmbEntidade.SelectedValue);
                encaminhamento.obs = txtObs.Text;

                if (encaminhamento.id == -1)
                    contexto.Encaminhamento.Add(encaminhamento);
                else
                    contexto.Entry(encaminhamento).State = EntityState.Modified;

                contexto.SaveChanges();
                MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            habilitaCampos(false);
            dgvEncaminhamento.DataSource = "";
            dgvEncaminhamento.DataSource = contexto.Atendimento.ToList();
            carregarGridEcaminhamento();
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

        private void frmEncaminhamento_KeyDown(object sender, KeyEventArgs e)
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
            List<Modelo.Encaminhamento> lstEncaminhamento = new List<Modelo.Encaminhamento>();
            var dados = from encaminhamento in contexto.Encaminhamento.ToList().Where(p => (p.obs.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = encaminhamento.id,
                            movimentoID = encaminhamento.movimentoID,
                            movimento = encaminhamento.Movimento.id,
                            entidadeID = encaminhamento.entidadeID,
                            entidade = encaminhamento.Entidade.nome,
                            obs = encaminhamento.obs
                        };
            dgvEncaminhamento.DataSource = "";
            dgvEncaminhamento.DataSource = dados.ToList();
        }
    }
}
