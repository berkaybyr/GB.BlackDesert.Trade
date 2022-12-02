namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSkillPreset
	{
		public long CharacterNo { get; set; }
		public int SlotNo { get; set; }
		public string SkillList { get; set; } = null!;
		public bool IsApply { get; set; }
		public int SkillAwakeningCount { get; set; }
		public int WeaponSkillAwakeningCount { get; set; }
		public int SuccessionSkillAwakeningCount { get; set; }
		public int SkillPoint { get; set; }
		public string CoolTimeList { get; set; } = null!;
		public string QuickSlotList { get; set; } = null!;
		public string CommandLockList { get; set; } = null!;
		public string SpiritLockList { get; set; } = null!;
		public string RingMenuList { get; set; } = null!;
	}
}
