```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFCacheF1.aspx.cs" Inherits="WebApplication1.WFCacheF1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h2>Server Side Session Management Using Cache</h2>
            First Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Last Name:<asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Set Data" Width="139px" OnClick="btnSubmit_Click" />
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
    public partial class WFCacheF1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Cache["FNmData"] = txtName.Text;
            Cache["LNmData"] = txtLName.Text;

            Response.Redirect("WFCacheF2.aspx");
        }
    }
}
```

```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFCacheF2.aspx.cs" Inherits="WebApplication1.WFCacheF2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
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
    public partial class WFCacheF2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Cache["FNmData"] == null && Cache["LNmData"] == null)
            {
                lblData.Text = "No data Found";
            }
            else
            {
                Response.Write("<script>window.alert('Data found ')</script>");
                lblData.Text = (Cache["FNmData"].ToString()) + " " + (Cache["LNmData"].ToString());
            }
        }
    }
}
```
