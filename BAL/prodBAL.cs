using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ComplaintPortal.BAL
{
    public class prodBAL
    {
        DAL.prodDAL pda = new DAL.prodDAL();
        
        private string PNAME;
        private string comp;
        private int prodid;
        private string query;
        private string proUID;
        private string reply;
        private string queid;

        public string replyuser
        {
            get { return reply; }
            set { reply = value; }
        }

        public string queID
        {

            get { return queid; }

            set { queid = value; }
        }
        public string UID
        {

            get { return proUID; }

            set { proUID = value; }
        }

        public string ProdName
        {

            get { return PNAME; }

            set { PNAME = value; }
        }

        public int ProdID
        {

            get { return prodid; }

            set { prodid = value; }
        }
        public string Complaint
        {
            get { return comp; }

            set { comp = value; }
        }

        public string Querys
        {
            get { return query; }

            set { query = value; }
        }

        public int ProdInsert()
        {
            return pda.ProdInsert(this);
       }

        public int ProdComp()
        {
            return pda.Complaints(this);
        }
        public System.Data.DataTable viewQuery()
        {
            return pda.viewuserquery(this);
        }
        
        public System.Data.DataTable viewComplaint()
        {
            return pda.viewusercomplaint(this);
        }

        public System.Data.DataTable viewQueryAdmin()
        {
            return pda.viewAdminquery();
        }

        public DataTable viewComplaintAdmin()
        {
            return pda.viewAdmincomplaint();
        }
        public int Prodquery()
        {
            return pda.ProdQueries(this);
        }
        
        public int updatequeryreply()
        {
            return pda.updatereply(this);
        }
    }
}