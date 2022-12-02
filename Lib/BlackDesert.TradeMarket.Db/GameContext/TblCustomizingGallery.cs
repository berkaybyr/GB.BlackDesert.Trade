namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCustomizingGallery
	{
		public long CustomizingNo { get; set; }
		public int CustomizingCategoryCode { get; set; }
		public string? CustomizingImage1 { get; set; }
		public string? CustomizingImage2 { get; set; }
		public string CustomizingFile { get; set; } = null!;
		public string CustomizingTitle { get; set; } = null!;
		public string? CustomizingDescription { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public long? CharacterNo { get; set; }
		public string? CharacterName { get; set; }
		public byte ClassType { get; set; }
		public long ViewCount { get; set; }
		public long CommentCount { get; set; }
		public int DownloadCount { get; set; }
		public DateTime Regdate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsMine { get; set; }
		public bool IsDelete { get; set; }
		public bool IsRandom { get; set; }
		public bool IsBlind { get; set; }
		public string? Author { get; set; }
		public string? CrossPlatform { get; set; }
		public bool? IsEdit { get; set; }
		public int LikeCount { get; set; }
	}
}
