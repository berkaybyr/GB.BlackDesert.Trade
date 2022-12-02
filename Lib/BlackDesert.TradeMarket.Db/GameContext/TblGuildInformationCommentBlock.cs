namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildInformationCommentBlock
	{
		public long GuildCommentBlockNo { get; set; }
		public long GuildNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public int IsBlock { get; set; }
		public DateTime Regdate { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
