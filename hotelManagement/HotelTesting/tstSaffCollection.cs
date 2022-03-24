using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;
using System.Collections.Generic;

namespace HotelTesting
{
    [TestClass]
    public class tstSaffCollection
    {
        [TestMethod]
        public void BookListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.EmployeeID = 1;
            TestItem.stockid = 1;
            TestItem.supplierid = 1;
            TestItem.Address = "Test";
            TestItem.Dateofbirth = "Test";
            TestItem.Email = "Test";
            TestItem.Firstname = "Test";
            TestItem.gender = "Test";
            TestItem.Lastname = "Test";
            TestItem.password = "Test";
            TestItem.phoneno = "Test";
            TestItem.position = "Test";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }
        
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //craete some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllStaffs.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign for the property
            clsStaff TestStaff = new clsStaff();
            //set its properties
            TestStaff.EmployeeID = 1;
            TestStaff.stockid = 1;
            TestStaff.supplierid = 1;
            TestStaff.Address = "Test";
            TestStaff.Dateofbirth = "Test";
            TestStaff.Email = "Test";
            TestStaff.Firstname = "Test";
            TestStaff.gender = "Test";
            TestStaff.Lastname = "Test";
            TestStaff.password = "Test";
            TestStaff.phoneno = "Test";
            TestStaff.position = "Test";
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.EmployeeID = 1;
            TestItem.stockid = 1;
            TestItem.supplierid = 1;
            TestItem.Address = "Test";
            TestItem.Dateofbirth = "Test";
            TestItem.Email = "Test";
            TestItem.Firstname = "Test";
            TestItem.gender = "Test";
            TestItem.Lastname = "Test";
            TestItem.password = "Test";
            TestItem.phoneno = "Test";
            TestItem.position = "Test";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties





            TestItem.EmployeeID = 1;
            TestItem.stockid = 1;
            TestItem.supplierid = 1;
            TestItem.Address = "Test";
            TestItem.Dateofbirth = "Test";
            TestItem.Email = "Test";
            TestItem.Firstname = "Test";
            TestItem.gender = "Test";
            TestItem.Lastname = "Test";
            TestItem.password = "Test";
            TestItem.phoneno = "Test";
            TestItem.position = "Test";

            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the Primary key of the test data
            TestItem.EmployeeID = PrimaryKey;
            //find the record   
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record 
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.EmployeeID = 1;
            TestItem.stockid = 1;
            TestItem.supplierid = 1;
            TestItem.Address = "Test";
            TestItem.Dateofbirth = "Test";
            TestItem.Email = "Test";
            TestItem.Firstname = "Test";
            TestItem.gender = "Test";
            TestItem.Lastname = "Test";
            TestItem.password = "Test";
            TestItem.phoneno = "Test";
            TestItem.position = "Test";

            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the Primary key of the test data
            TestItem.EmployeeID = PrimaryKey;
            //find the record   
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }




        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            // TestItem.BookId = 1;
            TestItem.stockid = 1;
            TestItem.supplierid = 1;
            TestItem.Address = "Test";
            TestItem.Dateofbirth = "23/03/2022 00:00:00";
            TestItem.Email = "Test";
            TestItem.Firstname = "Test";
            TestItem.gender = "Test";
            TestItem.Lastname = "Test";
            TestItem.password = "Test";
            TestItem.phoneno = "Test";
            TestItem.position = "Test";
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the Primary key of the test data
            TestItem.EmployeeID = PrimaryKey;
            //modify the test data
            TestItem.stockid = 1;
            TestItem.supplierid = 1;
            TestItem.Address = "Test";
            TestItem.Dateofbirth = "Test";
            TestItem.Email = "Test";
            TestItem.Firstname = "Test";
            TestItem.gender = "Test";
            TestItem.Lastname = "Test";
            TestItem.password = "Test";
            TestItem.phoneno = "Test";
            TestItem.position = "Test";
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record   
            AllStaffs.Update();
            //find the record 
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff mathces the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaffs.ReportByAddress("");
            //test to see ThisStaff mathces the test data
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByAddressFound()
        {

            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a title that doesn't exist
            FilteredStaffs.ReportByAddress("Doesn't exist");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

    }
}
