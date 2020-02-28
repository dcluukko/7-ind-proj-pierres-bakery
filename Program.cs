using System;
using System.Collections.Generic;
using Order.Models;


namespace Order
{
	public class Program
	{
		public static Bread breadOrder = new Bread(0,0);
		// public static Pastry pastryOrder = new Pastry();
		public static void Main()
		{
			Console.WriteLine("Welcome to Pierre's Bakery!");
			Console.WriteLine("type [start] to begin your order");
			string orderBegin = Console.ReadLine();
			Order();
		}		
			public static void Order()
			{
				if (orderBegin.Equals("start"))
				{
					Console.WriteLine("Type 'Bread' to begin a bread order OR type 'Pastry' to begin a pastry order.");
					string breadTime = Console.ReadLine();
					if (breadTime.Equals("Bread"))
					{
					// else if (orderBegin.Equals("Bread"))
					ShowBreadOptions();
					Console.WriteLine("Type 'loaf' to add one loaf OR 'special' to get 2 loaves for the price of one.");
					string breadResponse = Console.ReadLine();
					}
					else if (breadResponse.Equals("loaf"))
					{
						breadOrder.Addbread(1, 5);
					}
					else if(breadResponse.Equals("special"))
					{
						breadOrder.AddBread(3, 10);
					}
				}
					
					// else (orderBegin.Equals("Pastry")); //Semi-colon in question*
					// {
					// 	if (orderBegin.Equals("Pastry"))
					// 	{
					// 	ShowPastryOptions();
					// 	Console.WriteLine("Type 'pastry' to add one pastry OR 'special' to get 2 pastries for $3.");
					// 	string pastryResponse = Console.Readline();
					// 	}
					// 	else if (pastryResponse.Equals("loaf"))
					// 	{
					// 		pastryOrder.AddPastry(1, 5);
					// 	}
					// 	else if(pastryResponse.Equals("special"))
					// 	{
					// 		pastryOrder.AddPastry(3, 10);
					// 	}
					// }
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