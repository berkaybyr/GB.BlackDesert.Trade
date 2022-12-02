namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblOperationTicketV3
	{
		public DateTime RegisterDate { get; set; }
		public long TicketNo { get; set; }
		public byte WhereType { get; set; }
		public long RequestWhereNo { get; set; }
		public int? RequestRoleGroupNo { get; set; }
		public string? RequestRoleGroupName { get; set; }
		public string RequestXmlName { get; set; } = null!;
		public string RequestDbName { get; set; } = null!;
		public string RequestSpName { get; set; } = null!;
		public string RequestList { get; set; } = null!;
		public string RequestReason { get; set; } = null!;
		public byte RequestType { get; set; }
		public byte TicketState { get; set; }
		public long? ConfirmWhereNo { get; set; }
		public int? ConfirmRoleGroupNo { get; set; }
		public string? ConfirmRoleGroupName { get; set; }
		public string? ConfirmReason { get; set; }
		public DateTime? ConfirmDate { get; set; }
	}
}
