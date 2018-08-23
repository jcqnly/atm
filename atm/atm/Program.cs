using atm.Classes;
using System;

namespace atm
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome!");
			decimal Balance = 5000M;
			Menu();
		}

		public static void Menu()
		{
			Console.WriteLine("Select an option: \n" +
				"1. Deposit \n" +
				"2. Withdraw \n" +
				"3. View Balance \n" +
				"4. Exit \n");			
			Selection();
		}

		public static void Selection()
		{
			//need to declare this outside of the try/catch/finally because of scoping
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
						Console.WriteLine("How much do you want to deposit?");
						decimal amount = decimal.Parse(Console.ReadLine());
						Deposit(amount);
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
						Menu();
						break;
				}
			}
		}

		public static void Deposit(decimal amount)
		{
			Deposit deposit = new Deposit(amount);
		}
	}
}
