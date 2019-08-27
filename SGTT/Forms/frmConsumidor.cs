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
using SGAP.Modelo;
using Correios.Net;

namespace SGAP.Forms
{
    public partial class frmConsumidor : Form
    {
        public frmConsumidor()
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
            txtBairro.Enabled = status;
            cmbCidade.Enabled = status;
            txtCep.Enabled = status;
            txtTelefone.Enabled = status;
            txtTelefoneCom.Enabled = status;
            txtCelular.Enabled = status;
            txtOrgaoEmissor.Enabled = status;
            txtEmail.Enabled = status;
            txtRg.Enabled = status;
            txtCpf.Enabled = status;

            picProblema.Visible = status;
        }
        int sentinelaEditar = 1;

        private int validarTextBox()
        {
            if(sentinelaEditar == 1)
            {
                int sentinela = 0;
                bool status = false;
                status = FuncGeral.tratamentoCep(txtCep);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtTelefone);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtTelefoneCom);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtCelular);
                if (status == false)
                    sentinela++;
                status = FuncGeral.validarEmail(txtEmail);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoCpfConsumidor(txtCpf);
                if (status == false)
                    sentinela++;
                sentinelaEditar = 1;
                return sentinela;
            }
            else
            {
                int sentinela = 0;
                bool status = false;
                if (status == false)
                status = FuncGeral.tratamentoCep(txtCep);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtTelefone);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtTelefoneCom);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoTel(txtCelular);
                if (status == false)
                    sentinela++;
                status = FuncGeral.validarEmail(txtEmail);
                if (status == false)
                    sentinela++;
                status = FuncGeral.tratamentoCpfConsumidorNoBd(txtCpf);
                if (status == false)
                    sentinela++;
                return sentinela;
            }
            
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            cmbCidade.Text = "";
            txtCep.Text = "";
            txtTelefone.Text = "";
            txtTelefoneCom.Text = "";
            txtCelular.Text = "";
            txtOrgaoEmissor.Text = "";
            txtEmail.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
        }        

        private void carregarGridConsumidor()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from consumidor in contexto.Consumidor.OrderBy(consumidor => consumidor.id)
                        select new
                        {
                            id = consumidor.id,
                            nomeConsumidor = consumidor.nome,
                            endereco = consumidor.endereco,
                            bairro = consumidor.bairro,
                            cidadeID = consumidor.cidadeID,
                            nomeCidade = consumidor.Cidade.descricao,
                            cep = consumidor.cep,
                            fone = consumidor.fone,
                            foneComercial = consumidor.foneComercial,
                            celular = consumidor.celular,
                            whatsapp = consumidor.celular,
                            email = consumidor.email,
                            rg = consumidor.rg,
                            cpf = consumidor.cpf,
                        };
            dgvConsumidor.DataSource = dados.ToList();
        }

        private void frmConsumidor_Load(object sender, EventArgs e)
        {
            this.dgvConsumidor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvConsumidor);
            carregarGridConsumidor();
            habilitaCampos(false);

            
            cmbCidade.DisplayMember = "descEstado";
            cmbCidade.ValueMember = "id";
            cmbCidade.DataSource = contexto.Cidade.ToList().OrderBy(p => p.descEstado).ToList();
        }

        private void dgvConsumidor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConsumidor.SelectedRows.Count > 0)
            {
                txtId.Text = dgvConsumidor.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvConsumidor.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvConsumidor.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtBairro.Text = dgvConsumidor.SelectedRows[0].Cells["bairro"].Value.ToString();
                cmbCidade.SelectedValue = dgvConsumidor.SelectedRows[0].Cells["cidadeID"].Value;
                txtCep.Text = dgvConsumidor.SelectedRows[0].Cells["cep"].Value.ToString();
                txtTelefone.Text = dgvConsumidor.SelectedRows[0].Cells["fone"].Value.ToString();
                txtTelefoneCom.Text = dgvConsumidor.SelectedRows[0].Cells["foneComercial"].Value.ToString();
                txtCelular.Text = dgvConsumidor.SelectedRows[0].Cells["celular"].Value.ToString();
                txtOrgaoEmissor.Text = dgvConsumidor.SelectedRows[0].Cells["orgaoEmissor"].Value.ToString();
                txtEmail.Text = dgvConsumidor.SelectedRows[0].Cells["email"].Value.ToString();
                txtRg.Text = dgvConsumidor.SelectedRows[0].Cells["rg"].Value.ToString();
                txtCpf.Text = dgvConsumidor.SelectedRows[0].Cells["cpf"].Value.ToString();
                habilitaCampos(false);

                carregarGridConsumidor();
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
                MessageBox.Show("Não há registros para editar!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sentinelaEditar = 0;
                habilitaCampos(true);
                txtNome.Focus();
            }
            
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Consumidor consumidor = new Modelo.Consumidor();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                consumidor = contexto.Consumidor.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do consumidor?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Consumidor.Remove(consumidor);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Consumidor removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            carregarGridConsumidor();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Campo nome não pode ser vazio!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                }
                else
                {
                    Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                    DialogResult result;

                    if (validarTextBox() == 0)
                    {
                        result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            int id = Convert.ToInt32(txtId.Text);
                            Modelo.Consumidor consumidor = new Modelo.Consumidor();

                            if (id != -1)
                            {
                                consumidor = contexto.Consumidor.Find(id);
                            }

                            consumidor.id = id;
                            consumidor.nome = txtNome.Text;
                            consumidor.endereco = txtEndereco.Text;
                            consumidor.bairro = txtBairro.Text;
                            consumidor.cidadeID = Convert.ToInt32(cmbCidade.SelectedValue);
                            consumidor.cep = txtCep.Text;
                            consumidor.fone = txtTelefone.Text;
                            consumidor.foneComercial = txtTelefoneCom.Text;
                            consumidor.celular = txtCelular.Text;
                            consumidor.orgaoEmissor = txtOrgaoEmissor.Text;
                            consumidor.email = txtEmail.Text;
                            consumidor.rg = txtRg.Text;
                            consumidor.cpf = txtCpf.Text;


                            if (consumidor.id == -1)
                            {                                
                                contexto.Consumidor.Add(consumidor);
                                contexto.SaveChanges();
                                carregarGridConsumidor();
                                sentinelaEditar = 1;
                            }
                            else
                            {
                                contexto.Entry(consumidor).State = EntityState.Modified;
                                contexto.SaveChanges();
                                carregarGridConsumidor();
                                sentinelaEditar = 1;

                            }
                            MessageBox.Show("Dados gravados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
                            habilitaCampos(false);                            
                        }

                    }
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Campo Cidade é obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmConsumidor_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            List<Modelo.Consumidor> lstConsumidor = new List<Modelo.Consumidor>();

            try
            {
                var dados = from consumidor in contexto.Consumidor.ToList().Where(p => (p.nome.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.cpf.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                            select new
                            {
                                id = consumidor.id,
                                nomeConsumidor = consumidor.nome,
                                endereco = consumidor.endereco,
                                bairro = consumidor.bairro,
                                cidadeID = consumidor.cidadeID,
                                nomeCidade = consumidor.Cidade.descricao,
                                cep = consumidor.cep,
                                fone = consumidor.fone,
                                foneComercial = consumidor.foneComercial,
                                celular = consumidor.celular,
                                whatsapp = consumidor.celular,
                                email = consumidor.email,
                                rg = consumidor.rg,
                                cpf = consumidor.cpf,

                            };
                dgvConsumidor.DataSource = "";
                dgvConsumidor.DataSource = dados.ToList();
            }
            catch (System.NullReferenceException)
            {
                //Fazer algo para tratar esse erro
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

        private void lbFechar_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelFecharCorEnter(lbFechar);
        }

        private void lbFechar_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelFecharCorLeave(lbFechar);
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            //FuncGeral.tratamentoCep(txtCep);

            //string cep = String.Join("", System.Text.RegularExpressions.Regex.Split(txtCep.Text, @"[^\d]"));            

            //Address address = SearchZip.GetAddress("sp");
            //if (address.Zip != null)
            //{
            //    txtEndereco.Text = address.Street;
            //}
            //else txtCep.Text = "";
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtTelefone);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            FuncGeral.validarEmail(txtEmail);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTelefoneCom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefoneCom_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtTelefoneCom);
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoTel(txtCelular);
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            FuncGeral.tratamentoCpfConsumidor(txtCpf);
        }

        private void picProblema_Click(object sender, EventArgs e)
        {
            frmCidade cons = new frmCidade();
            cons.ShowDialog();
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbCidade.DataSource = contexto.Cidade.ToList().OrderBy(p => p.descEstado).ToList();
        }
    }
}
