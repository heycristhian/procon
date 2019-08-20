namespace SGCRP.Forms.Fotos
{
    partial class frmCadastroFotoCompetidor
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCompetidor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoFoto = new System.Windows.Forms.ComboBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnAltImagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCompetidoresSemFoto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fotos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Competidor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCompetidor
            // 
            this.cmbCompetidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompetidor.FormattingEnabled = true;
            this.cmbCompetidor.Location = new System.Drawing.Point(144, 142);
            this.cmbCompetidor.Name = "cmbCompetidor";
            this.cmbCompetidor.Size = new System.Drawing.Size(620, 28);
            this.cmbCompetidor.TabIndex = 2;
            this.cmbCompetidor.SelectedValueChanged += new System.EventHandler(this.cmbCompetidor_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(824, 144);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(388, 28);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo Foto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbTipoFoto
            // 
            this.cmbTipoFoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFoto.FormattingEnabled = true;
            this.cmbTipoFoto.Items.AddRange(new object[] {
            "Frente",
            "Perfil"});
            this.cmbTipoFoto.Location = new System.Drawing.Point(144, 176);
            this.cmbTipoFoto.Name = "cmbTipoFoto";
            this.cmbTipoFoto.Size = new System.Drawing.Size(341, 28);
            this.cmbTipoFoto.TabIndex = 6;
            this.cmbTipoFoto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFoto_SelectedIndexChanged);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFoto.Location = new System.Drawing.Point(47, 260);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(393, 353);
            this.pcbFoto.TabIndex = 7;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.Visible = false;
            this.pcbFoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbFoto_Paint);
            // 
            // btnAltImagem
            // 
            this.btnAltImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltImagem.Location = new System.Drawing.Point(869, 185);
            this.btnAltImagem.Name = "btnAltImagem";
            this.btnAltImagem.Size = new System.Drawing.Size(128, 52);
            this.btnAltImagem.TabIndex = 8;
            this.btnAltImagem.Text = "Alterar Imagem";
            this.btnAltImagem.UseVisualStyleBackColor = true;
            this.btnAltImagem.Visible = false;
            this.btnAltImagem.Click += new System.EventHandler(this.btnAltImagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1079, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(976, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1137, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompetidoresSemFoto
            // 
            this.btnCompetidoresSemFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompetidoresSemFoto.Location = new System.Drawing.Point(1003, 185);
            this.btnCompetidoresSemFoto.Name = "btnCompetidoresSemFoto";
            this.btnCompetidoresSemFoto.Size = new System.Drawing.Size(128, 52);
            this.btnCompetidoresSemFoto.TabIndex = 12;
            this.btnCompetidoresSemFoto.Text = "Competidores sem Foto";
            this.btnCompetidoresSemFoto.UseVisualStyleBackColor = true;
            this.btnCompetidoresSemFoto.Click += new System.EventHandler(this.btnCompetidoresSemFoto_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(735, 185);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 52);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir Imagem";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCadastroFotoCompetidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 749);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCompetidoresSemFoto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAltImagem);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.cmbTipoFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCompetidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1714, 888);
            this.MinimumSize = new System.Drawing.Size(1278, 726);
            this.Name = "frmCadastroFotoCompetidor";
            this.Text = "Cadastro de Foto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastroFotoCompetidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCompetidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoFoto;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnAltImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCompetidoresSemFoto;
        private System.Windows.Forms.Button btnExcluir;
    }
}