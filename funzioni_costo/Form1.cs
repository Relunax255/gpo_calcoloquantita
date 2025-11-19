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
using AngouriMath;

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
            double q = 0;
            double diffsp = 1;
            double maxsp = (float)1 / (float)1024;
            while (diffsp>=maxsp)
            {
                var result_d = d(q);
                var result_o = o(q);
                if (!(result_d>result_o)) { 
                q = q - diffsp; diffsp = diffsp / 2;listboxsp.Items.Add($"d = {result_d}, o = {result_o}, q- = {q - diffsp}, q+ = {q}"); }
                q = q + diffsp;
            }
        }
    }
}
