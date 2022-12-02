namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 번역신고
	/// </summary>
	public partial class TblTranslationReport
	{
		/// <summary>
		/// 신고일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 신고글의 고유 번호
		/// </summary>
		public long ReportNo { get; set; }
		/// <summary>
		/// 언어 타입
		/// </summary>
		public byte ServiceResourceType { get; set; }
		/// <summary>
		/// 번역키
		/// </summary>
		public short StaticType { get; set; }
		/// <summary>
		/// 번역키
		/// </summary>
		public int TranslationKey1 { get; set; }
		/// <summary>
		/// 번역키
		/// </summary>
		public short TranslationKey2 { get; set; }
		/// <summary>
		/// 번역키
		/// </summary>
		public short TranslationKey3 { get; set; }
		/// <summary>
		/// 번역키
		/// </summary>
		public short TextNo { get; set; }
		/// <summary>
		/// 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 바꾸고자 하는 번역 내용
		/// </summary>
		public string TranslationText { get; set; } = null!;
		/// <summary>
		/// 추천수
		/// </summary>
		public short RecommendCount { get; set; }
	}
}
