using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach
{
    class MixingConsoles : Instrument
    {
        string type;
        int channels;

        public MixingConsoles(string name, double price, string country, bool guarantee, string type, int channels)
            : base(name, price, country, guarantee)
        {
            this.type = type;
            this.channels = channels;
        }
        public string Type
        { get { return type; } }
        public int Channels
        { get { return channels; } }

        public override string Info()
        {
            string dd;
            if (Guarantee == true)
                dd = "Есть";
            else
                dd = "Нет";
            string sss = $"\nМикшерный пульт Название: { Name}" +
                         $"\nЦена: { Price}" +
                         $"\nСтрана производства: { Country}" +
                         $"\nНаличие гарантии: { dd}" +
                         $"\nТип: { type}" +
                         $"\nКоличество каналов: { channels}";
            return sss;
        }

    }
}
