namespace Order.Models	
{
	public class Bread
	{
		public int LoafQuantity { get; set; }
		public int LoafPrice { get; set; }

		public Bread()
		{
				LoafQuantity = 0;
				LoafPrice = 0;
		}
		public void AddBread()
		{
			LoafQuantity ++;
		}		
		public void AddPrice()
		{
			LoafPrice ++;
		}
	}

}