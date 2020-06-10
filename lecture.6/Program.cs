using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
              void Task1()
            {
                int[] empty_massive = new int[0];
             }

            void Task2()
            {
                //int a = 32; char b = 'A'; string c = "Hello";
                //int [] massive_of_3 = new[] {a,b,c};
                //massive_of_3[0]= 
            }
            void Task3()
            {
                int[] massive_random = new int[12];
                Random R = new Random();
                for (int i = 0; i <= 12; i++)
                    massive_random[i] = R.Next();
                Console.WriteLine($"massive:{massive_random}");
            }
        }
    }
}
