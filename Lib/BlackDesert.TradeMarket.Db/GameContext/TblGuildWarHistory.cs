namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildWarHistory
	{
		public long OwnerGuildNo { get; set; }
		public long TargetGuildNo { get; set; }
		public DateTime WarEndTime { get; set; }
	}
}
