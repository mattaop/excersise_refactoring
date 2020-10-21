using System;
using Xunit;
using System.Collections.Generic;

namespace RefactoringSample1.Tests
{
    public class MovieTest
    {
        /// <summary>
        /// Test that the Movie class gets the correct charge given the days the movie is rented
        /// </summary>
        /// <param name="movie">Movie object</param>
        /// <param name="daysRented">int number of days rented</param>
        /// <param name="charge">double correct charge for comparison</param>
        [Theory]
        [MemberData(nameof(GetChargeTestData))]
        public void GetCharge(Movie movie, int daysRented, double charge)
        {
            Assert.Equal(movie.GetCharge(daysRented), charge);
        }
        /// <summary>
        /// Test that the Movie class gets the correct number of frequent points given the days the movie is rented
        /// </summary>
        /// <param name="movie">Movie object</param>
        /// <param name="daysRented">int number of days rented</param>
        /// <param name="points">int correct number of frequent points for comparison</param>
        [Theory]
        [MemberData(nameof(GetFrequentPointsTestData))]
        public void GetFrequentPoints(Movie movie, int daysRented, int points)
        {
            Assert.Equal(movie.GetFrequentPoints(daysRented), points);
        }
        /// <summary>
        /// Test that the Movie object is assigned the correct title
        /// </summary>
        /// <param name="movie">Movie object</param>
        /// <param name="title">string correct title for comparison</param>
        [Theory]
        [MemberData(nameof(GetTitleTestData))]
        public void GetTitle(Movie movie, string title)
        {
            Assert.Equal(movie.GetTitle(), title);
        }
        /// <summary>
        /// Test data with input and output for the GetCharge test function
        /// </summary>
        /// <returns>TheoryData object with Movie movie, int daysRented, double correctCharge</returns>
        public static TheoryData<Movie, int, double> GetChargeTestData()
        {
            return new TheoryData<Movie, int, double>
            {
                 { new Movie("The Lion King", Movie.CHILDRENS), 3, 1.5 },
                 { new Movie("Joker", Movie.NEW_RELEASE), 2, 6},
                 { new Movie("Avengers: Endgame", Movie.REGULAR), 3, 3.5  },
                 { new Movie("Parasite", Movie.INTERNATIONAL), 5, 3 }

            };
        }
        /// <summary>
        /// Test data with input and output for the GetFrequenbtPoints test function
        /// </summary>
        /// <returns>TheoryData object with Movie movie, int daysRented, int correctPoints</returns>
        public static TheoryData<Movie, int, int> GetFrequentPointsTestData()
        {
            return new TheoryData<Movie, int, int>
            {
                 { new Movie("The Lion King", Movie.CHILDRENS), 3, 1 },
                 { new Movie("Joker", Movie.NEW_RELEASE), 2, 2},
                 { new Movie("Avengers: Endgame", Movie.REGULAR), 3, 1  },
                 { new Movie("Parasite", Movie.INTERNATIONAL), 5, 1 }
            };
        }
        /// <summary>
        /// Test data with input and output for the GetTitle test function
        /// </summary>
        /// <returns>TheoryData object with Movie movie, string title</returns>
        public static TheoryData<Movie, string> GetTitleTestData()
        {
            return new TheoryData<Movie, string>
            {
                { new Movie("The Lion King", Movie.CHILDRENS), "The Lion King" },
                { new Movie("Joker", Movie.NEW_RELEASE), "Joker"},
                { new Movie("Avengers: Endgame", Movie.REGULAR), "Avengers: Endgame" },
                { new Movie("Parasite", Movie.INTERNATIONAL), "Parasite"}
            };
        }

    }
}
