using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	public class Customer
	{
		private string _name;
		private List<Rental> _rentals = new List<Rental>();
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">string name of customer</param>
		public Customer(string name)
		{
			_name = name;
		}
		/// <summary>
		/// Add rental-objects to customer in _rentals list
		/// </summary>
		/// <param name="rent">Rental new rental-object</param>		
		public void AddRental(Rental rent)
		{
			_rentals.Add(rent);
		}
		/// <summary>
		/// Get name of customer
		/// </summary>
		/// <returns>string name of customer</returns>
		public string GetName()
		{
			return _name;
		}
		/// <summary>
		/// Get total charge of all rentals
		/// </summary>
		/// <returns>double sum of rentals charges </returns>
		public double GetTotalCharge()
		{
			double result = 0;

			foreach (Rental rental in _rentals)
			{
				result += Rental.GetCharge(rental);
			}

			return result;
		}
		/// <summary>
		/// Get total frequent points of all rentals
		/// </summary>
		/// <returns>int sum of all frequent points</returns>
		public int GetFrequentPoints()
		{
			int result = 0;

			foreach (Rental rental in _rentals)
			{
				result += Rental.GetFrequentPoints(rental);
			}

			return result;
		}

		/// <summary>
		/// Get a string statement explaining the amount owed and the frequent points earned for the rental
		/// </summary>
		/// <returns>string statement with charge and frequent points</returns>
		public string Statement()
		{
			var result = $"Rental Record for {GetName()}\n";

			foreach (Rental rental in _rentals) 
			{ 
				//show figures for this rental
				result += $"\t{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}\n";
            }

            //add footer lines
            result += $"Amount owed is {GetTotalCharge()}\n";
			result += $"You earned {GetFrequentPoints()} frequent renter points";
			return result;
		}

		/// <summary>
		/// Get a HTML statement explaining the amount owed and the frequent points earned for the rental
		/// </summary>
		/// <returns>HTML statement with charge and frequent points</returns>
		public string HtmlStatement()
		{
			var result = $"<h1>Rental Record for {GetName()}</h1>";

			foreach (Rental rental in _rentals)
			{
				//show figures for this rental
				result += $"<p>{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}</p>";
			}

			//add footer lines
			result += $"<p>Amount owed is {GetTotalCharge()}</p>";
			result += $"<p>ou earned {GetFrequentPoints()} frequent renter points</p>";
			return result;
		}
	}
}
