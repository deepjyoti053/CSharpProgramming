using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class PropertyExample
    {
        private int number1;
        private int number2;
        private int number3;
        private int number4;
        private int number5;
        private int number6;
        internal PropertyExample(int number1, int number2, int number3, int number4, int number5, int number6)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
            this.number4 = number4;
            this.number5 = number5;
            this.number6 = number6;
        }
        /// <summary>
        /// Can only read Number1 value
        /// </summary>
        public int Number1 { get; }
        public int Number2 { get { return number2; } }
        public int Number3 { get { return number3; } set {; } }  //-----
        public int Number4 { get { return number4; } set {number4 = value; } }
        public int Number5 { get; set; }
        public int Number6 { get; set; } = 50; //---------------

    }
}
