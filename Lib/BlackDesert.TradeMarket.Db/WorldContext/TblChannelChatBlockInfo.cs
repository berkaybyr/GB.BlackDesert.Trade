namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblChannelChatBlockInfo
	{
		public long UserNo { get; set; }
		public short? AvailableBlockCount { get; set; }
		public DateTime LastUpdateTime { get; set; }
		public short? BlockedCount { get; set; }
		public DateTime ChattingBlockEndTime { get; set; }
		public DateTime ChannelJoinBlockEndTime { get; set; }
	}
}
