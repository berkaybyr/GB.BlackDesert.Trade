namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBadPlayerList
	{
		public long CharacterNo { get; set; }
		public long BadCharacterNo { get; set; }
		public string BadUserNickname { get; set; } = null!;
		public string BadCharacterName { get; set; } = null!;
		public string DeadRegion { get; set; } = null!;
		public DateTime DeadTime { get; set; }
	}
}
