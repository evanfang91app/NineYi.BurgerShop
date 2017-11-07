using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.BurgerFactories.FactoryMethods;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Burgers.Enums;
using NineYi.BurgerShop.IngredientFactories;
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

            //// 提供原料工廠
            IIngredientFactory ingredientFactory = null;

            if (shopType == ShopType.Taipei && burgerType == BurgerType.Chicken)
            {
                factory = new TaipeiChickenBurgerFactory();
                ingredientFactory = new TaipeiIngredientFactory();
            }
            else if (shopType == ShopType.Taipei && burgerType == BurgerType.Pork)
            {
                factory = new TaipeiPorkBurgerFactory();
                ingredientFactory = new TaipeiIngredientFactory();
            }
            else if (shopType == ShopType.NewYork && burgerType == BurgerType.Chicken)
            {
                factory = new NewYorkChickenBurgerFactory();
                ingredientFactory = new NewYorkIngredientFactory();
            }
            else if (shopType == ShopType.NewYork && burgerType == BurgerType.Pork)
            {
                factory = new NewYorkPorkBurgerFactory();
                ingredientFactory = new NewYorkIngredientFactory();
            }

            return factory.Create(ingredientFactory);
        }
    }
}
