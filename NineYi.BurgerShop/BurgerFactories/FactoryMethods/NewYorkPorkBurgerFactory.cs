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
    public class NewYorkPorkBurgerFactory : IBurgerFactory
    {
        public Burger Create()
        {
            var burger = new NewYorkPorkBurger();

            //// 備料
            burger.Bread = new WheatBread();
            burger.Veggie = new Onion();
            burger.Meat = new Bacon();

            return burger;
        }
    }
}
