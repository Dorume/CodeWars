using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Parentheses
    {
        public static bool ValidParenthesesMyAnswer(string input)
        {
            int counter = 0;
            foreach(char symbol in input)
            {
                counter += symbol == ')' ? -1 : symbol == '(' ? 1 : 0;
                if (counter < 0) return false;
            }
            return counter == 0;
        }

        public static bool ValidParentheses(string input)
        {
            int parentheses = 0;
            foreach (char t in input)
            {
                if (t == '(')
                {
                    parentheses++;
                }
                else if (t == ')')
                {
                    parentheses--;

                    if (parentheses < 0)
                    {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }
    }
}
