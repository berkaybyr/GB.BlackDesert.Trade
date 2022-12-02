namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드가공
	/// </summary>
	public partial class TblGuildManufacture
	{
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 슬롯번호
		/// </summary>
		public byte Index { get; set; }
		/// <summary>
		/// 가공아이템갯수
		/// </summary>
		public long ProductItemCount { get; set; }
		/// <summary>
		/// 재료아이템갯수0
		/// </summary>
		public long RequiredItemCount0 { get; set; }
		/// <summary>
		/// 재료아이템갯수1
		/// </summary>
		public long RequiredItemCount1 { get; set; }
		/// <summary>
		/// 재료아이템갯수2
		/// </summary>
		public long RequiredItemCount2 { get; set; }
		/// <summary>
		/// 재료아이템갯수3
		/// </summary>
		public long RequiredItemCount3 { get; set; }
		/// <summary>
		/// 재료아이템갯수4
		/// </summary>
		public long RequiredItemCount4 { get; set; }
		/// <summary>
		/// 재료아이템갯수5
		/// </summary>
		public long RequiredItemCount5 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 완료일
		/// </summary>
		public DateTime CompleteDate { get; set; }
		/// <summary>
		/// 가공아이템
		/// </summary>
		public int ProductItemKey { get; set; }
		/// <summary>
		/// 재료아이템0
		/// </summary>
		public int RequiredItemKey0 { get; set; }
		/// <summary>
		/// 재료아이템1
		/// </summary>
		public int RequiredItemKey1 { get; set; }
		/// <summary>
		/// 재료아이템2
		/// </summary>
		public int RequiredItemKey2 { get; set; }
		/// <summary>
		/// 재료아이템3
		/// </summary>
		public int RequiredItemKey3 { get; set; }
		/// <summary>
		/// 재료아이템4
		/// </summary>
		public int RequiredItemKey4 { get; set; }
		/// <summary>
		/// 재료아이템5
		/// </summary>
		public int RequiredItemKey5 { get; set; }
	}
}
