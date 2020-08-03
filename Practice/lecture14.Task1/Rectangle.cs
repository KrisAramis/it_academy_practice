using System;
using System.Collections.Generic;
using System.Text;

namespace lecture14.Task1
{
    struct Rectangle
    {
        public double height;
        public double width;
        public Rectangle(double h, double w)
            {
            height = h;
            width = w;
            }

        public static void RectangleArray(out Rectangle[] rect)
        {

            const int arraylength = 100;
            Random rand = new Random();
            rect = new Rectangle[arraylength];
            for (int i = 0; i <= rect.GetUpperBound(0); i++)
            {
                int height = rand.Next(1, 10);
                int width = rand.Next(1, 10);
                rect[i] = new Rectangle(height, width);
                Console.WriteLine($"Rectangle's {i} sides are: {rect[i].height}, {rect[i].width}");
            }
        }

        public static void FindDuplicates(Rectangle[] rect)
        {
            int countDuplicates = 0;
            for (int i = 1; i < rect.GetUpperBound(0); i++)
            {
                if (rect[i].Equals(rect[0]))
                {
                    countDuplicates++;
                }
            }
            Console.WriteLine("Number of array members, that match 1st rectangle:{0}",countDuplicates);
        }
    }
}
