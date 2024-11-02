using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите год в диапазоне  20 - 69: ");
            int age = int.Parse(Console.ReadLine());

            int unit = age % 10;
            int decade = age / 10;

            string decadeString, unitString;

            if (age < 20 || age > 69)
            {
                Console.WriteLine("Введено неверное значение возраста");
            }
            else
            {
                switch (decade)
                {
                    case 2:
                        decadeString = "Двадцать";
                        switch (unit)
                        {
                            case 1:
                                unitString = "один";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} год");
                                break;
                            case 2:
                                unitString = "два";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 3:
                                unitString = "три";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 4:
                                unitString = "четыре";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 5:
                                unitString = "пять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 6:
                                unitString = "шесть";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 7:
                                unitString = "семь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 8:
                                unitString = "восемь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 9:
                                unitString = "девять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 0:
                                Console.WriteLine($"Ваш возраст: {decadeString} лет");
                                break;
                        }
                        break;
                    case 3:
                        decadeString = "Тридцать";
                        switch (unit)
                        {
                            case 1:
                                unitString = "один";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} год");
                                break;
                            case 2:
                                unitString = "два";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 3:
                                unitString = "три";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 4:
                                unitString = "четыре";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 5:
                                unitString = "пять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 6:
                                unitString = "шесть";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 7:
                                unitString = "семь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 8:
                                unitString = "восемь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 9:
                                unitString = "девять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 0:
                                Console.WriteLine($"Ваш возраст: {decadeString} лет");
                                break;
                        }
                        break;
                    case 4:
                        decadeString = "Сорок";
                        switch (unit)
                        {
                            case 1:
                                unitString = "один";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} год");
                                break;
                            case 2:
                                unitString = "два";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 3:
                                unitString = "три";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 4:
                                unitString = "четыре";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 5:
                                unitString = "пять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 6:
                                unitString = "шесть";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 7:
                                unitString = "семь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 8:
                                unitString = "восемь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 9:
                                unitString = "девять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 0:
                                Console.WriteLine($"Ваш возраст: {decadeString} лет");
                                break;
                        }
                        break;
                    case 5:
                        decadeString = "Пятдесят";
                        switch (unit)
                        {
                            case 1:
                                unitString = "один";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} год");
                                break;
                            case 2:
                                unitString = "два";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 3:
                                unitString = "три";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 4:
                                unitString = "четыре";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 5:
                                unitString = "пять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 6:
                                unitString = "шесть";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 7:
                                unitString = "семь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 8:
                                unitString = "восемь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 9:
                                unitString = "девять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 0:
                                Console.WriteLine($"Ваш возраст: {decadeString} лет");
                                break;
                        }
                        break;
                    case 6:
                        decadeString = "Шестьдесят";
                        switch (unit)
                        {
                            case 1:
                                unitString = "один";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} год");
                                break;
                            case 2:
                                unitString = "два";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 3:
                                unitString = "три";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 4:
                                unitString = "четыре";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} года");
                                break;
                            case 5:
                                unitString = "пять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 6:
                                unitString = "шесть";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 7:
                                unitString = "семь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 8:
                                unitString = "восемь";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 9:
                                unitString = "девять";
                                Console.WriteLine($"Ваш возраст: {decadeString} {unitString} лет");
                                break;
                            case 0:
                                Console.WriteLine($"Ваш возраст: {decadeString} лет");
                                break;
                        }
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
