namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유저를 위한 게임 옵션 정보
	/// </summary>
	public partial class TblUserGameOption
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 게임 옵션 데이터
		/// </summary>
		public string GameOptionSerializedData { get; set; } = null!;
	}
}
