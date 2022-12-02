namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblOperationTicket
	{
		public DateTime RegisterDate { get; set; }
		public long TicketNo { get; set; }
		public short WorldNo { get; set; }
		public string CharacterName { get; set; } = null!;
		public string UserId { get; set; } = null!;
		public byte RequestType { get; set; }
		public string RequestList { get; set; } = null!;
		public string Reason { get; set; } = null!;
		public long GmUserNo { get; set; }
		public byte Priority { get; set; }
		public byte TicketState { get; set; }
		public long? ApprovedUserNo { get; set; }
		public DateTime UpdatedDate { get; set; }
		public string? ConfirmReason { get; set; }
	}
}
