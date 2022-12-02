﻿namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4cashProductRefundInfo
	{
		public long RefundNo { get; set; }
		public string UserId { get; set; } = null!;
		public string EntitlementId { get; set; } = null!;
		public string ProductId { get; set; } = null!;
		public long RefundCount { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime? CompleteDate { get; set; }
		public DateTime? CancelDate { get; set; }
		public byte RefundState { get; set; }
		public long BeforeConsumeCount { get; set; }
		public long AfterConsumeCount { get; set; }
		public long BeforeUseCount { get; set; }
		public long AfterUseCount { get; set; }
		public bool IsCheckProductCount { get; set; }
	}
}
