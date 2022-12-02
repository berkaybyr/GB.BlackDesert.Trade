namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유저부가정보
	/// </summary>
	public partial class TblUserEtcInformation
	{
		/// <summary>
		/// 생성일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _userNo
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// _cpuBrandString
		/// </summary>
		public string? CpuBrandString { get; set; }
		/// <summary>
		/// _totalSystemMemory
		/// </summary>
		public int TotalSystemMemory { get; set; }
		/// <summary>
		/// _graphicsAdapterBrandString
		/// </summary>
		public string? GraphicsAdapterBrandString { get; set; }
		/// <summary>
		/// _resoulutionWidth
		/// </summary>
		public int ResoulutionWidth { get; set; }
		/// <summary>
		/// _resoulutionHeight
		/// </summary>
		public int ResoulutionHeight { get; set; }
		/// <summary>
		/// _textureQuality
		/// </summary>
		public byte TextureQuality { get; set; }
		/// <summary>
		/// _graphicOption
		/// </summary>
		public byte GraphicOption { get; set; }
		public bool? ConsoleCrossPlayOption { get; set; }
	}
}
