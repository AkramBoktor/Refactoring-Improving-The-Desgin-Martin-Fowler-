using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
   public class Movie
    {
        private Price price;
        private string title;
        public Movie(string _title , int _priceCode)
        {
            title = _title;
            SetPriceCode(_priceCode);
        }

        public int GetPriceCode()
        {
            return price.getPriceCode();
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
            if (_priceCode == 0) price = new ChildernPrice();
            else if (_priceCode == 1) price = new RegularPrice();
            else if (_priceCode == 2) price = new NewReleasePrice();
            else throw new ArgumentException("Incorrect price code");
        }

        //TODO We will replace the if statment with polymorphysim condition 
        public double GetTotalCharge(int daysRented)
        {
            return price.GetCharge(daysRented);
        }

        public int GetTotalFrequentDays(int days)
        {
            return price.GetFrequentPoint(days);
        }
    }
}
