namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlackSpiritAdventure
	{
		public long UserNo { get; set; }
		public int RegionKey { get; set; }
		public int TerritoryKey { get; set; }
		public byte RemainMoveCount { get; set; }
		public byte TodayChargeCount { get; set; }
		public byte Level { get; set; }
		public int Exp { get; set; }
		public bool IsMainQuest { get; set; }
		public string? MapPiece { get; set; }
		public int? BoxRegionKey { get; set; }
		public DateTime? RestUpdateDate { get; set; }
		public DateTime MoveCountUpdateDate { get; set; }
		public DateTime LastPlayDate { get; set; }
	}
}
