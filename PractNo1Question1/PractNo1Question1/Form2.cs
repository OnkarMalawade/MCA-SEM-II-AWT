using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractNo1Question1
{
    public partial class Form2 : Form
    {
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string uname { get; set; }
        public string pass { get; set; }
        public string city { get; set; }
        public string add { get; set; }
        public string hobby { get; set; }
        public string mob { get; set; }
        public string dob { get; set; }
        public Image imgB { get; set; }
        public string gen { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = fname;
            label2.Text = mname;
            label3.Text = lname;
            label4.Text = uname;
            label5.Text = pass;
            label6.Text = city;
            label7.Text = add;
            label8.Text = gen;
            label9.Text = hobby;
            label10.Text = mob;
            label11.Text = dob;
            pictureBox1.Image = imgB;
        }
    }
}
