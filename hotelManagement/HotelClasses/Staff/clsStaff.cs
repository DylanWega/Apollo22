using System;

namespace HotelClasses

{


    public class clsStaff
    {

        //private data members for all the attributes
        private int mEmployeeID;
        private int mstockid;
        private int msupplierid;
        private string mAddress;
        private string mDateofbirth;
        private string mEmail;
        private string mFirstname;
        private string mgender;
        private string mLastname;
        private string mpassword;
        private string mposition;
        private string mphoneno;



        //CREATE TABLE[dbo].[tblStaff] (

        //   [EmployeeID]  INT NOT NULL,
        //    [stockid]     INT NULL,
        //    [supplierid]  INT          NULL,
        //   [Address]     VARCHAR (50) NULL,
        //    [Dateofbirth] DATE NULL,
        //    [Email]       VARCHAR (50) NULL,
        //    [Firstname]   VARCHAR (50) NULL,
        //    [gender]      VARCHAR (50) NULL,
        //    [Lastname]    VARCHAR (50) NULL,
        //    [password]    VARCHAR (50) NULL,
        //    [phoneno]     INT NULL,
        //    [position]    VARCHAR (50) NULL,



        public int EmployeeID
        {
            get
            {
                return mEmployeeID;
            }
            set
            {
                mEmployeeID = value;
            }
        }
        public int stockid
        {
            get
            {
                return mstockid;
            }
            set
            {
                mstockid = value;
            }
        }
        public int supplierid
        {
            get
            {
                return msupplierid;
            }
            set
            {
                msupplierid = value;
            }
        }


        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string Dateofbirth
        {
            get
            {
                return mDateofbirth;
            }
            set
            {
                mDateofbirth = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Firstname
        {
            get
            {
                return mFirstname;
            }
            set
            {
                mFirstname = value;
            }
        }
        public string gender
        {
            get
            {
                return mgender;
            }
            set
            {
                mgender = value;
            }
        }



        public string Lastname
        {
            get
            {
                return mLastname;
            }
            set
            {
                mLastname = value;
            }
        }
        public string password
        {
            get
            {
                return mpassword;
            }
            set
            {
                mpassword = value;
            }
        }
        public string phoneno
        {
            get
            {
                return mphoneno;
            }
            set
            {
                mphoneno = value;
            }
        }

        public string position
        {
            get
            {
                return mposition;
            }
            set
            {
                mposition = value;
            }
        }
        public bool Find(int EmployeeID)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the EmployeeID to search for it
            DB.AddParameter("@EmployeeID", EmployeeID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByEmployeeID");
            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mEmployeeID = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeID"]);
                mstockid = Convert.ToInt32(DB.DataTable.Rows[0]["stockid"]);
                msupplierid = Convert.ToInt32(DB.DataTable.Rows[0]["supplierid"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateofbirth = Convert.ToString(DB.DataTable.Rows[0]["Dateofbirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstname = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mgender = Convert.ToString(DB.DataTable.Rows[0]["gender"]);
                mLastname = Convert.ToString(DB.DataTable.Rows[0]["Lastname"]);
                mpassword = Convert.ToString(DB.DataTable.Rows[0]["password"]);
                mposition = Convert.ToString(DB.DataTable.Rows[0]["position"]);
                mphoneno = Convert.ToString(DB.DataTable.Rows[0]["phoneno"]);


                //return everyting worked OK
                return true;
            }
            //if no records was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }
    }
}