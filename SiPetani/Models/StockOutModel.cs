namespace SiPetani.Models
{
	public class StockOutModel
	{
		public int Output_Id { get; set; }
		public int Stock_Id { get; set; }
		public DateTime Output_Date { get; set; }
		public float Output_Quantity { get; set; }
		public string Recipient { get; set; }
		public int Managed_By { get; set; }
		public string Description { get; set; }
	}
}
