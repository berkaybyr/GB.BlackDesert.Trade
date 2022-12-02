namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPurchasedSkin
	{
		public long UserNo { get; set; }
		public int SkinKey { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
