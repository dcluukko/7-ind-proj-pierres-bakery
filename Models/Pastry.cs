namespace Order.Models {
	public class Pastry
	{
		public int DanishNum {get; set;}
		public int DanishPrice {get; set;}

		public Pastry( int danishNum, int danishPrice)
		{
			DanishNum = danishNum;
			DanishPrice = danishPrice;
		}
			public void AddPastry(int danishNum, int danishPrice)
		{
			DanishNum += danishNum;
			DanishPrice += danishPrice;
		}
		
		
	}
}