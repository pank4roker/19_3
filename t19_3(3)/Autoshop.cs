using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t19_3_3_
{
    class Autoshop : IComparable<Autoshop>
    {
        public int Id {  get; set; }
        public string Marka { get; set; }
        public int MaxSpeed { get; set; }
        public double Price { get; set; }
        public int Discount {  get; set; }
        public Autoshop() { }
        public Autoshop(int id, string marka, int maxSpeed, double price, int discount)
        {
            Id = id;
            Marka = marka;
            MaxSpeed = maxSpeed;
            Price = price;
            Discount = discount;
        }
        public int CompareTo(Autoshop obj)
        {
            return Price.CompareTo(obj.Price);
        }
        public void OutPut()
        {
            Console.WriteLine($"{Id} ;{Marka} ;{MaxSpeed} ;{Price} $;{Discount} %.");
        }

        
    }
}
