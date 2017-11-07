using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.IngredientFactories;

namespace NineYi.BurgerShop.BurgerFactories.FactoryMethods
{
    public class PorkBurgerFactory : IBurgerFactory
    {
        public Burger Create(IIngredientFactory IngredientFactory)
        {
            var burger = new PorkBurger();

            //// 備料

            burger.Bread = IngredientFactory.GetBread();

            burger.Veggie = IngredientFactory.GetVeggie();

            //// 準備豬肉
            burger.Meat = IngredientFactory.GetPork();

            return burger;
        }
    }
}
