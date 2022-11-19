using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace ComplaintPortal.DAL
{
        public class DAL
        {
            public SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            public DAL()
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
            public int DataInsert(BAL.BAL obj)
            {
                string qry = "insert into registration values('" + obj.UserName + "','" + obj.UserPhone  + "','" + obj.UserEmail + "','" + obj.UserStatus + "');select @@IDENTITY";
                SqlCommand cmd = new SqlCommand(qry, GetCon());
                object ob = cmd.ExecuteScalar();
                string qry1 = "insert into login values('" + obj.UserName + "','" + obj.PassWord + "','user','" + obj.UserStatus + "','"+ob+"')";
                SqlCommand cmd1 = new SqlCommand(qry1, GetCon());
                return cmd1.ExecuteNonQuery();

            }
            
            public DataTable logcheck(BAL.BAL obj)
                {
                    string qry= "SELECT * FROM login WHERE uname='"+obj.UserName+ "'AND upass='" + obj.PassWord + "'";
                    SqlCommand cmd = new SqlCommand(qry, GetCon());
                    SqlDataAdapter dta = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dta.Fill(dt);
                    return dt;    
            }

            public DataTable UserView()
            {
                string s = "select * from login where status='0'";
                SqlCommand cmd = new SqlCommand(s, GetCon());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;



            }
            public int userApprove(BAL.BAL obj)
            {
                string s = "Update login set status = 1 where LID =" + obj.LID;
                SqlCommand cmd = new SqlCommand(s, GetCon());
                return cmd.ExecuteNonQuery();
            }

    }
    }

