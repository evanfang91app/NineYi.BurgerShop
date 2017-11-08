using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.BurgerFactories.FactoryMethods;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Burgers.Enums;
using NineYi.BurgerShop.IngredientFactories;
using NineYi.BurgerShop.Meats;
using NineYi.BurgerShop.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.BurgerFactories
{
    public class BurgerFactory
    {
        /// <summary>
        /// 漢堡工廠類別清單
        /// </summary>
        private static readonly IEnumerable<Type> _burgerFactories = _InitBurgerFactories();

        /// <summary>
        /// 原料工廠類別清單
        /// </summary>
        private static readonly IEnumerable<Type> _ingrdientFactories = _InitIngredientFactories();

        public static Burger Create(ShopType shopType, BurgerType burgerType)
        {
            //// 製作漢堡的工廠
            IBurgerFactory burgerFactory = _GetBurgerFactoy(burgerType);

            //// 提供原料的工廠
            IIngredientFactory ingredientFactory = _GetIngredientFactoy(shopType);

            //// 使用原料工廠提共的原料製作漢堡
            return burgerFactory.Create(ingredientFactory);
        }

        #region Private Methods
        /// <summary>
        /// 從組件中找出所有的漢堡工廠
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Type> _InitBurgerFactories()
        {
            return Assembly
                .GetExecutingAssembly()
                .ExportedTypes
                .Where(x => x.FullName.Contains("BurgerFactories.FactoryMethods") && x.IsInterface == false);
        }

        /// <summary>
        /// 從組件中找出所有的原料工廠
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Type> _InitIngredientFactories()
        {
            return Assembly
                .GetExecutingAssembly()
                .ExportedTypes
                .Where(x => x.FullName.Contains("IngredientFactories") && x.IsInterface == false);
        }

        /// <summary>
        /// 根據漢堡類別，取得對應的漢堡工廠
        /// </summary>
        /// <param name="burgerType"></param>
        /// <returns></returns>
        private static IBurgerFactory _GetBurgerFactoy(BurgerType burgerType)
        {
            var factoryType = _burgerFactories
                .Where(x => x.Name.Contains(string.Format("{0}BurgerFactory", burgerType.ToString())))
                .SingleOrDefault();

            if (factoryType != null)
            {
                return Activator.CreateInstance(factoryType) as IBurgerFactory;
            }
            else
            {
                throw new ArgumentException("No factory can make this type of burger: {0}", burgerType.ToString());
            }
        }

        /// <summary>
        /// 根據原料類別，取得對應的原料工廠
        /// </summary>
        /// <param name="burgerType"></param>
        /// <returns></returns>
        private static IIngredientFactory _GetIngredientFactoy(ShopType shopType)
        {
            var factoryType = _ingrdientFactories
                .Where(x => x.Name.Contains(string.Format("{0}IngredientFactory", shopType.ToString())))
                .SingleOrDefault();

            if (factoryType != null)
            {
                return Activator.CreateInstance(factoryType) as IIngredientFactory;
            }
            else
            {
                throw new ArgumentException("No factory can offer ingredient to this type of shop: {0}", shopType.ToString());
            }
        }
        #endregion
    }
}
