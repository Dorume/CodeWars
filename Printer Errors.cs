using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    class Printer_Errors
    {
        public static string PrinterErrorMyAnswer(String s)
        {
            Regex regex = new Regex(@"[m-z]");
            int startLengt = s.Length;
            MatchCollection matches = regex.Matches(s);

            return (matches.Count-1) + "/" + startLengt;
        }

        public static string PrinterError(string s)
        {
            return s.Where(c => c > 'm').Count() + "/" + s.Length;
        }
    }
}
