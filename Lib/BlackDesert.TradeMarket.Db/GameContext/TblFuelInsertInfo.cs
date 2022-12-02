namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFuelInsertInfo
	{
		public long ObjectNo { get; set; }
		public long ItemKey { get; set; }
		public long ItemCount { get; set; }
		public long VaryCount { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
