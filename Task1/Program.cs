using System;
using System.Collections.Generic;
using System.Data;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[200];
            var list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < array.Length; ++i)
                array[i] = rnd.Next(1,10);
            Console.WriteLine("[{0}]", string.Join(", ", array));
            int[] generalArray = new int[200];
            int index = 0;
            int len = 0;
            Console.WriteLine(" ");
            for (int i = array.Length - 1; i > 0; i -= 3)
            {
                Array.Copy(array, i, generalArray, index++, 1);
                len++;
            }
            Array.Resize(ref generalArray, len);
            Console.WriteLine("[{0}]", string.Join(", ", generalArray));

            int[] averageNumber = new int[generalArray.Length];

            for (int i = 0; i < generalArray.Length; i++) 
            {
                if (i == 0)
                    averageNumber[i] = generalArray[i] + 50 + generalArray[i + 1];
                else if (i == generalArray.Length - 1)
                    averageNumber[i] = generalArray[i] + generalArray[i - 1] + 50;
                else
                    averageNumber[i] = generalArray[i] + generalArray[i - 1] + generalArray[i + 1];
            }

            Console.WriteLine("[{0}]", string.Join(", ", averageNumber));

            for (int i = 0; i < averageNumber.Length; i++)
            {
                if (averageNumber[i] > 90)
                    list.Add(averageNumber[i]);

                list.Add(generalArray[i]);
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));

            var list2 = new List<double>();
            for (int i = 0; i < list.Count; i++)
            {
                list2.Add(list[i]);
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] != 0)
                        list2[i] *= list[j];
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", list2));
        }
    }
}
