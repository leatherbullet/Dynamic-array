using System;
using System.Collections.Generic;

namespace Массив_продвинутый
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "1";
            const string CommandAddNumber = "2";
            const string CommandExit = "3";

            List<int> numbers = new List<int>();

            bool isWork = true;

            string userInput;

            while (isWork)
            {
                Console.WriteLine($"{CommandSum} - сложить все числа.\n{CommandAddNumber} - добавить число.\n{CommandExit} - выход.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSum:
                        ShowSum(numbers);
                        break;
                    case CommandExit:
                        isWork = false;
                        break;
                    case CommandAddNumber:
                        AddNumber(numbers);
                        break;
                    default:
                        Console.WriteLine("неверный ввод.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ShowSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("сумма всех чисел: " + sum);
        }

        static void AddNumber(List<int> numbers)
        {
            string userNumber;

            Console.Write("введите число: ");
            userNumber = Console.ReadLine();

            if (int.TryParse(userNumber, out int number))
                numbers.Add(number);
        }
    }
}
