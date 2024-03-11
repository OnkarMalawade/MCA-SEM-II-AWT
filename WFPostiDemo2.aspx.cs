using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo2All
{
    public partial class WFPostiDemo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                // creating conntrol
                Calendar cal1 = new Calendar();
                TextBox txtData = new TextBox();

                cal1 = (Calendar)(PreviousPage.FindControl("Calendar1"));
                txtData = (TextBox)(PreviousPage.FindControl("txtName"));

                lblTextData.Text = "Hi!!! " + txtData.Text + ", Here is Your Birth date , " + cal1.SelectedDate.ToString("dd / MMMM /yyyy");
            }
            else {
                lblTextData.Text = "Hello Sir";
            }
        }
    }
}