using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class SA_BETA_TRADEDB_0002Context : DbContext
	{
		public SA_BETA_TRADEDB_0002Context()
		{
		}

		public SA_BETA_TRADEDB_0002Context(DbContextOptions<SA_BETA_TRADEDB_0002Context> options)
			: base(options)
		{
		}

		public virtual DbSet<TargetItemTrade> TargetItemTrades { get; set; } = null!;
		public virtual DbSet<TblAppPushEnableFlag> TblAppPushEnableFlags { get; set; } = null!;
		public virtual DbSet<TblAutoBuyBannedMainCategory> TblAutoBuyBannedMainCategories { get; set; } = null!;
		public virtual DbSet<TblAutoBuyBannedSubCategory> TblAutoBuyBannedSubCategories { get; set; } = null!;
		public virtual DbSet<TblAutoBuyBlockedItem> TblAutoBuyBlockedItems { get; set; } = null!;
		public virtual DbSet<TblAutoBuyBoughtItemsLog> TblAutoBuyBoughtItemsLogs { get; set; } = null!;
		public virtual DbSet<TblAutoBuyLog> TblAutoBuyLogs { get; set; } = null!;
		public virtual DbSet<TblAutoBuyOption> TblAutoBuyOptions { get; set; } = null!;
		public virtual DbSet<TblBlockItem> TblBlockItems { get; set; } = null!;
		public virtual DbSet<TblBlockUser> TblBlockUsers { get; set; } = null!;
		public virtual DbSet<TblContentMst> TblContentMsts { get; set; } = null!;
		public virtual DbSet<TblDisabledAutoBuyUser> TblDisabledAutoBuyUsers { get; set; } = null!;
		public virtual DbSet<TblMinusLoanIndex> TblMinusLoanIndices { get; set; } = null!;
		public virtual DbSet<TblMinusLoanInfo> TblMinusLoanInfos { get; set; } = null!;
		public virtual DbSet<TblMinusLoanResultInfo> TblMinusLoanResultInfos { get; set; } = null!;
		public virtual DbSet<TblShutDownDetail> TblShutDownDetails { get; set; } = null!;
		public virtual DbSet<TblWaitItem> TblWaitItems { get; set; } = null!;
		public virtual DbSet<TblWebLogEnableFlag> TblWebLogEnableFlags { get; set; } = null!;
		public virtual DbSet<TblWorldMarket> TblWorldMarkets { get; set; } = null!;
		public virtual DbSet<TblWorldMarketBiddingBuy> TblWorldMarketBiddingBuys { get; set; } = null!;
		public virtual DbSet<TblWorldMarketBiddingSell> TblWorldMarketBiddingSells { get; set; } = null!;
		public virtual DbSet<TblWorldMarketKeyWord> TblWorldMarketKeyWords { get; set; } = null!;
		public virtual DbSet<TblWorldMarketNoticeItem> TblWorldMarketNoticeItems { get; set; } = null!;
		public virtual DbSet<TblWorldMarketOption> TblWorldMarketOptions { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPayload> TblWorldMarketPayloads { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPayloadOld> TblWorldMarketPayloadOlds { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPayloadRestoration> TblWorldMarketPayloadRestorations { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPersonalTrade> TblWorldMarketPersonalTrades { get; set; } = null!;
		public virtual DbSet<TblWorldMarketPriceInfo> TblWorldMarketPriceInfos { get; set; } = null!;
		public virtual DbSet<TblWorldMarketRingBuff> TblWorldMarketRingBuffs { get; set; } = null!;
		public virtual DbSet<TblWorldMarketTickCount> TblWorldMarketTickCounts { get; set; } = null!;
		public virtual DbSet<TblWorldMarketWaitBiddingSell> TblWorldMarketWaitBiddingSells { get; set; } = null!;
		public virtual DbSet<TblWorldMarketWaitBiddingSellNotice> TblWorldMarketWaitBiddingSellNotices { get; set; } = null!;
		public virtual DbSet<TblWorldMarketWallet> TblWorldMarketWallets { get; set; } = null!;
		public virtual DbSet<TblWorldMarketWalletInfo> TblWorldMarketWalletInfos { get; set; } = null!;
		public virtual DbSet<TblWorldMarketWalletParam> TblWorldMarketWalletParams { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(ConnHelper.GetConnString("Trade"))
					.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TargetItemTrade>(entity =>
			{
				entity.HasKey(e => e.ItemKey)
					.HasName("PKTargetItemTrade");

				entity.ToTable("TargetItemTrade", "PaOperationPrivate");

				entity.Property(e => e.ItemKey)
					.ValueGeneratedNever()
					.HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblAppPushEnableFlag>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblAppPushEnableFlag", "PaGamePrivate");

				entity.Property(e => e.EnablePushSend).HasColumnName("_enablePushSend");
			});

			modelBuilder.Entity<TblAutoBuyBannedMainCategory>(entity =>
			{
				entity.ToTable("TblAutoBuyBannedMainCategory");

				entity.Property(e => e.Id).HasColumnName("_id");

				entity.Property(e => e.MainGroupNo).HasColumnName("_mainGroupNo");
			});

			modelBuilder.Entity<TblAutoBuyBannedSubCategory>(entity =>
			{
				entity.ToTable("TblAutoBuyBannedSubCategory");

				entity.Property(e => e.Id).HasColumnName("_id");

				entity.Property(e => e.MainGroup).HasColumnName("_mainGroup");

				entity.Property(e => e.SubGroup).HasColumnName("_subGroup");
			});

			modelBuilder.Entity<TblAutoBuyBlockedItem>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("_id");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");
			});

			modelBuilder.Entity<TblAutoBuyBoughtItemsLog>(entity =>
			{
				entity.ToTable("TblAutoBuyBoughtItemsLog");

				entity.Property(e => e.Id).HasColumnName("_id");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.EnchantLevel).HasColumnName("_enchantLevel");

				entity.Property(e => e.GivenSilver).HasColumnName("_givenSilver");

				entity.Property(e => e.IsRingBuff).HasColumnName("_isRingBuff");

				entity.Property(e => e.ItemKey).HasColumnName("_itemKey");

				entity.Property(e => e.ItemOriginalPrice).HasColumnName("_itemOriginalPrice");

				entity.Property(e => e.Percent).HasColumnName("_percent");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblAutoBuyLog>(entity =>
			{
				entity.ToTable("TblAutoBuyLog");

				entity.Property(e => e.Id).HasColumnName("_id");

				entity.Property(e => e.ItemsBought).HasColumnName("_itemsBought");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.TotalSilverGiven).HasColumnName("_totalSilverGiven");

				entity.Property(e => e.UserCount).HasColumnName("_userCount");
			});

			modelBuilder.Entity<TblAutoBuyOption>(entity =>
			{
				entity.HasKey(e => e.IsAutoBuyOpen)
					.HasName("PKTblAutoBuyOption");

				entity.Property(e => e.CheckEmail).HasColumnName("_checkEmail");

				entity.Property(e => e.CheckEmailConfirmed).HasColumnName("_checkEmailConfirmed");

				entity.Property(e => e.IsAutoBuyOpen).HasColumnName("_isAutoBuyOpen");

				entity.Property(e => e.MaxPriceLimit)
					.HasColumnName("_maxPriceLimit")
					.HasDefaultValueSql("((1000000000000.))");

				entity.Property(e => e.PremiumPercent)
					.HasColumnName("_premiumPercent")
					.HasDefaultValueSql("((25))");

				entity.Property(e => e.RingSilverBuff)
					.HasColumnName("_ringSilverBuff")
					.HasDefaultValueSql("((5))");

				entity.Property(e => e.SilverPercent)
					.HasColumnName("_silverPercent")
					.HasDefaultValueSql("((20))");

				entity.Property(e => e.ItemWaitDay)
					.HasColumnName("_itemWaitDay")
					.HasDefaultValueSql("((7))");
			});

			modelBuilder.Entity<TblBlockItem>(entity =>
			{
				entity.HasKey(e => new { e.KeyType, e.MainKey, e.SubKey })
					.HasName("PkTblBlockItem")
					.IsClustered(false);

				entity.ToTable("TblBlockItem", "PaGamePrivate");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblBlockUser>(entity =>
			{
				entity.HasKey(e => new { e.NationCode, e.ServerNo, e.UserNo })
					.HasName("PkTblBlockUser")
					.IsClustered(false);

				entity.ToTable("TblBlockUser", "PaGamePrivate");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.DueDate)
					.HasColumnType("datetime")
					.HasColumnName("_dueDate");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblContentMst>(entity =>
			{
				entity.HasKey(e => e.GroupContentNo)
					.HasName("PkTblContentMst")
					.IsClustered(false);

				entity.ToTable("TblContentMst", "PaGamePrivate");

				entity.Property(e => e.GroupContentNo)
					.ValueGeneratedNever()
					.HasColumnName("_groupContentNo");

				entity.Property(e => e.ContentEndDate)
					.HasColumnType("datetime")
					.HasColumnName("_contentEndDate");

				entity.Property(e => e.ContentStartDate)
					.HasColumnType("datetime")
					.HasColumnName("_contentStartDate");

				entity.Property(e => e.IsDelete).HasColumnName("_isDelete");

				entity.Property(e => e.IsDisplay)
					.IsRequired()
					.HasColumnName("_isDisplay")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.RegDate)
					.HasColumnType("datetime")
					.HasColumnName("_regDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDateTime]())");

				entity.Property(e => e.UpdDate)
					.HasColumnType("datetime")
					.HasColumnName("_updDate");
			});

			modelBuilder.Entity<TblDisabledAutoBuyUser>(entity =>
			{
				entity.HasKey(e => e.UserNo)
					.HasName("PK__TblAutoB__D84CDD5FB6EF62DB");

				entity.ToTable("TblDisabledAutoBuyUser");

				entity.Property(e => e.UserNo)
					.ValueGeneratedNever()
					.HasColumnName("_userNo");

				entity.Property(e => e.RegisterDate)
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<TblMinusLoanIndex>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblMinusLoanIndex", "PaOperationPublic");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.Idx)
					.ValueGeneratedOnAdd()
					.HasColumnName("_idx");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.Result)
					.HasColumnName("_result")
					.HasDefaultValueSql("((0))");
			});

			modelBuilder.Entity<TblMinusLoanInfo>(entity =>
			{
				entity.HasKey(e => new { e.Idx, e.UserId })
					.HasName("PK_TblMinusLoanInfo_idx_userId");

				entity.ToTable("TblMinusLoanInfo", "PaOperationPublic");

				entity.Property(e => e.Idx).HasColumnName("_idx");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.MinusMoney).HasColumnName("_minusMoney");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblMinusLoanResultInfo>(entity =>
			{
				entity.HasKey(e => new { e.Idx, e.UserId })
					.HasName("PK_TblMinusLoanResultInfo_idx_userId");

				entity.ToTable("TblMinusLoanResultInfo", "PaOperationPublic");

				entity.Property(e => e.Idx).HasColumnName("_idx");

				entity.Property(e => e.UserId)
					.HasMaxLength(30)
					.HasColumnName("_userId");

				entity.Property(e => e.AfterMoney).HasColumnName("_afterMoney");

				entity.Property(e => e.BeforeMoney).HasColumnName("_beforeMoney");

				entity.Property(e => e.MinusMoney).HasColumnName("_minusMoney");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblShutDownDetail>(entity =>
			{
				entity.HasKey(e => new { e.GroupContentno, e.CultureCode })
					.HasName("PkTblShutDownDetail")
					.IsClustered(false);

				entity.ToTable("TblShutDownDetail", "PaGamePrivate");

				entity.Property(e => e.GroupContentno).HasColumnName("_groupContentno");

				entity.Property(e => e.CultureCode)
					.HasMaxLength(8)
					.IsUnicode(false)
					.HasColumnName("_cultureCode");

				entity.Property(e => e.MainMessage).HasColumnName("_mainMessage");

				entity.Property(e => e.Memo)
					.HasMaxLength(200)
					.HasColumnName("_memo");

				entity.Property(e => e.RedirectUrl)
					.HasMaxLength(300)
					.HasColumnName("_redirectUrl");

				entity.Property(e => e.SubMessage).HasColumnName("_subMessage");
			});

			modelBuilder.Entity<TblWaitItem>(entity =>
			{
				entity.HasKey(e => new { e.KeyType, e.MainKey, e.SubKey })
					.HasName("PkTblWaitItem")
					.IsClustered(false);

				entity.ToTable("TblWaitItem", "PaGamePrivate");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");
			});

			modelBuilder.Entity<TblWebLogEnableFlag>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWebLogEnableFlag", "PaGamePrivate");

				entity.Property(e => e.WriteDebugLog).HasColumnName("_writeDebugLog");

				entity.Property(e => e.WriteErrorLog)
					.IsRequired()
					.HasColumnName("_writeErrorLog")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.WriteFatalLog)
					.IsRequired()
					.HasColumnName("_writeFatalLog")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.WriteInfoLog).HasColumnName("_writeInfoLog");

				entity.Property(e => e.WriteWarringLog)
					.IsRequired()
					.HasColumnName("_writeWarringLog")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<TblWorldMarket>(entity =>
			{
				entity.HasKey(e => new { e.MainKey, e.SubKey, e.KeyType })
					.HasName("PkTblWorldMarket");

				entity.ToTable("TblWorldMarket", "PaGamePrivate");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.AccumulateBiddingCount).HasColumnName("_accumulateBiddingCount");

				entity.Property(e => e.AccumulateTickCount).HasColumnName("_accumulateTickCount");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.CurrentTrend).HasColumnName("_currentTrend");

				entity.Property(e => e.FluctuationPrice).HasColumnName("_fluctuationPrice");

				entity.Property(e => e.FluctuationType).HasColumnName("_fluctuationType");

				entity.Property(e => e.IsDisplay).HasColumnName("_isDisplay");

				entity.Property(e => e.LastTradePrice).HasColumnName("_lastTradePrice");

				entity.Property(e => e.LastTradeTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastTradeTime")
					.HasDefaultValueSql("('1970-01-01 00:00:00')");

				entity.Property(e => e.MainCategory).HasColumnName("_mainCategory");

				entity.Property(e => e.MaxPrice).HasColumnName("_maxPrice");

				entity.Property(e => e.MaxTradeCount).HasColumnName("_maxTradeCount");

				entity.Property(e => e.MinPrice).HasColumnName("_minPrice");

				entity.Property(e => e.PriceGroupKey).HasColumnName("_priceGroupKey");

				entity.Property(e => e.PricePerOne).HasColumnName("_pricePerOne");

				entity.Property(e => e.RealMaxPrice).HasColumnName("_realMaxPrice");

				entity.Property(e => e.RealMinPrice).HasColumnName("_realMinPrice");

				entity.Property(e => e.SubCategory).HasColumnName("_subCategory");

				entity.Property(e => e.SumTradeCount).HasColumnName("_sumTradeCount");

				entity.Property(e => e.SumTradeCountByStock).HasColumnName("_sumTradeCountByStock");

				entity.Property(e => e.SumTradePrice).HasColumnName("_sumTradePrice");

				entity.Property(e => e.TotalTradeCount).HasColumnName("_totalTradeCount");

				entity.Property(e => e.TrendKeepCount).HasColumnName("_trendKeepCount");
			});

			modelBuilder.Entity<TblWorldMarketBiddingBuy>(entity =>
			{
				entity.HasKey(e => new { e.MainKey, e.SubKey, e.KeyType, e.UserNo })
					.HasName("PkTblWorldMarketBiddingBuy");

				entity.ToTable("TblWorldMarketBiddingBuy", "PaGamePrivate");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.AddEnchantPrice).HasColumnName("_addEnchantPrice");

				entity.Property(e => e.BoughtCount).HasColumnName("_boughtCount");

				entity.Property(e => e.BuyNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_buyNo");

				entity.Property(e => e.ChooseSubKey).HasColumnName("_chooseSubKey");

				entity.Property(e => e.IsCashCategory).HasColumnName("_isCashCategory");

				entity.Property(e => e.LeftCount).HasColumnName("_leftCount");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.NeedMaterialCount).HasColumnName("_needMaterialCount");

				entity.Property(e => e.PricePerOne).HasColumnName("_pricePerOne");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.RegisterMoneyCount).HasColumnName("_registerMoneyCount");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");
			});

			modelBuilder.Entity<TblWorldMarketBiddingSell>(entity =>
			{
				entity.HasKey(e => new { e.MainKey, e.SubKey, e.UserNo, e.IsSealed, e.KeyType })
					.HasName("PkTblWorldMarketBiddingSell");

				entity.ToTable("TblWorldMarketBiddingSell", "PaGamePrivate");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.AccumulateMoneyCount).HasColumnName("_accumulateMoneyCount");

				entity.Property(e => e.ChooseSubKey).HasColumnName("_chooseSubKey");

				entity.Property(e => e.IsRingBuff).HasColumnName("_isRingBuff");

				entity.Property(e => e.LeftCount).HasColumnName("_leftCount");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.NeedMaterialCount).HasColumnName("_needMaterialCount");

				entity.Property(e => e.PricePerOne).HasColumnName("_pricePerOne");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SellNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_sellNo")
					.Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.SoldCount).HasColumnName("_soldCount");
			});

			modelBuilder.Entity<TblWorldMarketKeyWord>(entity =>
			{
				entity.HasKey(e => e.KeyWordNo)
					.HasName("PkTblWorldMarketKeyWord")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketKeyWord", "PaGamePrivate");

				entity.Property(e => e.KeyWordNo).HasColumnName("_keyWordNo");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SearchKeyWord)
					.HasMaxLength(30)
					.HasColumnName("_searchKeyWord");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
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

			modelBuilder.Entity<TblWorldMarketOption>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketOption", "PaGamePrivate");

				entity.Property(e => e.IsMarketOpen)
					.IsRequired()
					.HasColumnName("_isMarketOpen")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IsRingBuff)
					.IsRequired()
					.HasColumnName("_isRingBuff")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.RingBuff).HasColumnName("_ringBuff");

				entity.Property(e => e.WaitPrice).HasColumnName("_waitPrice");
			});

			modelBuilder.Entity<TblWorldMarketPayload>(entity =>
			{
				entity.HasKey(e => e.Payload)
					.HasName("PkTblWorldMarketPayload")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketPayload", "PaGamePrivate");

				entity.Property(e => e.Payload).HasColumnName("_payload");

				entity.Property(e => e.Count).HasColumnName("_count");

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

				entity.Property(e => e.Weight).HasColumnName("_weight");
			});

			modelBuilder.Entity<TblWorldMarketPayloadOld>(entity =>
			{
				entity.HasKey(e => e.Payload)
					.HasName("PkTblWorldMarketPayload_OLD")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketPayload_OLD", "PaGamePrivate");

				entity.Property(e => e.Payload).HasColumnName("_payload");

				entity.Property(e => e.Count).HasColumnName("_count");

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

				entity.Property(e => e.Weight).HasColumnName("_weight");
			});

			modelBuilder.Entity<TblWorldMarketPayloadRestoration>(entity =>
			{
				entity.HasKey(e => e.Payload)
					.HasName("PkTblWorldMarketPayloadRestoration")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketPayloadRestoration", "PaGamePrivate");

				entity.Property(e => e.Payload)
					.ValueGeneratedNever()
					.HasColumnName("_payload");

				entity.Property(e => e.AfterTotalCount).HasColumnName("_afterTotalCount");

				entity.Property(e => e.BeforeTotalCount).HasColumnName("_beforeTotalCount");

				entity.Property(e => e.CompleteDate)
					.HasColumnType("datetime")
					.HasColumnName("_completeDate");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.GameState).HasColumnName("_gameState");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.MarketState).HasColumnName("_marketState");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.Param0).HasColumnName("_param0");

				entity.Property(e => e.Param1).HasColumnName("_param1");

				entity.Property(e => e.Param2).HasColumnName("_param2");

				entity.Property(e => e.Param3).HasColumnName("_param3");

				entity.Property(e => e.Param4).HasColumnName("_param4");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.Type).HasColumnName("_type");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			modelBuilder.Entity<TblWorldMarketPersonalTrade>(entity =>
			{
				entity.HasKey(e => e.MarketNo)
					.HasName("PkTblWorldMarketPersonalTrade")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketPersonalTrade", "PaGamePrivate");

				entity.Property(e => e.MarketNo).HasColumnName("_marketNo");

				entity.Property(e => e.Count).HasColumnName("_count");

				entity.Property(e => e.FromNationCode).HasColumnName("_fromNationCode");

				entity.Property(e => e.FromServerNo).HasColumnName("_fromServerNo");

				entity.Property(e => e.FromUserNo).HasColumnName("_fromUserNo");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.PricePerOne).HasColumnName("_pricePerOne");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.ToNationCode).HasColumnName("_toNationCode");

				entity.Property(e => e.ToServerNo).HasColumnName("_toServerNo");

				entity.Property(e => e.ToUserNo).HasColumnName("_toUserNo");
			});

			modelBuilder.Entity<TblWorldMarketPriceInfo>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketPriceInfo", "PaGamePrivate");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.Price).HasColumnName("_price");

				entity.Property(e => e.RegistTimeStamp).HasColumnName("_registTimeStamp");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");
			});

			modelBuilder.Entity<TblWorldMarketRingBuff>(entity =>
			{
				entity.HasKey(e => new { e.NationCode, e.ServerNo, e.UserNo })
					.HasName("PkTblWorldMarketRingBuff")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketRingBuff", "PaGamePrivate");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.MaxCount).HasColumnName("_maxCount");

				entity.Property(e => e.UsingCount).HasColumnName("_usingCount");
			});

			modelBuilder.Entity<TblWorldMarketTickCount>(entity =>
			{
				entity.HasKey(e => e.MainGroupNo)
					.HasName("PkTblWorldMarketTickCount")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketTickCount", "PaGamePrivate");

				entity.Property(e => e.MainGroupNo)
					.ValueGeneratedNever()
					.HasColumnName("_mainGroupNo");

				entity.Property(e => e.AllowIndex).HasColumnName("_allowIndex");

				entity.Property(e => e.CurrentTickCount).HasColumnName("_currentTickCount");

				entity.Property(e => e.LastUpdateTime)
					.HasColumnType("datetime")
					.HasColumnName("_LastUpdateTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerIp)
					.HasMaxLength(15)
					.IsUnicode(false)
					.HasColumnName("_serverIp");

				entity.Property(e => e.UpdateAccumulateCount).HasColumnName("_updateAccumulateCount");

				entity.Property(e => e.UpdateTickCount)
					.HasColumnName("_updateTickCount")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<TblWorldMarketWaitBiddingSell>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketWaitBiddingSell", "PaGamePrivate");

				entity.Property(e => e.ChooseSubKey).HasColumnName("_chooseSubKey");

				entity.Property(e => e.IsRingBuff).HasColumnName("_isRingBuff");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.LeftCount).HasColumnName("_leftCount");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.PricePerOne).HasColumnName("_pricePerOne");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.UsedType).HasColumnName("_usedType");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.WaitNo)
					.ValueGeneratedOnAdd()
					.HasColumnName("_waitNo");
			});

			modelBuilder.Entity<TblWorldMarketWaitBiddingSellNotice>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketWaitBiddingSellNotice", "PaGamePrivate");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResultMoneyCount).HasColumnName("_resultMoneyCount");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.Status).HasColumnName("_status");

				entity.Property(e => e.UsedType).HasColumnName("_usedType");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.WaitNo).HasColumnName("_waitNo");
			});

			modelBuilder.Entity<TblWorldMarketWallet>(entity =>
			{
				entity.HasKey(e => new { e.UserNo, e.ServerNo, e.NationCode, e.KeyType, e.MainKey, e.SubKey, e.IsSealed })
					.HasName("PkTblWorldMarketWallet");

				entity.ToTable("TblWorldMarketWallet", "PaGamePrivate");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.KeyType).HasColumnName("_keyType");

				entity.Property(e => e.MainKey).HasColumnName("_mainKey");

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.IsSealed).HasColumnName("_isSealed");

				entity.Property(e => e.Count).HasColumnName("_count");
			});

			modelBuilder.Entity<TblWorldMarketWalletInfo>(entity =>
			{
				entity.HasKey(e => new { e.NationCode, e.ServerNo, e.UserNo })
					.HasName("PkTblWorldMarketWalletInfo")
					.IsClustered(false);

				entity.ToTable("TblWorldMarketWalletInfo", "PaGamePrivate");

				entity.Property(e => e.NationCode).HasColumnName("_nationCode");

				entity.Property(e => e.ServerNo).HasColumnName("_serverNo");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");

				entity.Property(e => e.AddPearlItemLimitedCount).HasColumnName("_addPearlItemLimitedCount");

				entity.Property(e => e.AddTaxDiscountRate).HasColumnName("_addTaxDiscountRate");

				entity.Property(e => e.AddWeight).HasColumnName("_addWeight");

				entity.Property(e => e.AddWeightBuffExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_addWeightBuffExpiration")
					.HasDefaultValueSql("('1970-01-01 00:00:00')");

				entity.Property(e => e.AddWeightByBuff).HasColumnName("_addWeightByBuff");

				entity.Property(e => e.BlackUserCheckCount).HasColumnName("_blackUserCheckCount");

				entity.Property(e => e.BlackUserCheckTime)
					.HasColumnType("datetime")
					.HasColumnName("_blackUserCheckTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.FamilySkillAddTaxDiscountRate).HasColumnName("_familySkillAddTaxDiscountRate");

				entity.Property(e => e.IsGameMaster).HasColumnName("_isGameMaster");

				entity.Property(e => e.LastConfirmOtpTime)
					.HasColumnType("datetime")
					.HasColumnName("_lastConfirmOtpTime");

				entity.Property(e => e.LastSecondPwdFailDate)
					.HasColumnType("datetime")
					.HasColumnName("_lastSecondPwdFailDate");

				entity.Property(e => e.MaidCount).HasColumnName("_maidCount");

				entity.Property(e => e.PackageExpiration)
					.HasColumnType("datetime")
					.HasColumnName("_packageExpiration")
					.HasDefaultValueSql("('1970-01-01 00:00:00')");

				entity.Property(e => e.PearlItemLimitedCount).HasColumnName("_pearlItemLimitedCount");

				entity.Property(e => e.PearlItemLimitedresetTime)
					.HasColumnType("datetime")
					.HasColumnName("_pearlItemLimitedresetTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.PersonalTradeBuyCount).HasColumnName("_personalTradeBuyCount");

				entity.Property(e => e.PersonalTradeSellCount).HasColumnName("_personalTradeSellCount");

				entity.Property(e => e.RegisterDate)
					.HasColumnType("datetime")
					.HasColumnName("_registerDate")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.ResetTime)
					.HasColumnType("datetime")
					.HasColumnName("_resetTime")
					.HasDefaultValueSql("([PaGamePublic].[ufnGetCustomDatetime]())");

				entity.Property(e => e.SecondPwdFailCount).HasColumnName("_secondPwdFailCount");

				entity.Property(e => e.UserId)
					.HasMaxLength(60)
					.HasColumnName("_userId");

				entity.Property(e => e.UserNickname)
					.HasMaxLength(30)
					.HasColumnName("_userNickname");

				entity.Property(e => e.Weight).HasColumnName("_weight");
			});

			modelBuilder.Entity<TblWorldMarketWalletParam>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("TblWorldMarketWalletParam", "PaGamePrivate");

				entity.Property(e => e.Count).HasColumnName("_count");

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

				entity.Property(e => e.SubKey).HasColumnName("_subKey");

				entity.Property(e => e.UserNo).HasColumnName("_userNo");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
