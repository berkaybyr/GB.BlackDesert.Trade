namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 집의 대량생산기능을 위한 데이터 목록
	/// </summary>
	public partial class TblHouseLargeCraft
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// _houseKey
		/// </summary>
		public int HouseKey { get; set; }
		/// <summary>
		/// 집 대량생산 키
		/// </summary>
		public int LargeExchangeKey { get; set; }
		/// <summary>
		/// 대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
		/// </summary>
		public long CompletePoint0 { get; set; }
		/// <summary>
		/// 대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
		/// </summary>
		public long CompletePoint1 { get; set; }
		/// <summary>
		/// 대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
		/// </summary>
		public long CompletePoint2 { get; set; }
		/// <summary>
		/// 대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
		/// </summary>
		public long CompletePoint3 { get; set; }
		/// <summary>
		/// 대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
		/// </summary>
		public long CompletePoint4 { get; set; }
		/// <summary>
		/// 대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
		/// </summary>
		public long CompletePoint5 { get; set; }
	}
}
