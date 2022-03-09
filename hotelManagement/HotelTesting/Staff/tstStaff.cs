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




























































    }
}
