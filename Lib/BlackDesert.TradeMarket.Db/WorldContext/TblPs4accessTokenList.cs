namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4accessTokenList
	{
		public string UserId { get; set; } = null!;
		public string? AccessToken { get; set; }
		public string Ps4UserId { get; set; } = null!;
		public DateTime? LastUpdateTime { get; set; }
	}
}
