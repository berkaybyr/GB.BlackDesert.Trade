namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblContentMst
	{
		public int GroupContentNo { get; set; }
		public DateTime? ContentStartDate { get; set; }
		public DateTime? ContentEndDate { get; set; }
		public bool? IsDisplay { get; set; }
		public bool IsDelete { get; set; }
		public DateTime RegDate { get; set; }
		public DateTime? UpdDate { get; set; }
	}
}
