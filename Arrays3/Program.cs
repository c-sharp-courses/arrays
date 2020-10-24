using System;
using System.Buffers;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти индекс минимального элемента массива
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int min = numbers[0];

            int index_min = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[index_min])
                {
                    index_min = i;
                }
            }
            Console.WriteLine(index_min);
        }
    }
}
