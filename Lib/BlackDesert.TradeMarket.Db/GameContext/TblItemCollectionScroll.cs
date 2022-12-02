namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemCollectionScroll
	{
		public long UserNo { get; set; }
		public int CollectionPoint { get; set; }
		public int CurrentGrade { get; set; }
		public DateTime? CoolTime { get; set; }
	}
}
