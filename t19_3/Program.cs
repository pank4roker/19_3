using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace t19_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Кирилл",17));
            people.Add(new Person("Андрей", 17));
            people.Add(new Person("Даша", 18));
            foreach(var elem in people)
            {
                elem.OutPut();
            }
            people.Sort();
            WriteLine("Отсортированный список");
            foreach (var elem in people)
            {
                elem.OutPut();
            }
            Read();
        }
    }
}
