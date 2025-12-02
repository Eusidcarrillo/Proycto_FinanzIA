namespace FinanzIA
{
    partial class ReporteAnalisisFinanciero
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSaldo = new System.Windows.Forms.DataGridView();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbCategoriasGastos = new System.Windows.Forms.Label();
            this.chrCategoriaGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrIngresosGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbIngresosGastos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCategoriaGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrIngresosGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSaldo);
            this.panel1.Controls.Add(this.lbSaldo);
            this.panel1.Controls.Add(this.lbCategoriasGastos);
            this.panel1.Controls.Add(this.chrCategoriaGastos);
            this.panel1.Controls.Add(this.chrIngresosGastos);
            this.panel1.Controls.Add(this.lbIngresosGastos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 336);
            this.panel1.TabIndex = 0;
            // 
            // dgvSaldo
            // 
            this.dgvSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaldo.Location = new System.Drawing.Point(435, 287);
            this.dgvSaldo.Name = "dgvSaldo";
            this.dgvSaldo.Size = new System.Drawing.Size(314, 22);
            this.dgvSaldo.TabIndex = 6;
            // 
            // lbSaldo
            // 
            this.lbSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSaldo.Location = new System.Drawing.Point(430, 247);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(64, 25);
            this.lbSaldo.TabIndex = 5;
            this.lbSaldo.Text = "Saldo";
            // 
            // lbCategoriasGastos
            // 
            this.lbCategoriasGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCategoriasGastos.AutoSize = true;
            this.lbCategoriasGastos.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriasGastos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCategoriasGastos.Location = new System.Drawing.Point(12, 247);
            this.lbCategoriasGastos.Name = "lbCategoriasGastos";
            this.lbCategoriasGastos.Size = new System.Drawing.Size(200, 25);
            this.lbCategoriasGastos.TabIndex = 4;
            this.lbCategoriasGastos.Text = "Categorias de gastos";
            // 
            // chrCategoriaGastos
            // 
            this.chrCategoriaGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chrCategoriaGastos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrCategoriaGastos.Legends.Add(legend1);
            this.chrCategoriaGastos.Location = new System.Drawing.Point(68, 287);
            this.chrCategoriaGastos.Name = "chrCategoriaGastos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrCategoriaGastos.Series.Add(series1);
            this.chrCategoriaGastos.Size = new System.Drawing.Size(314, 22);
            this.chrCategoriaGastos.TabIndex = 3;
            this.chrCategoriaGastos.Text = "chart2";
            // 
            // chrIngresosGastos
            // 
            this.chrIngresosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chrIngresosGastos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrIngresosGastos.Legends.Add(legend2);
            this.chrIngresosGastos.Location = new System.Drawing.Point(111, 47);
            this.chrIngresosGastos.Name = "chrIngresosGastos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrIngresosGastos.Series.Add(series2);
            this.chrIngresosGastos.Size = new System.Drawing.Size(323, 175);
            this.chrIngresosGastos.TabIndex = 2;
            this.chrIngresosGastos.Text = "chart1";
            // 
            // lbIngresosGastos
            // 
            this.lbIngresosGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIngresosGastos.AutoSize = true;
            this.lbIngresosGastos.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresosGastos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbIngresosGastos.Location = new System.Drawing.Point(12, 9);
            this.lbIngresosGastos.Name = "lbIngresosGastos";
            this.lbIngresosGastos.Size = new System.Drawing.Size(169, 25);
            this.lbIngresosGastos.TabIndex = 1;
            this.lbIngresosGastos.Text = "Ingresos y gastos";
            // 
            // ReporteAnalisisFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteAnalisisFinanciero";
            this.Text = "Reporte y Analisis Financiero";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCategoriaGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrIngresosGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrCategoriaGastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrIngresosGastos;
        private System.Windows.Forms.Label lbIngresosGastos;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbCategoriasGastos;
        private System.Windows.Forms.DataGridView dgvSaldo;
    }
}