using System.Collections.Generic;
using System;

namespace HotelClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member ThisStaff
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public clsStaff ThisStaff
        {
            //return the private data
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //dont worry :)
            }
        }

        public clsStaffCollection()
        {

            //objcet for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);

        }


        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            int Index = 0;
            //var to store the record count 
            int RecordsCount = 0;
            //get the count of records
            RecordsCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordsCount)
            {

                //create a blank Staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current records
                AStaff.EmployeeID = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeID"]);
                AStaff.stockid = Convert.ToInt32(DB.DataTable.Rows[Index]["stockid"]);
                AStaff.supplierid = Convert.ToInt32(DB.DataTable.Rows[Index]["supplierid"]);
                AStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AStaff.Dateofbirth = Convert.ToString(DB.DataTable.Rows[Index]["Dateofbirth"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Firstname = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
                AStaff.gender = Convert.ToString(DB.DataTable.Rows[Index]["gender"]);
                AStaff.Lastname = Convert.ToString(DB.DataTable.Rows[Index]["Lastname"]);
                AStaff.password = Convert.ToString(DB.DataTable.Rows[Index]["password"]);
                AStaff.phoneno = Convert.ToString(DB.DataTable.Rows[Index]["phoneno"]);
                AStaff.position = Convert.ToString(DB.DataTable.Rows[Index]["position"]);


                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the record
                Index++;
            }
        }

        public int Add()
        {

            //adds a new record to the DB based on the value of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@stockid", mThisStaff.stockid);
            DB.AddParameter("@supplierid", mThisStaff.supplierid);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Dateofbirth", mThisStaff.Dateofbirth);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Firstname", mThisStaff.Firstname);
            DB.AddParameter("@gender", mThisStaff.gender);
            DB.AddParameter("@Lastname", mThisStaff.Lastname);
            DB.AddParameter("@password", mThisStaff.password);
            DB.AddParameter("@phoneno", mThisStaff.phoneno);
            DB.AddParameter("@position", mThisStaff.position);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //delete the record pointed by the ThisStaff
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeID", mThisStaff.EmployeeID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the value of the ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeID", mThisStaff.EmployeeID);
            DB.AddParameter("@stockid", mThisStaff.stockid);
            DB.AddParameter("@supplierid", mThisStaff.supplierid);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Dateofbirth", mThisStaff.Dateofbirth);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Firstname", mThisStaff.Firstname);
            DB.AddParameter("@gender", mThisStaff.gender);
            DB.AddParameter("@Lastname", mThisStaff.Lastname);
            DB.AddParameter("@password", mThisStaff.password);
            DB.AddParameter("@phoneno", mThisStaff.phoneno);
            DB.AddParameter("@position", mThisStaff.position);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");


        }

        public void ReportByAddress(string Address)
        {
            //filter the records based on a full or partial title
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //send the title parameter to the DB
            DB.AddParameter("@Address", Address);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }


    }
}
