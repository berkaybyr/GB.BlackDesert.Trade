namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCustomizingGalleryComment
	{
		public long CustomizingNo { get; set; }
		public long CustomizingCommentNo { get; set; }
		public string CustomizingComment { get; set; } = null!;
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public long? CharacterNo { get; set; }
		public string? CharacterName { get; set; }
		public byte ClassType { get; set; }
		public int CommentReportCount { get; set; }
		public DateTime CommentRegdate { get; set; }
		public DateTime CommentUpdateDate { get; set; }
		public bool IsBlind { get; set; }
		public bool IsDelete { get; set; }
	}
}
