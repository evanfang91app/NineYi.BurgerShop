using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.IngredientFactories;

namespace NineYi.BurgerShop.BurgerFactories.FactoryMethods
{
    public class FishBurgerFactory : IBurgerFactory
    {
        public Burger Create(IIngredientFactory IngredientFactory)
        {
            var burger = new FishBurger();

            //// 備料

            burger.Bread = IngredientFactory.GetBread();

            burger.Veggie = IngredientFactory.GetVeggie();

            //// 準備魚肉
            burger.Meat = IngredientFactory.GetFish();

            return burger;
        }
    }
}
