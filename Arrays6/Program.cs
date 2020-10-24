using System;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сделать реверс массива(массив в обратном направлении)

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int temp;
            int length = arr.Length;
            
            for(int i = 0; i < length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[length - i - 1];
                arr[length - i - 1] = temp;
            }

            for (int i = 0; i < length; i++)
                Console.Write($"{arr[i]} ");
            
        }
    }
}
