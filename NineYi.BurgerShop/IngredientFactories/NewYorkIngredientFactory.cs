using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.IngredientFactories
{
    public class NewYorkIngredientFactory : IIngredientFactory
    {
        public Bread GetBread()
        {
            return new WheatBread();
        }

        public Meat GetChicken()
        {
            return new Turkey();
        }

        public Meat GetPork()
        {
            return new Bacon();
        }

        public Veggie GetVeggie()
        {
            return new Onion();
        }

        public Meat GetFish()
        {
            return new Cod();
        }
    }
}
