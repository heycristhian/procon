namespace SGAP.Forms
{
    partial class frmAtendimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.cmbConsumidor = new System.Windows.Forms.ComboBox();
            this.txtnumeroProcon = new System.Windows.Forms.TextBox();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.cmbProblema = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoAtendimento = new System.Windows.Forms.ComboBox();
            this.cmbTipoReclamacao = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbMovimentar = new System.Windows.Forms.Label();
            this.lbEncaminhar = new System.Windows.Forms.Label();
            this.lblExpandirDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoProblema = new System.Windows.Forms.TextBox();
            this.picPesquisarFornecedor = new System.Windows.Forms.PictureBox();
            this.picPesquisarConsumidor = new System.Windows.Forms.PictureBox();
            this.btnAndamentos = new System.Windows.Forms.Button();
            this.lbRemover = new System.Windows.Forms.Label();
            this.lbSalvar = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.lbNovo = new System.Windows.Forms.Label();
            this.picProblema = new System.Windows.Forms.PictureBox();
            this.picAddFornecedor = new System.Windows.Forms.PictureBox();
            this.picAddConsumidor = new System.Windows.Forms.PictureBox();
            this.dtpInicio = new System.Windows.Forms.MaskedTextBox();
            this.dtpEncerramento = new System.Windows.Forms.MaskedTextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtendimentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReclamacaoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroProcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumidorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReclamacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemaPrincipalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemaPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reclamacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEncerramento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEncerrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisarConsumidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProblema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddConsumidor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Problema Principal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nº Atendimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data Início:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Encerramento:";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(15, 314);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(218, 24);
            this.cmbFornecedor.TabIndex = 6;
            this.cmbFornecedor.Click += new System.EventHandler(this.cmbFornecedor_Click);
            // 
            // cmbConsumidor
            // 
            this.cmbConsumidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsumidor.FormattingEnabled = true;
            this.cmbConsumidor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbConsumidor.Location = new System.Drawing.Point(15, 256);
            this.cmbConsumidor.Name = "cmbConsumidor";
            this.cmbConsumidor.Size = new System.Drawing.Size(218, 24);
            this.cmbConsumidor.TabIndex = 5;
            this.cmbConsumidor.Click += new System.EventHandler(this.cmbConsumidor_Click);
            // 
            // txtnumeroProcon
            // 
            this.txtnumeroProcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeroProcon.Location = new System.Drawing.Point(15, 28);
            this.txtnumeroProcon.MaxLength = 30;
            this.txtnumeroProcon.Name = "txtnumeroProcon";
            this.txtnumeroProcon.Size = new System.Drawing.Size(248, 22);
            this.txtnumeroProcon.TabIndex = 1;
            this.txtnumeroProcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeroProcon_KeyPress);
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.AllowUserToAddRows = false;
            this.dgvAtendimento.AllowUserToDeleteRows = false;
            this.dgvAtendimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtendimento.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipoAtendimentoID,
            this.tipoReclamacaoID,
            this.numeroProcon,
            this.tipoAtendimento,
            this.consumidorID,
            this.consumidor,
            this.fornecedorID,
            this.fornecedor,
            this.tipoReclamacao,
            this.problemaPrincipalID,
            this.problemaPrincipal,
            this.reclamacao,
            this.dataInicio,
            this.dataEncerramento,
            this.btnEncerrar});
            this.dgvAtendimento.Location = new System.Drawing.Point(329, 172);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.ReadOnly = true;
            this.dgvAtendimento.Size = new System.Drawing.Size(653, 438);
            this.dgvAtendimento.TabIndex = 16;
            this.dgvAtendimento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtendimento_CellClick);
            this.dgvAtendimento.DoubleClick += new System.EventHandler(this.dgvAtendimento_DoubleClick);
            // 
            // cmbProblema
            // 
            this.cmbProblema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProblema.FormattingEnabled = true;
            this.cmbProblema.Location = new System.Drawing.Point(15, 201);
            this.cmbProblema.Name = "cmbProblema";
            this.cmbProblema.Size = new System.Drawing.Size(248, 24);
            this.cmbProblema.TabIndex = 4;
            this.cmbProblema.Click += new System.EventHandler(this.cmbProblema_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Tipo Atendimento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 73;
            this.label10.Text = "Tipo Reclamação:";
            // 
            // cmbTipoAtendimento
            // 
            this.cmbTipoAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAtendimento.FormattingEnabled = true;
            this.cmbTipoAtendimento.Location = new System.Drawing.Point(15, 83);
            this.cmbTipoAtendimento.Name = "cmbTipoAtendimento";
            this.cmbTipoAtendimento.Size = new System.Drawing.Size(248, 24);
            this.cmbTipoAtendimento.TabIndex = 2;
            this.cmbTipoAtendimento.Click += new System.EventHandler(this.cmbTipoAtendimento_Click);
            // 
            // cmbTipoReclamacao
            // 
            this.cmbTipoReclamacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReclamacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoReclamacao.FormattingEnabled = true;
            this.cmbTipoReclamacao.Location = new System.Drawing.Point(15, 143);
            this.cmbTipoReclamacao.Name = "cmbTipoReclamacao";
            this.cmbTipoReclamacao.Size = new System.Drawing.Size(248, 24);
            this.cmbTipoReclamacao.TabIndex = 3;
            this.cmbTipoReclamacao.SelectedIndexChanged += new System.EventHandler(this.cmbTipoReclamacao_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(882, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 77;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(326, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Buscar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(329, 140);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(336, 22);
            this.txtPesquisar.TabIndex = 88;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lbMovimentar
            // 
            this.lbMovimentar.AutoSize = true;
            this.lbMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            this.lbMovimentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMovimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovimentar.Location = new System.Drawing.Point(715, 132);
            this.lbMovimentar.MaximumSize = new System.Drawing.Size(101, 23);
            this.lbMovimentar.MinimumSize = new System.Drawing.Size(120, 30);
            this.lbMovimentar.Name = "lbMovimentar";
            this.lbMovimentar.Size = new System.Drawing.Size(120, 30);
            this.lbMovimentar.TabIndex = 89;
            this.lbMovimentar.Text = "MOVIMENTAR (F6)";
            this.lbMovimentar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMovimentar.Click += new System.EventHandler(this.lbMovimentar_Click);
            this.lbMovimentar.MouseEnter += new System.EventHandler(this.lbMovimentar_MouseEnter);
            this.lbMovimentar.MouseLeave += new System.EventHandler(this.lbMovimentar_MouseLeave);
            // 
            // lbEncaminhar
            // 
            this.lbEncaminhar.AutoSize = true;
            this.lbEncaminhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            this.lbEncaminhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEncaminhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncaminhar.Location = new System.Drawing.Point(841, 132);
            this.lbEncaminhar.MaximumSize = new System.Drawing.Size(101, 23);
            this.lbEncaminhar.MinimumSize = new System.Drawing.Size(120, 30);
            this.lbEncaminhar.Name = "lbEncaminhar";
            this.lbEncaminhar.Size = new System.Drawing.Size(120, 30);
            this.lbEncaminhar.TabIndex = 90;
            this.lbEncaminhar.Text = "ENCAMINHAR (F7)";
            this.lbEncaminhar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEncaminhar.Click += new System.EventHandler(this.lbEncaminhar_Click);
            this.lbEncaminhar.MouseEnter += new System.EventHandler(this.lbEncaminhar_MouseEnter);
            this.lbEncaminhar.MouseLeave += new System.EventHandler(this.lbEncaminhar_MouseLeave);
            // 
            // lblExpandirDescricao
            // 
            this.lblExpandirDescricao.AutoSize = true;
            this.lblExpandirDescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExpandirDescricao.Font = new System.Drawing.Font("Decker", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpandirDescricao.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblExpandirDescricao.Location = new System.Drawing.Point(131, 456);
            this.lblExpandirDescricao.Name = "lblExpandirDescricao";
            this.lblExpandirDescricao.Size = new System.Drawing.Size(136, 16);
            this.lblExpandirDescricao.TabIndex = 91;
            this.lblExpandirDescricao.Text = "Expandir descrição";
            this.lblExpandirDescricao.Click += new System.EventHandler(this.lblExpandirDescricao_Click);
            // 
            // txtDescricaoProblema
            // 
            this.txtDescricaoProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProblema.Location = new System.Drawing.Point(15, 381);
            this.txtDescricaoProblema.MaxLength = 8000;
            this.txtDescricaoProblema.Multiline = true;
            this.txtDescricaoProblema.Name = "txtDescricaoProblema";
            this.txtDescricaoProblema.Size = new System.Drawing.Size(248, 72);
            this.txtDescricaoProblema.TabIndex = 7;
            // 
            // picPesquisarFornecedor
            // 
            this.picPesquisarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPesquisarFornecedor.Image = global::SGAP.Properties.Resources.search24px;
            this.picPesquisarFornecedor.Location = new System.Drawing.Point(239, 314);
            this.picPesquisarFornecedor.Name = "picPesquisarFornecedor";
            this.picPesquisarFornecedor.Size = new System.Drawing.Size(24, 24);
            this.picPesquisarFornecedor.TabIndex = 94;
            this.picPesquisarFornecedor.TabStop = false;
            this.picPesquisarFornecedor.Click += new System.EventHandler(this.picPesquisarFornecedor_Click);
            // 
            // picPesquisarConsumidor
            // 
            this.picPesquisarConsumidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPesquisarConsumidor.Image = global::SGAP.Properties.Resources.search24px;
            this.picPesquisarConsumidor.Location = new System.Drawing.Point(239, 256);
            this.picPesquisarConsumidor.Name = "picPesquisarConsumidor";
            this.picPesquisarConsumidor.Size = new System.Drawing.Size(24, 24);
            this.picPesquisarConsumidor.TabIndex = 93;
            this.picPesquisarConsumidor.TabStop = false;
            this.picPesquisarConsumidor.Click += new System.EventHandler(this.picPesquisarConsumidor_Click);
            // 
            // btnAndamentos
            // 
            this.btnAndamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            this.btnAndamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAndamentos.FlatAppearance.BorderSize = 0;
            this.btnAndamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAndamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndamentos.ForeColor = System.Drawing.Color.Black;
            this.btnAndamentos.Image = global::SGAP.Properties.Resources.add;
            this.btnAndamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAndamentos.Location = new System.Drawing.Point(15, 486);
            this.btnAndamentos.Name = "btnAndamentos";
            this.btnAndamentos.Size = new System.Drawing.Size(246, 34);
            this.btnAndamentos.TabIndex = 92;
            this.btnAndamentos.Text = "Andamentos";
            this.btnAndamentos.UseVisualStyleBackColor = false;
            this.btnAndamentos.Visible = false;
            this.btnAndamentos.Click += new System.EventHandler(this.btnAndamentos_Click);
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
            this.lbRemover.Location = new System.Drawing.Point(601, 28);
            this.lbRemover.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbRemover.Name = "lbRemover";
            this.lbRemover.Size = new System.Drawing.Size(64, 75);
            this.lbRemover.TabIndex = 87;
            this.lbRemover.Text = "Remover \n(F3)";
            this.lbRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbRemover.Click += new System.EventHandler(this.lbRemover_Click);
            this.lbRemover.MouseEnter += new System.EventHandler(this.lbRemover_MouseEnter);
            this.lbRemover.MouseLeave += new System.EventHandler(this.lbRemover_MouseLeave);
            // 
            // lbSalvar
            // 
            this.lbSalvar.AutoSize = true;
            this.lbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbSalvar.Image = global::SGAP.Properties.Resources.salvar;
            this.lbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSalvar.Location = new System.Drawing.Point(52, 529);
            this.lbSalvar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbSalvar.Name = "lbSalvar";
            this.lbSalvar.Size = new System.Drawing.Size(64, 75);
            this.lbSalvar.TabIndex = 10;
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
            this.lbCancelar.Location = new System.Drawing.Point(158, 529);
            this.lbCancelar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(64, 75);
            this.lbCancelar.TabIndex = 85;
            this.lbCancelar.Text = "Cancelar \n(F5)";
            this.lbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            this.lbCancelar.MouseEnter += new System.EventHandler(this.lbCancelar_MouseEnter);
            this.lbCancelar.MouseLeave += new System.EventHandler(this.lbCancelar_MouseLeave);
            // 
            // lbEditar
            // 
            this.lbEditar.AutoSize = true;
            this.lbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbEditar.Image = global::SGAP.Properties.Resources.modificar;
            this.lbEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbEditar.Location = new System.Drawing.Point(531, 28);
            this.lbEditar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(64, 75);
            this.lbEditar.TabIndex = 84;
            this.lbEditar.Text = "Editar \n(F2)";
            this.lbEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbEditar.Click += new System.EventHandler(this.lbEditar_Click);
            this.lbEditar.DragLeave += new System.EventHandler(this.lbNovo_MouseEnter);
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
            this.lbNovo.Location = new System.Drawing.Point(463, 28);
            this.lbNovo.MinimumSize = new System.Drawing.Size(62, 75);
            this.lbNovo.Name = "lbNovo";
            this.lbNovo.Size = new System.Drawing.Size(62, 75);
            this.lbNovo.TabIndex = 83;
            this.lbNovo.Text = "Novo \n(F1)";
            this.lbNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbNovo.Click += new System.EventHandler(this.lbNovo_Click);
            this.lbNovo.MouseEnter += new System.EventHandler(this.lbNovo_MouseEnter);
            this.lbNovo.MouseLeave += new System.EventHandler(this.lbNovo_MouseLeave);
            // 
            // picProblema
            // 
            this.picProblema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProblema.Image = global::SGAP.Properties.Resources.add;
            this.picProblema.Location = new System.Drawing.Point(269, 197);
            this.picProblema.Name = "picProblema";
            this.picProblema.Size = new System.Drawing.Size(28, 28);
            this.picProblema.TabIndex = 79;
            this.picProblema.TabStop = false;
            this.picProblema.Click += new System.EventHandler(this.picProblema_Click);
            // 
            // picAddFornecedor
            // 
            this.picAddFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddFornecedor.Image = global::SGAP.Properties.Resources.add;
            this.picAddFornecedor.Location = new System.Drawing.Point(269, 314);
            this.picAddFornecedor.Name = "picAddFornecedor";
            this.picAddFornecedor.Size = new System.Drawing.Size(28, 28);
            this.picAddFornecedor.TabIndex = 78;
            this.picAddFornecedor.TabStop = false;
            this.picAddFornecedor.Click += new System.EventHandler(this.picAddFornecedor_Click);
            // 
            // picAddConsumidor
            // 
            this.picAddConsumidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddConsumidor.Image = global::SGAP.Properties.Resources.add;
            this.picAddConsumidor.Location = new System.Drawing.Point(269, 252);
            this.picAddConsumidor.Name = "picAddConsumidor";
            this.picAddConsumidor.Size = new System.Drawing.Size(28, 28);
            this.picAddConsumidor.TabIndex = 76;
            this.picAddConsumidor.TabStop = false;
            this.picAddConsumidor.Click += new System.EventHandler(this.picAddConsumidor_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(329, 28);
            this.dtpInicio.Mask = "00/00/0000";
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(100, 21);
            this.dtpInicio.TabIndex = 95;
            this.dtpInicio.ValidatingType = typeof(System.DateTime);
            // 
            // dtpEncerramento
            // 
            this.dtpEncerramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEncerramento.Location = new System.Drawing.Point(329, 83);
            this.dtpEncerramento.Mask = "00/00/0000";
            this.dtpEncerramento.Name = "dtpEncerramento";
            this.dtpEncerramento.Size = new System.Drawing.Size(100, 21);
            this.dtpEncerramento.TabIndex = 96;
            this.dtpEncerramento.ValidatingType = typeof(System.DateTime);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 24;
            // 
            // tipoAtendimentoID
            // 
            this.tipoAtendimentoID.DataPropertyName = "tipoAtendimentoID";
            this.tipoAtendimentoID.HeaderText = "Atendimento ID";
            this.tipoAtendimentoID.Name = "tipoAtendimentoID";
            this.tipoAtendimentoID.ReadOnly = true;
            this.tipoAtendimentoID.Visible = false;
            // 
            // tipoReclamacaoID
            // 
            this.tipoReclamacaoID.DataPropertyName = "tipoReclamacaoID";
            this.tipoReclamacaoID.HeaderText = "Reclamacao ID";
            this.tipoReclamacaoID.Name = "tipoReclamacaoID";
            this.tipoReclamacaoID.ReadOnly = true;
            this.tipoReclamacaoID.Visible = false;
            // 
            // numeroProcon
            // 
            this.numeroProcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroProcon.DataPropertyName = "numeroProcon";
            this.numeroProcon.HeaderText = "Nº Atend.";
            this.numeroProcon.Name = "numeroProcon";
            this.numeroProcon.ReadOnly = true;
            this.numeroProcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numeroProcon.Width = 59;
            // 
            // tipoAtendimento
            // 
            this.tipoAtendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoAtendimento.DataPropertyName = "tipoAtendimento";
            this.tipoAtendimento.HeaderText = "Atendimento";
            this.tipoAtendimento.Name = "tipoAtendimento";
            this.tipoAtendimento.ReadOnly = true;
            this.tipoAtendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tipoAtendimento.Width = 72;
            // 
            // consumidorID
            // 
            this.consumidorID.DataPropertyName = "consumidorID";
            this.consumidorID.HeaderText = "ConsumidorID";
            this.consumidorID.Name = "consumidorID";
            this.consumidorID.ReadOnly = true;
            this.consumidorID.Visible = false;
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
            this.fornecedor.DataPropertyName = "nomeFornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fornecedor.Width = 67;
            // 
            // tipoReclamacao
            // 
            this.tipoReclamacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoReclamacao.DataPropertyName = "tipoReclamacao";
            this.tipoReclamacao.HeaderText = "Reclamação";
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
            // reclamacao
            // 
            this.reclamacao.DataPropertyName = "reclamacao";
            this.reclamacao.HeaderText = "Reclamação";
            this.reclamacao.Name = "reclamacao";
            this.reclamacao.ReadOnly = true;
            this.reclamacao.Visible = false;
            // 
            // dataInicio
            // 
            this.dataInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataInicio.DataPropertyName = "dataInicio";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataInicio.HeaderText = "Início";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            this.dataInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataInicio.Width = 40;
            // 
            // dataEncerramento
            // 
            this.dataEncerramento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataEncerramento.DataPropertyName = "dataEncerramento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataEncerramento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataEncerramento.HeaderText = "Encerramento";
            this.dataEncerramento.Name = "dataEncerramento";
            this.dataEncerramento.ReadOnly = true;
            this.dataEncerramento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataEncerramento.Width = 79;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.DataPropertyName = "btnEncerrar";
            this.btnEncerrar.HeaderText = "";
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.ReadOnly = true;
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 654);
            this.Controls.Add(this.dtpEncerramento);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.picPesquisarFornecedor);
            this.Controls.Add(this.picPesquisarConsumidor);
            this.Controls.Add(this.btnAndamentos);
            this.Controls.Add(this.lblExpandirDescricao);
            this.Controls.Add(this.lbEncaminhar);
            this.Controls.Add(this.lbMovimentar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lbRemover);
            this.Controls.Add(this.lbSalvar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.lbNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProblema);
            this.Controls.Add(this.picAddFornecedor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.picAddConsumidor);
            this.Controls.Add(this.cmbTipoReclamacao);
            this.Controls.Add(this.cmbTipoAtendimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbProblema);
            this.Controls.Add(this.dgvAtendimento);
            this.Controls.Add(this.txtnumeroProcon);
            this.Controls.Add(this.cmbConsumidor);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtDescricaoProblema);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.frmAtendimento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAtendimento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisarConsumidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProblema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddConsumidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgvAtendimento;
        public System.Windows.Forms.ComboBox cmbFornecedor;
        public System.Windows.Forms.ComboBox cmbConsumidor;
        public System.Windows.Forms.TextBox txtnumeroProcon;
        public System.Windows.Forms.ComboBox cmbProblema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoAtendimento;
        private System.Windows.Forms.ComboBox cmbTipoReclamacao;
        private System.Windows.Forms.PictureBox picAddConsumidor;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox picAddFornecedor;
        private System.Windows.Forms.PictureBox picProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNovo;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbSalvar;
        private System.Windows.Forms.Label lbRemover;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lbMovimentar;
        private System.Windows.Forms.Label lbEncaminhar;
        private System.Windows.Forms.Label lblExpandirDescricao;
        public System.Windows.Forms.TextBox txtDescricaoProblema;
        private System.Windows.Forms.Button btnAndamentos;
        private System.Windows.Forms.PictureBox picPesquisarConsumidor;
        private System.Windows.Forms.PictureBox picPesquisarFornecedor;
        private System.Windows.Forms.MaskedTextBox dtpInicio;
        private System.Windows.Forms.MaskedTextBox dtpEncerramento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtendimentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReclamacaoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroProcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumidorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReclamacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemaPrincipalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemaPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn reclamacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEncerramento;
        private System.Windows.Forms.DataGridViewButtonColumn btnEncerrar;
    }
}