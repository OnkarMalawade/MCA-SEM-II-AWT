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
    public partial class Pract1Q7 : Form
    {
        public Pract1Q7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string p = s1.ToUpper();
            string q = s2.ToUpper();
            label3.Text = p;
            label4.Text = q;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string p = s1.ToLower();
            string q = s2.ToLower();
            label3.Text = p;
            label4.Text = q;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            MessageBox.Show(s1 + " " + s2);
        }
    }
}
