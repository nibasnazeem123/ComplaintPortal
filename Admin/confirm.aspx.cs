using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.Admin
{
    public partial class confirm : System.Web.UI.Page
    {
        BAL.BAL ba = new BAL.BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ba.viewUser();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            ba.LID = id.ToString();
            int i = ba.approveUser();
            GridView1.EditIndex = -1;
            GridView1.DataSource = ba.viewUser();
            GridView1.DataBind();
        }

    }
}