namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceFieldNormalDatum
	{
		public int InstanceFieldKey { get; set; }
		public int SeasonKey { get; set; }
		public long UserNo { get; set; }
		public int PlayCount { get; set; }
		public int SumKillCount { get; set; }
		public int BestSessionPoint { get; set; }
		public int SumSessionPoint { get; set; }
		public long RankPoint { get; set; }
	}
}
