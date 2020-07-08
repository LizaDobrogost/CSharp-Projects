using System;

namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10] {5, 7, 2, 9, 7, 5, 11, 19, 3, 7};
            int i, j,key;
            for (i = 1; i < 10; i++)
            {
                key = numbers[i];
                j = i - 1;
                while (j>=0 && numbers[j]>key)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }

                numbers[j + 1] = key;
            }

            foreach (var h in numbers)
            {
                Console.WriteLine(h);
            }
        }  
    }
}
