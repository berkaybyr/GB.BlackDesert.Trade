namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceFieldMatching
	{
		public short ServerNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public int UniqueIndex { get; set; }
		public byte IsMatching { get; set; }
		public int? MatchedCount { get; set; }
		public int? BotCount { get; set; }
		public string? HostUserNickName { get; set; }
		public string? Title { get; set; }
		public int InstanceFieldMapKey { get; set; }
		public string? Password { get; set; }
		public long? PartyId { get; set; }
		public long HostUserNo { get; set; }
		public byte SessionLevel { get; set; }
		public short AiLevel { get; set; }
		public string? GameId { get; set; }
		public byte CloseFlag { get; set; }
		public DateTime GameStartTime { get; set; }
	}
}
