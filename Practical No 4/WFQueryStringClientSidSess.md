```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFQueryString.aspx.cs" Inherits="WebApplication1.WFQueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Client Side Session Management Using Query String</h2>
            <br />
&nbsp;<asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Counter :
            <asp:Label ID="lblCounter" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
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
    public partial class WFQueryString : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            count = Convert.ToInt32(Server.UrlDecode(Request.QueryString["count"]));

            if(count != 0)
            {
                count += 1; 
            }
            else
            {
                count = 1;
            }

            lblCounter.Text = Convert.ToString(count);

            lblMessage.Text = "Welcome " + Request.QueryString["name"];
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFQueryString.aspx?count=" + Server.UrlEncode((lblCounter.Text)) + "&&name=Onkar");
        }
    }
}
```
