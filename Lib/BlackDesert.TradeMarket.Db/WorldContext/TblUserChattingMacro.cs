namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유저를 위한 채팅 매크로 정보
	/// </summary>
	public partial class TblUserChattingMacro
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 매크로 번호
		/// </summary>
		public int MacroNo { get; set; }
		/// <summary>
		/// 채팅 타입
		/// </summary>
		public byte ChatType { get; set; }
		/// <summary>
		/// 채팅 메시지
		/// </summary>
		public string ChatMessage { get; set; } = null!;
	}
}
