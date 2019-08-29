namespace SGAP.Forms
{
    partial class frmFornecedor
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
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWhats = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatsapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picCidade = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSalvar = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbRemover = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.lbNovo = new System.Windows.Forms.Label();
            this.lbFechar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCidade)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(113, 197);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(197, 24);
            this.cmbCidade.TabIndex = 6;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(113, 92);
            this.txtCnpj.MaxLength = 18;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(231, 22);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(90, 224);
            this.txtSite.MaxLength = 30;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(238, 22);
            this.txtSite.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(90, 182);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 22);
            this.txtEmail.TabIndex = 50;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtWhats
            // 
            this.txtWhats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhats.Location = new System.Drawing.Point(90, 140);
            this.txtWhats.MaxLength = 14;
            this.txtWhats.Name = "txtWhats";
            this.txtWhats.Size = new System.Drawing.Size(144, 22);
            this.txtWhats.TabIndex = 49;
            this.txtWhats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWhats_KeyPress);
            this.txtWhats.Leave += new System.EventHandler(this.txtWhats_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(90, 59);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(144, 22);
            this.txtCelular.TabIndex = 47;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(90, 14);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(144, 22);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(113, 232);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(121, 22);
            this.txtCep.TabIndex = 7;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(113, 162);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(231, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(113, 127);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(231, 22);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(113, 22);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(231, 22);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(444, 396);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 22);
            this.txtId.TabIndex = 39;
            this.txtId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "CNPJ/CPF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Site:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "WhatsApp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Razão Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nome Fantasia:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(90, 98);
            this.txtContato.MaxLength = 20;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(144, 22);
            this.txtContato.TabIndex = 48;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasia.Location = new System.Drawing.Point(113, 57);
            this.txtFantasia.MaxLength = 30;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(231, 22);
            this.txtFantasia.TabIndex = 2;
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.razaoSocial,
            this.fantasia,
            this.contato,
            this.endereco,
            this.bairro,
            this.cidadeID,
            this.nomeCidade,
            this.cep,
            this.fone,
            this.celular,
            this.whatsapp,
            this.email,
            this.site,
            this.cnpj});
            this.dgvFornecedor.Location = new System.Drawing.Point(375, 50);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.Size = new System.Drawing.Size(597, 340);
            this.dgvFornecedor.TabIndex = 63;
            this.dgvFornecedor.DoubleClick += new System.EventHandler(this.dgvFornecedor_DoubleClick);
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
            // 
            // razaoSocial
            // 
            this.razaoSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.razaoSocial.DataPropertyName = "razaoSocial";
            this.razaoSocial.HeaderText = "Razão Social";
            this.razaoSocial.Name = "razaoSocial";
            this.razaoSocial.ReadOnly = true;
            this.razaoSocial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.razaoSocial.Width = 68;
            // 
            // fantasia
            // 
            this.fantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fantasia.DataPropertyName = "fantasia";
            this.fantasia.HeaderText = "Nome Fantasia";
            this.fantasia.Name = "fantasia";
            this.fantasia.ReadOnly = true;
            this.fantasia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fantasia.Width = 76;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contato.DataPropertyName = "contato";
            this.contato.HeaderText = "Contato";
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            this.contato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.contato.Width = 50;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endereco.Visible = false;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Visible = false;
            // 
            // cidadeID
            // 
            this.cidadeID.DataPropertyName = "cidadeID";
            this.cidadeID.HeaderText = "CidadeID";
            this.cidadeID.Name = "cidadeID";
            this.cidadeID.ReadOnly = true;
            this.cidadeID.Visible = false;
            // 
            // nomeCidade
            // 
            this.nomeCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeCidade.DataPropertyName = "nomeCidade";
            this.nomeCidade.HeaderText = "Cidade";
            this.nomeCidade.Name = "nomeCidade";
            this.nomeCidade.ReadOnly = true;
            this.nomeCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeCidade.Width = 46;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Visible = false;
            // 
            // fone
            // 
            this.fone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fone.DataPropertyName = "fone";
            this.fone.HeaderText = "Tel.";
            this.fone.Name = "fone";
            this.fone.ReadOnly = true;
            this.fone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fone.Width = 31;
            // 
            // celular
            // 
            this.celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.celular.Width = 45;
            // 
            // whatsapp
            // 
            this.whatsapp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.whatsapp.DataPropertyName = "whatsapp";
            this.whatsapp.HeaderText = "WhatsApp";
            this.whatsapp.Name = "whatsapp";
            this.whatsapp.ReadOnly = true;
            this.whatsapp.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // site
            // 
            this.site.DataPropertyName = "site";
            this.site.HeaderText = "Site";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            this.site.Visible = false;
            // 
            // cnpj
            // 
            this.cnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cnpj.DataPropertyName = "cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cnpj.Width = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 324);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picCidade);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtRazaoSocial);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtFantasia);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtCnpj);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbCidade);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picCidade
            // 
            this.picCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCidade.Image = global::SGAP.Properties.Resources.add;
            this.picCidade.Location = new System.Drawing.Point(316, 193);
            this.picCidade.Name = "picCidade";
            this.picCidade.Size = new System.Drawing.Size(28, 28);
            this.picCidade.TabIndex = 102;
            this.picCidade.TabStop = false;
            this.picCidade.Click += new System.EventHandler(this.picProblema_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtTelefone);
            this.tabPage2.Controls.Add(this.txtCelular);
            this.tabPage2.Controls.Add(this.txtWhats);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtContato);
            this.tabPage2.Controls.Add(this.txtSite);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbSalvar
            // 
            this.lbSalvar.AutoSize = true;
            this.lbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbSalvar.Image = global::SGAP.Properties.Resources.salvar;
            this.lbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSalvar.Location = new System.Drawing.Point(215, 351);
            this.lbSalvar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbSalvar.Name = "lbSalvar";
            this.lbSalvar.Size = new System.Drawing.Size(64, 75);
            this.lbSalvar.TabIndex = 96;
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
            this.lbCancelar.Location = new System.Drawing.Point(281, 351);
            this.lbCancelar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(64, 75);
            this.lbCancelar.TabIndex = 97;
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
            this.lbRemover.Location = new System.Drawing.Point(145, 351);
            this.lbRemover.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbRemover.Name = "lbRemover";
            this.lbRemover.Size = new System.Drawing.Size(64, 75);
            this.lbRemover.TabIndex = 95;
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
            this.lbEditar.Location = new System.Drawing.Point(75, 351);
            this.lbEditar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(64, 75);
            this.lbEditar.TabIndex = 94;
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
            this.lbNovo.Location = new System.Drawing.Point(7, 351);
            this.lbNovo.MinimumSize = new System.Drawing.Size(62, 75);
            this.lbNovo.Name = "lbNovo";
            this.lbNovo.Size = new System.Drawing.Size(62, 75);
            this.lbNovo.TabIndex = 93;
            this.lbNovo.Text = "Novo \n(F1)";
            this.lbNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbNovo.Click += new System.EventHandler(this.lbNovo_Click);
            this.lbNovo.MouseEnter += new System.EventHandler(this.lbNovo_MouseEnter);
            this.lbNovo.MouseLeave += new System.EventHandler(this.lbNovo_MouseLeave);
            // 
            // lbFechar
            // 
            this.lbFechar.AutoSize = true;
            this.lbFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.lbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechar.Location = new System.Drawing.Point(852, 404);
            this.lbFechar.MaximumSize = new System.Drawing.Size(101, 23);
            this.lbFechar.MinimumSize = new System.Drawing.Size(120, 30);
            this.lbFechar.Name = "lbFechar";
            this.lbFechar.Size = new System.Drawing.Size(120, 30);
            this.lbFechar.TabIndex = 99;
            this.lbFechar.Text = "FECHAR (Alt+X)";
            this.lbFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFechar.Click += new System.EventHandler(this.lbFechar_Click);
            this.lbFechar.MouseEnter += new System.EventHandler(this.lbFechar_MouseEnter);
            this.lbFechar.MouseLeave += new System.EventHandler(this.lbFechar_MouseLeave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(375, 22);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(336, 22);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.Location = new System.Drawing.Point(372, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 100;
            this.label15.Text = "Buscar:";
            // 
            // frmFornecedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbFechar);
            this.Controls.Add(this.lbSalvar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbRemover);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.lbNovo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvFornecedor);
            this.KeyPreview = true;
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCidade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWhats;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbSalvar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbRemover;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label lbNovo;
        private System.Windows.Forms.Label lbFechar;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox picCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatsapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
    }
}