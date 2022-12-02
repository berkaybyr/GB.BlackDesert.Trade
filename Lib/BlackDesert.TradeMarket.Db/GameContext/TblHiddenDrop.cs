namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 히든 드랍
	/// </summary>
	public partial class TblHiddenDrop
	{
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 드랍 고유 번호
		/// </summary>
		public long HiddenDropNo { get; set; }
		/// <summary>
		/// 진행 정도
		/// </summary>
		public long HiddenDropCount { get; set; }
		/// <summary>
		/// 완료 시간
		/// </summary>
		public DateTime? CompleteDate { get; set; }
	}
}
