using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Phuongtrinhbac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            Double a, b, x;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);

            if (a != 0)
            {
                x = -b / a;

                lblKQ.Text = "Nghiệm của phương trình là x = " + x.ToString();
            }
            else
            {
                if (b != 0)
                {
                    lblKQ.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    lblKQ.Text = "Phương trình đúng với mọi x ";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }
    }
}
