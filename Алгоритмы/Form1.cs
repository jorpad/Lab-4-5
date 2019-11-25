using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Алгоритмы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxReply.Text = "";
                double x = Convert.ToDouble(txtbxForX.Text);
                double y = Convert.ToDouble(txtbxForY.Text);
                double z = Convert.ToDouble(txtbxForZ.Text);
                double l = (5 * Math.Atan(x)) - ((1 / 4) * Math.Acos(x)) * ((x + 3 * Math.Abs(x - y) + Math.Pow(x, 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2)));
                txtbxReply.Text = Convert.ToString(l);
            }
            catch
            {

            }
        }
        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                txtbxAnswer.Text = "";
                double x = Convert.ToDouble(txtbxForXNumberTwo.Text);
                double y = Convert.ToDouble(txtbxForYNumberTwo.Text);
                double fx = x;
                double ch = (Math.Exp(x) + Math.Exp(-x)) / 2;
                double m;
                if (rbtnCosX.Checked)
                    fx = Math.Cos(x);
                else if (rbtnSqrX.Checked)
                    fx = Math.Pow(x, 2);
                else if (rbtnExpX.Checked)
                    fx = Math.Exp(x);
                if ((x * y) < 5)
                {
                    m = Math.Pow(fx, 3) + Math.Sin(y);
                }
                if ((x * y) > 7)
                {
                    m = (ch * Math.Pow(fx, 3)) + Math.Pow(y, 2);
                }
                else
                {
                    m = Math.Cos(x + Math.Pow(fx, 3));
                }
                txtbxAnswer.Text = Convert.ToString(m);
            }
            catch
            {

            }
        }
    }
}
