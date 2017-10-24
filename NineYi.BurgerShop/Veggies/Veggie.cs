using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Veggies
{
    /// <summary>
    /// 蔬菜類
    /// </summary>
    public class Veggie
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
