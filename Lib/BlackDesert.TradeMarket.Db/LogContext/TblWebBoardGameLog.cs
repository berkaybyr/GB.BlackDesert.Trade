namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblWebBoardGameLog
	{
		public long LogNo { get; set; }
		public byte LogType { get; set; }
		public short OperationLogType { get; set; }
		public short ServerNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public string? UserId { get; set; }
		public long UserNo { get; set; }
		public string? UserIp { get; set; }
		public string? CharacterName { get; set; }
		public long? CharacterNo { get; set; }
		public byte DiceValue { get; set; }
		public byte StartPosition { get; set; }
		public byte DicePosition { get; set; }
		public byte NowPosition { get; set; }
		public int FinishCount { get; set; }
		public byte TodayCount { get; set; }
		public byte? PrizeType { get; set; }
		public long? Param0 { get; set; }
		public long? Param1 { get; set; }
		public long? Param2 { get; set; }
		public long? Param3 { get; set; }
		public short Reason { get; set; }
	}
}
