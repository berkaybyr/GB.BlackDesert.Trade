namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemOptionRepository
	{
		public long ItemNo { get; set; }
		public int ItemKey { get; set; }
		public int OptionType0 { get; set; }
		public int OptionType1 { get; set; }
		public int OptionType2 { get; set; }
		public int OptionType3 { get; set; }
		public int OptionType4 { get; set; }
		public int OptionParam0 { get; set; }
		public int OptionParam1 { get; set; }
		public int OptionParam2 { get; set; }
		public int OptionParam3 { get; set; }
		public int OptionParam4 { get; set; }
		public long ItemOptionChangeCount { get; set; }
		public long? ParentItemNo { get; set; }
		public bool LimitOption0 { get; set; }
		public bool LimitOption1 { get; set; }
		public bool LimitOption2 { get; set; }
		public bool LimitOption3 { get; set; }
		public bool LimitOption4 { get; set; }
		public DateTime LastUpdateTime { get; set; }
	}
}
