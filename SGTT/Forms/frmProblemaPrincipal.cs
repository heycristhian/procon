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
    public partial class frmProblemaPrincipal : Form
    {

        public int idProblemaPrincipal { get; set; }

        public frmProblemaPrincipal()
        {
            InitializeComponent();
        }

        public frmProblemaPrincipal(int problemaPrincipal)
        {
            InitializeComponent();
            idProblemaPrincipal = problemaPrincipal;
        }

        private void habilitaCampos(bool status)
        {
            lbNovo.Enabled = !status;
            lbEditar.Enabled = !status;
            lbRemover.Enabled = !status;
            lbSalvar.Enabled = status;
            lbCancelar.Enabled = status;

            cmbTipoReclamacao.Enabled = status;
            txtDescricao.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            cmbTipoReclamacao.Text = "";
            txtDescricao.Text = "";
        }

        private void carregarGridProblemaPrincipal()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from problemaPrincipal in contexto.ProblemaPrincipal.OrderBy(tipoReclamacao => tipoReclamacao.tipoReclamacaoID)
                        select new
                        {
                            id = problemaPrincipal.id,
                            descricao = problemaPrincipal.descricao,
                            tipoReclamacaoID = problemaPrincipal.tipoReclamacaoID,
                            tipoReclamacao = problemaPrincipal.TipoReclamacao.descricao
                        };
            dgvProblemaPrincipal.DataSource = dados.ToList();
        }


        private void frmProblemaPrincipal_Load(object sender, EventArgs e)
        {
            this.dgvProblemaPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            habilitaCampos(false);
            ToolModeladas.dgvTransformation(dgvProblemaPrincipal);
            carregarGridProblemaPrincipal();       

            cmbTipoReclamacao.DisplayMember = "descricao";
            cmbTipoReclamacao.ValueMember = "id";
            cmbTipoReclamacao.DataSource = contexto.TipoReclamacao.ToList().OrderBy(p => p.descricao).ToList();
            cmbTipoReclamacao.SelectedValue = idProblemaPrincipal;
        }                

        private void dgvProblemaPrincipal_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProblemaPrincipal.SelectedRows.Count > 0)
            {
                txtId.Text = dgvProblemaPrincipal.SelectedRows[0].Cells["id"].Value.ToString();
                cmbTipoReclamacao.SelectedValue = dgvProblemaPrincipal.SelectedRows[0].Cells["tipoReclamacaoID"].Value;
                txtDescricao.Text = dgvProblemaPrincipal.SelectedRows[0].Cells["descricao"].Value.ToString();
                habilitaCampos(false);
                carregarGridProblemaPrincipal();
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
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

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            txtId.Text = "-1";
            cmbTipoReclamacao.Focus();
        }

        private void lbEditar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {                
                MessageBox.Show("Você precisa selecionar algum item para edição!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Modelo.ProblemaPrincipal problemaPrincipal = new Modelo.ProblemaPrincipal();
            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                problemaPrincipal = contexto.ProblemaPrincipal.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção da reclamação?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        contexto.ProblemaPrincipal.Remove(problemaPrincipal);
                        contexto.SaveChanges();          // atualiza o banco de dados 
                        MessageBox.Show("Reclamação removida com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Problema Principal não pode ser excluído, pois há outros registros que estão utilizando o mesmo!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvProblemaPrincipal.DataSource = "";
            dgvProblemaPrincipal.DataSource = contexto.ProblemaPrincipal.ToList();
            limparCampos();
            carregarGridProblemaPrincipal();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {            
            if (txtDescricao.Text == "")
            {
                txtDescricao.Focus();
                MessageBox.Show("Descrição não pode ser em branco!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
            else
            {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            DialogResult result;
            result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);
                Modelo.ProblemaPrincipal problemaPrincipal = new Modelo.ProblemaPrincipal();

                if (id != -1)
                {
                    problemaPrincipal = contexto.ProblemaPrincipal.Find(id);
                }
                problemaPrincipal.id = id;
                problemaPrincipal.tipoReclamacaoID = Convert.ToInt32(cmbTipoReclamacao.SelectedValue);
                problemaPrincipal.descricao = txtDescricao.Text;

                if (problemaPrincipal.id == -1)
                    contexto.ProblemaPrincipal.Add(problemaPrincipal);
                else
                    contexto.Entry(problemaPrincipal).State = EntityState.Modified;

                contexto.SaveChanges();
            }
            else MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
            habilitaCampos(false);
            carregarGridProblemaPrincipal();
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

        private void lbMovimentar_MouseEnter(object sender, EventArgs e)
        {
            lbFechar.BackColor = Color.Red;
        }

        private void lbMovimentar_MouseLeave(object sender, EventArgs e)
        {
            lbFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
        }

        private void frmProblemaPrincipal_KeyDown(object sender, KeyEventArgs e)
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
                lbFechar_Click(sender, e);
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from problemaPrincipal in contexto.ProblemaPrincipal.ToList().Where(p => (p.TipoReclamacao.descricao.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.descricao.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = problemaPrincipal.id,
                            tipoReclamacaoID = problemaPrincipal.tipoReclamacaoID,
                            tipoReclamacao = problemaPrincipal.TipoReclamacao.descricao,
                            descricao = problemaPrincipal.descricao                                                       
                        };
            dgvProblemaPrincipal.DataSource = "";
            dgvProblemaPrincipal.DataSource = dados.ToList();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            frmTipoReclamacao reclamacao = new frmTipoReclamacao();
            reclamacao.ShowDialog();

            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbTipoReclamacao.DataSource = contexto.TipoReclamacao.ToList().OrderBy(p => p.descricao).ToList();
        }
    }
}
