namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblItemLogInmem
	{
		public long LogNo { get; set; }
		public short OperationLogType { get; set; }
		public short ServerNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public string? UserId { get; set; }
		public long UserNo { get; set; }
		public string? UserIp { get; set; }
		public bool? IsUserGm { get; set; }
		public long? PlayMinuteOfUser { get; set; }
		public bool IsPcRoom { get; set; }
		public bool IsPcRoomPremium { get; set; }
		public bool? IsPvP { get; set; }
		public bool? IsGuestAccount { get; set; }
		public byte? GameAgeGradeType { get; set; }
		public string? CharacterName { get; set; }
		public long? CharacterNo { get; set; }
		public int? CharacterLevel { get; set; }
		public long? CharacterExperience { get; set; }
		public int? CharacterTendency { get; set; }
		public long? PlayMinuteOfCharacter { get; set; }
		public double? CurrentPositionX { get; set; }
		public double? CurrentPositionY { get; set; }
		public double? CurrentPositionZ { get; set; }
		public bool? IsDoingSiege { get; set; }
		public long ItemNo { get; set; }
		public int ItemKey { get; set; }
		public int? PushedItemKey0 { get; set; }
		public int? PushedItemKey1 { get; set; }
		public int? PushedItemKey2 { get; set; }
		public int? PushedItemKey3 { get; set; }
		public int? PushedItemKey4 { get; set; }
		public int? PushedItemKey5 { get; set; }
		public DateTime? ExpirationDate { get; set; }
		public int Endurance { get; set; }
		public int MaxEndurance { get; set; }
		public byte ItemWhereType { get; set; }
		public long? VariousNo { get; set; }
		public bool? IsFocused { get; set; }
		public long? BeforeCount { get; set; }
		public long VariedCount { get; set; }
		public string? PeerCharacterName { get; set; }
		public long? PeerCharacterNo { get; set; }
		public int? PeerCharacterKey { get; set; }
		public bool? PeerCharacterisGm { get; set; }
		public short Reason { get; set; }
		public long? PeerItemNo { get; set; }
		public byte? PeerItemWhereType { get; set; }
		public long? PeerVariousNo { get; set; }
		public long? Param1 { get; set; }
		public long? Param2 { get; set; }
		public long? Param3 { get; set; }
		public long? Param4 { get; set; }
		public long? Param5 { get; set; }
		public long? Param6 { get; set; }
		public string? TextParam1 { get; set; }
		public string? TextParam2 { get; set; }
		public int? CashProductNo { get; set; }
		public long? CashCount { get; set; }
		public string? ReceivingUserId { get; set; }
		public long? ReceivingUserNo { get; set; }
		public string? ReceivingCharacterName { get; set; }
		public long? ReceivingCharacterNo { get; set; }
		public long? ReceivingMailNo { get; set; }
	}
}
