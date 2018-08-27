using atm.Classes;
using System;

namespace atm
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome!");
			//balance will be passed as a parameter to the Deposit, Withdraw and View Balance methods
			decimal balance = 5000M;
			Menu(balance);
		}

		public static void Menu(decimal balance)
		{
			Console.WriteLine("Select an option: \n" +
				"1. Deposit \n" +
				"2. Withdraw \n" +
				"3. View Balance \n" +
				"4. Exit \n");			
			Selection(balance);
		}

		/// <summary>
		/// Ask for user input for a deposit and withdraw option
		/// </summary>
		/// <param name="balance"></param>
		public static void Selection(decimal balance)
		{
			//need to declare this int outside of the try/catch/finally because of scoping
			int choice = 0;
			try
			{
				choice = int.Parse(Console.ReadLine());
			}
			catch (Exception)//hits if anything other than a number is entered, default in the switch statement will hit
			{
				Console.Clear();
				Console.WriteLine("Invalid selection");
			}
			finally
			{
				switch (choice)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("How much do you want to deposit?");
						decimal amount = decimal.Parse(Console.ReadLine());
						Deposit(amount, balance);
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("How much do you want to withdraw?");
						decimal withdrawAmount = decimal.Parse(Console.ReadLine());
						Withdraw(withdrawAmount, balance);
						break;
					case 3:
						Console.Clear();
						Console.WriteLine($"Your balance is {balance}");
						Console.ReadLine();
						Console.Clear();
						Menu(balance);
						break;
					case 4:
						Environment.Exit(0);
						break;
					default:
						Console.Clear();
						Console.WriteLine("You didn't select one of the options");
						Menu(balance);
						break;
				}
			}
		}

		/// <summary>
		/// Adds the deposit amount to the running balance
		/// Checks to see if deposit amount is negative
		/// </summary>
		/// <param name="amount">amount user wants to deposit</param>
		/// <param name="balance">balance after a deposit</param>
		public static void Deposit(decimal amount, decimal balance)
		{
			Deposit deposit = new Deposit();

			deposit.CheckIfDepositIsNegative(amount, balance);

			Menu(balance);
		}

		public static void Withdraw(decimal withdrawAmount, decimal balance)
		{
			Withdraw withdraw = new Withdraw(withdrawAmount);

			if (withdraw.CheckIfWithdrawIsGreaterThanBalance(withdrawAmount, balance))
			{
				balance = withdraw.WithdrawAmount(withdrawAmount, balance);
				Console.WriteLine($"Your balance is {balance}");
			}
			else
			{
				Console.WriteLine("You cannot withdraw an amount greater than what you have");
			}
			Menu(balance);
		}
	}
}
