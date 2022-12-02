namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserEnchantStackSlot
	{
		public long UserNo { get; set; }
		public byte SlotNo { get; set; }
		public int EnchantStack { get; set; }
		public long EnchantStackExp { get; set; }
		public int EnchantAddedStack { get; set; }
	}
}
