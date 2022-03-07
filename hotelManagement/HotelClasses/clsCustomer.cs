using System;

namespace HotelClasses
{
    public class clsCustomer
    {
        private int customerID;
        private string firstName;
        private string phoneNumber;
        private string lastName;
        private string email;
        private string dateOfbirth;

        public int CustomerID { get => customerID; set => customerID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string DateOfbirth { get => dateOfbirth; set => dateOfbirth = value; }

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
            customerID = 1;
            dateOfbirth = "01/01/1999";
            email = "me@yahoo.com";
            firstName = "Tom";
            lastName = "Holland";
            phoneNumber = "12345678900";

            return true;


           
        }
    }
}