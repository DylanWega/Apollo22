using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsRoomCollection
    {
        //constructor for the class
        public clsRoomCollection()
        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_room_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);



        }
        //private data member
        clsRoom mThisroom = new clsRoom();
        public clsRoom Thisroom
        {
            get
            {
                //return the private data
                return mThisroom;
            }
            set
            {
                //set the private data
                mThisroom = value;
            }
        }
        List<clsRoom> mroomList = new List<clsRoom>();

        //public property for room list
        public List<clsRoom> roomList
        {
            get
            {
                //return private data
                return mroomList;
            }
            set
            {
                //set private data
                mroomList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mroomList.Count;
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
            DB.AddParameter("@availability", mThisroom.availability);
            DB.AddParameter("@description", mThisroom.description);
            DB.AddParameter("@price", mThisroom.price);
            DB.AddParameter("@type", mThisroom.type);
            DB.AddParameter("@roomNo", mThisroom.roomNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_room_Insert");
        }


        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramteters for the store procedure
            DB.AddParameter("@roomNo", mThisroom.roomNo);
            //execute the stored procedure
            DB.Execute("sproc_room_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the paramteters for the store procedure
            DB.AddParameter("@roomNo", mThisroom.roomNo);
            DB.AddParameter("@availability", mThisroom.availability);
            DB.AddParameter("@description", mThisroom.description);
            DB.AddParameter("@price", mThisroom.price);
            DB.AddParameter("@type", mThisroom.type);
            //execute stored procedure
            DB.Execute("sproc_room_Update");
        }

        public void ReportBydescription(string description)
        {
            //filter the records based on a full or partial last name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramteters for the store procedure
            DB.AddParameter("@description", description);
            //execute stored procedure
            DB.Execute("sproc_room_FilterBydescription");
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
            mroomList = new List<clsRoom>();
            //while there are records to process
            while (Index < RecordCount)
            {

                //create blank customer
                clsRoom theroom = new clsRoom();
                //read in the fields from the current record
                theroom.roomNo = Convert.ToInt32(DB.DataTable.Rows[Index]["roomNo"]);
                theroom.availability = Convert.ToString(DB.DataTable.Rows[Index]["availability"]);
                theroom.description = Convert.ToString(DB.DataTable.Rows[Index]["description"]);
                theroom.price = Convert.ToDecimal(DB.DataTable.Rows[Index]["price"]);
                theroom.type = Convert.ToString(DB.DataTable.Rows[Index]["type"]);
                //add the record to the private data member
                mroomList.Add(theroom);
                //point to the next record
                Index++;
            }
        }
    }
}

