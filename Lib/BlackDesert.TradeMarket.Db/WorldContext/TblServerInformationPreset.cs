namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblServerInformationPreset
	{
		public DateTime RegistDate { get; set; }
		public string PresetName { get; set; } = null!;
		public string ServerName { get; set; } = null!;
		public short ServerType { get; set; }
		public bool IsSpareMachine { get; set; }
		public string MainIp { get; set; } = null!;
		public string PublicIp { get; set; } = null!;
		public string MacAddress { get; set; } = null!;
		public short WorldNo { get; set; }
		public string FieldDsn { get; set; } = null!;
		public string LogDsn { get; set; } = null!;
		public short StartSiegeTerritory { get; set; }
		public bool DoImperialDelivery { get; set; }
		public bool DoImperialProductDelivery { get; set; }
		public bool DontPvPtendencyDecrease { get; set; }
		public bool DoHorseRaceMatch { get; set; }
		public short ServerGroupNo { get; set; }
		public bool FixedCharge { get; set; }
		public bool IsLimitedLocalWar { get; set; }
		public bool IsSpeedChannel { get; set; }
		public bool DoCompetitionArsha { get; set; }
		public bool IsBalanceChannel { get; set; }
		public short IsSavageDefence { get; set; }
		public bool IsPcroomChannel { get; set; }
		public bool IsSteamChannel { get; set; }
		public bool IsPremiumChannel { get; set; }
		public short IsGuildBattleChannel { get; set; }
		public bool IsCantPvPchannel { get; set; }
		public bool IsFixedBossSpawn { get; set; }
		public bool StartNationSiege { get; set; }
		public string IsInstanceFieldMainServer { get; set; } = null!;
		public byte ServicePlatformType { get; set; }
		public bool IsSeasonChannel { get; set; }
		public bool IsSeasonNewbieChannel { get; set; }
		public bool IsHadumChannel { get; set; }
		public bool IsEventChannel { get; set; }
		public bool IsSequentialCheck { get; set; }
	}
}
