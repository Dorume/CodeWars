using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Bit_Counting_6_kyu_
    {


        public static int CountBitsMyAnswer(int input)
        {
            int powerOfTwo = 1, countOfBits = 0;
            while (input > 0)
            {
                if (input >= powerOfTwo)
                {
                    powerOfTwo *= 2;
                }
                else
                {
                    countOfBits++;
                    input -= powerOfTwo / 2;
                    powerOfTwo = 1;
                }

            }
            return countOfBits;
        }
        /// <summary>
        /// Best practice but slow (comments)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
