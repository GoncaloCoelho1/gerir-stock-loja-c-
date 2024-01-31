namespace GerirStockLoja
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.niagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTrabbotoes = new System.Windows.Forms.Panel();
            this.BtnLoginAP = new Guna.UI2.WinForms.Guna2Button();
            this.panelBemVindo = new System.Windows.Forms.Panel();
            this.BtnSair = new Guna.UI2.WinForms.Guna2Button();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panelTrabbotoes.SuspendLayout();
            this.panelBemVindo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niagToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 26);
            // 
            // niagToolStripMenuItem
            // 
            this.niagToolStripMenuItem.Name = "niagToolStripMenuItem";
            this.niagToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.niagToolStripMenuItem.Text = "niag";
            // 
            // panelTrabbotoes
            // 
            this.panelTrabbotoes.Controls.Add(this.BtnLoginAP);
            this.panelTrabbotoes.Location = new System.Drawing.Point(0, 57);
            this.panelTrabbotoes.Name = "panelTrabbotoes";
            this.panelTrabbotoes.Size = new System.Drawing.Size(884, 51);
            this.panelTrabbotoes.TabIndex = 9;
            // 
            // BtnLoginAP
            // 
            this.BtnLoginAP.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnLoginAP.Checked = true;
            this.BtnLoginAP.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnLoginAP.CustomBorderColor = System.Drawing.Color.White;
            this.BtnLoginAP.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BtnLoginAP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLoginAP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLoginAP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLoginAP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLoginAP.FillColor = System.Drawing.Color.White;
            this.BtnLoginAP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginAP.ForeColor = System.Drawing.Color.Black;
            this.BtnLoginAP.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnLoginAP.Location = new System.Drawing.Point(0, 0);
            this.BtnLoginAP.Name = "BtnLoginAP";
            this.BtnLoginAP.Size = new System.Drawing.Size(884, 51);
            this.BtnLoginAP.TabIndex = 1;
            this.BtnLoginAP.Text = "Login";
            // 
            // panelBemVindo
            // 
            this.panelBemVindo.BackColor = System.Drawing.Color.DimGray;
            this.panelBemVindo.Controls.Add(this.BtnSair);
            this.panelBemVindo.Controls.Add(this.labelBemVindo);
            this.panelBemVindo.Controls.Add(this.pictureBox1);
            this.panelBemVindo.Location = new System.Drawing.Point(0, 0);
            this.panelBemVindo.Name = "panelBemVindo";
            this.panelBemVindo.Size = new System.Drawing.Size(884, 57);
            this.panelBemVindo.TabIndex = 8;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.DimGray;
            this.BtnSair.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnSair.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.BtnSair.CustomBorderColor = System.Drawing.Color.Red;
            this.BtnSair.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSair.FillColor = System.Drawing.Color.Red;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(808, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(64, 34);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBemVindo.Location = new System.Drawing.Point(359, 14);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(156, 32);
            this.labelBemVindo.TabIndex = 1;
            this.labelBemVindo.Text = "Bem Vindo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.BtnLogin);
            this.panelLogin.Controls.Add(this.textBoxSenha);
            this.panelLogin.Controls.Add(this.labelSenha);
            this.panelLogin.Controls.Add(this.labelEmail);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Location = new System.Drawing.Point(0, 106);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(884, 417);
            this.panelLogin.TabIndex = 10;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.LimeGreen;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.HoverState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.BtnLogin.Location = new System.Drawing.Point(384, 260);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(180, 45);
            this.BtnLogin.TabIndex = 25;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.textBoxSenha.Location = new System.Drawing.Point(317, 188);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(360, 34);
            this.textBoxSenha.TabIndex = 24;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.labelSenha.Location = new System.Drawing.Point(207, 192);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(93, 30);
            this.labelSenha.TabIndex = 23;
            this.labelSenha.Text = "Senha:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelEmail.Location = new System.Drawing.Point(211, 114);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(89, 31);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(317, 111);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(360, 34);
            this.textBoxEmail.TabIndex = 21;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 522);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelTrabbotoes);
            this.Controls.Add(this.panelBemVindo);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelTrabbotoes.ResumeLayout(false);
            this.panelBemVindo.ResumeLayout(false);
            this.panelBemVindo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem niagToolStripMenuItem;
        private System.Windows.Forms.Panel panelTrabbotoes;
        private Guna.UI2.WinForms.Guna2Button BtnLoginAP;
        private System.Windows.Forms.Panel panelBemVindo;
        private Guna.UI2.WinForms.Guna2Button BtnSair;
        private System.Windows.Forms.Label labelBemVindo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogin;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}