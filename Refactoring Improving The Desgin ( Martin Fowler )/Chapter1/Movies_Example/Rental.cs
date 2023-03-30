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


        //TODO We will replace the if statment with polymorphysim condition 
        public double GetAmount(int priceCode)
        {
            return movie.GetTotalCharge(GetDaysRented());
        }

        public int getFrequentRenterPoint()
        {
            return movie.GetTotalFrequentDays(GetDaysRented());
        }
    }
}
