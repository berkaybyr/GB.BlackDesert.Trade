namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildInformation
	{
		public long GuildNo { get; set; }
		public string? GuildInformation { get; set; }
		public string? GuildImageUrl { get; set; }
		public string? GuildYouTubeUrl { get; set; }
		public string? GuildFacebookUrl { get; set; }
		public int? GuildCommentCount { get; set; }
		public int GuildCommentUsed { get; set; }
		public int GuildNickNameCommentCount { get; set; }
		public bool? IsBlind { get; set; }
		public DateTime? UpdateDate { get; set; }
	}
}
