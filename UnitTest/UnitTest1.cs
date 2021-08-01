using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("UC1")]
        public void ReturnTotalFareForNormalRide()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 6.8;
            int time = 8;
            //calculating fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double excepted = 76;
            Assert.AreEqual(excepted, fare);
        }

        [TestMethod]
        public void MultipleRides()
        {
            try
            {
                //Arrange
                InvoiceGenerator getInvoice = new InvoiceGenerator(RideType.NORMAL);
                Ride[] rides = { new Ride(5.2, 10), new Ride(6.3, 10) };
                double actual, expected = 135;
                //Act
                actual = getInvoice.MultipleFare(rides);

                //Assert
                Assert.AreEqual(actual, expected);

            }
            catch (InvoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
