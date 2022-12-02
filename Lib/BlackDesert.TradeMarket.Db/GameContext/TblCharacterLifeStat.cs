namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCharacterLifeStat
	{
		public long CharacterNo { get; set; }
		public byte MainType { get; set; }
		public byte SubType { get; set; }
		public int Stat { get; set; }
	}
}
