namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMessengerInfo
	{
		public long RoomNo { get; set; }
		public byte RoomType { get; set; }
		public long UserNo { get; set; }
		public long MessageReadIndex { get; set; }
		public bool? AlarmIsOn { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
