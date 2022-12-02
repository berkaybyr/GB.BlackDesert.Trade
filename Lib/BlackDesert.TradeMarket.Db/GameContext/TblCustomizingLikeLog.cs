namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCustomizingLikeLog
	{
		public long CustomizingNo { get; set; }
		public long UserNo { get; set; }
		public DateTime LikeDate { get; set; }
	}
}
