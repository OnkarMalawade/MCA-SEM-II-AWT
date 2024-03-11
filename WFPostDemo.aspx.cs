using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo2All
{
    public partial class WFPostDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblData.Text = "Hi!!! " + txtName.Text;
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            lblData.Text = "Hi!!! " + txtName.Text +", Here is Your Birth date , "+ Calendar1.SelectedDate.ToString("dd / MMMM /yyyy");
        }

        protected void btnCross_Click(object sender, EventArgs e)
        {

        }
    }
}