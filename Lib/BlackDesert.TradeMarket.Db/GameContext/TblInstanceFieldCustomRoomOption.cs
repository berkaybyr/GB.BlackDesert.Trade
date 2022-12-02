namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceFieldCustomRoomOption
	{
		public short ServerNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public int UniqueIndex { get; set; }
		public long HostUserNo { get; set; }
		public bool IsShow { get; set; }
		public int AiCount { get; set; }
		public short AiLevel { get; set; }
		public bool IsHostObserver { get; set; }
		public bool IsShowNickName { get; set; }
		public byte MinTier { get; set; }
		public byte MaxTier { get; set; }
		public byte MatchType { get; set; }
	}
}
