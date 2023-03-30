using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
    public abstract class Price
    {
        public abstract int getPriceCode();

        public abstract double GetCharge(int daysRented);

        public virtual int GetFrequentPoint(int days)
        {
                return 1;
        }
              
    }
}
