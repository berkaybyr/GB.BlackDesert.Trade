namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildInformationComment
	{
		public long GuildCommentNo { get; set; }
		public long GuildNo { get; set; }
		public int Level { get; set; }
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public string CharacterName { get; set; } = null!;
		public string UserNickname { get; set; } = null!;
		public byte ClassType { get; set; }
		public string Comment { get; set; } = null!;
		public DateTime Regdate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsBlind { get; set; }
		public bool IsDelete { get; set; }
	}
}
