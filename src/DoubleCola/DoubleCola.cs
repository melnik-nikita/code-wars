using System;
using System.Collections.Generic;
using System.Linq;

namespace DoubleCola
{
    public class Line
    {
        public static string WhoIsNext(string[] names, long n)
        {
            long decrement = 1;
            int i = 0;

            while (n > 0)
            {
                i += 1;
                n -= decrement;

                if (i != 1 && i % names.Length == 0)
                {
                    decrement *= 2;
                    i = 0;
                }

            }

            if (i == 0) i = names.Length;

            return names[i - 1];
        }
    }
}