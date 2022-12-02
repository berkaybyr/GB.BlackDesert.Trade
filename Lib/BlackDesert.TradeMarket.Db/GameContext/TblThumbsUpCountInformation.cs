namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblThumbsUpCountInformation
	{
		public long UserNo { get; set; }
		public long ChatRoomNo { get; set; }
		public int ThumbsUpCount { get; set; }
		public int ThumbsUpGrade { get; set; }
	}
}
