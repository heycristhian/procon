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
    public partial class frmTipoReclamacao : Form
    {
        public frmTipoReclamacao()
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

        private void carregarGridTipoReclamacao()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from tipoReclamacao in contexto.TipoReclamacao.OrderBy(tipoReclamacao => tipoReclamacao.descricao)
                        select new
                        {
                            id = tipoReclamacao.id,
                            descricao = tipoReclamacao.descricao                            
                        };

            dgvTipoReclamacao.DataSource = dados.ToList();
        }

        private void frmTipoReclamacao_Load(object sender, EventArgs e)
        {
            this.dgvTipoReclamacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            habilitaCampos(false);

            ToolModeladas.dgvTransformation(dgvTipoReclamacao);
            carregarGridTipoReclamacao();

            dgvTipoReclamacao.DataSource = contexto.TipoReclamacao.ToList();
        }        

        private void dgvTipoReclamacao_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoReclamacao.SelectedRows.Count > 0)
                txtId.Text = dgvTipoReclamacao.SelectedRows[0].Cells["id"].Value.ToString();
                txtDescricao.Text = dgvTipoReclamacao.SelectedRows[0].Cells["descricao"].Value.ToString();
                habilitaCampos(false);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                //SELECIONANDO A LINHA TODA SE CASO O USUÁRIO CLICAR DUAS VEZES NUMA CÉLULA
                dgvTipoReclamacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            Modelo.TipoReclamacao tipoReclamacao = new Modelo.TipoReclamacao();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                tipoReclamacao = contexto.TipoReclamacao.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do tipo de reclamação?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.TipoReclamacao.Remove(tipoReclamacao);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Tipo de reclamação removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvTipoReclamacao.DataSource = "";
            dgvTipoReclamacao.DataSource = contexto.TipoReclamacao.ToList();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                DialogResult result;
                result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Modelo.TipoReclamacao tipoReclamacao = new Modelo.TipoReclamacao();

                    if (id != -1)
                    {
                        tipoReclamacao = contexto.TipoReclamacao.Find(id);
                    }
                    tipoReclamacao.id = id;
                    tipoReclamacao.descricao = txtDescricao.Text;

                    if (tipoReclamacao.id == -1)
                    {
                        bool teste = contexto.TipoReclamacao.ToList().Exists(p => p.descricao.ToLower().RemoveDiacritics().Equals(txtDescricao.Text.ToLower().RemoveDiacritics().Trim()));
                        if (teste)
                        {
                            MessageBox.Show("Tipo reclamação já cadastrada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDescricao.Focus();

                        }
                        else
                        {
                            contexto.TipoReclamacao.Add(tipoReclamacao);
                            contexto.SaveChanges();
                            MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
                            habilitaCampos(false);
                            dgvTipoReclamacao.DataSource = "";
                            dgvTipoReclamacao.DataSource = contexto.Cidade.ToList();
                            carregarGridTipoReclamacao();
                        }
                    }                        
                    else
                    {
                        contexto.Entry(tipoReclamacao).State = EntityState.Modified;
                        contexto.SaveChanges();
                        habilitaCampos(false);                        
                    }
                }
                else MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregarGridTipoReclamacao();
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

        private void frmTipoReclamacao_KeyDown(object sender, KeyEventArgs e)
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
            var dados = from tipoReclamacao in contexto.TipoReclamacao.ToList().Where(p => (p.descricao.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = tipoReclamacao.id,
                            descricao = tipoReclamacao.descricao
                        };
            dgvTipoReclamacao.DataSource = "";
            dgvTipoReclamacao.DataSource = dados.ToList();
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
