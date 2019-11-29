using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Money wallet = new Money(10000,70);
            Console.WriteLine(wallet.HowMuch());

            Good Hamburger = new Good(150, 80 ,10,"Hamburger");
            Good Cola = new Good(60, 0, 50,"Cola-Cola");
            Good IceCream = new Good(120, 40, 15,"Ice Cream");
            Good BubbleGum = new Good(40, 10, 10000,"Bubble Gum");

            wallet.Buy(Hamburger, 9);
            Console.WriteLine(wallet.HowMuch());

            Hamburger.Sale(5);
            wallet.Buy(Hamburger, 1);
            
            Console.WriteLine(wallet.HowMuch());
            Console.ReadKey();
        }
    }
}
