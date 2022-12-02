namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// IP 블록 테이블
	/// </summary>
	public partial class TblBlockedIp
	{
		/// <summary>
		/// 블록 고유 번호
		/// </summary>
		public long BlockNo { get; set; }
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// IP 대역 시작점 NVARCHAR형
		/// </summary>
		public string StartIp { get; set; } = null!;
		/// <summary>
		/// IP 대역 시작점 BIGINT형
		/// </summary>
		public long BigintStartIp { get; set; }
		/// <summary>
		/// IP 대역 시작점 NVARCHAR형
		/// </summary>
		public string EndIp { get; set; } = null!;
		/// <summary>
		/// IP 대역 시작점 BIGINT형
		/// </summary>
		public long BigintEndIp { get; set; }
		/// <summary>
		/// 블록 사유 코드
		/// </summary>
		public int BlockCode { get; set; }
		/// <summary>
		/// 블록 운영자 메모
		/// </summary>
		public string OperationMemo { get; set; } = null!;
	}
}
