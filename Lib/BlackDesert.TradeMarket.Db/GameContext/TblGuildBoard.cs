namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 게시판 정보
	/// </summary>
	public partial class TblGuildBoard
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 사용자번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 게시판 타입
		/// </summary>
		public byte BoardType { get; set; }
		/// <summary>
		/// 게시판 내용
		/// </summary>
		public string BoardMessage { get; set; } = null!;
	}
}
