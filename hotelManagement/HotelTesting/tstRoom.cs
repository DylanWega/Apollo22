using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HotelClasses;




namespace HotelTesting
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of class
            clsRoom ARoom = new clsRoom();
            //test to see that it exists
            Assert.IsNotNull(ARoom);
        }
        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //Create an instance of class
            clsRoom ARoom = new clsRoom();
            //Create some test data to assign to the property
            string TestData = "yes";
            //assign the data to the property
            ARoom.Availability = TestData;
            //test to see that it exists
            Assert.AreEqual(ARoom.Availability, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //Create an instance of class
            clsRoom ARoom = new clsRoom();
            //Create some test data to assign to the property
            string TestData = "good";
            //assign the data to the property
            ARoom.Description = TestData;
            //test to see that it exists
            Assert.AreEqual(ARoom.Description, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //Create an instance of class
            clsRoom ARoom = new clsRoom();
            //Create some test data to assign to the property
            Decimal TestData = 1;
            //assign the data to the property
            ARoom.Price = TestData;
            //test to see that it exists
            Assert.AreEqual(ARoom.Price, TestData);
        }
        [TestMethod]
        public void RoomNoPropertyOK()
        {
            //Create an instance of class
            clsRoom ARoom = new clsRoom();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ARoom.RoomNo = TestData;
            //test to see that it exists
            Assert.AreEqual(ARoom.RoomNo, TestData);
        }
        [TestMethod]
        public void TypePropertyOK()
        {
            //Create an instance of class
            clsRoom ARoom = new clsRoom();
            //Create some test data to assign to the property
            string TestData = "standard";
            //assign the data to the property
            ARoom.Type = TestData;
            //test to see that it exists
            Assert.AreEqual(ARoom.Type, TestData);
        }
        //[TestMethod]
        //public void FindMethodOK()
        //{
        //    //Create an instance of class
        //    clsRoom ARoom = new clsRoom();
        //    //Bollean varaible to store the results of the validation
        //    Boolean Found = false;
        //    //Create some test data to use
        //    int RoomNo = 1;
        //    //invoker the method
        //    Found = ARoom.Find(RoomNo);
        //    //test to see if the result is true
        //    Assert.IsTrue(Found);
        //}


    }
}


       

