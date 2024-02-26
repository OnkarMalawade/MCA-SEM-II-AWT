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
    public partial class Pract1Q8 : Form
    {
        DateTime date = DateTime.Now;
        public Pract1Q8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Pract1Q8_Load(object sender, EventArgs e)
        {
            textBox1.Text = date.ToString("F");
            textBox2.Text = date.ToString("D");
            textBox3.Text = date.ToString("d");
            textBox4.Text = date.ToString("G");
            textBox5.Text = date.ToString("T");
            textBox6.Text = date.ToString("t");
            textBox7.Text = (date.Year % 4 == 0) ? (366 - date.DayOfYear).ToString(): (365 - date.DayOfYear).ToString();
        }
    }
}
