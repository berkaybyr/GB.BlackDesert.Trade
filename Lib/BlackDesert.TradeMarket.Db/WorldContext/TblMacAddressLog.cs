namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblMacAddressLog
	{
		public long UserNo { get; set; }
		public string MacAddress { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
		public string? UserId { get; set; }
		public string? UserNickname { get; set; }
		public bool? IsHijackLogin { get; set; }
		public string? CpuBrandString { get; set; }
		public string? GraphicsAdapterBrandString { get; set; }
		public int RecordId { get; set; }
		public string? Ip { get; set; }
	}
}
