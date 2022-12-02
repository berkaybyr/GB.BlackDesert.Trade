namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저를 위한 소셜액션 키워드 변경정보
	/// </summary>
	public partial class TblUserSocialActionConfig
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 소셜액션 키
		/// </summary>
		public int SocialActionKey { get; set; }
		/// <summary>
		/// 타입(0:명령어,1:구문분석용)
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 저장된 데이터
		/// </summary>
		public string Data { get; set; } = null!;
	}
}
