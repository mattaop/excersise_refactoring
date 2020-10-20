using System;
using RefactoringSample1.Prices;

namespace RefactoringSample1
{
	public class Movie
	{
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		public const int CHILDRENS = 2;
		public const int INTERNATIONAL = 3;

		private string _title;
		private Price _price;
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="title">string title of the movie</param>
		/// <param name="priceCode">int price code responding to Regular, New release, Childrens and International</param>
		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}
		/// <summary>
		/// Sets the _price with a price object corresponding to the right price code
		/// </summary>
		/// <param name="PriceCode">int price code responding to Regular, New release, Childrens and International</param>
		public void SetPriceCode(int PriceCode)
        {
			_price = PriceCode switch
			{
				NEW_RELEASE => new NewReleasePrice(),
				CHILDRENS => new ChildrensPrice(),
				INTERNATIONAL => new InternationalPrice(),
				_ => new RegularPrice()

			};
        }
		/// <summary>
		/// Get the price code. 
		/// Is not used at the moment
		/// </summary>
		/// <returns>int price code</returns>
		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}
		/// <summary>
		/// Get charge from the corresponding price object, stored in _price
		/// </summary>
		/// <param name="daysRented">int number of days the movie is rented</param>
		/// <returns>double charge of the rent</returns>
		public double GetCharge(int daysRented)
        {
			return _price.GetCharge(daysRented);
        }
		/// <summary>
		/// Get frequent points from the corresponding price object, stored in _price
		/// </summary>
		/// <param name="daysRented">int number of days the movie is rented</param>
		/// <returns>int frequent points of the rent</returns>
		public int GetFrequentPoints(int daysRented)
		{
			return _price.GetFrequentPoints(daysRented);
		}
		/// <summary>
		/// Get the title of the movie
		/// </summary>
		/// <returns>string title of the movie</returns>
		public string GetTitle()
		{
			return _title;
		}
	}
}
