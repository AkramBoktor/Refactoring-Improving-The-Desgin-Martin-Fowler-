using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
   public class ExampleExtractMethod
    {
        public void Main()
        {
            Console.WriteLine("ExampleExtractMethod " + Price());
            Console.WriteLine("ExampleExtractMethod " + PriceAfter());
        }


        #region Before Extract Method
        public double Price()
        {
            return 10 * 5 - Math.Max(0, 10 - 500) * 5 * 0.05 + Math.Min(10 * 5 * 0.1, 1000);
        }
        #endregion

        #region With Extract Method 

        public double PriceAfter()
        {
            return basePrice() - quantityPrice() + shipping();


        }

        private double basePrice()
        {
            return 10 * 5;
        }

        private double quantityPrice()
        {
           return Math.Max(0, 10 - 500) * 5 * 0.05;
        }
        private double shipping()
        {
            return Math.Min(10 * 5 * 0.1, 1000);
        }
        #endregion
    }
}
