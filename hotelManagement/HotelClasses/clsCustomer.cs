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

        public string Valid(string firstname, string lastname, string email, string phonenumber, string dateofbirth)
        {
            //variable to store the error
            string Error = "";

            //temporary variable to store date
            DateTime dateTemp;

            //if firstname is blank
            if(firstname.Length == 0)
            {
                //record the error
                Error = Error + "First name cannot be blank ";
            }

            //if first name is longer than 20 characters
            if (firstname.Length > 20)
            {
                Error = Error + "The first name must be maximum 20 characters ";
            }

            //if lastname is blank
            if (lastname.Length == 0)
            {
                //record the error
                Error = Error + "last name cannot be blank ";
            }

            //if the last name is longer than 20 characters
            if (lastname.Length > 20)
            {
                Error = Error + "The last name must be maximum 20 characters ";
            }

            //if email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "Email cannot be blank ";
            }

            //if emai is longer than 20 characters
            if (email.Length > 20)
            {
                Error = Error + "Email must be maximum 20 characters ";
            }

            //if email does not have a @ or .
            if (!email.Contains("@") && !email.Contains("."))
            {
                Error = Error + "Please enter a valid email ";
            }

            if (phonenumber.Length == 0)
            {
                Error = Error + "Phone number cannot be empty ";
            }

            //phonenumber should be equal to 12 digits. Country code excluded
            if (phonenumber.Length != 12)
            {
                Error = Error +  "Enter a valid phone number ";
            }

            //copy dateOfbirth value to the dateTemp variable
            dateTemp = Convert.ToDateTime(dateofbirth);

            //if dateOfbirth is less than 16 years
            //using DateTime.Today because it sets the time at
            //00:00 instead of Now which gives the actual time

            if (dateTemp > DateTime.Today.AddYears(-16))
            {
                //record error
                Error = Error + "You are too young to have an account ";
            }


            //if dateOfbirth is 80 years in the future
            if (dateTemp >= DateTime.Today.Date)
            {
                //record error
                Error = Error + "You cannot be born today nor in the future ";
            }
            //return error message
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