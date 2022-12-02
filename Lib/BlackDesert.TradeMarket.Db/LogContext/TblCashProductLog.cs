namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblCashProductLog
	{
		public long LogNo { get; set; }
		public short? OperationLogType { get; set; }
		public short? ServerNo { get; set; }
		public DateTime? RegisterDate { get; set; }
		public string? UserId { get; set; }
		public long? UserNo { get; set; }
		public string? UserIp { get; set; }
		public bool? IsUserGm { get; set; }
		public long? PlayMinuteOfUser { get; set; }
		public bool? IsPcRoom { get; set; }
		public bool? IsPcRoomPremium { get; set; }
		public bool? IsPvP { get; set; }
		public bool? IsGuestAccount { get; set; }
		public byte? GameAgeGradeType { get; set; }
		public string? MacAddress { get; set; }
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
		public int? CashProductNo { get; set; }
		public string? CashProductName { get; set; }
		public long? CashCount { get; set; }
		public long? CashBillingNo { get; set; }
		public long? TotalCash { get; set; }
		public long? LeftCash { get; set; }
		public long? Result { get; set; }
	}
}
