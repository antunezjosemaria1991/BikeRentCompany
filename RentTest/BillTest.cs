using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRent;

namespace RentTest
{
    [TestClass]
    public class BillTest
    {
        [TestMethod]
        public void TestValidBill()
        {
            float amount = 5.0f;//h
            float expected = 25.0f;
            float actual = 0;
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(amount, "Bike", RentType.Hour);
            actual = bill.Total;
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestValidPromoBill()
        {
            float amount = 3.0f; //day family weekend
            float expected = 20.0f * 3.0f * 3.0f * (1.0f - 0.3f);
            float actual;
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(amount, "Bike black", RentType.Day);
            bill.Add(amount, "Bike white", RentType.Day);
            bill.Add(amount, "Bike blue", RentType.Day);
            actual = bill.Total;
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestValidBill_AddRemove()
        {
            float amount = 5.0f;//h
            float expected = 25.0f ;
            float actual = 0;
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(amount, "Bike green", RentType.Hour);
            bill.Add(amount, "Bike white", RentType.Hour);
            bill.Remove(2);
            actual = bill.Total;
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestValidNoPromoBill()
        {
            float amount = 3.0f; //day family weekend
            float expected = 20.0f * 3.0f * 6.0f;
            float actual;
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(amount, "Bike black", RentType.Day);
            bill.Add(amount, "Bike white", RentType.Day);
            bill.Add(amount, "Bike blue", RentType.Day);
            bill.Add(amount, "Bike green", RentType.Day);
            bill.Add(amount, "Bike yellow", RentType.Day);
            bill.Add(amount, "Bike cyan", RentType.Day);
            actual = bill.Total;
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidBill_Amount()
        {
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(-1, "Bike", RentType.Hour);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidBill_Desc()
        {
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(5, "", RentType.Hour);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidBill_Amount_Zero()
        {
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(0, "Bike", RentType.Hour);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidBill_Argument_1()
        {
            var bill = new Bill("", "Argentina", "3815582300");
            bill.Add(0, "Bike", RentType.Hour);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidBill_Argument_2()
        {
            var bill = new Bill("Jose Maria Antunez", "", "3815582300");
            bill.Add(0, "Bike", RentType.Hour);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidBill_Argument_3()
        {
            var bill = new Bill("Jose Maria Antunez", "Argentina", "");
            bill.Add(0, "Bike", RentType.Hour);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidBill_AddRemove()
        {
            float amount = 5.0f;//h
            float expected = 25.0f;
            float actual = 0;
            var bill = new Bill("Jose Maria Antunez", "Argentina", "3815582300");
            bill.Add(amount, "Bike green", RentType.Hour);
            bill.Add(amount, "Bike white", RentType.Hour);
            bill.Remove(2);
            bill.Remove(2);
            actual = bill.Total;
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
