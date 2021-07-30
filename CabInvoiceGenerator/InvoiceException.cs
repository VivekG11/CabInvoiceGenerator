using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
     public class InvoiceException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDE, INVALID_USER_ID, INVALID_RIDETYPE
        }
        public InvoiceException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
