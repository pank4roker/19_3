using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_4_
{
    abstract class Figure : IComparable<Figure>
    {
        public abstract double Area();
        public abstract double Per();
        public abstract string ToString1();
        public int CompareTo(Figure obj)
        {
            return Area().CompareTo(obj.Area());
        }
    }
}
