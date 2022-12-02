namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketKeyWord
	{
		public long KeyWordNo { get; set; }
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public string SearchKeyWord { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
	}
}
