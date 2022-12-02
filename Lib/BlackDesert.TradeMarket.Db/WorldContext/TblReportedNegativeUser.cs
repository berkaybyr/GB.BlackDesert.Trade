namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblReportedNegativeUser
	{
		public DateTime RegisterDate { get; set; }
		public byte Type { get; set; }
		public short ServerNo { get; set; }
		public long OwnerUserNo { get; set; }
		public long OwnerUserCharacterNo { get; set; }
		public string OwnerCharacterName { get; set; } = null!;
		public long TargetUserNo { get; set; }
		public long TargetUserCharacterNo { get; set; }
		public string TargetCharacterName { get; set; } = null!;
		public long PositionX { get; set; }
		public long PositionY { get; set; }
		public long PositionZ { get; set; }
		public string? Report { get; set; }
	}
}
