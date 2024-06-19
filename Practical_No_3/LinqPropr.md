```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFLINQ1.aspx.cs" Inherits="PracticalNo3.WFLINQ1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            LINQ Program to find the Words Less Than 6 Characters<br />
            <br />
            Input Data:
            <asp:Label ID="lblIp" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Display Short Words:
            <asp:Label ID="lblOp" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select Words" />
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

namespace PracticalNo3
{
    public partial class WFLINQ1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIp.Text = "";
            lblOp.Text = "";
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            string[] my_Words = {"hello", "Friends", "Chai", "Pilo"};

            foreach (var w in my_Words)
            {
                lblIp.Text = lblIp.Text + " " + w;
            }

            var Short_Words = from w in my_Words where w.Length <= 5 select w;

            foreach (var w in Short_Words)
            {
                lblOp.Text = lblOp.Text + " " + w;
            }
        }
    }
}
```
