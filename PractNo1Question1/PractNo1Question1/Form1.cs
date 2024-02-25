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
    public partial class Form1 : Form
    {
        Register reg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int mob = Convert.ToInt32(txtMob.Text);
                string fn = txtfname.Text;
                string mn = txtmname.Text;
                string ln = txtLname.Text;
                string un = uname.Text;
                string ps = password.Text;
                string gen = gender.Text;
                string hob = txtHobby.Text;
                string ad = txtAdd.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Caught!!! " + ex.Message + " at line " + ex.StackTrace);
            }
            finally
            {
                MessageBox.Show("Thank You!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
    // class register
    class Register
    {
        string fname;
        string lname;
        string mname;
        string uname;
        string pass;
        string mob;
        string dob;
        string city;
        string gender;
        string add;
        string hobby;


    }
}
