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
            customer.FirstName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.FirstName);
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
            customer.LastName = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.LastName);
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
            customer.Email = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.Email);
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
            customer.PhoneNumber = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.PhoneNumber);
        }

        [TestMethod]
        public void dateOfbirthOK()
        {
            //creating an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //declaring test data
            string testData;
            //creating test data to assign to the property
            testData = "01/01/1990";
            //addigning data to the property
            customer.DateOfbirth = testData;
            //test to see if the two values are the same
            Assert.AreEqual(testData, customer.DateOfbirth);
        }

        //Validation testing ///////////////////////////////////////////////

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
            if (customer.CustomerID != 1)
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
            if (customer.FirstName != "Tom")
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
            if (customer.LastName != "Holland")
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
            if (customer.PhoneNumber != "12345678900")
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
            if (customer.DateOfbirth != "01/01/1999")
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
        if (customer.Email != "me@yahoo.com")
        {
            OK = false;
        }

        //test too verify that result is correct
        Assert.IsTrue(OK);
    }
}


}

