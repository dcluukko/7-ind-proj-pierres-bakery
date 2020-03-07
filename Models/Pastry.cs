namespace Order.Models {
	public class Pastry
	{
		public int DanishPrice = 2;
		public int DanishNum {get; set;}
		public int DanishTotal {get; set;}

		public Pastry ( int danishNum)
		{
			DanishNum += danishNum;
		}
	
		public int DanishAdd(int danishNum)
		{
			int danishTotal = 0;
			for(int i = 1; i <= danishNum; i++)
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