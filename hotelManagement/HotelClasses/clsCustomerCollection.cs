using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            int Index = 0;
            //var to stire the record count
            int RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Customer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank customer
                clsCustomer theCustomer = new clsCustomer();
                //read in the fields from the current record
                theCustomer.customerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                theCustomer.dateOfbirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateOfbirth"]);
                theCustomer.email = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                theCustomer.firstName = Convert.ToString(DB.DataTable.Rows[Index]["firstName"]);
                theCustomer.lastName = Convert.ToString(DB.DataTable.Rows[Index]["lastName"]);
                theCustomer.phoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["phoneNumber"]);
                //add the record to the private data member
                mCustomerList.Add(theCustomer);
                //point to the next record
                Index++;
            }
            
        }
        //private data member
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer 
        {
            get 
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        //public property for customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return private data
                return mCustomerList;
            }
            set
            {
                //set private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
               //later
            }
        }

        //add method
        public int Add()
        {
            //adds a new record to the database based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@dob", mThisCustomer.dateOfbirth);
            DB.AddParameter("@email", mThisCustomer.email);
            DB.AddParameter("@firstName", mThisCustomer.firstName);
            DB.AddParameter("@lastName", mThisCustomer.lastName);
            DB.AddParameter("@phonenumber", mThisCustomer.phoneNumber);
            //execute the query returning the primary key value
            return DB.Execute("sproc_Customer_Insert");
        }
    }
}