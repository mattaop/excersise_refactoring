using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1.Prices
{
    class InternationalPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.INTERNATIONAL;
        }
        public override double GetCharge(int daysRented)
        {
            double thisAmount = 3;
            return thisAmount;
        }
    }
}
