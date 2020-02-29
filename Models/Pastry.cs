namespace Order.Models {
	public class Pastry
	{
		public int PastryInput;
		public int DanishNum {get; set;}
		public int DanishPrice {get; set;}


		public Pastry( int pastryInput, int danishNum)
		{
			PastryInput = pastryInput;
			DanishNum = danishNum;
			DanishPrice = 2;
		}
			public void OrderPastry(int pastryInput)
		{
			danishNum * pastryInput;
			return CurrentPastryOrderTotal;
		}
		 public void CalcPastryCost(int danishPrice)
		 {
			 DanishPrice * pastryInput;
			 return pastryCalcCost;
		 }
		//FUNCTION ON PROPERTY
		//FUNCTION CALLING GETTING AND SETTING
		 public int CalcPastryCost()
		{

		}
		
		
	}
}