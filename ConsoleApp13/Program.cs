using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int dollarToRuble = 10;
            int dollarToEuro = 1;
            int euroToRuble = 15;
            int euroToDollar = 1;
            int rubleToDollar = 55;
            int rubleToEuro = 60;
            float ruble;
            float dollar;
            float euro;
            string userInput;
            float currencyCount;

            Console.WriteLine("Курсы валют! Доллар ="+rubleToDollar+" рублей, Евро ="+rubleToEuro+" рублей, 1 доллар = 1 евро, рубль = "+ dollarToRuble+" долларов либо " + euroToRuble+" евро");
            
            Console.Write("Введите кол-во ваших рублей: ");
            ruble = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите кол-во ваших долларов: ");
            dollar = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите кол-во ваших евро: ");
            euro = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");
            Console.WriteLine("3 - обменять рубли на евро");
            Console.WriteLine("4 - обменять евро на рубли");
            Console.WriteLine("5 - обменять евро на доллары");
            Console.WriteLine("6 - обменять доллары на евро");
            Console.WriteLine("7 - Покинуть приложение");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (ruble >= currencyCount)
                    {
                        ruble -= currencyCount;
                        dollar += currencyCount * dollarToRuble;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollar >= currencyCount)
                    {
                        dollar -= currencyCount;
                        ruble += currencyCount * rubleToDollar;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "3":
                    Console.WriteLine("Обмен рублей на евро");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (ruble >= currencyCount)
                    {
                        ruble -= currencyCount;
                        euro += currencyCount * euroToRuble;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "4":
                    Console.WriteLine("Обмен евро на рубли");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (euro >= currencyCount)
                    {
                        euro -= currencyCount;
                        ruble += currencyCount * rubleToEuro;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "5":
                    Console.WriteLine("Обмен евро на доллары");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (euro >= currencyCount)
                    {
                        euro -= currencyCount;
                        dollar += currencyCount * dollarToEuro;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "6":
                    Console.WriteLine("Обмен доллары на евро");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollar >= currencyCount)
                    {
                        dollar -= currencyCount;
                        euro += currencyCount * euroToDollar;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "7":
                    {
                        Console.WriteLine("Приходите в другой раз");
                    }
                    break;
            }

            Console.WriteLine("Ваш баланс " + ruble + " рублей, " + dollar + " долларов, " + euro + " евро");
            }
    }
}
