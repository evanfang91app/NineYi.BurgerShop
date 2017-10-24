using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Breads
{
    /// <summary>
    /// 麵包類
    /// </summary>
    public class Bread
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
