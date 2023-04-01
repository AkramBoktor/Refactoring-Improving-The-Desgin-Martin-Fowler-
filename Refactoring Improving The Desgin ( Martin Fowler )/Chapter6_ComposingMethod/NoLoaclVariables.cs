using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
  public class NoLoaclVariables
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
            Console.WriteLine("*** NoLoaclVariables Banner ***");

            Console.WriteLine("NoLoaclVariables name " + "Akram");
            Console.WriteLine("NoLoaclVariables Amount " + amount);
        }
        #endregion

        #region After Extract Method
        // this simple example case extract the method (110) is trivially easy 
        public void printOwingRefactor(double amount)
        {
            printBanner();

            Console.WriteLine("After NoLoaclVariables name " + "Akram");
            Console.WriteLine("After NoLoaclVariables Amount " + amount);
        }

        private void printBanner()
        {
            Console.WriteLine("***After NoLoaclVariables Banner ***");

        }
        #endregion
    }
}
