```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo3
{
    public partial class WFLinqToSQL : System.Web.UI.Page
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public void showData()
        {
            try
            {
                var q = from a in dc.GetTable < StdInfo >() select a;
                GridView1.DataSource = q;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception " + ex.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void clearData()
        {
            txtRoll.Text = "";
            txtNm.Text = "";
            txtAdd.Text = "";
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StdInfo std = new StdInfo();
                std.rollNo = Convert.ToByte(txtRoll.Text);
                std.name = txtNm.Text;
                std.address = txtAdd.Text;

                dc.StdInfos.InsertOnSubmit(std);
                
                dc.SubmitChanges();

                Label4.Text = "Record Added Successfully";
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception " + ex.Message;
            }
            finally
            {
                showData();
            }
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                StdInfo objDel = dc.StdInfos.Single(StdInfo => StdInfo.rollNo == Convert.ToInt16(txtRoll.Text));
                
                if(objDel != null)
                {
                    dc.StdInfos.DeleteOnSubmit(objDel);
                    Label4.Text = "Record Deleted Successfully";
                    dc.SubmitChanges();
                }
                else
                {
                    Label4.Text = "Record Not Deleted";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception " + ex.Message;
            }
            finally
            {
                showData();
            }
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                StdInfo objUp = dc.StdInfos.Single(StdInfo => StdInfo.rollNo == Convert.ToInt16(txtRoll.Text));
                if (objUp != null) {
                    objUp.name = Convert.ToString(txtNm.Text);
                    objUp.address = Convert.ToString(txtAdd.Text);

                    dc.SubmitChanges();

                    Label4.Text = "Record Updated Successfully";
                }
                else
                {
                    Label4.Text = "Record Not Updated Successfully";
                }
                clearData();
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception " + ex.Message;
            }
            finally
            {
                showData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                StdInfo objSc = dc.StdInfos.Single(StdInfo => StdInfo.rollNo == Convert.ToInt16(txtRoll.Text));
                if (objSc != null)
                {
                    txtRoll.Text = Convert.ToString(objSc.rollNo);
                    txtNm.Text = objSc.name;
                    txtAdd.Text = objSc.address;

                    Label4.Text = "Record Searched Successfully";
                }
                else
                {
                    Label4.Text = "Record Not Searched Successfully";
                }
                clearData();
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception " + ex.Message;
            }
            finally
            {
                showData();
            }
        }
    }
}
```

```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFLinqToSQL.aspx.cs" Inherits="PracticalNo3.WFLinqToSQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Data Access Using LINQ to SQL</h1>
        <div aria-setsize="10">
            <asp:Label ID="Label1" runat="server" Text="Enter Roll No.:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtRoll" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Name: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNm" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter Address:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="218px" Width="330px">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"  />
&nbsp;&nbsp;
            <asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click"  />
&nbsp;
            <asp:Button ID="btnUp" runat="server" Text="Update" OnClick="btnUp_Click"/>
&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"/>
            <br />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click"  />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
&nbsp;
            </div>
        
    </form>
</body>
</html>

```

<img src = "https://github.com/OnkarMalawade/MCA-SEM-II-AWT/blob/main/Practical_No_3/Screenshot%202024-06-19%20201535.png?raw=true" alt = "dataClassess1.dbml" />
