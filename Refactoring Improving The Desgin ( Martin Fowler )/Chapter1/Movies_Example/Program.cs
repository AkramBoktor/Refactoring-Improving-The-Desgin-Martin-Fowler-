using Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Extract Method
            Extract_Method extract_Method = new Extract_Method();
            extract_Method.Main(); 
            #endregion
        }
    }
}
