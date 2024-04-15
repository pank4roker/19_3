using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t19_3_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Autoshop> autoshops = new List<Autoshop>();
            autoshops.Add(new Autoshop(45, "Reno", 180, 12000, 5));
            autoshops.Add(new Autoshop(124, "Toyota", 220, 5500, 10));
            autoshops.Add(new Autoshop(156, "BMW", 250, 10500, 3));
            foreach (var elem in  autoshops) 
            {
                elem.OutPut();
            }
            autoshops.Sort();
            Console.WriteLine("\nОтсортированный список");
            foreach (var elem in autoshops)
            {
                elem.OutPut();
            }
            Console.ReadLine();
        }
    }
}
