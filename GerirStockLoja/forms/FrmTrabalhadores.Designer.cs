namespace GerirStockLoja
{
    partial class FrmTrabalhadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabalhadores));
            this.panelBemVindo = new System.Windows.Forms.Panel();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSair = new Guna.UI2.WinForms.Guna2Button();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTrabbotoes = new System.Windows.Forms.Panel();
            this.BtnEstatisticas = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVender = new Guna.UI2.WinForms.Guna2Button();
            this.panelTrabalhadores = new System.Windows.Forms.Panel();
            this.panelBemVindo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTrabbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBemVindo
            // 
            this.panelBemVindo.BackColor = System.Drawing.Color.DimGray;
            this.panelBemVindo.Controls.Add(this.BtnLogout);
            this.panelBemVindo.Controls.Add(this.BtnSair);
            this.panelBemVindo.Controls.Add(this.labelBemVindo);
            this.panelBemVindo.Controls.Add(this.pictureBox1);
            this.panelBemVindo.Location = new System.Drawing.Point(0, 0);
            this.panelBemVindo.Name = "panelBemVindo";
            this.panelBemVindo.Size = new System.Drawing.Size(971, 57);
            this.panelBemVindo.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.DimGray;
            this.BtnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.BtnLogout.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(777, 12);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(97, 34);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
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
            this.BtnSair.Location = new System.Drawing.Point(880, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(79, 34);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBemVindo.Location = new System.Drawing.Point(306, 14);
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
            // panelTrabbotoes
            // 
            this.panelTrabbotoes.Controls.Add(this.BtnEstatisticas);
            this.panelTrabbotoes.Controls.Add(this.BtnVender);
            this.panelTrabbotoes.Location = new System.Drawing.Point(0, 57);
            this.panelTrabbotoes.Name = "panelTrabbotoes";
            this.panelTrabbotoes.Size = new System.Drawing.Size(971, 51);
            this.panelTrabbotoes.TabIndex = 1;
            // 
            // BtnEstatisticas
            // 
            this.BtnEstatisticas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnEstatisticas.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnEstatisticas.CustomBorderColor = System.Drawing.Color.White;
            this.BtnEstatisticas.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnEstatisticas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEstatisticas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEstatisticas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEstatisticas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEstatisticas.FillColor = System.Drawing.Color.White;
            this.BtnEstatisticas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstatisticas.ForeColor = System.Drawing.Color.Black;
            this.BtnEstatisticas.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnEstatisticas.Location = new System.Drawing.Point(480, 0);
            this.BtnEstatisticas.Name = "BtnEstatisticas";
            this.BtnEstatisticas.Size = new System.Drawing.Size(489, 51);
            this.BtnEstatisticas.TabIndex = 3;
            this.BtnEstatisticas.Text = "Estatisticas";
            this.BtnEstatisticas.Click += new System.EventHandler(this.BtnEstatisticas_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnVender.Checked = true;
            this.BtnVender.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnVender.CustomBorderColor = System.Drawing.Color.White;
            this.BtnVender.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnVender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVender.FillColor = System.Drawing.Color.White;
            this.BtnVender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVender.ForeColor = System.Drawing.Color.Black;
            this.BtnVender.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnVender.Location = new System.Drawing.Point(0, 0);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(482, 51);
            this.BtnVender.TabIndex = 1;
            this.BtnVender.Text = "Vender";
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // panelTrabalhadores
            // 
            this.panelTrabalhadores.Location = new System.Drawing.Point(0, 109);
            this.panelTrabalhadores.Name = "panelTrabalhadores";
            this.panelTrabalhadores.Size = new System.Drawing.Size(971, 559);
            this.panelTrabalhadores.TabIndex = 2;
            // 
            // FrmTrabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 668);
            this.Controls.Add(this.panelTrabalhadores);
            this.Controls.Add(this.panelTrabbotoes);
            this.Controls.Add(this.panelBemVindo);
            this.Name = "FrmTrabalhadores";
            this.Text = "Loja trabalhadores";
            this.Load += new System.EventHandler(this.FrmTrabalhadores_Load);
            this.panelBemVindo.ResumeLayout(false);
            this.panelBemVindo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTrabbotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBemVindo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTrabbotoes;
        private System.Windows.Forms.Label labelBemVindo;
        private Guna.UI2.WinForms.Guna2Button BtnVender;
        private Guna.UI2.WinForms.Guna2Button BtnEstatisticas;
        private System.Windows.Forms.Panel panelTrabalhadores;
        private Guna.UI2.WinForms.Guna2Button BtnSair;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
    }
}

