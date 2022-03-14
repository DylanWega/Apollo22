using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTesting
{

    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string firstname = "Clark";
        string lastname = "Kent";
        string email = "kent@mail.com";
        string phonenumber = "123456789000";
        string dateofbirth = "03/03/1993";


        //Properties validation ////////////////////////////////////////////////

        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //test to see if it works
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void firstNameOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string testData;
            //creating test data to assign to the property
            testData = "Dylan";
            //addigning data to the property
            customer.firstName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.firstName);
        }

        [TestMethod]
        public void lastNameOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string testData;
            //creating test data to assign to the property
            testData = "Wega";
            //addigning data to the property
            customer.lastName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.lastName);
        }

        [TestMethod]
        public void emailOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string testData;
            //creating test data to assign to the property
            testData = "me@yahoo.com";
            //addigning data to the property
            customer.email = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.email);
        }

        [TestMethod]
        public void phoneNumberOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string testData;
            //creating test data to assign to the property
            testData = "237";
            //addigning data to the property
            customer.phoneNumber = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.phoneNumber);
        }

        [TestMethod]
        public void dateOfbirthOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            DateTime testData;
            //creating test data to assign to the property
            testData = Convert.ToDateTime("01/01/1990");
            //addigning data to the property
            customer.dateOfbirth = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.dateOfbirth);
        }

        //Validation testing ///////////////////////////////////////////////
        [TestMethod]
        public void ValidMethodOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //creating a string variable to store the result of the validation
            string Error;
            //calling the method
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidfirstName()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //creating a string variable to store the result of the validation
            string Error;
            //creating test data to validate the method
            string firstname = "Dylan";
            //calling the method
            Error = customer.ValidName(firstname);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidlastName()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //creating a string variable to store the result of the validation
            string Error;
            //creating test data to validate the method
            string lastname = "Wega";
            //calling the method
            Error = customer.ValidName(lastname);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Validphonenumber()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string phoneNumber;
            //creating test data to assign to the property
            phoneNumber = "12345678900";
            //creating a variable to store the result of the validation
            string Error;
            //addigning data to the property
            Error = customer.Validphone(phoneNumber);
            //test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidEmailOk()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string email;
            //creating test data to assign to the property
            email = "me@yahoo.com";
            //creating a variable to store the result of the validation
            string Error;
            //addigning data to the property
            Error = customer.ValidEmail(email);
            //test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValiddateOfbirth()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string dateOfbirth;
            //creating test data to assign to the property
            dateOfbirth = "01/01/1990";
            //addigning data to the property
            string Error;
            //addigning data to the property
            Error = customer.ValidDOB(dateOfbirth);
            //test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        /// Find Method ////////////////////
        [TestMethod]
        public void FindMethodOk()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store result
            Boolean Found = false;
            //creating test data for the method
            Int32 customerID = 1;
            //addigning data to the property
            Found = customer.Find(customerID);
            //test to see if the two values are the same
            Assert.IsTrue(Found);
        }

        /// Test properties for Find ///////////////////////////

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();

            //declaring variable to store result
            Boolean Found = false;

            //Boolean varable to record if data is OK
            Boolean OK = true;

            //creating test data for the method
            Int32 customerID = 1;

            //addigning data to the property
            Found = customer.Find(customerID);

            //check the property
            if (customer.customerID != 1)
            {
                OK = false;
            }

            //test too verify that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();

            //declaring variable to store result
            Boolean Found = false;

            //Boolean varable to record if data is OK
            Boolean OK = true;

            //creating test data for the method
            Int32 customerID = 1;

            //addigning data to the property
            Found = customer.Find(customerID);

            //check the property
            if (customer.firstName != "Tom")
            {
                OK = false;
            }

            //test too verify that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();

            //declaring variable to store result
            Boolean Found = false;

            //Boolean varable to record if data is OK
            Boolean OK = true;

            //creating test data for the method
            Int32 customerID = 1;

            //addigning data to the property
            Found = customer.Find(customerID);

            //check the property
            if (customer.lastName != "Holland")
            {
                OK = false;
            }

            //test too verify that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();

            //declaring variable to store result
            Boolean Found = false;

            //Boolean varable to record if data is OK
            Boolean OK = true;

            //creating test data for the method
            Int32 customerID = 1;

            //addigning data to the property
            Found = customer.Find(customerID);

            //check the property
            if (customer.phoneNumber != "12345678900")
            {
                OK = false;
            }

            //test too verify that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();

            //declaring variable to store result
            Boolean Found = false;

            //Boolean varable to record if data is OK
            Boolean OK = true;

            //creating test data for the method
            Int32 customerID = 1;

            //addigning data to the property
            Found = customer.Find(customerID);

            //check the property
            if (customer.dateOfbirth != Convert.ToDateTime("01/01/1999"))
            {
                OK = false;
            }

            //test too verify that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();

            //declaring variable to store result
            Boolean Found = false;

            //Boolean varable to record if data is OK
            Boolean OK = true;

            //creating test data for the method
            Int32 customerID = 1;

            //addigning data to the property
            Found = customer.Find(customerID);

            //check the property
            if (customer.email != "me@yahoo.com")
            {
                OK = false;
            }

            //test too verify that result is correct
            Assert.IsTrue(OK);
        }

        //// Testing valid parameter ////////////////////////////////////
        /// Valid firstName
        [TestMethod]
        public void firstNameMinLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string firstname = "";
            //invoke the method
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMin()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string firstname = "D";
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMinPlusOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string firstname = "Dy";
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMaxLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string firstname = "";
            //creating test data to assign to the property with number of characters + 1
            firstname = firstname.PadRight(19, 'D');
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void firstNameMax()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string firstname = "";
            firstname = firstname.PadRight(20, 'D');
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void firstNameExtremeMax()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string firstname = "";
            firstname = firstname.PadRight(100, 'D');
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        //valid lastName ///////////////////////////////////

        [TestMethod]
        public void lastNameMinLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string lastname = "";
            //invoke the method
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMin()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string lastname = "W";
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMinPlusOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string lastname = "WW";
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMaxLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string lastname = "";
            //creating test data to assign to the property with number of characters + 1
            lastname = lastname.PadRight(19, 'W');
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameMax()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string lastname = "";
            lastname = lastname.PadRight(20, 'W');
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void lastNameExtremeMax()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string lastname = "";
            lastname = lastname.PadRight(100, 'W');
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        //Valid DOB ///////////////////////

        [TestMethod]
        public void DOBMin()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            DateTime testdate;
            //set the data todays date
            testdate = DateTime.Now.Date;
            //convert the date to whatever the date is less 16 years
            testdate = testdate.AddYears(-16);
            //convert date variable to string
            string dateOfbirth = testdate.ToString();
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateOfbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            DateTime testdate;
            //set the data todays date
            testdate = DateTime.Now.Date;
            //convert the date to whatever the date is less 16 years
            testdate = testdate.AddYears(-17);
            //convert date variable to string
            string dateOfbirth = testdate.ToString();
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateOfbirth);
            //test to see if the result is okay
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            DateTime testdate;
            //set the data todays date
            testdate = DateTime.Now.Date;
            //convert the date to whatever the date is less 16 years
            testdate = testdate.AddYears(-15);
            //convert date variable to string
            string dateOfbirth = testdate.ToString();
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateOfbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMax()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            DateTime testdate;
            //set the data todays date
            testdate = DateTime.Now.Date;
            //assigning the max age, 80 years
            testdate = testdate.AddYears(80);
            //convert date variable to string
            string dateOfbirth = testdate.ToString();
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateOfbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxPlusOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            DateTime testdate;
            //set the data todays date
            testdate = DateTime.Now.Date;
            //assigning the max age, 81 years
            testdate = testdate.AddYears(81);
            //convert date variable to string
            string dateOfbirth = testdate.ToString();
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateOfbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        public void DOBMaxLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            DateTime testdate;
            //set the data todays date
            testdate = DateTime.Now.Date;
            //convert the date to whatever the date is less 80 years
            testdate = testdate.AddYears(79);
            //convert date variable to string
            string dateOfbirth = testdate.ToString();
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateOfbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }


        //valid email ///////////////
        [TestMethod]
        public void ExtremeMin()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string email = "";
            //invoke the method
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string email = "";
            email = email.PadRight(19, 'e');
            //invoke the method
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring variable to store the error message
            string Error = "";
            //creating the test data
            string email = "D";
            //assigning data to propert
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the result is okay
            Assert.AreNotEqual(Error, "");
        }

        /// valid phone number ////////////////////////////////////////
        [TestMethod]
        public void phoneNumberMin()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring error message
            string Error ="";
            //creating test data to assign to the property
            string phonenumber = "123456789000";
            //addigning data to the property
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the two values are the same
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void phoneNumberMax()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring error message
            string Error = "";
            //creating test data to assign to the property
            string phonenumber = "123456789000";
            //addigning data to the property
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the two values are the same
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void phoneNumberMinLessOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring error message
            string Error = "";
            //creating test data to assign to the property
            string phonenumber = "12345678900";
            //addigning data to the property
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the two values are the same
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void phoneNumberMinPlusOne()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring error message
            string Error = "";
            //creating test data to assign to the property
            string phonenumber = "1234567890000";
            //addigning data to the property
            Error = customer.Valid(firstname, lastname, email, phonenumber, dateofbirth);
            //test to see if the two values are the same
            Assert.AreNotEqual(Error, "");

        }
    }
}

