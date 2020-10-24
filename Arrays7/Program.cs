using System;
using System.Threading;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Посчитать количество нечетных элементов массива

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
