using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideType type;

        private readonly double MIN_COST_PER_KM;
        private readonly int COST_PER_MIN;
        private readonly double MIN_FARE;


        public InvoiceGenerator(RideType type)
        {
            this.type = type;
            try
            {
                this.MIN_COST_PER_KM = 10;
                this.COST_PER_MIN = 1;
                this.MIN_FARE = 5;
            }
            catch(InvoiceException)
            {
                throw new InvoiceException(InvoiceException.ExceptionType.INVALID_RIDETYPE, "Invalid Ride Type");
            }
            
        }
        public double CalculateFare(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance * MIN_COST_PER_KM + time * COST_PER_MIN;
            }
            catch
            {
                if(distance <= 0)
                {
                    throw new InvoiceException(InvoiceException.ExceptionType.INVALID_DISTANCE, "Distance can't be negative");
                }
                if(time <= 0)
                {
                    throw new InvoiceException(InvoiceException.ExceptionType.INVALID_TIME, "Time must be positive");
                }
            }
            return Math.Max(totalFare, MIN_FARE);
        }
    }
}
