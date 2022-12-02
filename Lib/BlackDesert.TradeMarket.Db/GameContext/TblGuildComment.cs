namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildComment
	{
		public DateTime RegisterDate { get; set; }
		public long CommentNo { get; set; }
		public long GuildNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public string UserComment { get; set; } = null!;
		public long ChairGuildNo { get; set; }
		public bool IsBlind { get; set; }
	}
}
