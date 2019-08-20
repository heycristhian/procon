namespace SGCRP.Forms.Notas
{
    partial class frmNotasMobiles
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
            this.components = new System.ComponentModel.Container();
            this.dgvNotaMobile = new System.Windows.Forms.DataGridView();
            this.juiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaTouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaCompetidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaMobile)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotaMobile
            // 
            this.dgvNotaMobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaMobile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.juiz,
            this.notaTouro,
            this.notaCompetidor,
            this.repete,
            this.situacao});
            this.dgvNotaMobile.Location = new System.Drawing.Point(46, 56);
            this.dgvNotaMobile.Name = "dgvNotaMobile";
            this.dgvNotaMobile.Size = new System.Drawing.Size(545, 150);
            this.dgvNotaMobile.TabIndex = 0;
            // 
            // juiz
            // 
            this.juiz.DataPropertyName = "juiz";
            this.juiz.HeaderText = "Juiz";
            this.juiz.Name = "juiz";
            this.juiz.ReadOnly = true;
            // 
            // notaTouro
            // 
            this.notaTouro.DataPropertyName = "notaTouro";
            this.notaTouro.HeaderText = "Nota Touro";
            this.notaTouro.Name = "notaTouro";
            this.notaTouro.ReadOnly = true;
            // 
            // notaCompetidor
            // 
            this.notaCompetidor.DataPropertyName = "notaCompetidor";
            this.notaCompetidor.HeaderText = "Nota Competidor";
            this.notaCompetidor.Name = "notaCompetidor";
            this.notaCompetidor.ReadOnly = true;
            // 
            // repete
            // 
            this.repete.DataPropertyName = "repete";
            this.repete.HeaderText = "Repete";
            this.repete.Name = "repete";
            this.repete.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(492, 212);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(99, 31);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmNotasMobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 271);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvNotaMobile);
            this.Name = "frmNotasMobiles";
            this.Text = "Notas Mobile";
            this.Load += new System.EventHandler(this.frmNotasMobiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaMobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotaMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn juiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaTouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaCompetidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn repete;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Timer timer1;
    }
}