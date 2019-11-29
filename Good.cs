using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Good : Money
    {
        public int quantity;
        public string Name { get; private set; }
        public Good(int rub, int kop,int quan,string name) : base(rub,kop)
        {
            quantity = Math.Abs(quan);
            Name = name;
        }
        public void Sale(int val)//на сколько val ( в процентах) уменьшить
        {
            if (val >0 && val <100)
            {
                rubles -= (int) (rubles * ((float)val/100));
                kopecks -= (int)( kopecks * ((float)val / 100));
                bank = bank * (val / 100);
                Console.WriteLine($"These discounts had just started at store. {Name} now cost {rubles}  руб. и {kopecks} коп.");
            }
            else
            {
                Console.WriteLine("These discounts are impossible");
            }
        }
    }
}
