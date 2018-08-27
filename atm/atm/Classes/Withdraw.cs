using System;
using System.Collections.Generic;
using System.Text;

namespace atm.Classes
{
	public class Withdraw
	{
		public decimal Amount { get; set; }

		public Withdraw(decimal amount)
		{
			Amount = amount;
		}

		public bool CheckIfWithdrawIsGreaterThanBalance(decimal withdrawAmount, decimal balance)
		{
			if (withdrawAmount > balance) return false;

			return true;
		}

		public decimal WithdrawAmount(decimal withdrawAmount, decimal balance)
		{
			return balance - withdrawAmount;
		}

	}
}
