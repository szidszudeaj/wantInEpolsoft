using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach
{
    class Instrument
    {
        string name;
        double price;
        string country;
        bool guarantee;
        
        public Instrument(string name, double price, string country, bool guarantee)
        {
            this.name = name;
            this.price = price;
            this.country = country;
            this.guarantee = guarantee;
        }

        public string Name
        { get { return name; } }
        public double Price
        { get { return price; } }
        public string Country
        { get { return country; } }
        public bool Guarantee
        { get { return guarantee; } }


 
        public virtual string Info()
        {
            string dd;
            if (guarantee == true)
                dd = "Есть";
            else
                dd = "Нет";
            string sss = $"\nНазвание: { name}" +
                         $"\nЦена: { price}" +
                         $"\nСтрана производства: { country}" +
                         $"\nНаличие гарантии: { dd}";
            return sss;
        }

    }
}
