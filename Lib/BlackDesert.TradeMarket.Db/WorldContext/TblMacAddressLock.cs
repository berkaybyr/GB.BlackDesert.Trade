namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblMacAddressLock
	{
		public long UserNo { get; set; }
		public string MacAddress { get; set; } = null!;
		public bool BanIfDifferentLogin { get; set; }
		public bool? IsValid { get; set; }
		public bool LogDifferentLogin { get; set; }
		public bool MacBanDifferentLogin { get; set; }
	}
}
