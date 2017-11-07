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
    public class TaipeiPorkBurgerFactory : IBurgerFactory
    {
        public Burger Create()
        {
            var burger = new TaipeiPorkBurger();

            //// 備料
            burger.Bread = new WhiteBread();
            burger.Veggie = new Tomato();
            burger.Meat = new Tenderloin();

            return burger;
        }
    }
}
