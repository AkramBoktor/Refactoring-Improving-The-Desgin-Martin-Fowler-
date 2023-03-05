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
    }
}
