using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Simple_Pig_Latin
    {
        public static string PigItMyAnswer(string str)
        {
            string[] words = str.Split(new char[] { ' ' });
            str = "";
            foreach (string word in words)
            {
                str += word.Substring(1) + word[0] + "ay" + ' ';
            }
            str = str.Remove(str.Length - 1);
            return str;
        }

        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }
    }
}
