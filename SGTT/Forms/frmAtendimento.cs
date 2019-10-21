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

        public int idCombo { get; set; }

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

        private void novoCIP(Atendimento atendimento)
        {
            Atendimento verificaAtendimento = new Atendimento();

            verificaAtendimento = contexto.Atendimento.OrderByDescending(x => x.id).FirstOrDefault(x => x.TipoAtendimento.descricao.ToLower().Equals("cip"));

            string data = DateTime.Now.Year.ToString();
            if (verificaAtendimento == null)
                atendimento.numeroProcon = "001/" + data.Substring(data.Length - 2, 2);
            else
                atendimento.numeroProcon = (Convert.ToInt32(verificaAtendimento.numeroProcon.Substring(0, 3)) + 1).ToString("000") + "/" + data.Substring(data.Length - 2, 2);

        }


        private void habilitaCampos(bool status)
        {
            lbNovo.Enabled = !status;
            lbEditar.Enabled = !status;
            lbRemover.Enabled = !status;
            lbSalvar.Enabled = status;
            lbCancelar.Enabled = status;
            picAddConsumidor.Visible = status;
            picAddFornecedor.Visible = status;

            txtnumeroProcon.Enabled = status;
            cmbConsumidor.Enabled = status;
            picPesquisarConsumidor.Enabled = status;
            cmbFornecedor.Enabled = status;
            picPesquisarFornecedor.Enabled = status;
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

            cmbTipoAtendimento.SelectedIndex = 0;
        }

        private void trocaCorCIP()
        {
            for (int i = 0; i < dgvAtendimento.Rows.Count; i++)
            {
                if (dgvAtendimento.Rows[i].Cells["tipoAtendimento"].Value.ToString() == "CIP")
                {
                    dgvAtendimento.Rows[i].Cells["tipoAtendimento"].Style.BackColor = Color.Orange;
                }
            }
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

            dgvAtendimento.DataSource = "";
            dgvAtendimento.DataSource = dados.ToList();

            trocaCorCIP();

        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            btnEncerrar.Text = "Encerrar";
            btnEncerrar.UseColumnTextForButtonValue = true;

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
                try
                {
                    dtpEncerramento.Text = dgvAtendimento.SelectedRows[0].Cells["dataEncerramento"].Value.ToString();
                }
                catch (System.NullReferenceException)
                {
                    dtpEncerramento.Text = "";
                }

                habilitaCampos(false);

                lbEncaminhar.Enabled = true;
                lbEncaminhar.Enabled = true;

                btnAndamentos.Visible = true;
                lbEncaminhar.Visible = true;
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
        
        private void Pesquisar()
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
            trocaCorCIP();

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPesquisar.Text == "") 
                Pesquisar();
        }

        private void lbNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            cmbTipoAtendimento.ResetText();
            habilitaCampos(true);
            txtId.Text = "-1";
            txtnumeroProcon.Focus();
            btnAndamentos.Visible = false;
            lbEncaminhar.Visible = false;

            //dtpInicio.Text = DateTime.Now.ToShortDateString().ToString();


            dtpInicio.Text = DateTime.Now.ToShortDateString();
            
            AlteracaoAtendimento alteracaoAtendimento = new AlteracaoAtendimento();
            SGAPContexto contexto = new SGAPContexto();
            alteracaoAtendimento = contexto.AlteracaoAtendimento.OrderByDescending(x => x.id).FirstOrDefault(x => x.usuario.Equals(menu.usuario));
            
            if(alteracaoAtendimento == null)
            {
                txtnumeroProcon.Text = "001-" + DateTime.Now.Year + "-" + menu.usuario;
            }
            else if(alteracaoAtendimento.dataInicio.Year != DateTime.Now.Year)
            {
                txtnumeroProcon.Text = "001-" + DateTime.Now.Year + "-" + menu.usuario;
            }
            else
            {
                txtnumeroProcon.Text = (Convert.ToInt32(alteracaoAtendimento.numeroProcon.Substring(0, 3)) + 1).ToString("000") + "-" + DateTime.Now.Year + "-" + menu.usuario;
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
            lbEncaminhar.Visible = false;
        }

        private void lbSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
                Modelo.Atendimento atendimentoVerifica = new Modelo.Atendimento();

                int ano = (Convert.ToDateTime(dtpInicio.Text)).Year;
                int mes = (Convert.ToDateTime(dtpInicio.Text)).Month;

                atendimentoVerifica = contexto.Atendimento.FirstOrDefault(x => x.numeroProcon.Equals(txtnumeroProcon.Text) && x.dataInicio.Month == mes && x.dataInicio.Year == ano && txtId.Text == "-1");

                if (atendimentoVerifica == null)
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
                        atendimento.dataInicio = Convert.ToDateTime(dtpInicio.Text);

                        try
                        {
                            if (dtpEncerramento.Text == "  /  /")
                            {
                                atendimento.dataEncerramento = null;
                            }
                            else
                            {
                                atendimento.dataEncerramento = Convert.ToDateTime(dtpEncerramento.Text);
                            }
                        }
                        catch (System.FormatException)
                        {
                            atendimento.dataEncerramento = null;
                        }

                        atendimento.usuario = menu.usuario;

                        try
                        {
                            if (atendimento.id == -1)
                            {

                                contexto.Atendimento.Add(atendimento);
                                contexto.SaveChanges();
                                limparCampos();
                                btnAndamentos.Visible = false;
                                lbEncaminhar.Visible = false;
                                habilitaCampos(false);
                            }

                            else
                            {
                                contexto.Entry(atendimento).State = EntityState.Modified;
                                contexto.SaveChanges();
                                habilitaCampos(false);
                            }

                            FuncGeral.trigger(atendimento, menu.usuario);
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException)
                        {
                            MessageBox.Show("Número atendimento é obrigatório", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Por favor, confirme se todos os dados foram preenchidos!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void lbRemover_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            Modelo.Atendimento atendimento = new Modelo.Atendimento();
            List<AlteracaoAtendimento> lstAlteracaoAtendimento = new List<AlteracaoAtendimento>();

            btnAndamentos.Visible = false;
            lbEncaminhar.Visible = false;

            if (txtId.Text == "")
                txtId.Text = "0";

            int id = Convert.ToInt32(txtId.Text);

            if (id > 0)
            {
                atendimento = contexto.Atendimento.Find(id);
                lstAlteracaoAtendimento = contexto.AlteracaoAtendimento.Where(x => x.atendimentoID == id).ToList();

                DialogResult result; // confirmação da remoção
                result = MessageBox.Show("Confirma remoção do atendimento?", "Remover", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach(AlteracaoAtendimento alteracaoAtendimento in lstAlteracaoAtendimento)
                        {
                            contexto.AlteracaoAtendimento.Remove(alteracaoAtendimento);
                        }

                        contexto.Atendimento.Remove(atendimento);
                        contexto.SaveChanges();          // atualiza o banco de dados 

                        carregarGridAtendimento();
                        limparCampos();
                        habilitaCampos(false);

                        MessageBox.Show("Atendimento removido com sucesso!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("Atendimento não pode ser excluído, pois há históricos de andamento no mesmo!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else MessageBox.Show("Não há registo para remoção!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                
            if (e.KeyCode == Keys.F6 && lbEncaminhar.Enabled == true)
                lbMovimentar_Click(sender, e);
            if (e.Alt && e.KeyCode == Keys.X)
            {
                DialogResult result;
                result = MessageBox.Show("Deseja sair da tela de atendimento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                    menu.atendimentoAberto = 0;
                }
            }                

        }

        private void txtnumeroProcon_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lbMovimentar_MouseEnter(object sender, EventArgs e)
        {
            lbEncaminhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            lbEncaminhar.ForeColor = System.Drawing.Color.White;
        }

        private void lbMovimentar_MouseLeave(object sender, EventArgs e)
        {
            lbEncaminhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            lbEncaminhar.ForeColor = System.Drawing.Color.Black;
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
            TipoAtendimento tipoAtendimento = new TipoAtendimento();
            int id = Convert.ToInt32(Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["tipoAtendimentoID"].Value));
            tipoAtendimento = contexto.TipoAtendimento.FirstOrDefault(x => x.id == id);

            if (tipoAtendimento.descricao.ToLower().Trim() == "cip")
            {
                MessageBox.Show("Esse registro ja é uma CIP", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            else
            {
                DialogResult result;
                result = MessageBox.Show("Deseja transformar o atendimento " + dgvAtendimento.SelectedRows[0].Cells["numeroProcon"].Value.ToString() + " em CIP?", "Encerrar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    Atendimento atendimento = new Atendimento();
                    SGAPContexto contexto = new SGAPContexto();
                    AlteracaoAtendimento alteracao = new AlteracaoAtendimento();

                    tipoAtendimento = contexto.TipoAtendimento.First(x => x.descricao.ToLower().Trim().Equals("cip"));
                   
                    atendimento.id = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["id"].Value);

                    // aqui
                    novoCIP(atendimento);

                    atendimento.consumidorID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["consumidorID"].Value);
                    atendimento.fornecedorID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["fornecedorID"].Value);
                    atendimento.tipoAtendimentoID = tipoAtendimento.id;
                    atendimento.tipoReclamacaoID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["tipoReclamacaoID"].Value);
                    atendimento.problemaPrincipalID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["problemaPrincipalID"].Value);
                    atendimento.reclamacao = dgvAtendimento.SelectedRows[0].Cells["reclamacao"].Value.ToString();
                    atendimento.dataInicio = Convert.ToDateTime(dgvAtendimento.SelectedRows[0].Cells["dataInicio"].Value.ToString());
                    atendimento.dataEncerramento = DateTime.Now;                   

                    contexto.Entry(atendimento).State = EntityState.Modified;
                    contexto.SaveChanges();

                    FuncGeral.trigger(atendimento, menu.usuario);

                    carregarGridAtendimento();
                }
            }
           
        }

        private void cmbConsumidor_Click(object sender, EventArgs e)
        {
            Modelo.SGAPContexto contexto = new Modelo.SGAPContexto();
            cmbConsumidor.DataSource = contexto.Consumidor.ToList();
        }

        private void cmbTipoAtendimento_Click(object sender, EventArgs e)
        {
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

        private void picPesquisarConsumidor_Click(object sender, EventArgs e)
        {
            frmPesquisaEntidade pesquisaEntidade = new frmPesquisaEntidade(this, "consumidor");
            pesquisaEntidade.ShowDialog();

            if(idCombo > 0)
            {
                cmbConsumidor.DisplayMember = "descConsumidor";
                cmbConsumidor.ValueMember = "id";
                cmbConsumidor.DataSource = contexto.Consumidor.Where(x => x.id == idCombo).OrderBy(p => p.nome).ToList();
            }
        }

        private void picPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            frmPesquisaEntidade pesquisaEntidade = new frmPesquisaEntidade(this, "fornecedor");
            pesquisaEntidade.ShowDialog();

            cmbFornecedor.DisplayMember = "razaoSocial";
            cmbFornecedor.ValueMember = "id";
            cmbFornecedor.DataSource = contexto.Fornecedor.Where(x => x.id == idCombo).OrderBy(p => p.razaoSocial).ToList();
        }

        private void dgvAtendimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAtendimento.Columns["btnEncerrar"].Index && e.RowIndex >= 0)
            {
                DialogResult result;
                result = MessageBox.Show("Deseja encerrar o atendimento?", "Encerrar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if(result == DialogResult.Yes)
                {

                    Atendimento atendimento = new Atendimento();
                    SGAPContexto contexto = new SGAPContexto();

                    atendimento.id = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["id"].Value);
                    atendimento.numeroProcon = dgvAtendimento.SelectedRows[0].Cells["numeroProcon"].Value.ToString();
                    atendimento.consumidorID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["consumidorID"].Value);
                    atendimento.fornecedorID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["fornecedorID"].Value);
                    atendimento.tipoAtendimentoID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["tipoAtendimentoID"].Value);
                    atendimento.tipoReclamacaoID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["tipoReclamacaoID"].Value);
                    atendimento.problemaPrincipalID = Convert.ToInt32(dgvAtendimento.SelectedRows[0].Cells["problemaPrincipalID"].Value);
                    atendimento.reclamacao = dgvAtendimento.SelectedRows[0].Cells["reclamacao"].Value.ToString();
                    atendimento.dataInicio = Convert.ToDateTime(dgvAtendimento.SelectedRows[0].Cells["dataInicio"].Value.ToString());
                    atendimento.dataEncerramento = DateTime.Now;

                    contexto.Entry(atendimento).State = EntityState.Modified;
                    contexto.SaveChanges();

                    FuncGeral.trigger(atendimento, menu.usuario);

                    carregarGridAtendimento();

                }

               
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Pesquisar();
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisar.Text == "")
                Pesquisar();
        }

        private void cmbTipoAtendimento_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbTipoAtendimento.Text == "CIP")
            {
                Atendimento atendimento = new Atendimento();
                novoCIP(atendimento);
                txtnumeroProcon.Text = atendimento.numeroProcon;
            }
        }

        private void frmAtendimento_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.atendimentoAberto = 0;
        }

        private void cmbTipoReclamacao_Click(object sender, EventArgs e)
        {
            cmbTipoReclamacao.DisplayMember = "descricao";
            cmbTipoReclamacao.ValueMember = "id";
            cmbTipoReclamacao.DataSource = contexto.TipoReclamacao.ToList().OrderBy(p => p.descricao).ToList();
        }
    }
}
