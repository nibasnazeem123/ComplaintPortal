﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintPortal.user
{
    public partial class querys : System.Web.UI.Page
    {
        BAL.prodBAL prodba = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            prodba.Querys = Request.Form["text1"];
            prodba.UID = (string)Session["UID"];
            prodba.ProdID = int.Parse(drop1.SelectedItem.Value);
            int i = prodba.Prodquery();
            if (i == 1)
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