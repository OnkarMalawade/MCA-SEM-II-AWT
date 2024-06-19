```<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFViewState.aspx.cs" Inherits="WebApplication1.WFViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> View State Demo </h2><br />
            Page Counter :
            <asp:Label ID="lblCounter" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnCount" runat="server" Text="Add Count" OnClick="btnCount_Click" PostBackUrl="~/WFViewState.aspx" />
        </div>
    </form>
</body>
</html>

```

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WFViewState : System.Web.UI.Page
    {
        int counter;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCounter.Text = "Counter : " + counter;
        }

        protected void btnCount_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if(ViewState["Counter"] == null)
                {
                    counter = 1;
                }
                else
                {
                    // counter = Convert.ToInt32(ViewState["Counter"]) + 1;
                    counter = (int)ViewState["Counter"] + 1;
                }
                ViewState["Counter"] = counter;
                lblCounter.Text = "Counter : " + ViewState["Counter"];
            }
        }
    }
}
```
