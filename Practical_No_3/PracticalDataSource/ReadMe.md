# Hello Data GridView and Connection to be Separated
``` c#
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFConP3Q1.aspx.cs" Inherits="CustomerAPP.WFConP3Q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <div>
            Customer Details<br />
            <asp:Label ID="Label1" runat="server" Text="Enter Cust ID: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Name: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
           
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
           
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
            <br />
        </div>
    </form>
    </center>
</body>
</html>

```

``` c# aspx.cs
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerAPP
{
    public partial class WFConP3Q1 : System.Web.UI.Page
    {
        static string constr = ConfigurationManager.ConnectionStrings["connCust"].ToString();

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        public void showData()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM cust_info", conn);
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
                Label5.Text = "Exception" + ex.Message;

            }
            finally
            {
                conn.Close();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);
            showData();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO cust_info VALUES(@id,@nm,@add)", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@nm", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@add", TextBox3.Text);

                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        Label5.Text = "Record Inserted";

                    }
                    else
                    {
                        Label5.Text = "Failed!!";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
                {
                    cmd = new SqlCommand("UPDATE cust_info SET cname=@nm,cadd=@add WHERE cid=@id", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@nm", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@add", TextBox3.Text);

                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        Label5.Text = "Record Updated";
                    }
                    else
                    {
                        Label5.Text = "Failed!!";
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1.Text != "")
                {
                    cmd = new SqlCommand("DELETE cust_info WHERE cid=@id", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);


                    int r = cmd.ExecuteNonQuery();

                    if (r != 0)
                    {
                        Label5.Text = "Record Deleted";
                    }
                    else
                    {
                       Label5.Text = "Failed!!";
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox1.Text != "")
                {
                    cmd = new SqlCommand("SELECT * FROM cust_info WHERE cid=@id ", conn);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Label5.Text = "Records Found Succesfully";

                        TextBox1.Text = dr[0].ToString();
                        TextBox2.Text = dr[1].ToString();
                        TextBox3.Text = dr[2].ToString();
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
    }
}
```

``` database
<?xml version="1.0" encoding="utf-8"?>
<!--
  For more information on how to configure your ASP.NET application, please visit
  https://go.microsoft.com/fwlink/?LinkId=169433
  -->
<configuration>
  <connectionStrings>
    <add name="studConnString" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\studDB.mdf;Integrated Security=True;Connect Timeout=30"
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
