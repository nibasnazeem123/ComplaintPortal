using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintPortal.DAL
{
    
    public class prodDAL
    {
        //public int UID = Session["UID"];
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public prodDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        
         public int ProdInsert(BAL.prodBAL obj)
        {
            
            string qry1 = "insert into product values('" + obj.ProdName +"')";
            SqlCommand cmd1 = new SqlCommand(qry1, GetCon());
            return cmd1.ExecuteNonQuery();

        }

        public int Complaints(BAL.prodBAL obj)
        {
            string qry1 = "insert into complaint(prodid,complaint,status,date,UID) values('" + obj.ProdID + "','" + obj.Complaint + "',0,GETDATE(),'" + obj.UID + "')";
            SqlCommand cmd1 = new SqlCommand(qry1, GetCon());
            return cmd1.ExecuteNonQuery();
        }

        public int ProdQueries(BAL.prodBAL obj)
        {
            string qry1 = "insert into querys(prodid,query,status,date,UID) values('" + obj.ProdID + "','" + obj.Querys + "',0,GETDATE(),'"+obj.UID+"')";
            SqlCommand cmd1 = new SqlCommand(qry1, GetCon());
            return cmd1.ExecuteNonQuery();
        }
        public DataTable viewuserquery(BAL.prodBAL obj)
        {
            string s = "SELECT login.uname, product.prodname, querys.date, querys.query, querys.reply, querys.status FROM querys INNER JOIN product ON querys.prodid = product.prodid INNER JOIN login ON querys.UID = login.UID where login.UID='" + obj.UID + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int updatereply(BAL.prodBAL obj)
        {
            string s = "update querys set reply='" + obj.replyuser + "' where queid='" + obj.queID + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }
        public int updatecompreply(BAL.prodBAL obj)
        {
            string s = "update complaint set reply='" + obj.creplyuser + "' where compid='" + obj.comid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }


        public DataTable viewusercomplaint(BAL.prodBAL obj)
        {
            string s = "SELECT login.uname, product.prodname, complaint.date, complaint.complaint, complaint.reply, complaint.status FROM complaint INNER JOIN product ON complaint.prodid = product.prodid INNER JOIN login ON complaint.UID = login.UID where login.UID='" + obj.UID + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable viewAdmincomplaint()
        {
            string s = "SELECT complaint.compid,login.uname, product.prodname, complaint.date, complaint.complaint, complaint.reply, complaint.status FROM complaint INNER JOIN product ON complaint.prodid = product.prodid INNER JOIN login ON complaint.UID = login.UID ";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable viewAdminquery()
        {
            string s = "SELECT querys.queid,login.uname, product.prodname, querys.date, querys.query, querys.reply, querys.status FROM querys INNER JOIN product ON querys.prodid = product.prodid INNER JOIN login ON querys.UID = login.UID ";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}