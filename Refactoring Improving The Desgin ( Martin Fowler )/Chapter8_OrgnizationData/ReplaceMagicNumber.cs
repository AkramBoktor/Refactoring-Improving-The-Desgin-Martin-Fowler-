using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter8_OrgnizationData
{
  public class ReplaceMagicNumber
    {
        public void Main()
        {
            /*  Before Replace Magic Number */
            Symbolic_Constant symbole = new Symbolic_Constant();
            Console.WriteLine("ReplaceMagicNumber "+symbole.potentialEnergy(1, 2));

            /* After Replace Magic Number */
            Symbolic_ConstantAfter symboleAfter = new Symbolic_ConstantAfter();
            Console.WriteLine("ReplaceMagicNumber "+symboleAfter.potentialEnergy(1, 2));
        }

        #region Before Replace Magic Number

        public class Symbolic_Constant
        {
           public double potentialEnergy(double mass , double height)
            {
                return mass * 5 * height;
            }
        }
        #endregion

        #region After Replace Magic Number
        public class Symbolic_ConstantAfter
        {
            private const int weight = 5;
            public double potentialEnergy(double mass, double height)
            {
                return mass * weight * height;
            }
        }
        #endregion
    }
}
