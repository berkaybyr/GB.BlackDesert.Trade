namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblQuizEventUserInfo
	{
		public long UserNo { get; set; }
		public short CorrectCount { get; set; }
		public DateTime LastUpdateTime { get; set; }
	}
}
