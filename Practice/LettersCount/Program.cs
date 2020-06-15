using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();

            
            int[] nums = new int[word.Length];
            int count = 0;
            foreach (int i in nums)
            {
                count++;
                
            }
            Console.WriteLine($"Number of elements: {count}");
        
        }
    }
}
