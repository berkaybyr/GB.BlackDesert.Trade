namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblClearedBattlePass
	{
		public long UserNo { get; set; }
		public int Key { get; set; }
		public int SeasonKey { get; set; }
		public DateTime? BasicItemDate { get; set; }
		public DateTime? PremiumItemDate { get; set; }
	}
}
