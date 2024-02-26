using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalNo1All
{
    public partial class Pract1Q3 : Form
    {
        Wind d = null;
        public Pract1Q3()
        {
            InitializeComponent();
        }

        private void btnMPH_Click(object sender, EventArgs e)
        {
            double kn = Convert.ToDouble(textBox1.Text);
            d = new Wind(kn);
            MessageBox.Show("Value of MPH:" + d.mph());
        }

        private void btnKPH_Click(object sender, EventArgs e)
        {
            double kn = Convert.ToDouble(textBox1.Text);
            d = new Wind(kn);
            MessageBox.Show("Value of KPH:" + d.Kph());
        }
    }

    class Wind
    {
        double w;

        public Wind()
        {

        }

        public Wind(double p)
        {
            w = p;
        }

        ~Wind()
        {

        }

        public double getW()
        {
            return w;
        }

        public double mph()
        {
            return 1.15078 * w;
        }

        public double Kph()
        {
            return w * 1.852;
        }
    }
}
