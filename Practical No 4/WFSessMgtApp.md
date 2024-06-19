```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFsessionMgtApplication.aspx.cs" Inherits="WebApplication1.WFsessionMgtApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2> Session Management using Application State </h2>
            Total Visitor Counter :
            <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
            <br />
            Online Visitor Counter :
            <asp:Label ID="lblOnline" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Clear Session" OnClick="Button1_Click" />
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
    public partial class WFsessionMgtApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "No. of Visitors visted = " + Application["SiteVisited"].ToString();
            lblOnline.Text = "No. of Peoples Online Now = " + Application["OnlineVisited"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}
```
