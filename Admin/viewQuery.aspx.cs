using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ComplaintPortal.Admin
{
    public partial class viewQuery : System.Web.UI.Page
    {
        BAL.prodBAL prodba = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = prodba.viewQueryAdmin();
            GridView1.DataBind();
        }

        


    }
}