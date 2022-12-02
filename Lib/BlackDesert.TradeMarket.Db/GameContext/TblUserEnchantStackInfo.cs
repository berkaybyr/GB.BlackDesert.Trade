namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserEnchantStackInfo
	{
		public long UserNo { get; set; }
		public byte EnableSlotCount { get; set; }
		public DateTime? EnchantCoolTime { get; set; }
	}
}
