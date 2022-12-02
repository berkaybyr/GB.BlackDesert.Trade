namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPersonalMonsterInformation
	{
		public long UserNo { get; set; }
		public int CharacterKey { get; set; }
		public DateTime SpawnTime { get; set; }
		public int PositionIndex { get; set; }
		public int RemainHp { get; set; }
		public byte Option { get; set; }
		public byte Level { get; set; }
		public DateTime LevelupTime { get; set; }
	}
}
