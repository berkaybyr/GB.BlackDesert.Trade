namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBattleRoyaleUserInfo
	{
		public long UserNo { get; set; }
		public byte ClassType { get; set; }
		public int SkinKey { get; set; }
		public int WeaponSkinKey { get; set; }
		public bool IsNormalMode { get; set; }
		public int InstanceFieldKey { get; set; }
		public int TotalUserCount { get; set; }
		public int OrigOnlineRanking { get; set; }
		public int AfterOnlineRanking { get; set; }
		public string? PartyBotClassSetting { get; set; }
		public byte AutoMatchingType { get; set; }
	}
}
