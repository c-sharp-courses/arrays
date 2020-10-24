using System;

namespace Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти индекс vfrcbvfkmr элемента массива
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int min = numbers[0];

            int index_max = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[index_max])
                {
                    index_max = i;
                }
            }
            Console.WriteLine(index_max);
        }
    }
}
