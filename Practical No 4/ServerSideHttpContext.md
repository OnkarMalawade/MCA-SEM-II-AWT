```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerSideHttpContext.aspx.cs" Inherits="WebApplication1.ServerSideHttpContext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="color: darkred">
            <h2>Server Side Sesssion Management Using HttpContext</h2>
            Enter Name:
            <asp:TextBox ID="txtName" runat="server" Height="30px" Width="302px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStore" runat="server" Text="Store" OnClick="btnStore_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRetrive" runat="server" Text="Retrive" OnClick="btnRetrive_Click" />
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
    public partial class ServerSideHttpContext : System.Web.UI.Page
    {
        HttpContext context = HttpContext.Current;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            context.Session["UserName"] = txtName.Text;

            txtName.Text = "";
        }

        protected void btnRetrive_Click(object sender, EventArgs e)
        {
            txtName.Text = (string)(context.Session["UserName"]);
        }
    }
}
```
