using System;
using System.Collections.Generic;

namespace Lecture14.Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Neighbors> floorNeighbors = new List<Neighbors>(10);
            floorNeighbors.Add(new Neighbors() { Fullname = "John Dohry", Flatnumber = 43, PhoneNumber = 444 - 333 });
            floorNeighbors.Add(new Neighbors() { Fullname = "Lewis Hamilton", Flatnumber = 32, PhoneNumber = 220 - 333 });
            floorNeighbors.Add(new Neighbors() { Fullname = "Kristin Hamilton", Flatnumber = 21, PhoneNumber = 342 - 342 });

            Neighbors.ReturnNeighborbyFlatNo(floorNeighbors);
         }
    }
}
