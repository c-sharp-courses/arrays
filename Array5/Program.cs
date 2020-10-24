using System;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Посчитать сумму элементов массива с нечетными индексами

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int min = numbers[0];

            int sum = 0;

            for (int i = 1; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
