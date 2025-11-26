namespace funzioni_costo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnProc = new System.Windows.Forms.Button();
            this.listboxsp = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPuntoEffic = new System.Windows.Forms.Label();
            this.textBoxChartPrecision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(505, 83);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(120, 36);
            this.btnProc.TabIndex = 4;
            this.btnProc.Text = "ok";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // listboxsp
            // 
            this.listboxsp.FormattingEnabled = true;
            this.listboxsp.Location = new System.Drawing.Point(433, 156);
            this.listboxsp.Name = "listboxsp";
            this.listboxsp.Size = new System.Drawing.Size(591, 316);
            this.listboxsp.TabIndex = 20;
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(44, 149);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(383, 350);
            this.chart.TabIndex = 21;
            this.chart.Text = "chart1";
            // 
            // labelPuntoEffic
            // 
            this.labelPuntoEffic.AutoSize = true;
            this.labelPuntoEffic.Location = new System.Drawing.Point(447, 486);
            this.labelPuntoEffic.Name = "labelPuntoEffic";
            this.labelPuntoEffic.Size = new System.Drawing.Size(0, 13);
            this.labelPuntoEffic.TabIndex = 22;
            // 
            // textBoxChartPrecision
            // 
            this.textBoxChartPrecision.Location = new System.Drawing.Point(44, 111);
            this.textBoxChartPrecision.Name = "textBoxChartPrecision";
            this.textBoxChartPrecision.Size = new System.Drawing.Size(45, 20);
            this.textBoxChartPrecision.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Precisione (2^(-n). inserire n)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxChartPrecision);
            this.Controls.Add(this.labelPuntoEffic);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.listboxsp);
            this.Controls.Add(this.btnProc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.ListBox listboxsp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label labelPuntoEffic;
        private System.Windows.Forms.TextBox textBoxChartPrecision;
        private System.Windows.Forms.Label label1;
    }
}

