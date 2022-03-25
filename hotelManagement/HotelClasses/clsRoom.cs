using HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelClasses


{

    public class clsRoom
    {
        //private data maember for the Customer User Name property
        
        private string mdescription;
        private Decimal mprice;
        private Int32 mroomNo;
        private string mtype;
        private string mavailability;

      
        public string availability
        {
            get
            {
                //this line of code sends data out of the property
                return mavailability;
            }

            set
            {
                //this line of code allows data into the property
                mavailability = value;
            }
        }
        public string description
        {
            get
            {
                //this line of code sends data out of the property
                return mdescription;
            }

            set
            {
                //this line of code allows data into the property
                mdescription = value;
            }
        }
        public Decimal price
        {
            get
            {
                //this line of code sends data out of the property
                return mprice;
            }

            set
            {
                //this line of code allows data into the property
                mprice = value;
            }
        }
        public Int32 roomNo
        {
            get
            {
                //this line of code sends data out of the property
                return mroomNo;
            }

            set
            {
                //this line of code allows data into the property
                mroomNo = value;
            }
        }

        public string type
        {
            get
            {
                //this line of code sends data out of the property
                return mtype;
            }

            set
            {
                //this line of code allows data into the property
                mtype = value;
            }
        }
       
      public bool Find(int roomNo)
        {
            // create a instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the furniture id to search for
            DB.AddParameter("@roomNo", roomNo);
            // execute the stored procedure
            DB.Execute("sproc_room_FilterByroomNo");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                // copy the data from the database to the private data members
                mavailability = Convert.ToString(DB.DataTable.Rows[0]["availability"]);
                mdescription = Convert.ToString(DB.DataTable.Rows[0]["description"]);
                mprice = Convert.ToDecimal(DB.DataTable.Rows[0]["price"]);
                mroomNo = Convert.ToInt32(DB.DataTable.Rows[0]["roomNo"]);
                mtype = Convert.ToString(DB.DataTable.Rows[0]["type"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problems
                return false;
            }
        }
      
    }
}
