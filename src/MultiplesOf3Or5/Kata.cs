using System.Collections.Generic;
using System.Linq;

namespace MultiplesOf3Or5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            value -= 1;
            const int three = 3;
            const int five = 5;

            IList<int> multiples = new List<int>();

            for (int i = 1; i <= value / three; i++)
            {
                multiples.Add(i * three);
            }

            for (int i = 1; i <= value / five; i++)
            {
                multiples.Add(i * five);
            }

            return multiples.Distinct().Sum();
        }
    }
}