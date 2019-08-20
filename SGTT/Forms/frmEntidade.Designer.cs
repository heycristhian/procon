namespace SGAP.Forms
{
    partial class frmEntidade
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
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWhats = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEntidade = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatsapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRemover = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.lbNovo = new System.Windows.Forms.Label();
            this.lbSalvar = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbFechar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(16, 139);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(188, 24);
            this.cmbCidade.TabIndex = 51;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(562, 26);
            this.txtContato.MaxLength = 20;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(100, 22);
            this.txtContato.TabIndex = 50;
            // 
            // txtSite
            // 
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(421, 139);
            this.txtSite.MaxLength = 30;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(241, 22);
            this.txtSite.TabIndex = 49;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(421, 79);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 22);
            this.txtEmail.TabIndex = 48;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtWhats
            // 
            this.txtWhats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhats.Location = new System.Drawing.Point(421, 26);
            this.txtWhats.MaxLength = 14;
            this.txtWhats.Name = "txtWhats";
            this.txtWhats.Size = new System.Drawing.Size(100, 22);
            this.txtWhats.TabIndex = 47;
            this.txtWhats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWhats_KeyPress);
            this.txtWhats.Move += new System.EventHandler(this.txtWhats_Move);
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(265, 139);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 22);
            this.txtCelular.TabIndex = 46;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(265, 81);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 22);
            this.txtTelefone.TabIndex = 44;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(265, 26);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 22);
            this.txtCep.TabIndex = 43;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(15, 83);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(189, 22);
            this.txtEndereco.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 28);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 22);
            this.txtNome.TabIndex = 40;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(265, 200);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 22);
            this.txtId.TabIndex = 39;
            this.txtId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(559, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Contato:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Site:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(418, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(418, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "WhatsApp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome:";
            // 
            // dgvEntidade
            // 
            this.dgvEntidade.AllowUserToAddRows = false;
            this.dgvEntidade.AllowUserToDeleteRows = false;
            this.dgvEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.endereco,
            this.cidade,
            this.CidadeID,
            this.cep,
            this.fone,
            this.celular,
            this.whatsapp,
            this.email,
            this.contato,
            this.site});
            this.dgvEntidade.Location = new System.Drawing.Point(12, 324);
            this.dgvEntidade.Name = "dgvEntidade";
            this.dgvEntidade.ReadOnly = true;
            this.dgvEntidade.Size = new System.Drawing.Size(650, 168);
            this.dgvEntidade.TabIndex = 59;
            this.dgvEntidade.DoubleClick += new System.EventHandler(this.dgvEntidade_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 24;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.DataPropertyName = "nomeEntidade";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nome.Width = 41;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cidade.DataPropertyName = "nomeCidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cidade.Width = 46;
            // 
            // CidadeID
            // 
            this.CidadeID.DataPropertyName = "cidadeID";
            this.CidadeID.HeaderText = "CidadeID";
            this.CidadeID.Name = "CidadeID";
            this.CidadeID.ReadOnly = true;
            this.CidadeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CidadeID.Visible = false;
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
            this.fone.HeaderText = "Telefone";
            this.fone.Name = "fone";
            this.fone.ReadOnly = true;
            this.fone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fone.Width = 55;
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
            // site
            // 
            this.site.DataPropertyName = "site";
            this.site.HeaderText = "Site";
            this.site.Name = "site";
            this.site.ReadOnly = true;
            this.site.Visible = false;
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
            this.lbRemover.Location = new System.Drawing.Point(151, 181);
            this.lbRemover.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbRemover.Name = "lbRemover";
            this.lbRemover.Size = new System.Drawing.Size(64, 75);
            this.lbRemover.TabIndex = 90;
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
            this.lbEditar.Location = new System.Drawing.Point(81, 181);
            this.lbEditar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(64, 75);
            this.lbEditar.TabIndex = 89;
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
            this.lbNovo.Location = new System.Drawing.Point(13, 181);
            this.lbNovo.MinimumSize = new System.Drawing.Size(62, 75);
            this.lbNovo.Name = "lbNovo";
            this.lbNovo.Size = new System.Drawing.Size(62, 75);
            this.lbNovo.TabIndex = 88;
            this.lbNovo.Text = "Novo \n(F1)";
            this.lbNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbNovo.Click += new System.EventHandler(this.lbNovo_Click);
            this.lbNovo.MouseEnter += new System.EventHandler(this.lbNovo_MouseEnter);
            this.lbNovo.MouseLeave += new System.EventHandler(this.lbNovo_MouseLeave);
            // 
            // lbSalvar
            // 
            this.lbSalvar.AutoSize = true;
            this.lbSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lbSalvar.Image = global::SGAP.Properties.Resources.salvar;
            this.lbSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSalvar.Location = new System.Drawing.Point(526, 181);
            this.lbSalvar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbSalvar.Name = "lbSalvar";
            this.lbSalvar.Size = new System.Drawing.Size(64, 75);
            this.lbSalvar.TabIndex = 91;
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
            this.lbCancelar.Location = new System.Drawing.Point(596, 181);
            this.lbCancelar.MinimumSize = new System.Drawing.Size(64, 75);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(64, 75);
            this.lbCancelar.TabIndex = 92;
            this.lbCancelar.Text = "Cancelar \n(F5)";
            this.lbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            this.lbCancelar.MouseEnter += new System.EventHandler(this.lbCancelar_MouseEnter);
            this.lbCancelar.MouseLeave += new System.EventHandler(this.lbCancelar_MouseLeave);
            // 
            // lbFechar
            // 
            this.lbFechar.AutoSize = true;
            this.lbFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.lbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechar.Location = new System.Drawing.Point(542, 498);
            this.lbFechar.MaximumSize = new System.Drawing.Size(101, 23);
            this.lbFechar.MinimumSize = new System.Drawing.Size(120, 30);
            this.lbFechar.Name = "lbFechar";
            this.lbFechar.Size = new System.Drawing.Size(120, 30);
            this.lbFechar.TabIndex = 100;
            this.lbFechar.Text = "FECHAR (Alt+X)";
            this.lbFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFechar.Click += new System.EventHandler(this.lbFechar_Click);
            this.lbFechar.MouseEnter += new System.EventHandler(this.lbFechar_MouseEnter);
            this.lbFechar.MouseLeave += new System.EventHandler(this.lbFechar_MouseLeave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 296);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(336, 22);
            this.txtPesquisar.TabIndex = 102;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(9, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Buscar:";
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = global::SGAP.Properties.Resources.add;
            this.picAdd.Location = new System.Drawing.Point(210, 135);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(28, 28);
            this.picAdd.TabIndex = 103;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // frmEntidade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 535);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFechar);
            this.Controls.Add(this.lbSalvar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbRemover);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.lbNovo);
            this.Controls.Add(this.dgvEntidade);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWhats);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frmEntidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entidade";
            this.Load += new System.EventHandler(this.frmEntidade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntidade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWhats;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEntidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatsapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.Label lbRemover;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label lbNovo;
        private System.Windows.Forms.Label lbSalvar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbFechar;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAdd;
    }
}