```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WFHiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVisitCount.Text = string.Format("Clicked {0} times!", HiddenField1.Value);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if(HiddenField1.Value == null)
                {
                    HiddenField1.Value = 1.ToString();
                }
                else
                {
                    HiddenField1.Value = (Convert.ToInt32(HiddenField1.Value) + 1).ToString();
                }
            }
        }
    }
}
```

```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFHiddenField.aspx.cs" Inherits="WebApplication1.WFHiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Client Side Hidden Field for Count<br />
            <br />
            <asp:Label ID="lblVisitCount" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="Label"></asp:Label>
            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
            <asp:Button ID="btnSubmit" runat="server" PostBackUrl="~/WFHiddenField.aspx" Text="Visit Again" OnClick="btnSubmit_Click" />
            <br />
        </div>
    </form>
</body>
</html>

```
