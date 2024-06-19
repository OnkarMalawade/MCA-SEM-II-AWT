# Practical No.3
<br/>
<u><i>Datasource and the Connection Grid To be Separated in the Files</i></u>

## Data Bound Control / Data Binding Control (Grid View) 
<br/>

> <a href ="#">Data Source and Data Bound Control </a>
<br/>

> # ADO.net :Active X Data Objects is rich set of classes internet <br/>

> "using" is Keyword to import data <br/>

> 1. <b>Connected Archietecture:</b> Stay Connected while Accessing data with Connection string and retrive data from it. It contain SqlCommand,SqlDataReader,SqlConnection. SqlDataReader contain only single data and it Faster performance<br/>

> 2. <b>Disconnected Arichietecture:</b> When required you connected to the database. It contain temporary database work on the temporary db after it update to the Main db. It contain SqlConnection, DataSet, SqlDataAdapter,SqlCommandBuilder. DataSet is Slower and contain multiple type data. SqlDataAdapter CRUD operation work on it. DataSet allow multiple table takes time. SqlCommondBuilder is used to build Command ar requirements, It will Automatically create Sql Query. fill() retrive data from Main to temporary table, update() add updated data from temporay data to main data.<br/>

<img src="ADO.png">
</img>

class change with files name and connection file.

> SqlConnection: to connect with the DB using Open() method and Close().<br/>
> SqlConnection conn;<br/>
> conn.Open(); <br/>

> SqlCommand: Execute use various interactions based on the requirements <br/>
> 1. ExecuteScaler(): Single cell operations to be perform by using it.(e.g. Select, Update, sum(), min(), max() )<br/>
> 2. ExecuteReader(): When it executes returns an Instance of <b>DataReader</b> Class.<br/>
> 3. ExecuteNonQuery(): It returns (DML integer) how many data or rows are affected.(Update, Insert).<br/>
> 4. DataReader Object: You can Read Only the Data. Results of Connected Architecture. <b>It display Single Table inside of it</b>. Faster Access, Manually Control.We Can't create relation in data reader.It Can't modify data.

``` C#
  protected void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt);
               // dv.Sort = TextBox4.Text; // name ASC
                dv.RowFilter = TextBox4.Text; //"address =Mumbai"
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }catch(Exception ex)
            {
                Label5.Text = "Exception" + ex.Message;
               
            }
        }

        protected void btnAddSP_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtRollno.Text != "" && txtName.Text != "" && txtAddress.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertData";

                    cmd.Parameters.Add(new SqlParameter("@RollNo", SqlDbType.SmallInt)).Value =
                        Convert.ToInt16(txtRollno.Text);


                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar)).Value =
                        txtName.Text;

                    cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar)).Value =
                        txtAddress.Text;



                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        TextBox4.Text = "Record Inserted";
                    }
                    else
                    {
                        TextBox4.Text = "Failed!!";
                    }


                }
                else
                {
                    Label5.Text = "Please Enter Data!";
                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                showData();

            }

        }

        protected void btnSrcSP_Click(object sender, EventArgs e)
        {

            try
            {

                if (TextBox4.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "srcData";


                    cmd.Parameters.Add(new SqlParameter("@RollNo", SqlDbType.SmallInt)).Value =
                        Convert.ToInt16(TextBox4.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        Label5.Text = "Got The Records ";


                        while (dr.Read())
                        {


                            txtRollno.Text = dr[0].ToString();
                            txtName.Text = dr[1].ToString();
                            txtAddress.Text = dr[2].ToString();
                        }
                    }
                    else
                    {
                        Label5.Text = ("Records Not Found");
                    }
                }
                else
                {
                    Label5.Text = "Please Enter Data!";
                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();

            }
        }

        protected void btnDltSP_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtRollno.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "deleteData";


                    cmd.Parameters.Add(new SqlParameter("@RollNo", SqlDbType.SmallInt)).Value =
                        Convert.ToInt16(txtRollno.Text);


                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        TextBox4.Text = "Record Deleted";
                    }
                    else
                    {
                        TextBox4.Text = "Failed!!";
                    }


                }
                else
                {
                    Label5.Text = "Please Enter Data!";
                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                showData();

            }
        }

        protected void btnUpdateSP_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtRollno.Text != "" && txtName.Text != "" && txtAddress.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "updateData";

                    cmd.Parameters.Add(new SqlParameter("@RollNo", SqlDbType.SmallInt)).Value =
                        Convert.ToInt16(txtRollno.Text);


                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar)).Value =
                        txtName.Text;

                    cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar)).Value =
                        txtAddress.Text;

                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        TextBox4.Text = "Record Updated";
                    }
                    else
                    {
                        TextBox4.Text = "Failed!!";
                    }


                }
                else
                {
                    Label5.Text = "Please Enter Data!";
                }
            }
            catch (Exception ex)
            {
                Label5.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                showData();

            }

        }
```
# SQL Stored Procedures Below:

``` Sql Stored Procedure
#1
CREATE PROCEDURE insertData
(@RollNo int,
@Name varchar(50),
@Address varchar(50))
AS
begin 
insert into stud values(@RollNo,@Name,@Address)
SET NOCOUNT ON;
end

#2
CREATE PROCEDURE deleteData
(@RollNo int)
AS
begin 
DELETE stud WHERE rollno=@RollNo
SET NOCOUNT ON;
end

#3
CREATE PROCEDURE selectData
(@Rollno int)
AS
BEGIN
SELECT * FROM stud WHERE rollno=@Rollno;
SET NOCOUNT ON;
END
GO

#4
CREATE PROCEDURE updateData
(@RollNo int,
@Name varchar(50),
@Address varchar(50))
AS
begin 
UPDATE stud SET name=@Name,address=@Address WHERE rollno=@RollNo
SET NOCOUNT ON;
end
```

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
