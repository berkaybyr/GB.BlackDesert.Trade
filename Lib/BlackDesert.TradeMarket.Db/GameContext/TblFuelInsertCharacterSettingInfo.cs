namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFuelInsertCharacterSettingInfo
	{
		public long ObjectNo { get; set; }
		public int CharacterKey { get; set; }
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public short FieldNo { get; set; }
		public short FieldIndex { get; set; }
		public float PosX { get; set; }
		public float PosY { get; set; }
		public float PosZ { get; set; }
		public double DirX { get; set; }
		public double DirY { get; set; }
		public double DirZ { get; set; }
		public short ServerNo { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
