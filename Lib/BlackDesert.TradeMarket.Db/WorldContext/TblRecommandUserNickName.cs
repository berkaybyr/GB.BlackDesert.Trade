namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 가문 생성시 추천 닉네임
	/// </summary>
	public partial class TblRecommandUserNickName
	{
		/// <summary>
		/// 추천 닉네임 인덱스
		/// </summary>
		public int RecommandNickNameIndex { get; set; }
		/// <summary>
		/// 추천 닉네임 스트링
		/// </summary>
		public string RecommandNickName { get; set; } = null!;
		/// <summary>
		/// 추천 닉네임 뒤에 붙을 고유 ID
		/// </summary>
		public int RecommandNickNameId { get; set; }
	}
}
