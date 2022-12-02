namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblScreenShot
	{
		public long ScreenNo { get; set; }
		public string? ScreenImage1 { get; set; }
		public string? ScreenImage2 { get; set; }
		public string? ScreenImage3 { get; set; }
		public string? ScreenImage4 { get; set; }
		public string? ScreenImage5 { get; set; }
		public string? ScreenImage6 { get; set; }
		public string? ScreenThumb { get; set; }
		public string? ScreenSignImage1 { get; set; }
		public string? ScreenSignImage2 { get; set; }
		public string? ScreenSignImage3 { get; set; }
		public string? ScreenSignImage4 { get; set; }
		public string? ScreenSignImage5 { get; set; }
		public string? ScreenSignImage6 { get; set; }
		public string ScreenTitle { get; set; } = null!;
		public string? ScreenDescription { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public long CharacterNo { get; set; }
		public string CharacterName { get; set; } = null!;
		public byte ClassType { get; set; }
		public long ViewCount { get; set; }
		public long CommentCount { get; set; }
		public int LikeCount { get; set; }
		public DateTime Regdate { get; set; }
		public byte Category { get; set; }
		public bool IsMine { get; set; }
		public bool IsDelete { get; set; }
		public bool IsSignature { get; set; }
	}
}
