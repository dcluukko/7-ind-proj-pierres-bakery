using System;
using System.Collections.Generic;
using Order.Models;


namespace Order
{
	public class Program
	{
		public static Pastry pastryOrder = new Pastry(0);
		public static Bread breadOrder = new Bread(0);
		public static void Main()
		{
			int orderSum = 0;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("===========================================================================================================================================");
			Console.WriteLine(@"
    ______   __     ______     ______     ______     ______     ______        ______     ______     __  __     ______     ______     __  __    
   /\  == \ /\ \   /\  ___\   /\  == \   /\  == \   /\  ___\   /\  ___\      /\  == \   /\  __ \   /\ \/ /    /\  ___\   /\  == \   /\ \_\ \   
   \ \  _-/ \ \ \  \ \  __\   \ \  __<   \ \  __<   \ \  __\   \ \___  \     \ \  __<   \ \  __ \  \ \  _-.  \ \  __\   \ \  __<   \ \____ \  
    \ \_\    \ \_\  \ \_____\  \ \_\ \_\  \ \_\ \_\  \ \_____\  \/\_____\     \ \_____\  \ \_\ \_\  \ \_\ \_\  \ \_____\  \ \_\ \_\  \/\_____\ 
     \/_/     \/_/   \/_____/   \/_/ /_/   \/_/ /_/   \/_____/   \/_____/      \/_____/   \/_/\/_/   \/_/\/_/   \/_____/   \/_/ /_/   \/_____/ 
                                                                                                                                               
");
			Console.WriteLine("=================================================================================================================================================");
			
			Order(orderSum);
		}		

			//Beginning Order Logic
			public static void Order(int orderSum)
			{	
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("Type 'Bread' to begin a bread order OR type 'Pastry' to begin a pastry order.");
				string orderBegin = Console.ReadLine();
				if (orderBegin.Equals("Bread") || orderBegin.Equals("bread"))
				{
					ShowBreadOptions();
					SelectBreadOption(orderSum);
				}	
				else if (orderBegin.Equals("Pastry") || orderBegin.Equals("pastry")) 
				{
					ShowPastryOptions();
					SelectPastryOption(orderSum);
				}
			}	
				//PASTRY SELECT 
				public static void SelectPastryOption(int orderSum)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("How many pastries would you like?");
					int danishInput = int.Parse(Console.ReadLine());
					int danishTotal = pastryOrder.DanishAdd(danishInput);
					orderSum += danishTotal;
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Total Number of Pastries : " + danishInput);
					Console.WriteLine("Total Cost: $" + danishTotal);
					OrderShow(orderSum);
				
				}
				//BREAD SELECT
				public static void SelectBreadOption(int orderSum)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("How many loaves would you like?");
					int loafInput = int.Parse(Console.ReadLine());
					int loafTotal = breadOrder.LoafAdd(loafInput);
					orderSum += loafTotal;
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Total Number of Loaves : " + loafInput);
					Console.WriteLine("Total Cost: $" + loafTotal);
				
					OrderShow(orderSum);
				}	
        
				
				//ORDER SHOW 
				public static void OrderShow(int orderSum) 
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
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
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Total Cost: $" + orderSum);
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("Thank you for shopping with Pierre's Bakery! Brûle en enfer!");
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