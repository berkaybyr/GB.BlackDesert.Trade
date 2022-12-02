namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFameInfo
	{
		public long CharacterNo { get; set; }
		public int Fame { get; set; }
		public int KillCount { get; set; }
		public bool IsSheriff { get; set; }
	}
}
