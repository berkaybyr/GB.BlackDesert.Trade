namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 날씨 요소
	/// </summary>
	public partial class TblWeatherFactor
	{
		/// <summary>
		/// 마지막 수정일시
		/// </summary>
		public DateTime LastUpdateDate { get; set; }
		/// <summary>
		/// 슬롯번호
		/// </summary>
		public byte SlotNo { get; set; }
		/// <summary>
		/// _sectorX
		/// </summary>
		public int SectorX { get; set; }
		/// <summary>
		/// _sectorZ
		/// </summary>
		public int SectorZ { get; set; }
		/// <summary>
		/// 습기
		/// </summary>
		public double Humidity { get; set; }
		/// <summary>
		/// 섭씨
		/// </summary>
		public double Celsius { get; set; }
		/// <summary>
		/// 물
		/// </summary>
		public double Water { get; set; }
		/// <summary>
		/// 기름
		/// </summary>
		public double Oil { get; set; }
		/// <summary>
		/// 잔디
		/// </summary>
		public double Grass { get; set; }
	}
}
