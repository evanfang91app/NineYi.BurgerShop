using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.BurgerFactories.FactoryMethods;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Burgers.Enums;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.BurgerFactories
{
    public class BurgerFactory
    {
        public static Burger Create(ShopType shopType, BurgerType burgerType)
        {
            //// 製作漢堡的工廠
            IBurgerFactory factory = null;

            if (shopType == ShopType.Taipei && burgerType == BurgerType.Chicken)
            {
                factory = new TaipeiChickenBurgerFactory();
            }
            else if (shopType == ShopType.Taipei && burgerType == BurgerType.Pork)
            {
                factory = new TaipeiPorkBurgerFactory();
            }
            else if (shopType == ShopType.NewYork && burgerType == BurgerType.Chicken)
            {
                factory = new NewYorkChickenBurgerFactory();
            }
            else if (shopType == ShopType.NewYork && burgerType == BurgerType.Pork)
            {
                factory = new NewYorkPorkBurgerFactory();
            }

            return factory.Create();
        }
    }
}
