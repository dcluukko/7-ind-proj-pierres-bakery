namespace Order.Models	
{
	public class Bread
	{
		public int LoafQuantity { get; set; }
		public int LoafPrice { get; set; }

		public Bread(int LoafQuantity, int loafPrice)
		{
				LoafQuantity = 0;
				LoafPrice = 0;
		}
		public void AddBread(int LoafQuantity)
		{
			LoafQuantity ++;
		}		
		public void AddPrice(int loafPrice)
		{
			loafPrice ++;
		}
	}

}