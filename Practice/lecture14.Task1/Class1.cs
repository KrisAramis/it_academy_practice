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

        public void RectangleArray()
        {
            Random rand = new Random();
            Rectangle[] Rec = new Rectangle[100];
            for (int i = 0; i < Rec.GetUpperBound(0); i++)
            {
                int height = rand.Next(1, 10);
                int width = rand.Next(1, 10);
                Rec[i] = new Rectangle(height, width);
                Console.WriteLine(Rec[i]);
            }
        }
    }
}
