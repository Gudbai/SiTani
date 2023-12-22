namespace SiPetani.Models
{
	public class StockInModel
	{
		public int Input_Id { get; set; }
		public int Stock_Id { get; set; }
		public DateTime Input_Date { get; set; }
		public float Input_Quantity { get; set; }
		public string Sender { get; set; }
		public int Managed_By { get; set; }
		public string Description { get; set; }
	}
}
