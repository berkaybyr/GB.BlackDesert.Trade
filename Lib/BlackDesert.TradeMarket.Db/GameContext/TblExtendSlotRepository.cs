namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 확장 슬롯 정보
	/// </summary>
	public partial class TblExtendSlotRepository
	{
		/// <summary>
		/// 슬롯 타입
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 유저 혹은 캐릭터 고유 번호
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 지역번호 등 값
		/// </summary>
		public long VariousNo { get; set; }
		/// <summary>
		/// 확장 슬롯 개수
		/// </summary>
		public int Slot { get; set; }
		/// <summary>
		/// 등록 일시
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
