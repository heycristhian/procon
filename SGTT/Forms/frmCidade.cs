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
using SGAP.Funcoes;
using SGAP.Modelo;

namespace SGAP.Forms
{
    public partial class frmCidade : Form
    {
        public frmCidade()
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
            cmbUf.Enabled = status;
        }

        private void limparCampos()
        {
            lblId.Text = "";
            txtNome.Text = "";
        }        

        private void carregarGridCidade()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from cidade in contexto.Cidade.OrderBy(tipoReclamacao => tipoReclamacao.descricao)
                        select new
                        {
                            id = cidade.id,
                            descricao = cidade.descricao,
                            uf = cidade.uf
                        };

            dgvCidade.DataSource = dados.ToList();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            this.dgvCidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<String> lstEstado = new List<String>();
            lstEstado.Add("AC");
            lstEstado.Add("AL");
            lstEstado.Add("AP");
            lstEstado.Add("AM");
            lstEstado.Add("BA");
            lstEstado.Add("CE");
            lstEstado.Add("DF");
            lstEstado.Add("ES");
            lstEstado.Add("GO");
            lstEstado.Add("MA");
            lstEstado.Add("MT");
            lstEstado.Add("MS");
            lstEstado.Add("MG");
            lstEstado.Add("PA");
            lstEstado.Add("PB");
            lstEstado.Add("PR");
            lstEstado.Add("PE");
            lstEstado.Add("PI");
            lstEstado.Add("RJ");
            lstEstado.Add("RN");
            lstEstado.Add("RS");
            lstEstado.Add("RO");
            lstEstado.Add("RR");
            lstEstado.Add("SC");
            lstEstado.Add("SP");
            lstEstado.Add("SE");
            lstEstado.Add("TO");
            
            
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvCidade);

            dgvCidade.DataSource = "";
            dgvCidade.DataSource = contexto.Cidade.ToList();

            habilitaCampos(false);

            carregarGridCidade();

            cmbUf.DataSource = lstEstado.ToList();

            limparCampos();
        }           

        private void dgvCidade_DoubleClick(object sender, EventArgs e)
        {
            

            if (dgvCidade.SelectedRows.Count > 0)
            {
                lblId.Text = dgvCidade.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvCidade.SelectedRows[0].Cells["nome"].Value.ToString();
                cmbUf.SelectedItem = dgvCidade.SelectedRows[0].Cells["uf"].Value.ToString();
                habilitaCampos(false);
            }
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            lblId.Text = "-1";
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
                habilitaCampos(true);
                txtNome.Focus();
            }
            
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Cidade cidade = new Modelo.Cidade();
            if (lblId.Text == "")
                lblId.Text = "0";  //só foi feito para não dar erro qdo campo em branco. 

            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                cidade = contexto.Cidade.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma Remoção da cidade?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Cidade.Remove(cidade);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Remoção ocorreu com sucesso!!!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!!!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            dgvCidade.DataSource = "";
            dgvCidade.DataSource = contexto.Cidade.ToList();
            limparCampos();
            habilitaCampos(false);
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                List<Modelo.Cidade> lstCidade = new List<Modelo.Cidade>();
                DialogResult result;
                result = MessageBox.Show("Confirma Gravação?", "Salvar", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    Modelo.Cidade cidade = new Modelo.Cidade();

                    if (id != -1)
                    {
                        cidade = contexto.Cidade.Find(id);
                    }                        

                    //popular o objeto com os valores do formulário
                    cidade.id = id;
                    cidade.descricao = txtNome.Text;
                    //cidade.uf = txtUf.Text;
                    cidade.uf = cmbUf.Text.ToString();

                    if (cidade.id == -1) // se for inserir
                    {
                        bool teste = contexto.Cidade.ToList().Exists(p => p.descEstado.ToLower().RemoveDiacritics().Equals(txtNome.Text.ToLower().RemoveDiacritics().Trim() + " - " + cmbUf.SelectedValue.ToString().ToLower().RemoveDiacritics().Trim()));
                        if (teste)
                        {
                            MessageBox.Show("Cidade já cadastrada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Focus();

                        }
                        else
                        {
                            contexto.Cidade.Add(cidade);
                            contexto.SaveChanges();
                            MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
                            habilitaCampos(false);
                            dgvCidade.DataSource = "";
                            dgvCidade.DataSource = contexto.Cidade.ToList();
                        }
                    }                        
                    else
                    {
                        contexto.Entry(cidade).State = EntityState.Modified;
                        contexto.SaveChanges();
                        habilitaCampos(false);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Dados não gravado", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                carregarGridCidade();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("Os campos Nome e UF são obrigatórios!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var dados = from cidade in contexto.Cidade.ToList().Where(p => (p.descricao.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.uf.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = cidade.id,
                            descricao = cidade.descricao,
                            uf = cidade.uf
                        };
            dgvCidade.DataSource = "";
            dgvCidade.DataSource = dados.ToList();
        }

        private void frmCidade_KeyDown(object sender, KeyEventArgs e)
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
