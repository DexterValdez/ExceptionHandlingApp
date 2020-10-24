using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    class ValueLessThanHundredException : Exception
    {

        public ValueLessThanHundredException(string message) : base(message)
        {

        }
        public ValueLessThanHundredException() : base("Divident ot divisor should be Greater than 100") { 
        }
      
    }
}
