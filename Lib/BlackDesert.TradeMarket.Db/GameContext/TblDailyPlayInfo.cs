namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblDailyPlayInfo
	{
		public long UserNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public byte PlayCount { get; set; }
		public DateTime NextResetTime { get; set; }
	}
}
