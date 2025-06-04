using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Constructor_Class
    {
        
       public string Color_C1;
        public string Color_C2;
        //public string Model;
        //public int Year;
        public string ColorSample= "Pink";

        public Constructor_Class()
        {
            Color_C1 = ColorSample;
        }
        public Constructor_Class(string ColorName)
        {
            Color_C2 = ColorName;
            Color_C1 = ColorSample;
        }

    }
}
