using System;

namespace Arrays9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отсортировать массив по возрастанию выбором (Select) 

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int min_index;
            int temp; 

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                min_index = i;                    

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min_index])
                    {
                        min_index = j;
                    }
                }

                // swapping elements
                temp = numbers[min_index];
                numbers[min_index] = numbers[i];
                numbers[i] = temp;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
               
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
