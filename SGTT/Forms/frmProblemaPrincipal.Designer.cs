namespace SGAP.Forms
{
    partial class frmProblemaPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cmbTipoReclamacao = new System.Windows.Forms.ComboBox();
            this.dgvProblemaPrincipal = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReclamacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoReclamacaoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRemover = new System.Windows.Forms.Label();
            this.lbEditar = new System.Windows.Forms.Label();
            this.lbNovo = new System.Windows.Forms.Label();
            this.lbSalvar = new System.Windows.Forms.Label();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbFechar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemaPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tipo Reclamação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Descrição";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(137, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 79;
            this.txtId.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(19, 106);
            this.txtDescricao.MaxLength = 35;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(614, 43);
            this.txtDescricao.TabIndex = 2;
            // 
            // cmbTipoReclamacao
            // 
            this.cmbTipoReclamacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReclamacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoReclamacao.FormattingEnabled = true;
            this.cmbTipoReclamacao.Location = new System.Drawing.Point(18, 28);
            this.cmbTipoReclamacao.Name = "cmbTipoReclamacao";
            this.cmbTipoReclamacao.Size = new System.Drawing.Size(234, 24);
            this.cmbTipoReclamacao.TabIndex = 1;
            // 
            // dgvProblemaPrincipal
            // 
            this.dgvProblemaPrincipal.AllowUserToAddRows = false;
            this.dgvProblemaPrincipal.AllowUserToDeleteRows = false;
            this.dgvProblemaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProblemaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblemaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipoReclamacao,
            this.descricao,
            this.tipoReclamacaoID});
            this.dgvProblemaPrincipal.Location = new System.Drawing.Point(17, 199);
            this.dgvProblemaPrincipal.Name = "dgvProblemaPrincipal";
            this.dgvProblemaPrincipal.ReadOnly = true;
            this.dgvProblemaPrincipal.Size = new System.Drawing.Size(612, 290);
            this.dgvProblemaPrincipal.TabIndex = 82;
            this.dgvProblemaPrincipal.DoubleClick += new System.EventHandler(this.dgvProblemaPrincipal_DoubleClick);
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
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descricao.Width = 61;
            // 
            // tipoReclamacaoID
            // 
            this.tipoReclamacaoID.DataPropertyName = "tipoReclamacaoID";
            this.tipoReclamacaoID.HeaderText = "Reclamação ID";
            this.tipoReclamacaoID.Name = "tipoReclamacaoID";
            this.tipoReclamacaoID.ReadOnly = true;
            this.tipoReclamacaoID.Visible = false;
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
            this.lbRemover.Location = new System.Drawing.Point(425, 9);
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
            this.lbEditar.Location = new System.Drawing.Point(355, 9);
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
            this.lbNovo.Location = new System.Drawing.Point(287, 9);
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
            this.lbSalvar.Location = new System.Drawing.Point(495, 9);
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
            this.lbCancelar.Location = new System.Drawing.Point(565, 9);
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
            this.lbFechar.Location = new System.Drawing.Point(509, 495);
            this.lbFechar.MaximumSize = new System.Drawing.Size(101, 23);
            this.lbFechar.MinimumSize = new System.Drawing.Size(120, 30);
            this.lbFechar.Name = "lbFechar";
            this.lbFechar.Size = new System.Drawing.Size(120, 30);
            this.lbFechar.TabIndex = 93;
            this.lbFechar.Text = "FECHAR (Alt+X)";
            this.lbFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFechar.Click += new System.EventHandler(this.lbFechar_Click);
            this.lbFechar.MouseEnter += new System.EventHandler(this.lbMovimentar_MouseEnter);
            this.lbFechar.MouseLeave += new System.EventHandler(this.lbMovimentar_MouseLeave);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(18, 171);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(336, 22);
            this.txtPesquisar.TabIndex = 95;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(15, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Buscar:";
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = global::SGAP.Properties.Resources.add;
            this.picAdd.Location = new System.Drawing.Point(258, 24);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(28, 28);
            this.picAdd.TabIndex = 96;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // frmProblemaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 531);
            this.ControlBox = false;
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFechar);
            this.Controls.Add(this.lbSalvar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbRemover);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.lbNovo);
            this.Controls.Add(this.dgvProblemaPrincipal);
            this.Controls.Add(this.cmbTipoReclamacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "frmProblemaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problema Principal";
            this.Load += new System.EventHandler(this.frmProblemaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProblemaPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemaPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbTipoReclamacao;
        private System.Windows.Forms.DataGridView dgvProblemaPrincipal;
        private System.Windows.Forms.Label lbRemover;
        private System.Windows.Forms.Label lbEditar;
        private System.Windows.Forms.Label lbNovo;
        private System.Windows.Forms.Label lbSalvar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReclamacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoReclamacaoID;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAdd;
    }
}