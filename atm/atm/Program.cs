using System;

namespace atm
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome!");
			Menu();
		}

		public static void Menu()
		{
			Console.WriteLine("Select an option: \n" +
				"1. Deposit" +
				"2. Withdraw" +
				"3. View Balance" +
				"4. Exit");

		}
	}
}
