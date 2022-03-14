using System.Collections.Generic;

namespace HotelClasses
{
    public class clsCustomerCollection
    {
      
        public clsCustomer ThisCustomer { get; set; }

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

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
    }
}