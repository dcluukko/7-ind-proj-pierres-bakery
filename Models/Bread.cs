namespace Order.Models	{
	public class Bread
	{
		public int BreadInput {get; set;}
		public int LoafNum {get; set;}
		public int LoafPrice {get; set;}

		public Bread(int loafNum, int breadInput)
		{
				BreadInput = breadInput;
				LoafNum = loafNum;
				LoafPrice = 5;

		}
		public void orderBread(int loafNum)
		{
			LoafNum * breadInput;
			return CurrentBreadOrderTotal
		}		
		public void calcBreadCost(int loafPrice)
		{
			LoafPrice * breadInput;
			return breadCalcCost;
		}
	}

}