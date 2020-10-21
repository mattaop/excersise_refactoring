using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1.Prices
{
    abstract class Price
    {
        /// <summary>
        /// Get the price code
        /// </summary>
        /// <returns>int price code</returns>
        // abstract public int GetPriceCode();

        /// <summary>
        /// Get the charge of the price code given the number of days rented
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge of the rent</returns>
        abstract public double GetCharge(int daysRented);
        /// <summary>
        /// Get the frequent points related the the price code
        /// Default is 1 across the price codes
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>int number of frequent points (1 is default)</returns>
        public virtual int GetFrequentPoints(int daysRented)
        {
            return 1;
        }
    }
}
