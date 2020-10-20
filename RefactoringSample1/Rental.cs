using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	public class Rental
	{
		private Movie _movie;
		private int _daysRented;
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="movie">Movie object</param>
		/// <param name="daysRented">int number of days the movie is rented</param>
		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}
		/// <summary>
		/// Gets number of days the movie is rented
		/// </summary>
		/// <returns>int number of days the movie is rented</returns>
		public int GetDaysRented()
		{
			return _daysRented;
		}
		/// <summary>
		/// Gets Movie object
		/// </summary>
		/// <returns>Movie object</returns>
		public Movie GetMovie()
		{
			return _movie;
		}
		/// <summary>
		/// Get charge of the given rental
		/// </summary>
		/// <param name="rental">Rental object</param>
		/// <returns>double charge of the rental</returns>
        public static double GetCharge(Rental rental)
        {
			return rental.GetMovie().GetCharge(rental.GetDaysRented());

		}
		/// <summary>
		/// Get frequent points of the given rental
		/// </summary>
		/// <param name="rental">Rental object</param>
		/// <returns>int frequent points of the rental</returns>
        public static int GetFrequentPoints(Rental rental)
        {
			return rental.GetMovie().GetFrequentPoints(rental.GetDaysRented());
		}
    }
}
