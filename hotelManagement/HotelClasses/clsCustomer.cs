using System;

namespace HotelClasses
{
    public class clsCustomer
    {
        //private data member
        private int mcustomerID;

        //public property for customerID
        public int customerID
        {
            get
            {
                //return private data
                return mcustomerID;
            }

            set
            {
                //set private data
                mcustomerID = value;
            }
        }
        //private data member
        private string mfirstName;
        //public property for firstname
        public string firstName
        {
            get
            {
                //return private data
                return mfirstName;
            }

            set
            {
                //set private data
                mfirstName = value;
            }
        }

        //private data member
        private string mphoneNumber;
        //public property for phonemumber
        public string phoneNumber
        {
            get
            {
                //return private data
                return mphoneNumber;
            }

            set
            {
                //set private data
                mphoneNumber = value;
            }
        }

        //private data member
        private string mlastName;
        //public property for lastname
        public string lastName
        {
            get
            {
                //return private data
                return mlastName;
            }

            set
            {
                //set private data
                mlastName = value;
            }
        }

        //private data member
        private string memail;
        //public property for email
        public string email
        {
            get
            {
                //return private data
                return memail;
            }

            set
            {
                //set private data
                memail = value;
            }
        }

        //private data member
        private DateTime mdateOfbirth;
        public DateTime dateOfbirth
        {
            get
            {
                //return private data
                return mdateOfbirth;
            }

            set
            {
                //set private data
                mdateOfbirth = value;
            }
        }



        public string ValidName(string name)
        {
            //declaring error variable
            string Error = "";

            //if the customer's name is not empty
            if (name == "")
            {
                //return a not empty string message
                Error = "The customer name cannot be empty";
            }
            if (name.Length > 20)
            {
                Error = "The first name must be maximum 20 characters";
            }
            return Error;
        }

        public string Validphone(string testData)
        {
            //declaring error variable
            string Error = "";

            //phonenumber should be equal to 11. Country code excluded
            if (testData.Length != 11)
            {
                Error = "Enter a valid phone number";
            }
            return Error;
        }

        public string ValidEmail(string email)
        {
            string Error = "";           

            if (email == "")
            {
                Error = "Email cannot be empty";
            }

            if(!email.Contains("@") && !email.Contains("."))
            {
                Error = "Email cannot be empty";
            }

            return Error;
        }

        public string ValidDOB(string dateOfbirth)
        {
            string Error = "";
            DateTime dDate;

            if(DateTime.TryParse(dateOfbirth, out dDate))
            {
                String.Format("{0:d/MM/yyyy}", dDate);
            }
            else
            {
                Error = "Enter a valid date";
            }
            return Error;
        }

        public bool Find(int customerID)
        {
            
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@customerID", customerID);
            
            //execute the query
            DB.Execute("sproc_Customer_FilterBycustomerID");
            //if one record is found
            if(DB.Count == 1)
            {
                mcustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mdateOfbirth = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOfbirth"]);
                memail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mfirstName = Convert.ToString(DB.DataTable.Rows[0]["firstName"]);
                mlastName = Convert.ToString(DB.DataTable.Rows[0]["lastName"]);
                mphoneNumber = Convert.ToString(DB.DataTable.Rows[0]["phoneNumber"]);
                //return that everything work
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }
    }
}