namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketWaitBiddingSellNotice
	{
		public long WaitNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public byte UsedType { get; set; }
		public long ResultMoneyCount { get; set; }
		public byte Status { get; set; }
	}
}
