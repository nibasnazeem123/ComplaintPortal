using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintPortal.BAL
{
   
        public class BAL
        {
            DAL.DAL da = new DAL.DAL();
            private string USERNAME; 
            private string USERID; 
            private string USERSTATUS; 
            private string USERPHONE; 
            private string USEREMAIL;
            private string PASSWORD;
            private string id;

            public string UserName
            { 
                
                get { return USERNAME; } 
            
                set { USERNAME = value; }
            }

            public string PassWord
            {

                get { return PASSWORD; }

                set { PASSWORD = value; }
            }

        public string UserId
            {
                get { return USERID; }

                set { USERID = value; }
            }
            public string UserStatus 
            { 
                get { return USERSTATUS; }
                
                set { USERSTATUS = value; }
            }
            public string UserEmail
            {
                get { return USEREMAIL; }

                set { USEREMAIL = value; }
            }
            public string UserPhone
            {
                get { return USERPHONE; }

                set { USERPHONE = value; }
            }

            public string LID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
            public int RegInsert() 
            { 
            return da.DataInsert(this); 
            }

            public int approveUser()
            {
                return da.userApprove(this);
            }

            public DataTable viewUser()
            {
            return da.UserView();
            }


        public DataTable login()
            {
                return da.logcheck(this);
            }
    }
    }

