using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.user
{
    public partial class UserViewComplaint : System.Web.UI.Page
    {
        BAL.prodBAL prodba = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            prodba.UID = (string)Session["UID"];
            GridView1.DataSource = prodba.viewComplaint();
            GridView1.DataBind();
        }
    }
}