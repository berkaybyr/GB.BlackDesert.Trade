namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblAutoBuyBoughtItemsLog
	{
		public long Id { get; set; }
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public int ItemKey { get; set; }
		public int EnchantLevel { get; set; }
		public long Count { get; set; }
		public long ItemOriginalPrice { get; set; }
		public long GivenSilver { get; set; }
		public byte Percent { get; set; }
		public bool IsRingBuff { get; set; }
	}
}
