using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        double d(double q)
        {
            return 90 - 4 * q;
        }
        double o(double q)
        {
            return 10 + (q * q * q / 100);
        }
        private void btnProc_Click(object sender, EventArgs e)
        {
            // calcolo punto di equilibrio
            double q = 0;
            double diffsp = 1;
            double maxsp = (float)1 / (float)65536; //precisione 1/2^16
            double qResult = 0;
            while (diffsp>=maxsp)
            {
                var result_d = d(q);
                var result_o = o(q);
                if (!(result_d>result_o)) { 
                q = q - diffsp; diffsp = diffsp / 2;listboxsp.Items.Add($"d = {result_d}, o = {result_o}, q- = {q - diffsp}, q+ = {q}"); qResult = (q+q-diffsp)/2;
                }
                q = q + diffsp;
            }
            labelPuntoEffic.Text = $"Quantità di equilibrio: q = {qResult}, d = {d(qResult)}, o = {o(qResult)} -- precisione 1/2^16";



        }
    }
}
