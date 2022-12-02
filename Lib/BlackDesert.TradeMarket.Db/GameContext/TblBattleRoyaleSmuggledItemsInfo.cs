namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBattleRoyaleSmuggledItemsInfo
	{
		public long UserNo { get; set; }
		public int ItemKey { get; set; }
		public long Count { get; set; }
		public byte EnchantLevel { get; set; }
		public long ItemNo { get; set; }
	}
}
