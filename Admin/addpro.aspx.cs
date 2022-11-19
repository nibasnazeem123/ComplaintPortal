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
    }
}