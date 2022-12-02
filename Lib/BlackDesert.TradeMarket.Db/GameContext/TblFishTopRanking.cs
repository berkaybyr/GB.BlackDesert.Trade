namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 낚시 TOP 랭킹
	/// </summary>
	public partial class TblFishTopRanking
	{
		/// <summary>
		/// 낚은 시간
		/// </summary>
		public DateTime LastUpdateDate { get; set; }
		/// <summary>
		/// 어류도감 키
		/// </summary>
		public int EncyclopediaKey { get; set; }
		/// <summary>
		/// 어류도감 키
		/// </summary>
		public int FishLength { get; set; }
		/// <summary>
		/// _positionX
		/// </summary>
		public long PositionX { get; set; }
		/// <summary>
		/// _positionY
		/// </summary>
		public long PositionY { get; set; }
		/// <summary>
		/// _positionZ
		/// </summary>
		public long PositionZ { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 캐릭터명
		/// </summary>
		public string CharacterName { get; set; } = null!;
		/// <summary>
		/// 가문명
		/// </summary>
		public string? UserNickname { get; set; }
	}
}
