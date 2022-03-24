using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HotelTesting
{
    [TestClass]
    public class tstclsCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exist
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //creating some test data to assign to the property
            //here data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create a random customer to be added to the list
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.customerID = 1;
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/1999");
            TestCustomer.email = "calm@gmail.com";
            TestCustomer.firstName = "Calm";
            TestCustomer.lastName = "Pan";
            TestCustomer.phoneNumber = "223344567890";
            //add customer to the list
            TestList.Add(TestCustomer);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        //-----We don't need this test anymore
        //[TestMethod]
        //public void CountProperyOK()
        //{
        //    //creating an instance of the class
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //create test data to assign to property
        //    Int32 someCount = 2;
        //    AllCustomers.Count = someCount;
        //    //test to see the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, someCount);
        //}

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();           
            //create a random customer to be added to the list
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.customerID = 1;
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/1999");
            TestCustomer.email = "calm@gmail.com";
            TestCustomer.firstName = "Calm";
            TestCustomer.lastName = "Pan";
            TestCustomer.phoneNumber = "223344567890";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //creating some test data to assign to the property
            //here data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create a random customer to be added to the list
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.customerID = 1;
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/1999");
            TestCustomer.email = "calm@gmail.com";
            TestCustomer.firstName = "Calm";
            TestCustomer.lastName = "Pan";
            TestCustomer.phoneNumber = "223344567890";
            //add customer to the list
            TestList.Add(TestCustomer);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        //-----We don't need this test anymore
        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //creating an instance of the class
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //test to see the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create a random customer as test data
            clsCustomer TestCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestCustomer.customerID = 1;
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/1999");
            TestCustomer.email = "calm@gmail.com";
            TestCustomer.firstName = "Calm";
            TestCustomer.lastName = "Pan";
            TestCustomer.phoneNumber = "223344567890";
            //set ThisCustomer to the TestCustomer
            AllCustomers.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key to the test data
            TestCustomer.customerID = PrimaryKey;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create a random customer to be added to the list
            clsCustomer TestCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestCustomer.customerID = 1;
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/1999");
            TestCustomer.email = "calm@gmail.com";
            TestCustomer.firstName = "Calm";
            TestCustomer.lastName = "Pan";
            TestCustomer.phoneNumber = "223344567890";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestCustomer.customerID = PrimaryKey;
            //find the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create a random customer to be added to the list
            clsCustomer TestCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/1999");
            TestCustomer.email = "calm@gmail.com";
            TestCustomer.firstName = "Calm";
            TestCustomer.lastName = "Pan";
            TestCustomer.phoneNumber = "223344567890";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestCustomer.customerID = PrimaryKey;
            //modify the test data
            TestCustomer.dateOfbirth = Convert.ToDateTime("02/03/2000");
            TestCustomer.email = "Pan@gmail.com";
            TestCustomer.firstName = "Calmer";
            TestCustomer.lastName = "Pand";
            TestCustomer.phoneNumber = "000344567890";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestCustomer;
            //update the record
            AllCustomers.Update();
            //Find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomers matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //creating an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string
            FilteredCustomer.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //apply a blank string
            FilteredCustomer.ReportByLastName("LastName");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomer.Count);
        }

        //[TestMethod]
        //public void ReportByLastNameTestDataFound()
        //{
        //    //create an instance of the filtered data
        //    clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
        //    //var to store outcome
        //    Boolean OK = true;
        //    //apply a blank string
        //    FilteredCustomer.ReportByLastName("LastName");
        //    //test to see that the two values are the same
        //    Assert.AreEqual(0, FilteredCustomer.Count);
        //}
    }
}
