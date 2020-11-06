using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class ShortestWord_s_
    {
        public static int FindShortMyAnswer(string s)
        {
            string[] words = s.Split(new char[] { ' ' });
            int answer = words[0].Length;
            foreach(string word in words)
            {
                if (answer > word.Length) answer = word.Length;
            }
            return answer;
        }

        public static int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}
