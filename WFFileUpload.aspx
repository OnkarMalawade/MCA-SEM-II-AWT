<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFFileUpload.aspx.cs" Inherits="PracticalNo2All.WFFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>File Upload</h3>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Height="25px" />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
