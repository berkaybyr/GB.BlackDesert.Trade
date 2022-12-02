namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유저 캐시
	/// </summary>
	public partial class TblUserCache
	{
		/// <summary>
		/// 유저
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 캐시 데이터(pack)
		/// </summary>
		public byte[]? Pack { get; set; }
	}
}
