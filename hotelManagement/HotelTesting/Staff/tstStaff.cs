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
            String TestData = "21";
            //assign the data to the property
            AStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, TestData);

        }




        [TestMethod]
        public void DobOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DobOK = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DobOK, TestData);

        }


        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "21";
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
            String TestData = "21";
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
            String TestData = "21";
            //assign the data to the property
            AStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Gender, TestData);

        }







        [TestMethod]
        public void PswordOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "21";
            //assign the data to the property
            AStaff.Psword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Psword, TestData);

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
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.PhoneN = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneN, TestData);
        }




        


        [TestMethod]
        public void PosOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            String TestData = "21";
            //assign the data to the property
            AStaff.Pos = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Pos, TestData);

        }


        
            

        [TestMethod]
        public void StockIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StockID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StockID, TestData);
        }



        [TestMethod]
        public void SupplierIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.SupplierID, TestData);
        }







    }
}
