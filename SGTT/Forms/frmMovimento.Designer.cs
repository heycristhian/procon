namespace SGAP.Forms
{
    partial class frmMovimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbTipoAtendimento = new System.Windows.Forms.ComboBox();
            this.cmbAtendimento = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dgvMovimento = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroProcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumidorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtendimentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReclamacaoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReclamacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemaPrincipalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemaPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEncerramento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSalvar = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbRemover = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.lbNovo = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbFechar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Atendimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tipo Atendimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 80;
            this.label5.Text = "Histórico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Resultado:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(529, 143);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 82;
            this.txtId.Visible = false;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(188, 29);
            this.txtHistorico.MaxLength = 100;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(556, 20);
            this.txtHistorico.TabIndex = 83;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(188, 85);
            this.txtResultado.MaxLength = 100;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(556, 20);
            this.txtResultado.TabIndex = 84;
            // 
            // cmbTipoAtendimento
            // 
            this.cmbTipoAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAtendimento.FormattingEnabled = true;
            this.cmbTipoAtendimento.Location = new System.Drawing.Point(15, 84);
            this.cmbTipoAtendimento.Name = "cmbTipoAtendimento";
            this.cmbTipoAtendimento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAtendimento.TabIndex = 85;
            // 
            // cmbAtendimento
            // 
            this.cmbAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtendimento.FormattingEnabled = true;
            this.cmbAtendimento.Location = new System.Drawing.Point(15, 28);
            this.cmbAtendimento.Name = "cmbAtendimento";
            this.cmbAtendimento.Size = new System.Drawing.Size(121, 21);
            this.cmbAtendimento.TabIndex = 86;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(15, 143);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(121, 20);
            this.dtpData.TabIndex = 87;
            // 
            // dgvMovimento
            // 
            this.dgvMovimento.AllowUserToAddRows = false;
            this.dgvMovimento.AllowUserToDeleteRows = false;
            this.dgvMovimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data,
            this.historico,
            this.resultado,
            this.atendimentoID,
            this.numeroProcon,
            this.consumidorID,
            this.tipoAtendimentoID,
            this.tipoAtendimento,
            this.tipoReclamacaoID,
            this.tipoReclamacao,
            this.problemaPrincipalID,
            this.problemaPrincipal,
            this.dataInicio,
            this.dataEncerramento,
            this.consumidor,
            this.fornecedorID,
            this.fornecedor});
            this.dgvMovimento.Location = new System.Drawing.Point(12, 333);
            this.dgvMovimento.Name = "dgvMovimento";
            this.dgvMovimento.ReadOnly = true;
            this.dgvMovimento.Size = new System.Drawing.Size(770, 190);
            this.dgvMovimento.TabIndex = 88;
            this.dgvMovimento.DoubleClick += new System.EventHandler(this.dgvMovimento_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle4;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // historico
            // 
            this.historico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.historico.DataPropertyName = "historico";
            this.historico.HeaderText = "Histórico";
            this.historico.Name = "historico";
            this.historico.ReadOnly = true;
            this.historico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.historico.Width = 54;
            // 
            // resultado
            // 
            this.resultado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.resultado.DataPropertyName = "resultado";
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.resultado.Width = 61;
            // 
            // atendimentoID
            // 
            this.atendimentoID.DataPropertyName = "atendimentoID";
            this.atendimentoID.HeaderText = "AtendimentoID";
            this.atendimentoID.Name = "atendimentoID";
            this.atendimentoID.ReadOnly = true;
            this.atendimentoID.Visible = false;
            // 
            // numeroProcon
            // 
            this.numeroProcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroProcon.DataPropertyName = "numeroProcon";
            this.numeroProcon.HeaderText = "Número Atendimento";
            this.numeroProcon.Name = "numeroProcon";
            this.numeroProcon.ReadOnly = true;
            this.numeroProcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numeroProcon.Width = 101;
            // 
            // consumidorID
            // 
            this.consumidorID.DataPropertyName = "consumidorID";
            this.consumidorID.HeaderText = "ConsumidorID";
            this.consumidorID.Name = "consumidorID";
            this.consumidorID.ReadOnly = true;
            this.consumidorID.Visible = false;
            // 
            // tipoAtendimentoID
            // 
            this.tipoAtendimentoID.DataPropertyName = "tipoAtendimentoID";
            this.tipoAtendimentoID.HeaderText = "TipoAtendimentoID";
            this.tipoAtendimentoID.Name = "tipoAtendimentoID";
            this.tipoAtendimentoID.ReadOnly = true;
            this.tipoAtendimentoID.Visible = false;
            // 
            // tipoAtendimento
            // 
            this.tipoAtendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoAtendimento.DataPropertyName = "tipoAtendimento";
            this.tipoAtendimento.HeaderText = "Tipo Atendimento";
            this.tipoAtendimento.Name = "tipoAtendimento";
            this.tipoAtendimento.ReadOnly = true;
            this.tipoAtendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipoAtendimento.Width = 86;
            // 
            // tipoReclamacaoID
            // 
            this.tipoReclamacaoID.DataPropertyName = "tipoReclamacaoID";
            this.tipoReclamacaoID.HeaderText = "TipoReclamacaoID";
            this.tipoReclamacaoID.Name = "tipoReclamacaoID";
            this.tipoReclamacaoID.ReadOnly = true;
            this.tipoReclamacaoID.Visible = false;
            // 
            // tipoReclamacao
            // 
            this.tipoReclamacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoReclamacao.DataPropertyName = "tipoReclamacao";
            this.tipoReclamacao.HeaderText = "Reclamacão";
            this.tipoReclamacao.Name = "tipoReclamacao";
            this.tipoReclamacao.ReadOnly = true;
            this.tipoReclamacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipoReclamacao.Width = 73;
            // 
            // problemaPrincipalID
            // 
            this.problemaPrincipalID.DataPropertyName = "problemaPrincipalID";
            this.problemaPrincipalID.HeaderText = "ProblemaPrincipalID";
            this.problemaPrincipalID.Name = "problemaPrincipalID";
            this.problemaPrincipalID.ReadOnly = true;
            this.problemaPrincipalID.Visible = false;
            // 
            // problemaPrincipal
            // 
            this.problemaPrincipal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.problemaPrincipal.DataPropertyName = "problemaPrincipal";
            this.problemaPrincipal.HeaderText = "Problema Principal";
            this.problemaPrincipal.Name = "problemaPrincipal";
            this.problemaPrincipal.ReadOnly = true;
            this.problemaPrincipal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.problemaPrincipal.Width = 90;
            // 
            // dataInicio
            // 
            this.dataInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataInicio.DataPropertyName = "dataInicio";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dataInicio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataInicio.HeaderText = "Data início";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            this.dataInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataInicio.Width = 59;
            // 
            // dataEncerramento
            // 
            this.dataEncerramento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataEncerramento.DataPropertyName = "dataEncerramento";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dataEncerramento.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataEncerramento.HeaderText = "Data Encerramento";
            this.dataEncerramento.Name = "dataEncerramento";
            this.dataEncerramento.ReadOnly = true;
            this.dataEncerramento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataEncerramento.Width = 95;
            // 
            // consumidor
            // 
            this.consumidor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.consumidor.DataPropertyName = "nomeConsumidor";
            this.consumidor.HeaderText = "Consumidor";
            this.consumidor.Name = "consumidor";
            this.consumidor.ReadOnly = true;
            this.consumidor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.consumidor.Width = 68;
            // 
            // fornecedorID
            // 
            this.fornecedorID.DataPropertyName = "fornecedorID";
            this.fornecedorID.HeaderText = "FornecedorID";
            this.fornecedorID.Name = "fornecedorID";
            this.fornecedorID.ReadOnly = true;
            this.fornecedorID.Visible = false;
            // 
            // fornecedor
            // 
            this.fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fornecedor.Width = 67;
            // 
            // lbSalvar
            // 
            this.lbSalvar.AutoSize = true;
            this.lbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbSalvar.Image = global::SGAP.Properties.Resources.salvar;
            this.lbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSalvar.Location = new System.Drawing.Point(648, 186);
            this.lbSalvar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbSalvar.Name = "lbSalvar";
            this.lbSalvar.Size = new System.Drawing.Size(64, 75);
            this.lbSalvar.TabIndex = 106;
            this.lbSalvar.Text = "Salvar \n(F4)";
            this.lbSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbSalvar.Click += new System.EventHandler(this.lbSalvar_Click);
            this.lbSalvar.MouseEnter += new System.EventHandler(this.lbSalvar_MouseEnter);
            this.lbSalvar.MouseLeave += new System.EventHandler(this.lbSalvar_MouseLeave);
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbCancelar.Image = global::SGAP.Properties.Resources.cancelar;
            this.lbCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCancelar.Location = new System.Drawing.Point(718, 186);
            this.lbCancelar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(64, 75);
            this.lbCancelar.TabIndex = 107;
            this.lbCancelar.Text = "Cancelar \n(F5)";
            this.lbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            this.lbCancelar.MouseEnter += new System.EventHandler(this.lbCancelar_MouseEnter);
            this.lbCancelar.MouseLeave += new System.EventHandler(this.lbCancelar_MouseLeave);
            // 
            // lbRemover
            // 
            this.lbRemover.AutoSize = true;
            this.lbRemover.BackColor = System.Drawing.Color.White;
            this.lbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbRemover.Image = global::SGAP.Properties.Resources.remover;
            this.lbRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbRemover.Location = new System.Drawing.Point(530, 186);
            this.lbRemover.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbRemover.Name = "lbRemover";
            this.lbRemover.Size = new System.Drawing.Size(64, 75);
            this.lbRemover.TabIndex = 105;
            this.lbRemover.Text = "Remover \n(F3)";
            this.lbRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbRemover.Click += new System.EventHandler(this.lbRemover_Click);
            this.lbRemover.MouseEnter += new System.EventHandler(this.lbRemover_MouseEnter);
            this.lbRemover.MouseLeave += new System.EventHandler(this.lbRemover_MouseLeave);
            // 
            // lbEditar
            // 
            this.lbEditar.AutoSize = true;
            this.lbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbEditar.Image = global::SGAP.Properties.Resources.modificar;
            this.lbEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbEditar.Location = new System.Drawing.Point(460, 186);
            this.lbEditar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(64, 75);
            this.lbEditar.TabIndex = 104;
            this.lbEditar.Text = "Editar \n(F2)";
            this.lbEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbEditar.Click += new System.EventHandler(this.lbEditar_Click);
            this.lbEditar.MouseEnter += new System.EventHandler(this.lbEditar_MouseEnter);
            this.lbEditar.MouseLeave += new System.EventHandler(this.lbEditar_MouseLeave);
            // 
            // lbNovo
            // 
            this.lbNovo.AutoSize = true;
            this.lbNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbNovo.Image = global::SGAP.Properties.Resources.novo;
            this.lbNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNovo.Location = new System.Drawing.Point(392, 186);
            this.lbNovo.MinimumSize = new System.Drawing.Size(62, 75);
            this.lbNovo.Name = "lbNovo";
            this.lbNovo.Size = new System.Drawing.Size(62, 75);
            this.lbNovo.TabIndex = 103;
            this.lbNovo.Text = "Novo \n(F1)";
            this.lbNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbNovo.Click += new System.EventHandler(this.lbNovo_Click);
            this.lbNovo.MouseEnter += new System.EventHandler(this.lbNovo_MouseEnter);
            this.lbNovo.MouseLeave += new System.EventHandler(this.lbNovo_MouseLeave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 305);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(447, 22);
            this.txtPesquisar.TabIndex = 109;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.Location = new System.Drawing.Point(9, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 108;
            this.label15.Text = "Buscar:";
            // 
            // lbFechar
            // 
            this.lbFechar.AutoSize = true;
            this.lbFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.lbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechar.Location = new System.Drawing.Point(662, 526);
            this.lbFechar.MaximumSize = new System.Drawing.Size(101, 23);
            this.lbFechar.MinimumSize = new System.Drawing.Size(120, 30);
            this.lbFechar.Name = "lbFechar";
            this.lbFechar.Size = new System.Drawing.Size(120, 30);
            this.lbFechar.TabIndex = 110;
            this.lbFechar.Text = "FECHAR (Alt+X)";
            this.lbFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFechar.Click += new System.EventHandler(this.lbFechar_Click);
            this.lbFechar.MouseEnter += new System.EventHandler(this.lbFechar_MouseEnter);
            this.lbFechar.MouseLeave += new System.EventHandler(this.lbFechar_MouseLeave);
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 577);
            this.Controls.Add(this.lbFechar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbSalvar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbRemover);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.lbNovo);
            this.Controls.Add(this.dgvMovimento);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbAtendimento);
            this.Controls.Add(this.cmbTipoAtendimento);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frmMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentar";
            this.Load += new System.EventHandler(this.frmMovimento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbTipoAtendimento;
        private System.Windows.Forms.ComboBox cmbAtendimento;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView dgvMovimento;
        private System.Windows.Forms.Label lbSalvar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbRemover;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label lbNovo;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendimentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroProcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumidorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtendimentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReclamacaoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReclamacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemaPrincipalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemaPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEncerramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}