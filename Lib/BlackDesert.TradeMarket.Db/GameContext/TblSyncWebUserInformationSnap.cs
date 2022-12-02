namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSyncWebUserInformationSnap
	{
		public string UserId { get; set; } = null!;
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public long CharacterNo { get; set; }
		public string CharacterName { get; set; } = null!;
		public int Level { get; set; }
		public DateTime CreateDate { get; set; }
		public bool IsValid { get; set; }
		public byte ClassType { get; set; }
		public DateTime? DeletedDate { get; set; }
		public int AquiredPoint { get; set; }
		public bool IsGm { get; set; }
		public int OffenceValue { get; set; }
		public int DefenceValue { get; set; }
		public long? GuildNo { get; set; }
		public string? GuildName { get; set; }
	}
}
