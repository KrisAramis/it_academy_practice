using System;

namespace Lecture14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, guys!";
            string newstring = StringExtension.CutString(str);
            Console.WriteLine(newstring);
        }
    }
}
