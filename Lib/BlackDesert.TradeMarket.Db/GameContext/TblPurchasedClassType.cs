namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPurchasedClassType
	{
		public long UserNo { get; set; }
		public byte ClassType { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
