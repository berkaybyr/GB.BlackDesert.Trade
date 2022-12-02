namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWebLogEnableFlag
	{
		public bool WriteDebugLog { get; set; }
		public bool WriteInfoLog { get; set; }
		public bool? WriteWarringLog { get; set; }
		public bool? WriteErrorLog { get; set; }
		public bool? WriteFatalLog { get; set; }
	}
}
