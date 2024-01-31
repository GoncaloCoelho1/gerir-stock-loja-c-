namespace GerirStockLoja.paginas
{
    partial class UC_estatisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTrabalhadores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMaiorVenda = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFuncionarioNVendas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblMaiorVenda = new System.Windows.Forms.Label();
            this.lblValorTotalVendas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrabalhadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaiorVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTrabalhadores
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrabalhadores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTrabalhadores.Legends.Add(legend1);
            this.chartTrabalhadores.Location = new System.Drawing.Point(55, 245);
            this.chartTrabalhadores.Name = "chartTrabalhadores";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "VendasPorFuncionario";
            this.chartTrabalhadores.Series.Add(series1);
            this.chartTrabalhadores.Size = new System.Drawing.Size(430, 286);
            this.chartTrabalhadores.TabIndex = 4;
            this.chartTrabalhadores.Text = "chart1";
            // 
            // chartMaiorVenda
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMaiorVenda.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMaiorVenda.Legends.Add(legend2);
            this.chartMaiorVenda.Location = new System.Drawing.Point(514, 245);
            this.chartMaiorVenda.Name = "chartMaiorVenda";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "MaiorVendaPorFuncionario";
            this.chartMaiorVenda.Series.Add(series2);
            this.chartMaiorVenda.Size = new System.Drawing.Size(413, 286);
            this.chartMaiorVenda.TabIndex = 5;
            this.chartMaiorVenda.Text = "chart1";
            // 
            // labelFuncionarioNVendas
            // 
            this.labelFuncionarioNVendas.AutoSize = true;
            this.labelFuncionarioNVendas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncionarioNVendas.Location = new System.Drawing.Point(95, 219);
            this.labelFuncionarioNVendas.Name = "labelFuncionarioNVendas";
            this.labelFuncionarioNVendas.Size = new System.Drawing.Size(286, 23);
            this.labelFuncionarioNVendas.TabIndex = 6;
            this.labelFuncionarioNVendas.Text = "Funcionário com mais vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Funcionário com a maior venda efetuada";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.Location = new System.Drawing.Point(80, 32);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(69, 23);
            this.lblTotalVendas.TabIndex = 8;
            this.lblTotalVendas.Text = "label1";
            // 
            // lblMaiorVenda
            // 
            this.lblMaiorVenda.AutoSize = true;
            this.lblMaiorVenda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorVenda.Location = new System.Drawing.Point(80, 86);
            this.lblMaiorVenda.Name = "lblMaiorVenda";
            this.lblMaiorVenda.Size = new System.Drawing.Size(69, 23);
            this.lblMaiorVenda.TabIndex = 9;
            this.lblMaiorVenda.Text = "label1";
            // 
            // lblValorTotalVendas
            // 
            this.lblValorTotalVendas.AutoSize = true;
            this.lblValorTotalVendas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalVendas.Location = new System.Drawing.Point(80, 139);
            this.lblValorTotalVendas.Name = "lblValorTotalVendas";
            this.lblValorTotalVendas.Size = new System.Drawing.Size(69, 23);
            this.lblValorTotalVendas.TabIndex = 10;
            this.lblValorTotalVendas.Text = "label1";
            // 
            // UC_estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblValorTotalVendas);
            this.Controls.Add(this.lblMaiorVenda);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFuncionarioNVendas);
            this.Controls.Add(this.chartMaiorVenda);
            this.Controls.Add(this.chartTrabalhadores);
            this.Name = "UC_estatisticas";
            this.Size = new System.Drawing.Size(971, 559);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrabalhadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaiorVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrabalhadores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaiorVenda;
        private System.Windows.Forms.Label labelFuncionarioNVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lblMaiorVenda;
        private System.Windows.Forms.Label lblValorTotalVendas;
    }
}
