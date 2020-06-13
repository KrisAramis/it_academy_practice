using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] empty_massive = new int[0];

            Object[] massive_of_3 = { 32, 'A', "Hello" };
            foreach (object i in massive_of_3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(massive_of_3[0]);
            Console.WriteLine(massive_of_3[massive_of_3.Length - 1]);
            massive_of_3[0] = (int)massive_of_3[0] + 10;
            Console.WriteLine(massive_of_3[0]);
            massive_of_3[massive_of_3.Length - 1] = massive_of_3[massive_of_3.Length - 1] + ", guys";
            Console.WriteLine(massive_of_3[massive_of_3.Length - 1]);





            int[] massive_random = new int[12];
            Random R = new Random();
            for (int i = 0; i < 12; i++)
            {
                massive_random[i] = R.Next();
                Console.WriteLine($"massive number {i}:{massive_random[i]}");
                Console.WriteLine($"the maxvalue of random massive is:{massive_random.Max()}");
            }

            short variable = 4040;
            object obj = variable;
            sbyte unbox_obj = (sbyte) obj;
        }
    }
}
