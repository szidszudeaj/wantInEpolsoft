using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach
{
    class Payment
    {
        List<Instrument> instrum=new List<Instrument>();
        
        public Payment(List<Instrument> instrum)
        { this.instrum = instrum; }
        public List<Instrument> Instrum
        { get {return instrum; } }

        public double ToPay(int e)
        {
            double sumprice = 0;
            for (int i = 0; i < instrum.Count; i++)
                sumprice = sumprice + instrum[i].Price;
            if (e == 3)
                sumprice = sumprice + 10; //оплата домтавки курьером. 
            return sumprice;
        }
        public virtual string Info(int y, int e)
        {
            
            string forma_opl=" ";
            string forma_dost=" ";

            if (y == 1)
                forma_opl = "Оплата наличными";
            if (y == 2)
                forma_opl = "Оплата по карте";
            if (y == 3)
                forma_opl = "Оплата в рассрочку";
            if (e==1)
                forma_dost = "по почте";
            if (e == 2)
                forma_dost = "на месте";
            if (e == 3)
                forma_dost = "курьером";
            string h = $"\nЗаказано товаров: {instrum.Count}" +
                       $"\nФорма доставки: {forma_dost}" +
                       $"\nФорма оплаты: {forma_opl}" +
                       $"\nСумма заказа: {ToPay(e)}";

            return h;
        }
    }
}
