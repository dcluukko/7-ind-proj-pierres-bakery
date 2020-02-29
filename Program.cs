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
			Console.WriteLine("=========================================");
			Console.WriteLine("Welcome to Pierre's Bakery!");
			Console.WriteLine("=========================================");
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
				//PASTRY SELECT 
				public static void SelectPastryOption()
				{
					Console.WriteLine("How many pastries would you like?");
					int pastryResponse = int.Parse(Console.ReadLine());
					
					if (pastryResponse > 0)
					{
						pastryOrder.OrderPastry(pastryResponse);
						OrderShow();
					}
					else 
					{
						SelectPastryOption();
					}
					
				
				}
				//BREAD SELECT
				public static void SelectBreadOption()
				{
					Console.WriteLine("Type 'loaf' to add one loaf OR 'special' to get 2 loaves for the price of one.");
					int breadResponse = int.Parse(Console.ReadLine());
					if (breadResponse > 0)
					{
						breadOrder.OrderBread(breadResponse);
						OrderShow();
					}
				}	

				//ORDER SHOW 
				public static void OrderShow() 
				{
					int totalCost = breadOrder.LoafPrice + pastryOrder.DanishPrice;
					int loafTotal = breadOrder.LoafNum; 
					int danishTotal = pastryOrder.DanishNum;
					if (loafTotal > 0)
					{
					Console.WriteLine("Total Number of Loaves : " + breadOrder.LoafNum);
					}

					if (danishTotal > 0)
					{
					Console.WriteLine("Total Pastry Items: " + pastryOrder.DanishNum);
					}

					Console.WriteLine("Total Cost: $" + totalCost);
					Console.WriteLine("====================================");
					Console.WriteLine("To select another pastry item type [P], To select bread item type [B]To check out type [checkout]");
					string decideCheckoutOrSelect = Console.ReadLine();
					if (decideCheckoutOrSelect.Equals("P") || decideCheckoutOrSelect.Equals("p"))
					{
						SelectPastryOption();
					}
					else if (decideCheckoutOrSelect.Equals("B") || decideCheckoutOrSelect.Equals("b"))
					{
						SelectBreadOption();
					}
					else if (decideCheckoutOrSelect.Equals("Checkout") || decideCheckoutOrSelect.Equals("checkout"))
					{
						Checkout();
					}
				

					Order();
				}

				//CHECKOUT 
				public static void Checkout()
				{
					int totalCost = breadOrder.LoafPrice + pastryOrder.DanishPrice;

					int loafTotal = breadOrder.LoafNum; 
					int danishTotal = pastryOrder.DanishNum;
					if (loafTotal > 0)
					{
					Console.WriteLine("Total Number of Loaves : " + breadOrder.LoafNum);
					}

					if (danishTotal > 0)
					{
					Console.WriteLine("Total Pastry Items: " + pastryOrder.DanishNum);
					}

					Console.WriteLine("Total Cost: $" + totalCost);
					Console.WriteLine("Thank you for shopping with Pierre's Bakery! Brûle en enfer!");
					Main();

				}
				
				
				//BREAD OPTIONS
				public static void ShowBreadOptions()
				{
					Console.WriteLine("=============Bread Price Board=============");
					Console.WriteLine("One Loaf = $5");
					Console.WriteLine("*SPECIAL* Buy Two Loaves Get One Free");
				}
				//PASTRY OPTIONS
				public static void ShowPastryOptions()
				{
					Console.WriteLine("=============Pastry Price Board=============");
					Console.WriteLine("One Pastry = $2");
					Console.WriteLine("*SPECIAL* Buy Three Pastries for $5");
				}
					
	}
}