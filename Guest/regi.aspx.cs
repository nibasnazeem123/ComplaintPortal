using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.Guest
{
    public partial class regi : System.Web.UI.Page
    {
        BAL.BAL ba = new BAL.BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ba.UserName = name.Text;
            ba.UserPhone = phone.Text;
            ba.UserEmail = email.Text;
            ba.UserStatus = "0";
            ba.PassWord = pass.Text;
            int i = ba.RegInsert();
           // int n = ba.logInsert();
            if(i==1)
            {
                Response.Write("<script language=javascript>alert('SUCESS');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
        }
    }
}