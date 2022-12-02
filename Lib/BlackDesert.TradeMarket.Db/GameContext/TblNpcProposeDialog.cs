namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// NPC 고백 시 대사 테이블
	/// </summary>
	public partial class TblNpcProposeDialog
	{
		/// <summary>
		/// index 번호
		/// </summary>
		public int Index { get; set; }
		/// <summary>
		/// npc 번호
		/// </summary>
		public int NpcKey { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		public string SenderName { get; set; } = null!;
		/// <summary>
		/// 타이틀
		/// </summary>
		public string Title { get; set; } = null!;
		/// <summary>
		/// 실패 시 메시지
		/// </summary>
		public string Fail { get; set; } = null!;
		/// <summary>
		/// 성공 시 메시지
		/// </summary>
		public string Success { get; set; } = null!;
		/// <summary>
		/// 헤어질 때 메시지
		/// </summary>
		public string Farewell { get; set; } = null!;
		public int TitleKey { get; set; }
	}
}
