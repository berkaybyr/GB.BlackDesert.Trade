namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblServerChannelChatInformation
	{
		public int OrderNo { get; set; }
		public short ServerNo { get; set; }
		public long RoomNo { get; set; }
		public string RoomName { get; set; } = null!;
		public string RoomDesc { get; set; } = null!;
		public short MaxMemberCount { get; set; }
	}
}
