using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.Admin
{
    public partial class queryreply : System.Web.UI.Page
    {
        BAL.prodBAL prodba = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int queid = Convert.ToInt32(Request.QueryString["ID"]);
            prodba.replyuser = reply.Text;
            prodba.queID = queid;
            int i = prodba.updatequeryreply();
            if (i == 1)
            {
                Response.Write("<script language=javascript>alert('Replyed');</script>");
                Response.Redirect("viewQuery.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
                Response.Redirect("viewQuery.aspx");
            }

        }
    }
}