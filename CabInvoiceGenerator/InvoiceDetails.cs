using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceDetails
    {
        public int numOfRides;
        public double totFare, avgFare;


        public InvoiceDetails(int totRides, double fare)
        {
            numOfRides = totRides;
            totFare = fare;
            avgFare = totFare / numOfRides;
        }
    }
}
