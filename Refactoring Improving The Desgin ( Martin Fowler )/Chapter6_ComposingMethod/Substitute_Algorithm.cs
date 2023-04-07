using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter6
{
    public class Substitute_Algorithm
    {
        public void Main()
        {
            Console.WriteLine(FoundPerson(new string[] { "Don","test","test3" }));
            Console.WriteLine(FoundPersonAfter(new string[] { "John", "test", "test3" }));
        }

        #region Before Substitute_Algorithm  
        
        public string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return people[i];
                }
                if (people[i].Equals("John"))
                {
                    return people[i];
                }
                if (people[i].Equals("Kent"))
                {
                    return people[i];
                }
            }
            return string.Empty;
        }
        #endregion

        #region After Substitute_Algorithm 
        public string FoundPersonAfter(string[] people)
        {
            List<string> candiares = new List<string> { "Don", "John", "Kent" };
            for (int i = 0; i < people.Length; i++)
            {
                if (candiares.Contains(people[i]))
                    return people[i];
            }
            return string.Empty;
        }
        #endregion
    }
}

