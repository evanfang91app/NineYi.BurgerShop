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
    /// <summary>
    /// 提供製作漢堡所使用到的原料
    /// </summary>
    public interface IIngredientFactory
    {
        Bread GetBread();
        
        Veggie GetVeggie();

        Meat GetChicken();

        Meat GetPork();
    }
}
