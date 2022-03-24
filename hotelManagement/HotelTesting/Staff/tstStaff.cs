using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;


namespace HotelTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);

        }


        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "Test";
            //assign the data to the property
            AStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, TestData);

        }







        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "Test";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);

        }




        [TestMethod]
        public void EmployeeIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.EmployeeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmployeeID, TestData);
        }


        
            
            
            


        [TestMethod]
        public void FirstnameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "Test";
            //assign the data to the property
            AStaff.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Firstname, TestData);

        }


        [TestMethod]
        public void GenderOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "Test";
            //assign the data to the property
            AStaff.gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.gender, TestData);

        }







        [TestMethod]
        public void PswordOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "Test";
            //assign the data to the property
            AStaff.password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.password, TestData);

        }






        [TestMethod]
        public void LastnameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "21";
            //assign the data to the property
            AStaff.Lastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Lastname, TestData);

        }



        [TestMethod]
        public void PhoneNOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Test";
            //assign the data to the property
            AStaff.phoneno = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.phoneno, TestData);
        }




        


        [TestMethod]
        public void PosOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "Test";
            //assign the data to the property
            AStaff.position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.position, TestData);

        }


        
            

        [TestMethod]
        public void StockIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.stockid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.stockid, TestData);
        }



        [TestMethod]
        public void SupplierIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.supplierid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.supplierid, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //instance of the class
            clsStaff AStaff = new clsStaff();
            //boolean variable to for the validation results
            Boolean Found = false;
            //create test data
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AStaff.Find(EmployeeID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            if (AStaff.EmployeeID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TeststockidFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            if (AStaff.stockid != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestsupplieridFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            if (AStaff.supplierid != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.Address != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.Email != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.Firstname != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.Lastname != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestgenderFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.gender != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestpasswordFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.password != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestphonenoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.phoneno != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestpositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int EmployeeID = 1;
            Found = AStaff.Find(EmployeeID);
            //check the property
            if (AStaff.position != "Test")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }



































































































































































































































































































































































































































    }
}
