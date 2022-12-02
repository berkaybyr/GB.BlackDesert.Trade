namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlackSpiritAdventureMonster
	{
		public long UserNo { get; set; }
		public int MonsterKey { get; set; }
		public byte MonsterType { get; set; }
		public int RegionKey { get; set; }
		public bool Status { get; set; }
		public DateTime SpawnDate { get; set; }
		public DateTime? KillDate { get; set; }
	}
}
