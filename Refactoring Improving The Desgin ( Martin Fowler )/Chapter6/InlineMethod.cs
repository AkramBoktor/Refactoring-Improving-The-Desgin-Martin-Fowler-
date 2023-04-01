using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
   public class InlineMethod
    {
        public void Main()
        {
            Console.WriteLine("inline method "+ getRating());
            Console.WriteLine("inline method "+getRatingAfter());
        }

        #region Before Inline Method
        // *Inline Method** :  A method's body is just as clear as its name.
        // put the method's body into the body of its callers and remove the method .
        public int getRating()
        {
            int rate = 5;
            return (moreThanFiceLateDeliveries(rate)) ? 2 : 1;
        }

        private bool moreThanFiceLateDeliveries(int number)
        {
            return number > 5;
        }
        #endregion

        #region After Inline Method
        // *Inline Method** :  A method's body is just as clear as its name.
        // put the method's body into the body of its callers and remove the method .
        public int getRatingAfter()
        {
            int rate = 5;
            return (rate > 5) ? 2 : 1;
        }
        #endregion
    }
}
