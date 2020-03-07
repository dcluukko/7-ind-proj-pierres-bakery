namespace Order.Models {
	public class Pastry
	{
		public int DanishPrice = 2;
		public int DanishNum {get; set;}
		public int DanishCost {get; set;}

		// public Pastry ( int danishNum, int danishCost)
		// {
		// 	DanishNum = danishNum;
		// 	DanishCost = danishCost;
		// }
	
		public int DanishAdd(int x)
		{
			int danishTotal = 0;
			for(int i = 1; i <= x; i++)
			{
				if	(i % 3 == 0)
				{
					danishTotal += 1;
				} 
				else 
				{
					danishTotal += DanishPrice;
				}
			}
			return danishTotal;
		}
	}
}