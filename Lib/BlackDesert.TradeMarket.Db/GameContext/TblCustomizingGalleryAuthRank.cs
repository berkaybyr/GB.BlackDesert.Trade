namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCustomizingGalleryAuthRank
	{
		public int DayType { get; set; }
		public long? Ranking { get; set; }
		public string? Author { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public byte ClassType { get; set; }
		public int DownloadCount { get; set; }
		public long CustomizingNo { get; set; }
		public string? CustomizingImage1 { get; set; }
		public string? CustomizingImage2 { get; set; }
		public string CustomizingFile { get; set; } = null!;
		public int? DownTotal { get; set; }
		public int LikeCount { get; set; }
		public long CommentCount { get; set; }
		public long? Tnum { get; set; }
		public bool IsDelete { get; set; }
		public bool IsMine { get; set; }
		public string? CrossPlatform { get; set; }
	}
}
