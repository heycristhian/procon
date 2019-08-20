namespace SGCRP.Forms.Copa
{
    partial class PremioCopa
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCampeonato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCopa = new System.Windows.Forms.ComboBox();
            this.lblPremiacao = new System.Windows.Forms.Label();
            this.txtPremiacao = new System.Windows.Forms.TextBox();
            this.dgvPremiacao = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganhador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnRemoverPremio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremiacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Prêmio da Copa";
            // 
            // cmbCampeonato
            // 
            this.cmbCampeonato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampeonato.FormattingEnabled = true;
            this.cmbCampeonato.Location = new System.Drawing.Point(151, 100);
            this.cmbCampeonato.Name = "cmbCampeonato";
            this.cmbCampeonato.Size = new System.Drawing.Size(320, 27);
            this.cmbCampeonato.TabIndex = 1;
            this.cmbCampeonato.SelectedValueChanged += new System.EventHandler(this.cmbCampeonato_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campeonato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copa:";
            // 
            // cmbCopa
            // 
            this.cmbCopa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopa.FormattingEnabled = true;
            this.cmbCopa.Location = new System.Drawing.Point(542, 100);
            this.cmbCopa.Name = "cmbCopa";
            this.cmbCopa.Size = new System.Drawing.Size(320, 27);
            this.cmbCopa.TabIndex = 2;
            this.cmbCopa.SelectedIndexChanged += new System.EventHandler(this.cmbCopa_SelectedIndexChanged);
            // 
            // lblPremiacao
            // 
            this.lblPremiacao.AutoSize = true;
            this.lblPremiacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremiacao.Location = new System.Drawing.Point(191, 158);
            this.lblPremiacao.Name = "lblPremiacao";
            this.lblPremiacao.Size = new System.Drawing.Size(205, 20);
            this.lblPremiacao.TabIndex = 5;
            this.lblPremiacao.Text = "Quantidade de premiação:";
            // 
            // txtPremiacao
            // 
            this.txtPremiacao.Location = new System.Drawing.Point(436, 151);
            this.txtPremiacao.Name = "txtPremiacao";
            this.txtPremiacao.Size = new System.Drawing.Size(100, 27);
            this.txtPremiacao.TabIndex = 3;
            // 
            // dgvPremiacao
            // 
            this.dgvPremiacao.AllowUserToAddRows = false;
            this.dgvPremiacao.AllowUserToDeleteRows = false;
            this.dgvPremiacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPremiacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPremiacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ordem,
            this.premio,
            this.Ganhador});
            this.dgvPremiacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPremiacao.Location = new System.Drawing.Point(195, 196);
            this.dgvPremiacao.Name = "dgvPremiacao";
            this.dgvPremiacao.Size = new System.Drawing.Size(476, 361);
            this.dgvPremiacao.TabIndex = 7;
            this.dgvPremiacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPremiacao_CellContentClick);
            this.dgvPremiacao.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPremiacao_CellEndEdit);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ordem
            // 
            this.ordem.DataPropertyName = "ordem";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ordem.DefaultCellStyle = dataGridViewCellStyle1;
            this.ordem.HeaderText = "Ordem";
            this.ordem.Name = "ordem";
            this.ordem.ReadOnly = true;
            // 
            // premio
            // 
            this.premio.DataPropertyName = "premio";
            this.premio.HeaderText = "Premio";
            this.premio.Name = "premio";
            // 
            // Ganhador
            // 
            this.Ganhador.DataPropertyName = "ganhador";
            this.Ganhador.HeaderText = "Ganhador";
            this.Ganhador.Name = "Ganhador";
            this.Ganhador.ReadOnly = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(596, 151);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 27);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(195, 563);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(137, 36);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar Prêmios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnRemoverPremio
            // 
            this.btnRemoverPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverPremio.Location = new System.Drawing.Point(514, 563);
            this.btnRemoverPremio.Name = "btnRemoverPremio";
            this.btnRemoverPremio.Size = new System.Drawing.Size(157, 36);
            this.btnRemoverPremio.TabIndex = 6;
            this.btnRemoverPremio.Text = "Remover Prêmios";
            this.btnRemoverPremio.UseVisualStyleBackColor = true;
            this.btnRemoverPremio.Click += new System.EventHandler(this.btnRemoverPremio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1078, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(975, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(975, 563);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 36);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // PremioCopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoverPremio);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.dgvPremiacao);
            this.Controls.Add(this.txtPremiacao);
            this.Controls.Add(this.lblPremiacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCopa);
            this.Controls.Add(this.cmbCampeonato);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1278, 726);
            this.Name = "PremioCopa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Premiação da Copa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PremioCopa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPremiacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCampeonato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCopa;
        private System.Windows.Forms.Label lblPremiacao;
        private System.Windows.Forms.TextBox txtPremiacao;
        private System.Windows.Forms.DataGridView dgvPremiacao;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnRemoverPremio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganhador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSair;
    }
}