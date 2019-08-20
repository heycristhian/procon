namespace SGCRP.Forms.Telao
{
    partial class frmClassifTouro
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLancarTela
            // 
            this.btnLancarTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarTela.Location = new System.Drawing.Point(258, 28);
            this.btnLancarTela.Margin = new System.Windows.Forms.Padding(4);
            this.btnLancarTela.Name = "btnLancarTela";
            this.btnLancarTela.Size = new System.Drawing.Size(116, 34);
            this.btnLancarTela.TabIndex = 6;
            this.btnLancarTela.Text = "Lançar Tela";
            this.btnLancarTela.UseVisualStyleBackColor = true;
            this.btnLancarTela.Click += new System.EventHandler(this.btnLancarTela_Click);
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(95, 37);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(148, 21);
            this.cmbPosicao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Posição:";
            // 
            // frmClassifTouro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 100);
            this.Controls.Add(this.btnLancarTela);
            this.Controls.Add(this.cmbPosicao);
            this.Controls.Add(this.label2);
            this.Name = "frmClassifTouro";
            this.Text = "frmClassifTouro";
            this.Load += new System.EventHandler(this.frmClassifTouro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancarTela;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.Label label2;
    }
}