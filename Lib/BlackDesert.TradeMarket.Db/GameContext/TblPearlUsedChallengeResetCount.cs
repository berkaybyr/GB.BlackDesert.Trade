namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPearlUsedChallengeResetCount
	{
		public DateTime? RegisterDate { get; set; }
		public long UserNo { get; set; }
		public int MainChallengeKey { get; set; }
		public int? ResetCount { get; set; }
	}
}
