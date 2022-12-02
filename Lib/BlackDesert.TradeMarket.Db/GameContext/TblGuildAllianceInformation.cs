namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 연합 정보
	/// </summary>
	public partial class TblGuildAllianceInformation
	{
		/// <summary>
		/// 연합 번호
		/// </summary>
		public long AllianceNo { get; set; }
		/// <summary>
		/// 연합 이름
		/// </summary>
		public string AllianceName { get; set; } = null!;
		/// <summary>
		/// 마크 등록 시간
		/// </summary>
		public DateTime? AllianceMarkRegisterTime { get; set; }
		/// <summary>
		/// 기본 정보 동기화 번호
		/// </summary>
		public int AllianceBasicSeqNo { get; set; }
		/// <summary>
		/// 마크 동기화 번호
		/// </summary>
		public int AllianceMarkSeqNo { get; set; }
		/// <summary>
		/// 연합 마크
		/// </summary>
		public byte[]? AllianceMark { get; set; }
		/// <summary>
		/// 연합 공지사항
		/// </summary>
		public string? AllianceNotice { get; set; }
		public byte AllianceType { get; set; }
	}
}
