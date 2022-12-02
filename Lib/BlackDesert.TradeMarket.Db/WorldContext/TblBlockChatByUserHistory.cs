namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblBlockChatByUserHistory
	{
		public long BlockNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public string? UserId { get; set; }
		public long CharacterNo { get; set; }
		public string CharacterName { get; set; } = null!;
		public string? UserIp { get; set; }
		public string TargetCharacterName { get; set; } = null!;
		public string ReasonChat { get; set; } = null!;
	}
}
