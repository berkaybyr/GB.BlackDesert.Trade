namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaBriefUserInformation
	{
		public long UserNo { get; set; }
		public int AccountLevel { get; set; }
		public long AccountExp { get; set; }
		public bool IsOnline { get; set; }
		public bool IsEnterBattle { get; set; }
		public DateTime ExpBoostEndTime { get; set; }
		public DateTime MoneyBoostEndTime { get; set; }
		public string? SkinSetting { get; set; }
		public bool IsNewMail { get; set; }
		public DateTime AllCharacterBoostEndTime { get; set; }
		public int PreliminaryMatchTicket { get; set; }
		public int MainMatchTicket { get; set; }
		public int SpecialMatchTicket { get; set; }
		public byte? LastClassType { get; set; }
		public bool? IsTutorialComplete { get; set; }
		public string? WeaponSkinSetting { get; set; }
		public int CurrentAccountRewardLevel { get; set; }
		public short SelectedProfileIconKey { get; set; }
		public short? SelectedProfileFrameKey { get; set; }
		public short? SelectedProfileEffectKey { get; set; }
		public byte? LastTutorialFlowType { get; set; }
		public byte AuthorityIndex { get; set; }
	}
}
