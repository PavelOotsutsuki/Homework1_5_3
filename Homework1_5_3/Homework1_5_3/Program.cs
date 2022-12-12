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
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Work(list);

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void Work(List<int> list)
        {
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();
                PrintMenu();
                EnterNumbers(ref list, ref isWork);
                Console.ReadKey();
            }
        }

        static void EnterNumbers (ref List <int> list, ref bool isWork)
        {
            string enter;
            int number;
            bool isNumber;

            Console.Write("Введите число: ");
            enter = Console.ReadLine();
            isNumber = int.TryParse(enter, out number);

            if (isNumber)
            {
                ExecuteInputNumber(ref list, number);
            }
            else
            {
                ExecuteCommand(list, enter.ToLower(), ref isWork);
            }
        }

        static void ExecuteCommand (List <int> list, string command, ref bool isWork)
        {
            const string caseSum = "sum";
            const string caseExit = "exit";
            int sum;

            switch (command)
            {
                case caseSum:
                    sum = 0;

                    foreach (var listNumber in list)
                    {
                        sum += listNumber;
                    }

                    Console.WriteLine("Сумма введеных чисел – " + sum);
                    break;
                case caseExit:
                    isWork = false;
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }

        static void ExecuteInputNumber(ref List<int> list, int number)
        {
            list.Add(number);
            Console.WriteLine("Число добавлено");
        }

        static void PrintMenu()
        {
            const string caseSum = "sum";
            const string caseExit = "exit";

            Console.WriteLine(caseSum + " - вывести сумму введенных чисел");
            Console.WriteLine(caseExit + " - выйти из программы");
            Console.WriteLine();
        }
    }
}