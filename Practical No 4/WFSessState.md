```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFSessionState.aspx.cs" Inherits="WebApplication1.WFSessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Session Side Session Management using SessionState</h2>First Name:
            <asp:TextBox ID="txtFnm" runat="server"></asp:TextBox>
            <br />
            Last Name:
            <asp:TextBox ID="txtLnm" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Set Session State Data" Width="189px" />
            <br />
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
    public partial class WFSessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["FNmData"] = txtFnm.Text;
            Session["LNmData"] = txtLnm.Text;

            Response.Redirect("WFSessionState2.aspx");
        }
    }
}
```
