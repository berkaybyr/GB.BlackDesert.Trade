using Microsoft.EntityFrameworkCore;

namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class SA_BETA_GAMEDB_0002Context : DbContext
	{
		public SA_BETA_GAMEDB_0002Context()
		{
		}

		public SA_BETA_GAMEDB_0002Context(DbContextOptions<SA_BETA_GAMEDB_0002Context> options)
			: base(options)
		{
		}

		public virtual DbSet<DimGuildItemKey> DimGuildItemKeys { get; set; } = null!;
		public virtual DbSet<DimInstancefieldKey> DimInstancefieldKeys { get; set; } = null!;
		public virtual DbSet<DimItemKeyNeedContribute> DimItemKeyNeedContributes { get; set; } = null!;
		public virtual DbSet<DimItemOptionBlunt> DimItemOptionBlunts { get; set; } = null!;
		public virtual DbSet<DimItemOptionLongSword> DimItemOptionLongSwords { get; set; } = null!;
		public virtual DbSet<DimItemOptionTwoHandSword> DimItemOptionTwoHandSwords { get; set; } = null!;
		public virtual DbSet<DimMentalCardList> DimMentalCardLists { get; set; } = null!;
		public virtual DbSet<DimNodeNeedContribute> DimNodeNeedContributes { get; set; } = null!;
		public virtual DbSet<DimVariousNo> DimVariousNos { get; set; } = null!;
		public virtual DbSet<DimVariousNo1> DimVariousNos1 { get; set; } = null!;
		public virtual DbSet<DimWaypointKey> DimWaypointKeys { get; set; } = null!;
		public virtual DbSet<TabnormalPayloadBak> TabnormalPayloadBaks { get; set; } = null!;
		public virtual DbSet<TargetItem> TargetItems { get; set; } = null!;
		public virtual DbSet<TargetQuest> TargetQuests { get; set; } = null!;
		public virtual DbSet<TblAbsolutePower> TblAbsolutePowers { get; set; } = null!;
		public virtual DbSet<TblAbsolutePowerHistory> TblAbsolutePowerHistories { get; set; } = null!;
		public virtual DbSet<TblAcoinChargeNumbersByWeb> TblAcoinChargeNumbersByWebs { get; set; } = null!;
		public virtual DbSet<TblAddFriendList> TblAddFriendLists { get; set; } = null!;
		public virtual DbSet<TblAlchemyRecord> TblAlchemyRecords { get; set; } = null!;
		public virtual DbSet<TblAlchemyRecordNoOverlap> TblAlchemyRecordNoOverlaps { get; set; } = null!;
		public virtual DbSet<TblAltarOfBloodRank> TblAltarOfBloodRanks { get; set; } = null!;
		public virtual DbSet<TblAreaOfHadum> TblAreaOfHada { get; set; } = null!;
		public virtual DbSet<TblAttendPersonalBattle> TblAttendPersonalBattles { get; set; } = null!;
		public virtual DbSet<TblAttendance> TblAttendances { get; set; } = null!;
		public virtual DbSet<TblAuctionBidderVer2> TblAuctionBidderVer2s { get; set; } = null!;
		public virtual DbSet<TblAuctionBidderVer2GuildHouseBak> TblAuctionBidderVer2GuildHouseBaks { get; set; } = null!;
		public virtual DbSet<TblAuctionBuyGoodsVer2> TblAuctionBuyGoodsVer2s { get; set; } = null!;
		public virtual DbSet<TblAuctionGoodsVer2> TblAuctionGoodsVer2s { get; set; } = null!;
		public virtual DbSet<TblAuctionInfo> TblAuctionInfos { get; set; } = null!;
		public virtual DbSet<TblAutoChessDeck> TblAutoChessDecks { get; set; } = null!;
		public virtual DbSet<TblBadPlayerList> TblBadPlayerLists { get; set; } = null!;
		public virtual DbSet<TblBarterInfoList> TblBarterInfoLists { get; set; } = null!;
		public virtual DbSet<TblBarterUserInfo> TblBarterUserInfos { get; set; } = null!;
		public virtual DbSet<TblBattleHeroRanking> TblBattleHeroRankings { get; set; } = null!;
		public virtual DbSet<TblBattlePass> TblBattlePasses { get; set; } = null!;
		public virtual DbSet<TblBattleRoyaleItemsInfo> TblBattleRoyaleItemsInfos { get; set; } = null!;
		public virtual DbSet<TblBattleRoyalePlayTime> TblBattleRoyalePlayTimes { get; set; } = null!;
		public virtual DbSet<TblBattleRoyaleSmuggledItemsInfo> TblBattleRoyaleSmuggledItemsInfos { get; set; } = null!;
		public virtual DbSet<TblBattleRoyaleUserInfo> TblBattleRoyaleUserInfos { get; set; } = null!;
		public virtual DbSet<TblBattleRoyaleUserPlayTimeLog> TblBattleRoyaleUserPlayTimeLogs { get; set; } = null!;
		public virtual DbSet<TblBlackMarble> TblBlackMarbles { get; set; } = null!;
		public virtual DbSet<TblBlackSpiritAdventure> TblBlackSpiritAdventures { get; set; } = null!;
		public virtual DbSet<TblBlackSpiritAdventureItem> TblBlackSpiritAdventureItems { get; set; } = null!;
		public virtual DbSet<TblBlackSpiritAdventureMonster> TblBlackSpiritAdventureMonsters { get; set; } = null!;
		public virtual DbSet<TblBlackSpiritAdventureQuest> TblBlackSpiritAdventureQuests { get; set; } = null!;
		public virtual DbSet<TblBlackSpiritAdventureRegion> TblBlackSpiritAdventureRegions { get; set; } = null!;
		public virtual DbSet<TblBlackSpiritForm> TblBlackSpiritForms { get; set; } = null!;
		public virtual DbSet<TblBlockByKeyOrUserNo> TblBlockByKeyOrUserNos { get; set; } = null!;
		public virtual DbSet<TblBlockItem> TblBlockItems { get; set; } = null!;
		public virtual DbSet<TblBlockItemForTrade> TblBlockItemForTrades { get; set; } = null!;
		public virtual DbSet<TblBlockQuest> TblBlockQuests { get; set; } = null!;
		public virtual DbSet<TblBlockQuestLog> TblBlockQuestLogs { get; set; } = null!;
		public virtual DbSet<TblBlockUsingPointByUser> TblBlockUsingPointByUsers { get; set; } = null!;
		public virtual DbSet<TblBlockedChat> TblBlockedChats { get; set; } = null!;
		public virtual DbSet<TblBlockedItemLog> TblBlockedItemLogs { get; set; } = null!;
		public virtual DbSet<TblBossSpawn> TblBossSpawns { get; set; } = null!;
		public virtual DbSet<TblBranchQuest> TblBranchQuests { get; set; } = null!;
		public virtual DbSet<TblBriefUserInformation> TblBriefUserInformations { get; set; } = null!;
		public virtual DbSet<TblBuff> TblBuffs { get; set; } = null!;
		public virtual DbSet<TblBuffCount> TblBuffCounts { get; set; } = null!;
		public virtual DbSet<TblBuffExpirationDate> TblBuffExpirationDates { get; set; } = null!;
		public virtual DbSet<TblBusinessInstallation> TblBusinessInstallations { get; set; } = null!;
		public virtual DbSet<TblCacheSeq> TblCacheSeqs { get; set; } = null!;
		public virtual DbSet<TblCandidateList> TblCandidateLists { get; set; } = null!;
		public virtual DbSet<TblCaphrasBonusSlot> TblCaphrasBonusSlots { get; set; } = null!;
		public virtual DbSet<TblCashItemBuyCount> TblCashItemBuyCounts { get; set; } = null!;
		public virtual DbSet<TblCashItemBuyCountBak> TblCashItemBuyCountBaks { get; set; } = null!;
		public virtual DbSet<TblChallengeReward> TblChallengeRewards { get; set; } = null!;
		public virtual DbSet<TblChangeContentsOptionUser> TblChangeContentsOptionUsers { get; set; } = null!;
		public virtual DbSet<TblCharacterCustomizing> TblCharacterCustomizings { get; set; } = null!;
		public virtual DbSet<TblCharacterDetailInformation> TblCharacterDetailInformations { get; set; } = null!;
		public virtual DbSet<TblCharacterExpLoan> TblCharacterExpLoans { get; set; } = null!;
		public virtual DbSet<TblCharacterExpLoanLog> TblCharacterExpLoanLogs { get; set; } = null!;
		public virtual DbSet<TblCharacterInformation> TblCharacterInformations { get; set; } = null!;
		public virtual DbSet<TblCharacterLifeStat> TblCharacterLifeStats { get; set; } = null!;
		public virtual DbSet<TblCharacterMemo> TblCharacterMemos { get; set; } = null!;
		public virtual DbSet<TblCharacterNameModStr> TblCharacterNameModStrs { get; set; } = null!;
		public virtual DbSet<TblCharacterSpecialInformation> TblCharacterSpecialInformations { get; set; } = null!;
		public virtual DbSet<TblCharacterUicustomizing> TblCharacterUicustomizings { get; set; } = null!;
		public virtual DbSet<TblChatBlockByUser> TblChatBlockByUsers { get; set; } = null!;
		public virtual DbSet<TblChatBlockListByUser> TblChatBlockListByUsers { get; set; } = null!;
		public virtual DbSet<TblCheckItemForRemoveCharacter> TblCheckItemForRemoveCharacters { get; set; } = null!;
		public virtual DbSet<TblClearedBattlePass> TblClearedBattlePasses { get; set; } = null!;
		public virtual DbSet<TblClearedNewQuest> TblClearedNewQuests { get; set; } = null!;
		public virtual DbSet<TblClearedQuestList> TblClearedQuestLists { get; set; } = null!;
		public virtual DbSet<TblCommonBoardReport> TblCommonBoardReports { get; set; } = null!;
		public virtual DbSet<TblCommonContentsScoreRecord> TblCommonContentsScoreRecords { get; set; } = null!;
		public virtual DbSet<TblCommonSkillNo> TblCommonSkillNos { get; set; } = null!;
		public virtual DbSet<TblCompletedChallenge> TblCompletedChallenges { get; set; } = null!;
		public virtual DbSet<TblCompletedGuildBattle> TblCompletedGuildBattles { get; set; } = null!;
		public virtual DbSet<TblCompletedGuildDuel> TblCompletedGuildDuels { get; set; } = null!;
		public virtual DbSet<TblCompletedPersonalBattle> TblCompletedPersonalBattles { get; set; } = null!;
		public virtual DbSet<TblCompositionNote> TblCompositionNotes { get; set; } = null!;
		public virtual DbSet<TblCompositionNotesCount> TblCompositionNotesCounts { get; set; } = null!;
		public virtual DbSet<TblCompositionNotesReply> TblCompositionNotesReplies { get; set; } = null!;
		public virtual DbSet<TblConsignmentSale> TblConsignmentSales { get; set; } = null!;
		public virtual DbSet<TblContentsSeason> TblContentsSeasons { get; set; } = null!;
		public virtual DbSet<TblCoolTime> TblCoolTimes { get; set; } = null!;
		public virtual DbSet<TblCopyUserDate> TblCopyUserDates { get; set; } = null!;
		public virtual DbSet<TblCoupon> TblCoupons { get; set; } = null!;
		public virtual DbSet<TblCouponTargetUser> TblCouponTargetUsers { get; set; } = null!;
		public virtual DbSet<TblCrew> TblCrews { get; set; } = null!;
		public virtual DbSet<TblCrewMember> TblCrewMembers { get; set; } = null!;
		public virtual DbSet<TblCustomGuildWarHistory> TblCustomGuildWarHistories { get; set; } = null!;
		public virtual DbSet<TblCustomName> TblCustomNames { get; set; } = null!;
		public virtual DbSet<TblCustomizedKey> TblCustomizedKeys { get; set; } = null!;
		public virtual DbSet<TblCustomizingDownloadLog> TblCustomizingDownloadLogs { get; set; } = null!;
		public virtual DbSet<TblCustomizingGallery> TblCustomizingGalleries { get; set; } = null!;
		public virtual DbSet<TblCustomizingGalleryAuthRank> TblCustomizingGalleryAuthRanks { get; set; } = null!;
		public virtual DbSet<TblCustomizingGalleryAuthRankSnap> TblCustomizingGalleryAuthRankSnaps { get; set; } = null!;
		public virtual DbSet<TblCustomizingGalleryAuthRankTemp> TblCustomizingGalleryAuthRankTemps { get; set; } = null!;
		public virtual DbSet<TblCustomizingGalleryBlind> TblCustomizingGalleryBlinds { get; set; } = null!;
		public virtual DbSet<TblCustomizingGalleryComment> TblCustomizingGalleryComments { get; set; } = null!;
		public virtual DbSet<TblCustomizingLikeLog> TblCustomizingLikeLogs { get; set; } = null!;
		public virtual DbSet<TblCustomizingReportLog> TblCustomizingReportLogs { get; set; } = null!;
		public virtual DbSet<TblDailyBattlePassPoint> TblDailyBattlePassPoints { get; set; } = null!;
		public virtual DbSet<TblDailyPlayInfo> TblDailyPlayInfos { get; set; } = null!;
		public virtual DbSet<TblDeletedCharacterInformation> TblDeletedCharacterInformations { get; set; } = null!;
		public virtual DbSet<TblDeletedItemRepository> TblDeletedItemRepositories { get; set; } = null!;
		public virtual DbSet<TblDeletedNameExchange> TblDeletedNameExchanges { get; set; } = null!;
		public virtual DbSet<TblDeletedPet> TblDeletedPets { get; set; } = null!;
		public virtual DbSet<TblDeliveryRepository> TblDeliveryRepositories { get; set; } = null!;
		public virtual DbSet<TblDuelCharacterInfo> TblDuelCharacterInfos { get; set; } = null!;
		public virtual DbSet<TblEmoticon> TblEmoticons { get; set; } = null!;
		public virtual DbSet<TblEmployeeRepository> TblEmployeeRepositories { get; set; } = null!;
		public virtual DbSet<TblEmployeeSpawnInformation> TblEmployeeSpawnInformations { get; set; } = null!;
		public virtual DbSet<TblEncyclopedium> TblEncyclopedia { get; set; } = null!;
		public virtual DbSet<TblEventBuff> TblEventBuffs { get; set; } = null!;
		public virtual DbSet<TblEventMarbleGame> TblEventMarbleGames { get; set; } = null!;
		public virtual DbSet<TblEventMarbleGameDiceItem> TblEventMarbleGameDiceItems { get; set; } = null!;
		public virtual DbSet<TblEventMarbleGameMap> TblEventMarbleGameMaps { get; set; } = null!;
		public virtual DbSet<TblExcaliburUserInfo> TblExcaliburUserInfos { get; set; } = null!;
		public virtual DbSet<TblExpeditionResultItem> TblExpeditionResultItems { get; set; } = null!;
		public virtual DbSet<TblExpeditionaryUnit> TblExpeditionaryUnits { get; set; } = null!;
		public virtual DbSet<TblExplorationPoint> TblExplorationPoints { get; set; } = null!;
		public virtual DbSet<TblExtendSlotRepository> TblExtendSlotRepositories { get; set; } = null!;
		public virtual DbSet<TblFairyLook> TblFairyLooks { get; set; } = null!;
		public virtual DbSet<TblFameCoolTime> TblFameCoolTimes { get; set; } = null!;
		public virtual DbSet<TblFameInfo> TblFameInfos { get; set; } = null!;
		public virtual DbSet<TblFamePreSeasonRank> TblFamePreSeasonRanks { get; set; } = null!;
		public virtual DbSet<TblFameSeasonRank> TblFameSeasonRanks { get; set; } = null!;
		public virtual DbSet<TblFameSeasonRankNew> TblFameSeasonRankNews { get; set; } = null!;
		public virtual DbSet<TblFameTotalRank> TblFameTotalRanks { get; set; } = null!;
		public virtual DbSet<TblFameTotalRankNew> TblFameTotalRankNews { get; set; } = null!;
		public virtual DbSet<TblFamilySkill> TblFamilySkills { get; set; } = null!;
		public virtual DbSet<TblFamilySkillPoint> TblFamilySkillPoints { get; set; } = null!;
		public virtual DbSet<TblFamilySpecialInformation> TblFamilySpecialInformations { get; set; } = null!;
		public virtual DbSet<TblFeverPoint> TblFeverPoints { get; set; } = null!;
		public virtual DbSet<TblFindHiddenRecipe> TblFindHiddenRecipes { get; set; } = null!;
		public virtual DbSet<TblFishTopRanking> TblFishTopRankings { get; set; } = null!;
		public virtual DbSet<TblFitnessExperience> TblFitnessExperiences { get; set; } = null!;
		public virtual DbSet<TblFixedBusinessInformation> TblFixedBusinessInformations { get; set; } = null!;
		public virtual DbSet<TblFixedConsignmentSale> TblFixedConsignmentSales { get; set; } = null!;
		public virtual DbSet<TblFixedVendingMachine> TblFixedVendingMachines { get; set; } = null!;
		public virtual DbSet<TblFriend> TblFriends { get; set; } = null!;
		public virtual DbSet<TblFriendGroup> TblFriendGroups { get; set; } = null!;
		public virtual DbSet<TblFuelInsertCharacterInfo> TblFuelInsertCharacterInfos { get; set; } = null!;
		public virtual DbSet<TblFuelInsertCharacterSettingInfo> TblFuelInsertCharacterSettingInfos { get; set; } = null!;
		public virtual DbSet<TblFuelInsertInfo> TblFuelInsertInfos { get; set; } = null!;
		public virtual DbSet<TblGeneralRepository> TblGeneralRepositories { get; set; } = null!;
		public virtual DbSet<TblGetGuildGiveawayUser> TblGetGuildGiveawayUsers { get; set; } = null!;
		public virtual DbSet<TblGreatSeaRepository> TblGreatSeaRepositories { get; set; } = null!;
		public virtual DbSet<TblGrowStep> TblGrowSteps { get; set; } = null!;
		public virtual DbSet<TblGrowthPassCategoryReward> TblGrowthPassCategoryRewards { get; set; } = null!;
		public virtual DbSet<TblGrowthPassTotalReward> TblGrowthPassTotalRewards { get; set; } = null!;
		public virtual DbSet<TblGuild> TblGuilds { get; set; } = null!;
		public virtual DbSet<TblGuildAlliance> TblGuildAlliances { get; set; } = null!;
		public virtual DbSet<TblGuildAllianceInformation> TblGuildAllianceInformations { get; set; } = null!;
		public virtual DbSet<TblGuildApplicant> TblGuildApplicants { get; set; } = null!;
		public virtual DbSet<TblGuildBattleRanking> TblGuildBattleRankings { get; set; } = null!;
		public virtual DbSet<TblGuildBoard> TblGuildBoards { get; set; } = null!;
		public virtual DbSet<TblGuildCapital> TblGuildCapitals { get; set; } = null!;
		public virtual DbSet<TblGuildComment> TblGuildComments { get; set; } = null!;
		public virtual DbSet<TblGuildGathering> TblGuildGatherings { get; set; } = null!;
		public virtual DbSet<TblGuildGiveaway> TblGuildGiveaways { get; set; } = null!;
		public virtual DbSet<TblGuildHouseLargeCraft> TblGuildHouseLargeCrafts { get; set; } = null!;
		public virtual DbSet<TblGuildHouseLargeCraftDailyCount> TblGuildHouseLargeCraftDailyCounts { get; set; } = null!;
		public virtual DbSet<TblGuildInformation> TblGuildInformations { get; set; } = null!;
		public virtual DbSet<TblGuildInformationComment> TblGuildInformationComments { get; set; } = null!;
		public virtual DbSet<TblGuildInformationCommentBlock> TblGuildInformationCommentBlocks { get; set; } = null!;
		public virtual DbSet<TblGuildJournal> TblGuildJournals { get; set; } = null!;
		public virtual DbSet<TblGuildLifeRankingInfo> TblGuildLifeRankingInfos { get; set; } = null!;
		public virtual DbSet<TblGuildManufacture> TblGuildManufactures { get; set; } = null!;
		public virtual DbSet<TblGuildManufactureDailyCount> TblGuildManufactureDailyCounts { get; set; } = null!;
		public virtual DbSet<TblGuildMember> TblGuildMembers { get; set; } = null!;
		public virtual DbSet<TblGuildPendingReward> TblGuildPendingRewards { get; set; } = null!;
		public virtual DbSet<TblGuildPendingRewardLog> TblGuildPendingRewardLogs { get; set; } = null!;
		public virtual DbSet<TblGuildPendingRewardUser> TblGuildPendingRewardUsers { get; set; } = null!;
		public virtual DbSet<TblGuildPoint> TblGuildPoints { get; set; } = null!;
		public virtual DbSet<TblGuildPr> TblGuildPrs { get; set; } = null!;
		public virtual DbSet<TblGuildQuestList> TblGuildQuestLists { get; set; } = null!;
		public virtual DbSet<TblGuildRankingInfo> TblGuildRankingInfos { get; set; } = null!;
		public virtual DbSet<TblGuildRecommend> TblGuildRecommends { get; set; } = null!;
		public virtual DbSet<TblGuildSkill> TblGuildSkills { get; set; } = null!;
		public virtual DbSet<TblGuildSkillCoolTime> TblGuildSkillCoolTimes { get; set; } = null!;
		public virtual DbSet<TblGuildVolunteerMember> TblGuildVolunteerMembers { get; set; } = null!;
		public virtual DbSet<TblGuildWar> TblGuildWars { get; set; } = null!;
		public virtual DbSet<TblGuildWarHistory> TblGuildWarHistories { get; set; } = null!;
		public virtual DbSet<TblGuildWareHouseHistory> TblGuildWareHouseHistories { get; set; } = null!;
		public virtual DbSet<TblHarvestInstallation> TblHarvestInstallations { get; set; } = null!;
		public virtual DbSet<TblHiddenDrop> TblHiddenDrops { get; set; } = null!;
		public virtual DbSet<TblHorseRacingPreRecordRank> TblHorseRacingPreRecordRanks { get; set; } = null!;
		public virtual DbSet<TblHorseRacingPreTotalRank> TblHorseRacingPreTotalRanks { get; set; } = null!;
		public virtual DbSet<TblHorseRacingRank> TblHorseRacingRanks { get; set; } = null!;
		public virtual DbSet<TblHorseRacingRecordRank> TblHorseRacingRecordRanks { get; set; } = null!;
		public virtual DbSet<TblHorseRacingRecordRankNew> TblHorseRacingRecordRankNews { get; set; } = null!;
		public virtual DbSet<TblHorseRacingTotalRank> TblHorseRacingTotalRanks { get; set; } = null!;
		public virtual DbSet<TblHorseRacingTotalRankNew> TblHorseRacingTotalRankNews { get; set; } = null!;
		public virtual DbSet<TblHouseLargeCraft> TblHouseLargeCrafts { get; set; } = null!;
		public virtual DbSet<TblHouseListForTownManagement> TblHouseListForTownManagements { get; set; } = null!;
		public virtual DbSet<TblHouseholdFixed> TblHouseholdFixeds { get; set; } = null!;
		public virtual DbSet<TblHouseholdSpec> TblHouseholdSpecs { get; set; } = null!;
		public virtual DbSet<TblHouseholdTent> TblHouseholdTents { get; set; } = null!;
		public virtual DbSet<TblInstallation> TblInstallations { get; set; } = null!;
		public virtual DbSet<TblInstallationTempRealItemList> TblInstallationTempRealItemLists { get; set; } = null!;
		public virtual DbSet<TblInstallationTempVirtualItemList> TblInstallationTempVirtualItemLists { get; set; } = null!;
		public virtual DbSet<TblInstalledInstanceObject> TblInstalledInstanceObjects { get; set; } = null!;
		public virtual DbSet<TblInstanceContentReward> TblInstanceContentRewards { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldCurruetServerNo> TblInstanceFieldCurruetServerNos { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldCustomRoomOption> TblInstanceFieldCustomRoomOptions { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldMatching> TblInstanceFieldMatchings { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldNormalDatum> TblInstanceFieldNormalData { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldOnlineUserRanking> TblInstanceFieldOnlineUserRankings { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldOnlineUserRankingNew> TblInstanceFieldOnlineUserRankingNews { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldRankDatum> TblInstanceFieldRankData { get; set; } = null!;
		public virtual DbSet<TblInstanceFieldReadyUser> TblInstanceFieldReadyUsers { get; set; } = null!;
		public virtual DbSet<TblInstrumentInfo> TblInstrumentInfos { get; set; } = null!;
		public virtual DbSet<TblInvestGuildPointInformation> TblInvestGuildPointInformations { get; set; } = null!;
		public virtual DbSet<TblItemCollectionScroll> TblItemCollectionScrolls { get; set; } = null!;
		public virtual DbSet<TblItemDeliverer> TblItemDeliverers { get; set; } = null!;
		public virtual DbSet<TblItemMarketMaster> TblItemMarketMasters { get; set; } = null!;
		public virtual DbSet<TblItemMarketReservation> TblItemMarketReservations { get; set; } = null!;
		public virtual DbSet<TblItemMarketSell> TblItemMarketSells { get; set; } = null!;
		public virtual DbSet<TblItemMarketSellByParty> TblItemMarketSellByParties { get; set; } = null!;
		public virtual DbSet<TblItemMarketSellByReservation> TblItemMarketSellByReservations { get; set; } = null!;
		public virtual DbSet<TblItemNaming> TblItemNamings { get; set; } = null!;
		public virtual DbSet<TblItemOptionRepository> TblItemOptionRepositories { get; set; } = null!;
		public virtual DbSet<TblItemRental> TblItemRentals { get; set; } = null!;
		public virtual DbSet<TblItemRepository> TblItemRepositories { get; set; } = null!;
		public virtual DbSet<TblItemRepositoryGuildMoneyBak> TblItemRepositoryGuildMoneyBaks { get; set; } = null!;
		public virtual DbSet<TblItemRestoreWaiting> TblItemRestoreWaitings { get; set; } = null!;
		public virtual DbSet<TblItemToInventoryRequest> TblItemToInventoryRequests { get; set; } = null!;
		public virtual DbSet<TblItemToWarehouseRequest> TblItemToWarehouseRequests { get; set; } = null!;
		public virtual DbSet<TblJournal> TblJournals { get; set; } = null!;
		public virtual DbSet<TblLeaveBriefUserInformation> TblLeaveBriefUserInformations { get; set; } = null!;
		public virtual DbSet<TblLeaveLog> TblLeaveLogs { get; set; } = null!;
		public virtual DbSet<TblLifeExperience> TblLifeExperiences { get; set; } = null!;
		public virtual DbSet<TblLimitedCashProduct> TblLimitedCashProducts { get; set; } = null!;
		public virtual DbSet<TblLogoutPlayerWorking> TblLogoutPlayerWorkings { get; set; } = null!;
		public virtual DbSet<TblLoverList> TblLoverLists { get; set; } = null!;
		public virtual DbSet<TblMacroKeyInputCheckLog> TblMacroKeyInputCheckLogs { get; set; } = null!;
		public virtual DbSet<TblMaid> TblMaids { get; set; } = null!;
		public virtual DbSet<TblMail> TblMails { get; set; } = null!;
		public virtual DbSet<TblMailItemWhiteList> TblMailItemWhiteLists { get; set; } = null!;
		public virtual DbSet<TblMailPs4sub> TblMailPs4subs { get; set; } = null!;
		public virtual DbSet<TblMailWaitingQueue> TblMailWaitingQueues { get; set; } = null!;
		public virtual DbSet<TblMainQuestGroupInfo> TblMainQuestGroupInfos { get; set; } = null!;
		public virtual DbSet<TblMansionListForTownManagement> TblMansionListForTownManagements { get; set; } = null!;
		public virtual DbSet<TblMarbleGame> TblMarbleGames { get; set; } = null!;
		public virtual DbSet<TblMarbleGameCard> TblMarbleGameCards { get; set; } = null!;
		public virtual DbSet<TblMarbleGameDiceItem> TblMarbleGameDiceItems { get; set; } = null!;
		public virtual DbSet<TblMarbleGameMap> TblMarbleGameMaps { get; set; } = null!;
		public virtual DbSet<TblMassMail> TblMassMails { get; set; } = null!;
		public virtual DbSet<TblMassMailInfo> TblMassMailInfos { get; set; } = null!;
		public virtual DbSet<TblMassMailRequest> TblMassMailRequests { get; set; } = null!;
		public virtual DbSet<TblMassMailUserInfo> TblMassMailUserInfos { get; set; } = null!;
		public virtual DbSet<TblMassPlayerTitleRequest> TblMassPlayerTitleRequests { get; set; } = null!;
		public virtual DbSet<TblMasterySkillInfo> TblMasterySkillInfos { get; set; } = null!;
		public virtual DbSet<TblMentalCardList> TblMentalCardLists { get; set; } = null!;
		public virtual DbSet<TblMessengerInfo> TblMessengerInfos { get; set; } = null!;
		public virtual DbSet<TblMessengerMessage> TblMessengerMessages { get; set; } = null!;
		public virtual DbSet<TblMilitiaMember> TblMilitiaMembers { get; set; } = null!;
		public virtual DbSet<TblMiniGameUserInformation> TblMiniGameUserInformations { get; set; } = null!;
		public virtual DbSet<TblMusicLevelInfo> TblMusicLevelInfos { get; set; } = null!;
		public virtual DbSet<TblMusicScore> TblMusicScores { get; set; } = null!;
		public virtual DbSet<TblNameChange> TblNameChanges { get; set; } = null!;
		public virtual DbSet<TblNameChangeComplete> TblNameChangeCompletes { get; set; } = null!;
		public virtual DbSet<TblNameExchange> TblNameExchanges { get; set; } = null!;
		public virtual DbSet<TblNameExchangeComplete> TblNameExchangeCompletes { get; set; } = null!;
		public virtual DbSet<TblNewDeliveryRepository> TblNewDeliveryRepositories { get; set; } = null!;
		public virtual DbSet<TblNpcProposeDialog> TblNpcProposeDialogs { get; set; } = null!;
		public virtual DbSet<TblNpcShopItemBuyCount> TblNpcShopItemBuyCounts { get; set; } = null!;
		public virtual DbSet<TblOperationReport> TblOperationReports { get; set; } = null!;
		public virtual DbSet<TblPalette> TblPalettes { get; set; } = null!;
		public virtual DbSet<TblParty> TblParties { get; set; } = null!;
		public virtual DbSet<TblPartyMatching> TblPartyMatchings { get; set; } = null!;
		public virtual DbSet<TblPartyMatchingMember> TblPartyMatchingMembers { get; set; } = null!;
		public virtual DbSet<TblPcWorking> TblPcWorkings { get; set; } = null!;
		public virtual DbSet<TblPearlCashProductList> TblPearlCashProductLists { get; set; } = null!;
		public virtual DbSet<TblPearlInventoryDeletedItemRestoreLog> TblPearlInventoryDeletedItemRestoreLogs { get; set; } = null!;
		public virtual DbSet<TblPearlItemList> TblPearlItemLists { get; set; } = null!;
		public virtual DbSet<TblPearlUsedAmount> TblPearlUsedAmounts { get; set; } = null!;
		public virtual DbSet<TblPearlUsedChallengeResetCount> TblPearlUsedChallengeResetCounts { get; set; } = null!;
		public virtual DbSet<TblPearlUsedLastMonthAmount> TblPearlUsedLastMonthAmounts { get; set; } = null!;
		public virtual DbSet<TblPenaltyEscape> TblPenaltyEscapes { get; set; } = null!;
		public virtual DbSet<TblPendingReward> TblPendingRewards { get; set; } = null!;
		public virtual DbSet<TblPendingRewardLog> TblPendingRewardLogs { get; set; } = null!;
		public virtual DbSet<TblPersonalBattleRanking> TblPersonalBattleRankings { get; set; } = null!;
		public virtual DbSet<TblPersonalDuelRanking> TblPersonalDuelRankings { get; set; } = null!;
		public virtual DbSet<TblPersonalMonsterInformation> TblPersonalMonsterInformations { get; set; } = null!;
		public virtual DbSet<TblPersonalMonsterUserInfo> TblPersonalMonsterUserInfos { get; set; } = null!;
		public virtual DbSet<TblPet> TblPets { get; set; } = null!;
		public virtual DbSet<TblPlantRepository> TblPlantRepositories { get; set; } = null!;
		public virtual DbSet<TblPlayerTitle> TblPlayerTitles { get; set; } = null!;
		public virtual DbSet<TblPostBoxTemplate> TblPostBoxTemplates { get; set; } = null!;
		public virtual DbSet<TblPriorityGuildPr> TblPriorityGuildPrs { get; set; } = null!;
		public virtual DbSet<TblPrizeLottery> TblPrizeLotteries { get; set; } = null!;
		public virtual DbSet<TblProgressChallenge> TblProgressChallenges { get; set; } = null!;
		public virtual DbSet<TblProgressExpedition> TblProgressExpeditions { get; set; } = null!;
		public virtual DbSet<TblProgressingGuildDuel> TblProgressingGuildDuels { get; set; } = null!;
		public virtual DbSet<TblProgressingNewQuest> TblProgressingNewQuests { get; set; } = null!;
		public virtual DbSet<TblProposeList> TblProposeLists { get; set; } = null!;
		public virtual DbSet<TblPs4cashInfoLog> TblPs4cashInfoLogs { get; set; } = null!;
		public virtual DbSet<TblPurchasedClassType> TblPurchasedClassTypes { get; set; } = null!;
		public virtual DbSet<TblPurchasedSkin> TblPurchasedSkins { get; set; } = null!;
		public virtual DbSet<TblQuizEventUserInfo> TblQuizEventUserInfos { get; set; } = null!;
		public virtual DbSet<TblRandomPartyMatching> TblRandomPartyMatchings { get; set; } = null!;
		public virtual DbSet<TblRecordGuildVolunteerScore> TblRecordGuildVolunteerScores { get; set; } = null!;
		public virtual DbSet<TblRegionGroup> TblRegionGroups { get; set; } = null!;
		public virtual DbSet<TblRentInstanceField> TblRentInstanceFields { get; set; } = null!;
		public virtual DbSet<TblRentInstanceFieldPass> TblRentInstanceFieldPasses { get; set; } = null!;
		public virtual DbSet<TblRequestGuildInviteList> TblRequestGuildInviteLists { get; set; } = null!;
		public virtual DbSet<TblReservationArsha> TblReservationArshas { get; set; } = null!;
		public virtual DbSet<TblRestoreItemRepository> TblRestoreItemRepositories { get; set; } = null!;
		public virtual DbSet<TblRestoreItemUserInfo> TblRestoreItemUserInfos { get; set; } = null!;
		public virtual DbSet<TblRestoreServantList> TblRestoreServantLists { get; set; } = null!;
		public virtual DbSet<TblReturnStone> TblReturnStones { get; set; } = null!;
		public virtual DbSet<TblScreenShot> TblScreenShots { get; set; } = null!;
		public virtual DbSet<TblScreenShotBlind> TblScreenShotBlinds { get; set; } = null!;
		public virtual DbSet<TblScreenShotComment> TblScreenShotComments { get; set; } = null!;
		public virtual DbSet<TblScreenShotCommentReport> TblScreenShotCommentReports { get; set; } = null!;
		public virtual DbSet<TblScreenShotLikeLog> TblScreenShotLikeLogs { get; set; } = null!;
		public virtual DbSet<TblSeasonChangeLog> TblSeasonChangeLogs { get; set; } = null!;
		public virtual DbSet<TblSeasonCharacter> TblSeasonCharacters { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseChallenge> TblSeasonCloseChallenges { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseChallengeInfo> TblSeasonCloseChallengeInfos { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseChallengeWithReward> TblSeasonCloseChallengeWithRewards { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseChangeItem> TblSeasonCloseChangeItems { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseCharacterType> TblSeasonCloseCharacterTypes { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseDeleteItem> TblSeasonCloseDeleteItems { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseItemInfo> TblSeasonCloseItemInfos { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseQuest> TblSeasonCloseQuests { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseQuestInfo> TblSeasonCloseQuestInfos { get; set; } = null!;
		public virtual DbSet<TblSeasonCloseQuestWithReward> TblSeasonCloseQuestWithRewards { get; set; } = null!;
		public virtual DbSet<TblSeasonInfo> TblSeasonInfos { get; set; } = null!;
		public virtual DbSet<TblSeasonParam> TblSeasonParams { get; set; } = null!;
		public virtual DbSet<TblSeasonResetMail> TblSeasonResetMails { get; set; } = null!;
		public virtual DbSet<TblSeasonReward> TblSeasonRewards { get; set; } = null!;
		public virtual DbSet<TblServantMating> TblServantMatings { get; set; } = null!;
		public virtual DbSet<TblServantRepository> TblServantRepositories { get; set; } = null!;
		public virtual DbSet<TblServantStallionSkillInfo> TblServantStallionSkillInfos { get; set; } = null!;
		public virtual DbSet<TblServantTierInfo> TblServantTierInfos { get; set; } = null!;
		public virtual DbSet<TblShaBriefUserInfoNewTagTargetUser> TblShaBriefUserInfoNewTagTargetUsers { get; set; } = null!;
		public virtual DbSet<TblShaFreeClassType> TblShaFreeClassTypes { get; set; } = null!;
		public virtual DbSet<TblShadowArenaAbusingUser> TblShadowArenaAbusingUsers { get; set; } = null!;
		public virtual DbSet<TblShadowArenaAttendance> TblShadowArenaAttendances { get; set; } = null!;
		public virtual DbSet<TblShadowArenaAttendanceOption> TblShadowArenaAttendanceOptions { get; set; } = null!;
		public virtual DbSet<TblShadowArenaBriefUserInformation> TblShadowArenaBriefUserInformations { get; set; } = null!;
		public virtual DbSet<TblShadowArenaCharacter> TblShadowArenaCharacters { get; set; } = null!;
		public virtual DbSet<TblShadowArenaClanApplicant> TblShadowArenaClanApplicants { get; set; } = null!;
		public virtual DbSet<TblShadowArenaClanAssembleFlag> TblShadowArenaClanAssembleFlags { get; set; } = null!;
		public virtual DbSet<TblShadowArenaClanChat> TblShadowArenaClanChats { get; set; } = null!;
		public virtual DbSet<TblShadowArenaDodgePanelty> TblShadowArenaDodgePanelties { get; set; } = null!;
		public virtual DbSet<TblShadowArenaFriendChat> TblShadowArenaFriendChats { get; set; } = null!;
		public virtual DbSet<TblShadowArenaLastBattleResultInfo> TblShadowArenaLastBattleResultInfos { get; set; } = null!;
		public virtual DbSet<TblShadowArenaOption> TblShadowArenaOptions { get; set; } = null!;
		public virtual DbSet<TblShadowArenaPurchasedProfileIcon> TblShadowArenaPurchasedProfileIcons { get; set; } = null!;
		public virtual DbSet<TblShadowArenaRestrictMode> TblShadowArenaRestrictModes { get; set; } = null!;
		public virtual DbSet<TblShadowArenaShopPreset> TblShadowArenaShopPresets { get; set; } = null!;
		public virtual DbSet<TblShadowArenaSkillAwakenList> TblShadowArenaSkillAwakenLists { get; set; } = null!;
		public virtual DbSet<TblShadowArenaSkillAwakenSelect> TblShadowArenaSkillAwakenSelects { get; set; } = null!;
		public virtual DbSet<TblShadowArenaSkillStone> TblShadowArenaSkillStones { get; set; } = null!;
		public virtual DbSet<TblShadowArenaSkinDyingInfo> TblShadowArenaSkinDyingInfos { get; set; } = null!;
		public virtual DbSet<TblShadowArenaUserTitle> TblShadowArenaUserTitles { get; set; } = null!;
		public virtual DbSet<TblSiege> TblSieges { get; set; } = null!;
		public virtual DbSet<TblSiegeBuildingHistory> TblSiegeBuildingHistories { get; set; } = null!;
		public virtual DbSet<TblSiegeColor> TblSiegeColors { get; set; } = null!;
		public virtual DbSet<TblSiegeHistory> TblSiegeHistories { get; set; } = null!;
		public virtual DbSet<TblSiegeScore> TblSiegeScores { get; set; } = null!;
		public virtual DbSet<TblSiegeSecondRoundScore> TblSiegeSecondRoundScores { get; set; } = null!;
		public virtual DbSet<TblSiegeTaxTime> TblSiegeTaxTimes { get; set; } = null!;
		public virtual DbSet<TblSiegeVote> TblSiegeVotes { get; set; } = null!;
		public virtual DbSet<TblSimpleGuildInviteList> TblSimpleGuildInviteLists { get; set; } = null!;
		public virtual DbSet<TblSkill> TblSkills { get; set; } = null!;
		public virtual DbSet<TblSkillAwakeningVersion2> TblSkillAwakeningVersion2s { get; set; } = null!;
		public virtual DbSet<TblSkillPreset> TblSkillPresets { get; set; } = null!;
		public virtual DbSet<TblSkillPresetLastUpdateTime> TblSkillPresetLastUpdateTimes { get; set; } = null!;
		public virtual DbSet<TblSkillPresetSlot> TblSkillPresetSlots { get; set; } = null!;
		public virtual DbSet<TblStatementTemp> TblStatementTemps { get; set; } = null!;
		public virtual DbSet<TblStockMarketBuy> TblStockMarketBuys { get; set; } = null!;
		public virtual DbSet<TblStockMarketSell> TblStockMarketSells { get; set; } = null!;
		public virtual DbSet<TblSupplyCount> TblSupplyCounts { get; set; } = null!;
		public virtual DbSet<TblSupportPoint> TblSupportPoints { get; set; } = null!;
		public virtual DbSet<TblSyncGuildInformation> TblSyncGuildInformations { get; set; } = null!;
		public virtual DbSet<TblSyncGuildInformationSnap> TblSyncGuildInformationSnaps { get; set; } = null!;
		public virtual DbSet<TblSyncGuildInformationTran> TblSyncGuildInformationTrans { get; set; } = null!;
		public virtual DbSet<TblSyncLifeExperience> TblSyncLifeExperiences { get; set; } = null!;
		public virtual DbSet<TblSyncLifeExperienceSnap> TblSyncLifeExperienceSnaps { get; set; } = null!;
		public virtual DbSet<TblSyncLifeExperienceTran> TblSyncLifeExperienceTrans { get; set; } = null!;
		public virtual DbSet<TblSyncWebUserInformation> TblSyncWebUserInformations { get; set; } = null!;
		public virtual DbSet<TblSyncWebUserInformationSnap> TblSyncWebUserInformationSnaps { get; set; } = null!;
		public virtual DbSet<TblSyncWebUserInformationTran> TblSyncWebUserInformationTrans { get; set; } = null!;
		public virtual DbSet<TblTax> TblTaxes { get; set; } = null!;
		public virtual DbSet<TblTeleportableUser> TblTeleportableUsers { get; set; } = null!;
		public virtual DbSet<TblTeleportationPoint> TblTeleportationPoints { get; set; } = null!;
		public virtual DbSet<TblTerritoryTradeAuthority> TblTerritoryTradeAuthorities { get; set; } = null!;
		public virtual DbSet<TblTerritoryTradeItem> TblTerritoryTradeItems { get; set; } = null!;
		public virtual DbSet<TblThumbsUpCountInformation> TblThumbsUpCountInformations { get; set; } = null!;
		public virtual DbSet<TblThumbsUpInformation> TblThumbsUpInformations { get; set; } = null!;
		public virtual DbSet<TblTimeAttackRanking> TblTimeAttackRankings { get; set; } = null!;
		public virtual DbSet<TblTradeCompany> TblTradeCompanies { get; set; } = null!;
		public virtual DbSet<TblTradeCompanyLog> TblTradeCompanyLogs { get; set; } = null!;
		public virtual DbSet<TblTradeCompanyObtainItem> TblTradeCompanyObtainItems { get; set; } = null!;
		public virtual DbSet<TblTradeGroupList> TblTradeGroupLists { get; set; } = null!;
		public virtual DbSet<TblTroller> TblTrollers { get; set; } = null!;
		public virtual DbSet<TblTutorial> TblTutorials { get; set; } = null!;
		public virtual DbSet<TblTutorialCharacterInfo> TblTutorialCharacterInfos { get; set; } = null!;
		public virtual DbSet<TblUserEnchantStackInfo> TblUserEnchantStackInfos { get; set; } = null!;
		public virtual DbSet<TblUserEnchantStackSlot> TblUserEnchantStackSlots { get; set; } = null!;
		public virtual DbSet<TblUserGameOptionType> TblUserGameOptionTypes { get; set; } = null!;
		public virtual DbSet<TblUserItemLoan> TblUserItemLoans { get; set; } = null!;
		public virtual DbSet<TblUserItemLoanLog> TblUserItemLoanLogs { get; set; } = null!;
		public virtual DbSet<TblUserLanguage> TblUserLanguages { get; set; } = null!;
		public virtual DbSet<TblUserNpcCustomizing> TblUserNpcCustomizings { get; set; } = null!;
		public virtual DbSet<TblUserPlayTimeLog> TblUserPlayTimeLogs { get; set; } = null!;
		public virtual DbSet<TblUserProfileInfo> TblUserProfileInfos { get; set; } = null!;
		public virtual DbSet<TblUserSeasonState> TblUserSeasonStates { get; set; } = null!;
		public virtual DbSet<TblUserSocialActionConfig> TblUserSocialActionConfigs { get; set; } = null!;
		public virtual DbSet<TblUserUsePearlForCashProduct> TblUserUsePearlForCashProducts { get; set; } = null!;
		public virtual DbSet<TblUsingHiredNpc> TblUsingHiredNpcs { get; set; } = null!;
		public virtual DbSet<TblVendingMachine> TblVendingMachines { get; set; } = null!;
		public virtual DbSet<TblVendorTempVirtualItemList> TblVendorTempVirtualItemLists { get; set; } = null!;
		public virtual DbSet<TblVote> TblVotes { get; set; } = null!;
		public virtual DbSet<TblWantedList> TblWantedLists { get; set; } = null!;
		public virtual DbSet<TblWarehouseSlotCount> TblWarehouseSlotCounts { get; set; } = null!;
		public virtual DbSet<TblWarningItemList> TblWarningItemLists { get; set; } = null!;
		public virtual DbSet<TblWarningItemMailList> TblWarningItemMailLists { get; set; } = null!;
		public virtual DbSet<TblWeatherDynamicFactor> TblWeatherDynamicFactors { get; set; } = null!;
		public virtual DbSet<TblWeatherFactor> TblWeatherFactors { get; set; } = null!;
		public virtual DbSet<TblWebBenefit> TblWebBenefits { get; set; } = null!;
		public virtual DbSet<TblWebContentsOption> TblWebContentsOptions { get; set; } = null!;
		public virtual DbSet<TblWindDirection> TblWindDirections { get; set; } = null!;
		public virtual DbSet<TblWorker> TblWorkers { get; set; } = null!;
		public virtual DbSet<TblWorkerWorking> TblWorkerWorkings { get; set; } = null!;
		public virtual DbSet<TblWorldBoss> TblWorldBosses { get; set; } = null!;
		public virtual DbSet<TblWorldMarketCurrentPrice> TblWorldMarketCurrentPrices { get; set; } = null!;
		public virtual DbSet<TblWorldMarketNoticeItem> TblWorldMarketNoticeItems { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPayloadGameDb> TblWorldMarketPayloadGameDbs { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPayloadGameDbOld> TblWorldMarketPayloadGameDbOlds { get; set; } = null!;
		public virtual DbSet<TblWorldMarketTicket> TblWorldMarketTickets { get; set; } = null!;
		public virtual DbSet<TblWorldQuestLimit> TblWorldQuestLimits { get; set; } = null!;
		public virtual DbSet<TblXboxCashInfo> TblXboxCashInfos { get; set; } = null!;
		public virtual DbSet<TblXboxCashInfoLog> TblXboxCashInfoLogs { get; set; } = null!;
		public virtual DbSet<TexplorationExpTable> TexplorationExpTables { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(ConnHelper.GetConnString("Game"))
							 .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DimGuildItemKey>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PK__Dim_Guil__552FC81C9AD6E5B5");

				entity.ToTable("Dim_GuildItemKey", "PaOperationPublic");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");
			});

			modelBuilder.Entity<DimInstancefieldKey>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_InstancefieldKey", "PaOperationPublic");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.TypeHex)
					.HasMaxLength(10)
					.HasColumnName("_typeHex");
			});

			modelBuilder.Entity<DimItemKeyNeedContribute>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PK__Dim_item__552FC81CFA00E35C");

				entity.ToTable("Dim_itemKey_NeedContribute", "PaOperationPublic");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");

				entity.Property(e => e.ItemName).HasColumnName("_itemName");

				entity.Property(e => e.NeedContribute).HasColumnName("_NeedContribute");
			});

			modelBuilder.Entity<DimItemOptionBlunt>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_itemOption_Blunt", "PaOperationPublic");

				entity.Property(e => e.AddedDdd).HasColumnName("AddedDDD");

				entity.Property(e => e.AddedMdd).HasColumnName("AddedMDD");

				entity.Property(e => e.AddedRdd).HasColumnName("AddedRDD");

				entity.Property(e => e.Ddd)
					.HasMaxLength(255)
					.HasColumnName("DDD");

				entity.Property(e => e.Ddv).HasColumnName("DDV");

				entity.Property(e => e.Dhit).HasColumnName("DHIT");

				entity.Property(e => e.Dpv).HasColumnName("DPV");

				entity.Property(e => e.Hddv).HasColumnName("HDDV");

				entity.Property(e => e.Hdpv).HasColumnName("HDPV");

				entity.Property(e => e.Hmdv).HasColumnName("HMDV");

				entity.Property(e => e.Hmpv).HasColumnName("HMPV");

				entity.Property(e => e.Hrdv).HasColumnName("HRDV");

				entity.Property(e => e.Hrpv).HasColumnName("HRPV");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemName).HasMaxLength(255);

				entity.Property(e => e.Mdd)
					.HasMaxLength(255)
					.HasColumnName("MDD");

				entity.Property(e => e.Mdv).HasColumnName("MDV");

				entity.Property(e => e.Mhit).HasColumnName("MHIT");

				entity.Property(e => e.Mpv).HasColumnName("MPV");

				entity.Property(e => e.Rdd)
					.HasMaxLength(255)
					.HasColumnName("RDD");

				entity.Property(e => e.Rdv).HasColumnName("RDV");

				entity.Property(e => e.Rhit).HasColumnName("RHIT");

				entity.Property(e => e.Rpv).HasColumnName("RPV");
			});

			modelBuilder.Entity<DimItemOptionLongSword>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_itemOption_LongSword", "PaOperationPublic");

				entity.Property(e => e.AddedDdd).HasColumnName("AddedDDD");

				entity.Property(e => e.AddedMdd).HasColumnName("AddedMDD");

				entity.Property(e => e.AddedRdd).HasColumnName("AddedRDD");

				entity.Property(e => e.Ddd)
					.HasMaxLength(255)
					.HasColumnName("DDD");

				entity.Property(e => e.Ddv).HasColumnName("DDV");

				entity.Property(e => e.Dhit).HasColumnName("DHIT");

				entity.Property(e => e.Dpv).HasColumnName("DPV");

				entity.Property(e => e.Hddv).HasColumnName("HDDV");

				entity.Property(e => e.Hdpv).HasColumnName("HDPV");

				entity.Property(e => e.Hmdv).HasColumnName("HMDV");

				entity.Property(e => e.Hmpv).HasColumnName("HMPV");

				entity.Property(e => e.Hrdv).HasColumnName("HRDV");

				entity.Property(e => e.Hrpv).HasColumnName("HRPV");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemName).HasMaxLength(255);

				entity.Property(e => e.Mdd)
					.HasMaxLength(255)
					.HasColumnName("MDD");

				entity.Property(e => e.Mdv).HasColumnName("MDV");

				entity.Property(e => e.Mhit).HasColumnName("MHIT");

				entity.Property(e => e.Mpv).HasColumnName("MPV");

				entity.Property(e => e.Rdd)
					.HasMaxLength(255)
					.HasColumnName("RDD");

				entity.Property(e => e.Rdv).HasColumnName("RDV");

				entity.Property(e => e.Rhit).HasColumnName("RHIT");

				entity.Property(e => e.Rpv).HasColumnName("RPV");
			});

			modelBuilder.Entity<DimItemOptionTwoHandSword>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_itemOption_TwoHandSword", "PaOperationPublic");

				entity.Property(e => e.AddedDdd).HasColumnName("AddedDDD");

				entity.Property(e => e.AddedMdd).HasColumnName("AddedMDD");

				entity.Property(e => e.AddedRdd).HasColumnName("AddedRDD");

				entity.Property(e => e.Ddd)
					.HasMaxLength(255)
					.HasColumnName("DDD");

				entity.Property(e => e.Ddv).HasColumnName("DDV");

				entity.Property(e => e.Dhit).HasColumnName("DHIT");

				entity.Property(e => e.Dpv).HasColumnName("DPV");

				entity.Property(e => e.Hddv).HasColumnName("HDDV");

				entity.Property(e => e.Hdpv).HasColumnName("HDPV");

				entity.Property(e => e.Hmdv).HasColumnName("HMDV");

				entity.Property(e => e.Hmpv).HasColumnName("HMPV");

				entity.Property(e => e.Hrdv).HasColumnName("HRDV");

				entity.Property(e => e.Hrpv).HasColumnName("HRPV");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemName).HasMaxLength(255);

				entity.Property(e => e.Mdd)
					.HasMaxLength(255)
					.HasColumnName("MDD");

				entity.Property(e => e.Mdv).HasColumnName("MDV");

				entity.Property(e => e.Mhit).HasColumnName("MHIT");

				entity.Property(e => e.Mpv).HasColumnName("MPV");

				entity.Property(e => e.Rdd)
					.HasMaxLength(255)
					.HasColumnName("RDD");

				entity.Property(e => e.Rdv).HasColumnName("RDV");

				entity.Property(e => e.Rhit).HasColumnName("RHIT");

				entity.Property(e => e.Rpv).HasColumnName("RPV");
			});

			modelBuilder.Entity<DimMentalCardList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_MentalCardList", "PaOperationPublic");

				entity.Property(e => e.CardKey).HasColumnName("_cardKey");

				entity.Property(e => e.Level).HasColumnName("_level");
			});

			modelBuilder.Entity<DimNodeNeedContribute>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_Node_NeedContribute", "PaOperationPublic");

				entity.Property(e => e.Name)
					.HasMaxLength(255)
					.HasColumnName("_name");

				entity.Property(e => e.NeedExplorePoint).HasColumnName("_needExplorePoint");

				entity.Property(e => e.Type)
					.HasMaxLength(255)
					.HasColumnName("_Type");

				entity.Property(e => e.WayPointKey).HasColumnName("_wayPointKey");
			});

			modelBuilder.Entity<DimVariousNo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_VariousNo", "PaGamePrivate");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<DimVariousNo1>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_VariousNo", "PaOperationPublic");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<DimWaypointKey>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("Dim_WaypointKey", "PaOperationPublic");

				entity.Property(e => e.Value).HasColumnName("_value");

				entity.Property(e => e.WaypointKey).HasColumnName("_waypointKey");
			});

			modelBuilder.Entity<TabnormalPayloadBak>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TAbnormalPayload_bak");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.GameState).HasColumnName("_gameState");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Payload).HasColumnName("_payload");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.State).HasColumnName("_state");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Weight).HasColumnName("_weight");
			});

			modelBuilder.Entity<TargetItem>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PKTargetItem");

				entity.ToTable("TargetItem", "PaOperationPrivate");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TargetQuest>(entity =>
			{
				entity.HasKey(e => new { e.QuestGroupNo, e.QuestNo })
					.HasName("PKTargetQuest");

				entity.ToTable("TargetQuest", "PaOperationPrivate");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");
			});

			modelBuilder.Entity<TblAbsolutePower>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CurseType })
					.HasName("PkTblAbsolutePower")
					.IsClustered(false);

				entity.ToTable("TblAbsolutePower", "PaGamePrivate");

				entity.HasComment("절대권력");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("저주 걸린 사용자 번호");

				entity.Property(e => e.CurseType)
					.HasColumnName("_curseType")
					.HasComment("저주 타입");

				entity.Property(e => e.ExpirationTime)
					.HasColumnType("datetime")
					.HasColumnName("_expirationTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("만기 시간");
			});

			modelBuilder.Entity<TblAbsolutePowerHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAbsolutePowerHistory", "PaGamePrivate");

				entity.HasComment("절대권력이력");

				entity.Property(e => e.Comment)
					.HasColumnName("_comment")
					.HasComment("저주 건 사유");

				entity.Property(e => e.CurseTime)
					.HasColumnType("datetime")
					.HasColumnName("_curseTime")
					.HasComment("저주 종료 시간");

				entity.Property(e => e.Curses)
					.HasColumnName("_curses")
					.HasComment("적용된 저주 들");

				entity.Property(e => e.OperatorNo)
					.HasColumnName("_operatorNo")
					.HasComment("운영자 번호");

				entity.Property(e => e.RegisterTime)
					.HasColumnType("datetime")
					.HasColumnName("_registerTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 시간");

				entity.Property(e => e.TargetUserNo)
					.HasColumnName("_targetUserNo")
					.HasComment("대상 유저");
			});

			modelBuilder.Entity<TblAcoinChargeNumbersByWeb>(entity =>
			{
				entity.HasKey(e => e.ItemNo);

				entity.ToTable("TblAcoinChargeNumbersByWeb", "PaGamePrivate");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo");

				entity.Property(e => e.ChargeNo)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("_chargeNo");

				entity.Property(e => e.ChargeType).HasColumnName("_chargeType");

				entity.Property(e => e.IsCanceled).HasColumnName("_isCanceled");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MailNo).HasColumnName("_mailNo");

				entity.Property(e => e.RegDate)
					.HasColumnType("datetime")
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UpdDate)
					.HasColumnType("datetime")
					.HasColumnName("_updDate");

				entity.Property(e => e.WorldNo).HasColumnName("_worldNo");
			});

			modelBuilder.Entity<TblAddFriendList>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.RequestUserNo })
					.HasName("PkTblAddFriendList");

				entity.ToTable("TblAddFriendList", "PaGamePrivate");

				entity.HasComment("친구 요청 리스트");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.RequestUserNo)
					.HasColumnName("_requestUserNo")
					.HasComment("친구요청 유저번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblAlchemyRecord>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAlchemyRecord", "PaGamePrivate");

				entity.HasComment("연금(요리) 기록 테이블");

				entity.Property(e => e.ItemCount0)
					.HasColumnName("_itemCount0")
					.HasComment("아이템의갯수0");

				entity.Property(e => e.ItemCount1)
					.HasColumnName("_itemCount1")
					.HasComment("아이템의갯수1");

				entity.Property(e => e.ItemCount2)
					.HasColumnName("_itemCount2")
					.HasComment("아이템의갯수2");

				entity.Property(e => e.ItemCount3)
					.HasColumnName("_itemCount3")
					.HasComment("아이템의갯수3");

				entity.Property(e => e.ItemCount4)
					.HasColumnName("_itemCount4")
					.HasComment("아이템의갯수4");

				entity.Property(e => e.ItemCount5)
					.HasColumnName("_itemCount5")
					.HasComment("아이템의갯수5");

				entity.Property(e => e.ItemCount6)
					.HasColumnName("_itemCount6")
					.HasComment("아이템의갯수6");

				entity.Property(e => e.ItemCount7)
					.HasColumnName("_itemCount7")
					.HasComment("아이템의갯수7");

				entity.Property(e => e.ItemKey0)
					.HasColumnName("_itemKey0")
					.HasComment("아이템키값0");

				entity.Property(e => e.ItemKey1)
					.HasColumnName("_itemKey1")
					.HasComment("아이템키값1");

				entity.Property(e => e.ItemKey2)
					.HasColumnName("_itemKey2")
					.HasComment("아이템키값2");

				entity.Property(e => e.ItemKey3)
					.HasColumnName("_itemKey3")
					.HasComment("아이템키값3");

				entity.Property(e => e.ItemKey4)
					.HasColumnName("_itemKey4")
					.HasComment("아이템키값4");

				entity.Property(e => e.ItemKey5)
					.HasColumnName("_itemKey5")
					.HasComment("아이템키값5");

				entity.Property(e => e.ItemKey6)
					.HasColumnName("_itemKey6")
					.HasComment("아이템키값6");

				entity.Property(e => e.ItemKey7)
					.HasColumnName("_itemKey7")
					.HasComment("아이템키값7");

				entity.Property(e => e.MentalCardKey)
					.HasColumnName("_mentalCardKey")
					.HasComment("지식의키");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasComment("기록일");

				entity.Property(e => e.ResultItemKey)
					.HasColumnName("_resultItemKey")
					.HasComment("지식을 얻을때 나온 결과 아이템");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("타입(연금,요리)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");
			});

			modelBuilder.Entity<TblAlchemyRecordNoOverlap>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAlchemyRecordNoOverlap", "PaGamePrivate");

				entity.Property(e => e.ItemCount0).HasColumnName("_itemCount0");

				entity.Property(e => e.ItemCount1).HasColumnName("_itemCount1");

				entity.Property(e => e.ItemCount2).HasColumnName("_itemCount2");

				entity.Property(e => e.ItemCount3).HasColumnName("_itemCount3");

				entity.Property(e => e.ItemCount4).HasColumnName("_itemCount4");

				entity.Property(e => e.ItemCount5).HasColumnName("_itemCount5");

				entity.Property(e => e.ItemCount6).HasColumnName("_itemCount6");

				entity.Property(e => e.ItemCount7).HasColumnName("_itemCount7");

				entity.Property(e => e.ItemKey0).HasColumnName("_itemKey0");

				entity.Property(e => e.ItemKey1).HasColumnName("_itemKey1");

				entity.Property(e => e.ItemKey2).HasColumnName("_itemKey2");

				entity.Property(e => e.ItemKey3).HasColumnName("_itemKey3");

				entity.Property(e => e.ItemKey4).HasColumnName("_itemKey4");

				entity.Property(e => e.ItemKey5).HasColumnName("_itemKey5");

				entity.Property(e => e.ItemKey6).HasColumnName("_itemKey6");

				entity.Property(e => e.ItemKey7).HasColumnName("_itemKey7");

				entity.Property(e => e.MentalCardKey).HasColumnName("_mentalCardKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ResultItemKey).HasColumnName("_resultItemKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblAltarOfBloodRank>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAltarOfBloodRank", "PaWebGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ContentsType).HasColumnName("_contentsType");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.RankingRowNum).HasColumnName("_rankingRowNum");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.Score).HasColumnName("_score");

				entity.Property(e => e.Stage).HasColumnName("_stage");

				entity.Property(e => e.UserCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_userCharacterName");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblAreaOfHadum>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblAreaOfHadum");

				entity.ToTable("TblAreaOfHadum", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.Point).HasColumnName("_point");
			});

			modelBuilder.Entity<TblAttendPersonalBattle>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.BattleNo })
					.HasName("PkTblAttendPersonalBattle");

				entity.ToTable("TblAttendPersonalBattle", "PaGamePrivate");

				entity.HasComment("개인 결전 참여 정보");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 번호");

				entity.Property(e => e.BattleNo)
					.HasColumnName("_battleNo")
					.HasComment("결전 번호");

				entity.Property(e => e.TeamNo)
					.HasColumnName("_teamNo")
					.HasComment("참여 상태");
			});

			modelBuilder.Entity<TblAttendance>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.AttendanceKey })
					.HasName("PkTblAttendance")
					.IsClustered(false);

				entity.ToTable("TblAttendance", "PaGamePrivate");

				entity.HasComment("출석 테이블(매달 초기화됨)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.AttendanceKey)
					.HasColumnName("_attendanceKey")
					.HasComment("출석키");

				entity.Property(e => e.AttendanceCount)
					.HasColumnName("_attendanceCount")
					.HasComment("출석일수(한달간)");

				entity.Property(e => e.OnAttendanceTime)
					.HasColumnType("datetime")
					.HasColumnName("_onAttendanceTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("출석한 시간");

				entity.Property(e => e.OverlapCount)
					.HasColumnName("_overlapCount")
					.HasComment("중복 출석 횟수");

				entity.Property(e => e.ReceivedReward)
					.HasColumnName("_receivedReward")
					.HasComment("출석 보상수령");
			});

			modelBuilder.Entity<TblAuctionBidderVer2>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.AuctionKey, e.AuctionGoodsNo })
					.HasName("PkTblAuctionBidderVer2");

				entity.ToTable("TblAuctionBidderVer2", "PaGamePrivate");

				entity.HasComment("경매 입찰 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("입찰자 유져 번호(입찰 완료)");

				entity.Property(e => e.AuctionKey)
					.HasColumnName("_auctionKey")
					.HasComment("경매장 번호");

				entity.Property(e => e.AuctionGoodsNo)
					.HasColumnName("_auctionGoodsNo")
					.HasComment("경매상품 번호");

				entity.Property(e => e.BidCount).HasColumnName("_bidCount");

				entity.Property(e => e.BidPrice)
					.HasColumnName("_bidPrice")
					.HasComment("입찰가");

				entity.Property(e => e.BidPriceOwnerNo)
					.HasColumnName("_bidPriceOwnerNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("입찰자 유져 번호(입찰 완료)");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasComment("삭제일");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.SuccessBidder)
					.HasColumnName("_successBidder")
					.HasDefaultValueSql("((-1))")
					.HasComment("낙찰자(-1 입찰중,돈찾아가면 삭제)");
			});

			modelBuilder.Entity<TblAuctionBidderVer2GuildHouseBak>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAuctionBidderVer2_GuildHouse_bak", "PaOperationPrivate");

				entity.Property(e => e.AuctionGoodsNo).HasColumnName("_auctionGoodsNo");

				entity.Property(e => e.AuctionKey).HasColumnName("_auctionKey");

				entity.Property(e => e.BackupDate)
					.HasColumnType("datetime")
					.HasColumnName("_backupDate");

				entity.Property(e => e.BidCount).HasColumnName("_bidCount");

				entity.Property(e => e.BidPrice).HasColumnName("_bidPrice");

				entity.Property(e => e.BidPriceOwnerNo).HasColumnName("_bidPriceOwnerNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.SuccessBidder).HasColumnName("_successBidder");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblAuctionBuyGoodsVer2>(entity =>
			{
				entity.HasKey(e => e.AuctionGoodsNo)
					.HasName("PkTblAuctionBuyGoodsVer2");

				entity.ToTable("TblAuctionBuyGoodsVer2", "PaGamePrivate");

				entity.HasComment("경매 구매 테이블(삽니다)");

				entity.Property(e => e.AuctionGoodsNo)
					.HasColumnName("_auctionGoodsNo")
					.HasComment("경매상품 번호");

				entity.Property(e => e.AuctionKey)
					.HasColumnName("_auctionKey")
					.HasComment("경매장 번호");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("매입자");

				entity.Property(e => e.CurrentItemCount)
					.HasColumnName("_currentItemCount")
					.HasComment("구매한 아이템 갯수");

				entity.Property(e => e.Deposit)
					.HasColumnName("_deposit")
					.HasComment("보증금");

				entity.Property(e => e.ExpireTime)
					.HasColumnName("_expireTime")
					.HasComment("구매 종료 시간");

				entity.Property(e => e.IsAuctionEnd)
					.HasColumnName("_isAuctionEnd")
					.HasComment("경매종료(경매종료 1)");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("구매할 아이템 키");

				entity.Property(e => e.ItemPrice)
					.HasColumnName("_itemPrice")
					.HasComment("개당 아이템 갯수");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.TotalItemCount)
					.HasColumnName("_totalItemCount")
					.HasComment("구매할 아이템 갯수");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("매입자");
			});

			modelBuilder.Entity<TblAuctionGoodsVer2>(entity =>
			{
				entity.HasKey(e => e.AuctionGoodsNo)
					.HasName("PkTblAuctionGoodsVer2");

				entity.ToTable("TblAuctionGoodsVer2", "PaGamePrivate");

				entity.HasComment("경매 판매 테이블(팝니다)");

				entity.Property(e => e.AuctionGoodsNo)
					.HasColumnName("_auctionGoodsNo")
					.HasComment("경매상품 번호");

				entity.Property(e => e.AuctionKey)
					.HasColumnName("_auctionKey")
					.HasComment("경매장 번호");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("판매자 캐릭터 번호");

				entity.Property(e => e.ExpireLimitTime)
					.HasColumnName("_expireLimitTime")
					.HasComment("경매 종료 최대 시간");

				entity.Property(e => e.ExpireTime)
					.HasColumnName("_expireTime")
					.HasComment("경매 종료 시간( 1분 이하 일 때 입찰되면 시간 증가 남은 최대시간을 초과할 수는 없다.)");

				entity.Property(e => e.GoodsCount)
					.HasColumnName("_goodsCount")
					.HasComment("상품 갯수");

				entity.Property(e => e.GoodsKey)
					.HasColumnName("_goodsKey")
					.HasComment("상품 키");

				entity.Property(e => e.GoodsType)
					.HasColumnName("_goodsType")
					.HasComment("상품 종류");

				entity.Property(e => e.IsAuctionEnd)
					.HasColumnName("_isAuctionEnd")
					.HasComment("경매종료(경매종료 1)");

				entity.Property(e => e.MaxPrice)
					.HasColumnName("_maxPrice")
					.HasComment("즉시 구매가");

				entity.Property(e => e.MinPrice)
					.HasColumnName("_minPrice")
					.HasComment("최소 입찰가격");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.SuccessBidPrice)
					.HasColumnName("_successBidPrice")
					.HasComment("낙찰가");

				entity.Property(e => e.SuccessBidder)
					.HasColumnName("_successBidder")
					.HasDefaultValueSql("((-1))")
					.HasComment("낙찰자 TUserNo (입찰진행중 -1 낙찰자가 찾아가면 0)");

				entity.Property(e => e.TransferNo)
					.HasColumnName("_transferNo")
					.HasComment("입찰(구매) 제한");

				entity.Property(e => e.TransferType)
					.HasColumnName("_transferType")
					.HasComment("입찰(구매) 제한");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("판매자 유져 번호");
			});

			modelBuilder.Entity<TblAuctionInfo>(entity =>
			{
				entity.HasKey(e => e.AuctionKey)
					.HasName("PkTblAuctionInfo");

				entity.ToTable("TblAuctionInfo", "PaGamePrivate");

				entity.HasComment("경매장 정보 ( 집 경매 및 용병 경매를 위함 )");

				entity.Property(e => e.AuctionKey)
					.ValueGeneratedNever()
					.HasColumnName("_auctionKey")
					.HasComment("경매장 번호");

				entity.Property(e => e.NextStartTime)
					.HasColumnName("_nextStartTime")
					.HasComment("다음 경매 시간");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblAutoChessDeck>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CardKey })
					.HasName("PkTblTblCardBattleInfo")
					.IsClustered(false);

				entity.ToTable("TblAutoChessDeck", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CardKey)
					.ValueGeneratedOnAdd()
					.HasColumnName("_cardKey");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.Defence).HasColumnName("_defence");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.Grade).HasColumnName("_grade");

				entity.Property(e => e.Hp)
					.HasColumnName("_hp")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Offence).HasColumnName("_offence");
			});

			modelBuilder.Entity<TblBadPlayerList>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.BadCharacterNo, e.DeadTime })
					.HasName("PkBadPlayerList");

				entity.ToTable("TblBadPlayerList", "PaGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.BadCharacterNo).HasColumnName("_badCharacterNo");

				entity.Property(e => e.DeadTime)
					.HasColumnType("datetime")
					.HasColumnName("_deadTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.BadCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_badCharacterName");

				entity.Property(e => e.BadUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_badUserNickname");

				entity.Property(e => e.DeadRegion)
					.HasMaxLength(30)
					.HasColumnName("_deadRegion");
			});

			modelBuilder.Entity<TblBarterInfoList>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.IsSpecial, e.RegionKey })
					.HasName("PkTblBarterInfoList");

				entity.ToTable("TblBarterInfoList", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.IsSpecial).HasColumnName("_isSpecial");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.BarterSeed)
					.HasColumnName("_barterSeed")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.BarterType).HasColumnName("_barterType");

				entity.Property(e => e.CurrentExchangeCount).HasColumnName("_currentExchangeCount");

				entity.Property(e => e.ExchangeCountForTime).HasColumnName("_exchangeCountForTime");

				entity.Property(e => e.FromItemCount).HasColumnName("_fromItemCount");

				entity.Property(e => e.FromItemEnchantKey).HasColumnName("_fromItemEnchantKey");

				entity.Property(e => e.MaxExchangeCount).HasColumnName("_maxExchangeCount");

				entity.Property(e => e.ToItemCount).HasColumnName("_toItemCount");

				entity.Property(e => e.ToItemEnchantKey).HasColumnName("_toItemEnchantKey");
			});

			modelBuilder.Entity<TblBarterUserInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblBarterUserInfo");

				entity.ToTable("TblBarterUserInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.BarterSeed).HasColumnName("_barterSeed");

				entity.Property(e => e.BarterStack).HasColumnName("_barterStack");

				entity.Property(e => e.BarterType).HasColumnName("_barterType");

				entity.Property(e => e.ChangeSeedCountForDay).HasColumnName("_changeSeedCountForDay");

				entity.Property(e => e.ExchangeCountForTime).HasColumnName("_exchangeCountForTime");

				entity.Property(e => e.LastExchangeCount).HasColumnName("_lastExchangeCount");

				entity.Property(e => e.LastResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastResetTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.MaterialSeedChangeCountForDay).HasColumnName("_materialSeedChangeCountForDay");

				entity.Property(e => e.NextUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextUpdateDate");

				entity.Property(e => e.NormalSeedChangeCountForDay).HasColumnName("_normalSeedChangeCountForDay");

				entity.Property(e => e.TotalExchangeCount).HasColumnName("_totalExchangeCount");

				entity.Property(e => e.UseAddCountItemTime)
					.HasColumnType("datetime")
					.HasColumnName("_useAddCountItemTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseItemTime)
					.HasColumnType("datetime")
					.HasColumnName("_useItemTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblBattleHeroRanking>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBattleHeroRanking", "PaWebGamePrivate");

				entity.Property(e => e.BeforeRankingRowNum).HasColumnName("_beforeRankingRowNum");

				entity.Property(e => e.JoinCountBase).HasColumnName("_joinCountBase");

				entity.Property(e => e.JoinCountSeize).HasColumnName("_joinCountSeize");

				entity.Property(e => e.KillCountBase).HasColumnName("_killCountBase");

				entity.Property(e => e.KillCountSeize).HasColumnName("_killCountSeize");

				entity.Property(e => e.RankingRowNum).HasColumnName("_rankingRowNum");

				entity.Property(e => e.Score).HasColumnName("_score");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.WinCountBase).HasColumnName("_winCountBase");

				entity.Property(e => e.WinCountSeize).HasColumnName("_winCountSeize");
			});

			modelBuilder.Entity<TblBattlePass>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SeasonKey })
					.HasName("PKTblBattlePass");

				entity.ToTable("TblBattlePass", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SeasonKey).HasColumnName("_seasonKey");

				entity.Property(e => e.IsPremium).HasColumnName("_isPremium");

				entity.Property(e => e.Point).HasColumnName("_point");
			});

			modelBuilder.Entity<TblBattleRoyaleItemsInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ItemKey })
					.HasName("PkTblBattleRoyaleItemsInfo")
					.IsClustered(false);

				entity.ToTable("TblBattleRoyaleItemsInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.Count).HasColumnName("_count");
			});

			modelBuilder.Entity<TblBattleRoyalePlayTime>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblBattleRoyalePlayTime");

				entity.ToTable("TblBattleRoyalePlayTime", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.GamePlayTime).HasColumnName("_gamePlayTime");

				entity.Property(e => e.GamePlayTimePerDay).HasColumnName("_gamePlayTimePerDay");

				entity.Property(e => e.LastAccumulateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastAccumulateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.LastSoloGameTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastSoloGameTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.LastTeamGameTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastTeamGameTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TotalPlayTime).HasColumnName("_totalPlayTime");

				entity.Property(e => e.TotalPlayTimePerDay).HasColumnName("_totalPlayTimePerDay");
			});

			modelBuilder.Entity<TblBattleRoyaleSmuggledItemsInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ItemNo })
					.HasName("PkTblBattleRoyaleSmuggledItemsInfo")
					.IsClustered(false);

				entity.ToTable("TblBattleRoyaleSmuggledItemsInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblBattleRoyaleUserInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblBattleRoyaleUserInfo");

				entity.ToTable("TblBattleRoyaleUserInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.AfterOnlineRanking).HasColumnName("_afterOnlineRanking");

				entity.Property(e => e.AutoMatchingType).HasColumnName("_autoMatchingType");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.IsNormalMode).HasColumnName("_isNormalMode");

				entity.Property(e => e.OrigOnlineRanking).HasColumnName("_origOnlineRanking");

				entity.Property(e => e.PartyBotClassSetting)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_partyBotClassSetting");

				entity.Property(e => e.SkinKey).HasColumnName("_skinKey");

				entity.Property(e => e.TotalUserCount).HasColumnName("_totalUserCount");

				entity.Property(e => e.WeaponSkinKey).HasColumnName("_weaponSkinKey");
			});

			modelBuilder.Entity<TblBattleRoyaleUserPlayTimeLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBattleRoyaleUserPlayTimeLog", "PaGamePrivate");

				entity.Property(e => e.GamePlayTimePerDay).HasColumnName("_gamePlayTimePerDay");

				entity.Property(e => e.MDate).HasColumnName("_mDate");

				entity.Property(e => e.TotalPlayTimePerDay).HasColumnName("_totalPlayTimePerDay");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBlackMarble>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblBlackMarble");

				entity.ToTable("TblBlackMarble", "PaWebGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.FinishCount).HasColumnName("_finishCount");

				entity.Property(e => e.LastPlayDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastPlayDate");

				entity.Property(e => e.NowPosition).HasColumnName("_nowPosition");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TodayCount).HasColumnName("_todayCount");
			});

			modelBuilder.Entity<TblBlackSpiritAdventure>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblBlackSpiritAdventure");

				entity.ToTable("TblBlackSpiritAdventure", "PaWebGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.BoxRegionKey).HasColumnName("_boxRegionKey");

				entity.Property(e => e.Exp).HasColumnName("_exp");

				entity.Property(e => e.IsMainQuest).HasColumnName("_isMainQuest");

				entity.Property(e => e.LastPlayDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastPlayDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.MapPiece)
					.HasMaxLength(10)
					.HasColumnName("_mapPiece")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MoveCountUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_moveCountUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.RemainMoveCount).HasColumnName("_remainMoveCount");

				entity.Property(e => e.RestUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_restUpdateDate");

				entity.Property(e => e.TerritoryKey).HasColumnName("_territoryKey");

				entity.Property(e => e.TodayChargeCount).HasColumnName("_todayChargeCount");
			});

			modelBuilder.Entity<TblBlackSpiritAdventureItem>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.WebItemKey })
					.HasName("PkTblBlackSpiritAdventureItem");

				entity.ToTable("TblBlackSpiritAdventureItem", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.WebItemKey).HasColumnName("_webItemKey");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.UseCondition).HasColumnName("_useCondition");
			});

			modelBuilder.Entity<TblBlackSpiritAdventureMonster>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.MonsterKey, e.SpawnDate, e.Status })
					.HasName("PkTblBlackSpiritAdventureMonster");

				entity.ToTable("TblBlackSpiritAdventureMonster", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.MonsterKey).HasColumnName("_monsterKey");

				entity.Property(e => e.SpawnDate)
					.HasColumnType("datetime")
					.HasColumnName("_spawnDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Status).HasColumnName("_status");

				entity.Property(e => e.KillDate)
					.HasColumnType("datetime")
					.HasColumnName("_killDate");

				entity.Property(e => e.MonsterType).HasColumnName("_monsterType");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");
			});

			modelBuilder.Entity<TblBlackSpiritAdventureQuest>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.QuestNo })
					.HasName("PkTblBlackSpiritAdventureQuest");

				entity.ToTable("TblBlackSpiritAdventureQuest", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");

				entity.Property(e => e.CompleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_completeDate");

				entity.Property(e => e.IsBossQuest).HasColumnName("_isBossQuest");

				entity.Property(e => e.IsComplete).HasColumnName("_isComplete");

				entity.Property(e => e.MonsterKey).HasColumnName("_monsterKey");

				entity.Property(e => e.QuestGroupIndex).HasColumnName("_questGroupIndex");

				entity.Property(e => e.QuestSequence).HasColumnName("_questSequence");

				entity.Property(e => e.StartDate)
					.HasColumnType("datetime")
					.HasColumnName("_startDate");
			});

			modelBuilder.Entity<TblBlackSpiritAdventureRegion>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.RegionKey, e.MenuType })
					.HasName("PkTblBlackSpiritAdventureTerritory");

				entity.ToTable("TblBlackSpiritAdventureRegion", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.MenuType).HasColumnName("_menuType");

				entity.Property(e => e.Status).HasColumnName("_status");
			});

			modelBuilder.Entity<TblBlackSpiritForm>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBlackSpiritForm", "PaGamePrivate");

				entity.HasComment("흑정령외형변경");

				entity.Property(e => e.BlackSpiritFormIndex)
					.HasColumnName("_blackSpiritFormIndex")
					.HasComment("흑정령외형 인덱스");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("소유 캐릭터");
			});

			modelBuilder.Entity<TblBlockByKeyOrUserNo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBlockByKeyOrUserNo", "PaGamePrivate");

				entity.HasComment("블록 통합 테이블");

				entity.Property(e => e.BlockNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_blockNo");

				entity.Property(e => e.Memo)
					.HasMaxLength(200)
					.HasColumnName("_memo");

				entity.Property(e => e.Param1)
					.HasColumnName("_param1")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.Param2)
					.HasColumnName("_param2")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.Param3)
					.HasColumnName("_param3")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.RegisterUserNo)
					.HasColumnName("_registerUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("블록 타입 - BlockedTbl.proc.sql에 기록");
			});

			modelBuilder.Entity<TblBlockItem>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PKTblBlockItem")
					.IsClustered(false);

				entity.ToTable("TblBlockItem", "PaGamePrivate");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");
			});

			modelBuilder.Entity<TblBlockItemForTrade>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PKTblBlockItemForTrade")
					.IsClustered(false);

				entity.ToTable("TblBlockItemForTrade", "PaGamePrivate");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");
			});

			modelBuilder.Entity<TblBlockQuest>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PKTblBlockQuest")
					.IsClustered(false);

				entity.ToTable("TblBlockQuest", "PaGamePrivate");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");

				entity.Property(e => e.QuestType).HasColumnName("_questType");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");
			});

			modelBuilder.Entity<TblBlockQuestLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBlockQuestLog", "PaGamePrivate");

				entity.Property(e => e.ActionType).HasColumnName("_actionType");

				entity.Property(e => e.AttachUserNo).HasColumnName("_attachUserNo");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.DetachDate)
					.HasColumnType("datetime")
					.HasColumnName("_detachDate");

				entity.Property(e => e.DetachUserNo).HasColumnName("_detachUserNo");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBlockUsingPointByUser>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PKTblBlockUsingPointByUser")
					.IsClustered(false);

				entity.ToTable("TblBlockUsingPointByUser", "PaGamePrivate");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBlockedChat>(entity =>
			{
				entity.HasKey(e => e.BlockNo)
					.HasName("PkTblBlockedChat")
					.IsClustered(false);

				entity.ToTable("TblBlockedChat", "PaGamePrivate");

				entity.HasComment("운영 관련 그룹의 역할 테이블");

				entity.Property(e => e.BlockNo)
					.HasColumnName("_blockNo")
					.HasComment("블록 고유 번호");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasComment("블록 종료 시간");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo")
					.HasComment("블록 사유");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("블록 등록 시간");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("블록 유저 번호");
			});

			modelBuilder.Entity<TblBlockedItemLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBlockedItemLog", "PaGamePrivate");

				entity.Property(e => e.ActionType).HasColumnName("_actionType");

				entity.Property(e => e.AttachUserNo).HasColumnName("_attachUserNo");

				entity.Property(e => e.BlockNo).HasColumnName("_blockNo");

				entity.Property(e => e.DetachDate)
					.HasColumnType("datetime")
					.HasColumnName("_detachDate");

				entity.Property(e => e.DetachUserNo).HasColumnName("_detachUserNo");

				entity.Property(e => e.ReasonMemo)
					.HasMaxLength(200)
					.HasColumnName("_reasonMemo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblBossSpawn>(entity =>
			{
				entity.HasKey(e => new { e.SummonerNo, e.SpawnKey })
					.HasName("PkTblBossSpawn")
					.IsClustered(false);

				entity.ToTable("TblBossSpawn", "PaGamePrivate");

				entity.Property(e => e.SummonerNo).HasColumnName("_summonerNo");

				entity.Property(e => e.SpawnKey).HasColumnName("_spawnKey");

				entity.Property(e => e.ResetDateTime)
					.HasColumnType("datetime")
					.HasColumnName("_resetDateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SpawnCost).HasColumnName("_spawnCost");

				entity.Property(e => e.SpawnCount).HasColumnName("_spawnCount");
			});

			modelBuilder.Entity<TblBranchQuest>(entity =>
			{
				entity.HasKey(e => new { e.IsUserBaseQuest, e.QuestGroupNo, e.QuestNo })
					.HasName("PkTblBranchQuest")
					.IsClustered(false);

				entity.ToTable("TblBranchQuest", "PaGamePrivate");

				entity.Property(e => e.IsUserBaseQuest).HasColumnName("_isUserBaseQuest");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");
			});

			modelBuilder.Entity<TblBriefUserInformation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblBriefUserInformation");

				entity.ToTable("TblBriefUserInformation", "PaGamePrivate");

				entity.HasComment("게임서버를 위한 간단한 유저정보");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.AccumulatePcRoomPlayTime)
					.HasColumnName("_accumulatePcRoomPlayTime")
					.HasComment("PC방 누적 플레이 시간(초)");

				entity.Property(e => e.AccumulatedAdvantageofTrade)
					.HasColumnName("_accumulatedAdvantageofTrade")
					.HasComment("하룻동안 무역으로번 수익");

				entity.Property(e => e.AccumulatedLoginCount)
					.HasColumnName("_accumulatedLoginCount")
					.HasDefaultValueSql("((1))")
					.HasComment("누적 접속 횟수");

				entity.Property(e => e.AdventureEnd)
					.HasColumnName("_adventureEnd")
					.HasDefaultValueSql("((-1))")
					.HasComment("");

				entity.Property(e => e.AdventureExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_adventureExpiration")
					.HasDefaultValueSql("((0))")
					.HasComment("");

				entity.Property(e => e.AdventureNo)
					.HasColumnName("_adventureNo")
					.HasComment("");

				entity.Property(e => e.AdventureTotalScore)
					.HasColumnName("_adventureTotalScore")
					.HasComment("");

				entity.Property(e => e.AffiliatedTerritoryKey)
					.HasColumnName("_affiliatedTerritoryKey")
					.HasDefaultValueSql("((-1))")
					.HasComment("소속영지");

				entity.Property(e => e.CashItemSaleCount)
					.HasColumnName("_cashItemSaleCount")
					.HasComment("캐시 아이템 거래소 판매 개수");

				entity.Property(e => e.CashItemSaleCountResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_cashItemSaleCountResetTime")
					.HasDefaultValueSql("((0))")
					.HasComment("캐시 아이템 거래소 판매 개수 초기화 시간");

				entity.Property(e => e.CharacterCreationCount)
					.HasColumnName("_characterCreationCount")
					.HasComment("캐릭터를 생성한 횟수");

				entity.Property(e => e.CustomizationPackageBuffExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_customizationPackageBuffExpiration")
					.HasComment("커스터마이징 패키지 버프 만료일시(널이거나 과거면 버프없음)");

				entity.Property(e => e.DdTerritoryKey)
					.HasColumnName("_ddTerritoryKey")
					.HasComment("소속 영지(NULL 이면 소속 없음)");

				entity.Property(e => e.DwellingCount).HasColumnName("_dwellingCount");

				entity.Property(e => e.EnterServerNo)
					.HasColumnName("_enterServerNo")
					.HasComment("현재 서버 No");

				entity.Property(e => e.ExpeditionSupplyPoint)
					.HasColumnName("_expeditionSupplyPoint")
					.HasComment("토벌게임 재화");

				entity.Property(e => e.ExplorationPoint)
					.HasColumnName("_explorationPoint")
					.HasComment("탐험포인트");

				entity.Property(e => e.FamilyInventorySlotCount).HasColumnName("_familyInventorySlotCount");

				entity.Property(e => e.FamilyInventoryWeight).HasColumnName("_familyInventoryWeight");

				entity.Property(e => e.GuildJoinableTime)
					.HasColumnType("datetime")
					.HasColumnName("_guildJoinableTime")
					.HasComment("길드 가입 가능한 날짜.최초 길드 가입할때부터 설정됨,클랜은 해당안됨");

				entity.Property(e => e.IsFirstLogin)
					.IsRequired()
					.HasColumnName("_isFirstLogin")
					.HasDefaultValueSql("((1))")
					.HasComment("참이면 최초 접속자");

				entity.Property(e => e.IsGhostMode)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_isGhostMode")
					.HasDefaultValueSql("((0))")
					.IsFixedLength()
					.HasComment("사생활 모드 로그인");

				entity.Property(e => e.IsPcSwitching)
					.HasColumnName("_isPcSwitching")
					.HasComment("참이면 PC전환중임");

				entity.Property(e => e.IsPvpAble)
					.HasColumnName("_isPvpAble")
					.HasComment("PVP가능상태");

				entity.Property(e => e.IsUpdatePremiumBuffBySystem).HasColumnName("_isUpdatePremiumBuffBySystem");

				entity.Property(e => e.KeepItemKey)
					.HasColumnName("_keepItemKey")
					.HasComment("랜덤 상점 예약 아이템");

				entity.Property(e => e.KeepItemPriceRate)
					.HasColumnName("_keepItemPriceRate")
					.HasComment("랜덤 상점 예약 아이템 가격배율");

				entity.Property(e => e.LastCharacterNo)
					.HasColumnName("_lastCharacterNo")
					.HasDefaultValueSql("((-1))")
					.HasComment("최근 (플레이)캐릭터 번호");

				entity.Property(e => e.LastFairyRespawnTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastFairyRespawnTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("요정 부활(0이면 사용한적 없음)");

				entity.Property(e => e.LastIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_lastIp")
					.HasDefaultValueSql("(' ')")
					.HasComment("최근 IP");

				entity.Property(e => e.LastLoginTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLoginTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("최근 로그인시간");

				entity.Property(e => e.LastLogoutTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLogoutTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("최근 로그아웃시간");

				entity.Property(e => e.LastServantBuyTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastServantBuyTime")
					.HasComment("마지막으로 말 구매한 시간");

				entity.Property(e => e.LastServantMixTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastServantMixTime")
					.HasComment("마지막으로 말 교환을 진행한 시간");

				entity.Property(e => e.MaxWp).HasColumnName("_maxWp");

				entity.Property(e => e.NewFriend)
					.HasColumnName("_newFriend")
					.HasComment("새 친구 여부");

				entity.Property(e => e.NewRequestFriend)
					.HasColumnName("_newRequestFriend")
					.HasComment("친구 요청 여부");

				entity.Property(e => e.OceanTendency).HasColumnName("_oceanTendency");

				entity.Property(e => e.PcRoomPlayTimePerDay)
					.HasColumnName("_pcRoomPlayTimePerDay")
					.HasComment("PC방 플레이 시간(초)");

				entity.Property(e => e.PearlPackageBuffRemainMinute)
					.HasColumnName("_pearlPackageBuffRemainMinute")
					.HasComment("펄버프 남은 분=> TOdbcRemainTime 와 연결됨");

				entity.Property(e => e.PlatformType).HasColumnName("_platformType");

				entity.Property(e => e.PlayResetTimePerDay)
					.HasColumnType("datetime")
					.HasColumnName("_playResetTimePerDay")
					.HasDefaultValueSql("((0))")
					.HasComment("PC방 리셋 시간");

				entity.Property(e => e.PlayTimePerDay)
					.HasColumnName("_playTimePerDay")
					.HasComment("플레이 시간 (초)(하루 동안)");

				entity.Property(e => e.PlunderGameVoteCount)
					.HasColumnName("_plunderGameVoteCount")
					.HasComment("약탈게임 투표가능 횟수");

				entity.Property(e => e.PreGuildActivity)
					.HasColumnName("_preGuildActivity")
					.HasComment("과거 길드 활동 점수");

				entity.Property(e => e.PremiumPackageBuffExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_premiumPackageBuffExpiration")
					.HasComment("프리미엄패키지 버프 만료일시(널이거나 과거면 버프없음)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("간단 유저정보 최초 등록일시");

				entity.Property(e => e.RemainKeepTime)
					.HasColumnType("datetime")
					.HasColumnName("_remainKeepTime")
					.HasDefaultValueSql("((0))")
					.HasComment("랜덤 상점 예약 아이템 남은 분");

				entity.Property(e => e.SeasonPass).HasColumnName("_seasonPass");

				entity.Property(e => e.StarterPackageBuffExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_starterPackageBuffExpiration")
					.HasComment("스타터 패키지 버프 만료일시(널이거나 과거면 버프없음)");

				entity.Property(e => e.TotalPlayTime)
					.HasColumnName("_totalPlayTime")
					.HasComment("총 플레이 시간");

				entity.Property(e => e.TradeSupplyCount)
					.HasColumnName("_tradeSupplyCount")
					.HasComment("요리/연금 판매 가능 갯수");

				entity.Property(e => e.UserBasicCacheSeqNo)
					.HasColumnName("_userBasicCacheSeqNo")
					.HasComment("유저정보 갱신번호");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId")
					.HasComment("퍼블리셔에서 넘어온 유저번호");

				entity.Property(e => e.UserIntroduction)
					.HasMaxLength(200)
					.HasColumnName("_userIntroduction");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasComment("유저별명");

				entity.Property(e => e.VariedCharacterSlotCount)
					.HasColumnName("_variedCharacterSlotCount")
					.HasComment("증가된 캐릭터 슬롯 갯수");
			});

			modelBuilder.Entity<TblBuff>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBuff", "PaGamePrivate");

				entity.HasComment("버프를 저장하기 위한 테이블");

				entity.Property(e => e.BuffKey)
					.HasColumnName("_buffKey")
					.HasComment("서버에서 사용하는 버프키");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("버프가 적용되는 캐릭터의 번호");

				entity.Property(e => e.LeftApplyingCount)
					.HasColumnName("_leftApplyingCount")
					.HasComment("버프의 남은 적용 횟수");

				entity.Property(e => e.RemainTime)
					.HasColumnName("_remainTime")
					.HasComment("버프의 남은 시간");
			});

			modelBuilder.Entity<TblBuffCount>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Type })
					.HasName("PkTblBuffCount");

				entity.ToTable("TblBuffCount", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.Count).HasColumnName("_count");
			});

			modelBuilder.Entity<TblBuffExpirationDate>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblBuffExpirationDate", "PaGamePrivate");

				entity.HasComment("버프의 유효시간");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasComment("버프 만료일시(절대시간임) => NULL 이거나 과거면 버프 없음.");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasComment("버프 레벨.");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("버프 종류 => enum값과 연결됨");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");
			});

			modelBuilder.Entity<TblBusinessInstallation>(entity =>
			{
				entity.HasKey(e => e.InstallationNo)
					.HasName("PkTblBusinessInstallation")
					.IsClustered(false);

				entity.ToTable("TblBusinessInstallation", "PaGamePrivate");

				entity.HasComment("하우징 설치오브젝트 사업정보");

				entity.Property(e => e.InstallationNo)
					.ValueGeneratedNever()
					.HasColumnName("_installationNo")
					.HasComment("설치 오브젝트 번호");

				entity.Property(e => e.BusinessType)
					.HasColumnName("_businessType")
					.HasComment("0자동판매1위탁판매");

				entity.Property(e => e.CommissionRate)
					.HasColumnName("_commissionRate")
					.HasComment("판매수수료");

				entity.Property(e => e.HoldingMoney)
					.HasColumnName("_holdingMoney")
					.HasComment("보유금액");

				entity.Property(e => e.HouseholdNo)
					.HasColumnName("_householdNo")
					.HasComment("집 번호");

				entity.Property(e => e.IsActive)
					.HasColumnName("_isActive")
					.HasComment("액티브여부");

				entity.Property(e => e.MinRegisterMoney)
					.HasColumnName("_minRegisterMoney")
					.HasComment("최소등록비");

				entity.Property(e => e.SaleTime)
					.HasColumnName("_saleTime")
					.HasComment("판매기간");
			});

			modelBuilder.Entity<TblCacheSeq>(entity =>
			{
				entity.HasKey(e => new { e.Key, e.CacheType })
					.HasName("PkTblCacheSeq");

				entity.ToTable("TblCacheSeq", "PaGamePrivate");

				entity.HasComment("캐싱관련 변경회수");

				entity.Property(e => e.Key)
					.HasColumnName("_key")
					.HasComment("_cacheType 에 따라서 의미가 다름");

				entity.Property(e => e.CacheType)
					.HasColumnName("_cacheType")
					.HasComment("OdbcCacheType 참고");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SeqNo)
					.HasColumnName("_seqNo")
					.HasComment("CacheSeq 참고");
			});

			modelBuilder.Entity<TblCandidateList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCandidateList", "PaGamePrivate");

				entity.HasComment("후보자 리스트 테이블");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("후보자 캐릭터번호");

				entity.Property(e => e.ClassType)
					.HasColumnName("_classType")
					.HasComment("클래스 타입");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.Resign).HasColumnName("_resign");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("후보자 유저번호");

				entity.Property(e => e.VoteCount)
					.HasColumnName("_voteCount")
					.HasComment("투표 수");
			});

			modelBuilder.Entity<TblCaphrasBonusSlot>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.EquipSlotNo })
					.HasName("PkTblCaphrasBonusSlot");

				entity.ToTable("TblCaphrasBonusSlot", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.EquipSlotNo).HasColumnName("_equipSlotNo");

				entity.Property(e => e.Value).HasColumnName("_value");
			});

			modelBuilder.Entity<TblCashItemBuyCount>(entity =>
			{
				entity.HasKey(e => new { e.IsUserNo, e.UserCharacterNo, e.CashProductNo, e.Type })
					.HasName("PkTblCashItemBuyCount")
					.IsClustered(false);

				entity.ToTable("TblCashItemBuyCount", "PaGamePrivate");

				entity.HasComment("아이템 구매 갯수 저장");

				entity.Property(e => e.IsUserNo)
					.HasColumnName("_isUserNo")
					.HasComment("유저번호인가?");

				entity.Property(e => e.UserCharacterNo)
					.HasColumnName("_userCharacterNo")
					.HasComment("유저번호&캐릭터번호(_isUserNo가 참이면 유저번호임)");

				entity.Property(e => e.CashProductNo)
					.HasColumnName("_cashProductNo")
					.HasComment("캐시상품키");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("구매량");

				entity.Property(e => e.ResetTime).HasColumnName("_resetTime");
			});

			modelBuilder.Entity<TblCashItemBuyCountBak>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCashItemBuyCountBak", "PaOperationPrivate");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.IsUserNo).HasColumnName("_isUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResetTime).HasColumnName("_resetTime");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserCharacterNo).HasColumnName("_userCharacterNo");
			});

			modelBuilder.Entity<TblChallengeReward>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblChallengeReward", "PaGamePrivate");

				entity.HasComment("도전과제 및 pc방 정액제");

				entity.Property(e => e.ChallengeKey)
					.HasColumnName("_challengeKey")
					.HasComment("도전과제 키 -DataSheet_Challenge$Challenge_Table");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("횟수");

				entity.Property(e => e.IsOverlapable)
					.HasColumnName("_isOverlapable")
					.HasComment("보상을 중복해서 줄수 있는가 여부");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");
			});

			modelBuilder.Entity<TblChangeContentsOptionUser>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblChangeConOptionUser");

				entity.ToTable("TblChangeContentsOptionUser", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCharacterCustomizing>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblCharacterCustomizing");

				entity.ToTable("TblCharacterCustomizing", "PaGamePrivate");

				entity.HasComment("캐릭터 커스터마이징");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.Author)
					.HasMaxLength(30)
					.HasColumnName("_author")
					.HasComment("원저작자");

				entity.Property(e => e.AuthorUserNo)
					.HasColumnName("_authorUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.Bone)
					.HasMaxLength(660)
					.HasColumnName("_bone")
					.HasComment("뼈대");

				entity.Property(e => e.Decoration)
					.HasMaxLength(130)
					.HasColumnName("_decoration")
					.HasComment("장식");

				entity.Property(e => e.DecorationRgb)
					.HasMaxLength(12)
					.HasColumnName("_decorationRGB");

				entity.Property(e => e.Expression)
					.HasMaxLength(2)
					.HasColumnName("_expression")
					.HasDefaultValueSql("(0x0064)")
					.HasComment("표정");

				entity.Property(e => e.Extra0).HasColumnName("_extra0");

				entity.Property(e => e.Extra1).HasColumnName("_extra1");

				entity.Property(e => e.Extra2).HasColumnName("_extra2");

				entity.Property(e => e.Extra3).HasColumnName("_extra3");

				entity.Property(e => e.HairMesh)
					.HasColumnName("_hairMesh")
					.HasComment("헤어 스타일");

				entity.Property(e => e.HeadMesh)
					.HasColumnName("_headMesh")
					.HasComment("두상 모양");

				entity.Property(e => e.IsEditable)
					.IsRequired()
					.HasColumnName("_isEditable")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Version)
					.HasColumnName("_version")
					.HasDefaultValueSql("((20))")
					.HasComment("캐릭터 커스터마이징 버전");

				entity.Property(e => e.VoiceType)
					.HasColumnName("_voiceType")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ZodiacSignKey)
					.HasColumnName("_zodiacSignKey")
					.HasDefaultValueSql("((1))")
					.HasComment("별자리 키");
			});

			modelBuilder.Entity<TblCharacterDetailInformation>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PKTblCharacterDetailInformation");

				entity.ToTable("TblCharacterDetailInformation", "PaGamePrivate");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo");

				entity.Property(e => e.CurrentBlackSpiritForm).HasColumnName("_currentBlackSpiritForm");
			});

			modelBuilder.Entity<TblCharacterExpLoan>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PkTblCharacterExpLoan");

				entity.ToTable("TblCharacterExpLoan", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.LeftExperience).HasColumnName("_leftExperience");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TotalExperience).HasColumnName("_totalExperience");
			});

			modelBuilder.Entity<TblCharacterExpLoanLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCharacterExpLoanLog", "PaGamePrivate");

				entity.Property(e => e.BeforeExperience).HasColumnName("_beforeExperience");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.DecreaseExperience).HasColumnName("_decreaseExperience");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCharacterInformation>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblCharacterInformation");

				entity.ToTable("TblCharacterInformation", "PaGamePrivate");

				entity.HasComment("유저캐릭기본정보");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.AccumulatedKillCountByLocalWar).HasColumnName("_accumulatedKillCountByLocalWar");

				entity.Property(e => e.AquiredProductSkillPoint)
					.HasColumnName("_aquiredProductSkillPoint")
					.HasComment("총 획득한 스킬포인트");

				entity.Property(e => e.AquiredSkillPoint)
					.HasColumnName("_aquiredSkillPoint")
					.HasComment("총 획득한 스킬포인트");

				entity.Property(e => e.ArrivalRegionKey)
					.HasColumnName("_arrivalRegionKey")
					.HasComment("이동될 지역 번호");

				entity.Property(e => e.ArrivalTime)
					.HasColumnType("datetime")
					.HasColumnName("_arrivalTime")
					.HasComment("도착 시간");

				entity.Property(e => e.AwakenValue)
					.HasColumnName("_awakenValue")
					.HasComment("캐릭터 각성공격력");

				entity.Property(e => e.BiddingFailCount).HasColumnName("_biddingFailCount");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasComment("캐릭터명");

				entity.Property(e => e.ClassType)
					.HasColumnName("_classType")
					.HasComment("클래스타입 0 워리어 4 엘프레인저 8 위저드 12 자이언트");

				entity.Property(e => e.CreationIndex)
					.HasColumnName("_creationIndex")
					.HasComment("계정내의 캐릭터 생성순서");

				entity.Property(e => e.CurrentFieldIndex)
					.HasColumnName("_currentFieldIndex")
					.HasComment("TFieldIndex");

				entity.Property(e => e.CurrentFieldNo)
					.HasColumnName("_currentFieldNo")
					.HasComment("TFieldNo");

				entity.Property(e => e.CurrentPositionX)
					.HasColumnName("_currentPositionX")
					.HasComment("_currentPositionX");

				entity.Property(e => e.CurrentPositionY)
					.HasColumnName("_currentPositionY")
					.HasComment("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ)
					.HasColumnName("_currentPositionZ")
					.HasComment("_currentPositionZ");

				entity.Property(e => e.DefenceValue)
					.HasColumnName("_defenceValue")
					.HasComment("캐릭터 방어력");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasComment("삭제될 날짜(NULL이면 삭제시도없는것)");

				entity.Property(e => e.DuelCharacterNo)
					.HasColumnName("_duelCharacterNo")
					.HasDefaultValueSql("((-1))")
					.HasComment("듀얼캐릭터");

				entity.Property(e => e.DuelRegionKey).HasColumnName("_duelRegionKey");

				entity.Property(e => e.EnchantFailCount)
					.HasColumnName("_enchantFailCount")
					.HasComment("인챈트실패횟수");

				entity.Property(e => e.EnchantFailCountExp)
					.HasColumnName("_enchantFailCountExp")
					.HasComment("강화 스택 경험치");

				entity.Property(e => e.EnchantPcRoomCount)
					.HasColumnName("_enchantPcRoomCount")
					.HasComment("PC방 인챈트 카운트");

				entity.Property(e => e.EnchantProtectBrokenCount)
					.HasColumnName("_enchantProtectBrokenCount")
					.HasComment("강화실패시 장비 파괴 보호");

				entity.Property(e => e.EnchantValuePackCount).HasColumnName("_enchantValuePackCount");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("레벨경험치");

				entity.Property(e => e.Hp)
					.HasColumnName("_hp")
					.HasDefaultValueSql("((1))")
					.HasComment("현재hp");

				entity.Property(e => e.InjuryHp).HasColumnName("_injuryHp");

				entity.Property(e => e.InventorySlotCount)
					.HasColumnName("_inventorySlotCount")
					.HasComment("추가 인벤 슬롯 숫자");

				entity.Property(e => e.IsEventCharacter).HasColumnName("_isEventCharacter");

				entity.Property(e => e.IsOnTypeServant)
					.HasColumnName("_isOnTypeServant")
					.HasComment("내가 올라가 있는 탈것의 타입");

				entity.Property(e => e.IsRideTypeServant)
					.HasColumnName("_isRideTypeServant")
					.HasComment("내가 탑승(인터렉션을 통한) 중인 탈것의 타입");

				entity.Property(e => e.IsSpecialCharacter)
					.HasColumnName("_isSpecialCharacter")
					.HasComment("특별 케릭터인가");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))")
					.HasComment("참인 경우에만 선택할 수 있는 캐릭임");

				entity.Property(e => e.KillRewardCount)
					.HasColumnName("_killRewardCount")
					.HasComment("킬 보상(블랙스톤)");

				entity.Property(e => e.LastBiddingItemKey).HasColumnName("_lastBiddingItemKey");

				entity.Property(e => e.LastEnterServerNo).HasColumnName("_lastEnterServerNo");

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

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))")
					.HasComment("레벨");

				entity.Property(e => e.Mp)
					.HasColumnName("_mp")
					.HasComment("현재mp");

				entity.Property(e => e.MurdererStateEndTime).HasColumnName("_murdererStateEndTime");

				entity.Property(e => e.NewFriend)
					.HasColumnName("_newFriend")
					.HasComment("내가 친구를 요청한 것중 상대가 수락한게 개수");

				entity.Property(e => e.NewMail)
					.HasColumnName("_newMail")
					.HasComment("내게 도착한 새로운 멜 개수");

				entity.Property(e => e.NewRequestFriend)
					.HasColumnName("_newRequestFriend")
					.HasComment("나에게 친구를 요청한 개수");

				entity.Property(e => e.OffenceValue)
					.HasColumnName("_offenceValue")
					.HasComment("캐릭터 공격력");

				entity.Property(e => e.OnVariousNo)
					.HasColumnName("_onVariousNo")
					.HasComment("내가 올라가 있는 탈것의 고유 번호");

				entity.Property(e => e.PcBasicCacheSeqNo)
					.HasColumnName("_pcBasicCacheSeqNo")
					.HasComment("캐릭터 정보 갱신번호");

				entity.Property(e => e.PcNonSavedCacheSeqNo).HasColumnName("_pcNonSavedCacheSeqNo");

				entity.Property(e => e.ProductSkillPointExperience)
					.HasColumnName("_productSkillPointExperience")
					.HasComment("스킬포인트경험치");

				entity.Property(e => e.QuestLevelLog)
					.HasColumnName("_questLevelLog")
					.HasComment("퀘스트 보상레벨에 따라 보상을 받아간 마지막 로그");

				entity.Property(e => e.RankPointPvp).HasColumnName("_rankPointPvp");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("캐릭터 생성일");

				entity.Property(e => e.RemainedProductSkillPoint)
					.HasColumnName("_remainedProductSkillPoint")
					.HasComment("남은 스킬포인트");

				entity.Property(e => e.RemainedSkillPoint)
					.HasColumnName("_remainedSkillPoint")
					.HasComment("남은 스킬포인트");

				entity.Property(e => e.ReservedLearningSkillKey)
					.HasColumnName("_reservedLearningSkillKey")
					.HasComment("배우려는 예약 스킬의 키값");

				entity.Property(e => e.RestoreExperience).HasColumnName("_restoreExperience");

				entity.Property(e => e.ReturnFieldIndex)
					.HasColumnName("_returnFieldIndex")
					.HasComment("TFieldIndex");

				entity.Property(e => e.ReturnFieldNo)
					.HasColumnName("_returnFieldNo")
					.HasComment("TFieldNo");

				entity.Property(e => e.ReturnPositionX)
					.HasColumnName("_returnPositionX")
					.HasComment("_returnPositionX");

				entity.Property(e => e.ReturnPositionY)
					.HasColumnName("_returnPositionY")
					.HasComment("_returnPositionY");

				entity.Property(e => e.ReturnPositionZ)
					.HasColumnName("_returnPositionZ")
					.HasComment("_returnPositionZ");

				entity.Property(e => e.RewardPoint)
					.HasColumnName("_rewardPoint")
					.HasComment("퀘스트 보상 통합 포인트");

				entity.Property(e => e.RideSeatIndex)
					.HasColumnName("_rideSeatIndex")
					.HasComment("내가 탑승(인터렉션을 통한) 중인 탈것의 시트 번호");

				entity.Property(e => e.RideVariousNo)
					.HasColumnName("_rideVariousNo")
					.HasComment("내가 탑승(인터렉션을 통한) 중인 탈것의 고유 번호");

				entity.Property(e => e.SeasonType).HasColumnName("_seasonType");

				entity.Property(e => e.SkillAwakeningCount)
					.HasColumnName("_skillAwakeningCount")
					.HasComment("일반 스킬 각성한 횟수");

				entity.Property(e => e.SkillPointExperience)
					.HasColumnName("_skillPointExperience")
					.HasComment("스킬포인트경험치");

				entity.Property(e => e.SkillPointLevel)
					.HasColumnName("_skillPointLevel")
					.HasComment("스킬포인트레벨");

				entity.Property(e => e.SlotNo)
					.HasColumnName("_slotNo")
					.HasComment("생성된 슬롯번호");

				entity.Property(e => e.Sp)
					.HasColumnName("_sp")
					.HasComment("현재sp");

				entity.Property(e => e.SuccessionSkillAwakeningCount)
					.HasColumnName("_successionSkillAwakeningCount")
					.HasComment("전승 스킬 각성한 횟수");

				entity.Property(e => e.Tendency)
					.HasColumnName("_tendency")
					.HasComment("성향");

				entity.Property(e => e.TitleKey)
					.HasColumnName("_titleKey")
					.HasComment("적용한 칭호키(0은 칭호 없음)");

				entity.Property(e => e.TotalPlayTime)
					.HasColumnName("_totalPlayTime")
					.HasComment("총 play시간(단위:분)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("캐릭을 소유한 사용자번호");

				entity.Property(e => e.VariedDirectDv)
					.HasColumnName("_variedDirectDv")
					.HasComment("증감되는 근거리Dv");

				entity.Property(e => e.VariedDirectHit)
					.HasColumnName("_variedDirectHit")
					.HasComment("증감되는 근거리Hit");

				entity.Property(e => e.VariedDirectPv)
					.HasColumnName("_variedDirectPv")
					.HasComment("증감되는 근거리Pv");

				entity.Property(e => e.VariedMagicalDv)
					.HasColumnName("_variedMagicalDv")
					.HasComment("증감되는 MagicalHit");

				entity.Property(e => e.VariedMagicalHit)
					.HasColumnName("_variedMagicalHit")
					.HasComment("증감되는 MagicalHit");

				entity.Property(e => e.VariedMagicalPv)
					.HasColumnName("_variedMagicalPv")
					.HasComment("증감되는 MagicalHit");

				entity.Property(e => e.VariedMaxHp)
					.HasColumnName("_variedMaxHp")
					.HasComment("증감되는 hp통");

				entity.Property(e => e.VariedMaxMp)
					.HasColumnName("_variedMaxMp")
					.HasComment("증감되는 mp통");

				entity.Property(e => e.VariedRangeDv)
					.HasColumnName("_variedRangeDv")
					.HasComment("증감되는 원거리Dv");

				entity.Property(e => e.VariedRangeHit)
					.HasColumnName("_variedRangeHit")
					.HasComment("증감되는 원거리Hit");

				entity.Property(e => e.VariedRangePv)
					.HasColumnName("_variedRangePv")
					.HasComment("증감되는 원거리Pv");

				entity.Property(e => e.VariedWeight)
					.HasColumnName("_variedWeight")
					.HasComment("영구적으로 늘어난 무게");

				entity.Property(e => e.WeaponSkillAwakeningCount)
					.HasColumnName("_weaponSkillAwakeningCount")
					.HasComment("각성무기 스킬 각성한 횟수");

				entity.Property(e => e.Wp)
					.HasColumnName("_wp")
					.HasComment("현재wp");
			});

			modelBuilder.Entity<TblCharacterLifeStat>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCharacterLifeStat", "PaGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.MainType).HasColumnName("_mainType");

				entity.Property(e => e.Stat).HasColumnName("_stat");

				entity.Property(e => e.SubType).HasColumnName("_subType");
			});

			modelBuilder.Entity<TblCharacterMemo>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblCharacterMemo");

				entity.ToTable("TblCharacterMemo", "PaGamePrivate");

				entity.HasComment("유저캐릭 메모");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.CurrentFindExchangeItemEnchantKey)
					.HasColumnName("_currentFindExchangeItemEnchantKey")
					.HasComment("아이템 교환 길찾기 중이던 ItemEnchantKey");

				entity.Property(e => e.CurrentQuestGroupNo)
					.HasColumnName("_currentQuestGroupNo")
					.HasComment("현재 수행중이던 퀘스트 그룹번호");

				entity.Property(e => e.CurrentQuestNo)
					.HasColumnName("_currentQuestNo")
					.HasComment("현재 수행중이던 퀘스트 번호");

				entity.Property(e => e.CurrentQuestPositionX)
					.HasColumnName("_currentQuestPositionX")
					.HasComment("현재 수행중이던 퀘스트 좌표");

				entity.Property(e => e.CurrentQuestPositionY)
					.HasColumnName("_currentQuestPositionY")
					.HasComment("현재 수행중이던 퀘스트 좌표");

				entity.Property(e => e.CurrentQuestPositionZ)
					.HasColumnName("_currentQuestPositionZ")
					.HasComment("현재 수행중이던 퀘스트 좌표");

				entity.Property(e => e.LastQuestGroupNo0)
					.HasColumnName("_lastQuestGroupNo0")
					.HasComment("마지막 수행중이던 퀘스트 그룹번호");

				entity.Property(e => e.LastQuestGroupNo1)
					.HasColumnName("_lastQuestGroupNo1")
					.HasComment("마지막-1 수행중이던 퀘스트 그룹번호");

				entity.Property(e => e.LastQuestNo0)
					.HasColumnName("_lastQuestNo0")
					.HasComment("마지막 수행중이던 퀘스트 번호");

				entity.Property(e => e.LastQuestNo1)
					.HasColumnName("_lastQuestNo1")
					.HasComment("마지막-1 수행중이던 퀘스트 번호");

				entity.Property(e => e.Memo)
					.HasMaxLength(300)
					.HasColumnName("_memo")
					.HasComment("OdbcUserMemo와 연결됨");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.UserTargetPositionX)
					.HasColumnName("_userTargetPositionX")
					.HasComment("현재 유저가 설정한 목표 좌표");

				entity.Property(e => e.UserTargetPositionY)
					.HasColumnName("_userTargetPositionY")
					.HasComment("현재 유저가 설정한 목표 좌표");

				entity.Property(e => e.UserTargetPositionZ)
					.HasColumnName("_userTargetPositionZ")
					.HasComment("현재 유저가 설정한 목표 좌표");
			});

			modelBuilder.Entity<TblCharacterNameModStr>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCharacterNameModStr", "PaWebGamePrivate");

				entity.Property(e => e.Idx).HasColumnName("_idx");

				entity.Property(e => e.Str)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_str")
					.IsFixedLength();
			});

			modelBuilder.Entity<TblCharacterSpecialInformation>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PkTblCharacterSpecialInformation");

				entity.ToTable("TblCharacterSpecialInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param10).HasColumnName("_param10");

				entity.Property(e => e.Param11).HasColumnName("_param11");

				entity.Property(e => e.Param12).HasColumnName("_param12");

				entity.Property(e => e.Param13).HasColumnName("_param13");

				entity.Property(e => e.Param14).HasColumnName("_param14");

				entity.Property(e => e.Param15).HasColumnName("_param15");

				entity.Property(e => e.Param16).HasColumnName("_param16");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.Param7).HasColumnName("_param7");

				entity.Property(e => e.Param8).HasColumnName("_param8");

				entity.Property(e => e.Param9).HasColumnName("_param9");
			});

			modelBuilder.Entity<TblCharacterUicustomizing>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblCharacterUICustomizing");

				entity.ToTable("TblCharacterUICustomizing", "PaGamePrivate");

				entity.HasComment("유저 캐릭을 위한 UI Customizing정보");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.QuestSelectType)
					.HasMaxLength(18)
					.IsUnicode(false)
					.HasColumnName("_questSelectType")
					.HasDefaultValueSql("('')")
					.HasComment("퀘스트 선택 타입");

				entity.Property(e => e.QuestSerializedData)
					.HasMaxLength(300)
					.IsUnicode(false)
					.HasColumnName("_questSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("퀘스트 데이터");

				entity.Property(e => e.QuestSortType)
					.HasMaxLength(9)
					.IsUnicode(false)
					.HasColumnName("_questSortType")
					.HasDefaultValueSql("('')")
					.HasComment("퀘스트 정렬 타입");

				entity.Property(e => e.QuickSlotSerializedData)
					.HasMaxLength(756)
					.IsUnicode(false)
					.HasColumnName("_quickSlotSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("퀵슬롯 데이터");
			});

			modelBuilder.Entity<TblChatBlockByUser>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblChatBlockByUser");

				entity.ToTable("TblChatBlockByUser", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate");

				entity.Property(e => e.Point).HasColumnName("_point");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblChatBlockListByUser>(entity =>
			{
				entity.HasKey(e => new { e.FromUserNo, e.ToUserNo })
					.HasName("PkTblChatBlockListByUser")
					.IsClustered(false);

				entity.ToTable("TblChatBlockListByUser", "PaGamePrivate");

				entity.Property(e => e.FromUserNo).HasColumnName("_fromUserNo");

				entity.Property(e => e.ToUserNo).HasColumnName("_toUserNo");

				entity.Property(e => e.LastDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastDate");
			});

			modelBuilder.Entity<TblCheckItemForRemoveCharacter>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PkTblCheckItemForRemoveCharacter")
					.IsClustered(false);

				entity.ToTable("TblCheckItemForRemoveCharacter", "PaGamePrivate");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblClearedBattlePass>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Key })
					.HasName("PKTblClearedBattlePass");

				entity.ToTable("TblClearedBattlePass", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Key).HasColumnName("_key");

				entity.Property(e => e.BasicItemDate)
					.HasColumnType("datetime")
					.HasColumnName("_basicItemDate");

				entity.Property(e => e.PremiumItemDate)
					.HasColumnType("datetime")
					.HasColumnName("_premiumItemDate");

				entity.Property(e => e.SeasonKey).HasColumnName("_seasonKey");
			});

			modelBuilder.Entity<TblClearedNewQuest>(entity =>
			{
				entity.HasKey(e => new { e.UserCharacterNo, e.IsUserBaseQuest, e.QuestGroupNo, e.QuestNo })
					.HasName("PkTblClearedNewQuest")
					.IsClustered(false);

				entity.ToTable("TblClearedNewQuest", "PaGamePrivate");

				entity.HasComment("퀘스트 완료 목록");

				entity.Property(e => e.UserCharacterNo)
					.HasColumnName("_userCharacterNo")
					.HasComment("유저캐릭터번호");

				entity.Property(e => e.IsUserBaseQuest)
					.HasColumnName("_isUserBaseQuest")
					.HasComment("1이면 유저 0이면 캐릭터 기반");

				entity.Property(e => e.QuestGroupNo)
					.HasColumnName("_questGroupNo")
					.HasComment("_questGroupNo");

				entity.Property(e => e.QuestNo)
					.HasColumnName("_questNo")
					.HasComment("퀘스트번호");

				entity.Property(e => e.ClearedTime)
					.HasColumnType("datetime")
					.HasColumnName("_clearedTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("쾌스트 완료 시간");

				entity.Property(e => e.IsHideQuestCount).HasColumnName("_isHideQuestCount");

				entity.Property(e => e.ResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_resetTime")
					.HasComment("반복 퀘스트일 경우 초기화될 시간");
			});

			modelBuilder.Entity<TblClearedQuestList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblClearedQuestList", "PaOperationPrivate");

				entity.Property(e => e.ClassName)
					.HasMaxLength(30)
					.HasColumnName("_className");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");
			});

			modelBuilder.Entity<TblCommonBoardReport>(entity =>
			{
				entity.HasKey(e => new { e.BoardType, e.BoardNo, e.UserNo })
					.HasName("PKTblCommonBoardReport");

				entity.ToTable("TblCommonBoardReport", "PaWebGamePrivate");

				entity.Property(e => e.BoardType).HasColumnName("_boardType");

				entity.Property(e => e.BoardNo).HasColumnName("_boardNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.BlindType).HasColumnName("_blindType");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.RegDate)
					.HasColumnType("datetime")
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ReportType)
					.HasColumnName("_reportType")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<TblCommonContentsScoreRecord>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo, e.ContentsType, e.Mode, e.Stage })
					.HasName("PkTblCommonContentsScoreRecord")
					.IsClustered(false);

				entity.ToTable("TblCommonContentsScoreRecord", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ContentsType).HasColumnName("_contentsType");

				entity.Property(e => e.Mode).HasColumnName("_mode");

				entity.Property(e => e.Stage).HasColumnName("_stage");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Score).HasColumnName("_score");
			});

			modelBuilder.Entity<TblCommonSkillNo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Idx })
					.HasName("PKTblCommonSkillNo")
					.IsClustered(false);

				entity.ToTable("TblCommonSkillNo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Idx).HasColumnName("_idx");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");
			});

			modelBuilder.Entity<TblCompletedChallenge>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ChallengeKey })
					.HasName("PkTblCompletedChallenge")
					.IsClustered(false);

				entity.ToTable("TblCompletedChallenge", "PaGamePrivate");

				entity.HasComment("완료-도전과제 및 pc방 정액제");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.ChallengeKey)
					.HasColumnName("_challengeKey")
					.HasComment("도전과제 키 -DataSheet_Challenge$Challenge_Table");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_resetTime")
					.HasComment("초기화 시간");
			});

			modelBuilder.Entity<TblCompletedGuildBattle>(entity =>
			{
				entity.HasKey(e => e.BattleNo)
					.HasName("PkTblCompletedGuildBattle");

				entity.ToTable("TblCompletedGuildBattle", "PaGamePrivate");

				entity.HasComment("결전 종료 정보");

				entity.Property(e => e.BattleNo)
					.HasColumnName("_battleNo")
					.HasComment("결전 고유 번호");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("종료 시간");

				entity.Property(e => e.LoseGuildNo)
					.HasColumnName("_loseGuildNo")
					.HasComment("패배 길드 번호");

				entity.Property(e => e.Season)
					.HasColumnName("_season")
					.HasComment("시즌");

				entity.Property(e => e.State)
					.HasColumnName("_state")
					.HasComment("해당 결전 상금");

				entity.Property(e => e.WinGuildNo)
					.HasColumnName("_winGuildNo")
					.HasComment("이긴 길드 번호");
			});

			modelBuilder.Entity<TblCompletedGuildDuel>(entity =>
			{
				entity.HasKey(e => e.DuelNo)
					.HasName("PkTblCompletedGuildDuel");

				entity.ToTable("TblCompletedGuildDuel", "PaGamePrivate");

				entity.HasComment("길드 결전 정보");

				entity.Property(e => e.DuelNo)
					.ValueGeneratedNever()
					.HasColumnName("_duelNo")
					.HasComment("길드 결전 번호");

				entity.Property(e => e.AcceptGuildKill)
					.HasColumnName("_acceptGuildKill")
					.HasComment("수락한 길드가 죽인 횟수");

				entity.Property(e => e.AcceptGuildNo)
					.HasColumnName("_acceptGuildNo")
					.HasComment("결전 수락한 길드 번호");

				entity.Property(e => e.Deadline)
					.HasColumnType("datetime")
					.HasColumnName("_deadline")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("마감 시간");

				entity.Property(e => e.DeclareGuildKill)
					.HasColumnName("_declareGuildKill")
					.HasComment("선포한 길드가 죽인 횟수");

				entity.Property(e => e.DeclareGuildNo)
					.HasColumnName("_declareGuildNo")
					.HasComment("결전 선포한 길드 번호");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("종료 시간");

				entity.Property(e => e.Prize)
					.HasColumnName("_prize")
					.HasComment("상금");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TargetKill)
					.HasColumnName("_targetKill")
					.HasComment("목표 킬수");
			});

			modelBuilder.Entity<TblCompletedPersonalBattle>(entity =>
			{
				entity.HasKey(e => e.BattleNo)
					.HasName("PkTblCompletedPersonalBattle");

				entity.ToTable("TblCompletedPersonalBattle", "PaGamePrivate");

				entity.HasComment("결전 종료 정보");

				entity.Property(e => e.BattleNo)
					.HasColumnName("_battleNo")
					.HasComment("결전 고유 번호");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("종료 시간");

				entity.Property(e => e.LoseTeamNo)
					.HasColumnName("_loseTeamNo")
					.HasComment("패배 팀 번호");

				entity.Property(e => e.Season)
					.HasColumnName("_season")
					.HasComment("시즌");

				entity.Property(e => e.State)
					.HasColumnName("_state")
					.HasComment("결전 결과");

				entity.Property(e => e.WinTeamNo)
					.HasColumnName("_winTeamNo")
					.HasComment("이긴 팀 번호");
			});

			modelBuilder.Entity<TblCompositionNote>(entity =>
			{
				entity.HasKey(e => e.NoteNo)
					.HasName("PKTblCompositionNotes")
					.IsClustered(false);

				entity.ToTable("TblCompositionNotes", "PaWebGamePrivate");

				entity.Property(e => e.NoteNo).HasColumnName("_noteNo");

				entity.Property(e => e.DownloadCount).HasColumnName("_downloadCount");

				entity.Property(e => e.HeartCount).HasColumnName("_heartCount");

				entity.Property(e => e.Instrument)
					.HasMaxLength(100)
					.IsUnicode(false)
					.HasColumnName("_instrument");

				entity.Property(e => e.IsAdventurer).HasColumnName("_isAdventurer");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.IsDownload).HasColumnName("_isDownload");

				entity.Property(e => e.IsEdit)
					.IsRequired()
					.HasColumnName("_isEdit")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.MusicOwn)
					.HasMaxLength(60)
					.HasColumnName("_musicOwn");

				entity.Property(e => e.MusicPath)
					.HasMaxLength(500)
					.HasColumnName("_musicPath");

				entity.Property(e => e.MusicTime).HasColumnName("_musicTime");

				entity.Property(e => e.MusicTitle)
					.HasMaxLength(300)
					.HasColumnName("_musicTitle");

				entity.Property(e => e.NoteContent)
					.HasMaxLength(3000)
					.HasColumnName("_noteContent");

				entity.Property(e => e.NoteTitle)
					.HasMaxLength(100)
					.HasColumnName("_noteTitle");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.Rank)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_rank");

				entity.Property(e => e.RegDate)
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ReplyCount).HasColumnName("_replyCount");

				entity.Property(e => e.StarCount).HasColumnName("_starCount");

				entity.Property(e => e.UpdDate)
					.HasColumnName("_updDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(60)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCompositionNotesCount>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCompositionNotesCount", "PaWebGamePrivate");

				entity.Property(e => e.Flag).HasColumnName("_flag");

				entity.Property(e => e.NoteNo).HasColumnName("_noteNo");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCompositionNotesReply>(entity =>
			{
				entity.HasKey(e => e.ReplyNo)
					.HasName("PKTblCompositionNotesReply")
					.IsClustered(false);

				entity.ToTable("TblCompositionNotesReply", "PaWebGamePrivate");

				entity.Property(e => e.ReplyNo).HasColumnName("_replyNo");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.NoteNo).HasColumnName("_noteNo");

				entity.Property(e => e.RegDate)
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ReplyContent)
					.HasMaxLength(500)
					.HasColumnName("_replyContent");

				entity.Property(e => e.ReplyOrder).HasColumnName("_replyOrder");

				entity.Property(e => e.UpdDate)
					.HasColumnName("_updDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(60)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblConsignmentSale>(entity =>
			{
				entity.HasKey(e => e.ConsignmentNo)
					.HasName("PkTblConsignmentSale");

				entity.ToTable("TblConsignmentSale", "PaGamePrivate");

				entity.HasComment("위탁 판매 정보");

				entity.Property(e => e.ConsignmentNo)
					.HasColumnName("_consignmentNo")
					.HasComment("_consignmentNo");

				entity.Property(e => e.CommissionRate)
					.HasColumnName("_commissionRate")
					.HasComment("수수료(등록시 저장)");

				entity.Property(e => e.ExpireTime)
					.HasColumnName("_expireTime")
					.HasComment("판매 종료일");

				entity.Property(e => e.GatherMoney)
					.HasColumnName("_gatherMoney")
					.HasComment("판매후 모아진 돈(수수료 뺀 금액)");

				entity.Property(e => e.HouseholdNo)
					.HasColumnName("_householdNo")
					.HasComment("_householdNo");

				entity.Property(e => e.InstallationNo)
					.HasColumnName("_installationNo")
					.HasComment("_installationNo");

				entity.Property(e => e.IsStackable)
					.HasColumnName("_isStackable")
					.HasComment("_isStackable");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("_itemKey");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("_itemNo");

				entity.Property(e => e.OwnerCharacterNo)
					.HasColumnName("_ownerCharacterNo")
					.HasComment("_ownerCharacterNo");

				entity.Property(e => e.PricePerOne)
					.HasColumnName("_pricePerOne")
					.HasComment("개당 가격");

				entity.Property(e => e.RegisterMoney)
					.HasColumnName("_registerMoney")
					.HasComment("등록비");

				entity.Property(e => e.SaleEnd)
					.HasColumnName("_saleEnd")
					.HasComment("아이템이 모두팔리면 1");
			});

			modelBuilder.Entity<TblContentsSeason>(entity =>
			{
				entity.HasKey(e => new { e.ContentsType, e.Season })
					.HasName("PkTblContentsSeason");

				entity.ToTable("TblContentsSeason", "PaGamePrivate");

				entity.Property(e => e.ContentsType).HasColumnName("_contentsType");

				entity.Property(e => e.Season)
					.HasColumnName("_season")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblCoolTime>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCoolTime", "PaGamePrivate");

				entity.HasComment("쿨타임을 저장하기 위한 테이블");

				entity.Property(e => e.IsExpiredTime).HasColumnName("_isExpiredTime");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("skillType 에 따라 캐릭터No, 길드 No로 사용된다.");

				entity.Property(e => e.RemainOrExpiredtime).HasColumnName("_remainOrExpiredtime");

				entity.Property(e => e.ReuseGroup)
					.HasColumnName("_reuseGroup")
					.HasComment("재사용그룹의 넘버");

				entity.Property(e => e.SkillLevel)
					.HasColumnName("_skillLevel")
					.HasComment("재사용 대기중인 스킬의 레벨");

				entity.Property(e => e.SkillNo)
					.HasColumnName("_skillNo")
					.HasComment("재사용 대기중인 스킬의 넘버");

				entity.Property(e => e.SkillType)
					.HasColumnName("_skillType")
					.HasComment(" pc 스킬의 쿨타임인지 길드 스킬의 쿨타임인지 구분하는 타입 ( 0 = PC, 1= guild)");
			});

			modelBuilder.Entity<TblCopyUserDate>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCopyUserDate", "PaWebGamePrivate");

				entity.Property(e => e.LiveUserNo).HasColumnName("_liveUserNo");

				entity.Property(e => e.Nation)
					.HasMaxLength(4)
					.HasColumnName("_nation");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblCoupon>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CouponNo })
					.HasName("PkTblCoupon")
					.IsClustered(false);

				entity.ToTable("TblCoupon", "PaGamePrivate");

				entity.HasComment("쿠폰 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.CouponNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_couponNo")
					.HasComment("쿠폰번호");

				entity.Property(e => e.CouponKey)
					.HasColumnName("_couponKey")
					.HasComment("쿠폰키");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("쿠폰 만료 일시");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.State)
					.HasColumnName("_state")
					.HasComment("쿠폰 상태");

				entity.Property(e => e.UseDate)
					.HasColumnType("datetime")
					.HasColumnName("_useDate")
					.HasComment("쿠폰 사용 일시");
			});

			modelBuilder.Entity<TblCouponTargetUser>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCouponTargetUser", "PaOperationPrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCrew>(entity =>
			{
				entity.HasKey(e => e.CrewNo)
					.HasName("PkTblCrew");

				entity.ToTable("TblCrew", "PaGamePrivate");

				entity.Property(e => e.CrewNo).HasColumnName("_crewNo");

				entity.Property(e => e.CrewName)
					.HasMaxLength(30)
					.HasColumnName("_crewName");

				entity.Property(e => e.CrewNotice)
					.HasMaxLength(300)
					.HasColumnName("_crewNotice");

				entity.Property(e => e.LoseCount).HasColumnName("_loseCount");

				entity.Property(e => e.MasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_masterUserNickname");

				entity.Property(e => e.MasterUserNo).HasColumnName("_masterUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.WinCount).HasColumnName("_winCount");
			});

			modelBuilder.Entity<TblCrewMember>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblCrewMember")
					.IsClustered(false);

				entity.ToTable("TblCrewMember", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.CrewNo).HasColumnName("_crewNo");

				entity.Property(e => e.Grade).HasColumnName("_grade");

				entity.Property(e => e.LoseCount).HasColumnName("_loseCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.WinCount).HasColumnName("_winCount");
			});

			modelBuilder.Entity<TblCustomGuildWarHistory>(entity =>
			{
				entity.ToTable("TblCustomGuildWarHistory");

				entity.Property(e => e.Id).HasColumnName("_id");

				entity.Property(e => e.Death)
					.HasColumnName("_death")
					.HasComment("사망수");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드 번호");

				entity.Property(e => e.Kill)
					.HasColumnName("_kill")
					.HasComment("킬수");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("전쟁 시작 시간");

				entity.Property(e => e.TargetGuildNo)
					.HasColumnName("_targetGuildNo")
					.HasComment("전쟁 선포한 길드 번호");
			});

			modelBuilder.Entity<TblCustomName>(entity =>
			{
				entity.HasKey(e => new { e.Type, e.Param })
					.HasName("PkTblCustomName");

				entity.ToTable("TblCustomName", "PaGamePrivate");

				entity.HasComment("커스터마이징 된 이름 TABLE");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("타입");

				entity.Property(e => e.Param)
					.HasColumnName("_param")
					.HasComment("파라메터");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name")
					.HasComment("유저가 작성한 이름");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("생성/변경일");
			});

			modelBuilder.Entity<TblCustomizedKey>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblCustomizedKey");

				entity.ToTable("TblCustomizedKey", "PaGamePrivate");

				entity.HasComment("유저 캐릭을 위한 key 설정 정보");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.KeyActionInputSerializedData)
					.HasMaxLength(400)
					.IsUnicode(false)
					.HasColumnName("_keyActionInputSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("키보드 ActionInputType 설정 데이터");

				entity.Property(e => e.KeyUiInputSerializedData)
					.HasMaxLength(240)
					.IsUnicode(false)
					.HasColumnName("_keyUiInputSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("키보드 UiInputType 설정 데이터");

				entity.Property(e => e.PadActionInputSerializedData)
					.HasMaxLength(500)
					.IsUnicode(false)
					.HasColumnName("_padActionInputSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("패드 ActionInputType 설정 데이터");

				entity.Property(e => e.PadFunctionInput1)
					.HasColumnName("_padFunctionInput1")
					.HasComment("패드 기능키 1");

				entity.Property(e => e.PadFunctionInput2)
					.HasColumnName("_padFunctionInput2")
					.HasComment("패드 기능키 2");

				entity.Property(e => e.PadUiInputSerializedData)
					.HasMaxLength(300)
					.IsUnicode(false)
					.HasColumnName("_padUiInputSerializedData")
					.HasDefaultValueSql("('')")
					.HasComment("패드 UiInputType 설정 데이터");
			});

			modelBuilder.Entity<TblCustomizingDownloadLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingDownloadLog", "PaWebGamePrivate");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");

				entity.Property(e => e.DownloadDate)
					.HasColumnType("datetime")
					.HasColumnName("_downloadDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCustomizingGallery>(entity =>
			{
				entity.HasKey(e => e.CustomizingNo)
					.HasName("PkTblCustomizingGallery");

				entity.ToTable("TblCustomizingGallery", "PaWebGamePrivate");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");

				entity.Property(e => e.Author)
					.HasMaxLength(30)
					.HasColumnName("_author");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CommentCount).HasColumnName("_commentCount");

				entity.Property(e => e.CrossPlatform)
					.HasMaxLength(8)
					.HasColumnName("_crossPlatform");

				entity.Property(e => e.CustomizingCategoryCode).HasColumnName("_customizingCategoryCode");

				entity.Property(e => e.CustomizingDescription)
					.HasMaxLength(4000)
					.HasColumnName("_customizingDescription");

				entity.Property(e => e.CustomizingFile)
					.HasMaxLength(200)
					.HasColumnName("_customizingFile");

				entity.Property(e => e.CustomizingImage1)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage1");

				entity.Property(e => e.CustomizingImage2)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage2");

				entity.Property(e => e.CustomizingTitle)
					.HasMaxLength(50)
					.HasColumnName("_customizingTitle");

				entity.Property(e => e.DownloadCount).HasColumnName("_downloadCount");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.IsEdit)
					.IsRequired()
					.HasColumnName("_isEdit")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsMine).HasColumnName("_isMine");

				entity.Property(e => e.IsRandom).HasColumnName("_isRandom");

				entity.Property(e => e.LikeCount).HasColumnName("_likeCount");

				entity.Property(e => e.Regdate)
					.HasColumnType("datetime")
					.HasColumnName("_regdate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ViewCount).HasColumnName("_viewCount");
			});

			modelBuilder.Entity<TblCustomizingGalleryAuthRank>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingGalleryAuthRank", "PaWebGamePrivate");

				entity.Property(e => e.Author)
					.HasMaxLength(30)
					.HasColumnName("_author");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CommentCount).HasColumnName("_commentCount");

				entity.Property(e => e.CrossPlatform)
					.HasMaxLength(8)
					.HasColumnName("_crossPlatform");

				entity.Property(e => e.CustomizingFile)
					.HasMaxLength(200)
					.HasColumnName("_customizingFile");

				entity.Property(e => e.CustomizingImage1)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage1");

				entity.Property(e => e.CustomizingImage2)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage2");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");

				entity.Property(e => e.DayType).HasColumnName("_dayType");

				entity.Property(e => e.DownTotal).HasColumnName("downTotal");

				entity.Property(e => e.DownloadCount).HasColumnName("_downloadCount");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.IsMine).HasColumnName("_isMine");

				entity.Property(e => e.LikeCount).HasColumnName("_likeCount");

				entity.Property(e => e.Ranking).HasColumnName("_ranking");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCustomizingGalleryAuthRankSnap>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingGalleryAuthRank_Snap", "PaWebGamePrivate");

				entity.Property(e => e.Author)
					.HasMaxLength(30)
					.HasColumnName("_author");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CommentCount).HasColumnName("_commentCount");

				entity.Property(e => e.CrossPlatform)
					.HasMaxLength(8)
					.HasColumnName("_crossPlatform");

				entity.Property(e => e.CustomizingFile)
					.HasMaxLength(200)
					.HasColumnName("_customizingFile");

				entity.Property(e => e.CustomizingImage1)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage1");

				entity.Property(e => e.CustomizingImage2)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage2");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");

				entity.Property(e => e.DayType).HasColumnName("_dayType");

				entity.Property(e => e.DownTotal).HasColumnName("downTotal");

				entity.Property(e => e.DownloadCount).HasColumnName("_downloadCount");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.IsMine).HasColumnName("_isMine");

				entity.Property(e => e.LikeCount).HasColumnName("_likeCount");

				entity.Property(e => e.Ranking).HasColumnName("_ranking");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCustomizingGalleryAuthRankTemp>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingGalleryAuthRank_Temp", "PaWebGamePrivate");

				entity.Property(e => e.Author)
					.HasMaxLength(30)
					.HasColumnName("_author");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CommentCount).HasColumnName("_commentCount");

				entity.Property(e => e.CrossPlatform)
					.HasMaxLength(8)
					.HasColumnName("_crossPlatform");

				entity.Property(e => e.CustomizingFile)
					.HasMaxLength(200)
					.HasColumnName("_customizingFile");

				entity.Property(e => e.CustomizingImage1)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage1");

				entity.Property(e => e.CustomizingImage2)
					.HasMaxLength(200)
					.HasColumnName("_customizingImage2");

				entity.Property(e => e.CustomizingNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_customizingNo");

				entity.Property(e => e.DownloadCount).HasColumnName("_downloadCount");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.IsMine).HasColumnName("_isMine");

				entity.Property(e => e.LikeCount).HasColumnName("_likeCount");

				entity.Property(e => e.Regdate)
					.HasColumnType("datetime")
					.HasColumnName("_regdate");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCustomizingGalleryBlind>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingGalleryBlind", "PaWebGamePrivate");

				entity.Property(e => e.BlindDate)
					.HasColumnType("datetime")
					.HasColumnName("_blindDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.BlindUserNo).HasColumnName("_blindUserNo");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");
			});

			modelBuilder.Entity<TblCustomizingGalleryComment>(entity =>
			{
				entity.HasKey(e => e.CustomizingCommentNo)
					.HasName("PkTblCustomizingGalleryComment");

				entity.ToTable("TblCustomizingGalleryComment", "PaWebGamePrivate");

				entity.Property(e => e.CustomizingCommentNo).HasColumnName("_customizingCommentNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CommentRegdate)
					.HasColumnType("datetime")
					.HasColumnName("_CommentRegdate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.CommentReportCount).HasColumnName("_commentReportCount");

				entity.Property(e => e.CommentUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_CommentUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.CustomizingComment)
					.HasMaxLength(500)
					.HasColumnName("_customizingComment");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCustomizingLikeLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingLikeLog", "PaWebGamePrivate");

				entity.Property(e => e.CustomizingNo).HasColumnName("_customizingNo");

				entity.Property(e => e.LikeDate)
					.HasColumnType("datetime")
					.HasColumnName("_LikeDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblCustomizingReportLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblCustomizingReportLog", "PaWebGamePrivate");

				entity.Property(e => e.BlindType).HasColumnName("_blindType");

				entity.Property(e => e.CustomizingCommentNo).HasColumnName("_customizingCommentNo");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.ReportDate)
					.HasColumnType("datetime")
					.HasColumnName("_reportDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblDailyBattlePassPoint>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Type })
					.HasName("PKTblDailyBattlePassPoint");

				entity.ToTable("TblDailyBattlePassPoint", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.Point).HasColumnName("_point");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblDailyPlayInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.InstanceFieldKey })
					.HasName("PKTblDailyPlayInfo");

				entity.ToTable("TblDailyPlayInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.NextResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_nextResetTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");
			});

			modelBuilder.Entity<TblDeletedCharacterInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblDeletedCharacterInformation", "PaGamePrivate");

				entity.Property(e => e.AccumulatedKillCountByLocalWar).HasColumnName("_accumulatedKillCountByLocalWar");

				entity.Property(e => e.AquiredProductSkillPoint).HasColumnName("_aquiredProductSkillPoint");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.ArrivalRegionKey).HasColumnName("_arrivalRegionKey");

				entity.Property(e => e.ArrivalTime)
					.HasColumnType("datetime")
					.HasColumnName("_arrivalTime");

				entity.Property(e => e.BiddingFailCount).HasColumnName("_biddingFailCount");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CreationIndex).HasColumnName("_creationIndex");

				entity.Property(e => e.CurrentFieldIndex).HasColumnName("_currentFieldIndex");

				entity.Property(e => e.CurrentFieldNo).HasColumnName("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX).HasColumnName("_currentPositionX");

				entity.Property(e => e.CurrentPositionY).HasColumnName("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ).HasColumnName("_currentPositionZ");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.EnchantFailCount).HasColumnName("_enchantFailCount");

				entity.Property(e => e.EnchantPcRoomCount).HasColumnName("_enchantPcRoomCount");

				entity.Property(e => e.EnchantProtectBrokenCount).HasColumnName("_enchantProtectBrokenCount");

				entity.Property(e => e.EnchantValuePackCount).HasColumnName("_enchantValuePackCount");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.Hp).HasColumnName("_hp");

				entity.Property(e => e.InventorySlotCount).HasColumnName("_inventorySlotCount");

				entity.Property(e => e.IsOnTypeServant).HasColumnName("_isOnTypeServant");

				entity.Property(e => e.IsRideTypeServant).HasColumnName("_isRideTypeServant");

				entity.Property(e => e.IsSpecialCharacter).HasColumnName("_isSpecialCharacter");

				entity.Property(e => e.IsValid).HasColumnName("_isValid");

				entity.Property(e => e.KillRewardCount).HasColumnName("_killRewardCount");

				entity.Property(e => e.LastBiddingItemKey).HasColumnName("_lastBiddingItemKey");

				entity.Property(e => e.LastLoginTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLoginTime");

				entity.Property(e => e.LastLogoutTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastLogoutTime");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.Mp).HasColumnName("_mp");

				entity.Property(e => e.MurdererStateEndTime).HasColumnName("_murdererStateEndTime");

				entity.Property(e => e.NewFriend).HasColumnName("_newFriend");

				entity.Property(e => e.NewMail).HasColumnName("_newMail");

				entity.Property(e => e.NewRequestFriend).HasColumnName("_newRequestFriend");

				entity.Property(e => e.OnVariousNo).HasColumnName("_onVariousNo");

				entity.Property(e => e.PcBasicCacheSeqNo).HasColumnName("_pcBasicCacheSeqNo");

				entity.Property(e => e.PcNonSavedCacheSeqNo).HasColumnName("_pcNonSavedCacheSeqNo");

				entity.Property(e => e.ProductSkillPointExperience).HasColumnName("_productSkillPointExperience");

				entity.Property(e => e.QuestLevelLog).HasColumnName("_questLevelLog");

				entity.Property(e => e.RankPointPvp).HasColumnName("_rankPointPvp");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedProductSkillPoint).HasColumnName("_remainedProductSkillPoint");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.ReservedLearningSkillKey).HasColumnName("_reservedLearningSkillKey");

				entity.Property(e => e.RestoreExperience).HasColumnName("_restoreExperience");

				entity.Property(e => e.ReturnFieldIndex).HasColumnName("_returnFieldIndex");

				entity.Property(e => e.ReturnFieldNo).HasColumnName("_returnFieldNo");

				entity.Property(e => e.ReturnPositionX).HasColumnName("_returnPositionX");

				entity.Property(e => e.ReturnPositionY).HasColumnName("_returnPositionY");

				entity.Property(e => e.ReturnPositionZ).HasColumnName("_returnPositionZ");

				entity.Property(e => e.RewardPoint).HasColumnName("_rewardPoint");

				entity.Property(e => e.RideSeatIndex).HasColumnName("_rideSeatIndex");

				entity.Property(e => e.RideVariousNo).HasColumnName("_rideVariousNo");

				entity.Property(e => e.SeasonType).HasColumnName("_seasonType");

				entity.Property(e => e.SkillAwakeningCount).HasColumnName("_skillAwakeningCount");

				entity.Property(e => e.SkillPointExperience).HasColumnName("_skillPointExperience");

				entity.Property(e => e.SkillPointLevel).HasColumnName("_skillPointLevel");

				entity.Property(e => e.SlotNo).HasColumnName("_slotNo");

				entity.Property(e => e.Sp).HasColumnName("_sp");

				entity.Property(e => e.SuccessionSkillAwakeningCount).HasColumnName("_successionSkillAwakeningCount");

				entity.Property(e => e.Tendency).HasColumnName("_tendency");

				entity.Property(e => e.TitleKey).HasColumnName("_titleKey");

				entity.Property(e => e.TotalPlayTime).HasColumnName("_totalPlayTime");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariedDirectDv).HasColumnName("_variedDirectDv");

				entity.Property(e => e.VariedDirectHit).HasColumnName("_variedDirectHit");

				entity.Property(e => e.VariedDirectPv).HasColumnName("_variedDirectPv");

				entity.Property(e => e.VariedMagicalDv).HasColumnName("_variedMagicalDv");

				entity.Property(e => e.VariedMagicalHit).HasColumnName("_variedMagicalHit");

				entity.Property(e => e.VariedMagicalPv).HasColumnName("_variedMagicalPv");

				entity.Property(e => e.VariedMaxHp).HasColumnName("_variedMaxHp");

				entity.Property(e => e.VariedMaxMp).HasColumnName("_variedMaxMp");

				entity.Property(e => e.VariedRangeDv).HasColumnName("_variedRangeDv");

				entity.Property(e => e.VariedRangeHit).HasColumnName("_variedRangeHit");

				entity.Property(e => e.VariedRangePv).HasColumnName("_variedRangePv");

				entity.Property(e => e.VariedWeight).HasColumnName("_variedWeight");

				entity.Property(e => e.WeaponSkillAwakeningCount).HasColumnName("_weaponSkillAwakeningCount");

				entity.Property(e => e.Wp).HasColumnName("_wp");
			});

			modelBuilder.Entity<TblDeletedItemRepository>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblDeletedItemRepository")
					.IsClustered(false);

				entity.ToTable("TblDeletedItemRepository", "PaGamePrivate");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.BuyingPrice).HasColumnName("_buyingPrice");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.DyeingList)
					.HasMaxLength(24)
					.HasColumnName("_dyeingList");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.IsExpirationDyeing).HasColumnName("_isExpirationDyeing");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.IsSeized).HasColumnName("_isSeized");

				entity.Property(e => e.IsValid).HasColumnName("_isValid");

				entity.Property(e => e.IsVested).HasColumnName("_isVested");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OldItemNo).HasColumnName("_oldItemNo");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.ProductionRegionKey).HasColumnName("_productionRegionKey");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RestoreType).HasColumnName("_restoreType");

				entity.Property(e => e.VariableDate)
					.HasColumnType("datetime")
					.HasColumnName("_variableDate");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblDeletedNameExchange>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblDeletedNameExchange", "PaOperationPublic");

				entity.Property(e => e.Character1Name)
					.HasMaxLength(30)
					.HasColumnName("_character1Name");

				entity.Property(e => e.Character1No).HasColumnName("_character1No");

				entity.Property(e => e.Character2Name)
					.HasMaxLength(30)
					.HasColumnName("_character2Name");

				entity.Property(e => e.Character2No).HasColumnName("_character2No");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.No)
					.ValueGeneratedOnAdd()
					.HasColumnName("_no");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");
			});

			modelBuilder.Entity<TblDeletedPet>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblDeletedPet", "PaGamePrivate");

				entity.Property(e => e.ActionIndex).HasColumnName("_actionIndex");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.Hungry).HasColumnName("_hungry");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.LearnedEquipSkillFlag).HasColumnName("_learnedEquipSkillFlag");

				entity.Property(e => e.LearnedFlag).HasColumnName("_learnedFlag");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.Lovely).HasColumnName("_lovely");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name");

				entity.Property(e => e.OwnerUserNo).HasColumnName("_ownerUserNo");

				entity.Property(e => e.PetLootingType).HasColumnName("_petLootingType");

				entity.Property(e => e.PetNo).HasColumnName("_petNo");

				entity.Property(e => e.PetState).HasColumnName("_petState");

				entity.Property(e => e.PetType).HasColumnName("_petType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UpgradeStackCount).HasColumnName("_upgradeStackCount");
			});

			modelBuilder.Entity<TblDeliveryRepository>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblDeliveryRepository");

				entity.ToTable("TblDeliveryRepository", "PaGamePrivate");

				entity.HasComment("아이템 운송 정보");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo")
					.HasComment("아이템 번호");

				entity.Property(e => e.DelivererNo)
					.HasColumnName("_delivererNo")
					.HasComment("운송하는 객체 번호");

				entity.Property(e => e.DelivererType)
					.HasColumnName("_delivererType")
					.HasComment("운송하는 객체 타입");

				entity.Property(e => e.DeliveryRoute)
					.HasColumnName("_deliveryRoute")
					.HasComment("운송 노선 번호");

				entity.Property(e => e.From)
					.HasColumnName("_from")
					.HasComment("출발 지역 번호");

				entity.Property(e => e.Progress)
					.HasColumnName("_progress")
					.HasComment("운송 상태");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 시간");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.To)
					.HasColumnName("_to")
					.HasComment("도착 지역 번호");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 고유 번호");
			});

			modelBuilder.Entity<TblDuelCharacterInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo, e.DuelCharacterNo })
					.HasName("PkTblDuelCharacterInfo")
					.IsClustered(false);

				entity.ToTable("TblDuelCharacterInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.DuelCharacterNo).HasColumnName("_duelCharacterNo");

				entity.Property(e => e.AddExperience).HasColumnName("_addExperience");

				entity.Property(e => e.AddSkillPointExperience).HasColumnName("_addSkillPointExperience");
			});

			modelBuilder.Entity<TblEmoticon>(entity =>
			{
				entity.HasKey(e => new { e.OwnerUserNo, e.EmoticonPackageKey })
					.HasName("RkTblEmoticon");

				entity.ToTable("TblEmoticon", "PaGamePrivate");

				entity.HasComment("이모티콘");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("소유자번호");

				entity.Property(e => e.EmoticonPackageKey)
					.HasColumnName("_emoticonPackageKey")
					.HasComment("이모티콘패키지 키 ");

				entity.Property(e => e.EmoticonType)
					.HasColumnName("_emoticonType")
					.HasComment("이모티콘 상품 타입");

				entity.Property(e => e.PackageExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_packageExpirationDate")
					.HasDefaultValueSql("((0))")
					.HasComment("기간제 이모티콘 유통기한");
			});

			modelBuilder.Entity<TblEmployeeRepository>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.EmployeeNo })
					.HasName("PkTblEmployeeRepository")
					.IsClustered(false);

				entity.ToTable("TblEmployeeRepository", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.EmployeeNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_employeeNo");

				entity.Property(e => e.EmployeeJob).HasColumnName("_employeeJob");

				entity.Property(e => e.EmployeeKey).HasColumnName("_employeeKey");

				entity.Property(e => e.EmployeeNameKey).HasColumnName("_employeeNameKey");

				entity.Property(e => e.Exp).HasColumnName("_exp");

				entity.Property(e => e.IsApply).HasColumnName("_isApply");

				entity.Property(e => e.Loyalty).HasColumnName("_loyalty");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param10).HasColumnName("_param10");

				entity.Property(e => e.Param11).HasColumnName("_param11");

				entity.Property(e => e.Param12).HasColumnName("_param12");

				entity.Property(e => e.Param13).HasColumnName("_param13");

				entity.Property(e => e.Param14).HasColumnName("_param14");

				entity.Property(e => e.Param15).HasColumnName("_param15");

				entity.Property(e => e.Param16).HasColumnName("_param16");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.Param7).HasColumnName("_param7");

				entity.Property(e => e.Param8).HasColumnName("_param8");

				entity.Property(e => e.Param9).HasColumnName("_param9");

				entity.Property(e => e.State).HasColumnName("_state");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblEmployeeSpawnInformation>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.PositionIndex })
					.HasName("PkTblEmployeeSpawnInformation")
					.IsClustered(false);

				entity.ToTable("TblEmployeeSpawnInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.PositionIndex).HasColumnName("_positionIndex");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.NextSpawnTime)
					.HasColumnType("datetime")
					.HasColumnName("_nextSpawnTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SpawnTime)
					.HasColumnType("datetime")
					.HasColumnName("_spawnTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Status).HasColumnName("_status");
			});

			modelBuilder.Entity<TblEncyclopedium>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Key })
					.HasName("PkTblEncyclopedia");

				entity.ToTable("TblEncyclopedia", "PaGamePrivate");

				entity.HasComment("백과사전(어류도감)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.Key)
					.HasColumnName("_key")
					.HasComment("어종키 (DataSheet_Encyclopedia$Encyclopedia_Table)");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("잡은 수량");

				entity.Property(e => e.Value)
					.HasColumnName("_value")
					.HasComment("최대크기");
			});

			modelBuilder.Entity<TblEventBuff>(entity =>
			{
				entity.HasKey(e => new { e.ServerNo, e.BuffType })
					.HasName("PkTblEventBuff");

				entity.ToTable("TblEventBuff", "PaGamePrivate");

				entity.HasComment("이벤트 버프를 저장하기 위한 테이블");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버 번호");

				entity.Property(e => e.BuffType)
					.HasColumnName("_buffType")
					.HasComment("버프 타입");

				entity.Property(e => e.BuffPercent)
					.HasColumnName("_buffPercent")
					.HasComment("버프의 퍼센트");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasComment("버프의 남은 시간");

				entity.Property(e => e.Param1)
					.HasColumnName("_param1")
					.HasComment("범용 변수1");

				entity.Property(e => e.Param2)
					.HasColumnName("_param2")
					.HasComment("범용 변수2");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblEventMarbleGame>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblEventMarbleGame");

				entity.ToTable("TblEventMarbleGame", "PaWebGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.CompleteCount).HasColumnName("_completeCount");

				entity.Property(e => e.DailyResetDate)
					.HasColumnType("datetime")
					.HasColumnName("_dailyResetDate");

				entity.Property(e => e.PlayMarbleKey).HasColumnName("_playMarbleKey");

				entity.Property(e => e.PrePlayMarbleKey).HasColumnName("_prePlayMarbleKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RewardCompleteCount).HasColumnName("_rewardCompleteCount");

				entity.Property(e => e.TodayPlayDiceCount).HasColumnName("_todayPlayDiceCount");
			});

			modelBuilder.Entity<TblEventMarbleGameDiceItem>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.DiceItemKey })
					.HasName("PkTblEventMarbleGameDiceItem");

				entity.ToTable("TblEventMarbleGameDiceItem", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.DiceItemKey).HasColumnName("_diceItemKey");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblEventMarbleGameMap>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.MarbleKey })
					.HasName("PkTblEventMarbleGameMap");

				entity.ToTable("TblEventMarbleGameMap", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.MarbleKey).HasColumnName("_marbleKey");

				entity.Property(e => e.NextPlayDiceDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextPlayDiceDate");

				entity.Property(e => e.NowPosition).HasColumnName("_nowPosition");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblExcaliburUserInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblExcaliburUserInfo");

				entity.ToTable("TblExcaliburUserInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.DrawExcaliburCount).HasColumnName("_drawExcaliburCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_resetTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblExpeditionResultItem>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ItemEnchantKey })
					.HasName("PkTblExpeditionResultItem");

				entity.ToTable("TblExpeditionResultItem", "PaGamePrivate");

				entity.HasComment("토벌결과아이템");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.ItemEnchantKey)
					.HasColumnName("_itemEnchantKey")
					.HasComment("아이템키");

				entity.Property(e => e.ItemCount)
					.HasColumnName("_itemCount")
					.HasComment("아이템 갯수");

				entity.Property(e => e.RegisterDateDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록된 시간");
			});

			modelBuilder.Entity<TblExpeditionaryUnit>(entity =>
			{
				entity.HasKey(e => e.UnitNo)
					.HasName("PkTblExpeditionaryUnits");

				entity.ToTable("TblExpeditionaryUnits", "PaGamePrivate");

				entity.HasComment("부대");

				entity.Property(e => e.UnitNo)
					.HasColumnName("_unitNo")
					.HasComment("유닛 번호");

				entity.Property(e => e.EnergyPoint).HasColumnName("_energyPoint");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("부대 경험치");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))")
					.HasComment("부대레벨");

				entity.Property(e => e.UnitGrade)
					.HasColumnName("_unitGrade")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.UnitKey)
					.HasColumnName("_unitKey")
					.HasComment("유닛키");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");
			});

			modelBuilder.Entity<TblExplorationPoint>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.TerritoryKey })
					.HasName("PkTblExplorationPoint");

				entity.ToTable("TblExplorationPoint", "PaGamePrivate");

				entity.HasComment("탐험 포인트(지역별 공헌도)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 고유번호");

				entity.Property(e => e.TerritoryKey)
					.HasColumnName("_territoryKey")
					.HasComment("지역번호");

				entity.Property(e => e.AquiredPoint)
					.HasColumnName("_aquiredPoint")
					.HasComment("총 획득 포인트");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("경험치");

				entity.Property(e => e.RemainedPoint)
					.HasColumnName("_remainedPoint")
					.HasComment("남은 포인트");
			});

			modelBuilder.Entity<TblExtendSlotRepository>(entity =>
			{
				entity.HasKey(e => new { e.Type, e.OwnerNo, e.VariousNo })
					.HasName("PkTblExtendSlotRepository");

				entity.ToTable("TblExtendSlotRepository", "PaGamePrivate");

				entity.HasComment("확장 슬롯 정보");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("슬롯 타입");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("유저 혹은 캐릭터 고유 번호");

				entity.Property(e => e.VariousNo)
					.HasColumnName("_variousNo")
					.HasComment("지역번호 등 값");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 일시");

				entity.Property(e => e.Slot)
					.HasColumnName("_slot")
					.HasComment("확장 슬롯 개수");
			});

			modelBuilder.Entity<TblFairyLook>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblFairyLook", "PaGamePrivate");

				entity.HasComment("요정 외형");

				entity.Property(e => e.ActionIndex)
					.HasColumnName("_actionIndex")
					.HasComment("바꿀외형 번호");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("소유 사용자번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");
			});

			modelBuilder.Entity<TblFameCoolTime>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.BadCharacterNo })
					.HasName("PkTblFameCoolTime");

				entity.ToTable("TblFameCoolTime", "PaGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.BadCharacterNo).HasColumnName("_badCharacterNo");

				entity.Property(e => e.LastFameUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastFameUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblFameInfo>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblFameInfo");

				entity.ToTable("TblFameInfo", "PaGamePrivate");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo");

				entity.Property(e => e.Fame).HasColumnName("_fame");

				entity.Property(e => e.IsSheriff).HasColumnName("_isSheriff");

				entity.Property(e => e.KillCount).HasColumnName("_killCount");
			});

			modelBuilder.Entity<TblFamePreSeasonRank>(entity =>
			{
				entity.HasKey(e => new { e.Season, e.UserNo, e.CharacterNo })
					.HasName("PkTblFamePreSeasonRank")
					.IsClustered(false);

				entity.ToTable("TblFamePreSeasonRank", "PaWebGamePrivate");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.Fame).HasColumnName("_fame");

				entity.Property(e => e.GuildName)
					.HasMaxLength(60)
					.HasColumnName("_guildName");

				entity.Property(e => e.KillCount).HasColumnName("_killCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblFameSeasonRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PkTblFameSeasonRank")
					.IsClustered(false);

				entity.ToTable("TblFameSeasonRank", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.Fame).HasColumnName("_fame");

				entity.Property(e => e.GuildName)
					.HasMaxLength(60)
					.HasColumnName("_guildName");

				entity.Property(e => e.KillCount).HasColumnName("_killCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblFameSeasonRankNew>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PkTblFameSeasonRankNew")
					.IsClustered(false);

				entity.ToTable("TblFameSeasonRankNew", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.Fame).HasColumnName("_fame");

				entity.Property(e => e.GuildName)
					.HasMaxLength(60)
					.HasColumnName("_guildName");

				entity.Property(e => e.KillCount).HasColumnName("_killCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblFameTotalRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PkTblFameTotalRank")
					.IsClustered(false);

				entity.ToTable("TblFameTotalRank", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.Fame).HasColumnName("_fame");

				entity.Property(e => e.GuildName)
					.HasMaxLength(60)
					.HasColumnName("_guildName");

				entity.Property(e => e.KillCount).HasColumnName("_killCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblFameTotalRankNew>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PkTblFameTotalRankNew")
					.IsClustered(false);

				entity.ToTable("TblFameTotalRankNew", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.Fame).HasColumnName("_fame");

				entity.Property(e => e.GuildName)
					.HasMaxLength(60)
					.HasColumnName("_guildName");

				entity.Property(e => e.KillCount).HasColumnName("_killCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblFamilySkill>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SkillNo })
					.HasName("PKTblFamilySkills");

				entity.ToTable("TblFamilySkills", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");
			});

			modelBuilder.Entity<TblFamilySkillPoint>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblFamilySkillPoint")
					.IsClustered(false);

				entity.ToTable("TblFamilySkillPoint", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.RemainedSkillPoint).HasColumnName("_remainedSkillPoint");

				entity.Property(e => e.TotalskillPoint).HasColumnName("_totalskillPoint");
			});

			modelBuilder.Entity<TblFamilySpecialInformation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblFamilySpecialInformation");

				entity.ToTable("TblFamilySpecialInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param10).HasColumnName("_param10");

				entity.Property(e => e.Param10Point).HasColumnName("_param10Point");

				entity.Property(e => e.Param11).HasColumnName("_param11");

				entity.Property(e => e.Param11Point).HasColumnName("_param11Point");

				entity.Property(e => e.Param12).HasColumnName("_param12");

				entity.Property(e => e.Param12Point).HasColumnName("_param12Point");

				entity.Property(e => e.Param13).HasColumnName("_param13");

				entity.Property(e => e.Param13Point).HasColumnName("_param13Point");

				entity.Property(e => e.Param14).HasColumnName("_param14");

				entity.Property(e => e.Param14Point).HasColumnName("_param14Point");

				entity.Property(e => e.Param15).HasColumnName("_param15");

				entity.Property(e => e.Param15Point).HasColumnName("_param15Point");

				entity.Property(e => e.Param16).HasColumnName("_param16");

				entity.Property(e => e.Param16Point).HasColumnName("_param16Point");

				entity.Property(e => e.Param1Point).HasColumnName("_param1Point");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param2Point).HasColumnName("_param2Point");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param3Point).HasColumnName("_param3Point");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param4Point).HasColumnName("_param4Point");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Param5Point).HasColumnName("_param5Point");

				entity.Property(e => e.Param6).HasColumnName("_param6");

				entity.Property(e => e.Param6Point).HasColumnName("_param6Point");

				entity.Property(e => e.Param7).HasColumnName("_param7");

				entity.Property(e => e.Param7Point).HasColumnName("_param7Point");

				entity.Property(e => e.Param8).HasColumnName("_param8");

				entity.Property(e => e.Param8Point).HasColumnName("_param8Point");

				entity.Property(e => e.Param9).HasColumnName("_param9");

				entity.Property(e => e.Param9Point).HasColumnName("_param9Point");

				entity.Property(e => e.StatPoint).HasColumnName("_statPoint");
			});

			modelBuilder.Entity<TblFeverPoint>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblFeverPoint");

				entity.ToTable("TblFeverPoint", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.AddFeverPoint).HasColumnName("_addFeverPoint");

				entity.Property(e => e.FeverPoint).HasColumnName("_feverPoint");

				entity.Property(e => e.IsUseFeverSkill)
					.IsRequired()
					.HasColumnName("_isUseFeverSkill")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.LastAddPointTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastAddPointTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.MaxFeverPoint).HasColumnName("_maxFeverPoint");

				entity.Property(e => e.UseFeverSkillIndex).HasColumnName("_useFeverSkillIndex");
			});

			modelBuilder.Entity<TblFindHiddenRecipe>(entity =>
			{
				entity.HasKey(e => e.Recipe)
					.HasName("PKTblFindHiddenRecipe")
					.IsClustered(false);

				entity.ToTable("TblFindHiddenRecipe", "PaGamePrivate");

				entity.Property(e => e.Recipe)
					.ValueGeneratedNever()
					.HasColumnName("_recipe");

				entity.Property(e => e.FindTime)
					.HasColumnType("datetime")
					.HasColumnName("_findTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblFishTopRanking>(entity =>
			{
				entity.HasKey(e => new { e.EncyclopediaKey, e.UserNo })
					.HasName("PkTblFishTopRanking");

				entity.ToTable("TblFishTopRanking", "PaGamePrivate");

				entity.HasComment("낚시 TOP 랭킹");

				entity.Property(e => e.EncyclopediaKey)
					.HasColumnName("_encyclopediaKey")
					.HasComment("어류도감 키");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasComment("캐릭터명");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.FishLength)
					.HasColumnName("_fishLength")
					.HasComment("어류도감 키");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasComment("낚은 시간");

				entity.Property(e => e.PositionX)
					.HasColumnName("_positionX")
					.HasComment("_positionX");

				entity.Property(e => e.PositionY)
					.HasColumnName("_positionY")
					.HasComment("_positionY");

				entity.Property(e => e.PositionZ)
					.HasColumnName("_positionZ")
					.HasComment("_positionZ");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasComment("가문명");
			});

			modelBuilder.Entity<TblFitnessExperience>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.Type })
					.HasName("PkTblFitnessExperience");

				entity.ToTable("TblFitnessExperience", "PaGamePrivate");

				entity.HasComment("건강 경험치");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("0 호흡,1 힘,2 건강");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("경험치");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasComment("레벨");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblFixedBusinessInformation>(entity =>
			{
				entity.HasKey(e => new { e.VendorCharacterKey, e.OwnerUserNo })
					.HasName("PkTblFixedBusinessInformation")
					.IsClustered(false);

				entity.ToTable("TblFixedBusinessInformation", "PaGamePrivate");

				entity.HasComment("자판기_위탁판매");

				entity.Property(e => e.VendorCharacterKey)
					.HasColumnName("_vendorCharacterKey")
					.HasComment("해당지역 자판기_위탁판매기 번호");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("주인");

				entity.Property(e => e.BusinessType)
					.HasColumnName("_businessType")
					.HasComment("0자동판매1위탁판매");

				entity.Property(e => e.CommissionRate)
					.HasColumnName("_commissionRate")
					.HasComment("판매수수료(위탁판매시)");

				entity.Property(e => e.HoldingMoney)
					.HasColumnName("_holdingMoney")
					.HasComment("보유금액");

				entity.Property(e => e.IsActive)
					.HasColumnName("_isActive")
					.HasComment("액티브여부");

				entity.Property(e => e.MinRegisterMoney)
					.HasColumnName("_minRegisterMoney")
					.HasComment("최소등록비(위탁판매시)");

				entity.Property(e => e.SaleTime)
					.HasColumnName("_saleTime")
					.HasComment("판매기간(위탁판매시)");

				entity.Property(e => e.TownRegionKey)
					.HasColumnName("_townRegionKey")
					.HasComment("기간이 만료되어 아이템돌려줄때 사용");
			});

			modelBuilder.Entity<TblFixedConsignmentSale>(entity =>
			{
				entity.HasKey(e => e.ConsignmentNo)
					.HasName("PkTblFixedConsignmentSale");

				entity.ToTable("TblFixedConsignmentSale", "PaGamePrivate");

				entity.HasComment("위탁 판매 정보");

				entity.Property(e => e.ConsignmentNo)
					.HasColumnName("_consignmentNo")
					.HasComment("위탁판매 고유번호");

				entity.Property(e => e.CommissionRate)
					.HasColumnName("_commissionRate")
					.HasComment("수수료");

				entity.Property(e => e.ExpireTime)
					.HasColumnName("_expireTime")
					.HasComment("판매종료일");

				entity.Property(e => e.GatherMoney)
					.HasColumnName("_gatherMoney")
					.HasComment("판매후 모아진 돈");

				entity.Property(e => e.IsStackable)
					.HasColumnName("_isStackable")
					.HasComment("스택여부");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템키");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("아이템번호");

				entity.Property(e => e.OwnerCharacterNo)
					.HasColumnName("_ownerCharacterNo")
					.HasComment("소유자캐릭터번호");

				entity.Property(e => e.PricePerOne)
					.HasColumnName("_pricePerOne")
					.HasComment("개당 가격");

				entity.Property(e => e.RegisterMoney)
					.HasColumnName("_registerMoney")
					.HasComment("등록비");

				entity.Property(e => e.SaleEnd)
					.HasColumnName("_saleEnd")
					.HasComment("아이템이 모두 팔리면 1");

				entity.Property(e => e.VendorCharacterKey)
					.HasColumnName("_vendorCharacterKey")
					.HasComment("해당지역 자판기_위탁판매기 번호");
			});

			modelBuilder.Entity<TblFixedVendingMachine>(entity =>
			{
				entity.HasKey(e => new { e.VendorCharacterKey, e.VendingIndex })
					.HasName("PkTblFixedVendingMachine");

				entity.ToTable("TblFixedVendingMachine", "PaGamePrivate");

				entity.HasComment("자판기 정보");

				entity.Property(e => e.VendorCharacterKey)
					.HasColumnName("_vendorCharacterKey")
					.HasComment("해당지역 자판기_위탁판매기 번호");

				entity.Property(e => e.VendingIndex)
					.HasColumnName("_vendingIndex")
					.HasComment("자판기 내부 물건 구분");

				entity.Property(e => e.BuyFromUserPrice)
					.HasColumnName("_buyFromUserPrice")
					.HasComment("구매가격");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("갯수");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasComment("강화레벨");

				entity.Property(e => e.IsStackable)
					.HasColumnName("_isStackable")
					.HasComment("스택여부");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템키");

				entity.Property(e => e.MaxStackCount)
					.HasColumnName("_maxStackCount")
					.HasComment("최대 스택갯수");

				entity.Property(e => e.SellToUserPrice)
					.HasColumnName("_sellToUserPrice")
					.HasComment("판매가격");
			});

			modelBuilder.Entity<TblFriend>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.FriendUserNo })
					.HasName("PkTblFriends");

				entity.ToTable("TblFriends", "PaGamePrivate");

				entity.HasComment("친구 목록");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.FriendUserNo)
					.HasColumnName("_friendUserNo")
					.HasComment("친구 유저번호");

				entity.Property(e => e.FriendType)
					.HasColumnName("_friendType")
					.HasComment("0 일반,1 파티");

				entity.Property(e => e.GroupNo)
					.HasColumnName("_groupNo")
					.HasDefaultValueSql("((-1))")
					.HasComment("그룹번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblFriendGroup>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.GroupNo })
					.HasName("PkTblFriendGroup");

				entity.ToTable("TblFriendGroup", "PaGamePrivate");

				entity.HasComment("친구 그룹");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.GroupNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_groupNo")
					.HasComment("그룹번호");

				entity.Property(e => e.GroupName)
					.HasMaxLength(30)
					.HasColumnName("_groupName")
					.HasComment("그룹이름");
			});

			modelBuilder.Entity<TblFuelInsertCharacterInfo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblFuelInsertCharacterInfo", "PaGamePrivate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.Hp).HasColumnName("_hp");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ObjectNo).HasColumnName("_objectNo");

				entity.Property(e => e.ObjectState).HasColumnName("_objectState");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblFuelInsertCharacterSettingInfo>(entity =>
			{
				entity.HasKey(e => e.ObjectNo)
					.HasName("PkTblFuelInsertCharacterSettingInfo");

				entity.ToTable("TblFuelInsertCharacterSettingInfo", "PaGamePrivate");

				entity.Property(e => e.ObjectNo).HasColumnName("_objectNo");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.DirX).HasColumnName("_dirX");

				entity.Property(e => e.DirY).HasColumnName("_dirY");

				entity.Property(e => e.DirZ).HasColumnName("_dirZ");

				entity.Property(e => e.FieldIndex).HasColumnName("_fieldIndex");

				entity.Property(e => e.FieldNo).HasColumnName("_fieldNo");

				entity.Property(e => e.PosX).HasColumnName("_posX");

				entity.Property(e => e.PosY).HasColumnName("_posY");

				entity.Property(e => e.PosZ).HasColumnName("_posZ");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblFuelInsertInfo>(entity =>
			{
				entity.HasKey(e => new { e.ObjectNo, e.ItemKey })
					.HasName("PkTblFuelInsertInfo");

				entity.ToTable("TblFuelInsertInfo", "PaGamePrivate");

				entity.Property(e => e.ObjectNo).HasColumnName("_objectNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.VaryCount).HasColumnName("_varyCount");
			});

			modelBuilder.Entity<TblGeneralRepository>(entity =>
			{
				entity.HasKey(e => new { e.Type, e.MainKey, e.SubKey })
					.HasName("PkTblGeneralRepository");

				entity.ToTable("TblGeneralRepository", "PaGamePrivate");

				entity.HasComment("범용 저장소");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("타입별로 아래 분류");

				entity.Property(e => e.MainKey)
					.HasColumnName("_mainKey")
					.HasComment("캐릭터번호");

				entity.Property(e => e.SubKey)
					.HasColumnName("_subKey")
					.HasComment("WayPoint 또는 캐릭터키");

				entity.Property(e => e.DateTime)
					.HasColumnType("datetime")
					.HasColumnName("_dateTime")
					.HasComment("발견또는 레벨변경일시 또는 미사용");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.Value)
					.HasColumnName("_value")
					.HasComment("탐험lv 또는 친밀도");
			});

			modelBuilder.Entity<TblGetGuildGiveawayUser>(entity =>
			{
				entity.HasKey(e => new { e.Index, e.UserNo })
					.HasName("PkTblGetGuildGiveawayUser")
					.IsClustered(false);

				entity.ToTable("TblGetGuildGiveawayUser", "PaGamePrivate");

				entity.Property(e => e.Index).HasColumnName("_index");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGreatSeaRepository>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblGreatSeaRepository");

				entity.ToTable("TblGreatSeaRepository", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.EventTime)
					.HasColumnType("datetime")
					.HasColumnName("_eventTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.MaxEmployeeCount).HasColumnName("_maxEmployeeCount");

				entity.Property(e => e.SupriseEventTime)
					.HasColumnType("datetime")
					.HasColumnName("_supriseEventTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGrowStep>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.GrowStepKey })
					.HasName("PkTblGrowStep")
					.IsClustered(false);

				entity.ToTable("TblGrowStep", "PaGamePrivate");

				entity.HasComment("성장 단계 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.GrowStepKey)
					.HasColumnName("_growStepKey")
					.HasComment("성장 단계 키");

				entity.Property(e => e.IsOpen)
					.HasColumnName("_isOpen")
					.HasComment("성장 단계 오픈여부");
			});

			modelBuilder.Entity<TblGrowthPassCategoryReward>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CategoryKey, e.RewardIndex })
					.HasName("PkTblGrowthPassCategoryReward")
					.IsClustered(false);

				entity.ToTable("TblGrowthPassCategoryReward", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CategoryKey).HasColumnName("_categoryKey");

				entity.Property(e => e.RewardIndex).HasColumnName("_rewardIndex");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGrowthPassTotalReward>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.TotalRewardKey })
					.HasName("PkTblGrowthPassTotalReward")
					.IsClustered(false);

				entity.ToTable("TblGrowthPassTotalReward", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.TotalRewardKey).HasColumnName("_totalRewardKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGuild>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PkTblGuild");

				entity.ToTable("TblGuild", "PaGamePrivate");

				entity.HasComment("길드기본정보");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.AccumulateHouseCost)
					.HasColumnName("_accumulateHouseCost")
					.HasComment("길드하우스유지비");

				entity.Property(e => e.AccumulateTax)
					.HasColumnName("_accumulateTax")
					.HasComment("미납된 누적 법인세");

				entity.Property(e => e.AdviserUserNo)
					.HasColumnName("_adviserUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.AquiredSkillPoint)
					.HasColumnName("_aquiredSkillPoint")
					.HasComment("_aquiredSkillPoint");

				entity.Property(e => e.AvailableGuildQuestCount)
					.HasColumnName("_availableGuildQuestCount")
					.HasDefaultValueSql("((10))")
					.HasComment("일일 가능 길드 퀘스트");

				entity.Property(e => e.GuildBasicCacheSeqNo)
					.HasColumnName("_guildBasicCacheSeqNo")
					.HasComment("길드 기본 정보 캐쉬");

				entity.Property(e => e.GuildGrade)
					.HasColumnName("_guildGrade")
					.HasComment("길드등급");

				entity.Property(e => e.GuildIntroduction)
					.HasMaxLength(200)
					.HasColumnName("_guildIntroduction");

				entity.Property(e => e.GuildMainServerGroupNo)
					.HasColumnName("_guildMainServerGroupNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.GuildMainServerRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_guildMainServerRegisterDate")
					.HasDefaultValueSql("('2000-01-01')");

				entity.Property(e => e.GuildMark)
					.HasColumnName("_guildMark")
					.HasComment("길드마크");

				entity.Property(e => e.GuildMarkRegisterTime)
					.HasColumnType("datetime")
					.HasColumnName("_guildMarkRegisterTime");

				entity.Property(e => e.GuildMarkSeqNo)
					.HasColumnName("_guildMarkSeqNo")
					.HasComment("_guildMarkSeqNo");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName")
					.HasComment("길드명");

				entity.Property(e => e.GuildNotice)
					.HasMaxLength(300)
					.HasColumnName("_guildNotice")
					.HasComment("길드 공지사항");

				entity.Property(e => e.GuildWelfare)
					.HasColumnName("_guildWelfare")
					.HasComment("길드 복지자금 전달");

				entity.Property(e => e.IncentiveDate)
					.HasColumnType("datetime")
					.HasColumnName("_incentiveDate")
					.HasComment("인센티브 지급날짜");

				entity.Property(e => e.IsOccupyLastWeek)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_isOccupyLastWeek")
					.HasDefaultValueSql("((0))")
					.IsFixedLength()
					.HasComment("지난 주 점령전 점령 여부");

				entity.Property(e => e.LastActiveDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastActiveDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.MasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_masterUserNickname")
					.HasComment("길드마스터 가문명");

				entity.Property(e => e.MasterUserNo)
					.HasColumnName("_masterUserNo")
					.HasComment("길드마스터 사용자번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.RemainedSkillPoint)
					.HasColumnName("_remainedSkillPoint")
					.HasComment("_remainedSkillPoint");

				entity.Property(e => e.SiegeDecreaseHpStack)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_siegeDecreaseHpStack")
					.HasDefaultValueSql("((0))")
					.IsFixedLength()
					.HasComment("점령전 체력 감소 스택");

				entity.Property(e => e.SkillExperience)
					.HasColumnName("_skillExperience")
					.HasComment("_skillExperience");

				entity.Property(e => e.SkillPointLevel)
					.HasColumnName("_skillPointLevel")
					.HasComment("_skillPointLevel");

				entity.Property(e => e.TaxWarningCount)
					.HasColumnName("_taxWarningCount")
					.HasComment("법인세를 못 낸 경고 횟수(법인세 납부시 0으로 초기화됨)");

				entity.Property(e => e.Tendency)
					.HasColumnName("_tendency")
					.HasComment("길드성향");

				entity.Property(e => e.VariedMemberCount)
					.HasColumnName("_variedMemberCount")
					.HasComment("길드인원변화량");

				entity.Property(e => e.VariedProtectMemberCount)
					.HasColumnName("_variedProtectMemberCount")
					.HasComment("길드보호인원변화량");
			});

			modelBuilder.Entity<TblGuildAlliance>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildAlliance", "PaGamePrivate");

				entity.HasComment("길드연합");

				entity.Property(e => e.ChairGuildNo)
					.HasColumnName("_chairGuildNo")
					.HasComment("연합길드번호");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.LimitMemberCount)
					.HasColumnName("_limitMemberCount")
					.HasDefaultValueSql("((30))")
					.HasComment("길드인원 제한");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일(길드연합장의 등록일)");

				entity.Property(e => e.TaxRate)
					.HasColumnName("_taxRate")
					.HasComment("길드인원 세금 상수");
			});

			modelBuilder.Entity<TblGuildAllianceInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildAllianceInformation", "PaGamePrivate");

				entity.HasComment("연합 정보");

				entity.Property(e => e.AllianceBasicSeqNo)
					.HasColumnName("_allianceBasicSeqNo")
					.HasComment("기본 정보 동기화 번호");

				entity.Property(e => e.AllianceMark)
					.HasColumnName("_allianceMark")
					.HasComment("연합 마크");

				entity.Property(e => e.AllianceMarkRegisterTime)
					.HasColumnType("datetime")
					.HasColumnName("_allianceMarkRegisterTime")
					.HasComment("마크 등록 시간");

				entity.Property(e => e.AllianceMarkSeqNo)
					.HasColumnName("_allianceMarkSeqNo")
					.HasComment("마크 동기화 번호");

				entity.Property(e => e.AllianceName)
					.HasMaxLength(30)
					.HasColumnName("_allianceName")
					.HasComment("연합 이름");

				entity.Property(e => e.AllianceNo)
					.HasColumnName("_allianceNo")
					.HasComment("연합 번호");

				entity.Property(e => e.AllianceNotice)
					.HasMaxLength(300)
					.HasColumnName("_allianceNotice")
					.HasComment("연합 공지사항");

				entity.Property(e => e.AllianceType).HasColumnName("_allianceType");
			});

			modelBuilder.Entity<TblGuildApplicant>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.UserNo })
					.HasName("PkTblGuildApplicants");

				entity.ToTable("TblGuildApplicants", "PaGamePrivate");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.AwakenValue).HasColumnName("_awakenValue");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.DefenceValue).HasColumnName("_defenceValue");

				entity.Property(e => e.ExplorationPoint).HasColumnName("_explorationPoint");

				entity.Property(e => e.Introduction)
					.HasMaxLength(200)
					.HasColumnName("_introduction");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.OffenceValue).HasColumnName("_offenceValue");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.Wp).HasColumnName("_wp");
			});

			modelBuilder.Entity<TblGuildBattleRanking>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.Season })
					.HasName("PkTblGuildBattleRanking");

				entity.ToTable("TblGuildBattleRanking", "PaGamePrivate");

				entity.HasComment("결전 랭크 정보");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드 넘버");

				entity.Property(e => e.Season)
					.HasColumnName("_season")
					.HasComment("시즌");

				entity.Property(e => e.GuildBattleRating)
					.HasColumnName("_guildBattleRating")
					.HasComment("길드 점수");

				entity.Property(e => e.Lose)
					.HasColumnName("_lose")
					.HasComment("패배");

				entity.Property(e => e.Win)
					.HasColumnName("_win")
					.HasComment("승리");
			});

			modelBuilder.Entity<TblGuildBoard>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.BoardType })
					.HasName("PkTblGuildBoard");

				entity.ToTable("TblGuildBoard", "PaGamePrivate");

				entity.HasComment("길드 게시판 정보");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.BoardType)
					.HasColumnName("_boardType")
					.HasComment("게시판 타입");

				entity.Property(e => e.BoardMessage)
					.HasMaxLength(250)
					.HasColumnName("_boardMessage")
					.HasComment("게시판 내용");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("사용자번호");
			});

			modelBuilder.Entity<TblGuildCapital>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PkTblGuildCapital");

				entity.ToTable("TblGuildCapital", "PaGamePrivate");

				entity.Property(e => e.GuildNo)
					.ValueGeneratedNever()
					.HasColumnName("_guildNo");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");
			});

			modelBuilder.Entity<TblGuildComment>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildComments", "PaWebGamePrivate");

				entity.Property(e => e.ChairGuildNo).HasColumnName("_chairGuildNo");

				entity.Property(e => e.CommentNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_commentNo");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserComment)
					.HasMaxLength(200)
					.HasColumnName("_userComment");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblGuildGathering>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.Index })
					.HasName("PkTblGuildGathering");

				entity.ToTable("TblGuildGathering", "PaGamePrivate");

				entity.HasComment("길드 수집");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.Index)
					.HasColumnName("_index")
					.HasComment("목록 번호");

				entity.Property(e => e.ProductItemCount)
					.HasColumnName("_productItemCount")
					.HasComment("가공아이템갯수");

				entity.Property(e => e.ProductItemKey)
					.HasColumnName("_productItemKey")
					.HasComment("가공아이템");

				entity.Property(e => e.RequiredItemCount0)
					.HasColumnName("_requiredItemCount0")
					.HasComment("재료아이템갯수0");

				entity.Property(e => e.RequiredItemCount1)
					.HasColumnName("_requiredItemCount1")
					.HasComment("재료아이템갯수1");

				entity.Property(e => e.RequiredItemCount2)
					.HasColumnName("_requiredItemCount2")
					.HasComment("재료아이템갯수2");

				entity.Property(e => e.RequiredItemCount3)
					.HasColumnName("_requiredItemCount3")
					.HasComment("재료아이템갯수3");

				entity.Property(e => e.RequiredItemCount4)
					.HasColumnName("_requiredItemCount4")
					.HasComment("재료아이템갯수4");

				entity.Property(e => e.RequiredItemCount5)
					.HasColumnName("_requiredItemCount5")
					.HasComment("재료아이템갯수5");

				entity.Property(e => e.RequiredItemKey0)
					.HasColumnName("_requiredItemKey0")
					.HasComment("재료아이템0");

				entity.Property(e => e.RequiredItemKey1)
					.HasColumnName("_requiredItemKey1")
					.HasComment("재료아이템1");

				entity.Property(e => e.RequiredItemKey2)
					.HasColumnName("_requiredItemKey2")
					.HasComment("재료아이템2");

				entity.Property(e => e.RequiredItemKey3)
					.HasColumnName("_requiredItemKey3")
					.HasComment("재료아이템3");

				entity.Property(e => e.RequiredItemKey4)
					.HasColumnName("_requiredItemKey4")
					.HasComment("재료아이템4");

				entity.Property(e => e.RequiredItemKey5)
					.HasColumnName("_requiredItemKey5")
					.HasComment("재료아이템5");

				entity.Property(e => e.SyncCount)
					.HasColumnName("_syncCount")
					.HasComment("동기화 카운트");
			});

			modelBuilder.Entity<TblGuildGiveaway>(entity =>
			{
				entity.HasKey(e => e.Index)
					.HasName("PkTblGuildGiveaway");

				entity.ToTable("TblGuildGiveaway", "PaGamePrivate");

				entity.Property(e => e.Index).HasColumnName("_index");

				entity.Property(e => e.DeleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_deleteDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.Key).HasColumnName("_key");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblGuildHouseLargeCraft>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.ReceipeKey })
					.HasName("PkTblGuildHouseLargeCraft")
					.IsClustered(false);

				entity.ToTable("TblGuildHouseLargeCraft", "PaGamePrivate");

				entity.HasComment("길드하우스 대량제작");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("대량생산의 주체번호");

				entity.Property(e => e.ReceipeKey)
					.HasColumnName("_receipeKey")
					.HasComment("집의 레시피타입키 / 0은 용도없음");

				entity.Property(e => e.CompletePoint0)
					.HasColumnName("_completePoint0")
					.HasComment("대량생산 남은 수 0");

				entity.Property(e => e.CompletePoint1)
					.HasColumnName("_completePoint1")
					.HasComment("대량생산 남은 수 1");

				entity.Property(e => e.CompletePoint2)
					.HasColumnName("_completePoint2")
					.HasComment("대량생산 남은 수 2");

				entity.Property(e => e.CompletePoint3)
					.HasColumnName("_completePoint3")
					.HasComment("대량생산 남은 수 3");

				entity.Property(e => e.CompletePoint4)
					.HasColumnName("_completePoint4")
					.HasComment("대량생산 남은 수 4");

				entity.Property(e => e.CompletePoint5)
					.HasColumnName("_completePoint5")
					.HasComment("대량생산 남은 수 5");

				entity.Property(e => e.LargeExchangeKey)
					.HasColumnName("_largeExchangeKey")
					.HasComment("대량생산 exchange키");
			});

			modelBuilder.Entity<TblGuildHouseLargeCraftDailyCount>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.ReceipeKey, e.LargeExchangeKey })
					.HasName("PkTblGuildHouseLargeCraftDailyCount")
					.IsClustered(false);

				entity.ToTable("TblGuildHouseLargeCraftDailyCount", "PaGamePrivate");

				entity.HasComment("길드하우스 대량제작");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("대량생산의 주체번호");

				entity.Property(e => e.ReceipeKey)
					.HasColumnName("_receipeKey")
					.HasComment("집의 레시피타입키 / 0은 용도없음");

				entity.Property(e => e.LargeExchangeKey)
					.HasColumnName("_largeExchangeKey")
					.HasComment("대량생산 exchange키");

				entity.Property(e => e.CompleteCount)
					.HasColumnName("_completeCount")
					.HasComment("오늘 수행한대량생산 수");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGuildInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildInformation", "PaWebGamePrivate");

				entity.HasIndex(e => e.GuildNo, "PkTblGuildInformation")
					.IsUnique();

				entity.Property(e => e.GuildCommentCount)
					.HasColumnName("_guildCommentCount")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.GuildCommentUsed)
					.HasColumnName("_guildCommentUsed")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.GuildFacebookUrl)
					.HasMaxLength(200)
					.HasColumnName("_guildFacebookUrl");

				entity.Property(e => e.GuildImageUrl)
					.HasMaxLength(200)
					.HasColumnName("_guildImageUrl");

				entity.Property(e => e.GuildInformation)
					.HasMaxLength(1000)
					.HasColumnName("_guildInformation");

				entity.Property(e => e.GuildNickNameCommentCount).HasColumnName("_guildNickNameCommentCount");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildYouTubeUrl)
					.HasMaxLength(200)
					.HasColumnName("_guildYouTubeUrl");

				entity.Property(e => e.IsBlind)
					.HasColumnName("_isBlind")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate");
			});

			modelBuilder.Entity<TblGuildInformationComment>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.GuildCommentNo, e.UserNo })
					.HasName("PkTblGuildInformationComment")
					.IsClustered(false);

				entity.ToTable("TblGuildInformationComment", "PaWebGamePrivate");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildCommentNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_guildCommentNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.Comment)
					.HasMaxLength(1000)
					.HasColumnName("_comment");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.Regdate)
					.HasColumnType("datetime")
					.HasColumnName("_regdate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblGuildInformationCommentBlock>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.GuildCommentBlockNo })
					.HasName("PkTblGuildInformationCommentBlock")
					.IsClustered(false);

				entity.ToTable("TblGuildInformationCommentBlock", "PaWebGamePrivate");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildCommentBlockNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_guildCommentBlockNo");

				entity.Property(e => e.IsBlock)
					.HasColumnName("_isBlock")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Regdate)
					.HasColumnType("datetime")
					.HasColumnName("_regdate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblGuildJournal>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildJournal", "PaGamePrivate");

				entity.HasComment("나의 일지 시스템");

				entity.Property(e => e.DateKey)
					.HasColumnName("_dateKey")
					.HasComment("날짜키");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName")
					.HasComment("길드 이름");

				entity.Property(e => e.JournalType)
					.HasColumnName("_journalType")
					.HasComment("일지타입(JournalType-0칭호획득, 1 강화성공...)");

				entity.Property(e => e.OwnerCharacterNo)
					.HasColumnName("_ownerCharacterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.OwnerMasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_ownerMasterUserNickname")
					.HasComment("길마 가문명");

				entity.Property(e => e.OwnerMasterUserNo)
					.HasColumnName("_ownerMasterUserNo")
					.HasComment("길마 유저번호");

				entity.Property(e => e.OwnerMemberGrade)
					.HasColumnName("_ownerMemberGrade")
					.HasComment("owner의 GuildMemberGrade");

				entity.Property(e => e.OwnerName)
					.HasMaxLength(30)
					.HasColumnName("_ownerName")
					.HasComment("캐릭터 이름");

				entity.Property(e => e.OwnerNickname)
					.HasMaxLength(30)
					.HasColumnName("_ownerNickname")
					.HasComment("가문명");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("길드 번호");

				entity.Property(e => e.OwnerType)
					.HasColumnName("_ownerType")
					.HasComment("소유자타입(0 캐릭터,1길드)");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("UserNo");

				entity.Property(e => e.ParameterNo1)
					.HasColumnName("_parameterNo_1")
					.HasComment("인자1");

				entity.Property(e => e.ParameterNo2)
					.HasColumnName("_parameterNo_2")
					.HasComment("인자2");

				entity.Property(e => e.ParameterString)
					.HasMaxLength(50)
					.HasColumnName("_parameterString")
					.HasComment("문자열");

				entity.Property(e => e.PositionX)
					.HasColumnName("_positionX")
					.HasDefaultValueSql("((0))")
					.HasComment("위치값");

				entity.Property(e => e.PositionY)
					.HasColumnName("_positionY")
					.HasDefaultValueSql("((0))")
					.HasComment("위치값");

				entity.Property(e => e.PositionZ)
					.HasColumnName("_positionZ")
					.HasDefaultValueSql("((0))")
					.HasComment("위치값");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasComment("등록일");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버 번호");

				entity.Property(e => e.TargetCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_targetCharacterName")
					.HasComment("target의 캐릭터 이름");

				entity.Property(e => e.TargetCharacterNo)
					.HasColumnName("_targetCharacterNo")
					.HasComment("target의 캐릭터 번호");

				entity.Property(e => e.TargetGuildName)
					.HasMaxLength(30)
					.HasColumnName("_targetGuildName")
					.HasComment("target의 길드 이름");

				entity.Property(e => e.TargetGuildNo)
					.HasColumnName("_targetGuildNo")
					.HasComment("target의 길드 번호");

				entity.Property(e => e.TargetMasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_targetMasterUserNickname")
					.HasComment("길마 가문명");

				entity.Property(e => e.TargetMasterUserNo)
					.HasColumnName("_targetMasterUserNo")
					.HasComment("길마 유저번호");

				entity.Property(e => e.TargetMemberGrade)
					.HasColumnName("_targetMemberGrade")
					.HasComment("target의 GuildMemberGrade");

				entity.Property(e => e.TargetUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_targetUserNickname")
					.HasComment("targer의 가문명");

				entity.Property(e => e.TargetUserNo)
					.HasColumnName("_targetUserNo")
					.HasComment("targer의 UserNo");
			});

			modelBuilder.Entity<TblGuildLifeRankingInfo>(entity =>
			{
				entity.HasKey(e => new { e.Type, e.GuildNo })
					.HasName("PKTblGuildLifeRankingInfo");

				entity.ToTable("TblGuildLifeRankingInfo", "PaWebGamePrivate");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.LevelSum).HasColumnName("_levelSum");
			});

			modelBuilder.Entity<TblGuildManufacture>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildManufacture", "PaGamePrivate");

				entity.HasComment("길드가공");

				entity.Property(e => e.CompleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_completeDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("완료일");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.Index)
					.HasColumnName("_index")
					.HasComment("슬롯번호");

				entity.Property(e => e.ProductItemCount)
					.HasColumnName("_productItemCount")
					.HasComment("가공아이템갯수");

				entity.Property(e => e.ProductItemKey)
					.HasColumnName("_productItemKey")
					.HasComment("가공아이템");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.RequiredItemCount0)
					.HasColumnName("_requiredItemCount0")
					.HasComment("재료아이템갯수0");

				entity.Property(e => e.RequiredItemCount1)
					.HasColumnName("_requiredItemCount1")
					.HasComment("재료아이템갯수1");

				entity.Property(e => e.RequiredItemCount2)
					.HasColumnName("_requiredItemCount2")
					.HasComment("재료아이템갯수2");

				entity.Property(e => e.RequiredItemCount3)
					.HasColumnName("_requiredItemCount3")
					.HasComment("재료아이템갯수3");

				entity.Property(e => e.RequiredItemCount4)
					.HasColumnName("_requiredItemCount4")
					.HasComment("재료아이템갯수4");

				entity.Property(e => e.RequiredItemCount5)
					.HasColumnName("_requiredItemCount5")
					.HasComment("재료아이템갯수5");

				entity.Property(e => e.RequiredItemKey0)
					.HasColumnName("_requiredItemKey0")
					.HasComment("재료아이템0");

				entity.Property(e => e.RequiredItemKey1)
					.HasColumnName("_requiredItemKey1")
					.HasComment("재료아이템1");

				entity.Property(e => e.RequiredItemKey2)
					.HasColumnName("_requiredItemKey2")
					.HasComment("재료아이템2");

				entity.Property(e => e.RequiredItemKey3)
					.HasColumnName("_requiredItemKey3")
					.HasComment("재료아이템3");

				entity.Property(e => e.RequiredItemKey4)
					.HasColumnName("_requiredItemKey4")
					.HasComment("재료아이템4");

				entity.Property(e => e.RequiredItemKey5)
					.HasColumnName("_requiredItemKey5")
					.HasComment("재료아이템5");
			});

			modelBuilder.Entity<TblGuildManufactureDailyCount>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildManufactureDailyCount", "PaGamePrivate");

				entity.HasComment("길드가공일일횟수");

				entity.Property(e => e.CompleteCount)
					.HasColumnName("_completeCount")
					.HasComment("가공아이템완료갯수");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.ProductItemKey)
					.HasColumnName("_productItemKey")
					.HasComment("가공아이템");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("마지막 등록일");
			});

			modelBuilder.Entity<TblGuildMember>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblGuildMember")
					.IsClustered(false);

				entity.ToTable("TblGuildMember", "PaGamePrivate");

				entity.HasComment("길드멤버정보");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("사용자 번호");

				entity.Property(e => e.Benefit)
					.HasColumnName("_benefit")
					.HasComment("수당(실버)	( 길드가 동아리 등급이면 NULL일 수 있다.)");

				entity.Property(e => e.Bonus)
					.HasColumnName("_bonus")
					.HasComment("길드 상여금");

				entity.Property(e => e.ContractableDate)
					.HasColumnType("datetime")
					.HasColumnName("_contractableDate")
					.HasComment("다음 계약이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)");

				entity.Property(e => e.ContractedDay)
					.HasColumnName("_contractedDay")
					.HasComment("계약한 일 수");

				entity.Property(e => e.ContractedExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_contractedExpiration")
					.HasComment("계약기간 만료(길드가 동아리 등급이면 NULL일 수 있다.)");

				entity.Property(e => e.ContributedTendency)
					.HasColumnName("_contributedTendency")
					.HasComment("멤버가 기여한 길드 성향치");

				entity.Property(e => e.Grade)
					.HasColumnName("_grade")
					.HasComment("길드원 등급");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.IncentiveGrade)
					.HasColumnName("_incentiveGrade")
					.HasDefaultValueSql("((1))")
					.HasComment("최근 길드인센티브 지급등급");

				entity.Property(e => e.IsCollectable)
					.HasColumnName("_isCollectable")
					.HasComment("수당(일당) 수금이 가능한지? 1이면 가능, NULL 이거나, 0이면 안됨");

				entity.Property(e => e.IsPriceLimit)
					.IsRequired()
					.HasColumnName("_isPriceLimit")
					.HasDefaultValueSql("((1))")
					.HasComment("길드 자금 사용 한도 검사 유/무");

				entity.Property(e => e.IsProtectable)
					.HasColumnName("_isProtectable")
					.HasComment("보호 여부? 1이면 보호, NULL 이거나, 0이면 비보호");

				entity.Property(e => e.IsSiegeParticipant)
					.HasColumnName("_isSiegeParticipant")
					.HasComment("공성전에 참여 가능한 전투원");

				entity.Property(e => e.IsVacation)
					.HasColumnName("_isVacation")
					.HasComment("휴가중인지");

				entity.Property(e => e.IsVoiceChatListen)
					.HasColumnName("_isVoiceChatListen")
					.HasComment("음성 채팅 듣기 on/off");

				entity.Property(e => e.IsVoiceChatSpeak)
					.HasColumnName("_isVoiceChatSpeak")
					.HasComment("음성 채팅 말하기 on/off");

				entity.Property(e => e.LastSiegeRewardDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastSiegeRewardDate")
					.HasComment("공성전 보상 지급 시간.");

				entity.Property(e => e.MyPriceLimit)
					.HasColumnName("_myPriceLimit")
					.HasComment("길드 자금 사용 한도");

				entity.Property(e => e.Penalty)
					.HasColumnName("_penalty")
					.HasComment(" 위약금		(길드가 동아리 등급이면 NULL일 수 있다.)");

				entity.Property(e => e.ProtectableDate)
					.HasColumnType("datetime")
					.HasColumnName("_protectableDate")
					.HasComment("다음 보호 여부 변경이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("길드가입일");

				entity.Property(e => e.SiegeCombatant)
					.HasColumnName("_siegeCombatant")
					.HasDefaultValueSql("((5))")
					.HasComment("공성전에 참여 가능한 전투원");

				entity.Property(e => e.SiegeItemKey).HasColumnName("_siegeItemKey");

				entity.Property(e => e.SiegeMedalCount)
					.HasColumnName("_siegeMedalCount")
					.HasComment("공성전 훈장 보상.");

				entity.Property(e => e.SiegeMercenaryCost).HasColumnName("_siegeMercenaryCost");

				entity.Property(e => e.SiegeTopItemKey)
					.HasColumnName("_siegeTopItemKey")
					.HasComment("공성전 1등 보상.");

				entity.Property(e => e.Top5PercentsiegeItemCount).HasColumnName("_top5PercentsiegeItemCount");

				entity.Property(e => e.Top5PercentsiegeItemKey).HasColumnName("_top5PercentsiegeItemKey");

				entity.Property(e => e.TotalActivity)
					.HasColumnName("_totalActivity")
					.HasComment("총 활동 점수");

				entity.Property(e => e.UsableActivity)
					.HasColumnName("_usableActivity")
					.HasComment("사용 가능한 활동 점수(고용계약시 수당 갱신에 사용)");

				entity.Property(e => e.UserCharacterNoForCost).HasColumnName("_userCharacterNoForCost");
			});

			modelBuilder.Entity<TblGuildPendingReward>(entity =>
			{
				entity.HasKey(e => e.RewardNo)
					.HasName("PkTblGuildPendingReward");

				entity.ToTable("TblGuildPendingReward", "PaGamePrivate");

				entity.Property(e => e.RewardNo).HasColumnName("_rewardNo");

				entity.Property(e => e.ExpireDate)
					.HasColumnType("datetime")
					.HasColumnName("_expireDate");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.ItemString)
					.HasMaxLength(4000)
					.IsUnicode(false)
					.HasColumnName("_itemString");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGuildPendingRewardLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildPendingRewardLog", "PaGamePrivate");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblGuildPendingRewardUser>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.GuildNo, e.RewardNo })
					.HasName("PkTblGuildPendingRewardUser");

				entity.ToTable("TblGuildPendingRewardUser", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.RewardNo).HasColumnName("_rewardNo");

				entity.Property(e => e.IsRecieve).HasColumnName("_isRecieve");
			});

			modelBuilder.Entity<TblGuildPoint>(entity =>
			{
				entity.HasKey(e => e.TerritoryKey)
					.HasName("PkTblGuildPoint");

				entity.ToTable("TblGuildPoint", "PaGamePrivate");

				entity.Property(e => e.TerritoryKey)
					.ValueGeneratedNever()
					.HasColumnName("_territoryKey");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildPoint).HasColumnName("_guildPoint");

				entity.Property(e => e.GuildTotalPoint).HasColumnName("_guildTotalPoint");
			});

			modelBuilder.Entity<TblGuildPr>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PkTblGuildPR")
					.IsClustered(false);

				entity.ToTable("TblGuildPR", "PaGamePrivate");

				entity.Property(e => e.GuildNo)
					.ValueGeneratedNever()
					.HasColumnName("_guildNo");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.Category).HasColumnName("_category");

				entity.Property(e => e.GuildGrade).HasColumnName("_guildGrade");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.IsOpen).HasColumnName("_isOpen");

				entity.Property(e => e.MasterUserNickName)
					.HasMaxLength(30)
					.HasColumnName("_masterUserNickName");

				entity.Property(e => e.MemberCount).HasColumnName("_memberCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblGuildQuestList>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PkTblGuildQuestList")
					.IsClustered(false);

				entity.ToTable("TblGuildQuestList", "PaGamePrivate");

				entity.HasComment("길드 쾌스트 진행 목록");

				entity.Property(e => e.GuildNo)
					.ValueGeneratedNever()
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.Count1)
					.HasColumnName("_count1")
					.HasComment("_count1");

				entity.Property(e => e.Count2)
					.HasColumnName("_count2")
					.HasComment("_count2");

				entity.Property(e => e.Count3)
					.HasColumnName("_count3")
					.HasComment("_count3");

				entity.Property(e => e.Count4)
					.HasColumnName("_count4")
					.HasComment("_count4");

				entity.Property(e => e.Count5)
					.HasColumnName("_count5")
					.HasComment("_count5");

				entity.Property(e => e.GuildQuestNo)
					.HasColumnName("_guildQuestNo")
					.HasComment("길드 쾌스트 번호");

				entity.Property(e => e.IsPreoccupancy)
					.HasColumnName("_isPreoccupancy")
					.HasComment("선점여부");

				entity.Property(e => e.LimitTime)
					.HasColumnName("_limitTime")
					.HasComment("제한시간");

				entity.Property(e => e.OrderTime)
					.HasColumnType("datetime")
					.HasColumnName("_orderTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("쾌스트수락일시");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblGuildRankingInfo>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PKTblGuildRankingInfo");

				entity.ToTable("TblGuildRankingInfo", "PaWebGamePrivate");

				entity.Property(e => e.GuildNo)
					.ValueGeneratedNever()
					.HasColumnName("_guildNo");

				entity.Property(e => e.AquiredSkillPoint).HasColumnName("_aquiredSkillPoint");

				entity.Property(e => e.CommentCount).HasColumnName("_commentCount");

				entity.Property(e => e.CommentRegdate)
					.HasColumnType("datetime")
					.HasColumnName("_commentRegdate");

				entity.Property(e => e.GuildBattleRating).HasColumnName("_guildBattleRating");

				entity.Property(e => e.GuildGrade).HasColumnName("_guildGrade");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.IntroductionUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_introductionUpdateDate");

				entity.Property(e => e.IsIntroduction).HasColumnName("_isIntroduction");

				entity.Property(e => e.MasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_masterUserNickname");

				entity.Property(e => e.MasterUserNo).HasColumnName("_masterUserNo");

				entity.Property(e => e.MemberCount).HasColumnName("_memberCount");

				entity.Property(e => e.RegionKey1).HasColumnName("_regionKey1");

				entity.Property(e => e.RegionKey2).HasColumnName("_regionKey2");

				entity.Property(e => e.RegionKey3).HasColumnName("_regionKey3");

				entity.Property(e => e.SiegeCount).HasColumnName("_siegeCount");

				entity.Property(e => e.SpotSiegeCount).HasColumnName("_spotSiegeCount");

				entity.Property(e => e.VariedMemberCount).HasColumnName("_variedMemberCount");

				entity.Property(e => e.WinCount).HasColumnName("_winCount");
			});

			modelBuilder.Entity<TblGuildRecommend>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblGuildRecommend");

				entity.ToTable("TblGuildRecommend", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.DecommendGuildNo).HasColumnName("_decommendGuildNo");

				entity.Property(e => e.RecommenGuildNo).HasColumnName("_recommenGuildNo");
			});

			modelBuilder.Entity<TblGuildSkill>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.SkillNo })
					.HasName("PkTblGuildSkill");

				entity.ToTable("TblGuildSkill", "PaGamePrivate");

				entity.HasComment("길드 스킬 정보");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드번호");

				entity.Property(e => e.SkillNo)
					.HasColumnName("_skillNo")
					.HasComment("습득한 길드 스킬 번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.SkillLevel)
					.HasColumnName("_skillLevel")
					.HasComment("습득한 길드 스킬 레벨");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("스킬을 활성한 시킨 유저 정보");
			});

			modelBuilder.Entity<TblGuildSkillCoolTime>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.SkillNo })
					.HasName("PkTblGuildSkillCoolTime");

				entity.ToTable("TblGuildSkillCoolTime", "PaGamePrivate");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");

				entity.Property(e => e.ReusableTime)
					.HasColumnType("datetime")
					.HasColumnName("_reusableTime");
			});

			modelBuilder.Entity<TblGuildVolunteerMember>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildVolunteerMember", "PaGamePrivate");

				entity.HasComment("길드 용병 리스트");

				entity.Property(e => e.ContractAmount)
					.HasColumnName("_contractAmount")
					.HasComment("용병 계약 금액");

				entity.Property(e => e.ContractBenefit)
					.HasColumnName("_contractBenefit")
					.HasComment("용병 계약 혜택");

				entity.Property(e => e.IsPriceLimit)
					.IsRequired()
					.HasColumnName("_isPriceLimit")
					.HasDefaultValueSql("((1))")
					.HasComment("길드 자금 사용 한도 검사 유/무");

				entity.Property(e => e.IsSiegeParticipant)
					.HasColumnName("_isSiegeParticipant")
					.HasDefaultValueSql("((0))")
					.HasComment("용병 거점전 참여");

				entity.Property(e => e.LastSiegeRewardDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastSiegeRewardDate");

				entity.Property(e => e.MyPriceLimit)
					.HasColumnName("_myPriceLimit")
					.HasComment("길드 자금 사용 한도");

				entity.Property(e => e.SiegeItemKey).HasColumnName("_siegeItemKey");

				entity.Property(e => e.SiegeMedalCount).HasColumnName("_siegeMedalCount");

				entity.Property(e => e.SiegeMercenaryCost).HasColumnName("_siegeMercenaryCost");

				entity.Property(e => e.UserCharacterNoForCost).HasColumnName("_userCharacterNoForCost");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("등록일(길드연합장의 등록일)");

				entity.Property(e => e.VolunteerGuilNo)
					.HasColumnName("_volunteerGuilNo")
					.HasComment("용병 길드 넘버");
			});

			modelBuilder.Entity<TblGuildWar>(entity =>
			{
				entity.HasKey(e => new { e.GuildNo, e.TargetGuildNo })
					.HasName("PkTblGuildWar");

				entity.ToTable("TblGuildWar", "PaGamePrivate");

				entity.HasComment("길드 전쟁 정보");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드 번호");

				entity.Property(e => e.TargetGuildNo)
					.HasColumnName("_targetGuildNo")
					.HasComment("전쟁 선포한 길드 번호");

				entity.Property(e => e.Death)
					.HasColumnName("_death")
					.HasComment("사망수");

				entity.Property(e => e.Kill)
					.HasColumnName("_kill")
					.HasComment("킬수");

				entity.Property(e => e.LastUpdatePenaltyDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdatePenaltyDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("전쟁 페널티 마지막 갱신 시간");

				entity.Property(e => e.PenaltyCount)
					.HasColumnName("_penaltyCount")
					.HasComment("전쟁 페널티 누적 수치");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("전쟁 시작 시간");
			});

			modelBuilder.Entity<TblGuildWarHistory>(entity =>
			{
				entity.HasKey(e => new { e.OwnerGuildNo, e.TargetGuildNo })
					.HasName("PkTblGuildWarHistory");

				entity.ToTable("TblGuildWarHistory", "PaGamePrivate");

				entity.Property(e => e.OwnerGuildNo).HasColumnName("_ownerGuildNo");

				entity.Property(e => e.TargetGuildNo).HasColumnName("_targetGuildNo");

				entity.Property(e => e.WarEndTime)
					.HasColumnType("datetime")
					.HasColumnName("_warEndTime");
			});

			modelBuilder.Entity<TblGuildWareHouseHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblGuildWareHouseHistory", "PaGamePrivate");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsPush).HasColumnName("_isPush");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHarvestInstallation>(entity =>
			{
				entity.HasKey(e => e.InstallationNo)
					.HasName("PkTblHarvestInstallation")
					.IsClustered(false);

				entity.ToTable("TblHarvestInstallation", "PaGamePrivate");

				entity.Property(e => e.InstallationNo)
					.ValueGeneratedNever()
					.HasColumnName("_installationNo");

				entity.Property(e => e.NextType)
					.HasColumnName("_nextType")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.RemainBirdAttackCount).HasColumnName("_remainBirdAttackCount");

				entity.Property(e => e.RemainEventTime).HasColumnName("_remainEventTime");

				entity.Property(e => e.RemainLopCount).HasColumnName("_remainLopCount");

				entity.Property(e => e.RemainPestCount).HasColumnName("_remainPestCount");
			});

			modelBuilder.Entity<TblHiddenDrop>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.HiddenDropNo })
					.HasName("PkTblHiddenDrop");

				entity.ToTable("TblHiddenDrop", "PaGamePrivate");

				entity.HasComment("히든 드랍");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.HiddenDropNo)
					.HasColumnName("_hiddenDropNo")
					.HasComment("드랍 고유 번호");

				entity.Property(e => e.CompleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_completeDate")
					.HasComment("완료 시간");

				entity.Property(e => e.HiddenDropCount)
					.HasColumnName("_hiddenDropCount")
					.HasComment("진행 정도");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblHorseRacingPreRecordRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey })
					.HasName("PkTblHorseRacingPreRecordRank");

				entity.ToTable("TblHorseRacingPreRecordRank", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.MapKey).HasColumnName("_mapKey");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.RecordDate)
					.HasColumnType("datetime")
					.HasColumnName("_recordDate");

				entity.Property(e => e.RecordTick).HasColumnName("_recordTick");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHorseRacingPreTotalRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey })
					.HasName("PkTblHorseRacingPreTotalRank");

				entity.ToTable("TblHorseRacingPreTotalRank", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.MapKey).HasColumnName("_mapKey");

				entity.Property(e => e.FirstCount).HasColumnName("_firstCount");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.SecondCount).HasColumnName("_secondCount");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.ThirdCount).HasColumnName("_thirdCount");

				entity.Property(e => e.TotalScore).HasColumnName("_totalScore");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHorseRacingRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.RankIndex, e.MapKey })
					.HasName("PkTblHorseRacingRank");

				entity.ToTable("TblHorseRacingRank", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.RankIndex)
					.HasColumnName("_rankIndex")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.MapKey)
					.HasColumnName("_mapKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.FirstCount).HasColumnName("_firstCount");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.RecordDate)
					.HasColumnType("datetime")
					.HasColumnName("_recordDate");

				entity.Property(e => e.RecordTick).HasColumnName("_recordTick");

				entity.Property(e => e.SecondCount).HasColumnName("_secondCount");

				entity.Property(e => e.ServantNo).HasColumnName("_servantNo");

				entity.Property(e => e.ThirdCount).HasColumnName("_thirdCount");
			});

			modelBuilder.Entity<TblHorseRacingRecordRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey })
					.HasName("PkTblHorseRacingRecordRank");

				entity.ToTable("TblHorseRacingRecordRank", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.MapKey).HasColumnName("_mapKey");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.RecordDate)
					.HasColumnType("datetime")
					.HasColumnName("_recordDate");

				entity.Property(e => e.RecordTick).HasColumnName("_recordTick");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHorseRacingRecordRankNew>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey })
					.HasName("PkTblHorseRacingRecordRankNew");

				entity.ToTable("TblHorseRacingRecordRankNew", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.MapKey).HasColumnName("_mapKey");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.RecordDate)
					.HasColumnType("datetime")
					.HasColumnName("_recordDate");

				entity.Property(e => e.RecordTick).HasColumnName("_recordTick");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHorseRacingTotalRank>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey })
					.HasName("PkTblHorseRacingTotalRank");

				entity.ToTable("TblHorseRacingTotalRank", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.MapKey).HasColumnName("_mapKey");

				entity.Property(e => e.FirstCount).HasColumnName("_firstCount");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.SecondCount).HasColumnName("_secondCount");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.ThirdCount).HasColumnName("_thirdCount");

				entity.Property(e => e.TotalScore).HasColumnName("_totalScore");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHorseRacingTotalRankNew>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season, e.MapKey })
					.HasName("PkTblHorseRacingTotalRankNew");

				entity.ToTable("TblHorseRacingTotalRankNew", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.MapKey).HasColumnName("_mapKey");

				entity.Property(e => e.FirstCount).HasColumnName("_firstCount");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.Rank).HasColumnName("_rank");

				entity.Property(e => e.SecondCount).HasColumnName("_secondCount");

				entity.Property(e => e.ServantName)
					.HasMaxLength(30)
					.HasColumnName("_servantName");

				entity.Property(e => e.ThirdCount).HasColumnName("_thirdCount");

				entity.Property(e => e.TotalScore).HasColumnName("_totalScore");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblHouseLargeCraft>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.HouseKey })
					.HasName("PkTblHouseLargeCraft");

				entity.ToTable("TblHouseLargeCraft", "PaGamePrivate");

				entity.HasComment("집의 대량생산기능을 위한 데이터 목록");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.HouseKey)
					.HasColumnName("_houseKey")
					.HasComment("_houseKey");

				entity.Property(e => e.CompletePoint0)
					.HasColumnName("_completePoint0")
					.HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");

				entity.Property(e => e.CompletePoint1)
					.HasColumnName("_completePoint1")
					.HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");

				entity.Property(e => e.CompletePoint2)
					.HasColumnName("_completePoint2")
					.HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");

				entity.Property(e => e.CompletePoint3)
					.HasColumnName("_completePoint3")
					.HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");

				entity.Property(e => e.CompletePoint4)
					.HasColumnName("_completePoint4")
					.HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");

				entity.Property(e => e.CompletePoint5)
					.HasColumnName("_completePoint5")
					.HasComment("대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료");

				entity.Property(e => e.LargeExchangeKey)
					.HasColumnName("_largeExchangeKey")
					.HasComment("집 대량생산 키");
			});

			modelBuilder.Entity<TblHouseListForTownManagement>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.HouseKey })
					.HasName("PkTblHouseListForTownManagement");

				entity.ToTable("TblHouseListForTownManagement", "PaGamePrivate");

				entity.HasComment("마을 관리 유저가 소유한 집 목록");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.HouseKey)
					.HasColumnName("_houseKey")
					.HasComment("_houseKey");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))")
					.HasComment("현재레벨");

				entity.Property(e => e.PrevLevel)
					.HasColumnName("_prevLevel")
					.HasComment("이전레벨");

				entity.Property(e => e.ReturnExplorePoint)
					.HasColumnName("_returnExplorePoint")
					.HasComment("돌려받을 탐험포인트");

				entity.Property(e => e.TerritoryKey)
					.HasColumnName("_territoryKey")
					.HasComment("돌려받을 탐험포인트 지역키");

				entity.Property(e => e.UsableTime)
					.HasColumnType("datetime")
					.HasColumnName("_usableTime")
					.HasDefaultValueSql("((0))")
					.HasComment("사용 가능한 시간(용도 변경시 세팅)");

				entity.Property(e => e.UseType)
					.HasColumnName("_useType")
					.HasComment("0은 용도없음");
			});

			modelBuilder.Entity<TblHouseholdFixed>(entity =>
			{
				entity.HasKey(e => e.HouseholdNo)
					.HasName("PkTblHouseholdFixed");

				entity.ToTable("TblHouseholdFixed", "PaGamePrivate");

				entity.HasComment("하우징 하우스홀드 고정집 테이블");

				entity.Property(e => e.HouseholdNo)
					.ValueGeneratedNever()
					.HasColumnName("_householdNo")
					.HasComment("하우징홀드 번호");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.InteriorSensePoint)
					.HasColumnName("_interiorSensePoint")
					.HasComment("설치물 점수 합산");

				entity.Property(e => e.InteriorUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_interiorUpdateTime");

				entity.Property(e => e.IsOpenedForAlliance)
					.HasColumnName("_isOpenedForAlliance")
					.HasComment("참이면 가입연합원에게 오픈됨");

				entity.Property(e => e.IsOpenedForEverybody)
					.HasColumnName("_isOpenedForEverybody")
					.HasComment("참이면 모든 사람에게 오픈됨");

				entity.Property(e => e.IsOpenedForGuild)
					.HasColumnName("_isOpenedForGuild")
					.HasComment("참이면 가입길드원에게 오픈됨");

				entity.Property(e => e.SuccessBidPrice)
					.HasColumnName("_successBidPrice")
					.HasComment("길드하우스 일 경우 경매 낙찰 가격");
			});

			modelBuilder.Entity<TblHouseholdSpec>(entity =>
			{
				entity.HasKey(e => e.HouseholdNo)
					.HasName("PkTblHouseholdSpec")
					.IsClustered(false);

				entity.ToTable("TblHouseholdSpec", "PaGamePrivate");

				entity.HasComment("하우징 하우스홀드 기본 테이블");

				entity.Property(e => e.HouseholdNo)
					.HasColumnName("_householdNo")
					.HasComment("_householdNo");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("텐트나 고정집에 대응하는 캐릭터키");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("소유자 사용자 캐릭터번호");

				entity.Property(e => e.Expiration)
					.HasColumnType("datetime")
					.HasColumnName("_expiration")
					.HasComment("현재는 만료기간이 Auction 에서 하고 있음");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TownRegionKey)
					.HasColumnName("_townRegionKey")
					.HasComment("집/텐트가 설치된 구역의 레지온키");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("household의 타입 - 0개인텐트,1고정집,2하우징설치물,3장애물,4공성텐트,5마을의 여관방,6성채 텐트7함정,8촌장텐트");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("캐릭을 소유한 사용자번호");
			});

			modelBuilder.Entity<TblHouseholdTent>(entity =>
			{
				entity.HasKey(e => e.HouseholdNo)
					.HasName("PkTblHouseholdTent");

				entity.ToTable("TblHouseholdTent", "PaGamePrivate");

				entity.HasComment("하우징 하우스홀드 텐트 테이블");

				entity.Property(e => e.HouseholdNo)
					.ValueGeneratedNever()
					.HasColumnName("_householdNo")
					.HasComment("_householdNo");

				entity.Property(e => e.BuildCompletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_buildCompletedDate");

				entity.Property(e => e.BuildCreatedDate)
					.HasColumnType("datetime")
					.HasColumnName("_buildCreatedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.BuildDestroyedDate)
					.HasColumnType("datetime")
					.HasColumnName("_buildDestroyedDate");

				entity.Property(e => e.BuildDestroyerGuildNo).HasColumnName("_buildDestroyerGuildNo");

				entity.Property(e => e.BuildGuildNo).HasColumnName("_buildGuildNo");

				entity.Property(e => e.BuildProgressPoint0)
					.HasColumnName("_buildProgressPoint0")
					.HasComment("_buildProgressPoint0");

				entity.Property(e => e.BuildProgressPoint1)
					.HasColumnName("_buildProgressPoint1")
					.HasComment("_buildProgressPoint1");

				entity.Property(e => e.BuildProgressPoint2)
					.HasColumnName("_buildProgressPoint2")
					.HasComment("_buildProgressPoint2");

				entity.Property(e => e.BuildProgressPoint3)
					.HasColumnName("_buildProgressPoint3")
					.HasComment("_buildProgressPoint3");

				entity.Property(e => e.BuildProgressPoint4)
					.HasColumnName("_buildProgressPoint4")
					.HasComment("_buildProgressPoint4");

				entity.Property(e => e.BuildRegionKey)
					.HasColumnName("_buildRegionKey")
					.HasComment("설치한 곳의 지역 키");

				entity.Property(e => e.DestroyerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_destroyerCharacterName")
					.HasComment("파괴한 캐릭터 명");

				entity.Property(e => e.DestroyerCharacterNo)
					.HasColumnName("_destroyerCharacterNo")
					.HasComment("파괴한 캐릭터 번호");

				entity.Property(e => e.DirX)
					.HasColumnName("_dirX")
					.HasComment("_dirX");

				entity.Property(e => e.DirY)
					.HasColumnName("_dirY")
					.HasComment("_dirY");

				entity.Property(e => e.DirZ)
					.HasColumnName("_dirZ")
					.HasComment("_dirZ");

				entity.Property(e => e.FieldIndex)
					.HasColumnName("_fieldIndex")
					.HasComment("_fieldIndex");

				entity.Property(e => e.FieldNo)
					.HasColumnName("_fieldNo")
					.HasComment("_fieldNo");

				entity.Property(e => e.GrowingRate0)
					.HasColumnName("_growingRate0")
					.HasComment("_growingRate0");

				entity.Property(e => e.GrowingRate1)
					.HasColumnName("_growingRate1")
					.HasComment("_growingRate1");

				entity.Property(e => e.GrowingRate2)
					.HasColumnName("_growingRate2")
					.HasComment("_growingRate2");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("설치하기 전에 사용한 텐트 아이템 키");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("아이템번호(아이템테이블과 연결)");

				entity.Property(e => e.PosX)
					.HasColumnName("_posX")
					.HasComment("_posX");

				entity.Property(e => e.PosY)
					.HasColumnName("_posY")
					.HasComment("_posY");

				entity.Property(e => e.PosZ)
					.HasColumnName("_posZ")
					.HasComment("_posZ");

				entity.Property(e => e.RegionTaxLevel)
					.HasColumnName("_regionTaxLevel")
					.HasComment("지역의 세금 단계");

				entity.Property(e => e.TerritoryKey).HasColumnName("_territoryKey");
			});

			modelBuilder.Entity<TblInstallation>(entity =>
			{
				entity.HasKey(e => e.InstallationNo)
					.HasName("PkTblInstallation");

				entity.ToTable("TblInstallation", "PaGamePrivate");

				entity.HasComment("하우징 설치오브젝트 텐트 테이블");

				entity.Property(e => e.InstallationNo)
					.HasColumnName("_installationNo")
					.HasComment("_installationNo");

				entity.Property(e => e.DecreaseYieldPercent)
					.HasColumnName("_decreaseYieldPercent")
					.HasComment("설비도구가 작물일때, 작물 수확량 감소%");

				entity.Property(e => e.FieldIndex)
					.HasColumnName("_fieldIndex")
					.HasComment("_fieldIndex");

				entity.Property(e => e.FieldNo)
					.HasColumnName("_fieldNo")
					.HasComment("_fieldNo");

				entity.Property(e => e.InstallDate)
					.HasColumnType("datetime")
					.HasColumnName("_installDate")
					.HasComment("설비도구가 처음 설치된 시간");

				entity.Property(e => e.IsErase)
					.HasColumnName("_isErase")
					.HasComment("고정집이 반납될때 삭제되는 설비도구");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("배치된 설치물 아이템 번호");

				entity.Property(e => e.NeedLop)
					.HasColumnName("_needLop")
					.HasComment("설비도구가 작물일때, 가지치기가 필요한 상태");

				entity.Property(e => e.NeedPestControl)
					.HasColumnName("_needPestControl")
					.HasComment("설비도구가 작물일때, 병충해정리가 필요한 상태");

				entity.Property(e => e.NeedWaterPercent)
					.HasColumnName("_needWaterPercent")
					.HasComment("설비도구가 작물일때, 시듦 수치");

				entity.Property(e => e.Param0)
					.HasColumnName("_param0")
					.HasComment("설비도구 타입에 따라서 맞춰서 사용");

				entity.Property(e => e.Param1)
					.HasColumnName("_param1")
					.HasComment("설비도구 타입에 따라서 맞춰서 사용");

				entity.Property(e => e.PosX)
					.HasColumnName("_posX")
					.HasComment("_posX");

				entity.Property(e => e.PosY)
					.HasColumnName("_posY")
					.HasComment("_posY");

				entity.Property(e => e.PosZ)
					.HasColumnName("_posZ")
					.HasComment("_posZ");

				entity.Property(e => e.PrivateFlag)
					.HasColumnName("_privateFlag")
					.HasComment("설비도구 공개설정: 0(공개), 1:(고정집안에서공개) 2:(여관안에서 공개)");

				entity.Property(e => e.ProgressPercent)
					.HasColumnName("_progressPercent")
					.HasComment("설비도구가 작물일때, 성장정도");

				entity.Property(e => e.QuatW)
					.HasColumnName("_quatW")
					.HasComment("_quatW");

				entity.Property(e => e.QuatX)
					.HasColumnName("_quatX")
					.HasComment("_quatX");

				entity.Property(e => e.QuatY)
					.HasColumnName("_quatY")
					.HasComment("_quatY");

				entity.Property(e => e.QuatZ)
					.HasColumnName("_quatZ")
					.HasComment("_quatZ");

				entity.Property(e => e.RelativeInstallationNo)
					.HasColumnName("_relativeInstallationNo")
					.HasComment("인테리어 추가 점수에 따른 연관 설비도구 번호");
			});

			modelBuilder.Entity<TblInstallationTempRealItemList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblInstallationTempRealItemList", "PaGamePrivate");

				entity.HasComment("집이 기간 만료 후 남아있는 위탁판매기의 위탁판매물 임시저장소(0408안씀)");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("수량");

				entity.Property(e => e.IsStackable)
					.HasColumnName("_isStackable")
					.HasComment("스택여부");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템키");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("아이템번호");

				entity.Property(e => e.TownRegionKey)
					.HasColumnName("_townRegionKey")
					.HasComment("_townRegionKey");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");
			});

			modelBuilder.Entity<TblInstallationTempVirtualItemList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblInstallationTempVirtualItemList", "PaGamePrivate");

				entity.HasComment("집이 기간 만료 후 남아있는 자판기 및 위탁판매용 아이템 임시 저장소(0408안씀)");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("수량");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasComment("강화레벨");

				entity.Property(e => e.IsStackable)
					.HasColumnName("_isStackable")
					.HasComment("스택여부");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템키");

				entity.Property(e => e.TownRegionKey)
					.HasColumnName("_townRegionKey")
					.HasComment("_townRegionKey");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");
			});

			modelBuilder.Entity<TblInstalledInstanceObject>(entity =>
			{
				entity.HasKey(e => e.InstanceObjectNo)
					.HasName("PkTblInstalledInstanceObject");

				entity.ToTable("TblInstalledInstanceObject", "PaGamePrivate");

				entity.HasComment("하우징 설치 InstanceObject 테이블");

				entity.Property(e => e.InstanceObjectNo)
					.HasColumnName("_instanceObjectNo")
					.HasComment("설치된 설치물의 고유번호");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("설치된 설치물의 캐릭터키");

				entity.Property(e => e.DirX)
					.HasColumnName("_dirX")
					.HasComment("_dirX");

				entity.Property(e => e.DirY)
					.HasColumnName("_dirY")
					.HasComment("_dirY");

				entity.Property(e => e.DirZ)
					.HasColumnName("_dirZ")
					.HasComment("_dirZ");

				entity.Property(e => e.FieldIndex)
					.HasColumnName("_fieldIndex")
					.HasComment("_fieldIndex");

				entity.Property(e => e.FieldNo)
					.HasColumnName("_fieldNo")
					.HasComment("_fieldNo");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("소속 길드번호");

				entity.Property(e => e.HouseholdNo).HasColumnName("_householdNo");

				entity.Property(e => e.ObjectType)
					.HasColumnName("_objectType")
					.HasComment("설치된 설치물의 종류");

				entity.Property(e => e.PosX)
					.HasColumnName("_posX")
					.HasComment("_posX");

				entity.Property(e => e.PosY)
					.HasColumnName("_posY")
					.HasComment("_posY");

				entity.Property(e => e.PosZ)
					.HasColumnName("_posZ")
					.HasComment("_posZ");

				entity.Property(e => e.UserCharacterNo)
					.HasColumnName("_userCharacterNo")
					.HasComment("소유자 사용자캐릭터번호");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("캐릭을 소유한 사용자번호(정상적인 캐릭터라면 TUserNoDefault 이면 안됨)	");
			});

			modelBuilder.Entity<TblInstanceContentReward>(entity =>
			{
				entity.HasKey(e => e.RewardNo)
					.HasName("PkTblInstanceContentReward")
					.IsClustered(false);

				entity.ToTable("TblInstanceContentReward", "PaGamePrivate");

				entity.Property(e => e.RewardNo).HasColumnName("_rewardNo");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblInstanceFieldCurruetServerNo>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.SessionLevel, e.AiLevel })
					.HasName("PkTblIFCurruetServerNo");

				entity.ToTable("TblInstanceFieldCurruetServerNo", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.SessionLevel).HasColumnName("_sessionLevel");

				entity.Property(e => e.AiLevel).HasColumnName("_aiLevel");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblInstanceFieldCustomRoomOption>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex })
					.HasName("PkTblInstanceFieldCustomRoomOption");

				entity.ToTable("TblInstanceFieldCustomRoomOption", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UniqueIndex).HasColumnName("_uniqueIndex");

				entity.Property(e => e.AiCount).HasColumnName("_aiCount");

				entity.Property(e => e.AiLevel).HasColumnName("_aiLevel");

				entity.Property(e => e.HostUserNo)
					.HasColumnName("_hostUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.IsHostObserver).HasColumnName("_isHostObserver");

				entity.Property(e => e.IsShow).HasColumnName("_isShow");

				entity.Property(e => e.IsShowNickName).HasColumnName("_isShowNickName");

				entity.Property(e => e.MatchType).HasColumnName("_matchType");

				entity.Property(e => e.MaxTier).HasColumnName("_maxTier");

				entity.Property(e => e.MinTier).HasColumnName("_minTier");
			});

			modelBuilder.Entity<TblInstanceFieldMatching>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex })
					.HasName("PkTblInstanceFieldMatching");

				entity.ToTable("TblInstanceFieldMatching", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UniqueIndex).HasColumnName("_uniqueIndex");

				entity.Property(e => e.AiLevel).HasColumnName("_aiLevel");

				entity.Property(e => e.BotCount)
					.HasColumnName("_botCount")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.CloseFlag).HasColumnName("_closeFlag");

				entity.Property(e => e.GameId)
					.HasMaxLength(30)
					.HasColumnName("_gameId");

				entity.Property(e => e.GameStartTime)
					.HasColumnType("datetime")
					.HasColumnName("_gameStartTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.HostUserNickName)
					.HasMaxLength(30)
					.HasColumnName("_hostUserNickName");

				entity.Property(e => e.HostUserNo)
					.HasColumnName("_hostUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.InstanceFieldMapKey)
					.HasColumnName("_instanceFieldMapKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.IsMatching).HasColumnName("_isMatching");

				entity.Property(e => e.MatchedCount)
					.HasColumnName("_matchedCount")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.PartyId)
					.HasColumnName("_partyId")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.Password)
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasColumnName("_password");

				entity.Property(e => e.SessionLevel).HasColumnName("_sessionLevel");

				entity.Property(e => e.Title)
					.HasMaxLength(30)
					.HasColumnName("_title");
			});

			modelBuilder.Entity<TblInstanceFieldNormalDatum>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.SeasonKey, e.RankPoint, e.UserNo })
					.HasName("PKTblInstanceFieldNormalData");

				entity.ToTable("TblInstanceFieldNormalData", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.SeasonKey).HasColumnName("_seasonKey");

				entity.Property(e => e.RankPoint).HasColumnName("_rankPoint");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.BestSessionPoint).HasColumnName("_bestSessionPoint");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.SumKillCount).HasColumnName("_sumKillCount");

				entity.Property(e => e.SumSessionPoint).HasColumnName("_sumSessionPoint");
			});

			modelBuilder.Entity<TblInstanceFieldOnlineUserRanking>(entity =>
			{
				entity.HasKey(e => new { e.Ranking, e.InstanceFieldKey, e.IsNormal })
					.HasName("PKTblInstanceFieldOnlineUserRanking");

				entity.ToTable("TblInstanceFieldOnlineUserRanking", "PaGamePrivate");

				entity.Property(e => e.Ranking).HasColumnName("_ranking");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.IsNormal).HasColumnName("_isNormal");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblInstanceFieldOnlineUserRankingNew>(entity =>
			{
				entity.HasKey(e => new { e.Ranking, e.InstanceFieldKey, e.IsNormal })
					.HasName("PKTblInstanceFieldOnlineUserRanking_New");

				entity.ToTable("TblInstanceFieldOnlineUserRanking_New", "PaGamePrivate");

				entity.Property(e => e.Ranking).HasColumnName("_ranking");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.IsNormal).HasColumnName("_isNormal");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblInstanceFieldRankDatum>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.SeasonKey, e.Mmr, e.UserNo })
					.HasName("PKTblInstanceFieldRankData");

				entity.ToTable("TblInstanceFieldRankData", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.SeasonKey).HasColumnName("_seasonKey");

				entity.Property(e => e.Mmr).HasColumnName("_MMR");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.BestSessionPoint).HasColumnName("_bestSessionPoint");

				entity.Property(e => e.DefeatStack).HasColumnName("_defeatStack");

				entity.Property(e => e.PlayCount).HasColumnName("_playCount");

				entity.Property(e => e.PrevRankPoint).HasColumnName("_prevRankPoint");

				entity.Property(e => e.RankPoint).HasColumnName("_rankPoint");

				entity.Property(e => e.SumKillCount).HasColumnName("_sumKillCount");

				entity.Property(e => e.SumSessionPoint).HasColumnName("_sumSessionPoint");

				entity.Property(e => e.Tier).HasColumnName("_tier");

				entity.Property(e => e.TierPoint).HasColumnName("_tierPoint");
			});

			modelBuilder.Entity<TblInstanceFieldReadyUser>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblInstanceFieldReadyUser");

				entity.ToTable("TblInstanceFieldReadyUser", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.IsEnterTheObserver).HasColumnName("_isEnterTheObserver");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UniqueIndex).HasColumnName("_uniqueIndex");

				entity.Property(e => e.ValidTime)
					.HasColumnType("datetime")
					.HasColumnName("_validTime");
			});

			modelBuilder.Entity<TblInstrumentInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.InstrumentNo })
					.HasName("PkTblTblInstrumentInfo");

				entity.ToTable("TblInstrumentInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.InstrumentNo).HasColumnName("_instrumentNo");
			});

			modelBuilder.Entity<TblInvestGuildPointInformation>(entity =>
			{
				entity.HasKey(e => e.InvestKey)
					.HasName("PkTblInvestGuildPointInformation");

				entity.ToTable("TblInvestGuildPointInformation", "PaGamePrivate");

				entity.Property(e => e.InvestKey)
					.ValueGeneratedNever()
					.HasColumnName("_investKey");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildPoint).HasColumnName("_guildPoint");

				entity.Property(e => e.InvestType).HasColumnName("_investType");

				entity.Property(e => e.UseDate)
					.HasColumnType("datetime")
					.HasColumnName("_useDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblItemCollectionScroll>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblICScroll");

				entity.ToTable("TblItemCollectionScroll", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.CollectionPoint).HasColumnName("_collectionPoint");

				entity.Property(e => e.CoolTime)
					.HasColumnType("datetime")
					.HasColumnName("_coolTime");

				entity.Property(e => e.CurrentGrade).HasColumnName("_currentGrade");
			});

			modelBuilder.Entity<TblItemDeliverer>(entity =>
			{
				entity.HasKey(e => new { e.ServerNo, e.DelivererNo })
					.HasName("PkTblItemDeliverer");

				entity.ToTable("TblItemDeliverer", "PaGamePrivate");

				entity.HasComment("아이템 운송을 담당하는 객체 정보");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.DelivererNo)
					.HasColumnName("_delivererNo")
					.HasComment("운송 객체 고유 번호");

				entity.Property(e => e.Destination)
					.HasMaxLength(100)
					.HasColumnName("_destination")
					.HasComment("목적지 웨이포인트 이름");

				entity.Property(e => e.DestinationKey)
					.HasColumnName("_destinationKey")
					.HasComment("목적지 웨이포인트 키");

				entity.Property(e => e.PositionX)
					.HasColumnName("_positionX")
					.HasComment("현재 좌표(x)");

				entity.Property(e => e.PositionY)
					.HasColumnName("_positionY")
					.HasComment("현재 좌표(y)");

				entity.Property(e => e.PositionZ)
					.HasColumnName("_positionZ")
					.HasComment("현재 좌표(z)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 일시");

				entity.Property(e => e.UpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_updateTime")
					.HasComment("갱신 시간");
			});

			modelBuilder.Entity<TblItemMarketMaster>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PkTblItemMarketMaster");

				entity.ToTable("TblItemMarketMaster", "PaGamePrivate");

				entity.HasComment("아이템거래소 master");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");

				entity.Property(e => e.AccumulatedAmount).HasColumnName("_accumulatedAmount");

				entity.Property(e => e.AccumulatedPrice).HasColumnName("_accumulatedPrice");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.MaxPrice).HasColumnName("_maxPrice");

				entity.Property(e => e.MinPrice).HasColumnName("_minPrice");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.TradedTotalAmount).HasColumnName("_tradedTotalAmount");

				entity.Property(e => e.TradedTotalPrice).HasColumnName("_tradedTotalPrice");
			});

			modelBuilder.Entity<TblItemMarketReservation>(entity =>
			{
				entity.HasKey(e => new { e.ItemEnchantKey, e.RegisterUserNo })
					.HasName("PkTblItemMarketReservation");

				entity.ToTable("TblItemMarketReservation", "PaGamePrivate");

				entity.Property(e => e.ItemEnchantKey).HasColumnName("_itemEnchantKey");

				entity.Property(e => e.RegisterUserNo).HasColumnName("_registerUserNo");

				entity.Property(e => e.LeftCount).HasColumnName("_leftCount");

				entity.Property(e => e.OnePrice).HasColumnName("_onePrice");

				entity.Property(e => e.RegisterCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_registerCharacterName");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RegisterTerritory).HasColumnName("_registerTerritory");

				entity.Property(e => e.TotalCount).HasColumnName("_totalCount");
			});

			modelBuilder.Entity<TblItemMarketSell>(entity =>
			{
				entity.HasKey(e => e.ItemMarketNo)
					.HasName("PkTblItemMarketSell");

				entity.ToTable("TblItemMarketSell", "PaGamePrivate");

				entity.HasComment("아이템거래소 판매");

				entity.Property(e => e.ItemMarketNo).HasColumnName("_itemMarketNo");

				entity.Property(e => e.BidderDicePercent).HasColumnName("_bidderDicePercent");

				entity.Property(e => e.BidderUserNo)
					.HasColumnName("_bidderUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.DisplayedBeginDate)
					.HasColumnType("datetime")
					.HasColumnName("_displayedBeginDate");

				entity.Property(e => e.DisplayedEndDate)
					.HasColumnType("datetime")
					.HasColumnName("_displayedEndDate");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.LeftCount).HasColumnName("_leftCount");

				entity.Property(e => e.OnePrice).HasColumnName("_onePrice");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.RegisterTerritory).HasColumnName("_registerTerritory");

				entity.Property(e => e.RegisterUserNo).HasColumnName("_registerUserNo");

				entity.Property(e => e.TotalCount).HasColumnName("_totalCount");

				entity.Property(e => e.TradePassword).HasColumnName("_tradePassword");

				entity.Property(e => e.TradedTotalPrice).HasColumnName("_tradedTotalPrice");
			});

			modelBuilder.Entity<TblItemMarketSellByParty>(entity =>
			{
				entity.HasKey(e => e.ItemMarketNo)
					.HasName("PkTblItemMarketSellByParty");

				entity.ToTable("TblItemMarketSellByParty", "PaGamePrivate");

				entity.Property(e => e.ItemMarketNo).HasColumnName("_itemMarketNo");

				entity.Property(e => e.ItemEnchantKey).HasColumnName("_itemEnchantKey");

				entity.Property(e => e.Price).HasColumnName("_price");

				entity.Property(e => e.RegisterTime)
					.HasColumnType("datetime")
					.HasColumnName("_registerTime");

				entity.Property(e => e.RegisterUserNo0).HasColumnName("_registerUserNo0");

				entity.Property(e => e.RegisterUserNo1).HasColumnName("_registerUserNo1");

				entity.Property(e => e.RegisterUserNo2).HasColumnName("_registerUserNo2");

				entity.Property(e => e.RegisterUserNo3).HasColumnName("_registerUserNo3");

				entity.Property(e => e.RegisterUserNo4).HasColumnName("_registerUserNo4");
			});

			modelBuilder.Entity<TblItemMarketSellByReservation>(entity =>
			{
				entity.HasKey(e => e.ItemMarketNo)
					.HasName("PkTblItemMarketSellByReservation")
					.IsClustered(false);

				entity.ToTable("TblItemMarketSellByReservation", "PaGamePrivate");

				entity.Property(e => e.ItemMarketNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemMarketNo");

				entity.Property(e => e.ItemEnchantKey).HasColumnName("_itemEnchantKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.OnePrice).HasColumnName("_onePrice");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RegisterTerritory).HasColumnName("_registerTerritory");

				entity.Property(e => e.RegisterUserNo).HasColumnName("_registerUserNo");

				entity.Property(e => e.TotalCount).HasColumnName("_totalCount");
			});

			modelBuilder.Entity<TblItemNaming>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblItemNaming")
					.IsClustered(false);

				entity.ToTable("TblItemNaming", "PaGamePrivate");

				entity.HasComment("유저 아이템 네이밍");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo")
					.HasComment("아이템 넘버");

				entity.Property(e => e.MailNo)
					.HasColumnName("_mailNo")
					.HasComment("작성자 이름");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 시간");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasComment("작성자 이름");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 넘버");
			});

			modelBuilder.Entity<TblItemOptionRepository>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblItemOptionRepository")
					.IsClustered(false);

				entity.ToTable("TblItemOptionRepository", "PaGamePrivate");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemOptionChangeCount).HasColumnName("_itemOptionChangeCount");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.LimitOption0).HasColumnName("_limitOption0");

				entity.Property(e => e.LimitOption1).HasColumnName("_limitOption1");

				entity.Property(e => e.LimitOption2).HasColumnName("_limitOption2");

				entity.Property(e => e.LimitOption3).HasColumnName("_limitOption3");

				entity.Property(e => e.LimitOption4).HasColumnName("_limitOption4");

				entity.Property(e => e.OptionParam0).HasColumnName("_optionParam0");

				entity.Property(e => e.OptionParam1).HasColumnName("_optionParam1");

				entity.Property(e => e.OptionParam2).HasColumnName("_optionParam2");

				entity.Property(e => e.OptionParam3).HasColumnName("_optionParam3");

				entity.Property(e => e.OptionParam4).HasColumnName("_optionParam4");

				entity.Property(e => e.OptionType0).HasColumnName("_optionType0");

				entity.Property(e => e.OptionType1).HasColumnName("_optionType1");

				entity.Property(e => e.OptionType2).HasColumnName("_optionType2");

				entity.Property(e => e.OptionType3).HasColumnName("_optionType3");

				entity.Property(e => e.OptionType4).HasColumnName("_optionType4");

				entity.Property(e => e.ParentItemNo).HasColumnName("_parentItemNo");
			});

			modelBuilder.Entity<TblItemRental>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblItemRental");

				entity.ToTable("TblItemRental", "PaGamePrivate");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblItemRepository>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblItemRepository")
					.IsClustered(false);

				entity.ToTable("TblItemRepository", "PaGamePrivate");

				entity.HasComment("아이템&돈 저장소");

				entity.HasIndex(e => new { e.OwnerNo, e.ItemWhereType, e.VariousNo, e.VariableDate }, "IxTblItemRepository_itemKey_ownerNo_itemWhereType_variousNo_variableDate");

				entity.HasIndex(e => e.ItemWhereType, "IxTblItemRepository_itemWhereType");

				entity.HasIndex(e => new { e.OwnerNo, e.ItemNo, e.ItemWhereType, e.VariousNo }, "IxTblItemRepository_ownerNo_itemNo_itemWhereType_variousNo");

				entity.HasIndex(e => new { e.VariousNo, e.OwnerNo }, "IxTblItemRepository_variousNo_ownerNo");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("아이템 고유번호");

				entity.Property(e => e.BuyingPrice)
					.HasColumnName("_buyingPrice")
					.HasComment("구매가격(무역아이템/경매 에서 의미가 있음)");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("아이템 개수");

				entity.Property(e => e.DyeingList)
					.HasMaxLength(24)
					.HasColumnName("_dyeingList");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasComment("_enchantLevel");

				entity.Property(e => e.Endurance)
					.HasColumnName("_endurance")
					.HasComment("내구도");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasComment("유통기한(NULL이면 무기한임)");

				entity.Property(e => e.IsExpirationDyeing)
					.HasColumnName("_isExpirationDyeing")
					.HasComment("true 면 기간제 염색이 적용된 아이템임");

				entity.Property(e => e.IsSealed)
					.IsRequired()
					.HasColumnName("_isSealed")
					.HasDefaultValueSql("((1))")
					.HasComment("참이면 각인된 것임");

				entity.Property(e => e.IsSeized)
					.HasColumnName("_isSeized")
					.HasComment("참이면 압류임");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))")
					.HasComment("참인 경우에만 정상적인 아이템임");

				entity.Property(e => e.IsVested)
					.HasColumnName("_isVested")
					.HasComment("참이면 귀속된 것임");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("_itemKey");

				entity.Property(e => e.ItemWhereType)
					.HasColumnName("_itemWhereType")
					.HasComment("아이템위치");

				entity.Property(e => e.MaxEndurance)
					.HasColumnName("_maxEndurance")
					.HasComment("최대 내구도");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("_itemWhereType에 따라 의미 다름");

				entity.Property(e => e.ProductionRegionKey)
					.HasColumnName("_productionRegionKey")
					.HasComment("최초로 만들어진/생산되어진 지역번호");

				entity.Property(e => e.PushedItemKey0)
					.HasColumnName("_pushedItemKey0")
					.HasComment("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1)
					.HasColumnName("_pushedItemKey1")
					.HasComment("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2)
					.HasColumnName("_pushedItemKey2")
					.HasComment("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3)
					.HasColumnName("_pushedItemKey3")
					.HasComment("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4)
					.HasColumnName("_pushedItemKey4")
					.HasComment("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5)
					.HasColumnName("_pushedItemKey5")
					.HasComment("_pushedItemKey5");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.VariableDate)
					.HasColumnType("datetime")
					.HasColumnName("_variableDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_variableDate");

				entity.Property(e => e.VariousNo)
					.HasColumnName("_variousNo")
					.HasComment("_itemWhereType에 따라 의미 다름");
			});

			modelBuilder.Entity<TblItemRepositoryGuildMoneyBak>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblItemRepository_GuildMoney_bak", "PaOperationPrivate");

				entity.Property(e => e.BackupDate)
					.HasColumnType("datetime")
					.HasColumnName("_backupDate");

				entity.Property(e => e.BuyingPrice).HasColumnName("_buyingPrice");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.DyeingList)
					.HasMaxLength(1)
					.HasColumnName("_dyeingList");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.IsExpirationDyeing).HasColumnName("_isExpirationDyeing");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.IsSeized).HasColumnName("_isSeized");

				entity.Property(e => e.IsValid).HasColumnName("_isValid");

				entity.Property(e => e.IsVested).HasColumnName("_isVested");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.ProductionRegionKey).HasColumnName("_productionRegionKey");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.VariableDate)
					.HasColumnType("datetime")
					.HasColumnName("_variableDate");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblItemRestoreWaiting>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblItemRestoreWaiting", "PaOperationPublic");

				entity.Property(e => e.BuyingPrice).HasColumnName("_buyingPrice");

				entity.Property(e => e.ConfirmUserNo).HasColumnName("_confirmUserNo");

				entity.Property(e => e.ConfirmWaitingDate)
					.HasColumnType("datetime")
					.HasColumnName("_confirmWaitingDate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.DyeingList)
					.HasMaxLength(24)
					.HasColumnName("_dyeingList");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.IsExpirationDyeing).HasColumnName("_isExpirationDyeing");

				entity.Property(e => e.IsSealed)
					.IsRequired()
					.HasColumnName("_isSealed")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsSeized).HasColumnName("_isSeized");

				entity.Property(e => e.IsSended).HasColumnName("_isSended");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsVested).HasColumnName("_isVested");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.Memo)
					.HasMaxLength(1000)
					.HasColumnName("_memo");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.ProductionRegionKey).HasColumnName("_productionRegionKey");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RequestUserNo).HasColumnName("_requestUserNo");

				entity.Property(e => e.RestoreNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_restoreNo");

				entity.Property(e => e.RestoreRegDate)
					.HasColumnType("datetime")
					.HasColumnName("_restoreRegDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.VariableDate)
					.HasColumnType("datetime")
					.HasColumnName("_variableDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblItemToInventoryRequest>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblItemToInventoryRequest", "PaOperationPrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ConfirmUserNo).HasColumnName("_confirmUserNo");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.IsSended).HasColumnName("_isSended");

				entity.Property(e => e.IsStack).HasColumnName("_isStack");

				entity.Property(e => e.IsVested).HasColumnName("_isVested");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.NoteNo)
					.HasMaxLength(50)
					.HasColumnName("_noteNo");

				entity.Property(e => e.NoteUrl)
					.HasMaxLength(300)
					.HasColumnName("_noteURL");

				entity.Property(e => e.RequestNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_requestNo");

				entity.Property(e => e.RequestUserNo).HasColumnName("_requestUserNo");

				entity.Property(e => e.RequestedDate)
					.HasColumnType("datetime")
					.HasColumnName("_requestedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ToWhere).HasColumnName("_toWhere");
			});

			modelBuilder.Entity<TblItemToWarehouseRequest>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblItemToWarehouseRequest", "PaOperationPrivate");

				entity.Property(e => e.BuyingPrice).HasColumnName("_buyingPrice");

				entity.Property(e => e.ConfirmUserNo).HasColumnName("_confirmUserNo");

				entity.Property(e => e.ConfirmWaitingDate)
					.HasColumnType("datetime")
					.HasColumnName("_confirmWaitingDate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.IsExpirationDyeing).HasColumnName("_isExpirationDyeing");

				entity.Property(e => e.IsSealed)
					.IsRequired()
					.HasColumnName("_isSealed")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsSeized).HasColumnName("_isSeized");

				entity.Property(e => e.IsSended).HasColumnName("_isSended");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsVested).HasColumnName("_isVested");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.Memo)
					.HasMaxLength(1000)
					.HasColumnName("_memo");

				entity.Property(e => e.NoteNo)
					.HasMaxLength(50)
					.HasColumnName("_noteNo");

				entity.Property(e => e.NoteUrl)
					.HasMaxLength(300)
					.HasColumnName("_noteURL");

				entity.Property(e => e.ProductionRegionKey).HasColumnName("_productionRegionKey");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RequestNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_requestNo");

				entity.Property(e => e.RequestUserNo).HasColumnName("_requestUserNo");

				entity.Property(e => e.RequestedDate)
					.HasColumnType("datetime")
					.HasColumnName("_requestedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TownRegionKey).HasColumnName("_townRegionKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.VariableDate)
					.HasColumnType("datetime")
					.HasColumnName("_variableDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblJournal>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblJournal", "PaGamePrivate");

				entity.HasComment("나의 일지 시스템");

				entity.Property(e => e.DateKey)
					.HasColumnName("_dateKey")
					.HasComment("날짜키");

				entity.Property(e => e.JournalType)
					.HasColumnName("_journalType")
					.HasComment("일지타입(JournalType-0칭호획득, 1 강화성공...)");

				entity.Property(e => e.OwnerName)
					.HasMaxLength(30)
					.HasColumnName("_ownerName")
					.HasComment("캐릭터 이름");

				entity.Property(e => e.OwnerNickname)
					.HasMaxLength(30)
					.HasColumnName("_ownerNickname")
					.HasComment("가문명");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.OwnerType)
					.HasColumnName("_ownerType")
					.HasComment("소유자타입(0 캐릭터,1길드)");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("UserNo");

				entity.Property(e => e.ParameterNo1)
					.HasColumnName("_parameterNo_1")
					.HasComment("인자1");

				entity.Property(e => e.ParameterNo2)
					.HasColumnName("_parameterNo_2")
					.HasComment("인자2");

				entity.Property(e => e.ParameterString)
					.HasMaxLength(50)
					.HasColumnName("_parameterString")
					.HasComment("문자열");

				entity.Property(e => e.PositionX)
					.HasColumnName("_positionX")
					.HasDefaultValueSql("((0))")
					.HasComment("위치값");

				entity.Property(e => e.PositionY)
					.HasColumnName("_positionY")
					.HasDefaultValueSql("((0))")
					.HasComment("위치값");

				entity.Property(e => e.PositionZ)
					.HasColumnName("_positionZ")
					.HasDefaultValueSql("((0))")
					.HasComment("위치값");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasComment("등록일");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버 번호");

				entity.Property(e => e.TargetCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_targetCharacterName")
					.HasComment("target 캐릭터 이름");

				entity.Property(e => e.TargetCharacterNo)
					.HasColumnName("_targetCharacterNo")
					.HasComment("target 캐릭터 번호");

				entity.Property(e => e.TargetUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_targetUserNickname")
					.HasComment("target 가문명");

				entity.Property(e => e.TargetUserNo)
					.HasColumnName("_targetUserNo")
					.HasComment("target UserNo");
			});

			modelBuilder.Entity<TblLeaveBriefUserInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblLeaveBriefUserInformation", "PaGamePrivate");

				entity.Property(e => e.LeaveDate)
					.HasColumnType("datetime")
					.HasColumnName("_leaveDate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.TmpName)
					.HasMaxLength(30)
					.HasColumnName("_tmpName");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblLeaveLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblLeaveLog", "LeaveUser");

				entity.Property(e => e.MDate)
					.HasColumnType("datetime")
					.HasColumnName("_mDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Msg)
					.HasMaxLength(2000)
					.HasColumnName("_msg");

				entity.Property(e => e.RowCount).HasColumnName("_rowCount");

				entity.Property(e => e.Rv).HasColumnName("_rv");

				entity.Property(e => e.Step).HasColumnName("_step");
			});

			modelBuilder.Entity<TblLifeExperience>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.Type })
					.HasName("PkTblLifeExperience");

				entity.ToTable("TblLifeExperience", "PaGamePrivate");

				entity.HasComment("생활 숙련도 정보");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("타입");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("경험치");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasComment("숙련도");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 시간");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblLimitedCashProduct>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblLimitedCashProduct", "PaGamePrivate");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.DiscountPrice).HasColumnName("_discountPrice");

				entity.Property(e => e.IsLimitedCount).HasColumnName("_isLimitedCount");

				entity.Property(e => e.MaxCount).HasColumnName("_maxCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedCount).HasColumnName("_remainedCount");

				entity.Property(e => e.SalesEndPeriod)
					.HasColumnType("datetime")
					.HasColumnName("_salesEndPeriod");

				entity.Property(e => e.SalesStartPeriod)
					.HasColumnType("datetime")
					.HasColumnName("_salesStartPeriod");
			});

			modelBuilder.Entity<TblLogoutPlayerWorking>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblLogoutPlayerWorking")
					.IsClustered(false);

				entity.ToTable("TblLogoutPlayerWorking", "PaGamePrivate");

				entity.HasComment("로그아웃중인 플레이어의 작업목록");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo")
					.HasComment("캐릭의 고유한 번호(OdbcCharacterNo)");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("소유 사용자번호");

				entity.Property(e => e.ProcessType)
					.HasColumnName("_processType")
					.HasComment("작업의 종류(0: 없음, 1: 수리, 2: 마을이동)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("작업 시작일");

				entity.Property(e => e.RepairItemNo)
					.HasColumnName("_repairItemNo")
					.HasComment("해당 작업에 관련된 아이템 번호(OdbcItemNo) (수리시에는 수리할 아이템, 마을 이동시에는 운송화된 아이템번호)");

				entity.Property(e => e.ToWaypoint)
					.HasColumnName("_toWaypoint")
					.HasDefaultValueSql("((0))")
					.HasComment("해당 작업으로 이동할 Waypoint 번호이다. (현재 마을이동 이외의 경우에는 NULL)");
			});

			modelBuilder.Entity<TblLoverList>(entity =>
			{
				entity.HasKey(e => e.NpcKey)
					.HasName("PkTblLoverList");

				entity.ToTable("TblLoverList", "PaGamePrivate");

				entity.HasComment("연인 테이블");

				entity.Property(e => e.NpcKey)
					.ValueGeneratedNever()
					.HasColumnName("_npcKey")
					.HasComment("npc 번호");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("npc의 연인 유저 번호");
			});

			modelBuilder.Entity<TblMacroKeyInputCheckLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMacroKeyInputCheckLog", "PaGamePrivate");

				entity.Property(e => e.InputCount).HasColumnName("_inputCount");

				entity.Property(e => e.StartDate)
					.HasColumnType("datetime")
					.HasColumnName("_startDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TextParam1)
					.HasMaxLength(4000)
					.HasColumnName("_textParam1");

				entity.Property(e => e.TextParam2)
					.HasMaxLength(4000)
					.HasColumnName("_textParam2");

				entity.Property(e => e.TextParam3)
					.HasMaxLength(4000)
					.HasColumnName("_textParam3");

				entity.Property(e => e.TextParam4)
					.HasMaxLength(4000)
					.HasColumnName("_textParam4");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblMaid>(entity =>
			{
				entity.HasKey(e => e.MaidNo)
					.HasName("PkTblMaid")
					.IsClustered(false);

				entity.ToTable("TblMaid", "PaGamePrivate");

				entity.HasComment("메이드");

				entity.Property(e => e.MaidNo)
					.HasColumnName("_maidNo")
					.HasComment("메이드 고유번호");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("메이드 식별자");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("소유 사용자 번호");

				entity.Property(e => e.ReuseTime)
					.HasColumnType("datetime")
					.HasColumnName("_reuseTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("재사용 가능시간");
			});

			modelBuilder.Entity<TblMail>(entity =>
			{
				entity.HasKey(e => e.MailNo)
					.HasName("PkTblMail")
					.IsClustered(false);

				entity.ToTable("TblMail", "PaGamePrivate");

				entity.HasComment("편지 정보");

				entity.Property(e => e.MailNo)
					.HasColumnName("_mailNo")
					.HasComment("편지 고유 번호");

				entity.Property(e => e.ChargeNo)
					.HasMaxLength(60)
					.IsUnicode(false)
					.HasColumnName("_chargeNo")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Contents)
					.HasMaxLength(500)
					.HasColumnName("_contents")
					.HasComment("편지 내용");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate")
					.HasComment("편지 삭제 시간");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasComment("첨부된 아이템 인챈트 레벨");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasComment("첨부된 아이템 유통기한");

				entity.Property(e => e.ItemCount)
					.HasColumnName("_itemCount")
					.HasComment("첨부된 아이템 개수");

				entity.Property(e => e.MailType)
					.HasColumnName("_mailType")
					.HasComment("편지 타입");

				entity.Property(e => e.ReceiverName)
					.HasMaxLength(30)
					.HasColumnName("_receiverName")
					.HasComment("받는 캐릭터 이름");

				entity.Property(e => e.ReceiverUserNo)
					.HasColumnName("_receiverUserNo")
					.HasComment("받는 사용자번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 일시");

				entity.Property(e => e.SenderName)
					.HasMaxLength(30)
					.HasColumnName("_senderName")
					.HasComment("보낸 캐릭터 이름");

				entity.Property(e => e.SenderUserNo)
					.HasColumnName("_senderUserNo")
					.HasComment("보낸 사용자번호");

				entity.Property(e => e.Title)
					.HasMaxLength(100)
					.HasColumnName("_title")
					.HasComment("편지 제목");

				entity.Property(e => e.VariousNo)
					.HasColumnName("_variousNo")
					.HasComment("_mailType에 따라 의미 다름");

				entity.Property(e => e.WebItemType)
					.HasColumnName("_webItemType")
					.HasComment("우편발송 웹창고 아이템 구분 (0:인게임메일, 1:쿠폰지급 아이템, 2:패키지, 3:웹샵 아이템, 그외 추가 가능)");
			});

			modelBuilder.Entity<TblMailItemWhiteList>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PkTblMailItemWhiteList")
					.IsClustered(false);

				entity.ToTable("TblMailItemWhiteList", "PaGamePrivate");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblMailPs4sub>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMailPS4Sub", "PaGamePrivate");

				entity.Property(e => e.EntitlementId)
					.HasMaxLength(16)
					.HasColumnName("_entitlementId");

				entity.Property(e => e.IsBundleProduct).HasColumnName("_isBundleProduct");

				entity.Property(e => e.MailNo).HasColumnName("_mailNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblMailWaitingQueue>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMailWaitingQueue", "PaOperationPublic");

				entity.Property(e => e.MailRequestNo).HasColumnName("_mailRequestNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.WaitingNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_waitingNo");
			});

			modelBuilder.Entity<TblMainQuestGroupInfo>(entity =>
			{
				entity.HasKey(e => e.QuestGroupNo)
					.HasName("PkTblTblMainQuestGroupInfo")
					.IsClustered(false);

				entity.ToTable("TblMainQuestGroupInfo", "PaGamePrivate");

				entity.Property(e => e.QuestGroupNo)
					.ValueGeneratedNever()
					.HasColumnName("_questGroupNo");
			});

			modelBuilder.Entity<TblMansionListForTownManagement>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.LandKey, e.BuildingKey })
					.HasName("PkTblMansionListForTownManagement")
					.IsClustered(false);

				entity.ToTable("TblMansionListForTownManagement", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.LandKey).HasColumnName("_landKey");

				entity.Property(e => e.BuildingKey).HasColumnName("_buildingKey");

				entity.Property(e => e.BasePointBuilding).HasColumnName("_basePointBuilding");

				entity.Property(e => e.BasePointLand).HasColumnName("_basePointLand");

				entity.Property(e => e.BonusPointBuilding).HasColumnName("_bonusPointBuilding");

				entity.Property(e => e.BonusPointLand).HasColumnName("_bonusPointLand");

				entity.Property(e => e.EmptyPointBuilding).HasColumnName("_emptyPointBuilding");

				entity.Property(e => e.EmptyPointLand).HasColumnName("_emptyPointLand");

				entity.Property(e => e.HouseholdNoBuilding).HasColumnName("_householdNoBuilding");

				entity.Property(e => e.HouseholdNoLand).HasColumnName("_householdNoLand");

				entity.Property(e => e.InteriorSensePoint).HasColumnName("_interiorSensePoint");

				entity.Property(e => e.InteriorSensePointBuilding).HasColumnName("_interiorSensePointBuilding");

				entity.Property(e => e.InteriorSensePointLand).HasColumnName("_interiorSensePointLand");

				entity.Property(e => e.InteriorUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_interiorUpdateTime");

				entity.Property(e => e.SetPoint).HasColumnName("_setPoint");
			});

			modelBuilder.Entity<TblMarbleGame>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblMarbleGame");

				entity.ToTable("TblMarbleGame", "PaWebGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.CompleteCount).HasColumnName("_completeCount");

				entity.Property(e => e.DailyResetDate)
					.HasColumnType("datetime")
					.HasColumnName("_dailyResetDate");

				entity.Property(e => e.NextFreeDiceDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextFreeDiceDate");

				entity.Property(e => e.NextPlayCardDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextPlayCardDate");

				entity.Property(e => e.PlayMarbleKey).HasColumnName("_playMarbleKey");

				entity.Property(e => e.PrePlayMarbleKey).HasColumnName("_prePlayMarbleKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RewardCompleteCount).HasColumnName("_rewardCompleteCount");

				entity.Property(e => e.TodayFreeDiceCount).HasColumnName("_todayFreeDiceCount");

				entity.Property(e => e.TodayPlayDiceCount).HasColumnName("_todayPlayDiceCount");
			});

			modelBuilder.Entity<TblMarbleGameCard>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CardKey })
					.HasName("PkTblMarbleGameCard");

				entity.ToTable("TblMarbleGameCard", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CardKey).HasColumnName("_cardKey");

				entity.Property(e => e.Count).HasColumnName("_count");
			});

			modelBuilder.Entity<TblMarbleGameDiceItem>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.DiceItemKey })
					.HasName("PkTblMarbleGameDiceItem");

				entity.ToTable("TblMarbleGameDiceItem", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.DiceItemKey).HasColumnName("_diceItemKey");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblMarbleGameMap>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.MarbleKey })
					.HasName("PkTblMarbleGameMap");

				entity.ToTable("TblMarbleGameMap", "PaWebGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.MarbleKey).HasColumnName("_marbleKey");

				entity.Property(e => e.NextPlayDiceDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextPlayDiceDate");

				entity.Property(e => e.NowPosition).HasColumnName("_nowPosition");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UseCardKey).HasColumnName("_useCardKey");
			});

			modelBuilder.Entity<TblMassMail>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMassMail", "PaGamePrivate");

				entity.Property(e => e.Contents)
					.HasMaxLength(500)
					.HasColumnName("_contents");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MassMailNo).HasColumnName("_massMailNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SenderName)
					.HasMaxLength(30)
					.HasColumnName("_senderName");

				entity.Property(e => e.Title)
					.HasMaxLength(100)
					.HasColumnName("_title");
			});

			modelBuilder.Entity<TblMassMailInfo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMassMailInfo", "PaOperationPublic");

				entity.Property(e => e.MailRequestNo).HasColumnName("_mailRequestNo");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblMassMailRequest>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMassMailRequest", "PaOperationPublic");

				entity.Property(e => e.Contents)
					.HasMaxLength(500)
					.HasColumnName("_contents");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.IsAllUser).HasColumnName("_isAllUser");

				entity.Property(e => e.IsComplete)
					.HasColumnName("_isComplete")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MailRequestNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_mailRequestNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.SenderName)
					.HasMaxLength(30)
					.HasColumnName("_senderName");

				entity.Property(e => e.SendingWaitingNo)
					.HasColumnName("_sendingWaitingNo")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.Title)
					.HasMaxLength(100)
					.HasColumnName("_title");

				entity.Property(e => e.UserIdCount).HasColumnName("_userIdCount");

				entity.Property(e => e.UserIdString)
					.IsUnicode(false)
					.HasColumnName("_userIdString");
			});

			modelBuilder.Entity<TblMassMailUserInfo>(entity =>
			{
				entity.HasKey(e => new { e.MassMailNo, e.UserNo })
					.HasName("PkTblMassMailUserInfo")
					.IsClustered(false);

				entity.ToTable("TblMassMailUserInfo", "PaGamePrivate");

				entity.Property(e => e.MassMailNo).HasColumnName("_massMailNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.MailState).HasColumnName("_mailState");
			});

			modelBuilder.Entity<TblMassPlayerTitleRequest>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMassPlayerTitleRequest", "PaOperationPublic");

				entity.Property(e => e.No)
					.ValueGeneratedOnAdd()
					.HasColumnName("_no");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TitleKey).HasColumnName("_titleKey");

				entity.Property(e => e.UserIdString)
					.HasMaxLength(5000)
					.IsUnicode(false)
					.HasColumnName("_userIdString");
			});

			modelBuilder.Entity<TblMasterySkillInfo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMasterySkillInfo", "PaGamePrivate");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.IsBattle).HasColumnName("_isBattle");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblMentalCardList>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CardKey })
					.HasName("PkTblMentalCardList");

				entity.ToTable("TblMentalCardList", "PaGamePrivate");

				entity.HasComment("카드 목록 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("소유 유저번호");

				entity.Property(e => e.CardKey)
					.HasColumnName("_cardKey")
					.HasComment("카드키");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblMessengerInfo>(entity =>
			{
				entity.HasKey(e => new { e.RoomNo, e.UserNo })
					.HasName("PkTblMessengerInfo")
					.IsClustered(false);

				entity.ToTable("TblMessengerInfo", "PaGamePrivate");

				entity.Property(e => e.RoomNo).HasColumnName("_roomNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.AlarmIsOn)
					.IsRequired()
					.HasColumnName("_alarmIsOn")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.MessageReadIndex).HasColumnName("_messageReadIndex");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RoomType).HasColumnName("_roomType");
			});

			modelBuilder.Entity<TblMessengerMessage>(entity =>
			{
				entity.HasKey(e => new { e.RoomNo, e.MessageIndex })
					.HasName("PkTblMessengerMessage");

				entity.ToTable("TblMessengerMessage", "PaGamePrivate");

				entity.Property(e => e.RoomNo).HasColumnName("_roomNo");

				entity.Property(e => e.MessageIndex)
					.ValueGeneratedOnAdd()
					.HasColumnName("_messageIndex");

				entity.Property(e => e.EmoticonKey).HasColumnName("_emoticonKey");

				entity.Property(e => e.MessageContent)
					.HasMaxLength(350)
					.HasColumnName("_messageContent")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.MessageDate)
					.HasColumnType("datetime")
					.HasColumnName("_messageDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.MessageRealIndex)
					.HasColumnName("_messageRealIndex")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.SenderUserNo).HasColumnName("_senderUserNo");
			});

			modelBuilder.Entity<TblMilitiaMember>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMilitiaMember", "PaGamePrivate");

				entity.HasComment("민병대 정보");

				entity.Property(e => e.AdSummary)
					.HasColumnName("_adSummary")
					.HasComment("공방 합");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("길드 번호");

				entity.Property(e => e.IsAttackTeam)
					.HasColumnName("_isAttackTeam")
					.HasComment("공격 팀 신청");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 시간");

				entity.Property(e => e.State)
					.HasColumnName("_state")
					.HasDefaultValueSql("((1))")
					.HasComment("신청 상태");

				entity.Property(e => e.TerritoryKey).HasColumnName("_territoryKey");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 번호");
			});

			modelBuilder.Entity<TblMiniGameUserInformation>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Type })
					.HasName("PkTblMiniGameUserInformation");

				entity.ToTable("TblMiniGameUserInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.Draw).HasColumnName("_draw");

				entity.Property(e => e.Escape).HasColumnName("_escape");

				entity.Property(e => e.Lose).HasColumnName("_lose");

				entity.Property(e => e.Win).HasColumnName("_win");
			});

			modelBuilder.Entity<TblMusicLevelInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblMusicLevelInfo");

				entity.ToTable("TblMusicLevelInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblMusicScore>(entity =>
			{
				entity.HasKey(e => e.MusicScoreNo)
					.HasName("PkTblMusicScore");

				entity.ToTable("TblMusicScore", "PaGamePrivate");

				entity.Property(e => e.MusicScoreNo).HasColumnName("_musicScoreNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.MusicScore).HasColumnName("_musicScore");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Size).HasColumnName("_size");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Version).HasColumnName("_version");
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

			modelBuilder.Entity<TblNameChangeComplete>(entity =>
			{
				entity.HasKey(e => new { e.OwnerNo, e.Name, e.ChangedDate })
					.HasName("PkTblNameChangeComplete")
					.IsClustered(false);

				entity.ToTable("TblNameChangeComplete", "PaGamePrivate");

				entity.HasComment("이름 변경 완료");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("변경을 요청한 유저 번호");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name")
					.HasComment("변경할 이름");

				entity.Property(e => e.ChangedDate)
					.HasColumnType("datetime")
					.HasColumnName("_changedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("변경된 날짜");

				entity.Property(e => e.BeforeName)
					.HasMaxLength(30)
					.HasColumnName("_beforeName")
					.HasComment("변경된 날짜");

				entity.Property(e => e.NameChangeType)
					.HasColumnName("_nameChangeType")
					.HasComment("이름 변경 타입");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("신청 날짜");
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

			modelBuilder.Entity<TblNameExchangeComplete>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo1, e.CharacterNo2, e.ChangedDate })
					.HasName("PkTblNameExchangeComplete")
					.IsClustered(false);

				entity.ToTable("TblNameExchangeComplete", "PaGamePrivate");

				entity.Property(e => e.CharacterNo1).HasColumnName("_characterNo1");

				entity.Property(e => e.CharacterNo2).HasColumnName("_characterNo2");

				entity.Property(e => e.ChangedDate)
					.HasColumnType("datetime")
					.HasColumnName("_changedDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblNewDeliveryRepository>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblNewDeliveryRepository");

				entity.ToTable("TblNewDeliveryRepository", "PaGamePrivate");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo");

				entity.Property(e => e.DeliveryTime).HasColumnName("_deliveryTime");

				entity.Property(e => e.From).HasColumnName("_from");

				entity.Property(e => e.Index).HasColumnName("_index");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.To).HasColumnName("_to");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblNpcProposeDialog>(entity =>
			{
				entity.HasKey(e => e.Index)
					.HasName("PkTblNpcProposeDialog");

				entity.ToTable("TblNpcProposeDialog", "PaGamePrivate");

				entity.HasComment("NPC 고백 시 대사 테이블");

				entity.Property(e => e.Index)
					.HasColumnName("_index")
					.HasComment("index 번호");

				entity.Property(e => e.Fail)
					.HasMaxLength(300)
					.HasColumnName("_fail")
					.HasComment("실패 시 메시지");

				entity.Property(e => e.Farewell)
					.HasMaxLength(300)
					.HasColumnName("_farewell")
					.HasComment("헤어질 때 메시지");

				entity.Property(e => e.NpcKey)
					.HasColumnName("_npcKey")
					.HasComment("npc 번호");

				entity.Property(e => e.SenderName)
					.HasMaxLength(30)
					.HasColumnName("_senderName")
					.HasComment("이름");

				entity.Property(e => e.Success)
					.HasMaxLength(300)
					.HasColumnName("_success")
					.HasComment("성공 시 메시지");

				entity.Property(e => e.Title)
					.HasMaxLength(100)
					.HasColumnName("_title")
					.HasComment("타이틀");

				entity.Property(e => e.TitleKey).HasColumnName("_titleKey");
			});

			modelBuilder.Entity<TblNpcShopItemBuyCount>(entity =>
			{
				entity.HasKey(e => new { e.IsUserNo, e.UserCharacterNo, e.ItemSubGroupKey, e.ItemEnchantKey })
					.HasName("PkTblNpcShopItemBuyCount")
					.IsClustered(false);

				entity.ToTable("TblNpcShopItemBuyCount", "PaGamePrivate");

				entity.Property(e => e.IsUserNo).HasColumnName("_isUserNo");

				entity.Property(e => e.UserCharacterNo).HasColumnName("_userCharacterNo");

				entity.Property(e => e.ItemSubGroupKey).HasColumnName("_itemSubGroupKey");

				entity.Property(e => e.ItemEnchantKey).HasColumnName("_itemEnchantKey");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.ResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_resetTime");
			});

			modelBuilder.Entity<TblOperationReport>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblOperationReport", "PaGamePrivate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Report)
					.HasMaxLength(120)
					.HasColumnName("_report")
					.HasDefaultValueSql("(' ')");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblPalette>(entity =>
			{
				entity.HasKey(e => new { e.OwnerNo, e.ItemKey })
					.HasName("PkTblPalette");

				entity.ToTable("TblPalette", "PaGamePrivate");

				entity.HasComment("팔레트");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("소유자번호");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템키");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("수량");

				entity.Property(e => e.PaletteType).HasColumnName("_paletteType");
			});

			modelBuilder.Entity<TblParty>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblParty");

				entity.ToTable("TblParty", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.IsPartyLeader).HasColumnName("_isPartyLeader");

				entity.Property(e => e.PartyId).HasColumnName("_partyId");
			});

			modelBuilder.Entity<TblPartyMatching>(entity =>
			{
				entity.HasKey(e => e.MatchId)
					.HasName("PKTblPartyMatching");

				entity.ToTable("TblPartyMatching", "PaGamePrivate");

				entity.Property(e => e.MatchId).HasColumnName("_matchId");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.MemberCount).HasColumnName("_memberCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPartyMatchingMember>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblPartyMatchingMember")
					.IsClustered(false);

				entity.ToTable("TblPartyMatchingMember", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.MatchId).HasColumnName("_matchId");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblPcWorking>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblPcWorking");

				entity.ToTable("TblPcWorking", "PaGamePrivate");

				entity.HasComment("PC의 작업 정보");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.CompletingTime)
					.HasColumnType("datetime")
					.HasColumnName("_completingTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("작업완료시간(작업종류가 변경될 때마다 설정됨)");

				entity.Property(e => e.DelivererNo)
					.HasColumnName("_delivererNo")
					.HasComment("운송자 번호(이동중일때만 설정)");

				entity.Property(e => e.DeliveryFrom)
					.HasColumnName("_deliveryFrom")
					.HasComment("출발지 지역번호");

				entity.Property(e => e.DeliveryRoute)
					.HasColumnName("_deliveryRoute")
					.HasComment("노선번호");

				entity.Property(e => e.DeliveryTo)
					.HasColumnName("_deliveryTo")
					.HasComment("도착지 지역번호");

				entity.Property(e => e.DirectionX)
					.HasColumnName("_directionX")
					.HasComment("_directionX(방향)");

				entity.Property(e => e.DirectionY)
					.HasColumnName("_directionY")
					.HasComment("_directionY(방향)");

				entity.Property(e => e.DirectionZ)
					.HasColumnName("_directionZ")
					.HasDefaultValueSql("((-1))")
					.HasComment("_directionZ(방향)");

				entity.Property(e => e.HouseholdNo)
					.HasColumnName("_householdNo")
					.HasComment("수리하는 곳의 집 번호, 이외는 NULL");

				entity.Property(e => e.InstallationKey)
					.HasColumnName("_installationKey")
					.HasComment("설치물번호의 아이템키, 이외는 NULL");

				entity.Property(e => e.InstallationNo)
					.HasColumnName("_installationNo")
					.HasComment("수리할때 이용하는 설치물 번호, 이외는 NULL");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("수리되는 아이템번호, 이외는 NULL");

				entity.Property(e => e.MaxWp)
					.HasColumnName("_maxWp")
					.HasComment("(회복작업시)회복할 최대 대화여력");

				entity.Property(e => e.PcWorkingType)
					.HasColumnName("_pcWorkingType")
					.HasComment("작업종류(PcWorkingType와 연결됨)");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버번호-작업중일때만 의미있음");

				entity.Property(e => e.StartTime)
					.HasColumnType("datetime")
					.HasColumnName("_startTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("작업시작시간(작업종류가 변경될 때마다 설정됨)");
			});

			modelBuilder.Entity<TblPearlCashProductList>(entity =>
			{
				entity.HasKey(e => new { e.ServiceType, e.CashProductNo })
					.HasName("PkTblPearlCashProductList")
					.IsClustered(false);

				entity.ToTable("TblPearlCashProductList", "PaGamePrivate");

				entity.Property(e => e.ServiceType).HasColumnName("_serviceType");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.TotalCount).HasColumnName("_totalCount");
			});

			modelBuilder.Entity<TblPearlInventoryDeletedItemRestoreLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPearlInventoryDeletedItemRestoreLog", "PaOperationPublic");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.NewItemNo).HasColumnName("_newItemNo");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SymNo)
					.HasMaxLength(50)
					.HasColumnName("_symNo");
			});

			modelBuilder.Entity<TblPearlItemList>(entity =>
			{
				entity.HasKey(e => new { e.ServiceType, e.ItemKey })
					.HasName("PkTblPearlItemList")
					.IsClustered(false);

				entity.ToTable("TblPearlItemList", "PaGamePrivate");

				entity.Property(e => e.ServiceType).HasColumnName("_serviceType");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.TotalCount).HasColumnName("_totalCount");
			});

			modelBuilder.Entity<TblPearlUsedAmount>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblPearlUsedAmount")
					.IsClustered(false);

				entity.ToTable("TblPearlUsedAmount", "PaGamePrivate");

				entity.HasComment("펄 획득, 사용량 누적내역");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.DailyResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_dailyResetTime")
					.HasComment("일단위 펄 사용량 리셋 시간");

				entity.Property(e => e.MonthlyResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_monthlyResetTime")
					.HasComment("월단위 펄 사용량 리셋 시간");

				entity.Property(e => e.PearlObtainedDaily)
					.HasColumnName("_pearlObtainedDaily")
					.HasComment("일간 펄 획득량");

				entity.Property(e => e.PearlObtainedMonthly)
					.HasColumnName("_pearlObtainedMonthly")
					.HasComment("월간 펄 획득량");

				entity.Property(e => e.PearlObtainedTotal)
					.HasColumnName("_pearlObtainedTotal")
					.HasComment("총 누적 펄 획득량");

				entity.Property(e => e.PearlObtainedWeekly)
					.HasColumnName("_pearlObtainedWeekly")
					.HasComment("주간 펄 획득량");

				entity.Property(e => e.PearlUsedDaily)
					.HasColumnName("_pearlUsedDaily")
					.HasComment("일간 펄 사용량");

				entity.Property(e => e.PearlUsedMonthly)
					.HasColumnName("_pearlUsedMonthly")
					.HasComment("월간 펄 사용량");

				entity.Property(e => e.PearlUsedTotal)
					.HasColumnName("_pearlUsedTotal")
					.HasComment("총 누적 펄 사용량");

				entity.Property(e => e.PearlUsedWeekly)
					.HasColumnName("_pearlUsedWeekly")
					.HasComment("주간 펄 사용량");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.WeeklyResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_weeklyResetTime")
					.HasComment("주단위 펄 사용량 리셋 시간");
			});

			modelBuilder.Entity<TblPearlUsedChallengeResetCount>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.MainChallengeKey })
					.HasName("PkTblPearlUsedChallenge")
					.IsClustered(false);

				entity.ToTable("TblPearlUsedChallengeResetCount", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.MainChallengeKey).HasColumnName("_mainChallengeKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResetCount)
					.HasColumnName("_resetCount")
					.HasDefaultValueSql("((0))");
			});

			modelBuilder.Entity<TblPearlUsedLastMonthAmount>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblPearlUsedLastMonthAmount")
					.IsClustered(false);

				entity.ToTable("TblPearlUsedLastMonthAmount", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.LastRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastRegisterDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.PearlObtainedMonthly).HasColumnName("_pearlObtainedMonthly");

				entity.Property(e => e.PearlUsedMonthly).HasColumnName("_pearlUsedMonthly");
			});

			modelBuilder.Entity<TblPenaltyEscape>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.UserNo })
					.HasName("PKTblPenaltyEscape");

				entity.ToTable("TblPenaltyEscape", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.StackCount).HasColumnName("_stackCount");
			});

			modelBuilder.Entity<TblPendingReward>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ItemKey, e.Type })
					.HasName("PK__TblPendi__DB64CADA2C527A24");

				entity.ToTable("TblPendingReward", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.RewardNo).HasColumnName("_rewardNo");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPendingRewardLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPendingRewardLog", "PaGamePrivate");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblPersonalBattleRanking>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season })
					.HasName("PkTblPersonalBattleRanking");

				entity.ToTable("TblPersonalBattleRanking", "PaGamePrivate");

				entity.HasComment("개인 결전 랭크 정보");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("길드 넘버");

				entity.Property(e => e.Season)
					.HasColumnName("_season")
					.HasComment("시즌");

				entity.Property(e => e.Lose)
					.HasColumnName("_lose")
					.HasComment("패배");

				entity.Property(e => e.PersonalRating)
					.HasColumnName("_personalRating")
					.HasComment("길드 점수");

				entity.Property(e => e.Win)
					.HasColumnName("_win")
					.HasComment("승리");
			});

			modelBuilder.Entity<TblPersonalDuelRanking>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Season })
					.HasName("PkTblPersonalDuelRanking");

				entity.ToTable("TblPersonalDuelRanking", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.LoseCount).HasColumnName("_loseCount");

				entity.Property(e => e.RankRating).HasColumnName("_rankRating");

				entity.Property(e => e.WinCount).HasColumnName("_winCount");
			});

			modelBuilder.Entity<TblPersonalMonsterInformation>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterKey })
					.HasName("PkTblPersonalMonsterInformation")
					.IsClustered(false);

				entity.ToTable("TblPersonalMonsterInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.LevelupTime)
					.HasColumnType("datetime")
					.HasColumnName("_levelupTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Option).HasColumnName("_option");

				entity.Property(e => e.PositionIndex).HasColumnName("_positionIndex");

				entity.Property(e => e.RemainHp).HasColumnName("_remainHp");

				entity.Property(e => e.SpawnTime)
					.HasColumnType("datetime")
					.HasColumnName("_spawnTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPersonalMonsterUserInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblPersonalMonsterUserInfo")
					.IsClustered(false);

				entity.ToTable("TblPersonalMonsterUserInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPet>(entity =>
			{
				entity.HasKey(e => e.PetNo)
					.HasName("PkTblPet")
					.IsClustered(false);

				entity.ToTable("TblPet", "PaGamePrivate");

				entity.HasComment("펫");

				entity.Property(e => e.PetNo)
					.HasColumnName("_petNo")
					.HasComment("_petNo");

				entity.Property(e => e.ActionIndex)
					.HasColumnName("_actionIndex")
					.HasComment("펫의 외형");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("_characterKey");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("펫의 경험치");

				entity.Property(e => e.Hungry)
					.HasColumnName("_hungry")
					.HasComment("펫의 배고픔");

				entity.Property(e => e.IsSealed)
					.IsRequired()
					.HasColumnName("_isSealed")
					.HasDefaultValueSql("((1))")
					.HasComment("펫이 맡겨져있는지");

				entity.Property(e => e.LearnedEquipSkillFlag)
					.HasColumnName("_learnedEquipSkillFlag")
					.HasComment("_learnedEquipSkillFlag");

				entity.Property(e => e.LearnedFlag)
					.HasColumnName("_learnedFlag")
					.HasComment("_learnedFlag");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))")
					.HasComment("펫의 레벨");

				entity.Property(e => e.Lovely)
					.HasColumnName("_lovely")
					.HasComment("펫의 애정도");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("소유 사용자번호");

				entity.Property(e => e.PetLootingType)
					.HasColumnName("_petLootingType")
					.HasDefaultValueSql("((1))")
					.HasComment("_petLootingType");

				entity.Property(e => e.PetState)
					.HasColumnName("_petState")
					.HasDefaultValueSql("((1))")
					.HasComment("맡겨진 상태 값");

				entity.Property(e => e.PetType)
					.HasColumnName("_petType")
					.HasComment("_petType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.UpgradeStackCount)
					.HasColumnName("_upgradeStackCount")
					.HasComment("_upgradeStackCount");
			});

			modelBuilder.Entity<TblPlantRepository>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Type, e.SubType, e.WaypointKey })
					.HasName("PkTblPlantRepository");

				entity.ToTable("TblPlantRepository", "PaGamePrivate");

				entity.HasComment("탐험 & 탐험과 연계되는 컨텐츠 저장소");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("사용자번호");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("_type 별로 의미가 다르다");

				entity.Property(e => e.SubType)
					.HasColumnName("_subType")
					.HasComment("_subType");

				entity.Property(e => e.WaypointKey)
					.HasColumnName("_waypointKey")
					.HasComment("대상 노드의 WaypointKey");

				entity.Property(e => e.DateTime)
					.HasColumnType("datetime")
					.HasColumnName("_dateTime")
					.HasComment("업그레이드가 완료될 시각");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.Value)
					.HasColumnName("_value")
					.HasComment("_value");
			});

			modelBuilder.Entity<TblPlayerTitle>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Key })
					.HasName("PkTblPlayerTitle");

				entity.ToTable("TblPlayerTitle", "PaGamePrivate");

				entity.HasComment("칭호 시스템");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.Key)
					.HasColumnName("_key")
					.HasComment("칭호 키");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("칭호 카운트");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasComment("칭호 종료시간");

				entity.Property(e => e.IsAcquired)
					.HasColumnName("_isAcquired")
					.HasComment("칭호 획득 여부");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblPostBoxTemplate>(entity =>
			{
				entity.HasKey(e => e.TemplateNo)
					.HasName("PkTblPostBoxTemplate")
					.IsClustered(false);

				entity.ToTable("TblPostBoxTemplate", "PaOperationPublic");

				entity.Property(e => e.TemplateNo)
					.ValueGeneratedNever()
					.HasColumnName("_templateNo");

				entity.Property(e => e.Memo)
					.HasMaxLength(200)
					.HasColumnName("_memo");

				entity.Property(e => e.Message)
					.HasMaxLength(1000)
					.HasColumnName("_message");

				entity.Property(e => e.SenderName)
					.HasMaxLength(200)
					.HasColumnName("_senderName");

				entity.Property(e => e.Title)
					.HasMaxLength(200)
					.HasColumnName("_title");
			});

			modelBuilder.Entity<TblPriorityGuildPr>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PkTblPriorityGuildPR");

				entity.ToTable("TblPriorityGuildPR", "PaGamePrivate");

				entity.Property(e => e.GuildNo)
					.ValueGeneratedNever()
					.HasColumnName("_guildNo");
			});

			modelBuilder.Entity<TblPrizeLottery>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPrizeLottery", "PaGamePrivate");

				entity.HasComment("경품 추첨");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("NPC키");

				entity.Property(e => e.EntryUserNo)
					.HasColumnName("_entryUserNo")
					.HasComment("추첨유저번호");
			});

			modelBuilder.Entity<TblProgressChallenge>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ChallengeKey })
					.HasName("PkTblProgressChallenge")
					.IsClustered(false);

				entity.ToTable("TblProgressChallenge", "PaGamePrivate");

				entity.HasComment("진행중-도전과제 및 pc방 정액제");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.ChallengeKey)
					.HasColumnName("_challengeKey")
					.HasComment("도전과제 키-DataSheet_Challenge$Challenge_Table");

				entity.Property(e => e.ParamNumber).HasColumnName("_paramNumber");

				entity.Property(e => e.ParamTime).HasColumnName("_paramTime");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblProgressExpedition>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblProgressExpedition", "PaGamePrivate");

				entity.HasComment("토벌테이블");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.GroupKey)
					.HasColumnName("_groupKey")
					.HasComment("토벌 그룹");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("토벌 등록 시간");

				entity.Property(e => e.SlotIndex)
					.HasColumnName("_slotIndex")
					.HasComment("토벌 지역");

				entity.Property(e => e.UnitNo)
					.HasColumnName("_unitNo")
					.HasComment("유닛 번호");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 번호");
			});

			modelBuilder.Entity<TblProgressingGuildDuel>(entity =>
			{
				entity.HasKey(e => e.DuelNo)
					.HasName("PkTblProgressingGuildDuel");

				entity.ToTable("TblProgressingGuildDuel", "PaGamePrivate");

				entity.HasComment("길드 결전 정보");

				entity.Property(e => e.DuelNo)
					.HasColumnName("_duelNo")
					.HasComment("길드 결전 번호");

				entity.Property(e => e.AcceptGuildKill)
					.HasColumnName("_acceptGuildKill")
					.HasComment("수락한 길드가 죽인 횟수");

				entity.Property(e => e.AcceptGuildNo)
					.HasColumnName("_acceptGuildNo")
					.HasComment("결전 수락한 길드 번호");

				entity.Property(e => e.Deadline)
					.HasColumnType("datetime")
					.HasColumnName("_deadline")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("마감 시간");

				entity.Property(e => e.DeclareGuildKill)
					.HasColumnName("_declareGuildKill")
					.HasComment("선포한 길드가 죽인 횟수");

				entity.Property(e => e.DeclareGuildNo)
					.HasColumnName("_declareGuildNo")
					.HasComment("결전 선포한 길드 번호");

				entity.Property(e => e.Prize)
					.HasColumnName("_prize")
					.HasComment("상금");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TargetKill)
					.HasColumnName("_targetKill")
					.HasComment("목표 킬수");
			});

			modelBuilder.Entity<TblProgressingNewQuest>(entity =>
			{
				entity.HasKey(e => new { e.UserCharacterNo, e.IsUserBaseQuest, e.QuestGroupNo, e.QuestNo })
					.HasName("PkTblProgressingNewQuest")
					.IsClustered(false);

				entity.ToTable("TblProgressingNewQuest", "PaGamePrivate");

				entity.HasComment("퀘스트 진행 목록");

				entity.Property(e => e.UserCharacterNo)
					.HasColumnName("_userCharacterNo")
					.HasComment("유저,캐릭터번호");

				entity.Property(e => e.IsUserBaseQuest)
					.HasColumnName("_isUserBaseQuest")
					.HasComment("1이면 유저 0이면 캐릭터 기반");

				entity.Property(e => e.QuestGroupNo)
					.HasColumnName("_questGroupNo")
					.HasComment("_questGroupNo");

				entity.Property(e => e.QuestNo)
					.HasColumnName("_questNo")
					.HasComment("퀘스트번호");

				entity.Property(e => e.Count1)
					.HasColumnName("_count1")
					.HasComment("_count1");

				entity.Property(e => e.Count2)
					.HasColumnName("_count2")
					.HasComment("_count2");

				entity.Property(e => e.Count3)
					.HasColumnName("_count3")
					.HasComment("_count3");

				entity.Property(e => e.Count4)
					.HasColumnName("_count4")
					.HasComment("_count4");

				entity.Property(e => e.Count5)
					.HasColumnName("_count5")
					.HasComment("_count5");

				entity.Property(e => e.OrderTime)
					.HasColumnType("datetime")
					.HasColumnName("_orderTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_orderTime");
			});

			modelBuilder.Entity<TblProposeList>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.NpcKey })
					.HasName("PkTblProposeList");

				entity.ToTable("TblProposeList", "PaGamePrivate");

				entity.HasComment("고백 리스트 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("고백한 유저번호");

				entity.Property(e => e.NpcKey)
					.HasColumnName("_npcKey")
					.HasComment("npc 번호");
			});

			modelBuilder.Entity<TblPs4cashInfoLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblPS4CashInfoLog", "PaGamePrivate");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.CreatedCount).HasColumnName("_createdCount");

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

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblPurchasedClassType>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ClassType })
					.HasName("PKTblPurchasedClassType");

				entity.ToTable("TblPurchasedClassType", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblPurchasedSkin>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SkinKey })
					.HasName("PKTblPurchasedSkin");

				entity.ToTable("TblPurchasedSkin", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SkinKey).HasColumnName("_skinKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblQuizEventUserInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblQuizEventUserInfo");

				entity.ToTable("TblQuizEventUserInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.CorrectCount).HasColumnName("_correctCount");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblRandomPartyMatching>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.RegisterDate, e.UserNo })
					.HasName("PkTblRandomPartyMatching");

				entity.ToTable("TblRandomPartyMatching", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.EnterServerNo).HasColumnName("_enterServerNo");
			});

			modelBuilder.Entity<TblRecordGuildVolunteerScore>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblRecordGuildVolunteerScore", "PaGamePrivate");

				entity.HasComment("길드 용병 리스트");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasComment("캐릭터 넘버");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 넘버");

				entity.Property(e => e.DeathCount)
					.HasColumnName("_deathCount")
					.HasComment("사망 횟수");

				entity.Property(e => e.IsVillageSiege)
					.HasColumnName("_isVillageSiege")
					.HasComment("거점전 인지");

				entity.Property(e => e.KillCount)
					.HasColumnName("_killCount")
					.HasComment("죽인 횟수");

				entity.Property(e => e.MissionComplete)
					.HasColumnName("_missionComplete")
					.HasComment("용병 성공 했는지");

				entity.Property(e => e.OriginalGuilNo)
					.HasColumnName("_originalGuilNo")
					.HasComment("원래 길드 넘버");

				entity.Property(e => e.OriginalGuildName)
					.HasMaxLength(30)
					.HasColumnName("_originalGuildName")
					.HasComment("원래 길드 이름");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("거점 리전 키");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.SiegeScoreNo)
					.HasColumnName("_siegeScoreNo")
					.HasComment("거점/점령전 요일");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasComment("유저 가문명");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 넘버");

				entity.Property(e => e.VolunteerGuilNo)
					.HasColumnName("_volunteerGuilNo")
					.HasComment("용병 길드 넘버");

				entity.Property(e => e.VolunteerguildName)
					.HasMaxLength(30)
					.HasColumnName("_volunteerguildName")
					.HasComment("용병 길드 이름");
			});

			modelBuilder.Entity<TblRegionGroup>(entity =>
			{
				entity.HasKey(e => e.RegionGroupKey)
					.HasName("PkTblRegionGroup")
					.IsClustered(false);

				entity.ToTable("TblRegionGroup", "PaGamePrivate");

				entity.HasComment("영역별 정보");

				entity.Property(e => e.RegionGroupKey)
					.ValueGeneratedNever()
					.HasColumnName("_regionGroupKey")
					.HasComment("_regionGroupKey");

				entity.Property(e => e.CorpProductivity)
					.HasColumnName("_corpProductivity")
					.HasComment("농산물 생산력");

				entity.Property(e => e.FishingProductivity)
					.HasColumnName("_fishingProductivity")
					.HasComment("낚시 생산력");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("마지막 수정일시");

				entity.Property(e => e.Loyalty)
					.HasColumnName("_loyalty")
					.HasComment("충성도");
			});

			modelBuilder.Entity<TblRentInstanceField>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex })
					.HasName("PkTblRentInstanceField")
					.IsClustered(false);

				entity.ToTable("TblRentInstanceField", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UniqueIndex).HasColumnName("_uniqueIndex");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.HostUserNickName)
					.HasMaxLength(30)
					.HasColumnName("_hostUserNickName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.HostUserNo)
					.HasColumnName("_hostUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.InstanceFieldMapKey)
					.HasColumnName("_instanceFieldMapKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.ReCount).HasColumnName("_reCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblRentInstanceFieldPass>(entity =>
			{
				entity.HasKey(e => new { e.InstanceFieldKey, e.ServerNo, e.UniqueIndex, e.UserNo })
					.HasName("PkTblRentInstanceFieldPass")
					.IsClustered(false);

				entity.ToTable("TblRentInstanceFieldPass", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UniqueIndex).HasColumnName("_uniqueIndex");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.HostUserNo)
					.HasColumnName("_hostUserNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<TblRequestGuildInviteList>(entity =>
			{
				entity.HasKey(e => new { e.RegisterDate, e.HostGuildNo, e.ReceiveUserNo })
					.HasName("PkTblRequestGuildInviteList");

				entity.ToTable("TblRequestGuildInviteList", "PaGamePrivate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.HostGuildNo).HasColumnName("_hostGuildNo");

				entity.Property(e => e.ReceiveUserNo).HasColumnName("_receiveUserNo");

				entity.Property(e => e.ContractBenefit).HasColumnName("_contractBenefit");

				entity.Property(e => e.ContractDay).HasColumnName("_contractDay");

				entity.Property(e => e.ContractPenalty).HasColumnName("_contractPenalty");

				entity.Property(e => e.HostUserNo).HasColumnName("_hostUserNo");
			});

			modelBuilder.Entity<TblReservationArsha>(entity =>
			{
				entity.HasKey(e => new { e.ReservationDay, e.ServerNo })
					.HasName("PkTblReservationArsha");

				entity.ToTable("TblReservationArsha", "PaGamePrivate");

				entity.HasComment("아르샤의 창 예약");

				entity.Property(e => e.ReservationDay)
					.HasColumnType("datetime")
					.HasColumnName("_reservationDay")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("예약일");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("예약 채널 번호");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName")
					.HasComment("예약 길드 이름");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("예약 길드 번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("예약 등록시간");
			});

			modelBuilder.Entity<TblRestoreItemRepository>(entity =>
			{
				entity.HasKey(e => e.ItemNo)
					.HasName("PkTblRestoreItemRepository")
					.IsClustered(false);

				entity.ToTable("TblRestoreItemRepository", "PaGamePrivate");

				entity.Property(e => e.ItemNo)
					.ValueGeneratedNever()
					.HasColumnName("_itemNo");

				entity.Property(e => e.BuyingPrice).HasColumnName("_buyingPrice");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.DyeingList)
					.HasMaxLength(24)
					.HasColumnName("_dyeingList");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.Endurance).HasColumnName("_endurance");

				entity.Property(e => e.ExpirationDate)
					.HasColumnType("datetime")
					.HasColumnName("_expirationDate");

				entity.Property(e => e.IsExpirationDyeing).HasColumnName("_isExpirationDyeing");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.IsSeized).HasColumnName("_isSeized");

				entity.Property(e => e.IsValid).HasColumnName("_isValid");

				entity.Property(e => e.IsVested).HasColumnName("_isVested");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.MaxEndurance).HasColumnName("_maxEndurance");

				entity.Property(e => e.OldItemNo).HasColumnName("_oldItemNo");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.ProductionRegionKey).HasColumnName("_productionRegionKey");

				entity.Property(e => e.PushedItemKey0).HasColumnName("_pushedItemKey0");

				entity.Property(e => e.PushedItemKey1).HasColumnName("_pushedItemKey1");

				entity.Property(e => e.PushedItemKey2).HasColumnName("_pushedItemKey2");

				entity.Property(e => e.PushedItemKey3).HasColumnName("_pushedItemKey3");

				entity.Property(e => e.PushedItemKey4).HasColumnName("_pushedItemKey4");

				entity.Property(e => e.PushedItemKey5).HasColumnName("_pushedItemKey5");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.RemainedCount).HasColumnName("_remainedCount");

				entity.Property(e => e.VariableDate)
					.HasColumnType("datetime")
					.HasColumnName("_variableDate");

				entity.Property(e => e.VariousNo).HasColumnName("_variousNo");
			});

			modelBuilder.Entity<TblRestoreItemUserInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.RestoreType })
					.HasName("PkTblRestoreItemUserInfo");

				entity.ToTable("TblRestoreItemUserInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.RestoreType).HasColumnName("_restoreType");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.NextResetDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextResetDate");
			});

			modelBuilder.Entity<TblRestoreServantList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblRestoreServantList", "PaOperationPublic");

				entity.Property(e => e.CharacterKey).HasColumnName("_characterKey");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServantNo).HasColumnName("_servantNo");

				entity.Property(e => e.WhereType).HasColumnName("_whereType");
			});

			modelBuilder.Entity<TblReturnStone>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.TeleportType })
					.HasName("PkTblReturnStone")
					.IsClustered(false);

				entity.ToTable("TblReturnStone", "PaGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.TeleportType).HasColumnName("_teleportType");

				entity.Property(e => e.ReturnPositionX).HasColumnName("_returnPositionX");

				entity.Property(e => e.ReturnPositionY).HasColumnName("_returnPositionY");

				entity.Property(e => e.ReturnPositionZ).HasColumnName("_returnPositionZ");

				entity.Property(e => e.ReturnRegionKey).HasColumnName("_returnRegionKey");

				entity.Property(e => e.UsableDate)
					.HasColumnType("datetime")
					.HasColumnName("_usableDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblScreenShot>(entity =>
			{
				entity.HasKey(e => e.ScreenNo)
					.HasName("PkTblScreenShot")
					.IsClustered(false);

				entity.ToTable("TblScreenShot", "PaWebGamePrivate");

				entity.Property(e => e.ScreenNo).HasColumnName("_screenNo");

				entity.Property(e => e.Category).HasColumnName("_category");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CommentCount).HasColumnName("_commentCount");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.IsMine).HasColumnName("_isMine");

				entity.Property(e => e.IsSignature).HasColumnName("_isSignature");

				entity.Property(e => e.LikeCount).HasColumnName("_likeCount");

				entity.Property(e => e.Regdate)
					.HasColumnType("datetime")
					.HasColumnName("_regdate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ScreenDescription)
					.HasMaxLength(4000)
					.HasColumnName("_screenDescription");

				entity.Property(e => e.ScreenImage1)
					.HasMaxLength(200)
					.HasColumnName("_screenImage1");

				entity.Property(e => e.ScreenImage2)
					.HasMaxLength(200)
					.HasColumnName("_screenImage2");

				entity.Property(e => e.ScreenImage3)
					.HasMaxLength(200)
					.HasColumnName("_screenImage3");

				entity.Property(e => e.ScreenImage4)
					.HasMaxLength(200)
					.HasColumnName("_screenImage4");

				entity.Property(e => e.ScreenImage5)
					.HasMaxLength(200)
					.HasColumnName("_screenImage5");

				entity.Property(e => e.ScreenImage6)
					.HasMaxLength(200)
					.HasColumnName("_screenImage6");

				entity.Property(e => e.ScreenSignImage1)
					.HasMaxLength(200)
					.HasColumnName("_screenSignImage1");

				entity.Property(e => e.ScreenSignImage2)
					.HasMaxLength(200)
					.HasColumnName("_screenSignImage2");

				entity.Property(e => e.ScreenSignImage3)
					.HasMaxLength(200)
					.HasColumnName("_screenSignImage3");

				entity.Property(e => e.ScreenSignImage4)
					.HasMaxLength(200)
					.HasColumnName("_screenSignImage4");

				entity.Property(e => e.ScreenSignImage5)
					.HasMaxLength(200)
					.HasColumnName("_screenSignImage5");

				entity.Property(e => e.ScreenSignImage6)
					.HasMaxLength(200)
					.HasColumnName("_screenSignImage6");

				entity.Property(e => e.ScreenThumb)
					.HasMaxLength(200)
					.HasColumnName("_screenThumb");

				entity.Property(e => e.ScreenTitle)
					.HasMaxLength(50)
					.HasColumnName("_screenTitle");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ViewCount).HasColumnName("_viewCount");
			});

			modelBuilder.Entity<TblScreenShotBlind>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblScreenShotBlind", "PaWebGamePrivate");

				entity.Property(e => e.BlindDate)
					.HasColumnType("datetime")
					.HasColumnName("_blindDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.BlindUserNo).HasColumnName("_blindUserNo");

				entity.Property(e => e.ScreenNo).HasColumnName("_screenNo");
			});

			modelBuilder.Entity<TblScreenShotComment>(entity =>
			{
				entity.HasKey(e => e.ScreenCommentNo)
					.HasName("PkTblScreenShotComment");

				entity.ToTable("TblScreenShotComment", "PaWebGamePrivate");

				entity.Property(e => e.ScreenCommentNo).HasColumnName("_screenCommentNo");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.CommentRegdate)
					.HasColumnType("datetime")
					.HasColumnName("_CommentRegdate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.CommentReportCount).HasColumnName("_commentReportCount");

				entity.Property(e => e.CommentUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_CommentUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.ScreenComment)
					.HasMaxLength(500)
					.HasColumnName("_screenComment");

				entity.Property(e => e.ScreenNo).HasColumnName("_screenNo");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblScreenShotCommentReport>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblScreenShotCommentReport", "PaWebGamePrivate");

				entity.Property(e => e.BlindType)
					.HasMaxLength(1)
					.IsUnicode(false)
					.HasColumnName("_blindType")
					.HasDefaultValueSql("('')")
					.IsFixedLength();

				entity.Property(e => e.IsBlind).HasColumnName("_isBlind");

				entity.Property(e => e.ReportDate)
					.HasColumnType("datetime")
					.HasColumnName("_reportDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ScreenCommentNo).HasColumnName("_screenCommentNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblScreenShotLikeLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblScreenShotLikeLog", "PaWebGamePrivate");

				entity.Property(e => e.LikeDate)
					.HasColumnType("datetime")
					.HasColumnName("_LikeDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ScreenNo).HasColumnName("_screenNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSeasonChangeLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonChangeLog", "PaGamePrivate");

				entity.Property(e => e.IsSuccess).HasColumnName("_isSuccess");

				entity.Property(e => e.Message)
					.HasMaxLength(50)
					.HasColumnName("_message");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.Type).HasColumnName("_type");
			});

			modelBuilder.Entity<TblSeasonCharacter>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCharacter", "PaGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.IsDeleted).HasColumnName("_isDeleted");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSeasonCloseChallenge>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseChallenge", "PaGamePrivate");

				entity.Property(e => e.ChallengeKey).HasColumnName("_challengeKey");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasDefaultValueSql("((2))");
			});

			modelBuilder.Entity<TblSeasonCloseChallengeInfo>(entity =>
			{
				entity.HasKey(e => new { e.ChallengeKey, e.CloseType })
					.HasName("PkTblTblSeasonCloseChallengeInfo")
					.IsClustered(false);

				entity.ToTable("TblSeasonCloseChallengeInfo", "PaGamePrivate");

				entity.Property(e => e.ChallengeKey).HasColumnName("_challengeKey");

				entity.Property(e => e.CloseType).HasColumnName("_closeType");
			});

			modelBuilder.Entity<TblSeasonCloseChallengeWithReward>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseChallengeWithReward", "PaGamePrivate");

				entity.Property(e => e.ChallengeKey).HasColumnName("_challengeKey");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemEnchant).HasColumnName("_itemEnchant");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblSeasonCloseChangeItem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseChangeItem", "PaGamePrivate");

				entity.Property(e => e.AlterItemKey).HasColumnName("_alterItemKey");

				entity.Property(e => e.BeforeItemKey).HasColumnName("_beforeItemKey");

				entity.Property(e => e.ChangeItemKey).HasColumnName("_changeItemKey");
			});

			modelBuilder.Entity<TblSeasonCloseCharacterType>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseCharacterType", "PaGamePrivate");

				entity.Property(e => e.FromType).HasColumnName("_fromType");

				entity.Property(e => e.ToType).HasColumnName("_toType");
			});

			modelBuilder.Entity<TblSeasonCloseDeleteItem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseDeleteItem", "PaGamePrivate");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblSeasonCloseItemInfo>(entity =>
			{
				entity.HasKey(e => new { e.ItemKey, e.CloseType })
					.HasName("PkTblTblSeasonCloseItemInfo")
					.IsClustered(false);

				entity.ToTable("TblSeasonCloseItemInfo", "PaGamePrivate");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.CloseType).HasColumnName("_closeType");
			});

			modelBuilder.Entity<TblSeasonCloseQuest>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseQuest", "PaGamePrivate");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasDefaultValueSql("((2))");
			});

			modelBuilder.Entity<TblSeasonCloseQuestInfo>(entity =>
			{
				entity.HasKey(e => new { e.QuestGroupNo, e.QuestNo, e.CloseType })
					.HasName("PkTblTblSeasonCloseQuestInfo")
					.IsClustered(false);

				entity.ToTable("TblSeasonCloseQuestInfo", "PaGamePrivate");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");

				entity.Property(e => e.CloseType).HasColumnName("_closeType");
			});

			modelBuilder.Entity<TblSeasonCloseQuestWithReward>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonCloseQuestWithReward", "PaGamePrivate");

				entity.Property(e => e.Contents)
					.HasMaxLength(300)
					.HasColumnName("_contents");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");

				entity.Property(e => e.SenderName)
					.HasMaxLength(30)
					.HasColumnName("_senderName");

				entity.Property(e => e.Title)
					.HasMaxLength(100)
					.HasColumnName("_title");
			});

			modelBuilder.Entity<TblSeasonInfo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonInfo", "PaGamePrivate");

				entity.Property(e => e.EndDate)
					.HasColumnType("date")
					.HasColumnName("_endDate");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.SeasonName)
					.HasMaxLength(50)
					.HasColumnName("_seasonName");

				entity.Property(e => e.StartDate)
					.HasColumnType("date")
					.HasColumnName("_startDate");
			});

			modelBuilder.Entity<TblSeasonParam>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonParam", "PaGamePrivate");

				entity.Property(e => e.Info)
					.HasMaxLength(50)
					.HasColumnName("_info");

				entity.Property(e => e.InfoNo).HasColumnName("_infoNo");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Param5).HasColumnName("_param5");

				entity.Property(e => e.Season).HasColumnName("_season");

				entity.Property(e => e.Type).HasColumnName("_type");
			});

			modelBuilder.Entity<TblSeasonResetMail>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSeasonResetMail", "PaGamePrivate");

				entity.Property(e => e.Contents)
					.HasMaxLength(500)
					.HasColumnName("_contents");

				entity.Property(e => e.Info)
					.HasMaxLength(50)
					.HasColumnName("_info");

				entity.Property(e => e.InfoNo).HasColumnName("_infoNo");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.Region)
					.HasMaxLength(10)
					.HasColumnName("_region");

				entity.Property(e => e.SenderName)
					.HasMaxLength(50)
					.HasColumnName("_senderName");

				entity.Property(e => e.Title)
					.HasMaxLength(50)
					.HasColumnName("_title");
			});

			modelBuilder.Entity<TblSeasonReward>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SelectedItemKey })
					.HasName("PkTblTblSeasonReward")
					.IsClustered(false);

				entity.ToTable("TblSeasonReward", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SelectedItemKey).HasColumnName("_selectedItemKey");

				entity.Property(e => e.SelectedItemEnchantLevel).HasColumnName("_selectedItemEnchantLevel");
			});

			modelBuilder.Entity<TblServantMating>(entity =>
			{
				entity.HasKey(e => e.MatingNo)
					.HasName("PkTblServantMating");

				entity.ToTable("TblServantMating", "PaGamePrivate");

				entity.HasComment("말 교배 정보");

				entity.Property(e => e.MatingNo)
					.HasColumnName("_matingNo")
					.HasComment("교배 고유 번호");

				entity.Property(e => e.ChildCharacterKey)
					.HasColumnName("_childCharacterKey")
					.HasComment("망아지 캐릭터 키");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasComment("교배 종료 시간");

				entity.Property(e => e.FemaleServantNo)
					.HasColumnName("_femaleServantNo")
					.HasComment("암컷 말 고유 번호");

				entity.Property(e => e.IsMaleStallion)
					.HasColumnName("_isMaleStallion")
					.HasDefaultValueSql("((0))")
					.HasComment("수컷 말 종마 구분");

				entity.Property(e => e.MaleServantNo)
					.HasColumnName("_maleServantNo")
					.HasComment("수컷 말 고유 번호");

				entity.Property(e => e.StartDate)
					.HasColumnType("datetime")
					.HasColumnName("_startDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("교배 시작 시간");
			});

			modelBuilder.Entity<TblServantRepository>(entity =>
			{
				entity.HasKey(e => e.ServantNo)
					.HasName("PkTblServantRepository");

				entity.ToTable("TblServantRepository", "PaGamePrivate");

				entity.HasComment("Servant 정보");

				entity.Property(e => e.ServantNo)
					.HasColumnName("_servantNo")
					.HasComment("고유 번호");

				entity.Property(e => e.AwakenStack)
					.HasColumnName("_awakenStack")
					.HasComment("준마 각성 스택");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("캐릭터 키");

				entity.Property(e => e.ClearCountByDead)
					.HasColumnName("_clearCountByDead")
					.HasComment("죽은 횟수 초기화 아이템 사용 횟수");

				entity.Property(e => e.ClearCountByMating)
					.HasColumnName("_clearCountByMating")
					.HasComment("교배 횟수 추가 아이템 사용 횟수");

				entity.Property(e => e.CurrentFieldIndex)
					.HasColumnName("_currentFieldIndex")
					.HasComment("_currentFieldIndex");

				entity.Property(e => e.CurrentFieldNo)
					.HasColumnName("_currentFieldNo")
					.HasComment("_currentFieldNo");

				entity.Property(e => e.CurrentPositionX)
					.HasColumnName("_currentPositionX")
					.HasComment("_currentPositionX");

				entity.Property(e => e.CurrentPositionY)
					.HasColumnName("_currentPositionY")
					.HasComment("_currentPositionY");

				entity.Property(e => e.CurrentPositionZ)
					.HasColumnName("_currentPositionZ")
					.HasComment("_currentPositionZ");

				entity.Property(e => e.DeadCount).HasColumnName("_deadCount");

				entity.Property(e => e.DeleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_deleteDate")
					.HasComment("삭제 일시");

				entity.Property(e => e.Direction)
					.HasColumnName("_direction")
					.HasDefaultValueSql("((0))")
					.HasComment("_direction");

				entity.Property(e => e.DyeingList)
					.HasMaxLength(24)
					.HasColumnName("_dyeingList")
					.HasComment("염색");

				entity.Property(e => e.EndSkillExpTrainingTime)
					.HasColumnType("datetime")
					.HasColumnName("_endSkillExpTrainingTime")
					.HasComment("스킬 훈련 종료시간");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("경험치");

				entity.Property(e => e.ExpiredTime)
					.HasColumnType("datetime")
					.HasColumnName("_expiredTime")
					.HasComment("경험치");

				entity.Property(e => e.Food)
					.HasColumnName("_food")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.FormIndex)
					.HasColumnName("_formIndex")
					.HasComment("외형 인덱스");

				entity.Property(e => e.Hp)
					.HasColumnName("_hp")
					.HasDefaultValueSql("((1))")
					.HasComment("체력");

				entity.Property(e => e.IsImprint)
					.HasColumnName("_isImprint")
					.HasComment("각인(유/무)");

				entity.Property(e => e.IsSeized)
					.HasColumnName("_isSeized")
					.HasComment("압류(유/무)");

				entity.Property(e => e.LastServerNo)
					.HasColumnName("_lastServerNo")
					.HasComment("소환된 서버 번호");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))")
					.HasComment("레벨");

				entity.Property(e => e.MatingCount)
					.HasColumnName("_matingCount")
					.HasComment("교배 횟수");

				entity.Property(e => e.MatingNo)
					.HasColumnName("_matingNo")
					.HasComment("교배 고유 번호");

				entity.Property(e => e.Mp)
					.HasColumnName("_mp")
					.HasComment("스태미너");

				entity.Property(e => e.Name)
					.HasMaxLength(30)
					.HasColumnName("_name")
					.HasComment("이름");

				entity.Property(e => e.OwnerCharacterNo)
					.HasColumnName("_ownerCharacterNo")
					.HasComment("소유자 유저 고유 번호");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("소유자 고유 번호");

				entity.Property(e => e.OwnerServantNo)
					.HasColumnName("_ownerServantNo")
					.HasComment("연결된 마차 번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 일시");

				entity.Property(e => e.RentEndDate)
					.HasColumnType("datetime")
					.HasColumnName("_rentEndDate");

				entity.Property(e => e.RentOwnerNo)
					.HasColumnName("_rentOwnerNo")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.SealRegion)
					.HasColumnName("_sealRegion")
					.HasComment("_sealRegion");

				entity.Property(e => e.ServantBasicCacheSeqNo)
					.HasColumnName("_servantBasicCacheSeqNo")
					.HasComment("캐싱 시퀀스번호");

				entity.Property(e => e.SkillDiceCount).HasColumnName("_skillDiceCount");

				entity.Property(e => e.SkillFailedCount)
					.HasColumnName("_skillFailedCount")
					.HasComment("스킬 변경 실패 횟수");

				entity.Property(e => e.StatParam1)
					.HasColumnName("_statParam1")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.StatParam2)
					.HasColumnName("_statParam2")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.StatParam3)
					.HasColumnName("_statParam3")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.StateType)
					.HasColumnName("_stateType")
					.HasComment("말 상태");

				entity.Property(e => e.SympatheticCoolTime)
					.HasColumnName("_sympatheticCoolTime")
					.HasComment("교감쿨타임(밀리초)");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("캐릭터 타입(지상, 수상)");

				entity.Property(e => e.UnsealDelayTime)
					.HasColumnType("datetime")
					.HasColumnName("_unsealDelayTime")
					.HasComment("서번트 소환 가능 시간");

				entity.Property(e => e.UseAccelerationStatItem).HasColumnName("_useAccelerationStatItem");

				entity.Property(e => e.UseBrakeStatItem).HasColumnName("_useBrakeStatItem");

				entity.Property(e => e.UseCorneringStatItem).HasColumnName("_useCorneringStatItem");

				entity.Property(e => e.UseMoveSpeedStatItem).HasColumnName("_useMoveSpeedStatItem");

				entity.Property(e => e.VariedAcceleration)
					.HasColumnName("_variedAcceleration")
					.HasComment("성장 가변 가속도");

				entity.Property(e => e.VariedBrake)
					.HasColumnName("_variedBrake")
					.HasComment("성장 가변 브레이크");

				entity.Property(e => e.VariedCannonAccuracy)
					.HasColumnName("_variedCannonAccuracy")
					.HasComment("성장 가변 대포 정확도");

				entity.Property(e => e.VariedCannonCoolTime)
					.HasColumnName("_variedCannonCoolTime")
					.HasComment("성장 가변 대포 쿨타임");

				entity.Property(e => e.VariedCannonMaxAngle)
					.HasColumnName("_variedCannonMaxAngle")
					.HasComment("성장 가변 대포 각도");

				entity.Property(e => e.VariedCannonMaxLength)
					.HasColumnName("_variedCannonMaxLength")
					.HasComment("성장 가변 대포 사거리");

				entity.Property(e => e.VariedCornering)
					.HasColumnName("_variedCornering")
					.HasComment("성장 가변 코너링");

				entity.Property(e => e.VariedMaxHp)
					.HasColumnName("_variedMaxHp")
					.HasComment("_variedMaxHp");

				entity.Property(e => e.VariedMaxMp)
					.HasColumnName("_variedMaxMp")
					.HasComment("_variedMaxMp");

				entity.Property(e => e.VariedMoveSpeed)
					.HasColumnName("_variedMoveSpeed")
					.HasComment("성장 가변 속도");

				entity.Property(e => e.WhereType)
					.HasColumnName("_whereType")
					.HasComment("소유자 타입");
			});

			modelBuilder.Entity<TblServantStallionSkillInfo>(entity =>
			{
				entity.HasKey(e => new { e.Tier, e.SkillNo })
					.HasName("PkTblTblServantStallionSkillInfo");

				entity.ToTable("TblServantStallionSkillInfo", "PaGamePrivate");

				entity.Property(e => e.Tier).HasColumnName("_tier");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");
			});

			modelBuilder.Entity<TblServantTierInfo>(entity =>
			{
				entity.HasKey(e => e.CharacterKey)
					.HasName("PkTblServantTierInfo");

				entity.ToTable("TblServantTierInfo", "PaGamePrivate");

				entity.HasComment("tier 정보");

				entity.Property(e => e.CharacterKey)
					.ValueGeneratedNever()
					.HasColumnName("_characterKey")
					.HasComment("탑승물 characterKey");

				entity.Property(e => e.SexType)
					.HasColumnName("_sexType")
					.HasComment("탑승물 성별 (0: 수컷, 1: 암컷)");

				entity.Property(e => e.Tier)
					.HasColumnName("_tier")
					.HasComment("탑승물 tier");
			});

			modelBuilder.Entity<TblShaBriefUserInfoNewTagTargetUser>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblShaBriefUserInfo_NewTagTargetUser", "PaOperationPrivate");

				entity.Property(e => e.Idx).HasColumnName("_idx");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblShaFreeClassType>(entity =>
			{
				entity.HasKey(e => e.ClassType)
					.HasName("PKTblShaFreeClassType");

				entity.ToTable("TblShaFreeClassType", "PaGamePrivate");

				entity.Property(e => e.ClassType).HasColumnName("_classType");
			});

			modelBuilder.Entity<TblShadowArenaAbusingUser>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblShadowArenaAbusingUser");

				entity.ToTable("TblShadowArenaAbusingUser", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblShadowArenaAttendance>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Key, e.Day })
					.HasName("PKTblShadowArenaAttendance")
					.IsClustered(false);

				entity.ToTable("TblShadowArenaAttendance", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Key).HasColumnName("_key");

				entity.Property(e => e.Day).HasColumnName("_day");

				entity.Property(e => e.ReceiveDate)
					.HasColumnType("datetime")
					.HasColumnName("_receiveDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblShadowArenaAttendanceOption>(entity =>
			{
				entity.HasKey(e => e.Key)
					.HasName("PKTblShadowArenaAttendanceOption");

				entity.ToTable("TblShadowArenaAttendanceOption", "PaGamePrivate");

				entity.Property(e => e.Key)
					.ValueGeneratedNever()
					.HasColumnName("_key");

				entity.Property(e => e.BeginDate)
					.HasColumnType("datetime")
					.HasColumnName("_beginDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblShadowArenaBriefUserInformation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblShadowArenaBriefUserInformation");

				entity.ToTable("TblShadowArenaBriefUserInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.AccountExp).HasColumnName("_accountExp");

				entity.Property(e => e.AccountLevel).HasColumnName("_accountLevel");

				entity.Property(e => e.AllCharacterBoostEndTime)
					.HasColumnType("datetime")
					.HasColumnName("_allCharacterBoostEndTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.AuthorityIndex).HasColumnName("_authorityIndex");

				entity.Property(e => e.CurrentAccountRewardLevel)
					.HasColumnName("_currentAccountRewardLevel")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ExpBoostEndTime)
					.HasColumnType("datetime")
					.HasColumnName("_expBoostEndTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.IsEnterBattle).HasColumnName("_isEnterBattle");

				entity.Property(e => e.IsNewMail).HasColumnName("_isNewMail");

				entity.Property(e => e.IsOnline).HasColumnName("_isOnline");

				entity.Property(e => e.IsTutorialComplete)
					.IsRequired()
					.HasColumnName("_isTutorialComplete")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.LastClassType).HasColumnName("_lastClassType");

				entity.Property(e => e.LastTutorialFlowType).HasColumnName("_lastTutorialFlowType");

				entity.Property(e => e.MainMatchTicket).HasColumnName("_mainMatchTicket");

				entity.Property(e => e.MoneyBoostEndTime)
					.HasColumnType("datetime")
					.HasColumnName("_moneyBoostEndTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.PreliminaryMatchTicket).HasColumnName("_preliminaryMatchTicket");

				entity.Property(e => e.SelectedProfileEffectKey).HasColumnName("_selectedProfileEffectKey");

				entity.Property(e => e.SelectedProfileFrameKey).HasColumnName("_selectedProfileFrameKey");

				entity.Property(e => e.SelectedProfileIconKey)
					.HasColumnName("_selectedProfileIconKey")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.SkinSetting)
					.HasMaxLength(2000)
					.HasColumnName("_skinSetting");

				entity.Property(e => e.SpecialMatchTicket).HasColumnName("_specialMatchTicket");

				entity.Property(e => e.WeaponSkinSetting)
					.HasMaxLength(2000)
					.HasColumnName("_weaponSkinSetting");
			});

			modelBuilder.Entity<TblShadowArenaCharacter>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ClassType })
					.HasName("PkTblShadowArenaCharacter")
					.IsClustered(false);

				entity.ToTable("TblShadowArenaCharacter", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.Experience).HasColumnName("_experience");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<TblShadowArenaClanApplicant>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblShadowArenaClanApplicant");

				entity.ToTable("TblShadowArenaClanApplicant", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.ClanNo).HasColumnName("_clanNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");
			});

			modelBuilder.Entity<TblShadowArenaClanAssembleFlag>(entity =>
			{
				entity.HasKey(e => e.GuildNo)
					.HasName("PKTblShadowArenaClanAssembleFlag");

				entity.ToTable("TblShadowArenaClanAssembleFlag", "PaGamePrivate");

				entity.Property(e => e.GuildNo)
					.ValueGeneratedNever()
					.HasColumnName("_guildNo");

				entity.Property(e => e.InstanceFieldKey)
					.HasColumnName("_instanceFieldKey")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.PositionX).HasColumnName("_positionX");

				entity.Property(e => e.PositionY).HasColumnName("_positionY");

				entity.Property(e => e.PositionZ).HasColumnName("_positionZ");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.SummonTime)
					.HasColumnType("datetime")
					.HasColumnName("_summonTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UniqueIndex).HasColumnName("_uniqueIndex");
			});

			modelBuilder.Entity<TblShadowArenaClanChat>(entity =>
			{
				entity.HasKey(e => e.ChatIdx)
					.HasName("PKTblShadowArenaClanChat")
					.IsClustered(false);

				entity.ToTable("TblShadowArenaClanChat", "PaGamePrivate");

				entity.Property(e => e.ChatIdx).HasColumnName("_chatIdx");

				entity.Property(e => e.ChatMsg)
					.HasMaxLength(351)
					.HasColumnName("_chatMsg");

				entity.Property(e => e.ChatRoomNo).HasColumnName("_chatRoomNo");

				entity.Property(e => e.ChatType).HasColumnName("_chatType");

				entity.Property(e => e.EmoticonPackKey).HasColumnName("_emoticonPackKey");

				entity.Property(e => e.FromUserId)
					.HasMaxLength(30)
					.HasColumnName("_fromUserId");

				entity.Property(e => e.FromUserNo).HasColumnName("_fromUserNo");

				entity.Property(e => e.LangType).HasColumnName("_langType");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResType).HasColumnName("_resType");
			});

			modelBuilder.Entity<TblShadowArenaDodgePanelty>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblShadowArenaDodgePanelty");

				entity.ToTable("TblShadowArenaDodgePanelty", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.JoinableTime)
					.HasColumnType("datetime")
					.HasColumnName("_joinableTime");

				entity.Property(e => e.NextResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_nextResetTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TodayCount).HasColumnName("_todayCount");
			});

			modelBuilder.Entity<TblShadowArenaFriendChat>(entity =>
			{
				entity.HasKey(e => e.ChatIdx)
					.HasName("PKTblShadowArenaFriendChat")
					.IsClustered(false);

				entity.ToTable("TblShadowArenaFriendChat", "PaGamePrivate");

				entity.Property(e => e.ChatIdx).HasColumnName("_chatIdx");

				entity.Property(e => e.ChatMsg)
					.HasMaxLength(351)
					.HasColumnName("_chatMsg");

				entity.Property(e => e.FromUserId)
					.HasMaxLength(30)
					.HasColumnName("_fromUserId");

				entity.Property(e => e.FromUserNo).HasColumnName("_fromUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ToUserId)
					.HasMaxLength(30)
					.HasColumnName("_toUserId");

				entity.Property(e => e.ToUserNo).HasColumnName("_toUserNo");
			});

			modelBuilder.Entity<TblShadowArenaLastBattleResultInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblShadowArenaLastBattleResultInfo");

				entity.ToTable("TblShadowArenaLastBattleResultInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.Assist).HasColumnName("_assist");

				entity.Property(e => e.ChangeTierPoint).HasColumnName("_changeTierPoint");

				entity.Property(e => e.Death).HasColumnName("_death");

				entity.Property(e => e.InstanceFieldKey).HasColumnName("_instanceFieldKey");

				entity.Property(e => e.IsReceiveReward).HasColumnName("_isReceiveReward");

				entity.Property(e => e.Kill).HasColumnName("_kill");

				entity.Property(e => e.Ranking).HasColumnName("_ranking");

				entity.Property(e => e.RewardMoney).HasColumnName("_rewardMoney");
			});

			modelBuilder.Entity<TblShadowArenaOption>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblShadowArenaOption", "PaGamePrivate");

				entity.Property(e => e.Season).HasColumnName("_season");
			});

			modelBuilder.Entity<TblShadowArenaPurchasedProfileIcon>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.IconKey })
					.HasName("PKTblShadowArenaPurchasedProfileIcon");

				entity.ToTable("TblShadowArenaPurchasedProfileIcon", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.IconKey).HasColumnName("_iconKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblShadowArenaRestrictMode>(entity =>
			{
				entity.HasKey(e => e.InstanceFieldKey)
					.HasName("PKTblShadowArenaRestrictMode");

				entity.ToTable("TblShadowArenaRestrictMode", "PaGamePrivate");

				entity.Property(e => e.InstanceFieldKey)
					.ValueGeneratedNever()
					.HasColumnName("_instanceFieldKey");

				entity.Property(e => e.IsRestrict).HasColumnName("_isRestrict");
			});

			modelBuilder.Entity<TblShadowArenaShopPreset>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.InstanceContentsType, e.InstanceContentsMode, e.ClassType, e.PresetIndex })
					.HasName("PKTblShadowArenaShopPreset")
					.IsClustered(false);

				entity.ToTable("TblShadowArenaShopPreset", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.InstanceContentsType)
					.HasColumnName("_instanceContentsType")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.InstanceContentsMode)
					.HasColumnName("_instanceContentsMode")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.PresetIndex).HasColumnName("_presetIndex");

				entity.Property(e => e.ItemRoute)
					.HasMaxLength(2000)
					.HasColumnName("_itemRoute");

				entity.Property(e => e.PresetName)
					.HasMaxLength(30)
					.HasColumnName("_presetName");
			});

			modelBuilder.Entity<TblShadowArenaSkillAwakenList>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ClassType, e.SkillNo })
					.HasName("PKTblShaSkillAwakenList");

				entity.ToTable("TblShadowArenaSkillAwakenList", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");

				entity.Property(e => e.IsSelect).HasColumnName("_isSelect");
			});

			modelBuilder.Entity<TblShadowArenaSkillAwakenSelect>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SkillNo })
					.HasName("PKTblShaSkillAwakenSelect");

				entity.ToTable("TblShadowArenaSkillAwakenSelect", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SkillNo).HasColumnName("_skillNo");
			});

			modelBuilder.Entity<TblShadowArenaSkillStone>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblShadowArenaSkillStone");

				entity.ToTable("TblShadowArenaSkillStone", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.SkillStonesCount).HasColumnName("_skillStonesCount");
			});

			modelBuilder.Entity<TblShadowArenaSkinDyingInfo>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SkinKey })
					.HasName("PKTblShadowArenaSkinDyingInfo");

				entity.ToTable("TblShadowArenaSkinDyingInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SkinKey).HasColumnName("_skinKey");

				entity.Property(e => e.DyeingInfo1)
					.HasMaxLength(24)
					.HasColumnName("_dyeingInfo1");

				entity.Property(e => e.DyeingInfo2)
					.HasMaxLength(24)
					.HasColumnName("_dyeingInfo2");

				entity.Property(e => e.DyeingInfo3)
					.HasMaxLength(24)
					.HasColumnName("_dyeingInfo3");

				entity.Property(e => e.DyeingInfo4)
					.HasMaxLength(24)
					.HasColumnName("_dyeingInfo4");

				entity.Property(e => e.DyeingInfo5)
					.HasMaxLength(24)
					.HasColumnName("_dyeingInfo5");
			});

			modelBuilder.Entity<TblShadowArenaUserTitle>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblShadowArenaUserTitle");

				entity.ToTable("TblShadowArenaUserTitle", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.TitleKey).HasColumnName("_titleKey");
			});

			modelBuilder.Entity<TblSiege>(entity =>
			{
				entity.HasKey(e => e.RegionKey)
					.HasName("PkTblSiege");

				entity.ToTable("TblSiege", "PaGamePrivate");

				entity.HasComment("공성&마을 정보");

				entity.Property(e => e.RegionKey)
					.ValueGeneratedNever()
					.HasColumnName("_regionKey")
					.HasComment("_regionKey");

				entity.Property(e => e.Dislike)
					.HasColumnName("_dislike")
					.HasComment("싫어요수 (약탈게임)");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("주인이 없으면 0");

				entity.Property(e => e.Like)
					.HasColumnName("_like")
					.HasComment("좋아요수 (약탈게임)");

				entity.Property(e => e.OccupyingDate)
					.HasColumnType("datetime")
					.HasColumnName("_occupyingDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("점령일시(주인이 없다면 해방일시)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("최초 등록시간");

				entity.Property(e => e.TaxRateForSiege)
					.HasColumnName("_taxRateForSiege")
					.HasComment("성주가 설정한 세율");

				entity.Property(e => e.TaxRemainedAmountForFortress)
					.HasColumnName("_taxRemainedAmountForFortress")
					.HasComment("영주가 인출할 수 있는 세금잔량");

				entity.Property(e => e.TaxRemainedAmountForSiege)
					.HasColumnName("_taxRemainedAmountForSiege")
					.HasComment("성주가 인출할 수 있는 세금잔량");

				entity.Property(e => e.UpdateDateOfTaxRemainedAmount)
					.HasColumnType("datetime")
					.HasColumnName("_updateDateOfTaxRemainedAmount")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_taxRemainedAmount이 변경된 시간");
			});

			modelBuilder.Entity<TblSiegeBuildingHistory>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSiegeBuildingHistory", "PaGamePrivate");

				entity.Property(e => e.BuildRegionKey).HasColumnName("_buildRegionKey");

				entity.Property(e => e.CompletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_completedDate");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasColumnName("_createdDate");

				entity.Property(e => e.DestoryerGuildName)
					.HasMaxLength(30)
					.HasColumnName("_destoryerGuildName");

				entity.Property(e => e.DestroyedDate)
					.HasColumnType("datetime")
					.HasColumnName("_destroyedDate");

				entity.Property(e => e.DestroyerCharacterName)
					.HasMaxLength(30)
					.HasColumnName("_destroyerCharacterName");

				entity.Property(e => e.DestroyerCharacterNo).HasColumnName("_destroyerCharacterNo");

				entity.Property(e => e.DestroyerGuildNo).HasColumnName("_destroyerGuildNo");

				entity.Property(e => e.DestroyerguildMark).HasColumnName("_destroyerguildMark");

				entity.Property(e => e.DestroyermasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_destroyermasterUserNickname");

				entity.Property(e => e.DestroyermasterUserNo).HasColumnName("_destroyermasterUserNo");

				entity.Property(e => e.GuildMark).HasColumnName("_guildMark");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsVillageSiege).HasColumnName("isVillageSiege");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MasterUserNickname)
					.HasMaxLength(30)
					.HasColumnName("_masterUserNickname");

				entity.Property(e => e.MasterUserNo).HasColumnName("_masterUserNo");

				entity.Property(e => e.PosX).HasColumnName("_posX");

				entity.Property(e => e.PosY).HasColumnName("_posY");

				entity.Property(e => e.PosZ).HasColumnName("_posZ");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.SiegeHistoryDate).HasColumnName("_siegeHistoryDate");

				entity.Property(e => e.TerritoryKey).HasColumnName("_territoryKey");
			});

			modelBuilder.Entity<TblSiegeColor>(entity =>
			{
				entity.HasKey(e => e.ColorIndex)
					.HasName("PkTblSiegeColor");

				entity.ToTable("TblSiegeColor", "PaGamePrivate");

				entity.Property(e => e.ColorIndex).HasColumnName("_colorIndex");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");
			});

			modelBuilder.Entity<TblSiegeHistory>(entity =>
			{
				entity.HasKey(e => new { e.SiegeHistoryDate, e.RegionKey })
					.HasName("PkTblSiegeHistory");

				entity.ToTable("TblSiegeHistory", "PaGamePrivate");

				entity.HasComment("공성&마을 정보");

				entity.Property(e => e.SiegeHistoryDate)
					.HasColumnName("_siegeHistoryDate")
					.HasComment("공성 날짜 키");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("_regionKey");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName")
					.HasComment("점령 길드명");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("주인이 없으면 0");

				entity.Property(e => e.IsVillageSiege)
					.HasColumnName("_isVillageSiege")
					.HasComment("공성 종류");

				entity.Property(e => e.OccupyingDate)
					.HasColumnType("datetime")
					.HasColumnName("_occupyingDate")
					.HasComment("점령일시(주인이 없다면 해방일시)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("최초 등록시간");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasComment("갱신된 시간");
			});

			modelBuilder.Entity<TblSiegeScore>(entity =>
			{
				entity.HasKey(e => new { e.SiegeScoreNo, e.GuildNo, e.UserNo, e.RegionKey })
					.HasName("PkTblSiegeScore")
					.IsClustered(false);

				entity.ToTable("TblSiegeScore", "PaGamePrivate");

				entity.HasComment("길드공성전적");

				entity.Property(e => e.SiegeScoreNo)
					.HasColumnName("_siegeScoreNo")
					.HasComment("공성 회차");

				entity.Property(e => e.GuildNo)
					.HasColumnName("_guildNo")
					.HasComment("참여 길드 번호");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("참여 유저 번호");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("해당 공성의 지역키");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName")
					.HasComment("캐릭터명");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터 번호");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName")
					.HasComment("참여 길드 이름");

				entity.Property(e => e.IsVillageSiege)
					.HasColumnName("_isVillageSiege")
					.HasComment("해당 공성의 종류");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("공성 시작 시간");

				entity.Property(e => e.ScoreType0)
					.HasColumnName("_scoreType_0")
					.HasComment("사망 횟수");

				entity.Property(e => e.ScoreType1)
					.HasColumnName("_scoreType_1")
					.HasComment("지휘소 파괴 횟수");

				entity.Property(e => e.ScoreType10)
					.HasColumnName("_scoreType_10")
					.HasComment("배치물 파괴 횟수");

				entity.Property(e => e.ScoreType11)
					.HasColumnName("_scoreType_11")
					.HasComment("공성병기로 사람을 죽인 횟수");

				entity.Property(e => e.ScoreType2)
					.HasColumnName("_scoreType_2")
					.HasComment("성채 파괴 횟수");

				entity.Property(e => e.ScoreType3)
					.HasColumnName("_scoreType_3")
					.HasComment("군주 (연합 길드장) 죽인 횟수");

				entity.Property(e => e.ScoreType4)
					.HasColumnName("_scoreType_4")
					.HasComment("대장 처치 횟수");

				entity.Property(e => e.ScoreType5)
					.HasColumnName("_scoreType_5")
					.HasComment("성문 파괴 횟수");

				entity.Property(e => e.ScoreType6)
					.HasColumnName("_scoreType_6")
					.HasComment("부대장 처치 횟수");

				entity.Property(e => e.ScoreType7)
					.HasColumnName("_scoreType_7")
					.HasComment("길드처치 횟수");

				entity.Property(e => e.ScoreType8)
					.HasColumnName("_scoreType_8")
					.HasComment("도움 횟수");

				entity.Property(e => e.ScoreType9)
					.HasColumnName("_scoreType_9")
					.HasComment("탑승물 처치 횟수");

				entity.Property(e => e.TerritoryKey)
					.HasColumnName("_territoryKey")
					.HasComment("해당 공성의 영지키");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasComment("공성 전적 업데이트 시간");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname")
					.HasComment("가문명");
			});

			modelBuilder.Entity<TblSiegeSecondRoundScore>(entity =>
			{
				entity.HasKey(e => new { e.SiegeScoreNo, e.GuildNo, e.RegionKey, e.TerritoryKey })
					.HasName("PkTblSiegeSecondRoundScore");

				entity.ToTable("TblSiegeSecondRoundScore", "PaGamePrivate");

				entity.Property(e => e.SiegeScoreNo).HasColumnName("_siegeScoreNo");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");

				entity.Property(e => e.TerritoryKey).HasColumnName("_territoryKey");

				entity.Property(e => e.BuildScore).HasColumnName("_buildScore");

				entity.Property(e => e.DeathScore).HasColumnName("_deathScore");

				entity.Property(e => e.DestroyTime).HasColumnName("_destroyTime");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.HpScore).HasColumnName("_hpScore");

				entity.Property(e => e.KillScore).HasColumnName("_killScore");

				entity.Property(e => e.MasterNickname)
					.HasMaxLength(30)
					.HasColumnName("_masterNickname");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblSiegeTaxTime>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSiegeTaxTime", "PaGamePrivate");

				entity.HasComment("세금 납입 시간 기록용");

				entity.Property(e => e.LastPayTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastPayTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("지급 시간");
			});

			modelBuilder.Entity<TblSiegeVote>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.TerritoryKey })
					.HasName("PkTblSiegeVote")
					.IsClustered(false);

				entity.ToTable("TblSiegeVote", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.TerritoryKey).HasColumnName("_territoryKey");

				entity.Property(e => e.IsLike).HasColumnName("_isLike");
			});

			modelBuilder.Entity<TblSimpleGuildInviteList>(entity =>
			{
				entity.HasKey(e => new { e.HostGuildNo, e.ReciveUserNo })
					.HasName("PkTblSimpleGuildInviteList");

				entity.ToTable("TblSimpleGuildInviteList", "PaGamePrivate");

				entity.Property(e => e.HostGuildNo).HasColumnName("_hostGuildNo");

				entity.Property(e => e.ReciveUserNo).HasColumnName("_reciveUserNo");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.HostUserNickName)
					.HasMaxLength(30)
					.HasColumnName("_hostUserNickName");

				entity.Property(e => e.HostUserNo).HasColumnName("_hostUserNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblSkill>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.IsPlayer, e.SkillNo })
					.HasName("PkTblSkill");

				entity.ToTable("TblSkill", "PaGamePrivate");

				entity.HasComment("스킬 정보");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.IsPlayer)
					.HasColumnName("_isPlayer")
					.HasComment("_isPlayer");

				entity.Property(e => e.SkillNo)
					.HasColumnName("_skillNo")
					.HasComment("스킬번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.SkillLearningType)
					.HasColumnName("_skillLearningType")
					.HasComment("스킬 배우는 방법 타입");

				entity.Property(e => e.SkillLevel)
					.HasColumnName("_skillLevel")
					.HasComment("_skillLevel");

				entity.Property(e => e.SkillPointType)
					.HasColumnName("_skillPointType")
					.HasComment("스킬 포인트타입(전투,생산)");
			});

			modelBuilder.Entity<TblSkillAwakeningVersion2>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.SkillNo })
					.HasName("PkTblSkillAwakeningVersion2");

				entity.ToTable("TblSkillAwakeningVersion2", "PaGamePrivate");

				entity.HasComment("스킬 각성 정보 ( 리뉴얼 )");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("캐릭터번호");

				entity.Property(e => e.SkillNo)
					.HasColumnName("_skillNo")
					.HasComment("스킬번호");

				entity.Property(e => e.AwakeningBitFlag)
					.HasColumnName("_awakeningBitFlag")
					.HasComment("_awakeningBitFlag");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");
			});

			modelBuilder.Entity<TblSkillPreset>(entity =>
			{
				entity.HasKey(e => new { e.CharacterNo, e.SlotNo })
					.HasName("PkTblSkillPreset")
					.IsClustered(false);

				entity.ToTable("TblSkillPreset", "PaGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.SlotNo).HasColumnName("_slotNo");

				entity.Property(e => e.CommandLockList)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_commandLockList")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.CoolTimeList)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_coolTimeList")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.IsApply).HasColumnName("_isApply");

				entity.Property(e => e.QuickSlotList)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_quickSlotList")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.RingMenuList)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_ringMenuList")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SkillAwakeningCount).HasColumnName("_skillAwakeningCount");

				entity.Property(e => e.SkillList)
					.HasMaxLength(4000)
					.IsUnicode(false)
					.HasColumnName("_skillList")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SkillPoint).HasColumnName("_skillPoint");

				entity.Property(e => e.SpiritLockList)
					.HasMaxLength(2000)
					.IsUnicode(false)
					.HasColumnName("_spiritLockList")
					.HasDefaultValueSql("('')");

				entity.Property(e => e.SuccessionSkillAwakeningCount).HasColumnName("_successionSkillAwakeningCount");

				entity.Property(e => e.WeaponSkillAwakeningCount).HasColumnName("_weaponSkillAwakeningCount");
			});

			modelBuilder.Entity<TblSkillPresetLastUpdateTime>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblSkillPresetLastUpdateTime");

				entity.ToTable("TblSkillPresetLastUpdateTime", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.LastUpdateTimeBuff)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTimeBuff");

				entity.Property(e => e.LastUpdateTimeNpc)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTimeNpc");
			});

			modelBuilder.Entity<TblSkillPresetSlot>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.CharacterNo })
					.HasName("PKTblSkillPresetSlot");

				entity.ToTable("TblSkillPresetSlot", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.CashSlotItemCount).HasColumnName("_cashSlotItemCount");

				entity.Property(e => e.SlotCount).HasColumnName("_slotCount");
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

				entity.Property(e => e.ObjectQuery)
					.IsUnicode(false)
					.HasColumnName("_objectQuery");

				entity.Property(e => e.Objecttype)
					.HasMaxLength(30)
					.IsUnicode(false)
					.HasColumnName("_objecttype");
			});

			modelBuilder.Entity<TblStockMarketBuy>(entity =>
			{
				entity.HasKey(e => e.MarketId)
					.HasName("PkTblStockMarketBuy")
					.IsClustered(false);

				entity.ToTable("TblStockMarketBuy", "PaGamePrivate");

				entity.Property(e => e.MarketId)
					.HasColumnName("_marketId")
					.HasComment("거래순번");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("구매수량");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템 종류");

				entity.Property(e => e.Price)
					.HasColumnName("_price")
					.HasComment("구매가격");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("지역번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("구매자");
			});

			modelBuilder.Entity<TblStockMarketSell>(entity =>
			{
				entity.HasKey(e => e.MarketId)
					.HasName("PkTblStockMarketSell")
					.IsClustered(false);

				entity.ToTable("TblStockMarketSell", "PaGamePrivate");

				entity.Property(e => e.MarketId)
					.HasColumnName("_marketId")
					.HasComment("거래순번");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("판매수량");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템 종류");

				entity.Property(e => e.ItemNo)
					.HasColumnName("_itemNo")
					.HasComment("아이템 고유번호");

				entity.Property(e => e.Price)
					.HasColumnName("_price")
					.HasComment("판매가격");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("지역번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("판매자");
			});

			modelBuilder.Entity<TblSupplyCount>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblSupplyCount");

				entity.ToTable("TblSupplyCount", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.NextResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_nextResetTime");

				entity.Property(e => e.TradeCountForShell).HasColumnName("_tradeCountForShell");

				entity.Property(e => e.TradeCountForSilver).HasColumnName("_tradeCountForSilver");
			});

			modelBuilder.Entity<TblSupportPoint>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.TerritoryKey })
					.HasName("PkTblSupportPoint");

				entity.ToTable("TblSupportPoint", "PaGamePrivate");

				entity.HasComment("탐험 포인트(지역별 지지도)");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저 고유번호");

				entity.Property(e => e.TerritoryKey)
					.HasColumnName("_territoryKey")
					.HasComment("지역번호");

				entity.Property(e => e.AquiredPoint)
					.HasColumnName("_aquiredPoint")
					.HasComment("총 획득 포인트");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("경험치");

				entity.Property(e => e.RemainedPoint)
					.HasColumnName("_remainedPoint")
					.HasComment("남은 포인트");
			});

			modelBuilder.Entity<TblSyncGuildInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncGuildInformation", "PaWebGamePrivate");

				entity.Property(e => e.GuildGrade).HasColumnName("_guildGrade");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_guildRegisterDate");

				entity.Property(e => e.MasterUserNo).HasColumnName("_masterUserNo");

				entity.Property(e => e.MemberRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_memberRegisterDate");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSyncGuildInformationSnap>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncGuildInformation_Snap", "PaWebGamePrivate");

				entity.Property(e => e.GuildGrade).HasColumnName("_guildGrade");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_guildRegisterDate");

				entity.Property(e => e.MasterUserNo).HasColumnName("_masterUserNo");

				entity.Property(e => e.MemberRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_memberRegisterDate");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSyncGuildInformationTran>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncGuildInformation_Tran", "PaWebGamePrivate");

				entity.Property(e => e.GuildGrade).HasColumnName("_guildGrade");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.GuildRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_guildRegisterDate");

				entity.Property(e => e.IsChange).HasColumnName("_isChange");

				entity.Property(e => e.MasterUserNo).HasColumnName("_masterUserNo");

				entity.Property(e => e.MemberRegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_memberRegisterDate");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSyncLifeExperience>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncLifeExperience", "PaWebGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblSyncLifeExperienceSnap>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncLifeExperience_Snap", "PaWebGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblSyncLifeExperienceTran>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncLifeExperience_Tran", "PaWebGamePrivate");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.IsChange).HasColumnName("_isChange");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblSyncWebUserInformation>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncWebUserInformation", "PaWebGamePrivate");

				entity.Property(e => e.AquiredPoint).HasColumnName("_aquiredPoint");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CreateDate)
					.HasColumnType("datetime")
					.HasColumnName("_createDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DefenceValue).HasColumnName("_defenceValue");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsGm).HasColumnName("_isGM");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.OffenceValue).HasColumnName("_offenceValue");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSyncWebUserInformationSnap>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncWebUserInformation_Snap", "PaWebGamePrivate");

				entity.Property(e => e.AquiredPoint).HasColumnName("_aquiredPoint");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CreateDate)
					.HasColumnType("datetime")
					.HasColumnName("_createDate");

				entity.Property(e => e.DefenceValue).HasColumnName("_defenceValue");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsGm).HasColumnName("_isGM");

				entity.Property(e => e.IsValid).HasColumnName("_isValid");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.OffenceValue).HasColumnName("_offenceValue");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblSyncWebUserInformationTran>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblSyncWebUserInformation_Tran", "PaWebGamePrivate");

				entity.Property(e => e.AquiredPoint).HasColumnName("_aquiredPoint");

				entity.Property(e => e.CharacterName)
					.HasMaxLength(30)
					.HasColumnName("_characterName");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");

				entity.Property(e => e.ClassType).HasColumnName("_classType");

				entity.Property(e => e.CreateDate)
					.HasColumnType("datetime")
					.HasColumnName("_createDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DefenceValue).HasColumnName("_defenceValue");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.GuildName)
					.HasMaxLength(30)
					.HasColumnName("_guildName");

				entity.Property(e => e.GuildNo).HasColumnName("_guildNo");

				entity.Property(e => e.IsChange).HasColumnName("_isChange");

				entity.Property(e => e.IsGm).HasColumnName("_isGM");

				entity.Property(e => e.IsValid)
					.IsRequired()
					.HasColumnName("_isValid")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.OffenceValue).HasColumnName("_offenceValue");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblTax>(entity =>
			{
				entity.HasKey(e => new { e.RegionKey, e.TaxType })
					.HasName("PkTblTax");

				entity.ToTable("TblTax", "PaGamePrivate");

				entity.HasComment("세금정보");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("_regionKey");

				entity.Property(e => e.TaxType)
					.HasColumnName("_taxType")
					.HasComment("_taxType");

				entity.Property(e => e.AffiliatedAmount)
					.HasColumnName("_affiliatedAmount")
					.HasComment("주민세(소속지역주민들의 세금합)");

				entity.Property(e => e.ProducedAmount)
					.HasColumnName("_producedAmount")
					.HasComment("지방세(해당지역의 세금합)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("점령일시");

				entity.Property(e => e.TaxRate)
					.HasColumnName("_taxRate")
					.HasComment("현재 세율");
			});

			modelBuilder.Entity<TblTeleportableUser>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblTeleportableUser");

				entity.ToTable("TblTeleportableUser", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblTeleportationPoint>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.RegionKey })
					.HasName("PkTblTeleportationPoint");

				entity.ToTable("TblTeleportationPoint", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.RegionKey).HasColumnName("_regionKey");
			});

			modelBuilder.Entity<TblTerritoryTradeAuthority>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.TerritoryKey })
					.HasName("PkTblTerritoryTradeAuthority");

				entity.ToTable("TblTerritoryTradeAuthority", "PaGamePrivate");

				entity.HasComment("영지 무역(황실무역) 권한 테이블");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유져 번호");

				entity.Property(e => e.TerritoryKey)
					.HasColumnName("_territoryKey")
					.HasComment("영지 번호");
			});

			modelBuilder.Entity<TblTerritoryTradeItem>(entity =>
			{
				entity.HasKey(e => e.TerritoryKey)
					.HasName("PkTblTerritoryTradeItem");

				entity.ToTable("TblTerritoryTradeItem", "PaGamePrivate");

				entity.HasComment("영지 무역, 납품 아이템 테이블");

				entity.Property(e => e.TerritoryKey)
					.ValueGeneratedNever()
					.HasColumnName("_territoryKey")
					.HasComment("영지 번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("영지 아이템 등록 시간");

				entity.Property(e => e.SupplyItemMainGroupKey)
					.HasColumnName("_supplyItemMainGroupKey")
					.HasComment("영지 납품 gc::ItemMainGroupKey ");

				entity.Property(e => e.TradeItemMainGroupKey)
					.HasColumnName("_tradeItemMainGroupKey")
					.HasComment("영지 무역 gc::ItemMainGroupKey ");
			});

			modelBuilder.Entity<TblThumbsUpCountInformation>(entity =>
			{
				entity.HasKey(e => new { e.ChatRoomNo, e.UserNo })
					.HasName("PkTblThumbsUpCountInformation");

				entity.ToTable("TblThumbsUpCountInformation", "PaGamePrivate");

				entity.Property(e => e.ChatRoomNo).HasColumnName("_chatRoomNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ThumbsUpCount).HasColumnName("_thumbsUpCount");

				entity.Property(e => e.ThumbsUpGrade).HasColumnName("_thumbsUpGrade");
			});

			modelBuilder.Entity<TblThumbsUpInformation>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblThumbsUpInformation")
					.IsClustered(false);

				entity.ToTable("TblThumbsUpInformation", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.LastVoteTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastVoteTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ThumbsUpVoteCount).HasColumnName("_thumbsUpVoteCount");
			});

			modelBuilder.Entity<TblTimeAttackRanking>(entity =>
			{
				entity.HasKey(e => new { e.Type, e.OwnerNo, e.MonsterNo })
					.HasName("PkTblTimeAttackRanking")
					.IsClustered(false);

				entity.ToTable("TblTimeAttackRanking", "PaGamePrivate");

				entity.HasComment("타임어택 TOP 랭킹");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("타입");

				entity.Property(e => e.OwnerNo)
					.HasColumnName("_ownerNo")
					.HasComment("타임어택 소유주");

				entity.Property(e => e.MonsterNo)
					.HasColumnName("_monsterNo")
					.HasComment("몬스터");

				entity.Property(e => e.CompleteTime)
					.HasColumnName("_completeTime")
					.HasComment("완료 시간");
			});

			modelBuilder.Entity<TblTradeCompany>(entity =>
			{
				entity.HasKey(e => e.OwnerUserNo)
					.HasName("PkTblTradeCompany")
					.IsClustered(false);

				entity.ToTable("TblTradeCompany", "PaGamePrivate");

				entity.Property(e => e.OwnerUserNo)
					.ValueGeneratedNever()
					.HasColumnName("_ownerUserNo");

				entity.Property(e => e.Amulet).HasColumnName("_amulet");

				entity.Property(e => e.Carriage).HasColumnName("_carriage");

				entity.Property(e => e.Guard).HasColumnName("_guard");

				entity.Property(e => e.IsActiveWorkerTrade).HasColumnName("_isActiveWorkerTrade");

				entity.Property(e => e.Money).HasColumnName("_money");

				entity.Property(e => e.Porter).HasColumnName("_porter");
			});

			modelBuilder.Entity<TblTradeCompanyLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblTradeCompanyLog", "PaGamePrivate");

				entity.Property(e => e.LogType).HasColumnName("_logType");

				entity.Property(e => e.OwnerUserNo).HasColumnName("_ownerUserNo");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TradeGroupIndex).HasColumnName("_tradeGroupIndex");
			});

			modelBuilder.Entity<TblTradeCompanyObtainItem>(entity =>
			{
				entity.HasKey(e => new { e.OwnerUserNo, e.ObtainItemNo })
					.HasName("PkTblTradeCompanyObtainItem");

				entity.ToTable("TblTradeCompanyObtainItem", "PaGamePrivate");

				entity.Property(e => e.OwnerUserNo).HasColumnName("_ownerUserNo");

				entity.Property(e => e.ObtainItemNo).HasColumnName("_obtainItemNo");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.ItemEnchantKey).HasColumnName("_itemEnchantKey");
			});

			modelBuilder.Entity<TblTradeGroupList>(entity =>
			{
				entity.HasKey(e => new { e.OwnerUserNo, e.TradeGroupIndex })
					.HasName("PkTblTradeGroupList");

				entity.ToTable("TblTradeGroupList", "PaGamePrivate");

				entity.Property(e => e.OwnerUserNo).HasColumnName("_ownerUserNo");

				entity.Property(e => e.TradeGroupIndex).HasColumnName("_tradeGroupIndex");

				entity.Property(e => e.Amulet).HasColumnName("_amulet");

				entity.Property(e => e.BuyPrice1).HasColumnName("_buyPrice1");

				entity.Property(e => e.BuyPrice10).HasColumnName("_buyPrice10");

				entity.Property(e => e.BuyPrice2).HasColumnName("_buyPrice2");

				entity.Property(e => e.BuyPrice3).HasColumnName("_buyPrice3");

				entity.Property(e => e.BuyPrice4).HasColumnName("_buyPrice4");

				entity.Property(e => e.BuyPrice5).HasColumnName("_buyPrice5");

				entity.Property(e => e.BuyPrice6).HasColumnName("_buyPrice6");

				entity.Property(e => e.BuyPrice7).HasColumnName("_buyPrice7");

				entity.Property(e => e.BuyPrice8).HasColumnName("_buyPrice8");

				entity.Property(e => e.BuyPrice9).HasColumnName("_buyPrice9");

				entity.Property(e => e.Carriage).HasColumnName("_carriage");

				entity.Property(e => e.ContractedPrice1).HasColumnName("_contractedPrice1");

				entity.Property(e => e.ContractedPrice10).HasColumnName("_contractedPrice10");

				entity.Property(e => e.ContractedPrice2).HasColumnName("_contractedPrice2");

				entity.Property(e => e.ContractedPrice3).HasColumnName("_contractedPrice3");

				entity.Property(e => e.ContractedPrice4).HasColumnName("_contractedPrice4");

				entity.Property(e => e.ContractedPrice5).HasColumnName("_contractedPrice5");

				entity.Property(e => e.ContractedPrice6).HasColumnName("_contractedPrice6");

				entity.Property(e => e.ContractedPrice7).HasColumnName("_contractedPrice7");

				entity.Property(e => e.ContractedPrice8).HasColumnName("_contractedPrice8");

				entity.Property(e => e.ContractedPrice9).HasColumnName("_contractedPrice9");

				entity.Property(e => e.CurDestIndex).HasColumnName("_curDestIndex");

				entity.Property(e => e.Defense).HasColumnName("_defense");

				entity.Property(e => e.Guard).HasColumnName("_guard");

				entity.Property(e => e.ItemCount1).HasColumnName("_itemCount1");

				entity.Property(e => e.ItemCount10).HasColumnName("_itemCount10");

				entity.Property(e => e.ItemCount2).HasColumnName("_itemCount2");

				entity.Property(e => e.ItemCount3).HasColumnName("_itemCount3");

				entity.Property(e => e.ItemCount4).HasColumnName("_itemCount4");

				entity.Property(e => e.ItemCount5).HasColumnName("_itemCount5");

				entity.Property(e => e.ItemCount6).HasColumnName("_itemCount6");

				entity.Property(e => e.ItemCount7).HasColumnName("_itemCount7");

				entity.Property(e => e.ItemCount8).HasColumnName("_itemCount8");

				entity.Property(e => e.ItemCount9).HasColumnName("_itemCount9");

				entity.Property(e => e.ItemKey1).HasColumnName("_itemKey1");

				entity.Property(e => e.ItemKey10).HasColumnName("_itemKey10");

				entity.Property(e => e.ItemKey2).HasColumnName("_itemKey2");

				entity.Property(e => e.ItemKey3).HasColumnName("_itemKey3");

				entity.Property(e => e.ItemKey4).HasColumnName("_itemKey4");

				entity.Property(e => e.ItemKey5).HasColumnName("_itemKey5");

				entity.Property(e => e.ItemKey6).HasColumnName("_itemKey6");

				entity.Property(e => e.ItemKey7).HasColumnName("_itemKey7");

				entity.Property(e => e.ItemKey8).HasColumnName("_itemKey8");

				entity.Property(e => e.ItemKey9).HasColumnName("_itemKey9");

				entity.Property(e => e.Luck).HasColumnName("_luck");

				entity.Property(e => e.Money).HasColumnName("_money");

				entity.Property(e => e.MoveDistance).HasColumnName("_moveDistance");

				entity.Property(e => e.MoveSpeed).HasColumnName("_moveSpeed");

				entity.Property(e => e.Porter).HasColumnName("_porter");

				entity.Property(e => e.State).HasColumnName("_state");

				entity.Property(e => e.TradeNode1).HasColumnName("_tradeNode1");

				entity.Property(e => e.TradeNode10).HasColumnName("_tradeNode10");

				entity.Property(e => e.TradeNode2).HasColumnName("_tradeNode2");

				entity.Property(e => e.TradeNode3).HasColumnName("_tradeNode3");

				entity.Property(e => e.TradeNode4).HasColumnName("_tradeNode4");

				entity.Property(e => e.TradeNode5).HasColumnName("_tradeNode5");

				entity.Property(e => e.TradeNode6).HasColumnName("_tradeNode6");

				entity.Property(e => e.TradeNode7).HasColumnName("_tradeNode7");

				entity.Property(e => e.TradeNode8).HasColumnName("_tradeNode8");

				entity.Property(e => e.TradeNode9).HasColumnName("_tradeNode9");

				entity.Property(e => e.TransportCapacity).HasColumnName("_transportCapacity");

				entity.Property(e => e.WorkerNo1).HasColumnName("_workerNo1");

				entity.Property(e => e.WorkerNo2).HasColumnName("_workerNo2");
			});

			modelBuilder.Entity<TblTroller>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ContentsType })
					.HasName("PkTblTroller")
					.IsClustered(false);

				entity.ToTable("TblTroller", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.ContentsType)
					.HasColumnName("_contentsType")
					.HasComment("컨텐츠 타입");

				entity.Property(e => e.BannedTime)
					.HasColumnType("datetime")
					.HasColumnName("_bannedTime")
					.HasComment("밴 시간");

				entity.Property(e => e.ReportStack)
					.HasColumnName("_reportStack")
					.HasComment("신고 당한 횟수");
			});

			modelBuilder.Entity<TblTutorial>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Type })
					.HasName("PkTblTutorial")
					.IsClustered(false);

				entity.ToTable("TblTutorial", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.IsComplete).HasColumnName("_isComplete");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblTutorialCharacterInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblTutorialCharacterInfo");

				entity.ToTable("TblTutorialCharacterInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasDefaultValueSql("((-1))");

				entity.Property(e => e.CharacterNo).HasColumnName("_characterNo");
			});

			modelBuilder.Entity<TblUserEnchantStackInfo>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblUserEnchantStackSlotInfo")
					.IsClustered(false);

				entity.ToTable("TblUserEnchantStackInfo", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.EnableSlotCount).HasColumnName("_enableSlotCount");

				entity.Property(e => e.EnchantCoolTime)
					.HasColumnType("datetime")
					.HasColumnName("_enchantCoolTime");
			});

			modelBuilder.Entity<TblUserEnchantStackSlot>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SlotNo })
					.HasName("PkTblUserEnchantStackSlot");

				entity.ToTable("TblUserEnchantStackSlot", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.SlotNo).HasColumnName("_slotNo");

				entity.Property(e => e.EnchantAddedStack).HasColumnName("_enchantAddedStack");

				entity.Property(e => e.EnchantStack).HasColumnName("_enchantStack");

				entity.Property(e => e.EnchantStackExp).HasColumnName("_enchantStackExp");
			});

			modelBuilder.Entity<TblUserGameOptionType>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.GameOptionType })
					.HasName("PkTblUserGameOptionType");

				entity.ToTable("TblUserGameOptionType", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.GameOptionType).HasColumnName("_gameOptionType");

				entity.Property(e => e.GameOptionValue)
					.HasMaxLength(100)
					.IsUnicode(false)
					.HasColumnName("_gameOptionValue")
					.HasDefaultValueSql("('')");
			});

			modelBuilder.Entity<TblUserItemLoan>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ItemKey, e.EnchantLevel })
					.HasName("PkTblUserItemLoan");

				entity.ToTable("TblUserItemLoan", "PaGamePrivate");

				entity.HasComment("유저의 아이템 반납 정보");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템 키");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasComment("인챈트 레벨");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("개수");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록 시간");
			});

			modelBuilder.Entity<TblUserItemLoanLog>(entity =>
			{
				entity.HasKey(e => new { e.RegisterDate, e.UserNo, e.ItemNo, e.ItemKey })
					.HasName("PKTblUserItemLoanLog");

				entity.ToTable("TblUserItemLoanLog", "PaGamePrivate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ItemNo).HasColumnName("_itemNo");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.BeforeCount).HasColumnName("_beforeCount");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.ItemWhereType).HasColumnName("_itemWhereType");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.VariedCount).HasColumnName("_variedCount");
			});

			modelBuilder.Entity<TblUserLanguage>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PKTblUserLanguage");

				entity.ToTable("TblUserLanguage", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.UserLanguage).HasColumnName("_userLanguage");
			});

			modelBuilder.Entity<TblUserNpcCustomizing>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("pkTblUserNpcCustomizing");

				entity.ToTable("TblUserNpcCustomizing", "PaGamePrivate");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo");

				entity.Property(e => e.Bone)
					.HasMaxLength(660)
					.HasColumnName("_bone");

				entity.Property(e => e.Decoration)
					.HasMaxLength(130)
					.HasColumnName("_decoration");

				entity.Property(e => e.DecorationRgb)
					.HasMaxLength(12)
					.HasColumnName("_decorationRGB");

				entity.Property(e => e.Expression)
					.HasMaxLength(2)
					.HasColumnName("_expression")
					.HasDefaultValueSql("(0x0064)");

				entity.Property(e => e.Extra0).HasColumnName("_extra0");

				entity.Property(e => e.Extra1).HasColumnName("_extra1");

				entity.Property(e => e.Extra2).HasColumnName("_extra2");

				entity.Property(e => e.Extra3).HasColumnName("_extra3");

				entity.Property(e => e.HairMesh).HasColumnName("_hairMesh");

				entity.Property(e => e.HeadMesh).HasColumnName("_headMesh");

				entity.Property(e => e.SeqNo).HasColumnName("_seqNo");
			});

			modelBuilder.Entity<TblUserPlayTimeLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblUserPlayTimeLog", "PaGamePrivate");

				entity.Property(e => e.MDate).HasColumnName("_mDate");

				entity.Property(e => e.PcRoomPlayTimePerDay).HasColumnName("_pcRoomPlayTimePerDay");

				entity.Property(e => e.PlayTimePerDay).HasColumnName("_playTimePerDay");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblUserProfileInfo>(entity =>
			{
				entity.HasKey(e => new { e.DateInitTerm, e.UserNo })
					.HasName("PkTblUserProfileInfo")
					.IsClustered(false);

				entity.ToTable("TblUserProfileInfo", "PaGamePrivate");

				entity.HasComment("유저 프로파일");

				entity.Property(e => e.DateInitTerm)
					.HasColumnName("_dateInitTerm")
					.HasComment("프로파일 날짜 초기화 간격");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.IsRewardGain1)
					.HasColumnName("_isRewardGain1")
					.HasComment("몬스터 킬 수로 아이템 획득");

				entity.Property(e => e.IsRewardGain2)
					.HasColumnName("_isRewardGain2")
					.HasComment("낚시 성공으로 아이템 획득");

				entity.Property(e => e.IsRewardGain3)
					.HasColumnName("_isRewardGain3")
					.HasComment("아이템 획득으로 아이템 획득");

				entity.Property(e => e.IsRewardGain4)
					.HasColumnName("_isRewardGain4")
					.HasComment("제작 성공으로 아이템 획득");

				entity.Property(e => e.NextInitDate)
					.HasColumnType("datetime")
					.HasColumnName("_nextInitDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("초기화 될 시간");

				entity.Property(e => e.UpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_updateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("업데이트 시간");

				entity.Property(e => e.Value1)
					.HasColumnName("_value1")
					.HasComment("몬스터 킬 수");

				entity.Property(e => e.Value2)
					.HasColumnName("_value2")
					.HasComment("낚시 성공 횟수");

				entity.Property(e => e.Value3)
					.HasColumnName("_value3")
					.HasComment("아이템 획득 횟수");

				entity.Property(e => e.Value4)
					.HasColumnName("_value4")
					.HasComment("제작 성공 횟수");
			});

			modelBuilder.Entity<TblUserSeasonState>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblTblUserSeasonState")
					.IsClustered(false);

				entity.ToTable("TblUserSeasonState", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.LastCompletedSeasonNo).HasColumnName("_lastCompletedSeasonNo");

				entity.Property(e => e.RemainCompleteSeasonCount).HasColumnName("_remainCompleteSeasonCount");

				entity.Property(e => e.TotalCompleteSeasonCount).HasColumnName("_totalCompleteSeasonCount");
			});

			modelBuilder.Entity<TblUserSocialActionConfig>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.SocialActionKey, e.Type })
					.HasName("PkTblUserSocialActionConfig");

				entity.ToTable("TblUserSocialActionConfig", "PaGamePrivate");

				entity.HasComment("유저를 위한 소셜액션 키워드 변경정보");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.SocialActionKey)
					.HasColumnName("_socialActionKey")
					.HasComment("소셜액션 키");

				entity.Property(e => e.Type)
					.HasColumnName("_type")
					.HasComment("타입(0:명령어,1:구문분석용)");

				entity.Property(e => e.Data)
					.HasMaxLength(100)
					.HasColumnName("_data")
					.HasDefaultValueSql("('')")
					.HasComment("저장된 데이터");
			});

			modelBuilder.Entity<TblUserUsePearlForCashProduct>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblUserUsePearlForCashProductt")
					.IsClustered(false);

				entity.ToTable("TblUserUsePearlForCashProduct", "PaGamePrivate");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("게임내 고유 유저번호");

				entity.Property(e => e.StampCount)
					.HasColumnName("_stampCount")
					.HasComment("현재 스탬프 카운트");
			});

			modelBuilder.Entity<TblUsingHiredNpc>(entity =>
			{
				entity.HasKey(e => e.ActorKey)
					.HasName("PkTblUsingHiredNpc");

				entity.ToTable("TblUsingHiredNpc", "PaGamePrivate");

				entity.HasComment("고용되어 사용중인 Npc");

				entity.Property(e => e.ActorKey)
					.ValueGeneratedNever()
					.HasColumnName("_actorKey")
					.HasComment("액터키");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("캐릭터키");

				entity.Property(e => e.CharacterNo)
					.HasColumnName("_characterNo")
					.HasComment("소유 캐릭터번호");

				entity.Property(e => e.ExpiredTime)
					.HasColumnType("datetime")
					.HasColumnName("_expiredTime")
					.HasComment("만료일");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");
			});

			modelBuilder.Entity<TblVendingMachine>(entity =>
			{
				entity.HasKey(e => new { e.InstallationNo, e.VendingIndex })
					.HasName("PkTblVendingMachine");

				entity.ToTable("TblVendingMachine", "PaGamePrivate");

				entity.Property(e => e.InstallationNo).HasColumnName("_installationNo");

				entity.Property(e => e.VendingIndex).HasColumnName("_vendingIndex");

				entity.Property(e => e.BuyFromUserPrice).HasColumnName("_buyFromUserPrice");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.HouseholdNo).HasColumnName("_householdNo");

				entity.Property(e => e.IsStackable).HasColumnName("_isStackable");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MaxStackCount).HasColumnName("_maxStackCount");

				entity.Property(e => e.SellToUserPrice).HasColumnName("_sellToUserPrice");
			});

			modelBuilder.Entity<TblVendorTempVirtualItemList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblVendorTempVirtualItemList", "PaGamePrivate");

				entity.HasComment("집이 기간 만료 후 남아있는 자판기 및 위탁판매용 아이템 임시 저장소");

				entity.Property(e => e.Count)
					.HasColumnName("_count")
					.HasComment("수량");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasComment("강화레벨");

				entity.Property(e => e.IsStackable)
					.HasColumnName("_isStackable")
					.HasComment("스택여부");

				entity.Property(e => e.ItemKey)
					.HasColumnName("_itemKey")
					.HasComment("아이템키");

				entity.Property(e => e.TownRegionKey)
					.HasColumnName("_townRegionKey")
					.HasComment("지역키");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");
			});

			modelBuilder.Entity<TblVote>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PkTblVote");

				entity.ToTable("TblVote", "PaGamePrivate");

				entity.HasComment("투표 테이블");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo")
					.HasComment("투표한 자신");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("등록일");

				entity.Property(e => e.ToCharacterNo)
					.HasColumnName("_toCharacterNo")
					.HasComment("후보자 캐릭터번호");
			});

			modelBuilder.Entity<TblWantedList>(entity =>
			{
				entity.HasKey(e => e.CharacterNo)
					.HasName("PkTblWantedList");

				entity.ToTable("TblWantedList", "PaGamePrivate");

				entity.Property(e => e.CharacterNo)
					.ValueGeneratedNever()
					.HasColumnName("_characterNo");

				entity.Property(e => e.Bounty).HasColumnName("_bounty");

				entity.Property(e => e.LeftDeadCount).HasColumnName("_leftDeadCount");
			});

			modelBuilder.Entity<TblWarehouseSlotCount>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.RegionKey })
					.HasName("PkTblWarehouseSlotCount");

				entity.ToTable("TblWarehouseSlotCount", "PaGamePrivate");

				entity.HasComment("창고 확장 슬롯 수 저장");

				entity.Property(e => e.UserNo)
					.HasColumnName("_userNo")
					.HasComment("유저번호");

				entity.Property(e => e.RegionKey)
					.HasColumnName("_regionKey")
					.HasComment("지역키");

				entity.Property(e => e.SlotCount)
					.HasColumnName("_slotCount")
					.HasComment("슬롯 추가 갯수(아이템 사용)");
			});

			modelBuilder.Entity<TblWarningItemList>(entity =>
			{
				entity.HasKey(e => new { e.ItemKey, e.EnchantLevel })
					.HasName("PkTblWarningItemList");

				entity.ToTable("TblWarningItemList", "PaOperationPrivate");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblWarningItemMailList>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWarningItemMailList", "PaOperationPrivate");

				entity.Property(e => e.Contents).HasColumnName("_contents");

				entity.Property(e => e.DeletedDate)
					.HasColumnType("datetime")
					.HasColumnName("_deletedDate");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.IsSended).HasColumnName("_isSended");

				entity.Property(e => e.ItemCount).HasColumnName("_itemCount");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.MailRequestNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_mailRequestNo");

				entity.Property(e => e.NoteNo)
					.HasMaxLength(50)
					.HasColumnName("_noteNo");

				entity.Property(e => e.NoteUrl)
					.HasMaxLength(300)
					.HasColumnName("_noteURL");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SenderName)
					.HasMaxLength(30)
					.HasColumnName("_senderName");

				entity.Property(e => e.Title)
					.HasMaxLength(100)
					.HasColumnName("_title");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TblWeatherDynamicFactor>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWeatherDynamicFactor", "PaGamePrivate");

				entity.HasComment("날씨 동적 요소");

				entity.Property(e => e.AirPress)
					.HasColumnName("_airPress")
					.HasComment("기압");

				entity.Property(e => e.CloudRate)
					.HasColumnName("_cloudRate")
					.HasComment("구름비율(운량)");

				entity.Property(e => e.Direction)
					.HasColumnName("_direction")
					.HasComment("방향");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("마지막 수정일시");

				entity.Property(e => e.PositionX)
					.HasColumnName("_positionX")
					.HasComment("_positionX");

				entity.Property(e => e.PositionY)
					.HasColumnName("_positionY")
					.HasComment("_positionY");

				entity.Property(e => e.PositionZ)
					.HasColumnName("_positionZ")
					.HasComment("_positionZ");

				entity.Property(e => e.RadiusMax)
					.HasColumnName("_radiusMax")
					.HasComment("최대반경");

				entity.Property(e => e.RadiusMin)
					.HasColumnName("_radiusMin")
					.HasComment("최소반경");

				entity.Property(e => e.RainAmount)
					.HasColumnName("_rainAmount")
					.HasComment("강수량");

				entity.Property(e => e.Speed)
					.HasColumnName("_speed")
					.HasComment("속도");
			});

			modelBuilder.Entity<TblWeatherFactor>(entity =>
			{
				entity.HasKey(e => new { e.SlotNo, e.SectorX, e.SectorZ })
					.HasName("PkTblWeatherFactor");

				entity.ToTable("TblWeatherFactor", "PaGamePrivate");

				entity.HasComment("날씨 요소");

				entity.Property(e => e.SlotNo)
					.HasColumnName("_slotNo")
					.HasComment("슬롯번호");

				entity.Property(e => e.SectorX)
					.HasColumnName("_sectorX")
					.HasComment("_sectorX");

				entity.Property(e => e.SectorZ)
					.HasColumnName("_sectorZ")
					.HasComment("_sectorZ");

				entity.Property(e => e.Celsius)
					.HasColumnName("_celsius")
					.HasComment("섭씨");

				entity.Property(e => e.Grass)
					.HasColumnName("_grass")
					.HasComment("잔디");

				entity.Property(e => e.Humidity)
					.HasColumnName("_humidity")
					.HasComment("습기");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("마지막 수정일시");

				entity.Property(e => e.Oil)
					.HasColumnName("_oil")
					.HasComment("기름");

				entity.Property(e => e.Water)
					.HasColumnName("_water")
					.HasComment("물");
			});

			modelBuilder.Entity<TblWebBenefit>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWebBenefit", "PaGamePrivate");

				entity.Property(e => e.BenefitType).HasColumnName("_benefitType");

				entity.Property(e => e.IsUserNo).HasColumnName("_isUserNo");

				entity.Property(e => e.OwnerNo).HasColumnName("_ownerNo");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblWebContentsOption>(entity =>
			{
				entity.HasKey(e => e.Type)
					.HasName("PkTblWebContentsOption");

				entity.ToTable("TblWebContentsOption", "PaWebGamePrivate");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("_endDate");

				entity.Property(e => e.StartDate)
					.HasColumnType("datetime")
					.HasColumnName("_startDate");
			});

			modelBuilder.Entity<TblWindDirection>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWindDirection", "PaGamePrivate");

				entity.Property(e => e.LastUpdateDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Seed).HasColumnName("_seed");
			});

			modelBuilder.Entity<TblWorker>(entity =>
			{
				entity.HasKey(e => e.WorkerNo)
					.HasName("PkTblWorker")
					.IsClustered(false);

				entity.ToTable("TblWorker", "PaGamePrivate");

				entity.HasComment("일꾼");

				entity.Property(e => e.WorkerNo)
					.HasColumnName("_workerNo")
					.HasComment("_workerNo");

				entity.Property(e => e.ActionPoint)
					.HasColumnName("_actionPoint")
					.HasDefaultValueSql("((0))")
					.HasComment("작업 가능 횟수(NULL무제한, 0 행동력소모)");

				entity.Property(e => e.ActionPointMax)
					.HasColumnName("_actionPointMax")
					.HasDefaultValueSql("((0))")
					.HasComment("작업 가능 최대횟수(NULL무제한, 0 행동력소모)");

				entity.Property(e => e.CharacterKey)
					.HasColumnName("_characterKey")
					.HasComment("_characterKey");

				entity.Property(e => e.DeleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_deleteDate")
					.HasComment("삭제여부");

				entity.Property(e => e.Experience)
					.HasColumnName("_experience")
					.HasComment("현재 경험치");

				entity.Property(e => e.HomePlantKey)
					.HasColumnName("_homePlantKey")
					.HasComment("마을(살고 있는 곳)의 PlantKey");

				entity.Property(e => e.IsAuctionInsert)
					.HasColumnName("_isAuctionInsert")
					.HasComment("거래소 등록 여부");

				entity.Property(e => e.Level)
					.HasColumnName("_level")
					.HasComment("일꾼의 레벨");

				entity.Property(e => e.Luck)
					.HasColumnName("_luck")
					.HasComment("일꾼의 추가 행운");

				entity.Property(e => e.MoveSpeed)
					.HasColumnName("_moveSpeed")
					.HasComment("일꾼의 추가 이동속도");

				entity.Property(e => e.OwnerUserNo)
					.HasColumnName("_ownerUserNo")
					.HasComment("소유 사용자번호");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("_registerDate");

				entity.Property(e => e.SkillKey0)
					.HasColumnName("_skillKey0")
					.HasComment("일꾼의 스킬0");

				entity.Property(e => e.SkillKey1)
					.HasColumnName("_skillKey1")
					.HasComment("일꾼의 스킬1");

				entity.Property(e => e.SkillKey2)
					.HasColumnName("_skillKey2")
					.HasComment("일꾼의 스킬2");

				entity.Property(e => e.SkillKey3)
					.HasColumnName("_skillKey3")
					.HasComment("일꾼의 스킬3");

				entity.Property(e => e.SkillKey4)
					.HasColumnName("_skillKey4")
					.HasComment("일꾼의 스킬4");

				entity.Property(e => e.SkillKey5)
					.HasColumnName("_skillKey5")
					.HasComment("일꾼의 스킬5");

				entity.Property(e => e.SkillKey6)
					.HasColumnName("_skillKey6")
					.HasComment("일꾼의 스킬6");

				entity.Property(e => e.UpgradePoint)
					.HasColumnName("_upgradePoint")
					.HasComment("승급가능 횟수");

				entity.Property(e => e.WorkEfficience)
					.HasColumnName("_workEfficience")
					.HasComment("일꾼의 추가 효율");
			});

			modelBuilder.Entity<TblWorkerWorking>(entity =>
			{
				entity.HasKey(e => e.WorkerNo)
					.HasName("PkTblWorkerWorking");

				entity.ToTable("TblWorkerWorking", "PaGamePrivate");

				entity.HasComment("일꾼 작업");

				entity.Property(e => e.WorkerNo)
					.ValueGeneratedNever()
					.HasColumnName("_workerNo")
					.HasComment("_workerNo");

				entity.Property(e => e.EnchantLevel)
					.HasColumnName("_enchantLevel")
					.HasDefaultValueSql("((255))")
					.HasComment("개량할 아이템종류의 enchantLevel(_workingType에 따라서 가변적임)");

				entity.Property(e => e.Endurance)
					.HasColumnName("_endurance")
					.HasComment("개량할 아이템의 내구도");

				entity.Property(e => e.ExchangeKey)
					.HasColumnName("_exchangeKey")
					.HasComment("할일(전출의 경우 키 지정없음)");

				entity.Property(e => e.InstallationNo)
					.HasColumnName("_installationNo")
					.HasComment("집에서 제작하는 경우 사용할 (설치된)주설비의 번호");

				entity.Property(e => e.LeftCount)
					.HasColumnName("_leftCount")
					.HasComment("남은 작업회수");

				entity.Property(e => e.LuckProductivityLevel)
					.HasColumnName("_luckProductivityLevel")
					.HasComment("운 생산 효율 레벨");

				entity.Property(e => e.MaxEndurance)
					.HasColumnName("_maxEndurance")
					.HasComment("개량할 아이템의 최대 내구도");

				entity.Property(e => e.ProductivityLevel)
					.HasColumnName("_productivityLevel")
					.HasComment("생산 효율 레벨");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("작업시작시간");

				entity.Property(e => e.ServerNo)
					.HasColumnName("_serverNo")
					.HasComment("서버번호");

				entity.Property(e => e.StateChangeTime)
					.HasColumnType("datetime")
					.HasColumnName("_stateChangeTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("일상태 변경시간");

				entity.Property(e => e.ToPlantDynamicKey)
					.HasColumnName("_toPlantDynamicKey")
					.HasComment("목적지가 동적 플랜트일경우 추가키");

				entity.Property(e => e.ToPlantKey)
					.HasColumnName("_toPlantKey")
					.HasComment("목적지(=작업할 물건이 있는 곳)");

				entity.Property(e => e.ToVariable)
					.HasColumnName("_toVariable")
					.HasComment("목적지 정보(_workingType에 따라서 가변적임)");

				entity.Property(e => e.WorkingState)
					.HasColumnName("_workingState")
					.HasDefaultValueSql("((-1))")
					.HasComment("일의 상태");

				entity.Property(e => e.WorkingType)
					.HasColumnName("_workingType")
					.HasComment("OdbcNpcWorkingType 와 연결됨.");

				entity.Property(e => e.WorkingVariable)
					.HasColumnName("_workingVariable")
					.HasComment("작업내역 정보(_workingType에 따라서 가변적임)");

				entity.Property(e => e.WorkingVariable2)
					.HasColumnName("_workingVariable2")
					.HasComment("작업내역 정보2(_workingType에 따라서 가변적임)");
			});

			modelBuilder.Entity<TblWorldBoss>(entity =>
			{
				entity.HasKey(e => e.CharacterKey)
					.HasName("PkTblWorldBoss");

				entity.ToTable("TblWorldBoss", "PaGamePrivate");

				entity.Property(e => e.CharacterKey)
					.ValueGeneratedNever()
					.HasColumnName("_characterKey");

				entity.Property(e => e.CurrentHp).HasColumnName("_currentHp");

				entity.Property(e => e.UpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_updateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblWorldMarketCurrentPrice>(entity =>
			{
				entity.HasKey(e => new { e.MainKey, e.SubKey })
					.HasName("PkTblWorldMarketCurrentPrice")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketCurrentPrice", "PaGamePrivate");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.PricePerOne).HasColumnName("_pricePerOne");
			});

			modelBuilder.Entity<TblWorldMarketNoticeItem>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketNoticeItem", "PaGamePrivate");

				entity.Property(e => e.ChangedValue).HasColumnName("_changedValue");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.NoticeType).HasColumnName("_noticeType");

				entity.Property(e => e.Price).HasColumnName("_price");

				entity.Property(e => e.RegistTimeStamp).HasColumnName("_registTimeStamp");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");
			});

			modelBuilder.Entity<TblWorldMarketPayloadGameDb>(entity =>
			{
				entity.HasKey(e => e.Payload)
					.HasName("PkTblWorldMarketPayroad")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketPayloadGameDB", "PaGamePrivate");

				entity.Property(e => e.Payload)
					.ValueGeneratedNever()
					.HasColumnName("_payload");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.IsMovingTradeWeb).HasColumnName("_isMovingTradeWeb");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.State).HasColumnName("_state");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWorldMarketPayloadGameDbOld>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketPayloadGameDB_OLD", "PaGamePrivate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.IsMovingTradeWeb).HasColumnName("_isMovingTradeWeb");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.Payload).HasColumnName("_payload");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.State).HasColumnName("_state");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWorldMarketTicket>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.Type })
					.HasName("PkTblWorldMarketTicket")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketTicket", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.TicketNo).HasColumnName("_ticketNo");
			});

			modelBuilder.Entity<TblWorldQuestLimit>(entity =>
			{
				entity.HasKey(e => new { e.QuestGroupNo, e.QuestNo })
					.HasName("PkTblWorldQuestLimit");

				entity.ToTable("TblWorldQuestLimit", "PaGamePrivate");

				entity.Property(e => e.QuestGroupNo).HasColumnName("_questGroupNo");

				entity.Property(e => e.QuestNo).HasColumnName("_questNo");

				entity.Property(e => e.ClearedCount).HasColumnName("_clearedCount");
			});

			modelBuilder.Entity<TblXboxCashInfo>(entity =>
			{
				entity.HasKey(e => new { e.AccountNo, e.LegacyProductId })
					.HasName("PkTblXBoxCashInfo")
					.IsClustered(false);

				entity.ToTable("TblXBoxCashInfo", "PaGamePrivate");

				entity.HasComment("캐쉬정보");

				entity.Property(e => e.AccountNo)
					.HasMaxLength(30)
					.HasColumnName("_accountNo")
					.HasComment("계정 번호");

				entity.Property(e => e.LegacyProductId)
					.HasMaxLength(40)
					.HasColumnName("_legacyProductId")
					.HasComment("상품 넘버");

				entity.Property(e => e.ConsumeCount)
					.HasColumnName("_consumeCount")
					.HasComment("사용한 상품 개수 (누적 수량, remarks 참고)");

				entity.Property(e => e.ProductCount)
					.HasColumnName("_productCount")
					.HasComment("xbox 에서 구매한 상품 개수 (누적 수량, remarks 참고)");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())")
					.HasComment("생성일");
			});

			modelBuilder.Entity<TblXboxCashInfoLog>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblXBoxCashInfoLog", "PaGamePrivate");

				entity.Property(e => e.CashProductNo).HasColumnName("_cashProductNo");

				entity.Property(e => e.CreatedCount).HasColumnName("_createdCount");

				entity.Property(e => e.LegacyProductId)
					.HasMaxLength(40)
					.HasColumnName("_legacyProductId");

				entity.Property(e => e.LogNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_logNo");

				entity.Property(e => e.MailNo).HasColumnName("_mailNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");
			});

			modelBuilder.Entity<TexplorationExpTable>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TExplorationExpTable", "PaOperationPublic");

				entity.Property(e => e.Level).HasColumnName("_level");

				entity.Property(e => e.MaxExp).HasColumnName("_maxExp");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
