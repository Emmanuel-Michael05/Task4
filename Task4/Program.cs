using System;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an array
            int[] numbers = new int[] {2, 4, 6, 8, 10};
            int results = 0;

            foreach(int number in numbers )
            {
                results += number;
            }

            Console.WriteLine(results);

            Console.ReadKey();
        }
    }
}