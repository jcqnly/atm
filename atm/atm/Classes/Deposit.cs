using System;
using System.Collections.Generic;
using System.Text;

namespace atm.Classes
{
	public class Deposit
	{
		public decimal Amount { get; set; }

		public Deposit(decimal amount)
		{
			Amount = amount;
		}

		public bool CheckIfDepositIsNegative(decimal amount)
		{
			if (amount < 0)
			{
				return false;
			}
			return true;
		}

		public decimal AddDepositToBalance(decimal amount)
		{

		}
	}
}
