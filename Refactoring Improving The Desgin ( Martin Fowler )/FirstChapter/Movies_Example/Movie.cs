using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
   public class Movie
    {
        private int priceCode;
        private string title;
        public Movie(string _title , int _priceCode)
        {
            title = _title;
            priceCode = _priceCode;
        }

        public int GetPriceCode()
        {
            return priceCode;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string _title)
        {
            title = _title;
        }

        public void SetPriceCode(int _priceCode)
        {
            priceCode = _priceCode;
        }

        //TODO We will replace the if statment with polymorphysim condition 
        public double GetTotalCharge(int daysRented)
        {
            double thisAmount = 0;
            if (priceCode == 0)
            {
                thisAmount += 2;
                if (daysRented > 2 )
                    thisAmount += (daysRented - 2) * 1.5;
            }
            else if (priceCode == 1)
            {
                thisAmount += 1.5;
                if (daysRented > 3)
                    thisAmount += (daysRented - 3) * 1.5;
            }
            else
            {
                thisAmount += (daysRented * 3);
            }
            return thisAmount;
        }

        public int GetTotalFrequentDays(int days)
        {
            if ((GetPriceCode() == (int)CategoriesMovies.NEW_RELEASE)
                  && days > 1)
                return 2;
            else
                return 1;
        }
    }
}
