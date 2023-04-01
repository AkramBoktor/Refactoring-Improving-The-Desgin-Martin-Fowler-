using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
    public class LocalVariables
    {
        public void Main()
        {
            printOwing(100);
            printOwingRefactor(250);
        }

        #region Before Extract Method
        // this simple example case extract the method (110) is trivially easy 
        public void printOwing(double amount)
        {
            ///// Brfore extract the method 
            Console.WriteLine("*** LoaclVariables Banner ***");

            Console.WriteLine("LoaclVariables name " + "Akram");
            Console.WriteLine("LoaclVariables Amount " + amount);
        }
        #endregion

        #region After Extract Method
        // this simple example case extract the method (110) is trivially easy 
        public void printOwingRefactor(double amount)
        {
            printBanner();

            printDetails(amount);
        }

        private void printBanner()
        {
            Console.WriteLine("***After LoaclVariables Banner ***");

        }

        private void printDetails(double amount)
        {
            Console.WriteLine("After LoaclVariables name " + "Akram");
            Console.WriteLine("After LoaclVariables Amount " + amount);
        }
        #endregion
    }
}
