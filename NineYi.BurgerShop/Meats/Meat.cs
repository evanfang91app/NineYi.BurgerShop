using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Meats
{
    /// <summary>
    /// 肉類
    /// </summary>
    public class Meat
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
