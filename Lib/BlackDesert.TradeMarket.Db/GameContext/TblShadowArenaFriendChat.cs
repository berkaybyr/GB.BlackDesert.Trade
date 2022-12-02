namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaFriendChat
	{
		public long ChatIdx { get; set; }
		public long FromUserNo { get; set; }
		public string FromUserId { get; set; } = null!;
		public long ToUserNo { get; set; }
		public string ToUserId { get; set; } = null!;
		public string ChatMsg { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
	}
}
