using System;
using Xunit;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace RefactoringSample1.Tests
{
    public class CustomerTest
    {
        /// <summary>
        /// List of movies that can be added to a customer
        /// </summary>
        private static List<Movie> _movies = new List<Movie>
            {
                new Movie("The Lion King", Movie.CHILDRENS),
                new Movie("Joker", Movie.NEW_RELEASE),
                new Movie("Avengers: Endgame", Movie.REGULAR),
                new Movie("Parasite", Movie.INTERNATIONAL)

            };

        /// <summary>
        /// Test calculations in the statement function. 
        /// This includes the calculations of the total amount owed and the frequent points
        /// </summary>
        /// <param name="rental1">A rental object of a movie</param>
        /// <param name="rental2">Anpther rental of a movie</param>
        /// <param name="totalAmt">The total amount owed for the rentals</param>
        /// <param name="freqPoints">The frequent points earned for the rentals</param>
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

        /// <summary>
        /// Test calculations in the HtmlStatement function. 
        /// This includes the calculations of the total amount owed and the frequent points
        /// </summary>
        /// <param name="rental1">A rental object of a movie</param>
        /// <param name="rental2">Anpther rental of a movie</param>
        /// <param name="totalAmt">The total amount owed for the rentals</param>
        /// <param name="freqPoints">The frequent points earned for the rentals</param>
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

        /// <summary>
        /// Test data for both the statement functions:
        /// rental1, rental2, total amount, total frequent points
        /// </summary>
        /// <returns>TheoryData object with data to be tested</returns>
        public static TheoryData<Rental, Rental, double, int> StatementTestData()
        {
            return new TheoryData<Rental, Rental, double, int> {
                { new Rental(_movies[0], 4), new Rental(_movies[1], 2), 9, 3 },
                { new Rental(_movies[2], 2), new Rental(_movies[0], 3), 3.5, 2 },
                { new Rental(_movies[1], 2), new Rental(_movies[2], 3), 9.5, 3 },
                { new Rental(_movies[1], 4), new Rental(_movies[1], 3), 21, 4 },
                { new Rental(_movies[1], 4), new Rental(_movies[3], 3), 15, 3 }
            };
        }
    }
}
