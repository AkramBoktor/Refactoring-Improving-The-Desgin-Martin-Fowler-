using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter7_moving_features_between_objects
{
    public class ExtractClass
    {
        public void Main()
        {

        }

        #region Before extract class 

        public class Person
        {
            private string _name;
            private string _officeAreaCode;
            private string _officeNumber;
            public string getName()
            {
                return _name;
            }
            public string getTelephoneNumber()
            {
                return ("(" + _officeAreaCode + ")") + _officeNumber;
            }
            public string getOfficeAreaCode()
            {
                return _officeAreaCode;
            }
            public string getOfficeNumber()
            {
                return _officeNumber;
            }
            public void setOfficeAreaCode(string args)
            {
                _officeAreaCode = args;
            }
            public void setOfficeNumber(string args)
            {
                _officeNumber = args;
            }

        }
        #endregion

        #region After Move Method 
        public class TelephoneNumber
        {
            private string _areaCode;
            private string _Number;

            public string getAreaCode()
            {
                return _areaCode;
            }
            public void setNumber(string args)
            {
                _Number = args;
            }

            public string getNumber()
            {
                return _Number;
            }
            public void setAreaCode(string args)
            {
                _areaCode = args;
            }
            public string getTelephoneNumber()
            {
                return ("(" + _areaCode + ")") + _Number;
            }
        }

        /* By use move field and move method */
        public class personAfter
        {
            private TelephoneNumber telephoneNumber = new TelephoneNumber();
            private string _name;
            public string getName()
            {
                return _name;
            }
            public string getTelephoneNumber()
            {
                return telephoneNumber.getTelephoneNumber();
            }
        }
        #endregion
    }
}
