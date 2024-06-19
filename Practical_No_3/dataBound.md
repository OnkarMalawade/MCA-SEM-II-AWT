``` C#
WFConnectedArchi.aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFConnectedArchitectue.aspx.cs" Inherits="PracticalNo3Questions.WFConnectedArchitectue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Database Access Using Connected Architecture</h1>
    <form id="form1" runat="server">
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
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnDel" runat="server" Text="Update" OnClick="btnDel_Click" />
&nbsp;
            <asp:Button ID="btnUp" runat="server" Text="Delete" OnClick="btnUp_Click" />
&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
&nbsp;
            <asp:Button ID="btnSort" runat="server" Text="Sort" OnClick="btnSort_Click" />
&nbsp;
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <br />
&nbsp;
            </div>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </form>
</body>
</html>
```
``` 
WFConnectedArchi.aspx.cs
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo3Questions
{
    public partial class WFConnectedArchitectue : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        public void showData()
        {
            try
            {
                cmd = new SqlCommand("Select * from custData", conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                dt = new DataTable();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label4.Text = "Error" + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            showData();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtRoll.Text = "";
            txtNm.Text = "";
            txtAdd.Text = "";
            txtSearch.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoll.Text != "" && txtNm.Text != "" && txtAdd.Text != "")
                {
                    cmd = new SqlCommand("Insert into custData(cid, cname, cadd) values (@rN, @Nm, @Add)", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@rN", txtRoll.Text);
                    cmd.Parameters.AddWithValue("@Nm", txtNm.Text);
                    cmd.Parameters.AddWithValue("@Add", txtAdd.Text);

                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        //Response.Write("<script>alert(`Record Inserted Successfully ${txtNm.Text});</script>");
                        Label4.Text = "Record inserted";
                    }
                    else
                    {
                        Label4.Text = "Record not inserted";
                        //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                Label4.Text = ex.Message;

            }

        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoll.Text != "")
                {
                    cmd = new SqlCommand("Delete custData where cid=@rN", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@rN", txtRoll.Text);


                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        //Response.Write("<script>alert(`Record Inserted Successfully ${txtNm.Text});</script>");
                        Label4.Text = "Record deleted";
                    }
                    else
                    {
                        Label4.Text = "Record not deleted";
                        //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                Label4.Text = ex.Message;

            }
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoll.Text != "" && txtNm.Text != "" && txtAdd.Text != "")
                {
                    cmd = new SqlCommand("Update custData set cname=@Nm, cadd=@add where cid=@rN", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@rN", txtRoll.Text);
                    cmd.Parameters.AddWithValue("@Nm", txtNm.Text);
                    cmd.Parameters.AddWithValue("@Add", txtAdd.Text);

                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        //Response.Write("<script>alert(`Record Inserted Successfully ${txtNm.Text});</script>");
                        Label4.Text = "Record Updated";
                    }
                    else
                    {
                        Label4.Text = "Record not Updated";
                        //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                Label4.Text = ex.Message;

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    cmd = new SqlCommand("Select * from custData where cid=@rN", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@rN", txtSearch.Text);

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Response.Write("<script>alert('Record Found Successfully');</script>");
                        txtRoll.Text = dr["cid"].ToString();
                        txtNm.Text = dr["cname"].ToString();
                        txtAdd.Text = dr["cadd"].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('Record Not Found !!!');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert(`Record Not Inserted Successfully ${txtNm.Text}`);</script>");
                Label4.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            
            }
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
                dv.Sort = txtSearch.Text; // "name ASC"
                // dv.RowFilter = txtSearch.Text; // "address = 'Ratnagiri'";
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Exception! ' + ex.Message);</script>");
            }
        }
    }
}

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
