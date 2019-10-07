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
    public partial class frmEntidade : Form
    {
        public frmEntidade()
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

            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            cmbCidade.Enabled = status;
            txtCep.Enabled = status;
            txtTelefone.Enabled = status;
            txtCelular.Enabled = status;
            txtWhats.Enabled = status;
            txtEmail.Enabled = status;
            txtSite.Enabled = status;
            txtContato.Enabled = status;
            picAdd.Visible = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            cmbCidade.Text = "";
            txtCep.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtWhats.Text = "";
            txtEmail.Text = "";
            txtSite.Text = "";
            txtContato.Text = "";
        }

        private int validarTextBox()
        {            
            int sentinela = 0;
            if (txtNome.Text == "")
                sentinela++;
            if (FuncGeral.tratamentoCep(txtCep) == false)
                sentinela++;
            if (FuncGeral.tratamentoTel(txtTelefone) == false)
                sentinela++;
            if (FuncGeral.tratamentoTel(txtCelular) == false)
                sentinela++;
            if (FuncGeral.tratamentoTel(txtWhats) == false)
                sentinela++;
            if (FuncGeral.validarEmail(txtEmail) == false)
                sentinela++;
            return sentinela;
        }

        private void carregarGridEntidade()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from entidade in contexto.Entidade.OrderBy(entidade => entidade.id)
                        select new
                        {
                            id = entidade.id,
                            nomeEntidade = entidade.nome,
                            endereco = entidade.endereco,
                            cidadeID = entidade.cidadeID,
                            nomeCidade = entidade.Cidade.descricao,
                            cep = entidade.cep,
                            fone = entidade.fone,
                            celular = entidade.celular,
                            whatsapp = entidade.celular,
                            email = entidade.email,
                            site = entidade.site,
                            contato = entidade.contato
                        };
            dgvEntidade.DataSource = dados.ToList();
        }

        private void frmEntidade_Load(object sender, EventArgs e)
        {
            this.dgvEntidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvEntidade);
            carregarGridEntidade();
            habilitaCampos(false);

            cmbCidade.DisplayMember = "descEstado";
            cmbCidade.ValueMember = "id";
            cmbCidade.DataSource = contexto.Cidade.ToList().OrderBy(p => p.descEstado).ToList();
        }

        private void dgvEntidade_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEntidade.SelectedRows.Count > 0)
            {
                txtId.Text = dgvEntidade.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvEntidade.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvEntidade.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtCep.Text = dgvEntidade.SelectedRows[0].Cells["cep"].Value.ToString();
                cmbCidade.SelectedValue = dgvEntidade.SelectedRows[0].Cells["cidadeID"].Value;
                txtTelefone.Text = dgvEntidade.SelectedRows[0].Cells["fone"].Value.ToString();
                txtCelular.Text = dgvEntidade.SelectedRows[0].Cells["celular"].Value.ToString();
                txtWhats.Text = dgvEntidade.SelectedRows[0].Cells["whatsapp"].Value.ToString();
                txtEmail.Text = dgvEntidade.SelectedRows[0].Cells["email"].Value.ToString();
                txtSite.Text = dgvEntidade.SelectedRows[0].Cells["site"].Value.ToString();
                txtContato.Text = dgvEntidade.SelectedRows[0].Cells["contato"].Value.ToString();
                habilitaCampos(false);

                carregarGridEntidade();
            }
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            txtId.Text = "-1";
            txtNome.Focus();
        }

        private void lbEditar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                FuncGeral.messageBoxEditar();
            } else
            {
                habilitaCampos(true);
                txtNome.Focus();
            }
            
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Entidade entidade = new Modelo.Entidade();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                entidade = contexto.Entidade.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção da entidade?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Entidade.Remove(entidade);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Entidade removida com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            carregarGridEntidade();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if(validarTextBox() == 0)
                {
                    Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                    DialogResult result;
                    result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        Modelo.Entidade entidade = new Modelo.Entidade();

                        if (id != -1)
                        {
                            entidade = contexto.Entidade.Find(id);
                        }
                        entidade.id = id;
                        entidade.nome = txtNome.Text;
                        entidade.endereco = txtEndereco.Text;
                        entidade.cidadeID = Convert.ToInt32(cmbCidade.SelectedValue);
                        entidade.cep = txtCep.Text;
                        entidade.fone = txtTelefone.Text;
                        entidade.celular = txtCelular.Text;
                        entidade.whatsApp = txtWhats.Text;
                        entidade.email = txtEmail.Text;
                        entidade.site = txtSite.Text;
                        entidade.contato = txtContato.Text;

                        if (entidade.id == -1)
                        {
                            contexto.Entidade.Add(entidade);
                            limparCampos();
                            habilitaCampos(false);
                        }
                        else
                        {
                            contexto.Entry(entidade).State = EntityState.Modified;
                            limparCampos();
                            habilitaCampos(false);
                        }
                        contexto.SaveChanges();
                        carregarGridEntidade();
                    }
                    else
                    {
                        MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("Campo Nome é obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var dados = from entidade in contexto.Entidade.ToList().Where(p => (p.nome.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.contato.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = entidade.id,
                            nomeEntidade = entidade.nome,
                            endereco = entidade.endereco,
                            cidadeID = entidade.cidadeID,
                            nomeCidade = entidade.Cidade.descricao,
                            cep = entidade.cep,
                            fone = entidade.fone,
                            celular = entidade.celular,
                            whatsapp = entidade.celular,
                            email = entidade.email,
                            site = entidade.site,
                            contato = entidade.contato
                        };
            dgvEntidade.DataSource = "";
            dgvEntidade.DataSource = dados.ToList();
        }

        private void frmEntidade_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtWhats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtTelefone);
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtCelular);
        }

        private void txtWhats_Move(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtWhats);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            FuncGeral.validarEmail(txtEmail);
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoCep(txtCep);
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            frmCidade cons = new frmCidade();
            cons.ShowDialog();
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbCidade.DataSource = contexto.Cidade.ToList().OrderBy(p => p.descEstado).ToList();
        }
    }
}
