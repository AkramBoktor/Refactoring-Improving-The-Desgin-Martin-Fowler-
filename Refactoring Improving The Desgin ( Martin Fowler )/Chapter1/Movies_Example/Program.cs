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

            NoLoaclVariables noLoaclVariables = new NoLoaclVariables();
            noLoaclVariables.Main();

            LocalVariables localVariables = new LocalVariables();
            localVariables.Main();

            InlineMethod inlineMethod = new InlineMethod();
            inlineMethod.Main();

            ReplaceTempWithQuery replaceTempWithQuery = new ReplaceTempWithQuery();
            replaceTempWithQuery.Main();

            ExampleExtractMethod exampleExtractMethod = new ExampleExtractMethod();
            exampleExtractMethod.Main();

            Substitute_Algorithm substitute_Algorithm = new Substitute_Algorithm();
            substitute_Algorithm.Main();
            #endregion
        }
    }
}
