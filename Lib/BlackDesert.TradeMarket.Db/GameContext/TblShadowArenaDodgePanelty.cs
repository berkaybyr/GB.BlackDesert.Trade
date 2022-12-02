namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaDodgePanelty
	{
		public long UserNo { get; set; }
		public byte TodayCount { get; set; }
		public DateTime? JoinableTime { get; set; }
		public DateTime NextResetTime { get; set; }
	}
}
