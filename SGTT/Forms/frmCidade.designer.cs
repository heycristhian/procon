namespace SGAP.Forms
{
    partial class frmCidade
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvCidade = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRemover = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.lbNovo = new System.Windows.Forms.Label();
            this.lbSalvar = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbFechar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 31;
            this.lblNome.Text = "Nome:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(208, 16);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(35, 20);
            this.lblUf.TabIndex = 32;
            this.lblUf.Text = "UF:";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(306, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 34;
            this.lblId.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 39);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 20);
            this.txtNome.TabIndex = 1;
            // 
            // dgvCidade
            // 
            this.dgvCidade.AllowUserToAddRows = false;
            this.dgvCidade.AllowUserToDeleteRows = false;
            this.dgvCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.uf});
            this.dgvCidade.Location = new System.Drawing.Point(9, 209);
            this.dgvCidade.Name = "dgvCidade";
            this.dgvCidade.ReadOnly = true;
            this.dgvCidade.Size = new System.Drawing.Size(382, 221);
            this.dgvCidade.TabIndex = 38;
            this.dgvCidade.DoubleClick += new System.EventHandler(this.dgvCidade_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.id.DefaultCellStyle = dataGridViewCellStyle4;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 24;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.DataPropertyName = "descricao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nome.DefaultCellStyle = dataGridViewCellStyle5;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nome.Width = 41;
            // 
            // uf
            // 
            this.uf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.uf.DataPropertyName = "uf";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.uf.DefaultCellStyle = dataGridViewCellStyle6;
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.uf.Width = 27;
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
            this.lbRemover.Location = new System.Drawing.Point(145, 74);
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
            this.lbEditar.Location = new System.Drawing.Point(75, 74);
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
            this.lbNovo.Location = new System.Drawing.Point(7, 74);
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
            this.lbSalvar.Location = new System.Drawing.Point(257, 74);
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
            this.lbCancelar.Location = new System.Drawing.Point(327, 74);
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
            this.lbFechar.Location = new System.Drawing.Point(271, 436);
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
            this.txtPesquisar.Location = new System.Drawing.Point(9, 181);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(382, 22);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = " Buscar:";
            // 
            // cmbUf
            // 
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(212, 39);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(56, 21);
            this.cmbUf.TabIndex = 2;
            // 
            // frmCidade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 470);
            this.ControlBox = false;
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFechar);
            this.Controls.Add(this.lbSalvar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbRemover);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.lbNovo);
            this.Controls.Add(this.dgvCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblNome);
            this.KeyPreview = true;
            this.Name = "frmCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manter Cidade";
            this.Load += new System.EventHandler(this.frmCidade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCidade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.Label lbRemover;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label lbNovo;
        private System.Windows.Forms.Label lbSalvar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbFechar;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUf;
    }
}