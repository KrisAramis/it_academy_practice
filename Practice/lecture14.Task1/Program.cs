﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace lecture14.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rect;
            Rectangle.RectangleArray(out rect);
            Rectangle.FindDuplicates(rect);
        }
    }
}
    

