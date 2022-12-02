namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblAcoinChargeNumbersByWeb
	{
		public short WorldNo { get; set; }
		public long ItemNo { get; set; }
		public string? ChargeNo { get; set; }
		public byte ChargeType { get; set; }
		public int ItemKey { get; set; }
		public long? MailNo { get; set; }
		public bool IsCanceled { get; set; }
		public DateTime RegDate { get; set; }
		public DateTime? UpdDate { get; set; }
	}
}
