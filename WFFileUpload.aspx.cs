using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalNo2All
{
    public partial class WFFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (FileUpload1.HasFile)
            {
                try
                {
                    sb.AppendFormat(" Uploading File: {0} " , FileUpload1.FileName);
                    // Saving String
                    string filename = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/") + filename);
                    //Showing File Information
                    sb.AppendFormat("<br/> Save As: {0} ", FileUpload1.PostedFile.FileName);
                    sb.AppendFormat("<br/> Content Type: {0} ", FileUpload1.PostedFile.ContentType);
                    sb.AppendFormat("<br/> File Length: {0} ", FileUpload1.PostedFile.ContentLength);
                }
                catch(Exception ex)
                {
                    sb.Append("<br/> Error: <br/>");
                    sb.AppendFormat("Unable to Save File: {0} ", ex.Message);
                }
                lblMessage.Text = sb.ToString();
            }
            else
            {
                lblMessage.Text = "Sorry You Haven't Select any File";
            }   
        }
    }
}