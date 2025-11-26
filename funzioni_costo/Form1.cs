using Antlr4.Runtime.Atn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace funzioni_costo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dq2, dq1, dq0, oq2, oq1, oq0, dq3, oq3 = 0;
        double d(double q)
        {
            return dq3 * q*q*q + dq2 * q*q + dq1 * q + dq0;
        }
        double o(double q)
        {
            return oq3 * q*q*q + oq2 * q*q + oq1 * q + oq0;
        }
        private void btnProc_Click(object sender, EventArgs e)
        {
            // calcolo punto di equilibrio
            
            if (!int.TryParse(textBoxChartPrecision.Text, out int precision)) { MessageBox.Show("inserire un numero per Precisione"); return; }
            if (chart.Series.IndexOf("Domanda") != -1) chart.Series.Remove(chart.Series["Domanda"]);
            if (chart.Series.IndexOf("Offerta") != -1) chart.Series.Remove(chart.Series["Offerta"]);
            listboxsp.Items.Clear();

            var r_dq3 = input_dq3.Text;
            if (r_dq3 == "") dq3 = 0;
            else if (!double.TryParse(r_dq3, out dq3)) { MessageBox.Show("errore dati: dq3"); return; }
            var r_dq2 = input_dq2.Text;
            if (r_dq2 == "") dq2 = 0;
            else if (!double.TryParse(r_dq2, out dq2)) { MessageBox.Show("errore dati: dq2"); return; }
            var r_dq1 = input_dq1.Text;
            if (r_dq1 == "") dq1 = 0;
            else if (!double.TryParse(r_dq1, out dq1)) { MessageBox.Show("errore dati: dq1"); return; }
            var r_dq0 = input_dq0.Text;
            if (r_dq0 == "") dq0 = 0;
            else if (!double.TryParse(r_dq0, out dq0)) { MessageBox.Show("errore dati: dq0"); return; }
            var r_oq3 = input_oq3.Text;
            if (r_oq3 == "") oq3 = 0;
            else if (!double.TryParse(r_oq3, out oq3)) { MessageBox.Show("errore dati: oq3"); return; }
            var r_do2 = input_do2.Text;
            if (r_do2 == "") oq2 = 0;
            else if (!double.TryParse(r_do2, out oq2)) { MessageBox.Show("errore dati: oq2"); return; }
            var r_do1 = input_do1.Text;
            if (r_do1 == "") oq1 = 0;
            else if (!double.TryParse(r_do1, out oq1)) { MessageBox.Show("errore dati: oq1"); return; }
            var r_do0 = input_do0.Text;
            if (r_do0 == "") oq0 = 0;
            else if (!double.TryParse(r_do0, out oq0)) { MessageBox.Show("errore dati: oq0"); return; }

            double maxsp = (double)1 / (double)Math.Pow(2, precision);
            double q = 0;
            double diffsp = 1;
            double qResult = 0;

            while (diffsp >= maxsp)
            {
                var result_d = d(q);
                var result_o = o(q);
                if (!(result_d > result_o))
                {
                    q = q - diffsp; diffsp = diffsp / 2; listboxsp.Items.Add($"d = {result_d}, o = {result_o}, q- = {q - diffsp}, q+ = {q}"); qResult = (q + q - diffsp) / 2;
                }
                q = q + diffsp;
            }
            labelPuntoEffic.Text = $"Quantità di equilibrio: q = {qResult}, d = {d(qResult)}, o = {o(qResult)}";

            //
            
            
            q = 0;
            double qStop = 30;
            chart.Series.Add("Domanda");
            chart.Series["Domanda"].Color = Color.Brown;
            chart.Series["Domanda"].ChartType = SeriesChartType.Point;

            chart.Series.Add("Offerta");
            chart.Series["Offerta"].Color = Color.Orange;
            chart.Series["Offerta"].ChartType = SeriesChartType.Point;
            while (q <= qStop)
            {
                var result_d = d(q);
                var result_o = o(q);
                chart.Series["Domanda"].Points.AddXY(q, result_d);
                chart.Series["Offerta"].Points.AddXY(q, result_o);
                q = q + maxsp;
            
            }

        }
    }
}
