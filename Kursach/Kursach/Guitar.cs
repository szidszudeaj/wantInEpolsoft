using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach
{
    class Guitar : Instrument
    {

        string type;
        string size;

        public Guitar(string name, double price, string country, bool guarantee, string type, string size)
            : base(name, price, country, guarantee)
        {
            this.type = type;
            this.size = size;
        }
        public string Type
        { get { return type; } }
        public string Size
        { get { return size; } }
        public override string Info()
        {
            string dd;
            if (Guarantee == true)
                dd = "Есть";
            else
                dd = "Нет";
            string sss = $"\nГитара Название: { Name}" +
                         $"\nЦена: { Price}" +
                         $"\nСтрана производства: { Country}" +
                         $"\nНаличие гарантии: { dd}" +
                         $"\nТип: { type}" +
                         $"\nРазмер: { size}";
            return sss;
        }

    }
}
