namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCompositionNote
	{
		public long NoteNo { get; set; }
		public long UserNo { get; set; }
		public string NoteTitle { get; set; } = null!;
		public string NoteContent { get; set; } = null!;
		public string MusicTitle { get; set; } = null!;
		public string MusicOwn { get; set; } = null!;
		public TimeSpan MusicTime { get; set; }
		public string MusicPath { get; set; } = null!;
		public bool IsDownload { get; set; }
		public bool IsAdventurer { get; set; }
		public byte IsBlind { get; set; }
		public DateTime RegDate { get; set; }
		public DateTime UpdDate { get; set; }
		public string? Instrument { get; set; }
		public string? Rank { get; set; }
		public int HeartCount { get; set; }
		public int StarCount { get; set; }
		public int PlayCount { get; set; }
		public int DownloadCount { get; set; }
		public int ReplyCount { get; set; }
		public bool? IsEdit { get; set; }
		public string UserNickname { get; set; } = null!;
	}
}
