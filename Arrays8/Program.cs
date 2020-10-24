using System;

namespace Arrays8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поменять местами первую и вторую половину массива, например, 
            // для массива 1 2 3 4,  результат 3 4 1 2,  или для 12345 - 45312.

            int[] numbers = { 1, 2, 3, 4, 5, 6};
            int length = numbers.Length;
            int temp;

            for(int i = 0; i < length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[(length+1) / 2 + i];
                numbers[(length+1) / 2 + i] = temp;
            }

            for (int i = 0; i < length; i++)
                Console.Write($"{numbers[i]} ");
        }
    }
}
