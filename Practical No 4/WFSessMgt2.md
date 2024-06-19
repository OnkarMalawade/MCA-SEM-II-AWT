```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFSessionState2.aspx.cs" Inherits="WebApplication1.WFSessionState2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name:
            <asp:Label ID="lblFNm" runat="server" Text="Label"></asp:Label>
            <br />
            Last Name:
            <asp:Label ID="lblLnm" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

```

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WFSessionState2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FNmData"] == null && Session["LNmData"] == null)
            {
                lblFNm.Text = "No data Found";
            }
            else
            {
                Response.Write("<script>window.alert('Data found ')</script>");
                lblFNm.Text = (Session["FNmData"].ToString());
                lblLnm.Text = (Session["LNmData"].ToString());
            }
        }
    }
}
