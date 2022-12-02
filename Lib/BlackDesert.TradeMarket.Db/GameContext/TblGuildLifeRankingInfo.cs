namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildLifeRankingInfo
	{
		public long GuildNo { get; set; }
		public byte Type { get; set; }
		public int? LevelSum { get; set; }
	}
}
