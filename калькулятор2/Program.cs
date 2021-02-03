using System;

namespace калькулятор2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstValue, secondValue;
                string action;

                Console.Clear();

                Console.WriteLine("Введите число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выбирите операцию: '/' '*' '-' '+' ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;

                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine(0);
                        Console.WriteLine(firstValue / secondValue);
                        break;

                    default:
                        Console.WriteLine("Ошибка, Неизвестная операция");
                        break;



                }
                Console.ReadLine();
            }
        }
    }
}
