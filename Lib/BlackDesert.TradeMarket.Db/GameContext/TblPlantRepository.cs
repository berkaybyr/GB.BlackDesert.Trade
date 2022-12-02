namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 탐험 &amp; 탐험과 연계되는 컨텐츠 저장소
	/// </summary>
	public partial class TblPlantRepository
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 사용자번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 대상 노드의 WaypointKey
		/// </summary>
		public int WaypointKey { get; set; }
		/// <summary>
		/// _type 별로 의미가 다르다
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// _subType
		/// </summary>
		public int SubType { get; set; }
		/// <summary>
		/// _value
		/// </summary>
		public short Value { get; set; }
		public long Experience { get; set; }
		/// <summary>
		/// 업그레이드가 완료될 시각
		/// </summary>
		public DateTime DateTime { get; set; }
	}
}
