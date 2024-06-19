``` C#
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
    public partial class WFConnectedArch : System.Web.UI.Page
    {
        static string conStr = ConfigurationManager.ConnectionStrings["StudConnString"].ToString();
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        public void showData()
        {
            try
            {
                cmd = new SqlCommand("Select * from StdInfo", conn);
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
                    cmd = new SqlCommand("Insert into StdInfo(rollNo, name, address) values (@rN, @Nm, @Add)", conn);
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
                    cmd = new SqlCommand("Delete StdInfo where rollNo=@rN", conn);
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
                    cmd = new SqlCommand("Update StdInfo set name=@Nm, address=@add where rollNo=@rN", conn);
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
                    cmd = new SqlCommand("Select * from StdInfo where rollNo=@rN", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@rN", txtSearch.Text);

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Response.Write("<script>alert('Record Found Successfully');</script>");
                        txtRoll.Text = dr["rollNo"].ToString();
                        txtNm.Text = dr["name"].ToString();
                        txtAdd.Text = dr["address"].ToString();
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

        protected void btnSPADD_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtRoll.Text != "" && txtNm.Text != "" && txtAdd.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertData";

                    cmd.Parameters.Add(new SqlParameter("@RollNo", SqlDbType.SmallInt)).Value = Convert.ToInt16(txtRoll.Text);


                    cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar)).Value = txtNm.Text;

                    cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar)).Value = txtAdd.Text;



                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        Label4.Text = "Record Inserted";
                    }
                    else
                    {
                        Label4.Text = "Failed!!";
                    }


                }
                else
                {
                    Label4.Text = "Please Enter Data!";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();
                showData();

            }
        }

        protected void btnSSP_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSearch.Text != "")
                {
                    cmd = new SqlCommand();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "selectData";


                    cmd.Parameters.Add(new SqlParameter("@RollNo", SqlDbType.SmallInt)).Value =
                        Convert.ToInt16(txtSearch.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        Label4.Text = "Got The Records ";


                        while (dr.Read())
                        {


                            txtRoll.Text = dr[0].ToString();
                            txtNm.Text = dr[1].ToString();
                            txtAdd.Text = dr[2].ToString();
                        }
                    }
                    else
                    {
                        Label4.Text = ("Records Not Found");
                    }
                }
                else
                {
                    Label4.Text = "Please Enter Data!";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "Exception" + ex.Message;
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
```

``` Aspx
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFConnectedArch.aspx.cs" Inherits="PracticalNo3.WFConnectedArch" %>

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
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
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
            <asp:Button ID="btnSPADD" runat="server" Text="Add using Stored Procedure" OnClick="btnSPADD_Click" />
&nbsp;
            <asp:Button ID="btnSSP" runat="server" Text="Search using Stored Procedure" OnClick="btnSSP_Click" />
        </div>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

```

``` Config
<?xml version="1.0" encoding="utf-8"?>
<!--
  For more information on how to configure your ASP.NET application, please visit
  https://go.microsoft.com/fwlink/?LinkId=169433
  -->
<configuration>
  <connectionStrings>
      <add name="StudConnString" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudDB.mdf;Integrated Security=True;Connect Timeout=30"
          providerName="System.Data.SqlClient" />
      <add name="StudDBEntities" connectionString="metadata=res://*/StudModel.csdl|res://*/StudModel.ssdl|res://*/StudModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\StudDB.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework&quot;"
          providerName="System.Data.EntityClient" />
      <add name="ConnectionString" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework"
          providerName="System.Data.SqlClient" />
  </connectionStrings>
  <system.web>
    <compilation debug="true" targetFramework="4.7.2" />
    <httpRuntime targetFramework="4.7.2" />
  </system.web>
  <system.codedom>
    <compilers>
      <compiler language="c#;cs;csharp" extension=".cs" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701" />
      <compiler language="vb;vbs;visualbasic;vbscript" extension=".vb" type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" warningLevel="4" compilerOptions="/langversion:default /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+" />
    </compilers>
  </system.codedom>
</configuration>
```

``` Stored SQL Query
create procedure insertData(@rN int, @Nm varchar(50), @Add varchar(50))
as
begin 
insert into StdInfo values(@rN, @Nm, @Add)
set nocount on;
end


CREATE PROCEDURE selectData
(@Rollno int)
AS
BEGIN
SELECT * FROM StdInfo WHERE rollNo=@Rollno;
SET NOCOUNT ON;
END
```
