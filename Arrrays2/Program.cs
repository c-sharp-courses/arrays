using System;
using System.IO;

namespace Arrrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти максимальный элемент массива
            int[] numbers = new int[10];
            Random random = new Random();
            
            for(int i=0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
