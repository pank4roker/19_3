using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_4_
{
    class Circle : Figure
    {
        public string Name { get; set; }
        public int Rad { get; set; }
        public Circle() { }
        public Circle(string name, int rad)
        {
            Name = name;
            Rad = rad;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Rad, 2);
        }
        public override double Per()
        {
            return 2 * Math.PI * Rad; ;
        }
        public override string ToString1()
        {
            return $"Название фигуры: {Name}\nРадиус:{Rad}\nПлощадь: {Math.Round(Area(), 2)}\nПериметр: {Per():f2}";
        }

    }
}
