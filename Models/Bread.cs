namespace Order.Models	{
	public class Bread
	{
		public int BreadResponse {get; set;}
		public int LoafNum {get; set;}
		public int LoafPrice {get; set;}

		public Bread(int loafNum, int breadResponse)
		{
				BreadResponse = breadResponse;
				LoafNum = loafNum;
				LoafPrice = 5;

		}
		public void orderBread(int loafNum)
		{
			LoafNum * breadResponse;
		}		
		public void calcBreadCost(int loafPrice)
		{
			LoafPrice * breadResponse;
		}
	}

}