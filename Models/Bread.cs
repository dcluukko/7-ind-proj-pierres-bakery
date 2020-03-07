namespace Order.Models	{
	public class Bread
	{
		public int LoafNum{get; set;}
		public int LoafPrice = 5;

		// public Bread(int loafNum)
		// {
		// 	LoafNum += loafNum;
		// 	// LoafCost = loafCost;
		// }

		public int LoafAdd(int x)
		{
			int loafTotal = 0;
			for(int i=1; i <= x; i++)
			{
				if	(i % 3 != 0)
				{
					loafTotal += LoafPrice;
				} 
				else 
				{
					loafTotal += 0;
				}
			}
			return loafTotal;
		}
	}
}