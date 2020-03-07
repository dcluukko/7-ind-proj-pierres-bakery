namespace Order.Models	{
	public class Bread
	{
		public int LoafNum{get; set;}
		public int LoafPrice = 5;

		public Bread(int loafNum)
		{
			LoafNum += loafNum;
		}

		public int LoafAdd(int loafNum)
		{
			int loafTotal = 0;
			for(int i=1; i <= loafNum; i++)
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