```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFAjax.aspx.cs" Inherits="WebApplication1.WFAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">

            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Image ID="imgBanner" runat="server" Width="1000px" Height="300px" ImageUrl="~/Images/banner_1.jpg" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
            <br />
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
            </asp:Timer>
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
    public partial class WFAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random RndNm = new Random();

            int n = RndNm.Next(1, 6);

            imgBanner.ImageUrl = String.Concat("Images/banner_", n.ToString(), ".jpg");
        }
    }
}
```
