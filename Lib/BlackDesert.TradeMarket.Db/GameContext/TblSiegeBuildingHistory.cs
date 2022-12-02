namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSiegeBuildingHistory
	{
		public DateTime? RegisterDate { get; set; }
		public int? SiegeHistoryDate { get; set; }
		public bool IsVillageSiege { get; set; }
		public long GuildNo { get; set; }
		public string GuildName { get; set; } = null!;
		public long? MasterUserNo { get; set; }
		public string? MasterUserNickname { get; set; }
		public byte[]? GuildMark { get; set; }
		public int ItemKey { get; set; }
		public int? TerritoryKey { get; set; }
		public int? BuildRegionKey { get; set; }
		public double PosX { get; set; }
		public double PosY { get; set; }
		public double PosZ { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime CompletedDate { get; set; }
		public DateTime? DestroyedDate { get; set; }
		public long? DestroyerGuildNo { get; set; }
		public string? DestoryerGuildName { get; set; }
		public long? DestroyermasterUserNo { get; set; }
		public string? DestroyermasterUserNickname { get; set; }
		public byte[]? DestroyerguildMark { get; set; }
		public long? DestroyerCharacterNo { get; set; }
		public string? DestroyerCharacterName { get; set; }
	}
}
