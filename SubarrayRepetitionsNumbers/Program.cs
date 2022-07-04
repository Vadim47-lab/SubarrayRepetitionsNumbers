using System;

namespace SubarrayRepetitionsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать в программу: подмассив повторений чисел!");

            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 7, 7, 7};
            Array.Sort(array);
            int maxRepetitions = 0;
            int maxCountRepetitions = 0;
            int сountRepetitions = 0;
            int currCountRepetitions = array[0];

            foreach (int line in array)
            {
                if (line == currCountRepetitions)
                    сountRepetitions++;
                else
                {
                    сountRepetitions = 1;
                    currCountRepetitions = line;
                }
                if (сountRepetitions > maxRepetitions)
                {
                    maxRepetitions = сountRepetitions;
                    maxCountRepetitions = line;
                }
            }

            Console.WriteLine("\n Массив, состоящий из 30 чисел array = ");
            for (int line = 0; line < array.Length; line++)
            {
                Console.Write(" " + array[line] + " ");
            }

            Console.WriteLine("\n\n Число, которое само больше раз повторяется подряд maxCountRepetitions = " + maxCountRepetitions + ".\n И количество повторений сountRepetitions = " 
            + maxRepetitions + ".");
        }
    }
}