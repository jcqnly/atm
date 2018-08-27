using System;
using System.Collections.Generic;
using System.Text;

namespace atm.Classes
{
	public class Deposit
	{

		/// <summary>
		/// Check if a deposit amount is negative
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public void CheckIfDepositIsNegative(decimal amount, decimal balance)
		{
			if (amount < 0)
			{
				Console.WriteLine("Sorry, you cannot deposit a negative number.");
			}
			else
			{
				AddDepositToBalance(amount, balance);
			}
		}

		/// <summary>
		/// Adds amount to running balance
		/// </summary>
		/// <param name="amount">user amount to deposit</param>
		/// <param name="balance">declared within Program.cs</param>
		/// <returns></returns>
		public decimal AddDepositToBalance(decimal amount, decimal balance)
		{
			decimal total = amount + balance;
			Console.WriteLine($"Your balance is {total}");
			return total;
		}
	}
}
