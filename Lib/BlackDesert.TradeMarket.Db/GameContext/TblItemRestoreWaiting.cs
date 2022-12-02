namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemRestoreWaiting
	{
		public long RestoreNo { get; set; }
		public long RequestUserNo { get; set; }
		public long? ConfirmUserNo { get; set; }
		public DateTime RestoreRegDate { get; set; }
		public DateTime RegisterDate { get; set; }
		public bool? IsValid { get; set; }
		public int ItemKey { get; set; }
		public int ProductionRegionKey { get; set; }
		public DateTime? ExpirationDate { get; set; }
		public byte EnchantLevel { get; set; }
		public bool IsVested { get; set; }
		public bool IsSeized { get; set; }
		public bool? IsSealed { get; set; }
		public long BuyingPrice { get; set; }
		public byte ItemWhereType { get; set; }
		public long OwnerNo { get; set; }
		public long VariousNo { get; set; }
		public DateTime VariableDate { get; set; }
		public int? PushedItemKey0 { get; set; }
		public int? PushedItemKey1 { get; set; }
		public int? PushedItemKey2 { get; set; }
		public int? PushedItemKey3 { get; set; }
		public int? PushedItemKey4 { get; set; }
		public int? PushedItemKey5 { get; set; }
		public long Count { get; set; }
		public int Endurance { get; set; }
		public int MaxEndurance { get; set; }
		public byte[]? DyeingList { get; set; }
		public bool IsExpirationDyeing { get; set; }
		public DateTime? ConfirmWaitingDate { get; set; }
		public bool? IsSended { get; set; }
		public string? Memo { get; set; }
	}
}
