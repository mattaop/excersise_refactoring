using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1.Prices
{
    class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }
        public override double GetCharge(int daysRented)
        {
            return  daysRented * 3;
        }
        public override int GetFrequentPoints(int daysRented)
        {
            // add frequent renter points
            var frequentRenterPoints = 1;
            // add bonus for a two day new release rental
            if (daysRented > 1)
                frequentRenterPoints++;
            return frequentRenterPoints;
        }
    }
}
