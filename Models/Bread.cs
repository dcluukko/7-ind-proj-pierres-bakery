namespace Order.Models	{
	public class Bread
	{
		public int LoafNum {get; set;}
		public int LoafPrice {get; set;}

		public Bread(int loafNum, int loafPrice)
		{
				LoafNum = loafNum;
				LoafPrice = loafPrice;
		}
		public void AddBread(int loafNum, int loafPrice)
		{
			LoafNum += loafNum;
			LoafPrice += loafPrice;
		}		
		public void BreadSpecial(int loafNum, int loafPrice)
		{
			int specialLoaf = LoafNum / 3;
			Console.WriteLine(specialLoaf);
		}
	}

}