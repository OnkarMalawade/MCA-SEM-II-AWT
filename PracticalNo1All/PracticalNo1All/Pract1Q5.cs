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
    public partial class Pract1Q5 : Form
    {
        Rectangle rect = null;
        public Pract1Q5()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtLength.Text);
            int b = Convert.ToInt32(txtBreadth.Text);
            if (b == 0)
            {
                rect = new Rectangle(a, a);

                MessageBox.Show("This is Area of Square " + rect.area());
            }
            else
            {
                rect = new Rectangle(a, b);

                MessageBox.Show("This is Area of Rectangle " + rect.area());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    abstract class Shape
    {
        public abstract int area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int a, int b)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            return length * width;
        }
    }

}
