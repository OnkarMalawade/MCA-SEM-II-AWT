```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFUpdateProgress.aspx.cs" Inherits="WebApplication1.WFUpdateProgress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <h1>AJAX Extentension - ScriptManager, UpdatePanel and UpdateProgress</h1><br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">

            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <br />
                    Number 1 :
                    <asp:TextBox ID="txtNum" runat="server" Height="28px" Width="184px"></asp:TextBox>
                    <br />
                    <br />
                    Number 2 :
                    <asp:TextBox ID="txtNum2" runat="server" Height="28px" Width="182px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                        <ProgressTemplate>
                            Calculating Please Wait...
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <asp:Label ID="lblSum" runat="server" ForeColor="#00CC00" Text="Label"></asp:Label>
                    <br />
                    <asp:Label ID="lblSub" runat="server" ForeColor="#FF0066" Text="Label"></asp:Label>
<br />
                    <asp:Label ID="lblMul" runat="server" ForeColor="#3333CC" Text="Label"></asp:Label>
                    <br />
                    <asp:Button ID="btbCalculate" runat="server" Height="58px" Text="Calculate" Width="193px" OnClick="btbCalculate_Click" />
                </ContentTemplate>
                
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btbCalculate" EventName="Click" />
                </Triggers>
                
            </asp:UpdatePanel>
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
    public partial class WFUpdateProgress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btbCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(txtNum.Text);
                int n2 = Convert.ToInt32(txtNum2.Text);

                System.Threading.Thread.Sleep(5000);

                int add = n1 + n2;
                int sub = n1 - n2;
                int mult = n1 * n2;

                lblSum.Text = String.Concat("Addition : ", add.ToString());
                lblSub.Text = "Substraction : " + sub;
                lblMul.Text = string.Format("Multiplication : {0}",mult);
        
            }
            catch (Exception ex)
            {

            }
        }
    }
}
```
