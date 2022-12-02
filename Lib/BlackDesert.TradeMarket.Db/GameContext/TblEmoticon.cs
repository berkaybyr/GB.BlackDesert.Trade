namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 이모티콘
	/// </summary>
	public partial class TblEmoticon
	{
		/// <summary>
		/// 소유자번호
		/// </summary>
		public long OwnerUserNo { get; set; }
		/// <summary>
		/// 이모티콘패키지 키 
		/// </summary>
		public long EmoticonPackageKey { get; set; }
		/// <summary>
		/// 이모티콘 상품 타입
		/// </summary>
		public byte EmoticonType { get; set; }
		/// <summary>
		/// 기간제 이모티콘 유통기한
		/// </summary>
		public DateTime PackageExpirationDate { get; set; }
	}
}
