namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblAutoBuyLog
	{
		public int Id { get; set; }
		public DateTime RegisterDate { get; set; }
		public int UserCount { get; set; }
		public int ItemsBought { get; set; }
		public long TotalSilverGiven { get; set; }
	}
}
