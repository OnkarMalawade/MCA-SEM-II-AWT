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
    public partial class Pract1No4 : Form
    {
        Dervied dd = new Dervied();
        public Pract1No4()
        {
            InitializeComponent();
        }

        private void baseClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is " + dd.show());
        }

        private void derClass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is " + dd.display());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class Base
    {
        public string show()
        {
            return "Base Class ";
        }
    }
    class Dervied : Base
    {
        public string display()
        {
            return "Derived Class ";
        }
    }
}
