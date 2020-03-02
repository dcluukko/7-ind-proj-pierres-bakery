namespace Order.Models {
	public class Pastry
	{
		public int DanishPrice = 2;
	
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