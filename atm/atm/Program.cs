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
						Console.WriteLine("You chose Withdraw");
						break;
					case 3:
						Console.WriteLine("You chose View Balance");
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
			Deposit deposit = new Deposit(amount);

			//if amount is not negative, add to the balance
			if (deposit.CheckIfDepositIsNegative(amount))
			{
				balance = deposit.AddDepositToBalance(amount, balance);
				Console.WriteLine($"Your balance is {balance}");
			}
			else //if amount is negative, redirect user back to the menu
			{
				Console.WriteLine("You cannot add a negative number");
			}
			Menu(balance);
		}
	}
}
