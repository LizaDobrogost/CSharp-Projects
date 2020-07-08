using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10] {3, 5, 0, 1, 4, 9, 4, 8, 3, 7};
            int i, j,buf;
            for (i = 0; i < 10 - 1; i++)
            {
                for (j = 0; j < 10 - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        buf = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = buf;
                    }
                }
            }

            for (int k = 0; k < 9; k++)
            {
                 Console.WriteLine($"Sorted:{k}",numbers[k]);
            }


        }
    }
}
