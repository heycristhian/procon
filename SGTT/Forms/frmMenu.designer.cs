﻿namespace SGAP.Forms
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoReclamaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1276, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAtendimentoToolStripMenuItem});
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.ShowShortcutKeys = false;
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.atendimentoToolStripMenuItem.Text = "&Atendimento";
            this.atendimentoToolStripMenuItem.MouseEnter += new System.EventHandler(this.atendimentoToolStripMenuItem_MouseEnter);
            this.atendimentoToolStripMenuItem.MouseLeave += new System.EventHandler(this.atendimentoToolStripMenuItem_MouseLeave);
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            this.novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            this.novoAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.novoAtendimentoToolStripMenuItem.Text = "Novo Atendimento";
            this.novoAtendimentoToolStripMenuItem.Click += new System.EventHandler(this.novoAtendimentoToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadeToolStripMenuItem,
            this.consumidorToolStripMenuItem,
            this.entidadeToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.tipoReclamaçãoToolStripMenuItem,
            this.tipoAtendimentoToolStripMenuItem,
            this.problemaPrincipalToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            this.cadastrosToolStripMenuItem.MouseEnter += new System.EventHandler(this.cadastrosToolStripMenuItem_MouseEnter);
            this.cadastrosToolStripMenuItem.MouseLeave += new System.EventHandler(this.cadastrosToolStripMenuItem_MouseLeave);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.cidadeToolStripMenuItem.Text = "&Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // consumidorToolStripMenuItem
            // 
            this.consumidorToolStripMenuItem.Name = "consumidorToolStripMenuItem";
            this.consumidorToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.consumidorToolStripMenuItem.Text = "Consumidor";
            this.consumidorToolStripMenuItem.Click += new System.EventHandler(this.consumidorToolStripMenuItem_Click);
            // 
            // entidadeToolStripMenuItem
            // 
            this.entidadeToolStripMenuItem.Name = "entidadeToolStripMenuItem";
            this.entidadeToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.entidadeToolStripMenuItem.Text = "&Entidade";
            this.entidadeToolStripMenuItem.Click += new System.EventHandler(this.entidadeToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // tipoReclamaçãoToolStripMenuItem
            // 
            this.tipoReclamaçãoToolStripMenuItem.Name = "tipoReclamaçãoToolStripMenuItem";
            this.tipoReclamaçãoToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.tipoReclamaçãoToolStripMenuItem.Text = "Tipo Reclamação";
            this.tipoReclamaçãoToolStripMenuItem.Click += new System.EventHandler(this.tipoReclamaçãoToolStripMenuItem_Click);
            // 
            // tipoAtendimentoToolStripMenuItem
            // 
            this.tipoAtendimentoToolStripMenuItem.Name = "tipoAtendimentoToolStripMenuItem";
            this.tipoAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.tipoAtendimentoToolStripMenuItem.Text = "Tipo Atendimento";
            this.tipoAtendimentoToolStripMenuItem.Click += new System.EventHandler(this.tipoAtendimentoToolStripMenuItem_Click);
            // 
            // problemaPrincipalToolStripMenuItem
            // 
            this.problemaPrincipalToolStripMenuItem.Name = "problemaPrincipalToolStripMenuItem";
            this.problemaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(244, 30);
            this.problemaPrincipalToolStripMenuItem.Text = "Problema Principal";
            this.problemaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.problemaPrincipalToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            this.sairToolStripMenuItem.MouseEnter += new System.EventHandler(this.sairToolStripMenuItem_MouseEnter);
            this.sairToolStripMenuItem.MouseLeave += new System.EventHandler(this.sairToolStripMenuItem_MouseLeave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.lblUsuario.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1096, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(119, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Cristhian Dias";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(1098, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 1);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1276, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SGAP.Properties.Resources.procon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1276, 742);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestão Atendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoReclamaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}