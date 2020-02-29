namespace Order.Models	{
	public class Bread
	{
		public int BreadResponse {get: set:}
		public int LoafNum {get; set;}
		public int LoafPrice {get; set;}

		public Bread(int loafNum, int loafPrice)
		{
				LoafNum = loafNum;
				LoafPrice = loafPrice;
		}
		public void orderBread(int loafPrice)
		{
			LoafNum += loafNum;
			
		}		
		
	}

}