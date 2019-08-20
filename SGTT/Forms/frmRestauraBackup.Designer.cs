namespace SGAP.Forms
{
    partial class frmRestauraBackup
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbRestaurar = new System.Windows.Forms.Label();
            this.picDone = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picPath = new System.Windows.Forms.PictureBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Decker", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecionar arquivo:";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(37, 166);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(448, 20);
            this.txtPath.TabIndex = 6;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // lbRestaurar
            // 
            this.lbRestaurar.AutoSize = true;
            this.lbRestaurar.Font = new System.Drawing.Font("Decker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(168)))), ((int)(((byte)(252)))));
            this.lbRestaurar.Location = new System.Drawing.Point(133, 41);
            this.lbRestaurar.Name = "lbRestaurar";
            this.lbRestaurar.Size = new System.Drawing.Size(280, 39);
            this.lbRestaurar.TabIndex = 9;
            this.lbRestaurar.Text = "RESTAURAR DADOS";
            // 
            // picDone
            // 
            this.picDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDone.Image = global::SGAP.Properties.Resources.bd64x;
            this.picDone.Location = new System.Drawing.Point(471, 265);
            this.picDone.Name = "picDone";
            this.picDone.Size = new System.Drawing.Size(64, 64);
            this.picDone.TabIndex = 11;
            this.picDone.TabStop = false;
            this.picDone.Click += new System.EventHandler(this.picDone_Click);
            this.picDone.MouseEnter += new System.EventHandler(this.picDone_MouseEnter);
            this.picDone.MouseLeave += new System.EventHandler(this.picDone_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::SGAP.Properties.Resources.close16x;
            this.picClose.Location = new System.Drawing.Point(530, 1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(16, 16);
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picPath
            // 
            this.picPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPath.Image = global::SGAP.Properties.Resources.folder20x;
            this.picPath.Location = new System.Drawing.Point(491, 166);
            this.picPath.Name = "picPath";
            this.picPath.Size = new System.Drawing.Size(20, 20);
            this.picPath.TabIndex = 7;
            this.picPath.TabStop = false;
            this.picPath.Click += new System.EventHandler(this.picPath_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(34, 221);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 12;
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(163, 306);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(225, 23);
            this.pbStatus.TabIndex = 14;
            this.pbStatus.Visible = false;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbStatus.Location = new System.Drawing.Point(227, 332);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(96, 13);
            this.lbStatus.TabIndex = 15;
            this.lbStatus.Text = "Arquivo restaurado";
            this.lbStatus.Visible = false;
            // 
            // frmRestauraBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 348);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.picDone);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbRestaurar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picPath);
            this.Controls.Add(this.txtPath);
            this.Name = "frmRestauraBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauração de dados";
            this.Load += new System.EventHandler(this.frmRestauraBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lbRestaurar;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picDone;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label lbStatus;
    }
}