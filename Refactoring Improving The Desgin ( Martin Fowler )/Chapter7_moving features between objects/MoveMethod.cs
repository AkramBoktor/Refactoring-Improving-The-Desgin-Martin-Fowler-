using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
   public class MoveMethod
    {
        public void Main()
        {
            
        }

        #region Before Move Method 

   public class Acount 
   {
            private AcountType _type = new AcountType();
            private int _daysOverdrawn;

            double overdraftCharge()
            {
                    if (_type.isPremium())
                        return _daysOverdrawn * 1.75;
                    else
                    {
                        double result = 10;
                        if (_daysOverdrawn > 7) result += _daysOverdrawn - 7  *0.85;
                        return result;
                    }
                }

            double bankCharge()
            {
                double result = 4.5;
                if (_daysOverdrawn > 0) result += overdraftCharge();
                return result;
            }
        }
        public class AcountType 
       {
                private int _daysOverdrawn;

                public double overdraftCharge(int daysOverdrawn)
                {
                    if (isPremium())
                    {
                        double result = 10;
                        if (daysOverdrawn > 7) result += daysOverdrawn -7  * 0.85;
                        return result;
                    }
                    else return _daysOverdrawn * 1.75;
                }

                public bool isPremium()
                {
                    return true;
                }
        }
        #endregion

        #region After Move Method 
        public class AcountAfter
        {
            private AcountType _type = new AcountType();
            private int _daysOverdrawn;

            double overdraftCharge()
            {
                return _type.overdraftCharge(_daysOverdrawn);
            }

            double bankCharge()
            {
                double result = 4.5;
                if (_daysOverdrawn > 0) result += _type.overdraftCharge(_daysOverdrawn);
                return result;
            }
        }
        #endregion
    }
}
