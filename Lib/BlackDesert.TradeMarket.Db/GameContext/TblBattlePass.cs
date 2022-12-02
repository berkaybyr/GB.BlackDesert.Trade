namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBattlePass
	{
		public long UserNo { get; set; }
		public int SeasonKey { get; set; }
		public int Point { get; set; }
		public bool IsPremium { get; set; }
	}
}
