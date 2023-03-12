using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_Improving_The_Desgin___Martin_Fowler__.FirstChapter.Movies_Example
{
    public class Customer
    {
        private string name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string _name)
        {
            name = _name;
        }

        public void addRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string GetName()
        {
            return name;
        }

        public string statement()
        {
            int frequentRenterPoint = 0;
            int index = 0;
            var retnalsList = rentals;
            string result = "Rental Record " + GetName() + "\n";
            while (index <= retnalsList.Count)
            {
                Rental each = retnalsList[index];

                // add frequent renter point
                frequentRenterPoint += each.getFrequentRenterPoint();
               
                // Show figured for this rental
                result += "\t" + each.GetMovie().GetTitle() + "\t" + 
                    each.GetAmount(each.GetDaysRented()).ToString()+ "\n";
                index++;
            }

            result += "Amount owed is " + GetToltalAmount() + "\n"
                       + "you earned " + frequentRenterPoint.ToString()
                       + "Frequesnt enter point";

            return result;
        }


        private double GetToltalAmount()
        {
            var retnalsList = rentals;
            int index = 0;
            double result = 0;
            while (index <= retnalsList.Count)
            {
                Rental each = retnalsList[index];
                result += each.GetAmount(each.GetMovie().GetPriceCode());
            }

            return result;
        }
    }
}