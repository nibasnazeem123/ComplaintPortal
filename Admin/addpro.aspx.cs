using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.Admin
{
    public partial class addpro1 : System.Web.UI.Page
    {
        BAL.prodBAL obj = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = obj.viewProduct(); //taking val from tbl
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.ProdName = product.Text;
            int i = obj.ProdInsert();
            if (i == 1)
            {
                Response.Write("<script language=javascript>alert('PRODUCT ADDED');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex; //set edit index
            GridView1.DataSource = obj.viewProduct(); //taking val from tbl
            GridView1.DataBind();//bind to gridview
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; //set edit index
            GridView1.DataSource = obj.viewProduct(); //taking val from tbl
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            obj.ID = id;
            obj.Name = txt.Text;
            int i = obj.updateProduct();
            GridView1.EditIndex = -1;
            GridView1.DataSource = obj.viewProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            obj.ID = Id;
            int i = obj.deleteProduct();
            GridView1.DataSource = obj.viewProduct();
            GridView1.DataBind();
        }
    }
}