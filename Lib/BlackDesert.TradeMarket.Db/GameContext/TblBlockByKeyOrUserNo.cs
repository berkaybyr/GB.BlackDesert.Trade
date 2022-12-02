namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 블록 통합 테이블
	/// </summary>
	public partial class TblBlockByKeyOrUserNo
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public long? RegisterUserNo { get; set; }
		public long BlockNo { get; set; }
		/// <summary>
		/// 블록 타입 - BlockedTbl.proc.sql에 기록
		/// </summary>
		public int Type { get; set; }
		public long? Param1 { get; set; }
		public long? Param2 { get; set; }
		public long? Param3 { get; set; }
		public string? Memo { get; set; }
	}
}
