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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
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

            txtRazaoSocial.Enabled = status;
            txtFantasia.Enabled = status;
            txtContato.Enabled = status;
            txtEndereco.Enabled = status;
            txtBairro.Enabled = status;
            cmbCidade.Enabled = status;
            txtCep.Enabled = status;
            txtTelefone.Enabled = status;
            txtCelular.Enabled = status;
            txtWhats.Enabled = status;
            txtEmail.Enabled = status;
            txtSite.Enabled = status;
            txtCnpj.Enabled = status;

            picCidade.Visible = status;
        }

        int sentinelaEditar = 1;

        private int validarTextBox()
        {
            if (sentinelaEditar == 1)
            {
                int sentinela = 0;
                bool status = false;
                status = txtRazaoSocial.Text != "";
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoCpnjFornecedor(txtCnpj);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoCep(txtCep);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtTelefone);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtCelular);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtWhats);
                if (status == false)
                    sentinela++;
                status = FuncGeral.validarEmail(txtEmail);
                if (status == false)
                    sentinela++;
                return sentinela;
            }
            else
            {
                int sentinela = 0;
                bool status = false;
                status = txtRazaoSocial.Text != "";
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoCep(txtCep);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtTelefone);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtCelular);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtWhats);
                if (status == false)
                    sentinela++;
                status = FuncGeral.validarEmail(txtEmail);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoCpnjFornecedorNoBd(txtCnpj);
                if (status == false)
                    sentinela++;
                return sentinela;
                
            }

        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtRazaoSocial.Text = "";
            txtFantasia.Text = "";
            txtContato.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            cmbCidade.Text = "";
            txtCep.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtWhats.Text = "";
            txtEmail.Text = "";
            txtSite.Text = "";
            txtCnpj.Text = "";
        }

        private void carregarGridFornecedor()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from fornecedor in contexto.Fornecedor.OrderBy(fornecedor => fornecedor.id)
                        select new
                        {
                            id = fornecedor.id,
                            razaoSocial = fornecedor.razaoSocial,
                            fantasia = fornecedor.fantasia,
                            contato = fornecedor.contato,
                            endereco = fornecedor.endereco,
                            bairro = fornecedor.bairro,
                            cidadeID = fornecedor.cidadeID,
                            nomeCidade = fornecedor.Cidade.descricao,
                            cep = fornecedor.cep,
                            fone = fornecedor.fone,
                            celular = fornecedor.celular,
                            whatsapp = fornecedor.whatsApp,
                            email = fornecedor.email,
                            site = fornecedor.site,
                            cnpj = fornecedor.cnpj
                        };
            dgvFornecedor.DataSource = dados.ToList();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            this.dgvFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            habilitaCampos(false);

            ToolModeladas.dgvTransformation(dgvFornecedor);
            carregarGridFornecedor();
            

            cmbCidade.DisplayMember = "descEstado";
            cmbCidade.ValueMember = "id";
            cmbCidade.DataSource = contexto.Cidade.ToList().OrderBy(p => p.descEstado).ToList();
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            txtId.Text = dgvFornecedor.SelectedRows[0].Cells["id"].Value.ToString();
            txtRazaoSocial.Text = dgvFornecedor.SelectedRows[0].Cells["razaoSocial"].Value.ToString();
            txtFantasia.Text = dgvFornecedor.SelectedRows[0].Cells["fantasia"].Value.ToString();
            txtContato.Text = dgvFornecedor.SelectedRows[0].Cells["contato"].Value.ToString();
            txtEndereco.Text = dgvFornecedor.SelectedRows[0].Cells["endereco"].Value.ToString();
            txtBairro.Text = dgvFornecedor.SelectedRows[0].Cells["bairro"].Value.ToString();
            cmbCidade.SelectedValue = dgvFornecedor.SelectedRows[0].Cells["cidadeID"].Value;
            txtCep.Text = dgvFornecedor.SelectedRows[0].Cells["cep"].Value.ToString();
            txtTelefone.Text = dgvFornecedor.SelectedRows[0].Cells["fone"].Value.ToString();
            txtCelular.Text = dgvFornecedor.SelectedRows[0].Cells["celular"].Value.ToString();
            txtWhats.Text = dgvFornecedor.SelectedRows[0].Cells["whatsapp"].Value.ToString();
            txtEmail.Text = dgvFornecedor.SelectedRows[0].Cells["email"].Value.ToString();
            txtSite.Text = dgvFornecedor.SelectedRows[0].Cells["site"].Value.ToString();
            txtCnpj.Text = dgvFornecedor.SelectedRows[0].Cells["cnpj"].Value.ToString();
            habilitaCampos(false);

            carregarGridFornecedor();
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            txtId.Text = "-1";
            txtRazaoSocial.Focus();
        }

        private void lbEditar_Click(object sender, EventArgs e)
        {
            if(txtRazaoSocial.Text == "")
            {
                MessageBox.Show("Você precisa selecionar algum item para edição!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sentinelaEditar = 0;
                habilitaCampos(true);
                txtRazaoSocial.Focus();
            }
            
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Fornecedor fornecedor = new Modelo.Fornecedor();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                fornecedor = contexto.Fornecedor.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do fornecedor?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Fornecedor.Remove(fornecedor);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Fornecedor removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            carregarGridFornecedor();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                DialogResult result;

                if(validarTextBox() == 0)
                {
                    result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        Modelo.Fornecedor fornecedor = new Modelo.Fornecedor();

                        if (id != -1)
                        {
                            fornecedor = contexto.Fornecedor.Find(id);
                        }
                        fornecedor.id = id;
                        fornecedor.razaoSocial = txtRazaoSocial.Text;
                        fornecedor.fantasia = txtFantasia.Text;
                        fornecedor.contato = txtContato.Text;
                        fornecedor.endereco = txtEndereco.Text;
                        fornecedor.bairro = txtBairro.Text;
                        fornecedor.cidadeID = Convert.ToInt32(cmbCidade.SelectedValue);
                        fornecedor.cep = txtCep.Text;
                        fornecedor.fone = txtTelefone.Text;
                        fornecedor.celular = txtCelular.Text;
                        fornecedor.whatsApp = txtWhats.Text;
                        fornecedor.email = txtEmail.Text;
                        fornecedor.site = txtSite.Text;
                        fornecedor.cnpj = txtCnpj.Text;

                        if (fornecedor.id == -1)
                        {
                            habilitaCampos(false);
                            contexto.Fornecedor.Add(fornecedor);
                            MessageBox.Show("Dados gravados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
                            contexto.SaveChanges();
                            carregarGridFornecedor();
                            sentinelaEditar = 1;
                        }
                        else
                        {
                            limparCampos();
                            habilitaCampos(false);
                            contexto.Entry(fornecedor).State = EntityState.Modified;
                            contexto.SaveChanges();
                            carregarGridFornecedor();
                            sentinelaEditar = 1;
                        }                       
                    }                   
                }             
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("Os campos Razão Social e CNPJ são obrigatórios!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var dados = from fornecedor in contexto.Fornecedor.ToList().Where(p => (p.razaoSocial.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.fantasia.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = fornecedor.id,
                            razaoSocial = fornecedor.razaoSocial,
                            fantasia = fornecedor.fantasia,
                            contato = fornecedor.contato,
                            endereco = fornecedor.endereco,
                            bairro = fornecedor.bairro,
                            cidadeID = fornecedor.cidadeID,
                            nomeCidade = fornecedor.Cidade.descricao,
                            cep = fornecedor.cep,
                            fone = fornecedor.fone,
                            celular = fornecedor.celular,
                            whatsapp = fornecedor.whatsApp,
                            email = fornecedor.email,
                            site = fornecedor.site,
                            cnpj = fornecedor.cnpj
                        };
            dgvFornecedor.DataSource = "";
            dgvFornecedor.DataSource = dados.ToList();
        }

        private void frmFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCep_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoCep(txtCep);
            if(txtTelefone.Text == "" && txtCelular.Text == "" && txtContato.Text == "" && txtWhats.Text == "" && txtEmail.Text == "" && txtSite.Text == "")
            {
                tabControl1.SelectedTab = tabPage2;
            }
            
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoCpnjFornecedor(txtCnpj);
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

        private void txtWhats_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtWhats);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            FuncGeral.validarEmail(txtEmail);
        }

        private void picProblema_Click(object sender, EventArgs e)
        {
            frmCidade frmCidade = new frmCidade();
            frmCidade.ShowDialog();

            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvFornecedor);

            cmbCidade.DataSource = contexto.Cidade.ToList().OrderBy(p => p.descEstado).ToList();
        }        
    }
}
