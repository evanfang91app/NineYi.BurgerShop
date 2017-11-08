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
            IBurgerFactory burgerFactory = null;

            if (burgerType == BurgerType.Chicken)
            {
                burgerFactory = new ChickenBurgerFactory();
            }
            else if(burgerType == BurgerType.Pork)
            {
                burgerFactory = new PorkBurgerFactory();
            }

            //// 提供原料工廠
            IIngredientFactory ingredientFactory = null;

            if (shopType == ShopType.Taipei)
            {
                ingredientFactory = new TaipeiIngredientFactory();
            }
            else if (shopType == ShopType.NewYork)
            {
                ingredientFactory = new NewYorkIngredientFactory();
            }
            else if (shopType == ShopType.Tokyo)
            {
                ingredientFactory = new TokyoIngredientFactory();
            }

            //// 使用原料工廠提共的原料製作漢堡
            return burgerFactory.Create(ingredientFactory);
        }
    }
}
