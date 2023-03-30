using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
   public class Extract_Method
    {
        public void Main()
        {
            printOwing(100);
            printOwingRefactor(1010);
        }


        #region Before Extract Method
        public void printOwing(double amount)
        {
            printBanner();
            Console.WriteLine("name " + "Akram");
            Console.WriteLine("Amount " + amount);
        }

        private void printBanner()
        {
            Console.WriteLine("*** Banner ***");
        }
        #endregion

        #region With Extract Method 

        public void printOwingRefactor(double amount)
        {
            printBannerRefactor();
            printDetailsRefactor(amount);


        }

        private void printBannerRefactor()
        {
            Console.WriteLine("*** Banner Refactor ***");
        }

        private void printDetailsRefactor(double amount)
        {
            Console.WriteLine("name Refactor " + "Akram Refactor");
            Console.WriteLine("Amount Refactor " + amount);
        }
        #endregion
    }


}


