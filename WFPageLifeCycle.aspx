<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFPageLifeCycle.aspx.cs" Inherits="PracticalNo2All.WFPageLifeCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDemo" runat="server" Text="Demonstration of ASP.net"></asp:Label>
            <br /><asp:Label ID="lblDemo2" runat="server" Text="Label"></asp:Label>
            <br />
            <br/><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
