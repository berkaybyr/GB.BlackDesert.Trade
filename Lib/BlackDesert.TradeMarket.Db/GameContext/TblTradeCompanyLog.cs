namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblTradeCompanyLog
	{
		public DateTime RegisterDate { get; set; }
		public long OwnerUserNo { get; set; }
		public int TradeGroupIndex { get; set; }
		public byte LogType { get; set; }
		public int Param1 { get; set; }
		public int? Param2 { get; set; }
		public int? Param3 { get; set; }
		public int? Param4 { get; set; }
	}
}
