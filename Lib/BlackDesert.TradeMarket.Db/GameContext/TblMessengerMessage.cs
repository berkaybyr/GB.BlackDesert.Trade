namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMessengerMessage
	{
		public long RoomNo { get; set; }
		public long MessageIndex { get; set; }
		public long SenderUserNo { get; set; }
		public string MessageContent { get; set; } = null!;
		public long EmoticonKey { get; set; }
		public DateTime MessageDate { get; set; }
		public long MessageRealIndex { get; set; }
	}
}
