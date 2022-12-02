namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceFieldRankDatum
	{
		public int InstanceFieldKey { get; set; }
		public int SeasonKey { get; set; }
		public long UserNo { get; set; }
		public byte Tier { get; set; }
		public int TierPoint { get; set; }
		public int PlayCount { get; set; }
		public int BestSessionPoint { get; set; }
		public int SumSessionPoint { get; set; }
		public long RankPoint { get; set; }
		public int SumKillCount { get; set; }
		public long PrevRankPoint { get; set; }
		public int DefeatStack { get; set; }
		public long Mmr { get; set; }
	}
}
