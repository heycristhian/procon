namespace SGCRP.Forms.GoldCowboy
{
    partial class frmGoldDuelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCompetidor1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTouro1 = new System.Windows.Forms.ComboBox();
            this.cmbTouro2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCompetidor2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competidor:";
            // 
            // cmbCompetidor1
            // 
            this.cmbCompetidor1.FormattingEnabled = true;
            this.cmbCompetidor1.Location = new System.Drawing.Point(177, 38);
            this.cmbCompetidor1.Name = "cmbCompetidor1";
            this.cmbCompetidor1.Size = new System.Drawing.Size(380, 27);
            this.cmbCompetidor1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Touro:";
            // 
            // cmbTouro1
            // 
            this.cmbTouro1.FormattingEnabled = true;
            this.cmbTouro1.Location = new System.Drawing.Point(636, 38);
            this.cmbTouro1.Name = "cmbTouro1";
            this.cmbTouro1.Size = new System.Drawing.Size(385, 27);
            this.cmbTouro1.TabIndex = 4;
            // 
            // cmbTouro2
            // 
            this.cmbTouro2.FormattingEnabled = true;
            this.cmbTouro2.Location = new System.Drawing.Point(636, 161);
            this.cmbTouro2.Name = "cmbTouro2";
            this.cmbTouro2.Size = new System.Drawing.Size(385, 27);
            this.cmbTouro2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Touro:";
            // 
            // cmbCompetidor2
            // 
            this.cmbCompetidor2.FormattingEnabled = true;
            this.cmbCompetidor2.Location = new System.Drawing.Point(177, 161);
            this.cmbCompetidor2.Name = "cmbCompetidor2";
            this.cmbCompetidor2.Size = new System.Drawing.Size(380, 27);
            this.cmbCompetidor2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Competidor:";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(819, 236);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(98, 36);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(923, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmGoldDuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 294);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cmbTouro2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCompetidor2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTouro1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCompetidor1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGoldDuelo";
            this.Text = "frmGoldDuelo";
            this.Load += new System.EventHandler(this.frmGoldDuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCompetidor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTouro1;
        private System.Windows.Forms.ComboBox cmbTouro2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCompetidor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}