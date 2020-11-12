using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Description
 Implement a function that adds two numbers together and returns their sum in binary. 
The conversion can be done before, or after the addition.

The binary number returned should be a string.
 
 */

namespace CodeWars
{
    class Binary_Addition
    {
        public static string AddBinaryMyAnswer(int a, int b)
        {
            int sum = a + b;
            string res = "";
            while (sum != 0)
            {
                if (sum % 2 == 1) res = "1" + res;
                if (sum % 2 == 0) res = "0" + res;
                sum = sum / 2;

            }
            return res;
        }



        public static string AddBinary(int a, int b) =>
            Convert.ToString(a + b, 2);

    }
}
    