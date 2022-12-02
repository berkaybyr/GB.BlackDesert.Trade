namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblAuctionBidderVer2GuildHouseBak
	{
		public DateTime? BackupDate { get; set; }
		public DateTime? RegisterDate { get; set; }
		public long? AuctionGoodsNo { get; set; }
		public long? UserNo { get; set; }
		public long? CharacterNo { get; set; }
		public int? AuctionKey { get; set; }
		public long? BidPrice { get; set; }
		public long? SuccessBidder { get; set; }
		public long? BidPriceOwnerNo { get; set; }
		public byte? BidCount { get; set; }
		public DateTime? DeletedDate { get; set; }
	}
}
