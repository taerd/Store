using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Money
    {
        public int rubles { get; protected set; }
        public int kopecks { get; protected set; }
        public decimal bank { get; protected set; }
        public Money(int rub,int kop)
        {
            rubles = Math.Abs(rub) + kop/100;
            kopecks = Math.Abs(kop%100);
            bank = rubles + (decimal)kopecks / 100;
        }
        public string HowMuch()
        {
            return $"{rubles} руб.  и {kopecks} коп.";
        }
        public void Buy(Good a, int quantity)
        {
            if(a.quantity >= quantity)//есть ли заданное количество товара в магазине
            {
                if (bank >= a.bank * quantity)//хватает ли денег
                {
                    rubles -= quantity * a.rubles + (quantity * a.kopecks) / 100;
                    if(kopecks < (quantity * a.kopecks) % 100 )//если не хватает копеек добавим 100копеек из 1 рубля
                    {
                        rubles -= 1;
                        kopecks += 100;
                    }
                    kopecks -= (quantity * a.kopecks) % 100;
                    bank -= a.bank;
                    Console.WriteLine($"You had just buyed {a.Name} at quantity {quantity}");
                    a.quantity = 0;
                }
                else
                {
                    Console.WriteLine($"You dont have enough money to buy {a.Name} at quantity {quantity}");
                }
            }
            else
            {
                Console.WriteLine($"At store not enough quantity {quantity} . The Store has {a.quantity}");
            }

        }
    }
}
