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
	}
}
