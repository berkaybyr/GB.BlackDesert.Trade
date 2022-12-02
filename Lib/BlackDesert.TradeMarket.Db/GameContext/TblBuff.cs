namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 버프를 저장하기 위한 테이블
	/// </summary>
	public partial class TblBuff
	{
		/// <summary>
		/// 버프가 적용되는 캐릭터의 번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 서버에서 사용하는 버프키
		/// </summary>
		public int BuffKey { get; set; }
		/// <summary>
		/// 버프의 남은 시간
		/// </summary>
		public long RemainTime { get; set; }
		/// <summary>
		/// 버프의 남은 적용 횟수
		/// </summary>
		public int? LeftApplyingCount { get; set; }
	}
}
