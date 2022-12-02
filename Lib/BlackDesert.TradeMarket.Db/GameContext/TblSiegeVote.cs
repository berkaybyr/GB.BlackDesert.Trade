namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSiegeVote
	{
		public long UserNo { get; set; }
		public int TerritoryKey { get; set; }
		public bool IsLike { get; set; }
	}
}
