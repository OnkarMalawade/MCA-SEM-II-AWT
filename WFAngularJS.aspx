<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFAngularJS.aspx.cs" Inherits="PracticalNo2All.WFAngularJS" %>

<!DOCTYPE html>

<!-- <script src="/Scripts/angular.min.js"></script> -->
<script src="//ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js"></script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div ng-app="">
            <h1>
            Name :&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ng-model="name"></asp:TextBox>
            <br />
            Hello {{name}}
            </h1>
        </div>
    </form>
</body>
</html>
