namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblChatBlockListByUser
	{
		public long FromUserNo { get; set; }
		public long ToUserNo { get; set; }
		public DateTime LastDate { get; set; }
	}
}
