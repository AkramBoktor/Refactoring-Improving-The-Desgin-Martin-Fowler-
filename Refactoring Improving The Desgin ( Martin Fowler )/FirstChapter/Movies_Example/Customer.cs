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
            double totalAmount = 0;
            int frequentRenterPoint = 0;
            int index = 0;
            var retnals = rentals;
            string result = "Rental Record " + GetName() + "\n";
            while (index <= rentals.Count)
            {
                Rental each = rentals[index];

                // add frequent renter point
                frequentRenterPoint++;
                if ((each.GetMovie().GetPriceCode() == (int)CategoriesMovies.NEW_RELEASE)
                    && each.GetDaysRented() > 1) frequentRenterPoint++;

                // Show figured for this rental
                result += "\t" + each.GetMovie().GetTitle() + "\t" + 
                    each.GetAmount(each.GetMovie().GetPriceCode()).ToString()+ "\n";
                totalAmount += each.GetAmount(each.GetMovie().GetPriceCode());
                index++;
            }

            result += "Amount owed is " + totalAmount.ToString() + "\n"
                       + "you earned " + frequentRenterPoint.ToString()
                       + "Frequesnt enter point";

            return result;
        }

      
    }
}