``` Aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WFXmlDataSourceGV.aspx.cs" Inherits="PracticalNo3.WFXmlDataSourceGV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

           <h1> Gridview data bound and Xml Data Source</h1><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1" Height="303px" PageSize="4" Width="248px" AllowPaging="True">
                <Columns>
                    <asp:BoundField DataField="rollNo" HeaderText="rollNo" SortExpression="rollNo" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                </Columns>
                <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="First" LastPageText="Last" />
            </asp:GridView>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml"></asp:XmlDataSource>

            <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1">
                <ItemTemplate>
                    rollNo:
                    <asp:Label ID="rollNoLabel" runat="server" Text='<%# Eval("rollNo") %>' />
                    <br />
                    name:
                    <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="XmlDataSource1" Height="87px" Width="266px">
                <Fields>
                    <asp:BoundField DataField="rollNo" HeaderText="rollNo" SortExpression="rollNo" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                </Fields>
            </asp:DetailsView>
            <br />
            <asp:FormView ID="FormView1" runat="server" DataSourceID="XmlDataSource1">
                <EditItemTemplate>
                    rollNo:
                    <asp:TextBox ID="rollNoTextBox" runat="server" Text='<%# Bind("rollNo") %>' />
                    <br />
                    name:
                    <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    rollNo:
                    <asp:TextBox ID="rollNoTextBox" runat="server" Text='<%# Bind("rollNo") %>' />
                    <br />
                    name:
                    <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    rollNo:
                    <asp:Label ID="rollNoLabel" runat="server" Text='<%# Bind("rollNo") %>' />
                    <br />
                    name:
                    <asp:Label ID="nameLabel" runat="server" Text='<%# Bind("name") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>
            <br />
            <asp:ListView ID="ListView1" runat="server" DataSourceID="XmlDataSource1">
                <AlternatingItemTemplate>
                    <td runat="server" style="">rollNo:
                        <asp:Label ID="rollNoLabel" runat="server" Text='<%# Eval("rollNo") %>' />
                        <br />
                        name:
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                        <br />
                    </td>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <td runat="server" style="">rollNo:
                        <asp:TextBox ID="rollNoTextBox" runat="server" Text='<%# Bind("rollNo") %>' />
                        <br />
                        name:
                        <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table style="">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <td runat="server" style="">rollNo:
                        <asp:TextBox ID="rollNoTextBox" runat="server" Text='<%# Bind("rollNo") %>' />
                        <br />
                        name:
                        <asp:TextBox ID="nameTextBox" runat="server" Text='<%# Bind("name") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                </InsertItemTemplate>
                <ItemTemplate>
                    <td runat="server" style="">rollNo:
                        <asp:Label ID="rollNoLabel" runat="server" Text='<%# Eval("rollNo") %>' />
                        <br />
                        name:
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                        <br />
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server" border="0" style="">
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </table>
                    <div style="">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <td runat="server" style="">rollNo:
                        <asp:Label ID="rollNoLabel" runat="server" Text='<%# Eval("rollNo") %>' />
                        <br />
                        name:
                        <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                        <br />
                    </td>
                </SelectedItemTemplate>
            </asp:ListView>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="rollNo" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="rollNo" HeaderText="rollNo" ReadOnly="True" SortExpression="rollNo" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudConnString %>" SelectCommand="SELECT * FROM [StdInfo]"></asp:SqlDataSource>
            <br />
            <asp:DetailsView ID="DetailsView2" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="rollNo" DataSourceID="LinqDataSource1" Height="114px" Width="243px">
                <Fields>
                    <asp:BoundField DataField="rollNo" HeaderText="rollNo" ReadOnly="True" SortExpression="rollNo" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="PracticalNo3.DataClasses1DataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="StdInfos">
            </asp:LinqDataSource>
            <br />

        </div>
    </form>
</body>
</html>
```

``` XML
<?xml version="1.0" encoding="utf-8" ?>
<Students>
	<Student rollNo ="1" name="Onkar">
		<address> Talere </address>
	</Student>
	<Student rollNo ="2" name="Raju">
		<address> Kishan </address>
	</Student>
	<Student rollNo ="3" name="Abhi">
		<address> Pune </address>
	</Student>
	<Student rollNo ="4" name="Ashu">
		<address> Goa </address>
	</Student>
	<Student rollNo ="5" name="Bhai">
		<address> Talere </address>
	</Student>
	<Student rollNo ="6" name="Dada">
		<address> Kishan </address>
	</Student>
	<Student rollNo ="7" name="Chotu">
		<address> Pune </address>
	</Student>
	<Student rollNo ="8" name="Anu">
		<address> Goa </address>
	</Student>
</Students>
```
