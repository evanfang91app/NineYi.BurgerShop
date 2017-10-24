using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;

namespace NineYi.BurgerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. 使用者點餐

            Console.Write("Which shop do you like? (1)Taipei (2)NewYork: ");
            int shopChoice = int.Parse(Console.ReadLine());

            Console.Write("What burger would you like? (1)Chicken (2)Pork: ");
            int burgerChoice = int.Parse(Console.ReadLine());

            //// 2. 準備漢堡

            Burger burger = null;

            if (shopChoice == 1 && burgerChoice == 1)
            {
                burger = new TaipeiChickenBurger();

                //// 備料
                burger.Bread = new WhiteBread();
                burger.Veggie = new Tomato();
                burger.Meat = new TaiwanChicken();
            }
            else if (shopChoice == 1 && burgerChoice == 2)
            {
                burger = new TaipeiPorkBurger();

                //// 備料
                burger.Bread = new WhiteBread();
                burger.Veggie = new Tomato();
                burger.Meat = new Tenderloin();
            }
            else if (shopChoice == 2 && burgerChoice == 1)
            {
                burger = new NewYorkChickenBurger();

                //// 備料
                burger.Bread = new WheatBread();
                burger.Veggie = new Onion();
                burger.Meat = new Turkey();
            }
            else if(shopChoice == 2 && burgerChoice == 2)
            {
                burger = new NewYorkPorkBurger();

                //// 備料
                burger.Bread = new WheatBread();
                burger.Veggie = new Onion();
                burger.Meat = new Bacon();
            }

            //// 3. 烹飪漢堡

            burger.Cook();
        }
    }
}
