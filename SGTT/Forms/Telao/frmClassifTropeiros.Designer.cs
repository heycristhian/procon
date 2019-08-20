namespace SGCRP.Forms.Telao
{
    partial class frmClassifTropeiros
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
            this.btnLancarTela = new System.Windows.Forms.Button();
            this.cmbPosicao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLancarTela
            // 
            this.btnLancarTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarTela.Location = new System.Drawing.Point(273, 39);
            this.btnLancarTela.Margin = new System.Windows.Forms.Padding(4);
            this.btnLancarTela.Name = "btnLancarTela";
            this.btnLancarTela.Size = new System.Drawing.Size(116, 34);
            this.btnLancarTela.TabIndex = 3;
            this.btnLancarTela.Text = "Lançar Tela";
            this.btnLancarTela.UseVisualStyleBackColor = true;
            this.btnLancarTela.Click += new System.EventHandler(this.btnLancarTela_Click);
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(118, 44);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(148, 28);
            this.cmbPosicao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Posição:";
            // 
            // frmClassifTropeiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 120);
            this.Controls.Add(this.btnLancarTela);
            this.Controls.Add(this.cmbPosicao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmClassifTropeiros";
            this.Text = "Classificação Tropeiro";
            this.Load += new System.EventHandler(this.frmClassifTropeiros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancarTela;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.Label label1;
    }
}