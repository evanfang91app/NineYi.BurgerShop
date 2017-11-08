using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Burgers.Enums;
using NineYi.BurgerShop.BurgerFactories;

namespace NineYi.BurgerShop
{
    class Program
    {
        static void Main(string[] args)
        {

            //// 1. 使用者點餐
            var shopChoice = _UserSelectShop(); //// Select Shop
            var burgerChoice = _UserOrderBurger(); //// Order burger

            //// 2. 準備漢堡
            Burger burger = BurgerFactory.Create(shopChoice, burgerChoice);


            //// 3. 烹飪漢堡
            burger.Cook();
        }

        private static ShopType _UserSelectShop()
        {
            Console.Write("Which shop do you like? (1)Taipei (2)NewYork (3)Tokyo: ");

            int burgerChoice = int.Parse(Console.ReadLine());

            switch (burgerChoice)
            {
                case 1:
                    return ShopType.Taipei;

                case 2:
                    return ShopType.NewYork;

                case 3:
                    return ShopType.Tokyo;

                default:
                    throw new ArgumentException("No such burger");
            }
        }

        private static BurgerType _UserOrderBurger()
        {
            Console.Write("What burger would you like? (1)Chicken (2)Pork (3)Fish: ");

            int burgerChoice = int.Parse(Console.ReadLine());

            switch(burgerChoice)
            {
                case 1:
                    return BurgerType.Chicken;

                case 2:
                    return BurgerType.Pork;

                case 3:
                    return BurgerType.Fish;

                default:
                    throw new ArgumentException("No such burger");
            }
        }
    }
}
