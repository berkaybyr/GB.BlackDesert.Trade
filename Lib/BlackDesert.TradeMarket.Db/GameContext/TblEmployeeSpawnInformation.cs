namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblEmployeeSpawnInformation
	{
		public long UserNo { get; set; }
		public byte Status { get; set; }
		public int CharacterKey { get; set; }
		public int PositionIndex { get; set; }
		public DateTime SpawnTime { get; set; }
		public DateTime NextSpawnTime { get; set; }
	}
}
