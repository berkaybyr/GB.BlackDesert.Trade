namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMarbleGameMap
	{
		public long UserNo { get; set; }
		public byte MarbleKey { get; set; }
		public int NowPosition { get; set; }
		public DateTime? NextPlayDiceDate { get; set; }
		public DateTime RegisterDate { get; set; }
		public int UseCardKey { get; set; }
	}
}
