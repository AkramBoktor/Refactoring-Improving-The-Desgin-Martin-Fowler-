using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
   public class NewReleasePrice : Price
    {
        public override int getPriceCode()
        {
            return (int)CategoriesMovies.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequentPoint(int days)
        {
            return days > 1 ? 2 : 1; 
        }
    }
}
