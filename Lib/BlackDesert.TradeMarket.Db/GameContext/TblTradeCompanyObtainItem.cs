namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblTradeCompanyObtainItem
	{
		public long OwnerUserNo { get; set; }
		public int ObtainItemNo { get; set; }
		public int ItemEnchantKey { get; set; }
		public long Count { get; set; }
	}
}
