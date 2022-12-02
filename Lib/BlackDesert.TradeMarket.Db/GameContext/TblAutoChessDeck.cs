namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblAutoChessDeck
	{
		public long UserNo { get; set; }
		public long CardKey { get; set; }
		public int Grade { get; set; }
		public int CharacterKey { get; set; }
		public int Level { get; set; }
		public int Hp { get; set; }
		public long Experience { get; set; }
		public int Offence { get; set; }
		public int Defence { get; set; }
	}
}
