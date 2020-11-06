using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Your_order__please_6_kyu_
    {
        public static string OrderMyAnswer(string words)
        {
            int number = 1;
            string answer = "";
            string[] massiveOfWords = words.Split(new char[] { ' ' });
            if (String.IsNullOrWhiteSpace(massiveOfWords[0])) return answer;
            while (number <= massiveOfWords.Length)
            {
                for (int i = 0; i < massiveOfWords.Length; i++)
                {
                    if (massiveOfWords[i].Contains(number.ToString()))
                    {
                        answer += massiveOfWords[i] + " ";
                        number++;
                    }
                }
            }
            return answer.Remove(answer.Length - 1);

        }
        /// <summary>
        /// Best practise but have some problems with 2-digits numbers. ATTENTION!!! 
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
    }
}
}
