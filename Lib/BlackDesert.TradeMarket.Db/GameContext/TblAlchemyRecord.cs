namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 연금(요리) 기록 테이블
	/// </summary>
	public partial class TblAlchemyRecord
	{
		/// <summary>
		/// 기록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 타입(연금,요리)
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 지식의키
		/// </summary>
		public int MentalCardKey { get; set; }
		/// <summary>
		/// 지식을 얻을때 나온 결과 아이템
		/// </summary>
		public int ResultItemKey { get; set; }
		/// <summary>
		/// 아이템키값0
		/// </summary>
		public int? ItemKey0 { get; set; }
		/// <summary>
		/// 아이템의갯수0
		/// </summary>
		public long? ItemCount0 { get; set; }
		/// <summary>
		/// 아이템키값1
		/// </summary>
		public int? ItemKey1 { get; set; }
		/// <summary>
		/// 아이템의갯수1
		/// </summary>
		public long? ItemCount1 { get; set; }
		/// <summary>
		/// 아이템키값2
		/// </summary>
		public int? ItemKey2 { get; set; }
		/// <summary>
		/// 아이템의갯수2
		/// </summary>
		public long? ItemCount2 { get; set; }
		/// <summary>
		/// 아이템키값3
		/// </summary>
		public int? ItemKey3 { get; set; }
		/// <summary>
		/// 아이템의갯수3
		/// </summary>
		public long? ItemCount3 { get; set; }
		/// <summary>
		/// 아이템키값4
		/// </summary>
		public int? ItemKey4 { get; set; }
		/// <summary>
		/// 아이템의갯수4
		/// </summary>
		public long? ItemCount4 { get; set; }
		/// <summary>
		/// 아이템키값5
		/// </summary>
		public int? ItemKey5 { get; set; }
		/// <summary>
		/// 아이템의갯수5
		/// </summary>
		public long? ItemCount5 { get; set; }
		/// <summary>
		/// 아이템키값6
		/// </summary>
		public int? ItemKey6 { get; set; }
		/// <summary>
		/// 아이템의갯수6
		/// </summary>
		public long? ItemCount6 { get; set; }
		/// <summary>
		/// 아이템키값7
		/// </summary>
		public int? ItemKey7 { get; set; }
		/// <summary>
		/// 아이템의갯수7
		/// </summary>
		public long? ItemCount7 { get; set; }
	}
}
