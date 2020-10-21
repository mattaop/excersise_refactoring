using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1.Prices
{
    class InternationalPrice : Price
    {
        //public override int GetPriceCode()
        //{
        //    return Movie.INTERNATIONAL;
        //}

        /// <summary>
        /// Get charge of movies categorized as international
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge of the rental</returns>
        public override double GetCharge(int daysRented)
        {
            double thisAmount = 3;
            return thisAmount;
        }
    }
}
