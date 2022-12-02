namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 메이드
	/// </summary>
	public partial class TblMaid
	{
		/// <summary>
		/// 소유 사용자 번호
		/// </summary>
		public long OwnerUserNo { get; set; }
		/// <summary>
		/// 메이드 고유번호
		/// </summary>
		public long MaidNo { get; set; }
		/// <summary>
		/// 메이드 식별자
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 재사용 가능시간
		/// </summary>
		public DateTime ReuseTime { get; set; }
	}
}
