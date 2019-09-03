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

namespace SGAP.Forms
{
    public partial class frmAtendimento : Form
    {
        Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();

        frmMenu menu = new frmMenu("aux");

        public string descricao { get; set; }

        public frmAtendimento()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public frmAtendimento(frmMenu frmMenu)
        {           
            InitializeComponent();            
            this.MinimizeBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            menu = frmMenu;
        }

 

        private void habilitaCampos(bool status)
        {
            lbNovo.Enabled = !status;
            lbEditar.Enabled = !status;
            lbRemover.Enabled = !status;
            lbSalvar.Enabled = status;
            lbCancelar.Enabled = status;
            lbMovimentar.Enabled = status;
            lbEncaminhar.Enabled = status;
            picAddConsumidor.Visible = status;
            picAddFornecedor.Visible = status;

            txtnumeroProcon.Enabled = status;
            cmbConsumidor.Enabled = status;
            cmbFornecedor.Enabled = status;
            picProblema.Visible = status;
            cmbProblema.Enabled = status;
            cmbTipoAtendimento.Enabled = status;
            cmbTipoReclamacao.Enabled = status;
            txtDescricaoProblema.Enabled = status;
            lblExpandirDescricao.Enabled = status;
            dtpInicio.Enabled = status;
            dtpEncerramento.Enabled = status;
        }

        private void limparCampos()
        {
            txtId.Text = "";
            txtnumeroProcon.Text = "";
            cmbConsumidor.Text = "";
            cmbFornecedor.Text = "";
            cmbTipoAtendimento.Text = "";
            cmbTipoReclamacao.Text = "";
            txtDescricaoProblema.Text = "";
            dtpInicio.Text = "";
            dtpEncerramento.Text = "";
            cmbProblema.Text = "";
        }

        private void carregarGridAtendimento()
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from atendimento in contexto.Atendimento.OrderBy(atendimento => atendimento.id)
                        select new
                        {
                            id = atendimento.id,
                            numeroProcon = atendimento.numeroProcon,
                            consumidorID = atendimento.consumidorID,
                            nomeConsumidor = atendimento.Consumidor.nome,
                            fornecedorID = atendimento.fornecedorID,
                            nomeFornecedor = atendimento.Fornecedor.razaoSocial,
                            tipoAtendimentoID = atendimento.tipoAtendimentoID,
                            tipoAtendimento = atendimento.TipoAtendimento.descricao,
                            tipoReclamacaoID = atendimento.tipoReclamacaoID,
                            tipoReclamacao = atendimento.TipoReclamacao.descricao,
                            problemaPrincipalID = atendimento.problemaPrincipalID,
                            problemaPrincipal = atendimento.ProblemaPrincipal.descricao,
                            reclamacao = atendimento.reclamacao,
                            dataInicio = atendimento.dataInicio,
                            dataEncerramento = atendimento.dataEncerramento
                        };
            dgvAtendimento.DataSource = dados.ToList();
        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvAtendimento);

            this.dgvAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            habilitaCampos(false);

            carregarGridAtendimento();

            cmbConsumidor.DisplayMember = "descConsumidor";
            cmbConsumidor.ValueMember = "id";
            cmbConsumidor.DataSource = contexto.Consumidor.ToList().OrderBy(p=> p.nome).ToList();

            cmbFornecedor.DisplayMember = "razaoSocial";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.DataSource = contexto.Fornecedor.OrderBy(p=> p.razaoSocial).ToList();            

            cmbTipoAtendimento.DisplayMember = "descricao";
            cmbTipoAtendimento.ValueMember = "id";
            cmbTipoAtendimento.DataSource = contexto.TipoAtendimento.ToList().OrderBy(p => p.descricao).ToList();

            cmbTipoReclamacao.DisplayMember = "descricao";
            cmbTipoReclamacao.ValueMember = "id";
            cmbTipoReclamacao.DataSource = contexto.TipoReclamacao.ToList().OrderBy(p => p.descricao).ToList();

            cmbProblema.DisplayMember = "descricao";
            cmbProblema.ValueMember = "id";
            try
            {
                int id = Convert.ToInt32(cmbTipoReclamacao.SelectedValue.ToString());
                cmbProblema.DataSource = contexto.ProblemaPrincipal.ToList().Where(p => p.TipoReclamacao.id == id).OrderBy(p => p.descricao).ToList();
            }
            catch (System.NullReferenceException)
            {

            }

            limparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(true);
            limparCampos();
            txtId.Text = "-1";
            txtnumeroProcon.Focus();
        }     

        private void dgvAtendimento_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvAtendimento.SelectedRows.Count > 0)

                txtId.Text = dgvAtendimento.SelectedRows[0].Cells["id"].Value.ToString();
                txtnumeroProcon.Text = dgvAtendimento.SelectedRows[0].Cells["numeroProcon"].Value.ToString();
                cmbConsumidor.SelectedValue = dgvAtendimento.SelectedRows[0].Cells["consumidorID"].Value;
                cmbFornecedor.SelectedValue = dgvAtendimento.SelectedRows[0].Cells["fornecedorID"].Value;
                cmbTipoAtendimento.SelectedValue = dgvAtendimento.SelectedRows[0].Cells["tipoAtendimentoID"].Value;
                cmbTipoReclamacao.SelectedValue = dgvAtendimento.SelectedRows[0].Cells["tipoReclamacaoID"].Value;
                cmbProblema.SelectedValue = dgvAtendimento.SelectedRows[0].Cells["problemaPrincipalID"].Value;
                txtDescricaoProblema.Text = dgvAtendimento.SelectedRows[0].Cells["reclamacao"].Value.ToString();
                dtpInicio.Text = dgvAtendimento.SelectedRows[0].Cells["dataInicio"].Value.ToString();
                dtpEncerramento.Text = dgvAtendimento.SelectedRows[0].Cells["dataEncerramento"].Value.ToString();
                habilitaCampos(false);

                lbMovimentar.Enabled = true;
                lbEncaminhar.Enabled = true;

                carregarGridAtendimento();

                btnAndamentos.Visible = true;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //SELECIONANDO A LINHA TODA SE CASO O USUÁRIO CLICAR DUAS VEZES NUMA CÉLULA
                this.dgvAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;               
            }
        }      
        
        private void picAddFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor frmForn = new frmFornecedor();
            frmForn.ShowDialog();
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvAtendimento);

            cmbFornecedor.DataSource = contexto.Fornecedor.OrderBy(p=> p.razaoSocial).ToList();
        }

        private void picProblema_Click(object sender, EventArgs e)
        {
            frmProblemaPrincipal frmProblema = new frmProblemaPrincipal(Convert.ToInt32(cmbTipoReclamacao.SelectedValue));
            frmProblema.ShowDialog();

            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            int id = Convert.ToInt32(cmbTipoReclamacao.SelectedValue.ToString());
            cmbProblema.DataSource = contexto.ProblemaPrincipal.ToList().Where(p => p.TipoReclamacao.id == id).OrderBy(p => p.descricao).ToList();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            var dados = from atendimento in contexto.Atendimento.ToList().Where(p => (p.Consumidor.nome.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim()) || p.Fornecedor.razaoSocial.ToLower().RemoveDiacritics().Contains(txtPesquisar.Text.ToLower().RemoveDiacritics().Trim())))
                        select new
                        {
                            id = atendimento.id,
                            numeroProcon = atendimento.numeroProcon,
                            consumidorID = atendimento.consumidorID,
                            nomeConsumidor = atendimento.Consumidor.nome,
                            fornecedorID = atendimento.fornecedorID,
                            nomeFornecedor = atendimento.Fornecedor.razaoSocial,
                            problemaPrincipalID = atendimento.problemaPrincipalID,
                            problemaPrincipal = atendimento.ProblemaPrincipal.descricao,
                            reclamacao = atendimento.reclamacao,
                            dataInicio = atendimento.dataInicio,
                            dataEncerramento = atendimento.dataEncerramento,
                            tipoAtendimentoID = atendimento.tipoAtendimentoID,
                            tipoAtendimento = atendimento.TipoAtendimento.descricao,
                            tipoReclamacaoID = atendimento.tipoReclamacaoID,
                            tipoReclamacao = atendimento.TipoReclamacao.descricao
                        };
            dgvAtendimento.DataSource = "";
            dgvAtendimento.DataSource = dados.ToList();
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            cmbTipoAtendimento.ResetText();
            habilitaCampos(true);
            txtId.Text = "-1";
            txtnumeroProcon.Focus();
            btnAndamentos.Visible = false;

            Atendimento atendimento = new Atendimento();
            SGAPContexto contexto = new SGAPContexto();
            atendimento = contexto.Atendimento.OrderByDescending(x => x.id).FirstOrDefault(x => x.usuario.Equals(menu.usuario));
            
            if(atendimento == null)
            {
                txtnumeroProcon.Text = "001-" + DateTime.Now.Year + "-" + menu.usuario;
            }
            else if(atendimento.dataInicio.Month != DateTime.Now.Month)
            {
                txtnumeroProcon.Text = "001-" + DateTime.Now.Year + "-" + menu.usuario;
            }
            else
            {
                txtnumeroProcon.Text = (Convert.ToInt32(atendimento.numeroProcon.Substring(0, 3)) + 1).ToString("000") + "-" + DateTime.Now.Year + "-" + menu.usuario;
            }

        }

        private void lbEditar_Click(object sender, EventArgs e)
        {
            if(txtnumeroProcon.Text == "")
            {
                MessageBox.Show("Não há registros para editar!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                habilitaCampos(true);
                txtnumeroProcon.Focus();
            }
            
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitaCampos(false);

            btnAndamentos.Visible = false;
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                Modelo.Atendimento atendimentoVerifica = new Modelo.Atendimento();

                int ano = (Convert.ToDateTime(dtpInicio.Text)).Year;
                int mes = (Convert.ToDateTime(dtpInicio.Text)).Month;

                atendimentoVerifica = contexto.Atendimento.FirstOrDefault(x => x.numeroProcon.Equals(txtnumeroProcon.Text) && x.dataInicio.Month == mes && x.dataInicio.Year == ano);
                if(atendimentoVerifica == null)
                {
                    DialogResult result;
                    result = MessageBox.Show("Confirma gravação dos dados?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        Modelo.Atendimento atendimento = new Modelo.Atendimento();


                        if (id != -1)
                        {
                            atendimento = contexto.Atendimento.Find(id);
                        }
                        atendimento.id = id;
                        atendimento.numeroProcon = txtnumeroProcon.Text;
                        atendimento.consumidorID = Convert.ToInt32(cmbConsumidor.SelectedValue);
                        atendimento.fornecedorID = Convert.ToInt32(cmbFornecedor.SelectedValue);
                        atendimento.tipoAtendimentoID = Convert.ToInt32(cmbTipoAtendimento.SelectedValue);
                        atendimento.tipoReclamacaoID = Convert.ToInt32(cmbTipoReclamacao.SelectedValue);
                        atendimento.problemaPrincipalID = Convert.ToInt32(cmbProblema.SelectedValue);
                        atendimento.reclamacao = txtDescricaoProblema.Text;
                        atendimento.dataInicio = dtpInicio.Value;
                        atendimento.dataEncerramento = dtpEncerramento.Value;
                        atendimento.usuario = menu.usuario;

                        if (atendimento.id == -1)
                        {

                            contexto.Atendimento.Add(atendimento);
                            contexto.SaveChanges();
                            MessageBox.Show("Dados gravados com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limparCampos();
                            btnAndamentos.Visible = false;
                            habilitaCampos(false);
                            dgvAtendimento.DataSource = "";
                            dgvAtendimento.DataSource = contexto.Atendimento.ToList();

                        }

                        else
                        {
                            contexto.Entry(atendimento).State = EntityState.Modified;
                            contexto.SaveChanges();
                            habilitaCampos(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dados não gravados", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    carregarGridAtendimento();
                }
                else
                {
                    MessageBox.Show("Número atendimento já existe para mesma data", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (System.FormatException)
            {
                MessageBox.Show("Número de atendimento não pode ser vazio!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Atendimento atendimento = new Modelo.Atendimento();

            btnAndamentos.Visible = false;

            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                atendimento = contexto.Atendimento.Find(id);

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do atendimento?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    contexto.Atendimento.Remove(atendimento);
                    contexto.SaveChanges();          // atualiza o banco de dados 
                    MessageBox.Show("Atendimento removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            carregarGridAtendimento();
            limparCampos();
            habilitaCampos(false);
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

        private void lbRemover_MouseEnter(object sender, EventArgs e)
        {
            FuncGeral.labelCorEnter(lbRemover);
        }

        private void lbRemover_MouseLeave(object sender, EventArgs e)
        {
            FuncGeral.labelCorLeave(lbRemover);
        }

        private void picAddConsumidor_Click(object sender, EventArgs e)
        {
            frmConsumidor cons = new frmConsumidor();
            cons.ShowDialog();

            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            ToolModeladas.dgvTransformation(dgvAtendimento);

            cmbConsumidor.DataSource = contexto.Consumidor.ToList().OrderBy(p => p.descConsumidor).ToList();

            cmbConsumidor.Text = "";
        }

        private void frmAtendimento_KeyDown(object sender, KeyEventArgs e)
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
                
            if (e.KeyCode == Keys.F6 && lbMovimentar.Enabled == true)
                lbMovimentar_Click(sender, e);
            if (e.KeyCode == Keys.F7 && lbEncaminhar.Enabled == true)
                lbEncaminhar_Click(sender, e);
            if (e.Alt && e.KeyCode == Keys.X)
            {
                DialogResult result;
                result = MessageBox.Show("Deseja sair da tela de atendimento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }                

        }

        private void txtnumeroProcon_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lbMovimentar_MouseEnter(object sender, EventArgs e)
        {
            lbMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            lbMovimentar.ForeColor = System.Drawing.Color.White;
        }

        private void lbMovimentar_MouseLeave(object sender, EventArgs e)
        {
            lbMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            lbMovimentar.ForeColor = System.Drawing.Color.Black;
        }

        private void lbEncaminhar_MouseEnter(object sender, EventArgs e)
        {
            lbEncaminhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            lbEncaminhar.ForeColor = System.Drawing.Color.White;
        }

        private void lbEncaminhar_MouseLeave(object sender, EventArgs e)
        {
            lbEncaminhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            lbEncaminhar.ForeColor = System.Drawing.Color.Black;
        }

        private void lbMovimentar_Click(object sender, EventArgs e)
        {
            frmMovimento frmMov = new frmMovimento(Convert.ToInt32(txtId.Text));
            frmMov.ShowDialog();
        }

        private void lbEncaminhar_Click(object sender, EventArgs e)
        {
            frmEncaminhamento frmEncaminha = new frmEncaminhamento();
            frmEncaminha.ShowDialog();
        }

        private void cmbConsumidor_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbConsumidor.DataSource = contexto.Consumidor.ToList();
        }

        private void cmbTipoAtendimento_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbTipoAtendimento.DataSource = contexto.TipoAtendimento.ToList();
        }

        private void cmbProblema_Click(object sender, EventArgs e)
        {            
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            int id = Convert.ToInt32(cmbTipoReclamacao.SelectedValue.ToString());
            cmbProblema.DataSource = contexto.ProblemaPrincipal.ToList().Where(p => p.TipoReclamacao.id == id).OrderBy(p => p.descricao).ToList();            
        }

        private void cmbFornecedor_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbFornecedor.DataSource = contexto.Fornecedor.OrderBy(p=> p.razaoSocial).ToList();
        }

        private void cmbTipoReclamacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            int id = Convert.ToInt32(cmbTipoReclamacao.SelectedValue.ToString());
            cmbProblema.DataSource = contexto.ProblemaPrincipal.ToList().Where(p => p.TipoReclamacao.id == id).OrderBy(p => p.descricao).ToList();
        }

        private void lblExpandirDescricao_Click(object sender, EventArgs e)
        {
            frmTexto form = new frmTexto(txtDescricaoProblema.Text, this);
            form.ShowDialog();
            txtDescricaoProblema.Text = (descricao != null) ? descricao : txtDescricaoProblema.Text;
        }

        private void btnAndamentos_Click(object sender, EventArgs e)
        {
            frmAndamentos andamentos = new frmAndamentos(this);
            andamentos.ShowDialog();
        }
    }
}
