namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildPoint
	{
		public long GuildNo { get; set; }
		public int GuildPoint { get; set; }
		public int GuildTotalPoint { get; set; }
		public long TerritoryKey { get; set; }
	}
}
