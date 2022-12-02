namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInvestGuildPointInformation
	{
		public long GuildNo { get; set; }
		public int GuildPoint { get; set; }
		public short InvestType { get; set; }
		public int InvestKey { get; set; }
		public DateTime UseDate { get; set; }
	}
}
