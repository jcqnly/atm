using System;
using System.Collections.Generic;
using System.Text;

namespace atm.Classes
{
	public class Deposit
	{
		public decimal Amount { get; set; }
		public decimal Balance { get; set; }

		public Deposit(decimal amount)
		{
			Amount = amount;
		}

		/// <summary>
		/// Check if a deposit amount is negative
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public bool CheckIfDepositIsNegative(decimal amount)
		{
			if (amount < 0) return false;

			return true;
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
			return total;
		}
	}
}
