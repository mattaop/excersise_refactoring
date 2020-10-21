using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1.Prices
{
    class RegularPrice : Price
    {
        //public override int GetPriceCode()
        //{
        //    return Movie.REGULAR;
        //}

        /// <summary>
        /// Get charge of movies categorized as regular
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge of the rental</returns>
        public override double GetCharge(int daysRented)
        {
            double thisAmount = 2;
            if (daysRented > 2)
                thisAmount += (daysRented - 2) * 1.5;
            return thisAmount;
        }
    }
}
