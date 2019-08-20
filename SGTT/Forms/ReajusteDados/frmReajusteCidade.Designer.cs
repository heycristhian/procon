namespace SGCRP.Forms.ReajusteDados
{
    partial class frmReajusteCidade
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
            this.btnRelCidades = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCidadeRecebe = new System.Windows.Forms.ComboBox();
            this.cmbCidadeRemove = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRealizarAcao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reajustar Cidade";
            // 
            // btnRelCidades
            // 
            this.btnRelCidades.Location = new System.Drawing.Point(536, 198);
            this.btnRelCidades.Name = "btnRelCidades";
            this.btnRelCidades.Size = new System.Drawing.Size(115, 63);
            this.btnRelCidades.TabIndex = 1;
            this.btnRelCidades.Text = "Cidades Repetidas";
            this.btnRelCidades.UseVisualStyleBackColor = true;
            this.btnRelCidades.Click += new System.EventHandler(this.btnRelCidades_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade a ser Removida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade que receberá os dados:";
            // 
            // cmbCidadeRecebe
            // 
            this.cmbCidadeRecebe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidadeRecebe.FormattingEnabled = true;
            this.cmbCidadeRecebe.Location = new System.Drawing.Point(41, 128);
            this.cmbCidadeRecebe.Name = "cmbCidadeRecebe";
            this.cmbCidadeRecebe.Size = new System.Drawing.Size(258, 27);
            this.cmbCidadeRecebe.TabIndex = 4;
            // 
            // cmbCidadeRemove
            // 
            this.cmbCidadeRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidadeRemove.FormattingEnabled = true;
            this.cmbCidadeRemove.Location = new System.Drawing.Point(520, 128);
            this.cmbCidadeRemove.Name = "cmbCidadeRemove";
            this.cmbCidadeRemove.Size = new System.Drawing.Size(258, 27);
            this.cmbCidadeRemove.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "<<<";
            // 
            // btnRealizarAcao
            // 
            this.btnRealizarAcao.Location = new System.Drawing.Point(663, 198);
            this.btnRealizarAcao.Name = "btnRealizarAcao";
            this.btnRealizarAcao.Size = new System.Drawing.Size(115, 63);
            this.btnRealizarAcao.TabIndex = 7;
            this.btnRealizarAcao.Text = "Realizar Ação";
            this.btnRealizarAcao.UseVisualStyleBackColor = true;
            this.btnRealizarAcao.Click += new System.EventHandler(this.btnRealizarAcao_Click);
            // 
            // frmReajusteCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 303);
            this.Controls.Add(this.btnRealizarAcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCidadeRemove);
            this.Controls.Add(this.cmbCidadeRecebe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRelCidades);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReajusteCidade";
            this.Text = "Reajuste Cidade";
            this.Load += new System.EventHandler(this.frmReajusteCidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelCidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCidadeRecebe;
        private System.Windows.Forms.ComboBox cmbCidadeRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRealizarAcao;
    }
}