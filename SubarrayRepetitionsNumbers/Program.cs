using System;

namespace SubarrayRepetitionsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать в программу: подмассив повторений чисел!");

            Random random = new Random();
            int initialNumber = 0;
            int finitNumber = 30;
            int[] numbers = new int[finitNumber];
            int maxRepetitions = 0;
            int maxCountRepetitions = 0;
            int сountRepetitions = 0;
            int currCountRepetitions = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(initialNumber, finitNumber);
            }

            foreach (int number in numbers)
            {
                if (number == currCountRepetitions)
                {
                    сountRepetitions++;
                }
                else
                {
                    сountRepetitions = 1;
                    currCountRepetitions = number;
                }

                if (сountRepetitions > maxRepetitions)
                {
                    maxRepetitions = сountRepetitions;
                    maxCountRepetitions = number;
                }
            }

            Console.WriteLine("\n Массив, состоящий из " + numbers.Length + " чисел numbers = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i] + " ");
            }

            Console.WriteLine("\n\n Число, которое само больше раз повторяется подряд maxCountRepetitions = " + maxCountRepetitions + ".\n И количество повторений сountRepetitions = " 
            + maxRepetitions + ".");
        }
    }
}