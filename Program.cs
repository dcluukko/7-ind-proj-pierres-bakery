using System;
using System.Collections.Generic;
using Order.Models;


namespace Order
{
	public class Program
	{
		public static Pastry pastryOrder = new Pastry(0,0);
		public static Bread breadOrder = new Bread(0,0);

		public static void Main()
		{
			Console.WriteLine("Welcome to Pierre's Bakery!");
			Order();
		}		

			//Beginning Order Logic
			public static void Order()
			{
				Console.WriteLine("Type 'Bread' to begin a bread order OR type 'Pastry' to begin a pastry order.");
				string orderBegin = Console.ReadLine();
				if (orderBegin.Equals("Bread"))
				{
					ShowBreadOptions();
					SelectBreadOption();
				}	
				else if (orderBegin.Equals("Pastry")) 
				{
					ShowPastryOptions();
					SelectPastryOption();
				}
			}	

				public static void SelectPastryOption()
				{
					Console.WriteLine("Type 'pastry' to add one pastry OR 'special' to get 2 pastries for $3.");
					string pastryResponse = Console.ReadLine();
					
					if (pastryResponse.Equals("pastry"))
					{
						pastryOrder.AddPastry(1, 5);
					}
					else if(pastryResponse.Equals("special"))
					{
						pastryOrder.AddPastry(3, 10);
					}
				}

				public static void SelectBreadOption()
				{
					Console.WriteLine("Type 'loaf' to add one loaf OR 'special' to get 2 loaves for the price of one.");
					string breadResponse = Console.ReadLine();
					if (breadResponse.Equals("loaf"))
					{
						breadOrder.AddBread(1, 5);
					}
					else if(breadResponse.Equals("special"))
					{
						breadOrder.AddBread(3, 10);
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