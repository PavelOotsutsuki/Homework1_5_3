using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_5_3
{
    class Program
    {
        const string CaseSum = "sum";
        const string CaseExit = "exit";

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            bool isWork = true;

            while (isWork)
            {
                Console.Clear();
                PrintMenu();
                Console.Write("Введите число: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CaseSum:
                        SumNumbers(numbers);
                        break;
                    case CaseExit:
                        isWork = false;
                        break;
                    default:
                        AddNumber(numbers, userInput);
                        break;
                }
                
                Console.ReadKey();
            }

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void AddNumber(List <int> numbers, string userInput)
        {
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber)
            {
                numbers.Add(number);
                Console.WriteLine("Число добавлено");
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
        }

        static void SumNumbers(List<int> numbers)
        {
            int sum = 0;

            foreach (var listNumber in numbers)
            {
                sum += listNumber;
            }

            Console.WriteLine("Сумма введеных чисел – " + sum);
        }

        static void PrintMenu()
        {
            Console.WriteLine(CaseSum + " - вывести сумму введенных чисел");
            Console.WriteLine(CaseExit + " - выйти из программы");
            Console.WriteLine();
        }
    }
}