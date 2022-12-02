namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSkillPresetSlot
	{
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public int SlotCount { get; set; }
		public int CashSlotItemCount { get; set; }
	}
}
