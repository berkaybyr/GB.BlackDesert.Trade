namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblBlockUser
	{
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime? DueDate { get; set; }
	}
}
