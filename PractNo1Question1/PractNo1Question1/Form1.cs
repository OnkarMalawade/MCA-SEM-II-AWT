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
            Form2 f2 = new Form2();

            f2.fname = txtfname.Text;
            f2.mname = txtmname.Text;
            f2.lname = txtLname.Text;
            f2.dob = dtDOB.Value.ToShortDateString();
            f2.add = txtAdd.Text;
            f2.mob = txtMob.Text;
            f2.uname = uname.Text;
            f2.pass = password.Text;
            f2.gen = radioBtnMale.Checked ? "Male" : "Female";
            f2.hobby = txtHobby.Text;
            f2.city = txtCity.Text;
            f2.imgB = picBox.Image;

            f2.ShowDialog();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    picBox.ImageLocation = imageLocation;
                }
                     
            }catch(Exception)
            {
                MessageBox.Show("Error:" , "Error", MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }
    }
}
