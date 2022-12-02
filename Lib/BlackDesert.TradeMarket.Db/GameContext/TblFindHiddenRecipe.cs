namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFindHiddenRecipe
	{
		public int Recipe { get; set; }
		public long UserNo { get; set; }
		public DateTime FindTime { get; set; }
	}
}
