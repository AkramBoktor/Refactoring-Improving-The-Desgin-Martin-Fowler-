using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.Chapter7_moving_features_between_objects
{
    public class InlineClass
    {
        
            public void Main()
            {
                /* Before Inline class */
                person martin = new person();
                martin.getOfficeTelephone().setAreaCode("782");

            /* After Inline class */
            personAfter martinAfter = new personAfter();
            martinAfter.setAreaCode("782");
        }

        #region Before Inline class 

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
            public class person
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
                public TelephoneNumber getOfficeTelephone()
                {
                    return telephoneNumber;
                }
            }
        #endregion

        #region After Inline class 

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
            public TelephoneNumber getOfficeTelephone()
            {
                return telephoneNumber;
            }

            public string getAreaCode()
            {
                return telephoneNumber.getAreaCode();
            }
            public void setAreaCode(string args)
            {
                telephoneNumber.setAreaCode(args);
            }

            public string getNumber()
            {
                return telephoneNumber.getNumber();
            }
            public void setNumber(string args)
            {
                telephoneNumber.setNumber(args);
            }
        }

        #endregion

    }

}
