using System;

namespace lecture11
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem tom = new UniqueItem();
            tom.getID();
            Console.WriteLine(tom.getID());
            UniqueItem bob = new UniqueItem();
            bob.getID();
            Console.WriteLine(bob.getID());


        }
    }
}
