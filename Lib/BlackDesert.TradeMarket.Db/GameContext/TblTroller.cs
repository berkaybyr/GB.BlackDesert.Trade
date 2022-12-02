namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblTroller
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 컨텐츠 타입
		/// </summary>
		public int ContentsType { get; set; }
		/// <summary>
		/// 신고 당한 횟수
		/// </summary>
		public int ReportStack { get; set; }
		/// <summary>
		/// 밴 시간
		/// </summary>
		public DateTime? BannedTime { get; set; }
	}
}
