namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblNpcShopItemBuyCount
	{
		public bool IsUserNo { get; set; }
		public long UserCharacterNo { get; set; }
		public int ItemSubGroupKey { get; set; }
		public int ItemEnchantKey { get; set; }
		public int Count { get; set; }
		public DateTime ResetTime { get; set; }
	}
}
