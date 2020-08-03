using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lecture14.Task3
{
    public class Neighbors
    {
        public string Fullname { get; set; }
        public int Flatnumber { get; set; }
        public short PhoneNumber { get; set; }
       
             public static void ReturnNeighborbyFlatNo(IList<Neighbors> floorNeighbors)
            {
                Console.WriteLine("Add number of the flat");
                string flatNo = Console.ReadLine();
                foreach (Neighbors item in floorNeighbors)
                {
                    if (item.Flatnumber.Equals(Convert.ToInt32(flatNo)))
                    {
                        Console.WriteLine($"Fullname: {item.Fullname}, {item.PhoneNumber}");
                    }
                }
             }
    }
}

    

    

