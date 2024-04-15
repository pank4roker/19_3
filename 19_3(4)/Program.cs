using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>
            {
                new Triangle("Треугольник", 30, 30, 30),
                new Rectangle("Прямоугольник", 2, 5),
                new Circle("Окружность", 3)
            };
            foreach (var elem in figures)
            {
                Console.WriteLine(elem.ToString1());
            }
            figures.Sort();
            Console.WriteLine("\nОтсортированный список\n");
            foreach (var elem in figures)
            {
                Console.WriteLine(elem.ToString1());
            }
            Console.ReadLine();
        }
    }
}
