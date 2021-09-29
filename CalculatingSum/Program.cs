using System;

namespace CalculatingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 3; i++) 
            {
                Console.WriteLine("sisesta kolm numbrit.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                sum = sum + userNumber;
            }
            Console.WriteLine($"Your result is {sum}");
        }
    }
}
