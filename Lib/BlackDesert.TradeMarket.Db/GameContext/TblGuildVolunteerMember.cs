namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 용병 리스트
	/// </summary>
	public partial class TblGuildVolunteerMember
	{
		/// <summary>
		/// 등록일(길드연합장의 등록일)
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 용병 길드 넘버
		/// </summary>
		public long VolunteerGuilNo { get; set; }
		/// <summary>
		/// 용병 계약 금액
		/// </summary>
		public long ContractAmount { get; set; }
		/// <summary>
		/// 용병 계약 혜택
		/// </summary>
		public long ContractBenefit { get; set; }
		/// <summary>
		/// 용병 거점전 참여
		/// </summary>
		public bool? IsSiegeParticipant { get; set; }
		/// <summary>
		/// 길드 자금 사용 한도
		/// </summary>
		public long MyPriceLimit { get; set; }
		/// <summary>
		/// 길드 자금 사용 한도 검사 유/무
		/// </summary>
		public bool? IsPriceLimit { get; set; }
		public int SiegeMercenaryCost { get; set; }
		public long UserCharacterNoForCost { get; set; }
		public int SiegeMedalCount { get; set; }
		public int SiegeItemKey { get; set; }
		public DateTime? LastSiegeRewardDate { get; set; }
	}
}
