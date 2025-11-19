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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnProc = new System.Windows.Forms.Button();
            this.listboxsp = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPuntoEffic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(31, 55);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(120, 36);
            this.btnProc.TabIndex = 4;
            this.btnProc.Text = "Calcola";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // listboxsp
            // 
            this.listboxsp.FormattingEnabled = true;
            this.listboxsp.Location = new System.Drawing.Point(456, 41);
            this.listboxsp.Name = "listboxsp";
            this.listboxsp.Size = new System.Drawing.Size(656, 264);
            this.listboxsp.TabIndex = 20;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(31, 292);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(207, 200);
            this.chart.TabIndex = 21;
            this.chart.Text = "chart1";
            // 
            // labelPuntoEffic
            // 
            this.labelPuntoEffic.AutoSize = true;
            this.labelPuntoEffic.Location = new System.Drawing.Point(457, 315);
            this.labelPuntoEffic.Name = "labelPuntoEffic";
            this.labelPuntoEffic.Size = new System.Drawing.Size(0, 13);
            this.labelPuntoEffic.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 539);
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
    }
}

