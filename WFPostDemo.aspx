<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPostDemo.aspx.cs" Inherits="PracticalNo2All.WFPostDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Your Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                <DayStyle Width="14%" />
                <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                <TodayDayStyle BackColor="#CCCC99" />
            </asp:Calendar>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please Enter Name"></asp:RequiredFieldValidator>
            <asp:Button ID="btnPostBack" runat="server" OnClick="btnPostBack_Click" Text="Same Page Post Back" />
            <asp:Button ID="btnCross" runat="server" OnClick="btnCross_Click" PostBackUrl="~/WFPostiDemo2.aspx" Text="Cross Page Post Back" />
            <br />
            <asp:Label ID="lblData" runat="server" Text="Label"></asp:Label>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="CustomValidator"></asp:CustomValidator>
        </div>
    </form>
</body>
</html>
