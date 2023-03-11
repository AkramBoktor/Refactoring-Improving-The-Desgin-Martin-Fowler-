using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
    public class Rental
    {
        private int daysRented;

        private Movie movie;

        public Rental(int _daysRented , Movie _movie)
        {
            daysRented = _daysRented;
            movie = _movie;
        }
        public void SetDaysRented(int _daysRented)
        {
            daysRented = _daysRented;
        }
        public int GetDaysRented()
        {
            return daysRented;
        }

        public Movie GetMovie()
        {
            return movie;
        }


        public double GetAmount(int priceCode)
        {
            double thisAmount = 0;
            if (priceCode == 0)
            {
                thisAmount += 2;
                if (GetDaysRented() > 2)
                    thisAmount += (GetDaysRented() - 2) * 1.5;
            }
            else if (priceCode == 1)
            {
                thisAmount += 1.5;
                if (GetDaysRented() > 3)
                    thisAmount += (GetDaysRented() - 3) * 1.5;
            }
            else
            {
                thisAmount += (GetDaysRented() * 3);
            }
            return thisAmount;
        }

        public int getFrequentRenterPoint()
        {
            if ((GetMovie().GetPriceCode() == (int)CategoriesMovies.NEW_RELEASE)
                   && GetDaysRented() > 1)
                return 2;
            else
                return 1;
        }
    }
}
