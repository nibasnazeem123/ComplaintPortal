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

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = prodba.viewQueryAdmin();
            GridView1.DataBind();
        }

        protected void gridView_update(object sender, GridViewUpdateEventArgs e)
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string txt = TextBox1.Text;

                //(TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            prodba.queID = id.ToString();
            prodba.replyuser = txt.Text;
            int i = prodba.updatequeryreply();
            if (i == 1)
            {
                Response.Write("<script language=javascript>alert('PRODUCT ADDED');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
            GridView1.EditIndex = -1;
            GridView1.DataSource = prodba.viewQueryAdmin();
            GridView1.DataBind();
        }


    }
}