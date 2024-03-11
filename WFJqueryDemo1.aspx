<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFJqueryDemo1.aspx.cs" Inherits="PracticalNo2All.WFJqueryDemo1" %>

<!DOCTYPE html>

<script type="text/javascript" src ="/Scripts/jquery-3.7.1.min.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("#btnSubmit").click(function () {
            alert("Alert Using JQuery");
        });
    });
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
