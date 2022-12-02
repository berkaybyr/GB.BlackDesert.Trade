namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 쾌스트 진행 목록
	/// </summary>
	public partial class TblGuildQuestList
	{
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 길드 쾌스트 번호
		/// </summary>
		public int GuildQuestNo { get; set; }
		public short ServerNo { get; set; }
		/// <summary>
		/// _count1
		/// </summary>
		public int Count1 { get; set; }
		/// <summary>
		/// _count2
		/// </summary>
		public int Count2 { get; set; }
		/// <summary>
		/// _count3
		/// </summary>
		public int Count3 { get; set; }
		/// <summary>
		/// _count4
		/// </summary>
		public int Count4 { get; set; }
		/// <summary>
		/// _count5
		/// </summary>
		public int Count5 { get; set; }
		/// <summary>
		/// 쾌스트수락일시
		/// </summary>
		public DateTime OrderTime { get; set; }
		/// <summary>
		/// 제한시간
		/// </summary>
		public long? LimitTime { get; set; }
		/// <summary>
		/// 선점여부
		/// </summary>
		public bool IsPreoccupancy { get; set; }
	}
}
