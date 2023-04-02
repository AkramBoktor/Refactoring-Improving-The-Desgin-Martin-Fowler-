using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
   public class ReplaceTempWithQuery
    {
        public void Main()
        {
            Console.WriteLine(CalculateMethod());
            Console.WriteLine(CalculateMethodAfter());
        }

        #region Before Replace Temp With Query
        // Extract the expression into a method . replace all reference to the temp with the new method .
        // the new method can then br used in other methods.
        public double CalculateMethod()
        {
            ///// Before Replace Temp With Query
            Console.WriteLine("*** Before Replace Temp With Query ***");

            double basePrice = 10 * 5;
            if (basePrice > 1000)
                return basePrice * 10;
            else
                return basePrice * 0;
        }
        #endregion

        #region After Replace Temp With Query
        // this simple example case extract the method (110) is trivially easy 
        public double CalculateMethodAfter()
        {
            ///// Before Replace Temp With Query
            Console.WriteLine("*** After Replace Temp With Query ***");


            if (basePrice() > 1000)
                return basePrice() * 10;
            else
                return basePrice() * 0;
        }

        private double basePrice()
        {
            return 10 * 5;

        }
        #endregion
    }
}
