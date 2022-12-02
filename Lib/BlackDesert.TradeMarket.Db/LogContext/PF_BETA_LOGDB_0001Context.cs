using Microsoft.EntityFrameworkCore;

namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class PF_BETA_LOGDB_0001Context : DbContext
	{
		public PF_BETA_LOGDB_0001Context()
		{
		}

		public PF_BETA_LOGDB_0001Context(DbContextOptions<PF_BETA_LOGDB_0001Context> options)
			: base(options)
		{
		}

		public virtual DbSet<DimLogOperationLogReason> DimLogOperationLogReasons { get; set; } = null!;
		public virtual DbSet<TblAuctionLog> TblAuctionLogs { get; set; } = null!;
		public virtual DbSet<TblCashProductLog> TblCashProductLogs { get; set; } = null!;
		public virtual DbSet<TblCashProductLogExInmem> TblCashProductLogExInmems { get; set; } = null!;
		public virtual DbSet<TblCashProductLogExNew> TblCashProductLogExNews { get; set; } = null!;
		public virtual DbSet<TblChatLog> TblChatLogs { get; set; } = null!;
		public virtual DbSet<TblChatLogInmem> TblChatLogInmems { get; set; } = null!;
		public virtual DbSet<TblGmCommandLog> TblGmCommandLogs { get; set; } = null!;
		public virtual DbSet<TblGmCommandLogInmem> TblGmCommandLogInmems { get; set; } = null!;
		public virtual DbSet<TblGuildSiegeLogInmem> TblGuildSiegeLogInmems { get; set; } = null!;
		public virtual DbSet<TblItemLog> TblItemLogs { get; set; } = null!;
		public virtual DbSet<TblItemLogInmem> TblItemLogInmems { get; set; } = null!;
		public virtual DbSet<TblLogReasonGroup> TblLogReasonGroups { get; set; } = null!;
		public virtual DbSet<TblLogReasonGroupName> TblLogReasonGroupNames { get; set; } = null!;
		public virtual DbSet<TblMiscLog> TblMiscLogs { get; set; } = null!;
		public virtual DbSet<TblMiscLogInmem> TblMiscLogInmems { get; set; } = null!;
		public virtual DbSet<TblPointResourceLog> TblPointResourceLogs { get; set; } = null!;
		public virtual DbSet<TblPointResourceLogInmem> TblPointResourceLogInmems { get; set; } = null!;
		public virtual DbSet<TblServantLog> TblServantLogs { get; set; } = null!;
		public virtual DbSet<TblServantLogInmem> TblServantLogInmems { get; set; } = null!;
		public virtual DbSet<TblServiceLog> TblServiceLogs { get; set; } = null!;
		public virtual DbSet<TblTrPerformance> TblTrPerformances { get; set; } = null!;
		public virtual DbSet<TblUserLog> TblUserLogs { get; set; } = null!;
		public virtual DbSet<TblUserLogInmem> TblUserLogInmems { get; set; } = null!;
		public virtual DbSet<TblWebAdminToolLogV3> TblWebAdminToolLogV3s { get; set; } = null!;
		public virtual DbSet<TblWebBoardGameLog> TblWebBoardGameLogs { get; set; } = null!;
		public virtual DbSet<TblWorldMarketLog> TblWorldMarketLogs { get; set; } = null!;
		public virtual DbSet<TblWorldMarketLogInmem> TblWorldMarketLogInmems { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder
					.UseSqlServer(ConnHelper.GetConnString("Log"))
					.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DimLogOperationLogReason>(entity =>
			{
				entity.HasKey(e => e.LogReasonNo)
					.HasName("PK__Dim_Log___29F30E5F82B1B6FD");

				entity.ToTable("Dim_Log_OperationLogReason", "PaOperationPublic");

				entity.Property(e => e.LogReasonNo)
					.ValueGeneratedNever()
					.HasColumnName("_logReasonNo");

				entity.Property(e => e.LogReasonName).HasColumnName("_logReasonName");
			});

			modelBuilder.Entity<TblAuctionLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAuctionLog", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.AuctionGoodsNo).HasColumnName("_auctionGoodsNo");

				entity.Property(e => e.AuctionKey).HasColumnName("_auctionKey");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Price).HasColumnName("_price");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCashProductLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCashProductLog", "PaGamePrivate");

				entity.Property(e => e.CashBillingNo).HasColumnName("_cashBillingNo");

				entity.Property(e => e.CashCount).HasColumnName("_cashCount");

				entity.Property(e => e.CashProductName)
					.HasMaxLength(50)
					.HasColumnName("_cashProductName");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LeftCash).HasColumnName("_leftCash");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(32)
					.IsUnicode(false)
					.HasColumnName("_macAddress");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.Result).HasColumnName("_result");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.TotalCash).HasColumnName("_totalCash");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCashProductLogExInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCashProductLogEx_INMEM", "PaGamePrivate");

				entity.Property(e => e.CashItemCount).HasColumnName("_cashItemCount");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.DiscountPercent).HasColumnName("_discountPercent");

				entity.Property(e => e.EventCartkey).HasColumnName("_eventCartkey");

				entity.Property(e => e.LogNo).HasColumnName("_logNo");

				entity.Property(e => e.OriginalPearlCount).HasColumnName("_originalPearlCount");

				entity.Property(e => e.RealUsePearlCount).HasColumnName("_realUsePearlCount");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCouponKey).HasColumnName("_useCouponKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCashProductLogExNew>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCashProductLogEx_new", "PaGamePrivate");

				entity.Property(e => e.CashItemCount).HasColumnName("_cashItemCount");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.DiscountPercent).HasColumnName("_discountPercent");

				entity.Property(e => e.EventCartkey).HasColumnName("_eventCartkey");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OriginalPearlCount).HasColumnName("_originalPearlCount");

				entity.Property(e => e.RealUsePearlCount).HasColumnName("_realUsePearlCount");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCouponKey).HasColumnName("_useCouponKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblChatLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblChatLog", "PaGamePrivate");

				entity.Property(e => e.ChannelChatRoomName)
					.HasMaxLength(255)
					.HasColumnName("_channelChatRoomName");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.ChatLinkedItemKey).HasColumnName("_chatLinkedItemKey");

				entity.Property(e => e.ChatMessage)
					.HasMaxLength(100)
					.HasColumnName("_chatMessage");

				entity.Property(e => e.ChatType).HasColumnName("_chatType");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.ToCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_toCharacterName");

				entity.Property(e => e.ToCharacterNo).HasColumnName("_toCharacterNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblChatLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblChatLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.ChannelChatRoomName)
					.HasMaxLength(255)
					.HasColumnName("_channelChatRoomName");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.ChatLinkedItemKey).HasColumnName("_chatLinkedItemKey");

				entity.Property(e => e.ChatMessage)
					.HasMaxLength(100)
					.HasColumnName("_chatMessage");

				entity.Property(e => e.ChatType).HasColumnName("_chatType");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.ToCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_toCharacterName");

				entity.Property(e => e.ToCharacterNo).HasColumnName("_toCharacterNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblGmCommandLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGmCommandLog", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.BeforeCount).HasColumnName("_beforeCount");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CommandParam1).HasColumnName("_commandParam1");

				entity.Property(e => e.CommandParam2).HasColumnName("_commandParam2");

				entity.Property(e => e.CommandParam3).HasColumnName("_commandParam3");

				entity.Property(e => e.CommandParam4).HasColumnName("_commandParam4");

				entity.Property(e => e.CommandTextParam1)
					.HasMaxLength(30)
					.HasColumnName("_commandTextParam1");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.GmCommandType).HasColumnName("_gmCommandType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.PeerCharacterKey).HasColumnName("_peerCharacterKey");

				entity.Property(e => e.PeerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_peerCharacterName");

				entity.Property(e => e.PeerCharacterNo).HasColumnName("_peerCharacterNo");

				entity.Property(e => e.PeerCharacterisGm).HasColumnName("_peerCharacterisGm");

				entity.Property(e => e.PeerItemNo).HasColumnName("_peerItemNo");

				entity.Property(e => e.PeerItemWhereType).HasColumnName("_peerItemWhereType");

				entity.Property(e => e.PeerVariousNo).HasColumnName("_peerVariousNo");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedCount).HasColumnName("_variedCount");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblGmCommandLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGmCommandLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.BeforeCount).HasColumnName("_beforeCount");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CommandParam1).HasColumnName("_commandParam1");

				entity.Property(e => e.CommandParam2).HasColumnName("_commandParam2");

				entity.Property(e => e.CommandParam3).HasColumnName("_commandParam3");

				entity.Property(e => e.CommandParam4).HasColumnName("_commandParam4");

				entity.Property(e => e.CommandTextParam1)
					.HasMaxLength(30)
					.HasColumnName("_commandTextParam1");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.GmCommandType).HasColumnName("_gmCommandType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.PeerCharacterKey).HasColumnName("_peerCharacterKey");

				entity.Property(e => e.PeerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_peerCharacterName");

				entity.Property(e => e.PeerCharacterNo).HasColumnName("_peerCharacterNo");

				entity.Property(e => e.PeerCharacterisGm).HasColumnName("_peerCharacterisGm");

				entity.Property(e => e.PeerItemNo).HasColumnName("_peerItemNo");

				entity.Property(e => e.PeerItemWhereType).HasColumnName("_peerItemWhereType");

				entity.Property(e => e.PeerVariousNo).HasColumnName("_peerVariousNo");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedCount).HasColumnName("_variedCount");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblGuildSiegeLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildSiegeLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildParam1).HasColumnName("_guildParam1");

				entity.Property(e => e.GuildParam2).HasColumnName("_guildParam2");

				entity.Property(e => e.GuildParam3).HasColumnName("_guildParam3");

				entity.Property(e => e.GuildParam4).HasColumnName("_guildParam4");

				entity.Property(e => e.GuildParam5).HasColumnName("_guildParam5");

				entity.Property(e => e.GuildParam6).HasColumnName("_guildParam6");

				entity.Property(e => e.GuildParam7).HasColumnName("_guildParam7");

				entity.Property(e => e.GuildParam8).HasColumnName("_guildParam8");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.RegionName)
					.HasMaxLength(30)
					.HasColumnName("_regionName");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblItemLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblItemLog", "PaGamePrivate");

				entity.Property(e => e.BeforeCount).HasColumnName("_beforeCount");

				entity.Property(e => e.CashCount).HasColumnName("_cashCount");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsFocused).HasColumnName("_isFocused");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.PeerCharacterKey).HasColumnName("_peerCharacterKey");

				entity.Property(e => e.PeerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_peerCharacterName");

				entity.Property(e => e.PeerCharacterNo).HasColumnName("_peerCharacterNo");

				entity.Property(e => e.PeerCharacterisGm).HasColumnName("_peerCharacterisGm");

				entity.Property(e => e.PeerItemNo).HasColumnName("_peerItemNo");

				entity.Property(e => e.PeerItemWhereType).HasColumnName("_peerItemWhereType");

				entity.Property(e => e.PeerVariousNo).HasColumnName("_peerVariousNo");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.ReceivingCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_receivingCharacterName");

				entity.Property(e => e.ReceivingCharacterNo).HasColumnName("_receivingCharacterNo");

				entity.Property(e => e.ReceivingMailNo).HasColumnName("_receivingMailNo");

				entity.Property(e => e.ReceivingUserId)
					.HasMaxLength(30)
					.HasColumnName("_receivingUserId");

				entity.Property(e => e.ReceivingUserNo).HasColumnName("_receivingUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(30)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(30)
					.HasColumnName("_textParam2");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedCount).HasColumnName("_variedCount");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblItemLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblItemLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.BeforeCount).HasColumnName("_beforeCount");

				entity.Property(e => e.CashCount).HasColumnName("_cashCount");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsFocused).HasColumnName("_isFocused");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.PeerCharacterKey).HasColumnName("_peerCharacterKey");

				entity.Property(e => e.PeerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_peerCharacterName");

				entity.Property(e => e.PeerCharacterNo).HasColumnName("_peerCharacterNo");

				entity.Property(e => e.PeerCharacterisGm).HasColumnName("_peerCharacterisGm");

				entity.Property(e => e.PeerItemNo).HasColumnName("_peerItemNo");

				entity.Property(e => e.PeerItemWhereType).HasColumnName("_peerItemWhereType");

				entity.Property(e => e.PeerVariousNo).HasColumnName("_peerVariousNo");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.ReceivingCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_receivingCharacterName");

				entity.Property(e => e.ReceivingCharacterNo).HasColumnName("_receivingCharacterNo");

				entity.Property(e => e.ReceivingMailNo).HasColumnName("_receivingMailNo");

				entity.Property(e => e.ReceivingUserId)
					.HasMaxLength(30)
					.HasColumnName("_receivingUserId");

				entity.Property(e => e.ReceivingUserNo).HasColumnName("_receivingUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(30)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(30)
					.HasColumnName("_textParam2");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedCount).HasColumnName("_variedCount");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblLogReasonGroup>(entity =>
			{
				entity.HasKey(e => new { e.LogReasonGroupNo, e.LogReasonNo })
					.HasName("PkTblLogReasonGroup")
					.IsClustered(false);

				entity.ToTable("TblLogReasonGroup", "PaOperationPrivate");

				entity.Property(e => e.LogReasonGroupNo).HasColumnName("_logReasonGroupNo");

				entity.Property(e => e.LogReasonNo).HasColumnName("_logReasonNo");
			});

			modelBuilder.Entity<TblLogReasonGroupName>(entity =>
			{
				entity.HasKey(e => e.LogReasonGroupNo)
					.HasName("PkTblLogReasonGroupName")
					.IsClustered(false);

				entity.ToTable("TblLogReasonGroupName", "PaOperationPrivate");

				entity.Property(e => e.LogReasonGroupNo)
					.ValueGeneratedNever()
					.HasColumnName("_logReasonGroupNo");

				entity.Property(e => e.LogReasonGroupMemo)
					.HasMaxLength(50)
					.HasColumnName("_logReasonGroupMemo");

				entity.Property(e => e.LogReasonGroupName)
					.HasMaxLength(30)
					.HasColumnName("_logReasonGroupName");
			});

			modelBuilder.Entity<TblMiscLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMiscLog", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MiscParam1).HasColumnName("_miscParam1");

				entity.Property(e => e.MiscParam2).HasColumnName("_miscParam2");

				entity.Property(e => e.MiscParam3).HasColumnName("_miscParam3");

				entity.Property(e => e.MiscParam4).HasColumnName("_miscParam4");

				entity.Property(e => e.MiscParam5).HasColumnName("_miscParam5");

				entity.Property(e => e.MiscParam6).HasColumnName("_miscParam6");

				entity.Property(e => e.MiscParam7).HasColumnName("_miscParam7");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(200)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(200)
					.HasColumnName("_textParam2");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblMiscLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMiscLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MiscParam1).HasColumnName("_miscParam1");

				entity.Property(e => e.MiscParam2).HasColumnName("_miscParam2");

				entity.Property(e => e.MiscParam3).HasColumnName("_miscParam3");

				entity.Property(e => e.MiscParam4).HasColumnName("_miscParam4");

				entity.Property(e => e.MiscParam5).HasColumnName("_miscParam5");

				entity.Property(e => e.MiscParam6).HasColumnName("_miscParam6");

				entity.Property(e => e.MiscParam7).HasColumnName("_miscParam7");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(200)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(200)
					.HasColumnName("_textParam2");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblPointResourceLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPointResourceLog", "PaGamePrivate");

				entity.Property(e => e.AquiredPoint).HasColumnName("_aquiredPoint");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedPoint).HasColumnName("_remainedPoint");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ResourceType).HasColumnName("_resourceType");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedPoint).HasColumnName("_variedPoint");
			});

			modelBuilder.Entity<TblPointResourceLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPointResourceLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.AquiredPoint).HasColumnName("_aquiredPoint");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedPoint).HasColumnName("_remainedPoint");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ResourceType).HasColumnName("_resourceType");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedPoint).HasColumnName("_variedPoint");
			});

			modelBuilder.Entity<TblServantLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblServantLog", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServantCharacterKey).HasColumnName("_servantCharacterKey");

				entity.Property(e => e.ServantCurrentFieldIndex).HasColumnName("_servantCurrentFieldIndex");

				entity.Property(e => e.ServantCurrentFieldNo).HasColumnName("_servantCurrentFieldNo");

				entity.Property(e => e.ServantCurrentPositionX).HasColumnName("_servantCurrentPositionX");

				entity.Property(e => e.ServantCurrentPositionY).HasColumnName("_servantCurrentPositionY");

				entity.Property(e => e.ServantCurrentPositionZ).HasColumnName("_servantCurrentPositionZ");

				entity.Property(e => e.ServantExperience).HasColumnName("_servantExperience");

				entity.Property(e => e.ServantHp).HasColumnName("_servantHp");

				entity.Property(e => e.ServantLevel).HasColumnName("_servantLevel");

				entity.Property(e => e.ServantMp).HasColumnName("_servantMp");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.ServantNo).HasColumnName("_servantNo");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblServantLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblServantLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServantCharacterKey).HasColumnName("_servantCharacterKey");

				entity.Property(e => e.ServantCurrentFieldIndex).HasColumnName("_servantCurrentFieldIndex");

				entity.Property(e => e.ServantCurrentFieldNo).HasColumnName("_servantCurrentFieldNo");

				entity.Property(e => e.ServantCurrentPositionX).HasColumnName("_servantCurrentPositionX");

				entity.Property(e => e.ServantCurrentPositionY).HasColumnName("_servantCurrentPositionY");

				entity.Property(e => e.ServantCurrentPositionZ).HasColumnName("_servantCurrentPositionZ");

				entity.Property(e => e.ServantExperience).HasColumnName("_servantExperience");

				entity.Property(e => e.ServantHp).HasColumnName("_servantHp");

				entity.Property(e => e.ServantLevel).HasColumnName("_servantLevel");

				entity.Property(e => e.ServantMp).HasColumnName("_servantMp");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.ServantNo).HasColumnName("_servantNo");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblServiceLog>(entity =>
			{
				entity.HasKey(e => e.LogNo)
					.HasName("PkTblWorker")
					.IsClustered(false);

				entity.ToTable("TblServiceLog", "PaGamePrivate");

				entity.HasComment("Service 로그");

				entity.Property(e => e.LogNo)
					.HasColumnName("_logNo")
					.HasComment("로그 고유번호");

				entity.Property(e => e.GameAgeGradeType)
					.HasColumnName("_gameAgeGradeType")
					.HasComment("15세 이용가");

				entity.Property(e => e.IsGuestAccount)
					.HasColumnName("_isGuestAccount")
					.HasComment("guest 계정 여부");

				entity.Property(e => e.IsPcRoom)
					.HasColumnName("_isPcRoom")
					.HasComment("참이면 PC방");

				entity.Property(e => e.IsPcRoomPremium)
					.HasColumnName("_isPcRoomPremium")
					.HasComment("참이면 PC방 혜택");

				entity.Property(e => e.IsPvP)
					.HasColumnName("_isPvP")
					.HasComment("참이면 PVP");

				entity.Property(e => e.IsUserGm)
					.HasColumnName("_isUserGm")
					.HasComment("참이면 운영자");

				entity.Property(e => e.OperationLogType)
					.HasColumnName("_operationLogType")
					.HasComment("로그 타입");

				entity.Property(e => e.PlayMinuteOfUser)
					.HasColumnName("_playMinuteOfUser")
					.HasComment("유저 플레이 시간");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())")
					.HasComment("등록 시간");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버 번호");

				entity.Property(e => e.ServiceParam1)
					.HasColumnName("_serviceParam1")
					.HasComment("param1");

				entity.Property(e => e.ServiceParam2)
					.HasColumnName("_serviceParam2")
					.HasComment("param2");

				entity.Property(e => e.ServiceParam3)
					.HasColumnName("_serviceParam3")
					.HasComment("param3");

				entity.Property(e => e.ServiceString)
					.HasMaxLength(200)
					.HasColumnName("_serviceString")
					.HasComment("운영 로그 내용");

				entity.Property(e => e.SymNoReason)
					.HasColumnName("_symNoReason")
					.HasComment("로그 이유");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId")
					.HasComment("유저 ID");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp")
					.HasComment("유저 IP");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 고유 번호");
			});

			modelBuilder.Entity<TblTrPerformance>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblTrPerformance", "PaGamePrivate");

				entity.Property(e => e.CallCount).HasColumnName("_callCount");

				entity.Property(e => e.LastStartTime).HasColumnName("_lastStartTime");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.SlowElapsedTime).HasColumnName("_slowElapsedTime");

				entity.Property(e => e.TotalElapsedTime).HasColumnName("_totalElapsedTime");

				entity.Property(e => e.TrId).HasColumnName("_trId");

				entity.Property(e => e.TrName)
					.HasMaxLength(50)
					.HasColumnName("_trName");
			});

			modelBuilder.Entity<TblUserLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblUserLog", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.LogoutReason).HasColumnName("_logoutReason");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblUserLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblUserLog_INMEM", "PaGamePrivate");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CharacterExperience).HasColumnName("_characterExperience");

				entity.Property(e => e.CharacterLevel).HasColumnName("_characterLevel");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterTendency).HasColumnName("_characterTendency");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.GameAgeGradeType).HasColumnName("_gameAgeGradeType");

				entity.Property(e => e.IsDoingSiege).HasColumnName("_isDoingSiege");

				entity.Property(e => e.IsGuestAccount).HasColumnName("_isGuestAccount");

				entity.Property(e => e.IsPcRoom).HasColumnName("_isPcRoom");

				entity.Property(e => e.IsPcRoomPremium).HasColumnName("_isPcRoomPremium");

				entity.Property(e => e.IsPvP).HasColumnName("_isPvP");

				entity.Property(e => e.IsUserGm).HasColumnName("_isUserGm");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.LogoutReason).HasColumnName("_logoutReason");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.PlayMinuteOfCharacter).HasColumnName("_playMinuteOfCharacter");

				entity.Property(e => e.PlayMinuteOfUser).HasColumnName("_playMinuteOfUser");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegionType).HasColumnName("_regionType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWebAdminToolLogV3>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWebAdminToolLog_v3", "PaOperationPrivate");

				entity.Property(e => e.AccountNo).HasColumnName("_accountNo");

				entity.Property(e => e.ExecuteSpName)
					.HasMaxLength(100)
					.HasColumnName("_executeSpName");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.LogType).HasColumnName("_logType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param10).HasColumnName("_param10");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.Param7).HasColumnName("_param7");

				entity.Property(e => e.Param8).HasColumnName("_param8");

				entity.Property(e => e.Param9).HasColumnName("_param9");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Rv).HasColumnName("_rv");

				entity.Property(e => e.StringParam1).HasColumnName("_stringParam1");

				entity.Property(e => e.StringParam2).HasColumnName("_stringParam2");

				entity.Property(e => e.StringParam3).HasColumnName("_stringParam3");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWebBoardGameLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWebBoardGameLog", "PaWebGamePrivate");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.DicePosition).HasColumnName("_dicePosition");

				entity.Property(e => e.DiceValue).HasColumnName("_diceValue");

				entity.Property(e => e.FinishCount).HasColumnName("_finishCount");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.LogType).HasColumnName("_logType");

				entity.Property(e => e.NowPosition).HasColumnName("_nowPosition");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.PrizeType).HasColumnName("_prizeType");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.StartPosition).HasColumnName("_startPosition");

				entity.Property(e => e.TodayCount).HasColumnName("_todayCount");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWorldMarketLog>(entity =>
			{
				entity.HasKey(e => e.LogNo)
					.HasName("PK__TblWorld__820A04EA0B75A0FA");

				entity.ToTable("TblWorldMarketLog", "PaWebGamePrivate");

				entity.Property(e => e.LogNo)
					.ValueGeneratedNever()
					.HasColumnName("_logNo");

				entity.Property(e => e.AfterCount1).HasColumnName("_afterCount1");

				entity.Property(e => e.AfterCount2).HasColumnName("_afterCount2");

				entity.Property(e => e.BeforeCount1).HasColumnName("_beforeCount1");

				entity.Property(e => e.BeforeCount2).HasColumnName("_beforeCount2");

				entity.Property(e => e.Count1).HasColumnName("_count1");

				entity.Property(e => e.Count2).HasColumnName("_count2");

				entity.Property(e => e.KeyType1).HasColumnName("_keyType1");

				entity.Property(e => e.KeyType2).HasColumnName("_keyType2");

				entity.Property(e => e.MainKey1).HasColumnName("_mainKey1");

				entity.Property(e => e.MainKey2).HasColumnName("_mainKey2");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param10).HasColumnName("_param10");

				entity.Property(e => e.Param11).HasColumnName("_param11");

				entity.Property(e => e.Param12).HasColumnName("_param12");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.Param7).HasColumnName("_param7");

				entity.Property(e => e.Param8).HasColumnName("_param8");

				entity.Property(e => e.Param9).HasColumnName("_param9");

				entity.Property(e => e.Reason)
					.HasMaxLength(255)
					.IsUnicode(false)
					.HasColumnName("_reason");

				entity.Property(e => e.RegisterUtc)
					.HasColumnType("datetime")
					.HasColumnName("_registerUtc");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.ServerUtc)
					.HasColumnType("datetime")
					.HasColumnName("_serverUtc");

				entity.Property(e => e.SubKey1).HasColumnName("_subKey1");

				entity.Property(e => e.SubKey2).HasColumnName("_subKey2");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(255)
					.IsUnicode(false)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(255)
					.IsUnicode(false)
					.HasColumnName("_textParam2");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWorldMarketLogInmem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketLog_INMEM", "PaWebGamePrivate");

				entity.Property(e => e.AfterCount1).HasColumnName("_afterCount1");

				entity.Property(e => e.AfterCount2).HasColumnName("_afterCount2");

				entity.Property(e => e.BeforeCount1).HasColumnName("_beforeCount1");

				entity.Property(e => e.BeforeCount2).HasColumnName("_beforeCount2");

				entity.Property(e => e.Count1).HasColumnName("_count1");

				entity.Property(e => e.Count2).HasColumnName("_count2");

				entity.Property(e => e.KeyType1).HasColumnName("_keyType1");

				entity.Property(e => e.KeyType2).HasColumnName("_keyType2");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MainKey1).HasColumnName("_mainKey1");

				entity.Property(e => e.MainKey2).HasColumnName("_mainKey2");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.OperationLogType).HasColumnName("_operationLogType");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param10).HasColumnName("_param10");

				entity.Property(e => e.Param11).HasColumnName("_param11");

				entity.Property(e => e.Param12).HasColumnName("_param12");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.Param7).HasColumnName("_param7");

				entity.Property(e => e.Param8).HasColumnName("_param8");

				entity.Property(e => e.Param9).HasColumnName("_param9");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.RegisterUtc)
					.HasColumnType("datetime")
					.HasColumnName("_registerUtc")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.ServerUtc)
					.HasColumnType("datetime")
					.HasColumnName("_serverUtc");

				entity.Property(e => e.SubKey1).HasColumnName("_subKey1");

				entity.Property(e => e.SubKey2).HasColumnName("_subKey2");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(30)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(30)
					.HasColumnName("_textParam2");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
