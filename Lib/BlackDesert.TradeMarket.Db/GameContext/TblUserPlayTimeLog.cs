namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserPlayTimeLog
	{
		public int? MDate { get; set; }
		public long? UserNo { get; set; }
		public int? PcRoomPlayTimePerDay { get; set; }
		public int? PlayTimePerDay { get; set; }
	}
}
