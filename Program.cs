using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение координат первой точки x1 и y1: ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение координат второй точки x2 и y2: ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение координат третей точки x3 и y3: ");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int x4, y4;

            if (x1 == x3 && y2 == y3 || x2 == x3 && y1 == y3 || x1 == x3 && y1 == y2 || x2 == x3 && y1 == y2 || x1 == x2 && y2 == y3 || x1 == x2 && y1 == y2)
            {
                if (x1 == x2 && y2 == y3)
                {
                    x4 = x3;
                    y4 = y1;
                    Console.WriteLine($"Координаты вершины: x = {x4}, y = {y4}");
                }
                else if (x1 == x2 && y1 == y3)
                {
                    x4 = x3;
                    y4 = y2;
                    Console.WriteLine($"Координаты вершины: x = {x4}, y = {y4}");
                }
                else if (x2 == x3 && y1 == y2)
                {
                    x4 = x1;
                    y4 = y3;
                    Console.WriteLine($"Координаты вершин: x = {x4}, y = {y4}");
                }
                else if (x1 == x3 && y2 == y3)
                {
                    x4 = x2;
                    y4 = y1;
                    Console.WriteLine($"Координаты вершин: x = {x4}, y = {y4}");
                }
                else if (x2 == x3 && y1 == y3)
                {
                    x4 = x1;
                    y4 = y2;
                    Console.WriteLine($"Координаты вершин: x = {x4}, y = {y4}");
                }
                else
                {
                    Console.WriteLine("Стороны не параллельны координатным осям!");
                }
            }

            Console.ReadKey();
        }
    }
}
