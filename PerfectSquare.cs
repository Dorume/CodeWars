using static System.Math;

namespace CodeWars
{
    class PerfectSquare
    {
        public static long FindNextSquareMyAnswer(long num)
        {
            double testSquare = Sqrt(num);
            num = (int)Sqrt(num);
            if (num == testSquare)
            {
                num++;
                num *= num;
            }
            else
            {
                num = -1;
            }
            return num;
        }

        public static long FindNextSquare(long num)
        {
            return Sqrt(num) % 1 == 0 ? (long)Pow(Sqrt(num) + 1, 2) : -1;
        }
    }
}
