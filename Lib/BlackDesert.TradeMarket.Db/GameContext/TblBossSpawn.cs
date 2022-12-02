namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBossSpawn
	{
		public long SummonerNo { get; set; }
		public int SpawnKey { get; set; }
		public int SpawnCost { get; set; }
		public int SpawnCount { get; set; }
		public DateTime ResetDateTime { get; set; }
	}
}
