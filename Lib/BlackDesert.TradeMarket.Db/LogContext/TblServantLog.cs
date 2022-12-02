namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblServantLog
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
		public long? ServantNo { get; set; }
		public string? ServantName { get; set; }
		public int? ServantLevel { get; set; }
		public long? ServantExperience { get; set; }
		public int? ServantCharacterKey { get; set; }
		public int? ServantHp { get; set; }
		public int? ServantMp { get; set; }
		public int? RegionKey { get; set; }
		public short? ServantCurrentFieldNo { get; set; }
		public short? ServantCurrentFieldIndex { get; set; }
		public long? ServantCurrentPositionX { get; set; }
		public long? ServantCurrentPositionY { get; set; }
		public long? ServantCurrentPositionZ { get; set; }
		public long? Param1 { get; set; }
		public long? Param2 { get; set; }
		public long? Param3 { get; set; }
		public short Reason { get; set; }
	}
}
