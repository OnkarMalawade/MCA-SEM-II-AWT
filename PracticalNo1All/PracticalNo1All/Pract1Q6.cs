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
    public partial class Pract1Q6 : Form
    {
        IndexerClass team = null;
        public Pract1Q6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                team = new IndexerClass();
                team[0] = textBox1.Text;
                team[1] = textBox2.Text;
                team[2] = textBox3.Text;

                label4.Text = team[0];
                label5.Text = team[1];
                label6.Text = team[2];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
    }

    class IndexerClass
    {
        private string[] names = new string[3];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
}
