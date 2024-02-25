using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractNo01Question2
{
    public partial class Form1 : Form
    {
        Year y = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int e2 = Convert.ToInt32(txtYear.Text);
                y = new Year(e2);
                MessageBox.Show(y.check());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Caught!!! " + ex.Message + " at line " + ex.StackTrace);
            }
        }
    }

    class Year
    {
        int y;

        public Year()
        {

        }

        ~Year()
        {

        }

        public Year(int e)
        {
            this.y = e;
        }

        public int getY()
        {
            return y;
        }

        public string check()
        {
            if(y % 4 == 0)
            {
                return "It is Leap Year";
            }
            return "It is Not Leap Year";
        }
    }
}
