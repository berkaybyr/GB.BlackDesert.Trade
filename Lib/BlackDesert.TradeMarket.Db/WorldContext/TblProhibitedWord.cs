namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblProhibitedWord
	{
		public DateTime? RegisterDate { get; set; }
		public string ProhibitedWord { get; set; } = null!;
	}
}
