using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
    public class ChildernPrice : Price
    {
        public override int getPriceCode()
        {
            return (int)CategoriesMovies.CHILDERNS;
        }

        public override double GetCharge(int daysRented)
        {
            double result  = 1.5;
            if (daysRented > 2)
                result += (daysRented - 3) * 1.5;

            return result;
        }
    }
}
