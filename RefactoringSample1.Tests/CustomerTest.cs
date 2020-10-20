using System;
using Xunit;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace RefactoringSample1.Tests
{
    public class CustomerTest
    {
        private static List<Movie> _movies = new List<Movie>
            {
                new Movie("The Lion King", Movie.CHILDRENS),
                new Movie("Joker", Movie.NEW_RELEASE),
                new Movie("Avengers: Endgame", Movie.REGULAR)
            };
        private static List<Rental> _rentals = new List<Rental>
            {
                new Rental(_movies[0],1),
                new Rental(_movies[0],2),
                new Rental(_movies[0],3),
                new Rental(_movies[1],1),
                new Rental(_movies[1],2),
                new Rental(_movies[1],3),
            };

        [Theory]
        [MemberData(nameof(StatementTestData))]
        public void Statement(Rental rental1, Rental rental2, double totalAmt, int freqPoints)
        {
            var customer = new Customer("Mathias");
            customer.AddRental(rental1);
            customer.AddRental(rental2);
            var statement = customer.Statement();
            var totalAmount = customer.GetTotalCharge();
            var frequentRenterPoints = customer.GetFrequentPoints();
            Assert.Equal(totalAmount, totalAmt);
            Assert.Equal(frequentRenterPoints, freqPoints);
        }
        [Theory]
        [MemberData(nameof(StatementTestData))]
        public void HtmlStatement(Rental rental1, Rental rental2, double totalAmt, int freqPoints)
        {
            var customer = new Customer("Mathias");
            customer.AddRental(rental1);
            customer.AddRental(rental2);
            var statement = customer.HtmlStatement();
            var totalAmount = customer.GetTotalCharge();
            var frequentRenterPoints = customer.GetFrequentPoints();
            Assert.Equal(totalAmount, totalAmt);
            Assert.Equal(frequentRenterPoints, freqPoints);
        }
        public static TheoryData<Rental, Rental, double, int> StatementTestData()
        {
            return new TheoryData<Rental, Rental, double, int> {
                { new Rental(_movies[0], 4), new Rental(_movies[1], 2), 9, 3 },
                { new Rental(_movies[2], 2), new Rental(_movies[0], 3), 3.5, 2 },
                { new Rental(_movies[1], 2), new Rental(_movies[2], 3), 9.5, 3 },
                { new Rental(_movies[1], 4), new Rental(_movies[1], 3), 21, 4 }
            };
        }
    }
}
