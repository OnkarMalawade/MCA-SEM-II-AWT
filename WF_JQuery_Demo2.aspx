<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_JQuery_Demo2.aspx.cs" Inherits="PracticalNo2All.WF_JQuery_Demo2" %>

<!DOCTYPE html>

<script type="text/javascript" src ="//ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
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
              <div>
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
        </div>
    </form>
</body>
</html>
