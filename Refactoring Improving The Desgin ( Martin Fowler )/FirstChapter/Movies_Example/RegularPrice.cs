using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
    public class RegularPrice : Price
    {
        public override int getPriceCode()
        {
            return (int)CategoriesMovies.REGULAR;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
                result += (daysRented - 2) * 1.5;

            return result;
        }
    }
}
