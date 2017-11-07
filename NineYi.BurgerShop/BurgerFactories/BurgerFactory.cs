using NineYi.BurgerShop.Breads;
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
            Burger burger = null;

            if (shopType == ShopType.Taipei && burgerType == BurgerType.Chicken)
            {
                burger = new TaipeiChickenBurger();

                //// 備料
                burger.Bread = new WhiteBread();
                burger.Veggie = new Tomato();
                burger.Meat = new TaiwanChicken();
            }
            else if (shopType == ShopType.Taipei && burgerType == BurgerType.Pork)
            {
                burger = new TaipeiPorkBurger();

                //// 備料
                burger.Bread = new WhiteBread();
                burger.Veggie = new Tomato();
                burger.Meat = new Tenderloin();
            }
            else if (shopType == ShopType.NewYork && burgerType == BurgerType.Chicken)
            {
                burger = new NewYorkChickenBurger();

                //// 備料
                burger.Bread = new WheatBread();
                burger.Veggie = new Onion();
                burger.Meat = new Turkey();
            }
            else if (shopType == ShopType.NewYork && burgerType == BurgerType.Pork)
            {
                burger = new NewYorkPorkBurger();

                //// 備料
                burger.Bread = new WheatBread();
                burger.Veggie = new Onion();
                burger.Meat = new Bacon();
            }

            return burger;
        }
    }
}
