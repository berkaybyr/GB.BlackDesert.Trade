namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 날씨 동적 요소
	/// </summary>
	public partial class TblWeatherDynamicFactor
	{
		/// <summary>
		/// 마지막 수정일시
		/// </summary>
		public DateTime LastUpdateDate { get; set; }
		/// <summary>
		/// _positionX
		/// </summary>
		public double PositionX { get; set; }
		/// <summary>
		/// _positionY
		/// </summary>
		public double PositionY { get; set; }
		/// <summary>
		/// _positionZ
		/// </summary>
		public double PositionZ { get; set; }
		/// <summary>
		/// 속도
		/// </summary>
		public double Speed { get; set; }
		/// <summary>
		/// 방향
		/// </summary>
		public double Direction { get; set; }
		/// <summary>
		/// 최소반경
		/// </summary>
		public double RadiusMin { get; set; }
		/// <summary>
		/// 최대반경
		/// </summary>
		public double RadiusMax { get; set; }
		/// <summary>
		/// 구름비율(운량)
		/// </summary>
		public double CloudRate { get; set; }
		/// <summary>
		/// 강수량
		/// </summary>
		public double RainAmount { get; set; }
		/// <summary>
		/// 기압
		/// </summary>
		public double AirPress { get; set; }
	}
}
