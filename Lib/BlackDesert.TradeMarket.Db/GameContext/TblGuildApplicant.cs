namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildApplicant
	{
		public DateTime RegisterDate { get; set; }
		public long GuildNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public string CharacterName { get; set; } = null!;
		public byte ClassType { get; set; }
		public int Level { get; set; }
		public int Wp { get; set; }
		public int ExplorationPoint { get; set; }
		public int OffenceValue { get; set; }
		public int AwakenValue { get; set; }
		public int DefenceValue { get; set; }
		public string? Introduction { get; set; }
	}
}
