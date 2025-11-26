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
            this.btnProc = new System.Windows.Forms.Button();
            this.listboxsp = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPuntoEffic = new System.Windows.Forms.Label();
            this.textBoxChartPrecision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_dq2 = new System.Windows.Forms.TextBox();
            this.input_dq1 = new System.Windows.Forms.TextBox();
            this.input_dq0 = new System.Windows.Forms.TextBox();
            this.input_do0 = new System.Windows.Forms.TextBox();
            this.input_do1 = new System.Windows.Forms.TextBox();
            this.input_do2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.input_oq3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.input_dq3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(372, 83);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(120, 36);
            this.btnProc.TabIndex = 4;
            this.btnProc.Text = "calcola";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // listboxsp
            // 
            this.listboxsp.FormattingEnabled = true;
            this.listboxsp.Location = new System.Drawing.Point(44, 154);
            this.listboxsp.Name = "listboxsp";
            this.listboxsp.Size = new System.Drawing.Size(591, 316);
            this.listboxsp.TabIndex = 20;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(641, 30);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(471, 440);
            this.chart.TabIndex = 21;
            this.chart.Text = "chart1";
            // 
            // labelPuntoEffic
            // 
            this.labelPuntoEffic.AutoSize = true;
            this.labelPuntoEffic.Location = new System.Drawing.Point(638, 473);
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
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Precisione (2^(-n). inserire n) preferibilmente minore di 8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "q +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "q^2 +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "d =";
            // 
            // input_dq2
            // 
            this.input_dq2.Location = new System.Drawing.Point(132, 27);
            this.input_dq2.Name = "input_dq2";
            this.input_dq2.Size = new System.Drawing.Size(26, 20);
            this.input_dq2.TabIndex = 31;
            this.input_dq2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_dq1
            // 
            this.input_dq1.Location = new System.Drawing.Point(187, 27);
            this.input_dq1.Name = "input_dq1";
            this.input_dq1.Size = new System.Drawing.Size(26, 20);
            this.input_dq1.TabIndex = 32;
            this.input_dq1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_dq0
            // 
            this.input_dq0.Location = new System.Drawing.Point(231, 27);
            this.input_dq0.Name = "input_dq0";
            this.input_dq0.Size = new System.Drawing.Size(26, 20);
            this.input_dq0.TabIndex = 33;
            this.input_dq0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_do0
            // 
            this.input_do0.Location = new System.Drawing.Point(231, 53);
            this.input_do0.Name = "input_do0";
            this.input_do0.Size = new System.Drawing.Size(26, 20);
            this.input_do0.TabIndex = 39;
            this.input_do0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_do1
            // 
            this.input_do1.Location = new System.Drawing.Point(187, 53);
            this.input_do1.Name = "input_do1";
            this.input_do1.Size = new System.Drawing.Size(26, 20);
            this.input_do1.TabIndex = 38;
            this.input_do1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input_do2
            // 
            this.input_do2.Location = new System.Drawing.Point(132, 53);
            this.input_do2.Name = "input_do2";
            this.input_do2.Size = new System.Drawing.Size(26, 20);
            this.input_do2.TabIndex = 37;
            this.input_do2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "q +";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "q^2 +";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 56);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "o =";
            // 
            // input_oq3
            // 
            this.input_oq3.Location = new System.Drawing.Point(69, 53);
            this.input_oq3.Name = "input_oq3";
            this.input_oq3.Size = new System.Drawing.Size(26, 20);
            this.input_oq3.TabIndex = 43;
            this.input_oq3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "q^3 +";
            // 
            // input_dq3
            // 
            this.input_dq3.Location = new System.Drawing.Point(69, 27);
            this.input_dq3.Name = "input_dq3";
            this.input_dq3.Size = new System.Drawing.Size(26, 20);
            this.input_dq3.TabIndex = 41;
            this.input_dq3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "q^3 +";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 527);
            this.Controls.Add(this.input_oq3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.input_dq3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.input_do0);
            this.Controls.Add(this.input_do1);
            this.Controls.Add(this.input_do2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_dq0);
            this.Controls.Add(this.input_dq1);
            this.Controls.Add(this.input_dq2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_dq2;
        private System.Windows.Forms.TextBox input_dq1;
        private System.Windows.Forms.TextBox input_dq0;
        private System.Windows.Forms.TextBox input_do0;
        private System.Windows.Forms.TextBox input_do1;
        private System.Windows.Forms.TextBox input_do2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_oq3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox input_dq3;
        private System.Windows.Forms.Label label9;
    }
}

