using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
   internal class MyCustomException:ApplicationException
    {
        public MyCustomException(string message) : base(message)
        { 

        }

    }
}
