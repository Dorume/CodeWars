using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Int32.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(PerfectSquare.FindNextSquare(num));
            Console.ReadKey();
        }


    }
}
