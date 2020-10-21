using System;
using Xunit;
using System.Collections.Generic;

namespace RefactoringSample1.Tests
{
    public class MovieTest
    {
        private static List<Movie> _movies = new List<Movie>
            {
                new Movie("The Lion King", Movie.CHILDRENS),
                new Movie("Joker", Movie.NEW_RELEASE),
                new Movie("Avengers: Endgame", Movie.REGULAR),
                new Movie("Parasite", Movie.INTERNATIONAL)
            };

        [Theory]
        [MemberData(nameof(GetChargeTestData))]
        public void GetCharge(Movie movie, int daysRented, double charge)
        {
            Assert.Equal(movie.GetCharge(daysRented), charge);
        }

        [Theory]
        [MemberData(nameof(GetFrequentPointsTestData))]
        public void GetFrequentPoints(Movie movie, int daysRented, int points)
        {
            Assert.Equal(movie.GetFrequentPoints(daysRented), points);
        }
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

    }
}
