namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblTradeAuthKey
	{
		public long UserNo { get; set; }
		public Guid? CurKey { get; set; }
		public Guid? PrevKey { get; set; }
		public DateTime? CurUpdateDate { get; set; }
		public DateTime? PrevUpdateDate { get; set; }
	}
}
