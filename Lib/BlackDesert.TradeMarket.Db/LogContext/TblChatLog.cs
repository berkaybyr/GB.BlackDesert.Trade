namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblChatLog
	{
		public long LogNo { get; set; }
		public short OperationLogType { get; set; }
		public short ServerNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public long UserNo { get; set; }
		public string UserIp { get; set; } = null!;
		public bool IsUserGm { get; set; }
		public long? PlayMinuteOfUser { get; set; }
		public bool IsPcRoom { get; set; }
		public bool IsPcRoomPremium { get; set; }
		public bool? IsPvP { get; set; }
		public bool? IsGuestAccount { get; set; }
		public byte? GameAgeGradeType { get; set; }
		public string CharacterName { get; set; } = null!;
		public long CharacterNo { get; set; }
		public int? CharacterTendency { get; set; }
		public byte ChatType { get; set; }
		public string ChatMessage { get; set; } = null!;
		public string? ToCharacterName { get; set; }
		public long? ToCharacterNo { get; set; }
		public int? ChatLinkedItemKey { get; set; }
		public long GuildNo { get; set; }
		public string? ChannelChatRoomName { get; set; }
	}
}
