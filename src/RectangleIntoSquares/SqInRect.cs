using System.Collections.Generic;

namespace RectangleIntoSquares
{
    public class SqInRect
    {
        public static List<int> sqInRect(int length, int width)
        {
            List<int> result = new List<int>();

            int total = length * width;

            if (length == width) return null;

            while (total > 0)
            {
                if (length > width)
                {
                    total -= (width * width);
                    result.Add(width);
                    length -= width;
                }
                else if (width > length)
                {
                    total -= (length * length);
                    result.Add(length);
                    width -= length;
                }
                else
                {
                    result.Add(length);
                    total -= (length * length);
                }
            }

            return result;
        }
    }
}