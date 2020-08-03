using System;
 using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace GoodDay
{
    class Greeting
    {
        static void Main(string[] args)
        {
            DateTime currentdate = DateTime.Now; // год - месяц - день
            DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
            TimeSpan number = TimeSpan.FromHours(9);
            Console.WriteLine(number);
           //TimeSpan fierstinerval = new Hours

        }
        public int Hours { get; }
            public TimeSpan TimeOfDay { get; }

        

    }
}

