namespace GerirStockLoja.forms
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFornecedores = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnFuncionarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdutos = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEstatisticas = new Guna.UI2.WinForms.Guna2Button();
            this.btnComprar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVender = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSair = new Guna.UI2.WinForms.Guna2Button();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFornecedores);
            this.panel2.Controls.Add(this.btnCategorias);
            this.panel2.Controls.Add(this.btnFuncionarios);
            this.panel2.Controls.Add(this.btnProdutos);
            this.panel2.Controls.Add(this.BtnEstatisticas);
            this.panel2.Controls.Add(this.btnComprar);
            this.panel2.Controls.Add(this.BtnVender);
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 50);
            this.panel2.TabIndex = 3;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFornecedores.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnFornecedores.CustomBorderColor = System.Drawing.Color.White;
            this.btnFornecedores.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnFornecedores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFornecedores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFornecedores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFornecedores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFornecedores.FillColor = System.Drawing.Color.White;
            this.btnFornecedores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.ForeColor = System.Drawing.Color.Black;
            this.btnFornecedores.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnFornecedores.Location = new System.Drawing.Point(814, 0);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(157, 51);
            this.btnFornecedores.TabIndex = 6;
            this.btnFornecedores.Text = "Gerir Fornecedores";
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategorias.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnCategorias.CustomBorderColor = System.Drawing.Color.White;
            this.btnCategorias.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.FillColor = System.Drawing.Color.White;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCategorias.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnCategorias.Location = new System.Drawing.Point(516, -1);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(145, 51);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Gerir Categorias";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFuncionarios.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnFuncionarios.CustomBorderColor = System.Drawing.Color.White;
            this.btnFuncionarios.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnFuncionarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFuncionarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFuncionarios.FillColor = System.Drawing.Color.White;
            this.btnFuncionarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionarios.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnFuncionarios.Location = new System.Drawing.Point(661, 0);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(153, 51);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "Gerir Funcionarios";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProdutos.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnProdutos.CustomBorderColor = System.Drawing.Color.White;
            this.btnProdutos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnProdutos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProdutos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProdutos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProdutos.FillColor = System.Drawing.Color.White;
            this.btnProdutos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnProdutos.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnProdutos.Location = new System.Drawing.Point(380, -1);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(136, 51);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Gerir Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
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
            this.BtnEstatisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEstatisticas.ForeColor = System.Drawing.Color.Black;
            this.BtnEstatisticas.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnEstatisticas.Location = new System.Drawing.Point(132, -1);
            this.BtnEstatisticas.Name = "BtnEstatisticas";
            this.BtnEstatisticas.Size = new System.Drawing.Size(131, 51);
            this.BtnEstatisticas.TabIndex = 3;
            this.BtnEstatisticas.Text = "Estatisticas";
            this.BtnEstatisticas.Click += new System.EventHandler(this.BtnEstatisticas_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnComprar.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnComprar.CustomBorderColor = System.Drawing.Color.White;
            this.btnComprar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnComprar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprar.FillColor = System.Drawing.Color.White;
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.Black;
            this.btnComprar.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.btnComprar.Location = new System.Drawing.Point(263, -1);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(117, 51);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // BtnVender
            // 
            this.BtnVender.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnVender.CheckedState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnVender.CustomBorderColor = System.Drawing.Color.White;
            this.BtnVender.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnVender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVender.FillColor = System.Drawing.Color.White;
            this.BtnVender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVender.ForeColor = System.Drawing.Color.Black;
            this.BtnVender.HoverState.CustomBorderColor = System.Drawing.Color.LimeGreen;
            this.BtnVender.Location = new System.Drawing.Point(0, 0);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(132, 51);
            this.BtnVender.TabIndex = 1;
            this.BtnVender.Text = "Vender";
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.labelBemVindo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 57);
            this.panel1.TabIndex = 2;
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
            this.BtnLogout.Location = new System.Drawing.Point(792, 12);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(97, 34);
            this.BtnLogout.TabIndex = 6;
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
            this.BtnSair.Location = new System.Drawing.Point(895, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(64, 34);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBemVindo.Location = new System.Drawing.Point(299, 14);
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
            // panelAdmin
            // 
            this.panelAdmin.Location = new System.Drawing.Point(0, 107);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(971, 559);
            this.panelAdmin.TabIndex = 4;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 666);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdmin";
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnFuncionarios;
        private Guna.UI2.WinForms.Guna2Button btnProdutos;
        private Guna.UI2.WinForms.Guna2Button BtnEstatisticas;
        private Guna.UI2.WinForms.Guna2Button btnComprar;
        private Guna.UI2.WinForms.Guna2Button BtnVender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBemVindo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAdmin;
        private Guna.UI2.WinForms.Guna2Button BtnSair;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnFornecedores;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
    }
}