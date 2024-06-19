```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPagination.aspx.cs" Inherits="WebApplication1.WFPagination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Pagination AJAX</strong><br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="cid" DataSourceID="SqlDataSource1" PageSize="2">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="cid" HeaderText="cid" ReadOnly="True" SortExpression="cid" />
                            <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                            <asp:BoundField DataField="cadd" HeaderText="cadd" SortExpression="cadd" />
                        </Columns>
                        <PagerSettings Mode="NextPrevious" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:custDBConnectionString %>" SelectCommand="SELECT * FROM [cust_info]"></asp:SqlDataSource>
                    <br />
                    <br />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
            <br />
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
    public partial class WFPagination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if(GridView1.PageIndex != GridView1.PageCount - 1)
            {
                GridView1.PageIndex++;
            }
            else
            {
                GridView1.PageIndex = 0;
            }
        }
    }
}
```
