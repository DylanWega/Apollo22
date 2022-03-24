﻿using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_Customer_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);

          
            
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


        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramteters for the store procedure
            DB.AddParameter("@customerID", mThisCustomer.customerID);
            //execute the stored procedure
            DB.Execute("sproc_Customer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the paramteters for the store procedure
            DB.AddParameter("@customerID", mThisCustomer.customerID);
            DB.AddParameter("@dateOfbirth", mThisCustomer.dateOfbirth);
            DB.AddParameter("@email", mThisCustomer.email);
            DB.AddParameter("@firstName", mThisCustomer.firstName);
            DB.AddParameter("@lastName", mThisCustomer.lastName);
            DB.AddParameter("@phoneNumber", mThisCustomer.phoneNumber);
            //execute stored procedure
            DB.Execute("sproc_Customer_Update");
        }

        public void ReportByLastName(string lastName)
        {
            //filter the records based on a full or partial last name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramteters for the store procedure
            DB.AddParameter("@lastName", lastName);            
            //execute stored procedure
            DB.Execute("sproc_Customer_FilterByLastName");
            //populate the array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the date
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count pf records
            RecordCount = DB.Count;
            //declear the privaye array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while(Index < RecordCount)
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
    }
}