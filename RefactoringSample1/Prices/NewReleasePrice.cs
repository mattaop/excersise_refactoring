using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1.Prices
{
    class NewReleasePrice : Price
    {
        //public override int GetPriceCode()
        //{
        //    return Movie.NEW_RELEASE;
        //}

        /// <summary>
        /// Get charge of movies categorized as new release
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge of the rental</returns>
        public override double GetCharge(int daysRented)
        {
            return  daysRented * 3;
        }

        /// <summary>
        /// Get frequent points of movies categorized as new release
        /// </summary>
        /// <param name="daysRented">int number fo days the movie is rented</param>
        /// <returns>int frequent points earned for the rental</returns>
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
