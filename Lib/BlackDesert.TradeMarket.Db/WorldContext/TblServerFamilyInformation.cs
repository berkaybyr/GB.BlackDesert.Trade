namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblServerFamilyInformation
	{
		public bool? IsValid { get; set; }
		public short FromServerNo { get; set; }
		public short ToServerNo { get; set; }
	}
}
