using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Description
Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in 
this way until a single-digit number is produced. The input will be a non-negative integer.
 
 */


namespace CodeWars
{
    class Sum_of_Digits___Digital_Root
    {
        public static int DigitalRootMyAnswer(long n)        //В codewars убрати static
        {
            long sum = n;
            long answer = 0;
            do
            {
                answer = 0;
                while (sum != 0)
                {
                    answer += sum % 10;
                    sum /= 10;
                }
                sum = answer;
            } while (answer / 10 > 0);

            return (int)answer;

        }


        public int DigitalRoot(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }

    }
}
