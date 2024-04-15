using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_4_
{
    class Triangle : Figure
    {
        public string Name { get; set; }
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public Triangle() { }
        public Triangle(string name, int sidea, int sideb, int sidec)
        {
            Name = name;
            SideA = sidea;
            SideB = sideb;
            SideC = sidec;
        }
        public override double Area()
        {
            double p = Per() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double Per()
        {
            return SideA + SideB + SideC;
        }
        public override string ToString1()
        {
            return $"Название фигуры: {Name}\na={SideA}\nb={SideB}\nc={SideC}\nПлощадь: {Area():f2}\nПериметр: {Per():f2}";
        }
    }
}
