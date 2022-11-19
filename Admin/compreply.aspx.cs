using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.Admin
{
    public partial class compreply : System.Web.UI.Page
    {
        BAL.prodBAL prodba = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(Request.QueryString["ID"]);
            prodba.creplyuser = DropDownList1.SelectedItem.Value;
            prodba.comid = cid;
            int i = prodba.updatecomplaintreply();
            if (i == 1)
            {
                Response.Write("<script language=javascript>alert('Updated');</script>");
                Response.Redirect("viewComp.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
                Response.Redirect("viewComp.aspx");
            }
        }
    }
}