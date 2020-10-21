using System;
using Xunit;
using System.Collections.Generic;

namespace RefactoringSample1.Tests
{
    public class RentalTest
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
        /// Test that the Rental class gets the correct earned frequent points of the rental
        /// </summary>
        /// <param name="rental">Rental object of which the frequent points are calculated</param>
        /// <param name="points">The correct output for comparison</param>
        [Theory]
        [MemberData(nameof(FrequentPointsTestData))]
        public void GetFrequentPoints(Rental rental, int points)
        {
            Assert.Equal(Rental.GetFrequentPoints(rental), points);
        }

        /// <summary>
        /// Test that the Rental class gets the correct charge of the rental
        /// </summary>
        /// <param name="rental">Rental object of which the charge is calulated</param>
        /// <param name="charge">The correct output for comparison</param>
        [Theory]
        [MemberData(nameof(GetChargeRentalTestData))]
        public void GetCharge(Rental rental, double charge)
        {
            Assert.Equal(Rental.GetCharge(rental), charge);
        }

        /// <summary>
        /// Test data with input and output to GetFrequentPoints test function
        /// </summary>
        /// <returns>TheoryData object with rental, int</returns>
        public static TheoryData<Rental, int> FrequentPointsTestData()
        {
            return new TheoryData<Rental, int>
            {
                { new Rental(_movies[0],1),1 },
                { new Rental(_movies[0],2),1 },
                { new Rental(_movies[0],3),1 },
                { new Rental(_movies[1],1),1 },
                { new Rental(_movies[1],2),2 },
                { new Rental(_movies[1],3),2 },
                { new Rental(_movies[2],1),1 },
                { new Rental(_movies[2],2),1 },
                { new Rental(_movies[2],3),1 },


            };
        }

        /// <summary>
        /// Test data with input and output to GetChargeRental test function
        /// </summary>
        /// <returns>TheoryData object with rental, double</returns>
        public static TheoryData<Rental, double> GetChargeRentalTestData()
        {
            return new TheoryData<Rental, double>
            {
                { new Rental(_movies[2], 1),2 },
                { new Rental(_movies[2], 2),2 },
                { new Rental(_movies[2], 3),3.5 },
                { new Rental(_movies[2], 4),5 },
                { new Rental(_movies[0], 3),1.5 },
                { new Rental(_movies[0], 4),3 },
                { new Rental(_movies[1], 2),6 },
                { new Rental(_movies[1], 3),9 },
                { new Rental(_movies[3], 1),3 },
                { new Rental(_movies[3], 2),3 },
                { new Rental(_movies[3], 3),3 },
            };
        }
    }
}
