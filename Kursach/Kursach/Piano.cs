using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach
{
    class Piano : Instrument
    {
        int keys;

        public Piano(string name, double price, string country, bool guarantee, int keys)
            : base(name, price, country, guarantee)
        {
            this.keys = keys;

        }
        public int Keys
        { get { return keys; } }
        public override string Info()
        {
            string dd;
            if (Guarantee == true)
                dd = "Есть";
            else
                dd = "Нет";
            string sss = $"\nФортепиано Название: { Name}" +
                         $"\nЦена: { Price}" +
                         $"\nСтрана производства: { Country}" +
                         $"\nНаличие гарантии: { dd}" +
                         $"\nКоличество клавиш: { keys}" ;
            return sss;
        }

    }
}
