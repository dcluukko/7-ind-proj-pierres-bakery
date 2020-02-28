using System;
using System.Collections.Generic;
using Order.Models;


namespace Order
{
	public class Program
	{
		public static void Main()
		{
				Bread breadOrder = new Bread(0, 0);
				Pastry pastryOrder = new Pastry(0, 0);

				List<Bread> Breads = new List<Bread>(100) {breadOrder};
				List<Pastry> Pastrys = new List<Pastry>(100) {pastryOrder};
				

				Console.WriteLine("Welcome to Pierre's Bakery!");
				Console.WriteLine("Type 'Bread' to begin a bread order OR type 'Pastry' to begin a pastry order.");
				string orderBegin = Console.ReadLine();
				if (orderBegin.Equals("Bread"))
				{
					if (orderBegin.Equals("Bread"))
					{
					ShowBreadOptions();
					Console.WriteLine("Type 'loaf' to add one loaf OR 'special' to get 2 loaves for the price of one.");
					string breadResponse = Console.ReadLine();
					}
					else if (breadResponse.Equals("loaf"))
					{
						bread.Addbread(1, 5);
					}
					else if(breadResponse.Equals("special"))
					{
						bread.AddBread(3, 10);
					}
				}	
				else (orderBegin.Equals("Pastry")); //Semi-colon in question*
				{
					if (orderBegin.Equals("Pastry"))
					{
					ShowPastryOptions();
					Console.WriteLine("Type 'pastry' to add one pastry OR 'special' to get 2 pastries for $3.");
					string pastryResponse = Console.Readline();
					}
					else if (pastryResponse.Equals("loaf"))
					{
						pastry.AddPastry(1, 5);
					}
					else if(pastryResponse.Equals("special"))
					{
						pastry.AddPastry(3, 10);
					}
				}
				
		}	
				
				public static void ShowBreadOptions()
				{
					Console.WriteLine("=============Bread Price Board=============");
					Console.WriteLine("One Loaf = $5");
					Console.WriteLine("*SPECIAL* Buy Two Loaves Get One Free");
				}
				public static void ShowPastryOptions()
				{
					Console.WriteLine("=============Pastry Price Board=============");
					Console.WriteLine("One Pastry = $2");
					Console.WriteLine("*SPECIAL* Buy Three Pastries for $5");
				}
				
	}
}