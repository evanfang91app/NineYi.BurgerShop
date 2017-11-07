using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;

namespace NineYi.BurgerShop.BurgerFactories.FactoryMethods
{
    public class NewYorkChickenBurgerFactory : IBurgerFactory
    {
        public Burger Create()
        {
            var burger = new NewYorkChickenBurger();

            //// 備料
            burger.Bread = new WheatBread();
            burger.Veggie = new Onion();
            burger.Meat = new Turkey();

            return burger;
        }
    }
}
