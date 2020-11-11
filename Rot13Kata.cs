using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.
/// Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. 
/// Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
/// </summary>
namespace CodeWars
{
    class Rot13Kata
    {
        public static string Rot13(string message)
        {
            string answer = "";
            foreach (char symbol in message)
            {
                int counter = symbol;
                if (char.IsLetter(symbol))
                {
                    counter += symbol >= 'm' ? symbol <= 'M' ? 13 : -13 : -13;
                }
                else
                    counter = symbol;
                answer += (char)counter;
            }
            return answer;
        }
    }
}
