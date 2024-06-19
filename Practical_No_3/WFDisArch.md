```
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo3
{
    public partial class WFDisconnectedArch : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["StudConnString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        SqlCommandBuilder builder = null;
        DataSet ds = null;

        public void clearData() {
            txtRoll.Text = "";
            txtNm.Text = "";
            txtAdd.Text = "";
        }
        public void showData()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                da = new SqlDataAdapter();
                ds = new DataSet();

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                cmd = new SqlCommand("Select * from StdInfo", conn);
                cmd.CommandType = CommandType.Text;

                da.SelectCommand = cmd;

                da.Fill(ds, "StdDS");

                GridView1.DataSource = ds.Tables["StdDS"];

                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Label4.Text = "Exception : " + ex.Message;
            }
            finally
            {
                // Close connection
                conn.Close();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            showData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new SqlCommandBuilder(da);

                DataRow drNew = ds.Tables["StdDS"].NewRow();

                drNew[0] = txtRoll.Text;
                drNew[1] = txtNm.Text;
                drNew[2] = txtAdd.Text;

                ds.Tables["StdDS"].Rows.Add(drNew);

                builder.GetInsertCommand();
                int r = da.Update(ds, "StdDS");
                if(r != 0)
                {
                    Label4.Text = "Record Inserted Successfully";
                }
                else
                {
                    Label4.Text = "Not Inserted";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception : " + ex.Message;
            }
            finally
            {
                // Close connection
                conn.Close();
                showData();
            }
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new SqlCommandBuilder(da);

                DataRow drUpdate = ds.Tables["StdDS"].Rows.Find(Convert.ToInt32(txtRoll.Text));

                if (drUpdate == null)
                {
                    Label4.Text = "Record Not Found";
                }
                else
                {
                    drUpdate[1] = txtNm.Text;
                    drUpdate[2] = txtAdd.Text;

                    //ds.Tables["StdDS"].Rows.Add(drUpdate);
                    builder.GetUpdateCommand();
                    int r = da.Update(ds, "StdDS");
                    if (r != 0)
                    {
                        Label4.Text = "Record Updated Successfully";
                    }
                    else
                    {
                        Label4.Text = "Record Not Updated";
                    }
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception : " + ex.Message;
            }
            finally
            {
                // Close connection
                conn.Close();
                showData();
            }
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new SqlCommandBuilder(da);

                DataRow drDelete = ds.Tables["StdDS"].Rows.Find(Convert.ToInt32(txtRoll.Text));

                if (drDelete == null)
                {
                    Label4.Text = "Record Not Found";
                }
                else {
                    drDelete.Delete();
                    builder.GetDeleteCommand();
                    int r = da.Update(ds, "StdDS");
                    if(r != 0)
                    {
                        Label4.Text = "Record Deleted Successfully";
                    }
                    else
                    {
                        Label4.Text = "Record Not Deleted";
                    }
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception : " + ex.Message;
            }
            finally
            {
                // Close connection
                conn.Close();
                showData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtRoll.Text != "")
                {
               
                    DataRow drSearch = ds.Tables[0].Rows.Find(Convert.ToInt32(txtRoll.Text));

                    if(drSearch != null)
                    {
                        Label4.Text = "Record Found";

                        clearData();

                        txtRoll.Text = drSearch[0].ToString();
                        txtNm.Text = drSearch[1].ToString();
                        txtAdd.Text = drSearch[2].ToString();
                    }
                    else
                    {
                        Label4.Text = "Record Not found";
                    }
                }
                else
                {
                    Label4.Text = "Please Enter Roll No.";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception : " + ex.Message;
            }
            finally
            {
                // Close connection
                conn.Close();
                showData();
            }
        }
    }
}
```

```
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WFDisconnectedArch.aspx.cs" Inherits="PracticalNo3.WFDisconnectedArch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
    <h1>Database Access Using Disconnected Architecture</h1>
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
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click" />
&nbsp;
            <asp:Button ID="btnUp" runat="server" Text="Update" OnClick="btnUp_Click" />
&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Clear" OnClick="Button1_Click" />
            <br />
&nbsp;
            </div>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
    </center>
</body>
</html>

```
