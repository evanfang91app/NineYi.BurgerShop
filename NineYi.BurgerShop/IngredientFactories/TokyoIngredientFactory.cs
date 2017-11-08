using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;

namespace NineYi.BurgerShop.IngredientFactories
{
    public class TokyoIngredientFactory : IIngredientFactory
    {
        public Bread GetBread()
        {
            return new JapanBread();
        }

        public Meat GetChicken()
        {
            //// 美式風味!
            return new Turkey();
        }

        public Meat GetPork()
        {
            //// 美式風味!
            return new Bacon();
        }

        public Veggie GetVeggie()
        {
            return new JapanVeggie();
        }

        public Meat GetFish()
        {
            return new Cod();
        }
    }
}
