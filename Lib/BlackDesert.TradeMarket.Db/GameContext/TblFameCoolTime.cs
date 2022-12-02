namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFameCoolTime
	{
		public long CharacterNo { get; set; }
		public long BadCharacterNo { get; set; }
		public DateTime LastFameUpdateTime { get; set; }
	}
}
