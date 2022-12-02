namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblPointResourceLogInmem
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
		public int? RemainedSkillPoint { get; set; }
		public int? AquiredSkillPoint { get; set; }
		public short? CurrentFieldNo { get; set; }
		public long? CurrentPositionX { get; set; }
		public long? CurrentPositionY { get; set; }
		public long? CurrentPositionZ { get; set; }
		public byte? RegionType { get; set; }
		public bool? IsDoingSiege { get; set; }
		public long? PlayMinuteOfCharacter { get; set; }
		public byte? ResourceType { get; set; }
		public int? VariedPoint { get; set; }
		public int? RemainedPoint { get; set; }
		public int? AquiredPoint { get; set; }
		public short? Reason { get; set; }
	}
}
