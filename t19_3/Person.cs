using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t19_3
{
    class Person : IComparable<Person>
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int CompareTo(Person obj)
        {
           return Name.CompareTo(obj.Name);
        }
        public void OutPut()
        {
            Console.WriteLine($"{Name};{Age} лет");
        }
    }
}
