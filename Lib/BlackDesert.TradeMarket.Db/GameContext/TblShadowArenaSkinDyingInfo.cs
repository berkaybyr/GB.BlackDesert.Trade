namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaSkinDyingInfo
	{
		public long UserNo { get; set; }
		public int SkinKey { get; set; }
		public byte[]? DyeingInfo1 { get; set; }
		public byte[]? DyeingInfo2 { get; set; }
		public byte[]? DyeingInfo3 { get; set; }
		public byte[]? DyeingInfo4 { get; set; }
		public byte[]? DyeingInfo5 { get; set; }
	}
}
