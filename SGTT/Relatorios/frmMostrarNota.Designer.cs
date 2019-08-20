namespace SGCRP.Relatorios
{
    partial class frmMostrarNota
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
            this.crvNotas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.relMostrarNotas3 = new SGCRP.Relatorios.relMostrarNotas();
            this.relMostrarNotas1 = new SGCRP.Relatorios.relMostrarNotas();
            this.relMostrarNotas2 = new SGCRP.Relatorios.relMostrarNotas();
            this.SuspendLayout();
            // 
            // crvNotas
            // 
            this.crvNotas.ActiveViewIndex = 0;
            this.crvNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNotas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.crvNotas.Location = new System.Drawing.Point(0, 0);
            this.crvNotas.Name = "crvNotas";
            this.crvNotas.ReportSource = this.relMostrarNotas3;
            this.crvNotas.Size = new System.Drawing.Size(1094, 436);
            this.crvNotas.TabIndex = 0;
            this.crvNotas.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmMostrarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 436);
            this.Controls.Add(this.crvNotas);
            this.Name = "frmMostrarNota";
            this.Text = "frmMostrarNota";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNotas;
        private relMostrarNotas relMostrarNotas1;
        private relMostrarNotas relMostrarNotas3;
        private relMostrarNotas relMostrarNotas2;
    }
}