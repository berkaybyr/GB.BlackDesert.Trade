namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblThumbsUpInformation
	{
		public long UserNo { get; set; }
		public short ThumbsUpVoteCount { get; set; }
		public DateTime LastVoteTime { get; set; }
	}
}
