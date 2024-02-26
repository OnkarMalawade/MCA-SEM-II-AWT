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
    public partial class Pract1Q2 : Form
    {
        Year y = null;
        public Pract1Q2()
        {
            InitializeComponent();
        }

        private void Pract1Q2_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (y % 4 == 0)
            {
                return "It is Leap Year";
            }
            return "It is Not Leap Year";
        }
    }
 }
