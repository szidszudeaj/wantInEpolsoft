using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursach
{
    class installment : Payment
    {
        int mounth;
        

        public installment(List<Instrument> instrum, int mounth) 
            : base(instrum)
        { this.mounth = mounth; }
        public double PayinMounth(int e)
        {
            return Math.Round((ToPay(e) / mounth),2);
        }
        public override string Info(int y, int e)
        {
            
            string forma_opl = " ";
            string forma_dost = " ";

            if (y == 1)
                forma_opl = "Оплата наличными";
            if (y == 2)
                forma_opl = "Оплата по карте";
            if (y == 3)
                forma_opl = "Оплата в рассрочку";
            if (e == 1)
                forma_dost = "по почте";
            if (e == 2)
                forma_dost = "на месте";
            if (e == 3)
                forma_dost = "курьером";
            string h = $"\nЗаказано товаров: {Instrum.Count}" +
                       $"\nФорма доставки: {forma_dost}" +
                       $"\nФорма оплаты: {forma_opl}" +
                       $"\nСумма заказа: {ToPay(e)}" +
                       $"\nСумма платежа в месяц: {PayinMounth(e)}";


            return h;
        }
    }
}
