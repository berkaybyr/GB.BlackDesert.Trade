namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketNoticeItem
	{
		public long RegistTimeStamp { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public long Price { get; set; }
		public short NoticeType { get; set; }
		public long ChangedValue { get; set; }
	}
}
