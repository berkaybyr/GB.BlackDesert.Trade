using Microsoft.EntityFrameworkCore;

namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class SA_BETA_WORLDDB_0002Context : DbContext
	{
		public SA_BETA_WORLDDB_0002Context()
		{
		}

		public SA_BETA_WORLDDB_0002Context(DbContextOptions<SA_BETA_WORLDDB_0002Context> options)
			: base(options)
		{
		}

		public virtual DbSet<TblAccessibleServerInformation> TblAccessibleServerInformations { get; set; } = null!;
		public virtual DbSet<TblAdminCommandType> TblAdminCommandTypes { get; set; } = null!;
		public virtual DbSet<TblBlockChatByUserHistory> TblBlockChatByUserHistories { get; set; } = null!;
		public virtual DbSet<TblBlockHistory> TblBlockHistories { get; set; } = null!;
		public virtual DbSet<TblBlockType> TblBlockTypes { get; set; } = null!;
		public virtual DbSet<TblBlockedIp> TblBlockedIps { get; set; } = null!;
		public virtual DbSet<TblBlockedMacAddress> TblBlockedMacAddresses { get; set; } = null!;
		public virtual DbSet<TblBlockedUser> TblBlockedUsers { get; set; } = null!;
		public virtual DbSet<TblBlockedUserForPublisher> TblBlockedUserForPublishers { get; set; } = null!;
		public virtual DbSet<TblBriefCharacterInformation> TblBriefCharacterInformations { get; set; } = null!;
		public virtual DbSet<TblChannelChatBlockInfo> TblChannelChatBlockInfos { get; set; } = null!;
		public virtual DbSet<TblCharacterName> TblCharacterNames { get; set; } = null!;
		public virtual DbSet<TblCommandInfo> TblCommandInfos { get; set; } = null!;
		public virtual DbSet<TblCommonTime> TblCommonTimes { get; set; } = null!;
		public virtual DbSet<TblContentsOptionsLog> TblContentsOptionsLogs { get; set; } = null!;
		public virtual DbSet<TblContentsOptionsNewList> TblContentsOptionsNewLists { get; set; } = null!;
		public virtual DbSet<TblContentsOptionsOldList> TblContentsOptionsOldLists { get; set; } = null!;
		public virtual DbSet<TblCurrentInformation> TblCurrentInformations { get; set; } = null!;
		public virtual DbSet<TblFoolsDayEvent> TblFoolsDayEvents { get; set; } = null!;
		public virtual DbSet<TblGuildName> TblGuildNames { get; set; } = null!;
		public virtual DbSet<TblHijack> TblHijacks { get; set; } = null!;
		public virtual DbSet<TblIpblockHistory> TblIpblockHistories { get; set; } = null!;
		public virtual DbSet<TblLoveDonateEvent> TblLoveDonateEvents { get; set; } = null!;
		public virtual DbSet<TblMacAddressLock> TblMacAddressLocks { get; set; } = null!;
		public virtual DbSet<TblMacAddressLog> TblMacAddressLogs { get; set; } = null!;
		public virtual DbSet<TblMaintenance> TblMaintenances { get; set; } = null!;
		public virtual DbSet<TblNameChange> TblNameChanges { get; set; } = null!;
		public virtual DbSet<TblNameChangeFailLogInWorld> TblNameChangeFailLogInWorlds { get; set; } = null!;
		public virtual DbSet<TblNameExchange> TblNameExchanges { get; set; } = null!;
		public virtual DbSet<TblOperationMention> TblOperationMentions { get; set; } = null!;
		public virtual DbSet<TblOperationTicket> TblOperationTickets { get; set; } = null!;
		public virtual DbSet<TblOperationTicketV3> TblOperationTicketV3s { get; set; } = null!;
		public virtual DbSet<TblPcroomGateWayList> TblPcroomGateWayLists { get; set; } = null!;
		public virtual DbSet<TblPcroomLoginList> TblPcroomLoginLists { get; set; } = null!;
		public virtual DbSet<TblPcroomRequestList> TblPcroomRequestLists { get; set; } = null!;
		public virtual DbSet<TblProhibitedWord> TblProhibitedWords { get; set; } = null!;
		public virtual DbSet<TblPs4accessTokenList> TblPs4accessTokenLists { get; set; } = null!;
		public virtual DbSet<TblPs4cashConsumeLog> TblPs4cashConsumeLogs { get; set; } = null!;
		public virtual DbSet<TblPs4cashInfoWorld> TblPs4cashInfoWorlds { get; set; } = null!;
		public virtual DbSet<TblPs4cashProductAndItemMapping> TblPs4cashProductAndItemMappings { get; set; } = null!;
		public virtual DbSet<TblPs4cashProductRefundInfo> TblPs4cashProductRefundInfos { get; set; } = null!;
		public virtual DbSet<TblPs4devAccessUserList> TblPs4devAccessUserLists { get; set; } = null!;
		public virtual DbSet<TblPs4entitlementHistory> TblPs4entitlementHistories { get; set; } = null!;
		public virtual DbSet<TblPs4refundHistory> TblPs4refundHistories { get; set; } = null!;
		public virtual DbSet<TblRecommandUserNickName> TblRecommandUserNickNames { get; set; } = null!;
		public virtual DbSet<TblReplaceSubItemGroup> TblReplaceSubItemGroups { get; set; } = null!;
		public virtual DbSet<TblReportedNegativeUser> TblReportedNegativeUsers { get; set; } = null!;
		public virtual DbSet<TblRoleGroup> TblRoleGroups { get; set; } = null!;
		public virtual DbSet<TblRoleGroupMember> TblRoleGroupMembers { get; set; } = null!;
		public virtual DbSet<TblRoleGroupMemberLoginIpOasis> TblRoleGroupMemberLoginIpOases { get; set; } = null!;
		public virtual DbSet<TblRoleGroupMemberOasis> TblRoleGroupMemberOases { get; set; } = null!;
		public virtual DbSet<TblRoleGroupName> TblRoleGroupNames { get; set; } = null!;
		public virtual DbSet<TblRoleGroupNameOasis> TblRoleGroupNameOases { get; set; } = null!;
		public virtual DbSet<TblRoleGroupOasis> TblRoleGroupOases { get; set; } = null!;
		public virtual DbSet<TblRoleList> TblRoleLists { get; set; } = null!;
		public virtual DbSet<TblRoleListOasis> TblRoleListOases { get; set; } = null!;
		public virtual DbSet<TblServerChannelChatInformation> TblServerChannelChatInformations { get; set; } = null!;
		public virtual DbSet<TblServerDataCrc> TblServerDataCrcs { get; set; } = null!;
		public virtual DbSet<TblServerExpPreset> TblServerExpPresets { get; set; } = null!;
		public virtual DbSet<TblServerFamilyInformation> TblServerFamilyInformations { get; set; } = null!;
		public virtual DbSet<TblServerGroup> TblServerGroups { get; set; } = null!;
		public virtual DbSet<TblServerInformation> TblServerInformations { get; set; } = null!;
		public virtual DbSet<TblServerInformationPreset> TblServerInformationPresets { get; set; } = null!;
		public virtual DbSet<TblServerInstanceFieldInformation> TblServerInstanceFieldInformations { get; set; } = null!;
		public virtual DbSet<TblShaRegistedUserYesterday> TblShaRegistedUserYesterdays { get; set; } = null!;
		public virtual DbSet<TblStatementTemp> TblStatementTemps { get; set; } = null!;
		public virtual DbSet<TblTeenageUserInformation> TblTeenageUserInformations { get; set; } = null!;
		public virtual DbSet<TblTradeAuthKey> TblTradeAuthKeys { get; set; } = null!;
		public virtual DbSet<TblTradeAuthKeyHistory> TblTradeAuthKeyHistories { get; set; } = null!;
		public virtual DbSet<TblTransferAccountBuffUserList> TblTransferAccountBuffUserLists { get; set; } = null!;
		public virtual DbSet<TblTranslationReport> TblTranslationReports { get; set; } = null!;
		public virtual DbSet<TblTranslationReportRecommendHistory> TblTranslationReportRecommendHistories { get; set; } = null!;
		public virtual DbSet<TblUniqueName> TblUniqueNames { get; set; } = null!;
		public virtual DbSet<TblUniqueNameBackup> TblUniqueNameBackups { get; set; } = null!;
		public virtual DbSet<TblUserCache> TblUserCaches { get; set; } = null!;
		public virtual DbSet<TblUserChattingMacro> TblUserChattingMacros { get; set; } = null!;
		public virtual DbSet<TblUserEtcInformation> TblUserEtcInformations { get; set; } = null!;
		public virtual DbSet<TblUserGameOption> TblUserGameOptions { get; set; } = null!;
		public virtual DbSet<TblUserInformation> TblUserInformations { get; set; } = null!;
		public virtual DbSet<TblUserNickNameModStr> TblUserNickNameModStrs { get; set; } = null!;
		public virtual DbSet<TblUserUiinfomation> TblUserUiinfomations { get; set; } = null!;
		public virtual DbSet<TblValidServerInformation> TblValidServerInformations { get; set; } = null!;
		public virtual DbSet<TblXboxCashInfoWorld> TblXboxCashInfoWorlds { get; set; } = null!;
		public virtual DbSet<TblXboxCashProductAndItemMapping> TblXboxCashProductAndItemMappings { get; set; } = null!;
		public virtual DbSet<TblXboxCashProductRefundInfo> TblXboxCashProductRefundInfos { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(ConnHelper.GetConnString("World"))
						.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TblAccessibleServerInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAccessibleServerInformation", "PaGamePrivate");

				entity.HasComment("유저별 접속가능한 게임서버(채널번호)");

				entity.Property(e => e.IsWorking)
					.HasColumnName("_isWorking")
					.HasComment("작업중 이라서 이곳으로 접속 가능");

				entity.Property(e => e.MoveableSpecialChannelTime)
					.HasColumnType("datetime")
					.HasColumnName("_moveableSpecialChannelTime")
					.HasComment("이 시간이 지나야 특수 채널 이동을 할 수 있다");

				entity.Property(e => e.MoveableTime)
					.HasColumnType("datetime")
					.HasColumnName("_moveableTime")
					.HasComment("이 시간이 지나야 채널 이동을 할 수 있다");

				entity.Property(e => e.RestrictReason).HasColumnName("_restrictReason");

				entity.Property(e => e.ServerGroupNo)
					.HasColumnName("_serverGroupNo")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버 번호(채널)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 번호");

				entity.Property(e => e.WorldNo)
					.HasColumnName("_worldNo")
					.HasComment("월드 번호");
			});

			modelBuilder.Entity<TblAdminCommandType>(entity =>
			{
				entity.HasKey(e => e.CommandTypeNo)
					.HasName("PkTblAdminCommandType")
					.IsClustered(false);

				entity.ToTable("TblAdminCommandType", "PaOperationPrivate");

				entity.Property(e => e.CommandTypeNo)
					.ValueGeneratedNever()
					.HasColumnName("_commandTypeNo");

				entity.Property(e => e.Command)
					.HasMaxLength(100)
					.HasColumnName("_command");

				entity.Property(e => e.CommandDesc)
					.HasMaxLength(100)
					.HasColumnName("_commandDesc");

				entity.Property(e => e.ParamCount)
					.HasColumnName("_paramCount")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ParamDesc)
					.HasMaxLength(300)
					.HasColumnName("_paramDesc");
			});

			modelBuilder.Entity<TblBlockChatByUserHistory>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PkTblBlockChatByUserHistory")
					.IsClustered(false);

				entity.ToTable("TblBlockChatByUserHistory", "PaGamePrivate");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ReasonChat)
					.HasMaxLength(350)
					.HasColumnName("_reasonChat");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TargetCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_targetCharacterName");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_userIp");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBlockHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBlockHistory", "PaGamePrivate");

				entity.Property(e => e.BlockCode).HasColumnName("_blockCode");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate");

				entity.Property(e => e.HistoryNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_historyNo");

				entity.Property(e => e.OperationMemo)
					.HasMaxLength(200)
					.HasColumnName("_operationMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBlockType>(entity =>
			{
				entity.HasKey(e => e.BlockCode)
					.HasName("PkTblBlockType")
					.IsClustered(false);

				entity.ToTable("TblBlockType", "PaGamePublic");

				entity.Property(e => e.BlockCode)
					.ValueGeneratedNever()
					.HasColumnName("_blockCode");

				entity.Property(e => e.BlockReason)
					.HasMaxLength(200)
					.HasColumnName("_blockReason");

				entity.Property(e => e.Duration).HasColumnName("_duration");

				entity.Property(e => e.Index)
					.ValueGeneratedOnAdd()
					.HasColumnName("_index");

				entity.Property(e => e.IsUse)
					.IsRequired()
					.HasColumnName("_isUse")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Memo)
					.HasMaxLength(200)
					.HasColumnName("_memo")
					.HasDefaultValueSql("(N'')");
			});

			modelBuilder.Entity<TblBlockedIp>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PkTblBlockedIP")
					.IsClustered(false);

				entity.ToTable("TblBlockedIP", "PaGamePrivate");

				entity.HasComment("IP 블록 테이블");

				entity.Property(e => e.BlockNo)
					.HasColumnName("_blockNo")
					.HasComment("블록 고유 번호");

				entity.Property(e => e.BigintEndIp)
					.HasColumnName("_bigintEndIP")
					.HasComment("IP 대역 시작점 BIGINT형");

				entity.Property(e => e.BigintStartIp)
					.HasColumnName("_bigintStartIP")
					.HasComment("IP 대역 시작점 BIGINT형");

				entity.Property(e => e.BlockCode)
					.HasColumnName("_blockCode")
					.HasComment("블록 사유 코드");

				entity.Property(e => e.EndIp)
					.HasMaxLength(15)
					.HasColumnName("_endIP")
					.HasComment("IP 대역 시작점 NVARCHAR형");

				entity.Property(e => e.OperationMemo)
					.HasMaxLength(200)
					.HasColumnName("_operationMemo")
					.HasComment("블록 운영자 메모");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasComment("등록 시간");

				entity.Property(e => e.StartIp)
					.HasMaxLength(15)
					.HasColumnName("_startIP")
					.HasComment("IP 대역 시작점 NVARCHAR형");
			});

			modelBuilder.Entity<TblBlockedMacAddress>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBlockedMacAddress");

				entity.Property(e => e.BlockCode)
					.HasColumnName("_blockCode")
					.HasDefaultValueSql("((10105))");

				entity.Property(e => e.EndDate).HasColumnName("_endDate");

				entity.Property(e => e.Id)
					.ValueGeneratedOnAdd()
					.HasColumnName("_id");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(30)
					.HasColumnName("_macAddress");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(250)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBlockedUser>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PkTblBlockedUser")
					.IsClustered(false);

				entity.ToTable("TblBlockedUser", "PaGamePrivate");

				entity.HasComment("운영 관련 그룹의 역할 테이블");

				entity.Property(e => e.BlockNo)
					.HasColumnName("_blockNo")
					.HasComment("블록 고유 번호");

				entity.Property(e => e.BlockCode)
					.HasColumnName("_blockCode")
					.HasComment("블록 사유 코드");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasComment("블록 종료 시간");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(64)
					.HasColumnName("_macAddress");

				entity.Property(e => e.OperationMemo)
					.HasMaxLength(200)
					.HasColumnName("_operationMemo")
					.HasComment("블록 운영자 메모");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasComment("블록 등록 시간");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("블록 유저 번호");
			});

			modelBuilder.Entity<TblBlockedUserForPublisher>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.BlockType })
					.HasName("PkTblBlockedUserForPublisher")
					.IsClustered(false);

				entity.ToTable("TblBlockedUserForPublisher", "PaGamePrivate");

				entity.HasComment("북미 블록 유저 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 넘버");

				entity.Property(e => e.BlockType)
					.HasColumnName("_blockType")
					.HasComment("블록 타입");

				entity.Property(e => e.BlockCode)
					.HasColumnName("_blockCode")
					.HasComment("블록 코드");

				entity.Property(e => e.BlockDuration)
					.HasColumnName("_blockDuration")
					.HasComment("블록 종료 시간");

				entity.Property(e => e.BlockNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_blockNo")
					.HasComment("블록 고유 번호");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasComment("유저 이름");

				entity.Property(e => e.Check).HasColumnName("_check");

				entity.Property(e => e.OperationMemo)
					.HasMaxLength(200)
					.HasColumnName("_operationMemo")
					.HasComment("블록 사유");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasComment("블록 등록 시간");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("북미 서버 넘버");
			});

			modelBuilder.Entity<TblBriefCharacterInformation>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.UserNo, e.WorldNo })
					.HasName("PkTblBriefCharacterInformation")
					.IsClustered(false);

				entity.ToTable("TblBriefCharacterInformation", "PaGamePrivate");

				entity.HasComment("캐릭터 요약정보");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 번호");

				entity.Property(e => e.WorldNo)
					.HasColumnName("_worldNo")
					.HasComment("월드 번호");

				entity.Property(e => e.AffiliatedTerritoryKey)
					.HasColumnName("_affiliatedTerritoryKey")
					.HasComment("소속영지");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasComment("캐릭터 명");

				entity.Property(e => e.ClassType)
					.HasColumnName("_classType")
					.HasComment("클래스");

				entity.Property(e => e.CreateDate)
					.HasColumnType("datetime")
					.HasColumnName("_createDate")
					.HasComment("생성일");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasComment("삭제일");

				entity.Property(e => e.IsMain)
					.HasColumnName("_isMain")
					.HasComment("메인 캐릭터여부");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))")
					.HasComment("참인 경우에만 선택할 수 있는 캐릭터");

				entity.Property(e => e.LastLoginTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLoginTime")
					.HasComment("최종 로그인");

				entity.Property(e => e.LastLogoutTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLogoutTime")
					.HasComment("최종 로그아웃");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasComment("레벨");

				entity.Property(e => e.TotalPlayTime)
					.HasColumnName("_totalPlayTime")
					.HasComment("총 플레이시간(분)");
			});

			modelBuilder.Entity<TblChannelChatBlockInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblChannelChatBlockInfo");

				entity.ToTable("TblChannelChatBlockInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.AvailableBlockCount)
					.HasColumnName("_availableBlockCount")
					.HasDefaultValueSql("((5))");

				entity.Property(e => e.BlockedCount)
					.HasColumnName("_blockedCount")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.ChannelJoinBlockEndTime)
					.HasColumnType("datetime")
					.HasColumnName("_channelJoinBlockEndTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ChattingBlockEndTime)
					.HasColumnType("datetime")
					.HasColumnName("_chattingBlockEndTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblCharacterName>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCharacterName", "PaOperationPrivate");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");
			});

			modelBuilder.Entity<TblCommandInfo>(entity =>
			{
				entity.HasKey(e => e.CommandNo)
					.HasName("PkTblCommandInfo")
					.IsClustered(false);

				entity.ToTable("TblCommandInfo", "PaOperationPrivate");

				entity.Property(e => e.CommandNo).HasColumnName("_commandNo");

				entity.Property(e => e.CommandString).HasColumnName("_commandString");

				entity.Property(e => e.EndDate)
					.HasColumnName("_endDate")
					.HasDefaultValueSql("(dateadd(day,(7),[PaGamePublic].[ufnGetCustomDatetime]()))");

				entity.Property(e => e.Interval)
					.HasColumnName("_interval")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.IsCycleCommand).HasColumnName("_isCycleCommand");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ReserveDate)
					.HasColumnName("_reserveDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.Status).HasColumnName("_status");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.WorldNo).HasColumnName("_worldNo");
			});

			modelBuilder.Entity<TblCommonTime>(entity =>
			{
				entity.HasKey(e => e.WorldNo)
					.HasName("PkTblCommonTime");

				entity.ToTable("TblCommonTime", "PaGamePrivate");

				entity.HasComment("시간 테이블");

				entity.Property(e => e.WorldNo)
					.ValueGeneratedNever()
					.HasColumnName("_worldNo");

				entity.Property(e => e.CumulatedTick)
					.HasColumnName("_cumulatedTick")
					.HasComment("서버 누적 시간(서버가 켜진 상태에서만 누적됨)");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasComment("서버의 마지막 업데이트 시간");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.ServerOpenTime)
					.HasColumnType("datetime")
					.HasColumnName("_serverOpenTime")
					.HasComment("서버가 켜진 시간");
			});

			modelBuilder.Entity<TblContentsOptionsLog>(entity =>
			{
				entity.HasKey(e => new { e.ProcessTime, e.ContentsOptionKey })
					.HasName("PkTblContentsOptionsLog");

				entity.ToTable("TblContentsOptionsLog", "PaGamePrivate");

				entity.Property(e => e.ProcessTime)
					.HasColumnType("datetime")
					.HasColumnName("_processTime");

				entity.Property(e => e.ContentsOptionKey).HasColumnName("_contentsOptionKey");

				entity.Property(e => e.ChangingStatus).HasColumnName("_changingStatus");
			});

			modelBuilder.Entity<TblContentsOptionsNewList>(entity =>
			{
				entity.HasKey(e => e.ContentsOptionKey)
					.HasName("PkTblContentsOptionsNewList");

				entity.ToTable("TblContentsOptionsNewList", "PaGamePrivate");

				entity.Property(e => e.ContentsOptionKey)
					.ValueGeneratedNever()
					.HasColumnName("_contentsOptionKey");
			});

			modelBuilder.Entity<TblContentsOptionsOldList>(entity =>
			{
				entity.HasKey(e => e.ContentsOptionKey)
					.HasName("PkTblContentsOptionsOldList");

				entity.ToTable("TblContentsOptionsOldList", "PaGamePrivate");

				entity.Property(e => e.ContentsOptionKey)
					.ValueGeneratedNever()
					.HasColumnName("_contentsOptionKey");
			});

			modelBuilder.Entity<TblCurrentInformation>(entity =>
			{
				entity.HasKey(e => new { e.WorldNo, e.ServerNo, e.UpdatedDate })
					.HasName("PkTblCurrentInformation");

				entity.ToTable("TblCurrentInformation", "PaGamePrivate");

				entity.HasComment("현재정보");

				entity.Property(e => e.WorldNo)
					.HasColumnName("_worldNo")
					.HasComment("월드번호");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버번호");

				entity.Property(e => e.UpdatedDate)
					.HasColumnType("datetime")
					.HasColumnName("_updatedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("수정시간");

				entity.Property(e => e.BusySessionCount)
					.HasColumnName("_busySessionCount")
					.HasComment("사용중인 세션수");

				entity.Property(e => e.LoginningUserCount)
					.HasColumnName("_loginningUserCount")
					.HasComment("ID PW는 맞는데 아직 필드 진입하지 않은 수");

				entity.Property(e => e.PcRoomUserCount).HasColumnName("_pcRoomUserCount");

				entity.Property(e => e.PlayingUserCount)
					.HasColumnName("_playingUserCount")
					.HasComment("플레이중인 이용자 수");

				entity.Property(e => e.TotalSessionCount)
					.HasColumnName("_totalSessionCount")
					.HasComment("총세션수");
			});

			modelBuilder.Entity<TblFoolsDayEvent>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblFoolsDayEvent", "PaGamePrivate");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MDate)
					.HasColumnType("datetime")
					.HasColumnName("_mDate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SumCount).HasColumnName("_sumCount");
			});

			modelBuilder.Entity<TblGuildName>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildName", "PaOperationPrivate");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");
			});

			modelBuilder.Entity<TblHijack>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblHijack", "PaGamePrivate");

				entity.HasIndex(e => e.AdminUserNo, "UQ__TblHijac__3B4EB7571B6D25FD")
					.IsUnique();

				entity.HasIndex(e => e.HijackUserNo, "UQ__TblHijac__647D4392E18D9723")
					.IsUnique();

				entity.Property(e => e.AdminUserNo)
					.HasColumnName("_adminUserNo")
					.HasComment("_adminUserNo");

				entity.Property(e => e.HijackUserNo)
					.HasColumnName("_hijackUserNo")
					.HasComment("_hijackUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblIpblockHistory>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PkTblIPBlockHistory")
					.IsClustered(false);

				entity.ToTable("TblIPBlockHistory", "PaGamePrivate");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.BlockCode).HasColumnName("_blockCode");

				entity.Property(e => e.EndIp)
					.HasMaxLength(15)
					.HasColumnName("_endIP");

				entity.Property(e => e.OperationMemo)
					.HasMaxLength(200)
					.HasColumnName("_operationMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.StartIp)
					.HasMaxLength(15)
					.HasColumnName("_startIP");
			});

			modelBuilder.Entity<TblLoveDonateEvent>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblLoveDonateEvent", "PaGamePrivate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.EventNo)
					.HasColumnName("_eventNo")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblMacAddressLock>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PK__TblMacAd__D84CDD5F18135269");

				entity.ToTable("TblMacAddressLock");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.BanIfDifferentLogin).HasColumnName("_banIfDifferentLogin");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.LogDifferentLogin).HasColumnName("_logDifferentLogin");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(20)
					.IsUnicode(false)
					.HasColumnName("_macAddress");

				entity.Property(e => e.MacBanDifferentLogin).HasColumnName("_macBanDifferentLogin");
			});

			modelBuilder.Entity<TblMacAddressLog>(entity =>
			{
				entity.HasKey(e => e.RecordId)
					.HasName("PK__TblMacAd__2508F51DED736BF9");

				entity.ToTable("TblMacAddressLog");

				entity.Property(e => e.RecordId).HasColumnName("_recordId");

				entity.Property(e => e.CpuBrandString)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("_cpuBrandString");

				entity.Property(e => e.GraphicsAdapterBrandString)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("_graphicsAdapterBrandString");

				entity.Property(e => e.Ip)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_ip");

				entity.Property(e => e.IsHijackLogin).HasColumnName("_isHijackLogin");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(32)
					.IsUnicode(false)
					.HasColumnName("_macAddress");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblMaintenance>(entity =>
			{
				entity.HasKey(e => e.IsMaintenance)
					.HasName("PK__TblMaint__767097595FCDB711");

				entity.ToTable("TblMaintenance");

				entity.Property(e => e.IsMaintenance).HasColumnName("_isMaintenance");
			});

			modelBuilder.Entity<TblNameChange>(entity =>
			{
				entity.HasKey(e => new { e.OwnerNo, e.NameChangeType })
					.HasName("PkTblNameChange")
					.IsClustered(false);

				entity.ToTable("TblNameChange", "PaGamePrivate");

				entity.HasComment("이름 변경 요청");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("변경을 요청한 유저 번호");

				entity.Property(e => e.NameChangeType)
					.HasColumnName("_nameChangeType")
					.HasComment("이름 변경 타입");

				entity.Property(e => e.BeforeName)
					.HasMaxLength(30)
					.HasColumnName("_beforeName")
					.HasComment("변경전 이름");

				entity.Property(e => e.IsBadName)
					.HasColumnName("_isBadName")
					.HasComment("불건전한 이름 확인 여부");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name")
					.HasComment("변경할 이름");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("신청 날짜");
			});

			modelBuilder.Entity<TblNameChangeFailLogInWorld>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblNameChangeFailLogInWorld", "PaOperationPrivate");

				entity.Property(e => e.BeforeName)
					.HasMaxLength(30)
					.HasColumnName("_beforeName");

				entity.Property(e => e.MDate)
					.HasMaxLength(8)
					.HasColumnName("_mDate");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name");

				entity.Property(e => e.NameChangeType).HasColumnName("_nameChangeType");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.Result).HasColumnName("_result");

				entity.Property(e => e.Rv).HasColumnName("_rv");
			});

			modelBuilder.Entity<TblNameExchange>(entity =>
			{
				entity.HasKey(e => e.OwnerNo)
					.HasName("PkTblNameExchange")
					.IsClustered(false);

				entity.ToTable("TblNameExchange", "PaGamePrivate");

				entity.Property(e => e.OwnerNo)
					.ValueGeneratedNever()
					.HasColumnName("_ownerNo");

				entity.Property(e => e.Character1Name)
					.HasMaxLength(30)
					.HasColumnName("_character1Name");

				entity.Property(e => e.Character1No).HasColumnName("_character1No");

				entity.Property(e => e.Character2Name)
					.HasMaxLength(30)
					.HasColumnName("_character2Name");

				entity.Property(e => e.Character2No).HasColumnName("_character2No");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblOperationMention>(entity =>
			{
				entity.HasKey(e => e.MentionNo)
					.HasName("PkTblOperationMention")
					.IsClustered(false);

				entity.ToTable("TblOperationMention", "PaGamePrivate");

				entity.Property(e => e.MentionNo).HasColumnName("_mentionNo");

				entity.Property(e => e.Mention)
					.HasMaxLength(50)
					.HasColumnName("_mention");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ResourceType).HasColumnName("_resourceType");

				entity.Property(e => e.Type).HasColumnName("_type");
			});

			modelBuilder.Entity<TblOperationTicket>(entity =>
			{
				entity.HasKey(e => e.TicketNo)
					.HasName("PkTblOperationTicket")
					.IsClustered(false);

				entity.ToTable("TblOperationTicket", "PaOperationPrivate");

				entity.Property(e => e.TicketNo).HasColumnName("_ticketNo");

				entity.Property(e => e.ApprovedUserNo).HasColumnName("_approvedUserNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.ConfirmReason)
					.HasMaxLength(300)
					.HasColumnName("_confirmReason");

				entity.Property(e => e.GmUserNo).HasColumnName("_gmUserNo");

				entity.Property(e => e.Priority).HasColumnName("_priority");

				entity.Property(e => e.Reason)
					.HasMaxLength(300)
					.HasColumnName("_reason");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RequestList)
					.HasMaxLength(1000)
					.HasColumnName("_requestList");

				entity.Property(e => e.RequestType).HasColumnName("_requestType");

				entity.Property(e => e.TicketState).HasColumnName("_ticketState");

				entity.Property(e => e.UpdatedDate)
					.HasColumnType("datetime")
					.HasColumnName("_updatedDate");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.WorldNo).HasColumnName("_worldNo");
			});

			modelBuilder.Entity<TblOperationTicketV3>(entity =>
			{
				entity.HasKey(e => e.TicketNo)
					.HasName("PkTblOperationTicket_v3")
					.IsClustered(false);

				entity.ToTable("TblOperationTicket_v3", "PaOperationPrivate");

				entity.Property(e => e.TicketNo).HasColumnName("_ticketNo");

				entity.Property(e => e.ConfirmDate).HasColumnName("_confirmDate");

				entity.Property(e => e.ConfirmReason)
					.HasMaxLength(300)
					.HasColumnName("_confirmReason");

				entity.Property(e => e.ConfirmRoleGroupName)
					.HasMaxLength(30)
					.HasColumnName("_confirmRoleGroupName");

				entity.Property(e => e.ConfirmRoleGroupNo).HasColumnName("_confirmRoleGroupNo");

				entity.Property(e => e.ConfirmWhereNo).HasColumnName("_confirmWhereNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RequestDbName)
					.HasMaxLength(30)
					.HasColumnName("_requestDbName");

				entity.Property(e => e.RequestList).HasColumnName("_requestList");

				entity.Property(e => e.RequestReason)
					.HasMaxLength(300)
					.HasColumnName("_requestReason");

				entity.Property(e => e.RequestRoleGroupName)
					.HasMaxLength(30)
					.HasColumnName("_requestRoleGroupName");

				entity.Property(e => e.RequestRoleGroupNo).HasColumnName("_requestRoleGroupNo");

				entity.Property(e => e.RequestSpName)
					.HasMaxLength(100)
					.HasColumnName("_requestSpName");

				entity.Property(e => e.RequestType).HasColumnName("_requestType");

				entity.Property(e => e.RequestWhereNo).HasColumnName("_requestWhereNo");

				entity.Property(e => e.RequestXmlName)
					.HasMaxLength(30)
					.HasColumnName("_requestXmlName");

				entity.Property(e => e.TicketState).HasColumnName("_ticketState");

				entity.Property(e => e.WhereType).HasColumnName("_whereType");
			});

			modelBuilder.Entity<TblPcroomGateWayList>(entity =>
			{
				entity.HasKey(e => e.GatewayServerNo)
					.HasName("PkTblPCRoomGateWayList");

				entity.ToTable("TblPCRoomGateWayList", "PaGamePrivate");

				entity.Property(e => e.GatewayServerNo).HasColumnName("_gatewayServerNo");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerIp)
					.HasMaxLength(20)
					.HasColumnName("_serverIP");

				entity.Property(e => e.Status).HasColumnName("_status");
			});

			modelBuilder.Entity<TblPcroomLoginList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPCRoomLoginList", "PaGamePrivate");

				entity.Property(e => e.ClientIp)
					.HasMaxLength(20)
					.IsUnicode(false)
					.HasColumnName("_clientIP");

				entity.Property(e => e.GatewayServerNo).HasColumnName("_gatewayServerNo");

				entity.Property(e => e.GussUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_gussUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.IngameUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_ingameUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.LocalIp)
					.HasMaxLength(20)
					.IsUnicode(false)
					.HasColumnName("_localIP");

				entity.Property(e => e.MachineId)
					.HasMaxLength(20)
					.HasColumnName("_machineID");

				entity.Property(e => e.Reason).HasColumnName("_reason");

				entity.Property(e => e.SessionNo)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_sessionNo");

				entity.Property(e => e.Status).HasColumnName("_status");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblPcroomRequestList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPCRoomRequestList", "PaGamePrivate");

				entity.Property(e => e.ClientIp)
					.HasMaxLength(20)
					.IsUnicode(false)
					.HasColumnName("_clientIP");

				entity.Property(e => e.DoState)
					.HasColumnName("_doState")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.GatewayServerNo).HasColumnName("_gatewayServerNo");

				entity.Property(e => e.LocalIp)
					.HasMaxLength(20)
					.IsUnicode(false)
					.HasColumnName("_localIP");

				entity.Property(e => e.MachineId)
					.HasMaxLength(20)
					.HasColumnName("_machineID");

				entity.Property(e => e.RegistDate)
					.HasColumnType("datetime")
					.HasColumnName("_registDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RequestType).HasColumnName("_requestType");

				entity.Property(e => e.SessionNo)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_sessionNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblProhibitedWord>(entity =>
			{
				entity.HasKey(e => e.ProhibitedWord)
					.HasName("PkTblProhibitedWord")
					.IsClustered(false);

				entity.ToTable("TblProhibitedWord", "PaGamePublic");

				entity.Property(e => e.ProhibitedWord)
					.HasMaxLength(30)
					.HasColumnName("_prohibitedWord");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPs4accessTokenList>(entity =>
			{
				entity.HasKey(e => e.UserId)
					.HasName("PkTblPS4AccessTokenList")
					.IsClustered(false);

				entity.ToTable("TblPS4AccessTokenList", "PaGamePrivate");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.AccessToken)
					.HasMaxLength(40)
					.HasColumnName("_accessToken")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Ps4UserId)
					.HasMaxLength(30)
					.HasColumnName("_ps4UserId");
			});

			modelBuilder.Entity<TblPs4cashConsumeLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPS4CashConsumeLog", "PaGamePrivate");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(20)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MailNo).HasColumnName("_mailNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCount).HasColumnName("_useCount");

				entity.Property(e => e.UseLimit).HasColumnName("_useLimit");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblPs4cashInfoWorld>(entity =>
			{
				entity.HasKey(e => new { e.UserId, e.EntitlementId })
					.HasName("PkTblPS4CashInfoWorld")
					.IsClustered(false);

				entity.ToTable("TblPS4CashInfoWorld", "PaGamePrivate");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(16)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.ActiveDate)
					.HasColumnType("datetime")
					.HasColumnName("_activeDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ConsumeCount).HasColumnName("_consumeCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCount).HasColumnName("_useCount");

				entity.Property(e => e.UseLimit).HasColumnName("_useLimit");
			});

			modelBuilder.Entity<TblPs4cashProductAndItemMapping>(entity =>
			{
				entity.HasKey(e => e.EntitlementId)
					.HasName("PkTblPS4CashProductAndItemMapping")
					.IsClustered(false);

				entity.ToTable("TblPS4CashProductAndItemMapping", "PaGamePrivate");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(16)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.Description)
					.HasMaxLength(200)
					.HasColumnName("_description");

				entity.Property(e => e.IsBundleProduct).HasColumnName("_isBundleProduct");

				entity.Property(e => e.NationType).HasColumnName("_nationType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPs4cashProductRefundInfo>(entity =>
			{
				entity.HasKey(e => e.RefundNo)
					.HasName("PkTblPS4CashProductRefundInfo")
					.IsClustered(false);

				entity.ToTable("TblPS4CashProductRefundInfo", "PaGamePrivate");

				entity.Property(e => e.RefundNo).HasColumnName("_refundNo");

				entity.Property(e => e.AfterConsumeCount).HasColumnName("_afterConsumeCount");

				entity.Property(e => e.AfterUseCount).HasColumnName("_afterUseCount");

				entity.Property(e => e.BeforeConsumeCount).HasColumnName("_beforeConsumeCount");

				entity.Property(e => e.BeforeUseCount).HasColumnName("_beforeUseCount");

				entity.Property(e => e.CancelDate)
					.HasColumnType("datetime")
					.HasColumnName("_cancelDate");

				entity.Property(e => e.CompleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_completeDate");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(16)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.IsCheckProductCount).HasColumnName("_isCheckProductCount");

				entity.Property(e => e.ProductId)
					.HasMaxLength(40)
					.HasColumnName("_ProductId");

				entity.Property(e => e.RefundCount).HasColumnName("_refundCount");

				entity.Property(e => e.RefundState).HasColumnName("_refundState");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblPs4devAccessUserList>(entity =>
			{
				entity.HasKey(e => e.TokenKey)
					.HasName("PkTblPS4AccessUserList")
					.IsClustered(false);

				entity.ToTable("TblPS4DevAccessUserList", "PaGamePrivate");

				entity.Property(e => e.TokenKey)
					.HasMaxLength(25)
					.HasColumnName("_tokenKey");

				entity.Property(e => e.AccessIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_accessIp")
					.HasDefaultValueSql("(' ')");

				entity.Property(e => e.Ps4UserId)
					.HasMaxLength(30)
					.HasColumnName("_ps4UserId");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UsedDate)
					.HasColumnType("datetime")
					.HasColumnName("_usedDate");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblPs4entitlementHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPS4EntitlementHistory", "PaGamePrivate");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(16)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.Index)
					.ValueGeneratedOnAdd()
					.HasColumnName("_index");

				entity.Property(e => e.PurchaseCountry)
					.HasMaxLength(10)
					.HasColumnName("_purchaseCountry");

				entity.Property(e => e.RegDate)
					.HasColumnType("datetime")
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCount)
					.HasColumnName("_useCount")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UseLimit)
					.HasColumnName("_useLimit")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblPs4refundHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPS4RefundHistory", "PaGamePrivate");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(16)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.Index)
					.ValueGeneratedOnAdd()
					.HasColumnName("_index");

				entity.Property(e => e.PurchaseCountry)
					.HasMaxLength(10)
					.HasColumnName("_purchaseCountry");

				entity.Property(e => e.RegDate)
					.HasColumnType("datetime")
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCount)
					.HasColumnName("_useCount")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UseLimit)
					.HasColumnName("_useLimit")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblRecommandUserNickName>(entity =>
			{
				entity.HasKey(e => e.RecommandNickNameIndex)
					.HasName("PkTblRecommandUserNickName");

				entity.ToTable("TblRecommandUserNickName", "PaGamePrivate");

				entity.HasComment("가문 생성시 추천 닉네임");

				entity.Property(e => e.RecommandNickNameIndex)
					.HasColumnName("_recommandNickNameIndex")
					.HasComment("추천 닉네임 인덱스");

				entity.Property(e => e.RecommandNickName)
					.HasMaxLength(26)
					.HasColumnName("_recommandNickName")
					.HasDefaultValueSql("('')")
					.HasComment("추천 닉네임 스트링");

				entity.Property(e => e.RecommandNickNameId)
					.HasColumnName("_recommandNickNameID")
					.HasComment("추천 닉네임 뒤에 붙을 고유 ID");
			});

			modelBuilder.Entity<TblReplaceSubItemGroup>(entity =>
			{
				entity.HasKey(e => e.ItemSubGroupKey)
					.HasName("PkTblReplaceSubItemGroup")
					.IsClustered(false);

				entity.ToTable("TblReplaceSubItemGroup", "PaGamePrivate");

				entity.HasComment("변경할 드랍그룹(일본용)");

				entity.Property(e => e.ItemSubGroupKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemSubGroupKey")
					.HasComment("아이템드랍엑셀의 서브그룹키(ItemSubGroup_Table)");

				entity.Property(e => e.ItemList)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_itemList")
					.HasComment("아이템목록");
			});

			modelBuilder.Entity<TblReportedNegativeUser>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblReportedNegativeUser", "PaGamePrivate");

				entity.Property(e => e.OwnerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_ownerCharacterName");

				entity.Property(e => e.OwnerUserCharacterNo).HasColumnName("_ownerUserCharacterNo");

				entity.Property(e => e.OwnerUserNo).HasColumnName("_ownerUserNo");

				entity.Property(e => e.PositionX).HasColumnName("_positionX");

				entity.Property(e => e.PositionY).HasColumnName("_positionY");

				entity.Property(e => e.PositionZ).HasColumnName("_positionZ");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Report)
					.HasMaxLength(100)
					.HasColumnName("_report");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.TargetCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_targetCharacterName");

				entity.Property(e => e.TargetUserCharacterNo).HasColumnName("_targetUserCharacterNo");

				entity.Property(e => e.TargetUserNo).HasColumnName("_targetUserNo");

				entity.Property(e => e.Type).HasColumnName("_type");
			});

			modelBuilder.Entity<TblRoleGroup>(entity =>
			{
				entity.HasKey(e => new { e.RoleGroupNo, e.RoleNo })
					.HasName("PkTblRoleGroup")
					.IsClustered(false);

				entity.ToTable("TblRoleGroup", "PaGamePrivate");

				entity.Property(e => e.RoleGroupNo).HasColumnName("_roleGroupNo");

				entity.Property(e => e.RoleNo).HasColumnName("_roleNo");

				entity.Property(e => e.ConfirmPass).HasColumnName("_confirmPass");
			});

			modelBuilder.Entity<TblRoleGroupMember>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblRoleGroupMember")
					.IsClustered(false);

				entity.ToTable("TblRoleGroupMember", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.IpAddress)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_ipAddress")
					.HasDefaultValueSql("(' ')");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(32)
					.IsUnicode(false)
					.HasColumnName("_macAddress")
					.HasDefaultValueSql("(' ')");

				entity.Property(e => e.Password)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_password");

				entity.Property(e => e.PasswordUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_passwordUpdateDate");

				entity.Property(e => e.PrevPassword1)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_prevPassword1");

				entity.Property(e => e.PrevPassword2)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_prevPassword2");

				entity.Property(e => e.PrevPassword3)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_prevPassword3");

				entity.Property(e => e.RoleGroupNo).HasColumnName("_roleGroupNo");
			});

			modelBuilder.Entity<TblRoleGroupMemberLoginIpOasis>(entity =>
			{
				entity.HasKey(e => new { e.WhereType, e.WhereNo, e.IpAddress })
					.HasName("PkTblRoleGroupMemberLoginIpOasis")
					.IsClustered(false);

				entity.ToTable("TblRoleGroupMemberLoginIpOasis", "PaOperationPrivate");

				entity.Property(e => e.WhereType).HasColumnName("_whereType");

				entity.Property(e => e.WhereNo).HasColumnName("_whereNo");

				entity.Property(e => e.IpAddress)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_ipAddress")
					.HasDefaultValueSql("(' ')");
			});

			modelBuilder.Entity<TblRoleGroupMemberOasis>(entity =>
			{
				entity.HasKey(e => new { e.WhereType, e.WhereNo })
					.HasName("PkTblRoleGroupMemberOasis")
					.IsClustered(false);

				entity.ToTable("TblRoleGroupMemberOasis", "PaOperationPrivate");

				entity.Property(e => e.WhereType).HasColumnName("_whereType");

				entity.Property(e => e.WhereNo).HasColumnName("_whereNo");

				entity.Property(e => e.ExtraTime).HasColumnName("_extraTime");

				entity.Property(e => e.LastLoginDate).HasColumnName("_lastLoginDate");

				entity.Property(e => e.LoginAttemptCount).HasColumnName("_loginAttemptCount");

				entity.Property(e => e.Password)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_password");

				entity.Property(e => e.PasswordUpdateDate).HasColumnName("_passwordUpdateDate");

				entity.Property(e => e.PrevPassword1)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_prevPassword1");

				entity.Property(e => e.PrevPassword2)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_prevPassword2");

				entity.Property(e => e.PrevPassword3)
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasColumnName("_prevPassword3");

				entity.Property(e => e.RoleGroupMemberMemo)
					.HasMaxLength(50)
					.HasColumnName("_roleGroupMemberMemo");

				entity.Property(e => e.RoleGroupNo).HasColumnName("_roleGroupNo");
			});

			modelBuilder.Entity<TblRoleGroupName>(entity =>
			{
				entity.HasKey(e => e.RoleGroupNo)
					.HasName("PkTblRoleGroupName")
					.IsClustered(false);

				entity.ToTable("TblRoleGroupName", "PaGamePrivate");

				entity.Property(e => e.RoleGroupNo).HasColumnName("_roleGroupNo");

				entity.Property(e => e.RoleGroupGrade)
					.HasColumnName("_roleGroupGrade")
					.HasDefaultValueSql("((100))");

				entity.Property(e => e.RoleGroupMemo)
					.HasMaxLength(50)
					.HasColumnName("_roleGroupMemo");

				entity.Property(e => e.RoleGroupName)
					.HasMaxLength(30)
					.HasColumnName("_roleGroupName");
			});

			modelBuilder.Entity<TblRoleGroupNameOasis>(entity =>
			{
				entity.HasKey(e => e.RoleGroupNo)
					.HasName("PkTblRoleGroupNameOasis")
					.IsClustered(false);

				entity.ToTable("TblRoleGroupNameOasis", "PaOperationPrivate");

				entity.Property(e => e.RoleGroupNo).HasColumnName("_roleGroupNo");

				entity.Property(e => e.RoleGroupGrade)
					.HasColumnName("_roleGroupGrade")
					.HasDefaultValueSql("((100))");

				entity.Property(e => e.RoleGroupMemo)
					.HasMaxLength(50)
					.HasColumnName("_roleGroupMemo");

				entity.Property(e => e.RoleGroupName)
					.HasMaxLength(30)
					.HasColumnName("_roleGroupName");
			});

			modelBuilder.Entity<TblRoleGroupOasis>(entity =>
			{
				entity.HasKey(e => new { e.RoleGroupNo, e.RoleNo })
					.HasName("PkTblRoleGroupOasis")
					.IsClustered(false);

				entity.ToTable("TblRoleGroupOasis", "PaOperationPrivate");

				entity.Property(e => e.RoleGroupNo).HasColumnName("_roleGroupNo");

				entity.Property(e => e.RoleNo).HasColumnName("_roleNo");
			});

			modelBuilder.Entity<TblRoleList>(entity =>
			{
				entity.HasKey(e => e.RoleNo)
					.HasName("PkTblRoleList")
					.IsClustered(false);

				entity.ToTable("TblRoleList", "PaGamePublic");

				entity.Property(e => e.RoleNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_roleNo");

				entity.Property(e => e.RoleName)
					.HasMaxLength(30)
					.HasColumnName("_roleName");
			});

			modelBuilder.Entity<TblRoleListOasis>(entity =>
			{
				entity.HasKey(e => e.RoleNo)
					.HasName("PkTblRoleListOasis")
					.IsClustered(false);

				entity.ToTable("TblRoleListOasis", "PaOperationPrivate");

				entity.Property(e => e.RoleNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_roleNo");

				entity.Property(e => e.RoleName)
					.HasMaxLength(30)
					.HasColumnName("_roleName");
			});

			modelBuilder.Entity<TblServerChannelChatInformation>(entity =>
			{
				entity.HasKey(e => e.RoomNo)
					.HasName("PkTblServerChannelChatInformation");

				entity.ToTable("TblServerChannelChatInformation", "PaGamePrivate");

				entity.Property(e => e.RoomNo)
					.ValueGeneratedNever()
					.HasColumnName("_roomNo");

				entity.Property(e => e.MaxMemberCount).HasColumnName("_maxMemberCount");

				entity.Property(e => e.OrderNo).HasColumnName("_orderNo");

				entity.Property(e => e.RoomDesc)
					.HasMaxLength(150)
					.HasColumnName("_roomDesc");

				entity.Property(e => e.RoomName)
					.HasMaxLength(32)
					.HasColumnName("_roomName");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblServerDataCrc>(entity =>
			{
				entity.HasKey(e => new { e.ServerVersion, e.ServerDataCrc })
					.HasName("PkTblServerDataCRC");

				entity.ToTable("TblServerDataCRC", "PaGamePrivate");

				entity.Property(e => e.ServerVersion).HasColumnName("_serverVersion");

				entity.Property(e => e.ServerDataCrc)
					.HasColumnName("_serverDataCRC")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.RegistDate)
					.HasColumnType("datetime")
					.HasColumnName("_registDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblServerExpPreset>(entity =>
			{
				entity.HasKey(e => new { e.SavePresetName, e.ServerNo })
					.HasName("PkTblServerExpPreset")
					.IsClustered(false);

				entity.ToTable("TblServerExpPreset", "PaOperationPrivate");

				entity.Property(e => e.SavePresetName)
					.HasMaxLength(30)
					.HasColumnName("_savePresetName");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.BattleDrop).HasColumnName("_battleDrop");

				entity.Property(e => e.BattleExp).HasColumnName("_battleExp");

				entity.Property(e => e.BattleExpTooltipText)
					.HasMaxLength(30)
					.HasColumnName("_battleExpTooltipText")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IsShowDropEvent).HasColumnName("_isShowDropEvent");

				entity.Property(e => e.IsShowExpEvent).HasColumnName("_isShowExpEvent");

				entity.Property(e => e.LifeDrop1).HasColumnName("_lifeDrop1");

				entity.Property(e => e.LifeDrop10).HasColumnName("_lifeDrop10");

				entity.Property(e => e.LifeDrop11).HasColumnName("_lifeDrop11");

				entity.Property(e => e.LifeDrop12).HasColumnName("_lifeDrop12");

				entity.Property(e => e.LifeDrop13).HasColumnName("_lifeDrop13");

				entity.Property(e => e.LifeDrop14).HasColumnName("_lifeDrop14");

				entity.Property(e => e.LifeDrop15).HasColumnName("_lifeDrop15");

				entity.Property(e => e.LifeDrop2).HasColumnName("_lifeDrop2");

				entity.Property(e => e.LifeDrop3).HasColumnName("_lifeDrop3");

				entity.Property(e => e.LifeDrop4).HasColumnName("_lifeDrop4");

				entity.Property(e => e.LifeDrop5).HasColumnName("_lifeDrop5");

				entity.Property(e => e.LifeDrop6).HasColumnName("_lifeDrop6");

				entity.Property(e => e.LifeDrop7).HasColumnName("_lifeDrop7");

				entity.Property(e => e.LifeDrop8).HasColumnName("_lifeDrop8");

				entity.Property(e => e.LifeDrop9).HasColumnName("_lifeDrop9");

				entity.Property(e => e.LifeExp1).HasColumnName("_lifeExp1");

				entity.Property(e => e.LifeExp10).HasColumnName("_lifeExp10");

				entity.Property(e => e.LifeExp11).HasColumnName("_lifeExp11");

				entity.Property(e => e.LifeExp12).HasColumnName("_lifeExp12");

				entity.Property(e => e.LifeExp13).HasColumnName("_lifeExp13");

				entity.Property(e => e.LifeExp14).HasColumnName("_lifeExp14");

				entity.Property(e => e.LifeExp15).HasColumnName("_lifeExp15");

				entity.Property(e => e.LifeExp2).HasColumnName("_lifeExp2");

				entity.Property(e => e.LifeExp3).HasColumnName("_lifeExp3");

				entity.Property(e => e.LifeExp4).HasColumnName("_lifeExp4");

				entity.Property(e => e.LifeExp5).HasColumnName("_lifeExp5");

				entity.Property(e => e.LifeExp6).HasColumnName("_lifeExp6");

				entity.Property(e => e.LifeExp7).HasColumnName("_lifeExp7");

				entity.Property(e => e.LifeExp8).HasColumnName("_lifeExp8");

				entity.Property(e => e.LifeExp9).HasColumnName("_lifeExp9");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SkillExp).HasColumnName("_skillExp");

				entity.Property(e => e.VehicleExp).HasColumnName("_vehicleExp");
			});

			modelBuilder.Entity<TblServerFamilyInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblServerFamilyInformation", "PaGamePrivate");

				entity.Property(e => e.FromServerNo).HasColumnName("_fromServerNo");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ToServerNo).HasColumnName("_toServerNo");
			});

			modelBuilder.Entity<TblServerGroup>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblServerGroup", "PaOperationPrivate");

				entity.Property(e => e.ServerGroup)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_serverGroup")
					.IsFixedLength();

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblServerInformation>(entity =>
			{
				entity.HasKey(e => e.ServerNo)
					.HasName("PkTblServerInformation")
					.IsClustered(false);

				entity.ToTable("TblServerInformation", "PaGamePrivate");

				entity.Property(e => e.ServerNo)
					.ValueGeneratedNever()
					.HasColumnName("_serverNo");

				entity.Property(e => e.ServerName)
					.HasMaxLength(30)
					.HasColumnName("_serverName");
			});

			modelBuilder.Entity<TblServerInformationPreset>(entity =>
			{
				entity.HasKey(e => e.PresetName)
					.HasName("PkTblServerInformationPreset");

				entity.ToTable("TblServerInformationPreset", "PaOperationPrivate");

				entity.Property(e => e.PresetName)
					.HasMaxLength(30)
					.HasColumnName("_presetName");

				entity.Property(e => e.DoCompetitionArsha).HasColumnName("_doCompetitionArsha");

				entity.Property(e => e.DoHorseRaceMatch).HasColumnName("_doHorseRaceMatch");

				entity.Property(e => e.DoImperialDelivery).HasColumnName("_doImperialDelivery");

				entity.Property(e => e.DoImperialProductDelivery).HasColumnName("_doImperialProductDelivery");

				entity.Property(e => e.DontPvPtendencyDecrease).HasColumnName("_dontPvPTendencyDecrease");

				entity.Property(e => e.FieldDsn)
					.HasMaxLength(100)
					.HasColumnName("_fieldDsn")
					.HasDefaultValueSql("('field1.dsn')");

				entity.Property(e => e.FixedCharge).HasColumnName("_fixedCharge");

				entity.Property(e => e.IsBalanceChannel).HasColumnName("_isBalanceChannel");

				entity.Property(e => e.IsCantPvPchannel).HasColumnName("_isCantPvPChannel");

				entity.Property(e => e.IsEventChannel).HasColumnName("_isEventChannel");

				entity.Property(e => e.IsFixedBossSpawn).HasColumnName("_isFixedBossSpawn");

				entity.Property(e => e.IsGuildBattleChannel).HasColumnName("_isGuildBattleChannel");

				entity.Property(e => e.IsHadumChannel).HasColumnName("_isHadumChannel");

				entity.Property(e => e.IsInstanceFieldMainServer)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_isInstanceFieldMainServer")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IsLimitedLocalWar).HasColumnName("_isLimitedLocalWar");

				entity.Property(e => e.IsPcroomChannel).HasColumnName("_isPcroomChannel");

				entity.Property(e => e.IsPremiumChannel).HasColumnName("_isPremiumChannel");

				entity.Property(e => e.IsSavageDefence).HasColumnName("_isSavageDefence");

				entity.Property(e => e.IsSeasonChannel).HasColumnName("_isSeasonChannel");

				entity.Property(e => e.IsSeasonNewbieChannel).HasColumnName("_isSeasonNewbieChannel");

				entity.Property(e => e.IsSequentialCheck).HasColumnName("_isSequentialCheck");

				entity.Property(e => e.IsSpareMachine).HasColumnName("_isSpareMachine");

				entity.Property(e => e.IsSpeedChannel).HasColumnName("_isSpeedChannel");

				entity.Property(e => e.IsSteamChannel).HasColumnName("_isSteamChannel");

				entity.Property(e => e.LogDsn)
					.HasMaxLength(100)
					.HasColumnName("_logDsn")
					.HasDefaultValueSql("('log1.dsn')");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(32)
					.IsUnicode(false)
					.HasColumnName("_macAddress")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_mainIP")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PublicIp)
					.HasMaxLength(100)
					.IsUnicode(false)
					.HasColumnName("_publicIP")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.RegistDate)
					.HasColumnType("datetime")
					.HasColumnName("_registDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerGroupNo).HasColumnName("_serverGroupNo");

				entity.Property(e => e.ServerName)
					.HasMaxLength(30)
					.HasColumnName("_serverName")
					.HasDefaultValueSql("(N'None')");

				entity.Property(e => e.ServerType)
					.HasColumnName("_serverType")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ServicePlatformType).HasColumnName("_servicePlatformType");

				entity.Property(e => e.StartNationSiege).HasColumnName("_startNationSiege");

				entity.Property(e => e.StartSiegeTerritory)
					.HasColumnName("_startSiegeTerritory")
					.HasDefaultValueSql("((-2))");

				entity.Property(e => e.WorldNo)
					.HasColumnName("_worldNo")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<TblServerInstanceFieldInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblServerInstanceFieldInformation", "PaGamePrivate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.InstanceFieldMapKey).HasColumnName("_instanceFieldMapKey");

				entity.Property(e => e.InstanceFieldMode).HasColumnName("_instanceFieldMode");

				entity.Property(e => e.InstanceFieldType).HasColumnName("_instanceFieldType");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblShaRegistedUserYesterday>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblShaRegistedUserYesterday", "PaOperationPrivate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblStatementTemp>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblStatementTemp", "PaOperationPrivate");

				entity.Property(e => e.Idx)
					.ValueGeneratedOnAdd()
					.HasColumnName("_idx");

				entity.Property(e => e.ObjectName)
					.HasMaxLength(100)
					.IsUnicode(false)
					.HasColumnName("_objectName");

				entity.Property(e => e.ObjectQuert)
					.IsUnicode(false)
					.HasColumnName("_objectQuert");

				entity.Property(e => e.Objecttype)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_objecttype");
			});

			modelBuilder.Entity<TblTeenageUserInformation>(entity =>
			{
				entity.HasKey(e => e.UserId)
					.HasName("PkTblTeenageUserInformation")
					.IsClustered(false);

				entity.ToTable("TblTeenageUserInformation", "PaGamePrivate");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TeenAgeType).HasColumnName("_teenAgeType");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblTradeAuthKey>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblTradeAuthKey_userNo")
					.IsClustered(false);

				entity.ToTable("TblTradeAuthKey", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.CurKey).HasColumnName("_curKey");

				entity.Property(e => e.CurUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_curUpdateDate");

				entity.Property(e => e.PrevKey).HasColumnName("_prevKey");

				entity.Property(e => e.PrevUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_prevUpdateDate");
			});

			modelBuilder.Entity<TblTradeAuthKeyHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblTradeAuthKeyHistory", "PaGamePrivate");

				entity.Property(e => e.CurKey)
					.HasMaxLength(50)
					.HasColumnName("_curKey");

				entity.Property(e => e.CurUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_curUpdateDate");

				entity.Property(e => e.HistoryNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_historyNo");

				entity.Property(e => e.PrevKey)
					.HasMaxLength(50)
					.HasColumnName("_prevKey");

				entity.Property(e => e.PrevUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_prevUpdateDate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RequestKey)
					.HasMaxLength(50)
					.HasColumnName("_requestKey");

				entity.Property(e => e.ReturnValue).HasColumnName("_returnValue");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblTransferAccountBuffUserList>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblTransferAccountBuffUserList")
					.IsClustered(false);

				entity.ToTable("TblTransferAccountBuffUserList", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblTranslationReport>(entity =>
			{
				entity.HasKey(e => e.ReportNo)
					.HasName("PkTblTranslationReport")
					.IsClustered(false);

				entity.ToTable("TblTranslationReport", "PaGamePrivate");

				entity.HasComment("번역신고");

				entity.Property(e => e.ReportNo)
					.HasColumnName("_reportNo")
					.HasComment("신고글의 고유 번호");

				entity.Property(e => e.RecommendCount)
					.HasColumnName("_recommendCount")
					.HasComment("추천수");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("신고일");

				entity.Property(e => e.ServiceResourceType)
					.HasColumnName("_serviceResourceType")
					.HasComment("언어 타입");

				entity.Property(e => e.StaticType)
					.HasColumnName("_staticType")
					.HasComment("번역키");

				entity.Property(e => e.TextNo)
					.HasColumnName("_textNo")
					.HasComment("번역키");

				entity.Property(e => e.TranslationKey1)
					.HasColumnName("_translationKey1")
					.HasComment("번역키");

				entity.Property(e => e.TranslationKey2)
					.HasColumnName("_translationKey2")
					.HasComment("번역키");

				entity.Property(e => e.TranslationKey3)
					.HasColumnName("_translationKey3")
					.HasComment("번역키");

				entity.Property(e => e.TranslationText)
					.HasMaxLength(2000)
					.HasColumnName("_translationText")
					.HasComment("바꾸고자 하는 번역 내용");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 번호");
			});

			modelBuilder.Entity<TblTranslationReportRecommendHistory>(entity =>
			{
				entity.HasKey(e => new { e.ReportNo, e.UserNo })
					.HasName("PkTblTranslationReportRecommendHistory")
					.IsClustered(false);

				entity.ToTable("TblTranslationReportRecommendHistory", "PaGamePrivate");

				entity.Property(e => e.ReportNo).HasColumnName("_reportNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblUniqueName>(entity =>
			{
				entity.HasKey(e => new { e.Type, e.Name })
					.HasName("PkTblUniqueName")
					.IsClustered(false);

				entity.ToTable("TblUniqueName", "PaGamePrivate");

				entity.HasComment("유일한 이름");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("0 캐릭터명,1 길드명, 2 가문명(enum NameType)");

				entity.Property(e => e.Name)
					.HasMaxLength(50)
					.HasColumnName("_name")
					.HasComment("이름");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasComment("삭제일");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("생성일");

				entity.Property(e => e.SubType).HasColumnName("_subType");

				entity.Property(e => e.VariousNo)
					.HasColumnName("_variousNo")
					.HasComment("해당번호");

				entity.Property(e => e.WorldNo)
					.HasColumnName("_worldNo")
					.HasComment("월드번호");
			});

			modelBuilder.Entity<TblUniqueNameBackup>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblUniqueName_Backup", "PaOperationPrivate");

				entity.Property(e => e.BackupDate)
					.HasMaxLength(8)
					.HasColumnName("_backupDate");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.Name)
					.HasMaxLength(50)
					.HasColumnName("_name");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");

				entity.Property(e => e.WorldNo).HasColumnName("_worldNo");
			});

			modelBuilder.Entity<TblUserCache>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblUserCache");

				entity.ToTable("TblUserCache", "PaGamePrivate");

				entity.HasComment("유저 캐시");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("유저");

				entity.Property(e => e.Pack)
					.HasColumnName("_pack")
					.HasComment("캐시 데이터(pack)");
			});

			modelBuilder.Entity<TblUserChattingMacro>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.MacroNo })
					.HasName("PkTblUserChattingMacro");

				entity.ToTable("TblUserChattingMacro", "PaGamePrivate");

				entity.HasComment("유저를 위한 채팅 매크로 정보");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.MacroNo)
					.HasColumnName("_macroNo")
					.HasComment("매크로 번호");

				entity.Property(e => e.ChatMessage)
					.HasMaxLength(100)
					.HasColumnName("_chatMessage")
					.HasDefaultValueSql("('')")
					.HasComment("채팅 메시지");

				entity.Property(e => e.ChatType)
					.HasColumnName("_chatType")
					.HasComment("채팅 타입");
			});

			modelBuilder.Entity<TblUserEtcInformation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblUserEtcInformation")
					.IsClustered(false);

				entity.ToTable("TblUserEtcInformation", "PaGamePrivate");

				entity.HasComment("유저부가정보");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("_userNo");

				entity.Property(e => e.ConsoleCrossPlayOption)
					.IsRequired()
					.HasColumnName("_consoleCrossPlayOption")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.CpuBrandString)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("_cpuBrandString")
					.HasComment("_cpuBrandString");

				entity.Property(e => e.GraphicOption)
					.HasColumnName("_graphicOption")
					.HasComment("_graphicOption");

				entity.Property(e => e.GraphicsAdapterBrandString)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("_graphicsAdapterBrandString")
					.HasComment("_graphicsAdapterBrandString");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("생성일");

				entity.Property(e => e.ResoulutionHeight)
					.HasColumnName("_resoulutionHeight")
					.HasComment("_resoulutionHeight");

				entity.Property(e => e.ResoulutionWidth)
					.HasColumnName("_resoulutionWidth")
					.HasComment("_resoulutionWidth");

				entity.Property(e => e.TextureQuality)
					.HasColumnName("_textureQuality")
					.HasComment("_textureQuality");

				entity.Property(e => e.TotalSystemMemory)
					.HasColumnName("_totalSystemMemory")
					.HasComment("_totalSystemMemory");
			});

			modelBuilder.Entity<TblUserGameOption>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblUserGameOption");

				entity.ToTable("TblUserGameOption", "PaGamePrivate");

				entity.HasComment("유저를 위한 게임 옵션 정보");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.GameOptionSerializedData)
					.HasMaxLength(200)
					.IsUnicode(false)
					.HasColumnName("_gameOptionSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("게임 옵션 데이터");
			});

			modelBuilder.Entity<TblUserInformation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.IsClustered(false);

				entity.ToTable("TblUserInformation", "PaGamePrivate");

				entity.HasComment("유저정보");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("_userNo");

				entity.Property(e => e.AccountExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_accountExpirationDate")
					.HasComment("계정 만료 시간");

				entity.Property(e => e.AllCharacterTotalLevel).HasColumnName("_allCharacterTotalLevel");

				entity.Property(e => e.AtField)
					.HasMaxLength(13)
					.IsUnicode(false)
					.HasColumnName("_atField")
					.HasDefaultValueSql("(left(newid(),(13)))")
					.IsFixedLength();

				entity.Property(e => e.AuthenticExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_authenticExpiration")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("인증유통기한");

				entity.Property(e => e.AuthenticKey)
					.HasColumnName("_authenticKey")
					.HasComment("인증Key");

				entity.Property(e => e.Balance).HasColumnName("_balance");

				entity.Property(e => e.Email)
					.HasMaxLength(125)
					.HasColumnName("_email");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.FailPasswordCount)
					.HasColumnName("_failPasswordCount")
					.HasComment("비밀번호 틀린 횟수");

				entity.Property(e => e.Fullname)
					.HasMaxLength(255)
					.HasColumnName("_fullname");

				entity.Property(e => e.IsAccessBlanceChannel)
					.IsRequired()
					.HasColumnName("_isAccessBlanceChannel")
					.HasDefaultValueSql("((1))")
					.HasComment("밸런스 채널에 접속 가능한가");

				entity.Property(e => e.IsAdmissionToSpeedServer)
					.HasColumnName("_isAdmissionToSpeedServer")
					.HasDefaultValueSql("((2))")
					.HasComment("스피드서버 접속 가능 여부");

				entity.Property(e => e.IsAdultWorldUser)
					.HasColumnName("_isAdultWorldUser")
					.HasComment("성인 채널에 접속 한 계정인지");

				entity.Property(e => e.IsAppliedNickNameChange).HasColumnName("_isAppliedNickNameChange");

				entity.Property(e => e.IsCompleteTesterSubmit).HasColumnName("_isCompleteTesterSubmit");

				entity.Property(e => e.IsEmailConfirmed).HasColumnName("_isEmailConfirmed");

				entity.Property(e => e.IsGuestAccount)
					.HasColumnName("_isGuestAccount")
					.HasComment("게스트 패스");

				entity.Property(e => e.IsIgnoreCheckCustomizeOnly)
					.HasColumnName("_isIgnoreCheckCustomizeOnly")
					.HasComment("사전생성 기간에도 접속 유무");

				entity.Property(e => e.IsOtp).HasColumnName("_isOtp");

				entity.Property(e => e.IsPcRoom)
					.HasColumnName("_isPcRoom")
					.HasComment("피씨방 여부");

				entity.Property(e => e.IsPremiumChannelPermission)
					.HasColumnName("_isPremiumChannelPermission")
					.HasComment("프리미엄 채널 입장 가능여부");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))")
					.HasComment("참인 경우에만 선택할 수 있는 사용자임");

				entity.Property(e => e.LastIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_lastIp")
					.HasDefaultValueSql("(' ')")
					.HasComment("최근접속IP");

				entity.Property(e => e.LastLoginTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLoginTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("최근로그인시간");

				entity.Property(e => e.LastLogoutTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLogoutTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("최근로그아웃시간");

				entity.Property(e => e.LastMacAddress)
					.HasMaxLength(64)
					.HasColumnName("_lastMacAddress");

				entity.Property(e => e.LastServerNo)
					.HasColumnName("_lastServerNo")
					.HasDefaultValueSql("((-1))")
					.HasComment("접속중인 월드번호.=>접속중이 아니면 음수임");

				entity.Property(e => e.LastWorldNo).HasColumnName("_lastWorldNo");

				entity.Property(e => e.MembershipType)
					.HasColumnName("_membershipType")
					.HasComment("유저 채널링 정보");

				entity.Property(e => e.Password)
					.HasMaxLength(256)
					.HasColumnName("_password")
					.HasComment("2차 비밀 번호");

				entity.Property(e => e.PaymentPassword)
					.HasMaxLength(256)
					.HasColumnName("_paymentPassword")
					.HasComment("결제 비밀 번호");

				entity.Property(e => e.PlayToken)
					.HasMaxLength(256)
					.IsUnicode(false)
					.HasColumnName("_playToken");

				entity.Property(e => e.PreAuthenticKey)
					.HasColumnName("_preAuthenticKey")
					.HasComment("재접 인증Key");

				entity.Property(e => e.PublisherCryptToken)
					.HasMaxLength(40)
					.IsUnicode(false)
					.HasColumnName("_publisherCryptToken")
					.HasComment("퍼블리셔 토큰 정보");

				entity.Property(e => e.RealPassword)
					.HasMaxLength(32)
					.HasColumnName("_realPassword");

				entity.Property(e => e.RefreshToken)
					.HasMaxLength(256)
					.IsUnicode(false)
					.HasColumnName("_refreshToken");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("생성일");

				entity.Property(e => e.ServiceType).HasColumnName("_serviceType");

				entity.Property(e => e.ShutDownTime)
					.HasColumnType("datetime")
					.HasColumnName("_shutDownTime")
					.HasComment("셧다운 시간");

				entity.Property(e => e.SpeedServerExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_speedServerExpiration")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("스피드서버 접속 가능 기간");

				entity.Property(e => e.SurveyHwandSw)
					.HasMaxLength(200)
					.IsUnicode(false)
					.HasColumnName("_surveyHWAndSW")
					.HasComment("하드웨어와 드라이버 정보");

				entity.Property(e => e.TokenExpireDate)
					.HasColumnName("_tokenExpireDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TotalPlayTime)
					.HasColumnName("_totalPlayTime")
					.HasComment("총 play시간(단위:분)");

				entity.Property(e => e.UserId)
					.HasMaxLength(64)
					.HasColumnName("_userId")
					.HasComment("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasComment("_userNickname");

				entity.Property(e => e.Username)
					.HasMaxLength(32)
					.HasColumnName("_username");

				entity.Property(e => e.WebAuthenticKey).HasColumnName("_webAuthenticKey");
			});

			modelBuilder.Entity<TblUserNickNameModStr>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblUserNickNameModStr", "PaWebGamePrivate");

				entity.Property(e => e.Idx).HasColumnName("_idx");

				entity.Property(e => e.Str)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_str")
					.IsFixedLength();
			});

			modelBuilder.Entity<TblUserUiinfomation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblUserUIInfomation");

				entity.ToTable("TblUserUIInfomation", "PaGamePrivate");

				entity.HasComment("탈것 장착 메시 보이기on/off");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.AvatarEquipSlotFlag)
					.HasColumnName("_avatarEquipSlotFlag")
					.HasComment("아바타 장착");

				entity.Property(e => e.CamelVehicleEquipFlag)
					.HasColumnName("_camelVehicleEquipFlag")
					.HasComment("낙타 탈것 장비");

				entity.Property(e => e.HorseVehicleEquipFlag)
					.HasColumnName("_horseVehicleEquipFlag")
					.HasComment("말 탈것 장비");

				entity.Property(e => e.IsBattleHelmShow)
					.HasColumnName("_isBattleHelmShow")
					.HasComment("안면 보호대");

				entity.Property(e => e.IsCloakShow)
					.IsRequired()
					.HasColumnName("_isCloakShow")
					.HasDefaultValueSql("((1))")
					.HasComment("망토 보이기 on/off");
			});

			modelBuilder.Entity<TblValidServerInformation>(entity =>
			{
				entity.HasKey(e => e.ServerNo)
					.HasName("PkTblValidServerInformation");

				entity.ToTable("TblValidServerInformation", "PaGamePrivate");

				entity.Property(e => e.ServerNo)
					.ValueGeneratedNever()
					.HasColumnName("_serverNo");

				entity.Property(e => e.DoCompetitionArsha).HasColumnName("_doCompetitionArsha");

				entity.Property(e => e.DoHorseRaceMatch).HasColumnName("_doHorseRaceMatch");

				entity.Property(e => e.DoImperialDelivery).HasColumnName("_doImperialDelivery");

				entity.Property(e => e.DoImperialProductDelivery).HasColumnName("_doImperialProductDelivery");

				entity.Property(e => e.DontPvPtendencyDecrease).HasColumnName("_dontPvPTendencyDecrease");

				entity.Property(e => e.FieldDsn)
					.HasMaxLength(100)
					.HasColumnName("_fieldDsn")
					.HasDefaultValueSql("('field1.dsn')");

				entity.Property(e => e.FixedCharge).HasColumnName("_fixedCharge");

				entity.Property(e => e.IsBalanceChannel).HasColumnName("_isBalanceChannel");

				entity.Property(e => e.IsCantPvPchannel).HasColumnName("_isCantPvPChannel");

				entity.Property(e => e.IsEventChannel).HasColumnName("_isEventChannel");

				entity.Property(e => e.IsFixedBossSpawn).HasColumnName("_isFixedBossSpawn");

				entity.Property(e => e.IsGuildBattleChannel).HasColumnName("_isGuildBattleChannel");

				entity.Property(e => e.IsHadumChannel).HasColumnName("_isHadumChannel");

				entity.Property(e => e.IsInstanceFieldMainServer)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_isInstanceFieldMainServer")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IsLimitedLocalWar).HasColumnName("_isLimitedLocalWar");

				entity.Property(e => e.IsPcroomChannel).HasColumnName("_isPcroomChannel");

				entity.Property(e => e.IsPremiumChannel).HasColumnName("_isPremiumChannel");

				entity.Property(e => e.IsSavageDefence).HasColumnName("_isSavageDefence");

				entity.Property(e => e.IsSeasonChannel).HasColumnName("_isSeasonChannel");

				entity.Property(e => e.IsSeasonNewbieChannel).HasColumnName("_isSeasonNewbieChannel");

				entity.Property(e => e.IsSequentialCheck).HasColumnName("_isSequentialCheck");

				entity.Property(e => e.IsSpareMachine).HasColumnName("_isSpareMachine");

				entity.Property(e => e.IsSpeedChannel).HasColumnName("_isSpeedChannel");

				entity.Property(e => e.IsSteamChannel).HasColumnName("_isSteamChannel");

				entity.Property(e => e.LogDsn)
					.HasMaxLength(100)
					.HasColumnName("_logDsn")
					.HasDefaultValueSql("('log1.dsn')");

				entity.Property(e => e.MacAddress)
					.HasMaxLength(32)
					.IsUnicode(false)
					.HasColumnName("_macAddress")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MainIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_mainIP")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PublicIp)
					.HasMaxLength(100)
					.IsUnicode(false)
					.HasColumnName("_publicIP")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.RegistDate)
					.HasColumnType("datetime")
					.HasColumnName("_registDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerGroupNo).HasColumnName("_serverGroupNo");

				entity.Property(e => e.ServerId)
					.HasMaxLength(50)
					.HasColumnName("_serverId");

				entity.Property(e => e.ServerName)
					.HasMaxLength(30)
					.HasColumnName("_serverName")
					.HasDefaultValueSql("(N'None')");

				entity.Property(e => e.ServerType)
					.HasColumnName("_serverType")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ServicePlatformType).HasColumnName("_servicePlatformType");

				entity.Property(e => e.StartNationSiege).HasColumnName("_startNationSiege");

				entity.Property(e => e.StartSiegeTerritory)
					.HasColumnName("_startSiegeTerritory")
					.HasDefaultValueSql("((-2))");

				entity.Property(e => e.WorldNo)
					.HasColumnName("_worldNo")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<TblXboxCashInfoWorld>(entity =>
			{
				entity.HasKey(e => new { e.AccountNo, e.LegacyProductId })
					.HasName("PkTblXboxCashInfoWorld")
					.IsClustered(false);

				entity.ToTable("TblXboxCashInfoWorld", "PaGamePrivate");

				entity.Property(e => e.AccountNo)
					.HasMaxLength(30)
					.HasColumnName("_accountNo");

				entity.Property(e => e.LegacyProductId)
					.HasMaxLength(40)
					.HasColumnName("_legacyProductId");

				entity.Property(e => e.ConsumeCount).HasColumnName("_consumeCount");

				entity.Property(e => e.ProductCount).HasColumnName("_productCount");

				entity.Property(e => e.PurchaseCountry)
					.HasMaxLength(10)
					.HasColumnName("_purchaseCountry")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblXboxCashProductAndItemMapping>(entity =>
			{
				entity.HasKey(e => e.LegacyProductId)
					.HasName("PkTblXboxCashProductAndItemMapping")
					.IsClustered(false);

				entity.ToTable("TblXboxCashProductAndItemMapping", "PaGamePrivate");

				entity.Property(e => e.LegacyProductId)
					.HasMaxLength(40)
					.HasColumnName("_legacyProductId");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.Description)
					.HasMaxLength(200)
					.HasColumnName("_description");

				entity.Property(e => e.IsBundleProduct).HasColumnName("_isBundleProduct");

				entity.Property(e => e.IsSingularItem).HasColumnName("_isSingularItem");

				entity.Property(e => e.NationType).HasColumnName("_nationType");

				entity.Property(e => e.ProductId)
					.HasMaxLength(40)
					.HasColumnName("_productId");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblXboxCashProductRefundInfo>(entity =>
			{
				entity.HasKey(e => e.RefundNo)
					.HasName("PkTblXboxCashProuctRefundInfo")
					.IsClustered(false);

				entity.ToTable("TblXboxCashProductRefundInfo", "PaGamePrivate");

				entity.Property(e => e.RefundNo).HasColumnName("_refundNo");

				entity.Property(e => e.AccountNo)
					.HasMaxLength(30)
					.HasColumnName("_accountNo");

				entity.Property(e => e.AfterConsumeCount).HasColumnName("_afterConsumeCount");

				entity.Property(e => e.AfterProductCount).HasColumnName("_afterProductCount");

				entity.Property(e => e.BeforeConsumeCount).HasColumnName("_beforeConsumeCount");

				entity.Property(e => e.BeforeProductCount).HasColumnName("_beforeProductCount");

				entity.Property(e => e.CancelDate)
					.HasColumnType("datetime")
					.HasColumnName("_cancelDate");

				entity.Property(e => e.CompleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_completeDate");

				entity.Property(e => e.IsCheckProductCount).HasColumnName("_isCheckProductCount");

				entity.Property(e => e.LegacyProductId)
					.HasMaxLength(40)
					.HasColumnName("_legacyProductId");

				entity.Property(e => e.ProductId)
					.HasMaxLength(40)
					.HasColumnName("_ProductId");

				entity.Property(e => e.RefundCount).HasColumnName("_refundCount");

				entity.Property(e => e.RefundState).HasColumnName("_refundState");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
