namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 캐싱관련 변경회수
	/// </summary>
	public partial class TblCacheSeq
	{
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _cacheType 에 따라서 의미가 다름
		/// </summary>
		public long Key { get; set; }
		/// <summary>
		/// OdbcCacheType 참고
		/// </summary>
		public short CacheType { get; set; }
		/// <summary>
		/// CacheSeq 참고
		/// </summary>
		public int SeqNo { get; set; }
	}
}
