namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblWorldMarketPayloadGameDb
	{
		public long Payload { get; set; }
		public short Type { get; set; }
		public short State { get; set; }
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public bool IsSealed { get; set; }
		public long Param0 { get; set; }
		public long Param1 { get; set; }
		public long Param2 { get; set; }
		public long Param3 { get; set; }
		public long Param4 { get; set; }
		public long Count { get; set; }
		public bool IsMovingTradeWeb { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
