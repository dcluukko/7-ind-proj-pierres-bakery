using System;
using System.Collections.Generic;
using Order.Models;


namespace Order
{
	public class Program
	{
		public static Pastry pastryOrder = new Pastry();
		public static Bread breadOrder = new Bread();
		public static void Main()
		{
			int orderSum = 0;
			Console.WriteLine("=========================================");
			Console.WriteLine("Welcome to Pierre's Bakery!");
			Console.WriteLine("=========================================");
			
			Order(orderSum);
		}		

			//Beginning Order Logic
			public static void Order(int orderSum)
			{	
				Console.WriteLine("Type 'Bread' to begin a bread order OR type 'Pastry' to begin a pastry order.");
				string orderBegin = Console.ReadLine();
				if (orderBegin.Equals("Bread"))
				{
					ShowBreadOptions();
					SelectBreadOption(orderSum);
				}	
				else if (orderBegin.Equals("Pastry")) 
				{
					ShowPastryOptions();
					SelectPastryOption(orderSum);
				}
			}	
				//PASTRY SELECT 
				public static void SelectPastryOption(int orderSum)
				{
					Console.WriteLine("How many pastries would you like?");
					int danishInput = int.Parse(Console.ReadLine());
					int danishTotal = pastryOrder.DanishAdd(danishInput);
					danishTotal += orderSum;
					Console.WriteLine("Total Number of Loaves : " + danishInput);
					Console.WriteLine("Total Cost: $" + danishTotal);
					OrderShow(orderSum);
				
				}
				//BREAD SELECT
				public static void SelectBreadOption(int orderSum)
				{
					Console.WriteLine("How many loaves would you like?");
					int loafInput = int.Parse(Console.ReadLine());
					int loafTotal = breadOrder.LoafAdd(loafInput);
					loafTotal += orderSum;
					Console.WriteLine("Total Number of Loaves : " + loafInput);
					Console.WriteLine("Total Cost: $" + loafTotal);
				
					OrderShow(orderSum);
				}	

				//ORDER SHOW 
				public static void OrderShow(int orderSum) 
				{
					Console.WriteLine("====================================");
					Console.WriteLine("To select another pastry item type [P], To select bread item type [B]To check out type [checkout]");
					string decideCheckoutOrSelect = Console.ReadLine();
					if (decideCheckoutOrSelect.Equals("P") || decideCheckoutOrSelect.Equals("p"))
					{
						SelectPastryOption(orderSum);
					}
					else if (decideCheckoutOrSelect.Equals("B") || decideCheckoutOrSelect.Equals("b"))
					{
						SelectBreadOption(orderSum);
					}
					else if (decideCheckoutOrSelect.Equals("Checkout") || decideCheckoutOrSelect.Equals("checkout"))
					{
					Checkout(orderSum);
						
					}
				}

				//CHECKOUT 
				public static void Checkout(int orderSum)
				{
					int totalCost = orderSum;
					
				
				// 	if (loafTotal > 0)
				// 	{
				// 	Console.WriteLine("Total Number of Loaves : " + breadOrder.LoafNum);
				// 	}

				// 	if (danishTotal > 0)
				// 	{
				// 	Console.WriteLine("Total Pastry Items: " + pastryOrder.DanishNum);
				// 	}

					Console.WriteLine("Total Cost: $" + totalCost);
					Console.WriteLine("Thank you for shopping with Pierre's Bakery! Brûle en enfer!");
					Main();

				}
				
				
				// BREAD OPTIONS
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