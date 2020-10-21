using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RefactoringSample1.Prices
{
    class ChildrensPrice : Price
    {
        //public override int GetPriceCode()
        //{
        //    return Movie.CHILDRENS;
        //}

        /// <summary>
        /// Get charge of movies categorized as childrens
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge of the rental</returns>
        public override double GetCharge(int daysRented)
        {
            double thisAmount = 1.5;
            if (daysRented > 3)
                thisAmount += (daysRented - 3) * 1.5;
            return thisAmount;
        }
    }
}
