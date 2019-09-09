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
    public partial class frmTipoAtendimento : Form
    {
        public frmTipoAtendimento()
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

            txtDescricao.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtDescricao.Text = "";
        }

        private void carregarGridTipoAtendimento()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from tipoAtendimento in contexto.TipoAtendimento.OrderBy(tipoAtendimento => tipoAtendimento.descricao)
                        select new
                        {
                            id = tipoAtendimento.id,
                            descricao = tipoAtendimento.descricao
                        };

            dgvTipoAtendimento.DataSource = dados.ToList();
        }

        private void frmTipoAtendimento_Load(object sender, EventArgs e)
        {
            this.dgvTipoAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            habilitaCampos(false);

            ToolModeladas.dgvTransformation(dgvTipoAtendimento);
            carregarGridTipoAtendimento();

            dgvTipoAtendimento.DataSource = "";
            dgvTipoAtendimento.DataSource = contexto.TipoAtendimento.ToList();
        }

        private void dgvTipoAtendimento_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTipoAtendimento.SelectedRows.Count > 0)
            {
                txtId.Text = dgvTipoAtendimento.SelectedRows[0].Cells["id"].Value.ToString();
                txtDescricao.Text = dgvTipoAtendimento.SelectedRows[0].Cells["descricao"].Value.ToString();
                habilitaCampos(false);
            }
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            txtId.Text = "-1";
            txtDescricao.Focus();
        }

        private void lbEditar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text == "")
            {
                FuncGeral.messageBoxEditar();
            }
            else
            {
                habilitaCampos(true);
                txtDescricao.Focus();
            }            
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.TipoAtendimento tipoAtendimento = new Modelo.TipoAtendimento();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                tipoAtendimento = contexto.TipoAtendimento.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do tipo de atendimento?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.TipoAtendimento.Remove(tipoAtendimento);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Tipo de atendimento removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvTipoAtendimento.DataSource = "";
            dgvTipoAtendimento.DataSource = contexto.TipoAtendimento.ToList();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                DialogResult result;
                result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Modelo.TipoAtendimento tipoAtendimento = new Modelo.TipoAtendimento();

                    if (id != -1)
                    {
                        tipoAtendimento = contexto.TipoAtendimento.Find(id);

                    }
                    tipoAtendimento.id = id;
                    tipoAtendimento.descricao = txtDescricao.Text;

                    if (tipoAtendimento.id == -1)
                    {
                        bool teste = contexto.TipoAtendimento.ToList().Exists(p => p.descricao.ToLower().RemoveDiacritics().Equals(txtDescricao.Text.ToLower().RemoveDiacritics().Trim()));
                        if (teste)
                        {
                            MessageBox.Show("Tipo de atendimento já cadastrada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDescricao.Focus();
                        }
                        else
                        {
                            contexto.TipoAtendimento.Add(tipoAtendimento);
                            contexto.SaveChanges();                            
                            limparCampos();
                            habilitaCampos(false);

                            MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        contexto.Entry(tipoAtendimento).State = EntityState.Modified;
                        contexto.SaveChanges();
                        habilitaCampos(false);
                        MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                carregarGridTipoAtendimento();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("O campo Descrição é obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from tipoAtendimento in contexto.TipoAtendimento.ToList().Where(p => (p.descricao.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = tipoAtendimento.id,
                            descricao = tipoAtendimento.descricao
                        };
            dgvTipoAtendimento.DataSource = "";
            dgvTipoAtendimento.DataSource = dados.ToList();
        }

        private void frmTipoAtendimento_KeyDown(object sender, KeyEventArgs e)
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
    }
}
