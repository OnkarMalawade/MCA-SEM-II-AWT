using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo2All
{
    public partial class WFPageLifeCycle : System.Web.UI.Page
    {
        // Event Handling Methods
        protected void Page_PreInit(object sender, EventArgs e) 
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "PreInit";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "Init";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "InitComplete";
        }
        // Event
        protected override void OnPreLoad(EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "PreLoad";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "Load";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "Load Complete";
        }

        protected override void OnPreRender(EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "PreRender";
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "On Save State Complete";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "UnLoad";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //lblDemo2.ForeColor = System.Drawing.Color.AliceBlue;
            lblDemo2.Text = lblDemo2.Text + "<br/>" + "btnSubmit_Click";
        }
    }
}