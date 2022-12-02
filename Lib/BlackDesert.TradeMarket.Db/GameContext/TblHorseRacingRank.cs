namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblHorseRacingRank
	{
		public long UserNo { get; set; }
		public int RankIndex { get; set; }
		public short MapKey { get; set; }
		public long ServantNo { get; set; }
		public long RecordTick { get; set; }
		public DateTime RecordDate { get; set; }
		public int PlayCount { get; set; }
		public int FirstCount { get; set; }
		public int SecondCount { get; set; }
		public int ThirdCount { get; set; }
	}
}
