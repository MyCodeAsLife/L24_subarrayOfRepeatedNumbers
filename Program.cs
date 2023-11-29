using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L24_subarrayOfRepeatedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = { 1, 1, 2, 2, 3, 3, 3, 2, 2, 7, 7, 7, 7, 7, 7, 5, 5, 5, 9, 9, 9, 9, 4, 4, 4, 7, 7, 6, 6, 6 };
            int foundNumber = int.MinValue;
            int maxCounter = 0;
            int currentCounter = 1;

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < mainArray.Length - 1; i++)
            {
                if (mainArray[i] == mainArray[i + 1])
                {
                    currentCounter++;
                }
                else
                {
                    if (maxCounter < currentCounter)
                    {
                        maxCounter = currentCounter;
                        foundNumber = mainArray[i];
                    }

                    currentCounter = 1;
                }

                Console.Write(mainArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Число {foundNumber} повторяется {maxCounter} раз подряд.");
        }
    }
}
