using System;
using System.Linq;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10] {3, 8, 1, 3, 3, 4, 9, 6, 9, 1};
            int min_ind=0,i,j,buf;
            for (i = 0; i < 9; i++)
            {
              min_ind = i;
              for (j = i+1; j < 10; j++)
              {
                  if (numbers[j] < numbers[min_ind])
                  {
                      min_ind = j;
                  }
                  
              }

              buf = numbers[min_ind];
              numbers[min_ind] = numbers[i];
              numbers[i] = buf;
            }

            foreach (var il in numbers)
            {
                Console.WriteLine(il);
            }

        }
    }
}
