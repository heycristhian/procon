namespace SGCRP.Forms
{
    partial class frmCopiaBackup
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picDone = new System.Windows.Forms.PictureBox();
            this.picPath = new System.Windows.Forms.PictureBox();
            this.lbRestaurar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(23, 199);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(448, 20);
            this.txtPath.TabIndex = 0;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Enabled = false;
            this.txtNomeArquivo.Location = new System.Drawing.Point(23, 122);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(265, 20);
            this.txtNomeArquivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do arquivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pasta do arquivo:";
            // 
            // picClose
            // 
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::SGAP.Properties.Resources.close16x;
            this.picClose.Location = new System.Drawing.Point(528, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(16, 16);
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picDone
            // 
            this.picDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDone.Image = global::SGAP.Properties.Resources.save50x;
            this.picDone.Location = new System.Drawing.Point(485, 279);
            this.picDone.Name = "picDone";
            this.picDone.Size = new System.Drawing.Size(50, 50);
            this.picDone.TabIndex = 6;
            this.picDone.TabStop = false;
            this.picDone.Click += new System.EventHandler(this.picDone_Click);
            this.picDone.MouseEnter += new System.EventHandler(this.picDone_MouseEnter);
            this.picDone.MouseLeave += new System.EventHandler(this.picDone_MouseLeave);
            // 
            // picPath
            // 
            this.picPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPath.Image = global::SGAP.Properties.Resources.folder20x;
            this.picPath.Location = new System.Drawing.Point(477, 199);
            this.picPath.Name = "picPath";
            this.picPath.Size = new System.Drawing.Size(20, 20);
            this.picPath.TabIndex = 3;
            this.picPath.TabStop = false;
            this.picPath.Click += new System.EventHandler(this.picPath_Click);
            // 
            // lbRestaurar
            // 
            this.lbRestaurar.AutoSize = true;
            this.lbRestaurar.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(168)))), ((int)(((byte)(252)))));
            this.lbRestaurar.Location = new System.Drawing.Point(158, 31);
            this.lbRestaurar.Name = "lbRestaurar";
            this.lbRestaurar.Size = new System.Drawing.Size(229, 39);
            this.lbRestaurar.TabIndex = 10;
            this.lbRestaurar.Text = "SALVAR DADOS";
            // 
            // frmCopiaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 341);
            this.Controls.Add(this.lbRestaurar);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picDone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPath);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.txtPath);
            this.Name = "frmCopiaBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copiar dados";
            this.Load += new System.EventHandler(this.frmCopiaBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox picPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picDone;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbRestaurar;
    }
}