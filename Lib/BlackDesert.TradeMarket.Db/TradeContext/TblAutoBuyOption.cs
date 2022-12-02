namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblAutoBuyOption
	{
		public bool IsAutoBuyOpen { get; set; }
		public bool CheckEmail { get; set; }
		public bool CheckEmailConfirmed { get; set; }
		public long MaxPriceLimit { get; set; }
		public byte SilverPercent { get; set; }
		public byte PremiumPercent { get; set; }
		public byte RingSilverBuff { get; set; }
		public byte ItemWaitDay { get; set; }
	}
}
