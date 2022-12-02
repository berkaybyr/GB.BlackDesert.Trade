namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// tier 정보
	/// </summary>
	public partial class TblServantTierInfo
	{
		/// <summary>
		/// 탑승물 characterKey
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 탑승물 tier
		/// </summary>
		public int Tier { get; set; }
		/// <summary>
		/// 탑승물 성별 (0: 수컷, 1: 암컷)
		/// </summary>
		public bool SexType { get; set; }
	}
}
