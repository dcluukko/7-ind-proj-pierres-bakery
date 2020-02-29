namespace Order.Models {
	public class Pastry
	{
		public int PastryResponse;
		public int DanishNum {get; set;}
		public int DanishPrice {get; set;}


		public Pastry( int pastryResponse, int danishNum)
		{
			PastryResponse = pastryResponse;
			DanishNum = danishNum;
			DanishPrice = 2;
		}
			public void OrderPastry(int danishNum)
		{
			DanishNum * pastryResponse;
		}
		 public void CalcPastryCost(int danishPrice)
		 {
			 DanishPrice * pastryResponse;
		 }
		
		
	}
}