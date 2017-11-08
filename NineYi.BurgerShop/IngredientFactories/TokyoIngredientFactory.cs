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
            return new JapanPork();
        }

        public Meat GetPork()
        {
            return new JapanPork();
        }

        public Veggie GetVeggie()
        {
            return new JapanVeggie();
        }
    }
}
