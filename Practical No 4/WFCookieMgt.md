```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFCookiesMGT.aspx.cs" Inherits="WebApplication1.WFCookiesMGT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Client Side Session Management using Cookies</h2><br />

            Page Counter :
            <asp:Label ID="lblCounter" runat="server" Text="Label"></asp:Label>
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
    public partial class WFCookiesMGT : System.Web.UI.Page
    {
        int counter = 0; // Value add 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["counter"] == null) 
            {
                counter = 1;
            }
            else
            {
                counter = int.Parse(Request.Cookies["counter"].Value) + 1;
            }

            Response.Cookies["counter"].Value = counter.ToString();

            Response.Cookies["counter"].Expires = DateTime.Now.AddSeconds(1);

            if(Request.Cookies["counter"] != null)
            {
                lblCounter.Text = Request.Cookies["counter"].Value;
            }
        }
    }
}
```
