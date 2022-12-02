namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCashItemBuyCountBak
	{
		public DateTime? RegisterDate { get; set; }
		public bool IsUserNo { get; set; }
		public long UserCharacterNo { get; set; }
		public int CashProductNo { get; set; }
		public int Count { get; set; }
		public long ResetTime { get; set; }
		public bool? Type { get; set; }
	}
}
