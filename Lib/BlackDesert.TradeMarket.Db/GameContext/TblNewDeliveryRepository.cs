namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblNewDeliveryRepository
	{
		public long UserNo { get; set; }
		public byte Index { get; set; }
		public long ItemNo { get; set; }
		public int From { get; set; }
		public int To { get; set; }
		public DateTime RegisterDate { get; set; }
		public int DeliveryTime { get; set; }
	}
}
