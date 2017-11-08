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
    public class TaipeiIngredientFactory : IIngredientFactory
    {
        public Bread GetBread()
        {
            return new WhiteBread();
        }

        public Meat GetChicken()
        {
            return new TaiwanChicken();
        }

        public Meat GetPork()
        {
            return new Tenderloin();
        }

        public Veggie GetVeggie()
        {
            return new Tomato();
        }

        public Meat GetFish()
        {
            return new Cod();
        }
    }
}
