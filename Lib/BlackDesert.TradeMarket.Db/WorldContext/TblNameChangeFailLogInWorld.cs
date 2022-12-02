namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblNameChangeFailLogInWorld
	{
		public string? MDate { get; set; }
		public long? OwnerNo { get; set; }
		public int? NameChangeType { get; set; }
		public string? Name { get; set; }
		public string? BeforeName { get; set; }
		public int? Result { get; set; }
		public int? Rv { get; set; }
	}
}
