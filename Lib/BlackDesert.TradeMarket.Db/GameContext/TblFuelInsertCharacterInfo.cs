namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFuelInsertCharacterInfo
	{
		public long OwnerNo { get; set; }
		public long ObjectNo { get; set; }
		public long Count { get; set; }
		public int? Hp { get; set; }
		public byte ObjectState { get; set; }
		public DateTime LastUpdateTime { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
