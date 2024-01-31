namespace GerirStockLoja.paginas
{
    partial class UC_comprar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFornecedores = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbProdutos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdicionarProduto = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCompra = new Guna.UI2.WinForms.Guna2Button();
            this.TxtboxUniCompradas = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategorias_fornecedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLimparCampos = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecionar Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecionar Fornecedor";
            // 
            // cbFornecedores
            // 
            this.cbFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.cbFornecedores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFornecedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedores.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFornecedores.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFornecedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFornecedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFornecedores.ItemHeight = 30;
            this.cbFornecedores.Location = new System.Drawing.Point(178, 123);
            this.cbFornecedores.Name = "cbFornecedores";
            this.cbFornecedores.Size = new System.Drawing.Size(287, 36);
            this.cbFornecedores.TabIndex = 10;
            this.cbFornecedores.SelectedIndexChanged += new System.EventHandler(this.cbFornecedores_SelectedIndexChanged);
            // 
            // cbProdutos
            // 
            this.cbProdutos.BackColor = System.Drawing.Color.Transparent;
            this.cbProdutos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdutos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProdutos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProdutos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProdutos.ItemHeight = 30;
            this.cbProdutos.Location = new System.Drawing.Point(178, 285);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(287, 36);
            this.cbProdutos.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selecionar Produto";
            // 
            // BtnAdicionarProduto
            // 
            this.BtnAdicionarProduto.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnAdicionarProduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdicionarProduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdicionarProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdicionarProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdicionarProduto.FillColor = System.Drawing.Color.LimeGreen;
            this.BtnAdicionarProduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnAdicionarProduto.HoverState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.BtnAdicionarProduto.Location = new System.Drawing.Point(588, 296);
            this.BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            this.BtnAdicionarProduto.Size = new System.Drawing.Size(180, 45);
            this.BtnAdicionarProduto.TabIndex = 19;
            this.BtnAdicionarProduto.Text = "Adicionar produto";
            this.BtnAdicionarProduto.Click += new System.EventHandler(this.BtnAdicionarProduto_Click);
            // 
            // BtnCompra
            // 
            this.BtnCompra.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.BtnCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCompra.FillColor = System.Drawing.Color.LimeGreen;
            this.BtnCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCompra.HoverState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.BtnCompra.Location = new System.Drawing.Point(588, 360);
            this.BtnCompra.Name = "BtnCompra";
            this.BtnCompra.Size = new System.Drawing.Size(180, 45);
            this.BtnCompra.TabIndex = 18;
            this.BtnCompra.Text = "Realizar Compra";
            this.BtnCompra.Click += new System.EventHandler(this.BtnCompra_Click);
            // 
            // TxtboxUniCompradas
            // 
            this.TxtboxUniCompradas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxUniCompradas.DefaultText = "";
            this.TxtboxUniCompradas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtboxUniCompradas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtboxUniCompradas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtboxUniCompradas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtboxUniCompradas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtboxUniCompradas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtboxUniCompradas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtboxUniCompradas.Location = new System.Drawing.Point(178, 371);
            this.TxtboxUniCompradas.Name = "TxtboxUniCompradas";
            this.TxtboxUniCompradas.PasswordChar = '\0';
            this.TxtboxUniCompradas.PlaceholderText = "";
            this.TxtboxUniCompradas.SelectedText = "";
            this.TxtboxUniCompradas.Size = new System.Drawing.Size(287, 36);
            this.TxtboxUniCompradas.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Indique Unidades a Comprar";
            // 
            // cbCategorias_fornecedor
            // 
            this.cbCategorias_fornecedor.BackColor = System.Drawing.Color.Transparent;
            this.cbCategorias_fornecedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategorias_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorias_fornecedor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategorias_fornecedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategorias_fornecedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategorias_fornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategorias_fornecedor.ItemHeight = 30;
            this.cbCategorias_fornecedor.Location = new System.Drawing.Point(178, 200);
            this.cbCategorias_fornecedor.Name = "cbCategorias_fornecedor";
            this.cbCategorias_fornecedor.Size = new System.Drawing.Size(287, 36);
            this.cbCategorias_fornecedor.TabIndex = 20;
            this.cbCategorias_fornecedor.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_fornecedor_SelectedIndexChanged);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnLimparCampos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparCampos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparCampos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimparCampos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimparCampos.FillColor = System.Drawing.Color.BurlyWood;
            this.btnLimparCampos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimparCampos.HoverState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnLimparCampos.Location = new System.Drawing.Point(588, 237);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(180, 45);
            this.btnLimparCampos.TabIndex = 21;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // UC_comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.cbCategorias_fornecedor);
            this.Controls.Add(this.BtnAdicionarProduto);
            this.Controls.Add(this.BtnCompra);
            this.Controls.Add(this.TxtboxUniCompradas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFornecedores);
            this.Name = "UC_comprar";
            this.Size = new System.Drawing.Size(971, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFornecedores;
        private Guna.UI2.WinForms.Guna2ComboBox cbProdutos;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnAdicionarProduto;
        private Guna.UI2.WinForms.Guna2Button BtnCompra;
        private Guna.UI2.WinForms.Guna2TextBox TxtboxUniCompradas;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategorias_fornecedor;
        private Guna.UI2.WinForms.Guna2Button btnLimparCampos;
    }
}
