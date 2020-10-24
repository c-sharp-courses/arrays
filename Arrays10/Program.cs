using System;

namespace Arrays10
{
    class Program
    {
        static void Main(string[] args)
        {
            // сортировка вставками по убыванию 

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int temp;

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j - 1] < numbers[j])
                    {
                        // swapping elements
                        temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write(numbers[i] + " ");
            }
        }
    }
}
