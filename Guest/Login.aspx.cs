using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.BAL ba = new BAL.BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            ba.UserName = user.Text;
            ba.PassWord = pass.Text;
            DataTable dt = ba.login();
            if (dt.Rows.Count > 0)
            {
                Session["UID"] = dt.Rows[0][5].ToString().Trim();
               
               

                if (dt.Rows[0][3].ToString().Trim()=="admin")
                    { 

                    Response.Write("<script language=javascript>alert('Admin');</script>");
                    Response.Redirect("../Admin/adminhome.aspx");
                }
                
                Response.Write("<script language=javascript>alert('User');</script>");
                Response.Redirect("../User/UserHome.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
        }
    }
}