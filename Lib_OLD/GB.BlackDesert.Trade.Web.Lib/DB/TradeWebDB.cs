// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.TradeWebDB
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class TradeWebDB : DbContext
    {
        public TradeWebDB()
          : base("name=TradeWebDB")
        {
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
        }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

        public virtual int uspUnRegisterBuyableReserve(
          int? keyType,
          int? mainKey,
          int? subKey,
          long? count,
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUnRegisterBuyableReserve), new ObjectParameter[9]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspGetAndUpdatePersonalTradeCount(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter personalTradeBuyCount,
          ObjectParameter personalTradeSellCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetAndUpdatePersonalTradeCount), new ObjectParameter[7]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        personalTradeBuyCount,
        personalTradeSellCount,
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspLoadWorldMarketInfo_Result> uspLoadWorldMarketInfo(
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspLoadWorldMarketInfo_Result>(nameof(uspLoadWorldMarketInfo), new ObjectParameter[2]
            {
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspBuyablePersonalTradeList_Result> uspBuyablePersonalTradeList(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspBuyablePersonalTradeList_Result>(nameof(uspBuyablePersonalTradeList), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspPersonalTradeList_Result> uspPersonalTradeList(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspPersonalTradeList_Result>(nameof(uspPersonalTradeList), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspUnregisterPersonalTrade(
          long? marketNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          long? pricePerOne,
          long? count,
          int? fromNationCode,
          int? fromServerNo,
          long? fromUserNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUnregisterPersonalTrade), new ObjectParameter[11]
            {
        marketNo.HasValue ? new ObjectParameter(nameof (marketNo), (object) marketNo) : new ObjectParameter(nameof (marketNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        pricePerOne.HasValue ? new ObjectParameter(nameof (pricePerOne), (object) pricePerOne) : new ObjectParameter(nameof (pricePerOne), typeof (long)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        fromNationCode.HasValue ? new ObjectParameter(nameof (fromNationCode), (object) fromNationCode) : new ObjectParameter(nameof (fromNationCode), typeof (int)),
        fromServerNo.HasValue ? new ObjectParameter(nameof (fromServerNo), (object) fromServerNo) : new ObjectParameter(nameof (fromServerNo), typeof (int)),
        fromUserNo.HasValue ? new ObjectParameter(nameof (fromUserNo), (object) fromUserNo) : new ObjectParameter(nameof (fromUserNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketAccumulateTradeByStock_Result> uspListWorldMarketAccumulateTradeByStock(
          int? mainGroupNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketAccumulateTradeByStock_Result>(nameof(uspListWorldMarketAccumulateTradeByStock), new ObjectParameter[3]
            {
        mainGroupNo.HasValue ? new ObjectParameter(nameof (mainGroupNo), (object) mainGroupNo) : new ObjectParameter(nameof (mainGroupNo), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual int uspUpdateWorldMarketStock(
          int? keyType,
          int? mainKey,
          int? subKey,
          long? newStockCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateWorldMarketStock), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        newStockCount.HasValue ? new ObjectParameter(nameof (newStockCount), (object) newStockCount) : new ObjectParameter(nameof (newStockCount), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspFindUser_Result> uspFindUser(
          int? serverNo,
          string userNickname,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspFindUser_Result>(nameof(uspFindUser), new ObjectParameter[4]
            {
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNickname != null ? new ObjectParameter(nameof (userNickname), (object) userNickname) : new ObjectParameter(nameof (userNickname), typeof (string)),
        symNo,
        rv
            });
        }

        public virtual int uspSetUpdateTickCount(
          int? mainGroupNo,
          int? updateTickCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetUpdateTickCount), new ObjectParameter[4]
            {
        mainGroupNo.HasValue ? new ObjectParameter(nameof (mainGroupNo), (object) mainGroupNo) : new ObjectParameter(nameof (mainGroupNo), typeof (int)),
        updateTickCount.HasValue ? new ObjectParameter(nameof (updateTickCount), (object) updateTickCount) : new ObjectParameter(nameof (updateTickCount), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual int uspInsertBlockItem(
          int? keyType,
          int? mainKey,
          long? subKey,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspInsertBlockItem), new ObjectParameter[5]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspRemoveBlockItem(
          int? keyType,
          int? mainKey,
          long? subKey,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspRemoveBlockItem), new ObjectParameter[5]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspBuyItemFromPersonalTrade(
          long? marketNo,
          int? buyKeyType,
          int? buyMainKey,
          int? buySubKey,
          long? buyCount,
          int? moneyKeyType,
          int? moneyMainKey,
          int? moneySubKey,
          long? moneyCount,
          int? toNationCode,
          int? toServerNo,
          long? toUserNo,
          int? maxBuyCount,
          int? maxSellCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspBuyItemFromPersonalTrade), new ObjectParameter[16]
            {
        marketNo.HasValue ? new ObjectParameter(nameof (marketNo), (object) marketNo) : new ObjectParameter(nameof (marketNo), typeof (long)),
        buyKeyType.HasValue ? new ObjectParameter(nameof (buyKeyType), (object) buyKeyType) : new ObjectParameter(nameof (buyKeyType), typeof (int)),
        buyMainKey.HasValue ? new ObjectParameter(nameof (buyMainKey), (object) buyMainKey) : new ObjectParameter(nameof (buyMainKey), typeof (int)),
        buySubKey.HasValue ? new ObjectParameter(nameof (buySubKey), (object) buySubKey) : new ObjectParameter(nameof (buySubKey), typeof (int)),
        buyCount.HasValue ? new ObjectParameter(nameof (buyCount), (object) buyCount) : new ObjectParameter(nameof (buyCount), typeof (long)),
        moneyKeyType.HasValue ? new ObjectParameter(nameof (moneyKeyType), (object) moneyKeyType) : new ObjectParameter(nameof (moneyKeyType), typeof (int)),
        moneyMainKey.HasValue ? new ObjectParameter(nameof (moneyMainKey), (object) moneyMainKey) : new ObjectParameter(nameof (moneyMainKey), typeof (int)),
        moneySubKey.HasValue ? new ObjectParameter(nameof (moneySubKey), (object) moneySubKey) : new ObjectParameter(nameof (moneySubKey), typeof (int)),
        moneyCount.HasValue ? new ObjectParameter(nameof (moneyCount), (object) moneyCount) : new ObjectParameter(nameof (moneyCount), typeof (long)),
        toNationCode.HasValue ? new ObjectParameter(nameof (toNationCode), (object) toNationCode) : new ObjectParameter(nameof (toNationCode), typeof (int)),
        toServerNo.HasValue ? new ObjectParameter(nameof (toServerNo), (object) toServerNo) : new ObjectParameter(nameof (toServerNo), typeof (int)),
        toUserNo.HasValue ? new ObjectParameter(nameof (toUserNo), (object) toUserNo) : new ObjectParameter(nameof (toUserNo), typeof (long)),
        maxBuyCount.HasValue ? new ObjectParameter(nameof (maxBuyCount), (object) maxBuyCount) : new ObjectParameter(nameof (maxBuyCount), typeof (int)),
        maxSellCount.HasValue ? new ObjectParameter(nameof (maxSellCount), (object) maxSellCount) : new ObjectParameter(nameof (maxSellCount), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual int uspRegisterPersonalTrade(
          int? keyType,
          int? mainKey,
          int? subKey,
          long? count,
          int? chooseKey,
          int? metarialMainKey,
          long? metarialCount,
          int? fromNationCode,
          int? fromServerNo,
          long? fromUserNo,
          int? toNationCode,
          int? toServerNo,
          string toUserNickname,
          int? maxSellCount,
          ObjectParameter toUserNo,
          ObjectParameter marketNo,
          ObjectParameter pricePerOne,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspRegisterPersonalTrade), new ObjectParameter[19]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        chooseKey.HasValue ? new ObjectParameter(nameof (chooseKey), (object) chooseKey) : new ObjectParameter(nameof (chooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        metarialCount.HasValue ? new ObjectParameter(nameof (metarialCount), (object) metarialCount) : new ObjectParameter(nameof (metarialCount), typeof (long)),
        fromNationCode.HasValue ? new ObjectParameter(nameof (fromNationCode), (object) fromNationCode) : new ObjectParameter(nameof (fromNationCode), typeof (int)),
        fromServerNo.HasValue ? new ObjectParameter(nameof (fromServerNo), (object) fromServerNo) : new ObjectParameter(nameof (fromServerNo), typeof (int)),
        fromUserNo.HasValue ? new ObjectParameter(nameof (fromUserNo), (object) fromUserNo) : new ObjectParameter(nameof (fromUserNo), typeof (long)),
        toNationCode.HasValue ? new ObjectParameter(nameof (toNationCode), (object) toNationCode) : new ObjectParameter(nameof (toNationCode), typeof (int)),
        toServerNo.HasValue ? new ObjectParameter(nameof (toServerNo), (object) toServerNo) : new ObjectParameter(nameof (toServerNo), typeof (int)),
        toUserNickname != null ? new ObjectParameter(nameof (toUserNickname), (object) toUserNickname) : new ObjectParameter(nameof (toUserNickname), typeof (string)),
        maxSellCount.HasValue ? new ObjectParameter(nameof (maxSellCount), (object) maxSellCount) : new ObjectParameter(nameof (maxSellCount), typeof (int)),
        toUserNo,
        marketNo,
        pricePerOne,
        symNo,
        rv
            });
        }

        public virtual int uspIsBlockUser__XXX(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspIsBlockUser__XXX), new ObjectParameter[4]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo
            });
        }

        public virtual int uspRemoveBlockUser(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspRemoveBlockUser), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspUpdateMyWalletWeight(
          int? nationCode,
          int? serverNo,
          long? userNo,
          long? calculateWeight,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateMyWalletWeight), new ObjectParameter[6]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        calculateWeight.HasValue ? new ObjectParameter(nameof (calculateWeight), (object) calculateWeight) : new ObjectParameter(nameof (calculateWeight), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspBuyBiddingFromWorldMarketBySystem(
          int? buyKeyType,
          int? buyMainKey,
          int? buySubKey,
          long? buyCount,
          int? buyChooseKey,
          int? metarialMainKey,
          long? buyerMetarialCount,
          double? biddingRate,
          ObjectParameter realBuyCount,
          ObjectParameter totalMoneyCount,
          ObjectParameter sellNo,
          ObjectParameter stopType,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspBuyBiddingFromWorldMarketBySystem), new ObjectParameter[14]
            {
        buyKeyType.HasValue ? new ObjectParameter(nameof (buyKeyType), (object) buyKeyType) : new ObjectParameter(nameof (buyKeyType), typeof (int)),
        buyMainKey.HasValue ? new ObjectParameter(nameof (buyMainKey), (object) buyMainKey) : new ObjectParameter(nameof (buyMainKey), typeof (int)),
        buySubKey.HasValue ? new ObjectParameter(nameof (buySubKey), (object) buySubKey) : new ObjectParameter(nameof (buySubKey), typeof (int)),
        buyCount.HasValue ? new ObjectParameter(nameof (buyCount), (object) buyCount) : new ObjectParameter(nameof (buyCount), typeof (long)),
        buyChooseKey.HasValue ? new ObjectParameter(nameof (buyChooseKey), (object) buyChooseKey) : new ObjectParameter(nameof (buyChooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        buyerMetarialCount.HasValue ? new ObjectParameter(nameof (buyerMetarialCount), (object) buyerMetarialCount) : new ObjectParameter(nameof (buyerMetarialCount), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter("BiddingRate", (object) biddingRate) : new ObjectParameter("BiddingRate", typeof (double)),
        realBuyCount,
        totalMoneyCount,
        sellNo,
        stopType,
        symNo,
        rv
            });
        }

        public virtual int uspBuyFromWorldMarketBySystem(
          int? buyKeyType,
          int? buyMainKey,
          int? buySubKey,
          long? buyCount,
          int? buyChooseKey,
          int? metarialMainKey,
          long? needMetarialCount,
          double? biddingRate,
          ObjectParameter realBuyCount,
          ObjectParameter totalMoneyCount,
          ObjectParameter buyNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspBuyFromWorldMarketBySystem), new ObjectParameter[13]
            {
        buyKeyType.HasValue ? new ObjectParameter(nameof (buyKeyType), (object) buyKeyType) : new ObjectParameter(nameof (buyKeyType), typeof (int)),
        buyMainKey.HasValue ? new ObjectParameter(nameof (buyMainKey), (object) buyMainKey) : new ObjectParameter(nameof (buyMainKey), typeof (int)),
        buySubKey.HasValue ? new ObjectParameter(nameof (buySubKey), (object) buySubKey) : new ObjectParameter(nameof (buySubKey), typeof (int)),
        buyCount.HasValue ? new ObjectParameter(nameof (buyCount), (object) buyCount) : new ObjectParameter(nameof (buyCount), typeof (long)),
        buyChooseKey.HasValue ? new ObjectParameter(nameof (buyChooseKey), (object) buyChooseKey) : new ObjectParameter(nameof (buyChooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        needMetarialCount.HasValue ? new ObjectParameter(nameof (needMetarialCount), (object) needMetarialCount) : new ObjectParameter(nameof (needMetarialCount), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter("BiddingRate", (object) biddingRate) : new ObjectParameter("BiddingRate", typeof (double)),
        realBuyCount,
        totalMoneyCount,
        buyNo,
        symNo,
        rv
            });
        }

        public virtual int uspUpdateMarketState(
          bool? isOpen,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateMarketState), new ObjectParameter[3]
            {
        isOpen.HasValue ? new ObjectParameter(nameof (isOpen), (object) isOpen) : new ObjectParameter(nameof (isOpen), typeof (bool)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketByMainGroup_Result> uspListWorldMarketByMainGroup(
          int? mainGroupNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketByMainGroup_Result>(nameof(uspListWorldMarketByMainGroup), new ObjectParameter[3]
            {
        mainGroupNo.HasValue ? new ObjectParameter(nameof (mainGroupNo), (object) mainGroupNo) : new ObjectParameter(nameof (mainGroupNo), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual int uspPrepareWithdrawFromWorldMarket(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          long? count,
          long? itemWeight,
          ObjectParameter payload,
          ObjectParameter param0,
          ObjectParameter param1,
          ObjectParameter param2,
          ObjectParameter param3,
          ObjectParameter param4,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspPrepareWithdrawFromWorldMarket), new ObjectParameter[17]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        itemWeight.HasValue ? new ObjectParameter(nameof (itemWeight), (object) itemWeight) : new ObjectParameter(nameof (itemWeight), typeof (long)),
        payload,
        param0,
        param1,
        param2,
        param3,
        param4,
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketMyWallet_Result> uspListWorldMarketMyWallet(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketMyWallet_Result>(nameof(uspListWorldMarketMyWallet), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspWorldMarketMyWallet(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          ObjectParameter count,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspWorldMarketMyWallet), new ObjectParameter[10]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        count,
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspGetShutDownInfo_Result> uspGetShutDownInfo(
          int? groupContentNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetShutDownInfo_Result>(nameof(uspGetShutDownInfo), new ObjectParameter[1]
            {
        groupContentNo.HasValue ? new ObjectParameter(nameof (groupContentNo), (object) groupContentNo) : new ObjectParameter(nameof (groupContentNo), typeof (int))
            });
        }

        public virtual ObjectResult<uspListNoticeItem_Result> uspListNoticeItem(
          long? checkDateTimeStamp,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListNoticeItem_Result>(nameof(uspListNoticeItem), new ObjectParameter[3]
            {
        checkDateTimeStamp.HasValue ? new ObjectParameter(nameof (checkDateTimeStamp), (object) checkDateTimeStamp) : new ObjectParameter(nameof (checkDateTimeStamp), typeof (long)),
        rv,
        symNo
            });
        }

        public virtual int uspUpdateWorldMarketPassCount(
          int? keyType,
          int? mainKey,
          int? subKey,
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateWorldMarketPassCount), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListBiddingInfo_Result> uspListBiddingInfo(
          int? keyType,
          int? mainKey,
          int? subKey,
          int? metarialMainKey,
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListBiddingInfo_Result>(nameof(uspListBiddingInfo), new ObjectParameter[7]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual int uspIsMarketOpen__XXX(ObjectParameter symNo) => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspIsMarketOpen__XXX), new ObjectParameter[1]
        {
      symNo
        });

        public virtual ObjectResult<uspGetMarketPriceInfo_Result> uspGetMarketPriceInfo(
          int? keyType,
          int? mainKey,
          int? subKey,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetMarketPriceInfo_Result>(nameof(uspGetMarketPriceInfo), new ObjectParameter[4]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        symNo
            });
        }

        public virtual int uspPayloadRestoration(
          long? payload,
          short? state,
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          long? count,
          bool? isSealed,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          ObjectParameter isNot,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspPayloadRestoration), new ObjectParameter[18]
            {
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        state.HasValue ? new ObjectParameter(nameof (state), (object) state) : new ObjectParameter(nameof (state), typeof (short)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        isNot,
        rv,
        symNo
            });
        }

        public virtual ObjectResult<uspListWorldMarketCurrentPrice_Result> uspListWorldMarketCurrentPrice(
          int? mainCategory,
          int? subCategory,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketCurrentPrice_Result>(nameof(uspListWorldMarketCurrentPrice), new ObjectParameter[4]
            {
        mainCategory.HasValue ? new ObjectParameter(nameof (mainCategory), (object) mainCategory) : new ObjectParameter(nameof (mainCategory), typeof (int)),
        subCategory.HasValue ? new ObjectParameter(nameof (subCategory), (object) subCategory) : new ObjectParameter(nameof (subCategory), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspGetLogWriteEnable_Result> uspGetLogWriteEnable() => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetLogWriteEnable_Result>(nameof(uspGetLogWriteEnable), new ObjectParameter[0]);

        public virtual int uspAddTrade(
          int? keyType,
          int? mainKey,
          long? subKey,
          long? price,
          long? count,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspAddTrade), new ObjectParameter[7]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (long)),
        price.HasValue ? new ObjectParameter(nameof (price), (object) price) : new ObjectParameter(nameof (price), typeof (long)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListBiddingPrice_Result> uspListBiddingPrice(
          int? keyType,
          int? mainKey,
          int? subKey,
          int? maxGroupKey,
          double? biddingRate,
          long? pricePerOne,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListBiddingPrice_Result>(nameof(uspListBiddingPrice), new ObjectParameter[8]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        maxGroupKey.HasValue ? new ObjectParameter(nameof (maxGroupKey), (object) maxGroupKey) : new ObjectParameter(nameof (maxGroupKey), typeof (int)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        pricePerOne.HasValue ? new ObjectParameter(nameof (pricePerOne), (object) pricePerOne) : new ObjectParameter(nameof (pricePerOne), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspCheckAndUpdateBlackUser(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter blocked,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCheckAndUpdateBlackUser), new ObjectParameter[6]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        blocked,
        symNo,
        rv
            });
        }

        public virtual int uspSetMaxPrice(
          int? keyType,
          int? mainKey,
          long? subKey,
          bool? isMax,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetMaxPrice), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (long)),
        isMax.HasValue ? new ObjectParameter(nameof (isMax), (object) isMax) : new ObjectParameter(nameof (isMax), typeof (bool)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListTickCount_Result> uspListTickCount(
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListTickCount_Result>(nameof(uspListTickCount), new ObjectParameter[2]
            {
        symNo,
        rv
            });
        }

        public virtual int uspGetWithDrawPayLoadState(
          long? userNo,
          int? nationCode,
          int? serverNo,
          long? payload,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          long? count,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          ObjectParameter state,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetWithDrawPayLoadState), new ObjectParameter[16]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        state,
        symNo,
        rv
            });
        }

        public virtual int uspWorldMarketDetailOne(
          int? mainKey,
          int? subKey,
          ObjectParameter pricePerOne,
          ObjectParameter count,
          ObjectParameter minPrice,
          ObjectParameter maxPrice,
          ObjectParameter totalTradeCount,
          ObjectParameter lastTradePrice,
          ObjectParameter lastTradeTime,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspWorldMarketDetailOne), new ObjectParameter[11]
            {
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        pricePerOne,
        count,
        minPrice,
        maxPrice,
        totalTradeCount,
        lastTradePrice,
        lastTradeTime,
        symNo,
        rv
            });
        }

        public virtual int uspSetContentsInsUseWeb(
          int? groupContentNo,
          DateTime? contentStartDate,
          DateTime? contentEndDate,
          byte? isDisplay,
          byte? isDelete,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetContentsInsUseWeb), new ObjectParameter[6]
            {
        groupContentNo.HasValue ? new ObjectParameter(nameof (groupContentNo), (object) groupContentNo) : new ObjectParameter(nameof (groupContentNo), typeof (int)),
        contentStartDate.HasValue ? new ObjectParameter(nameof (contentStartDate), (object) contentStartDate) : new ObjectParameter(nameof (contentStartDate), typeof (DateTime)),
        contentEndDate.HasValue ? new ObjectParameter(nameof (contentEndDate), (object) contentEndDate) : new ObjectParameter(nameof (contentEndDate), typeof (DateTime)),
        isDisplay.HasValue ? new ObjectParameter(nameof (isDisplay), (object) isDisplay) : new ObjectParameter(nameof (isDisplay), typeof (byte)),
        isDelete.HasValue ? new ObjectParameter(nameof (isDelete), (object) isDelete) : new ObjectParameter(nameof (isDelete), typeof (byte)),
        resultCode
            });
        }

        public virtual int uspSetContentsUpdUseWeb(
          int? groupContentNo,
          DateTime? contentStartDate,
          DateTime? contentEndDate,
          byte? isDisplay,
          byte? isDelete,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetContentsUpdUseWeb), new ObjectParameter[6]
            {
        groupContentNo.HasValue ? new ObjectParameter(nameof (groupContentNo), (object) groupContentNo) : new ObjectParameter(nameof (groupContentNo), typeof (int)),
        contentStartDate.HasValue ? new ObjectParameter(nameof (contentStartDate), (object) contentStartDate) : new ObjectParameter(nameof (contentStartDate), typeof (DateTime)),
        contentEndDate.HasValue ? new ObjectParameter(nameof (contentEndDate), (object) contentEndDate) : new ObjectParameter(nameof (contentEndDate), typeof (DateTime)),
        isDisplay.HasValue ? new ObjectParameter(nameof (isDisplay), (object) isDisplay) : new ObjectParameter(nameof (isDisplay), typeof (byte)),
        isDelete.HasValue ? new ObjectParameter(nameof (isDelete), (object) isDelete) : new ObjectParameter(nameof (isDelete), typeof (byte)),
        resultCode
            });
        }

        public virtual int uspSetShutDownInfoInsUseWeb(
          int? groupContentsNo,
          string cultureCode,
          string mainMessage,
          string subMessage,
          string redirectUrl,
          string memo,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetShutDownInfoInsUseWeb), new ObjectParameter[7]
            {
        groupContentsNo.HasValue ? new ObjectParameter(nameof (groupContentsNo), (object) groupContentsNo) : new ObjectParameter(nameof (groupContentsNo), typeof (int)),
        cultureCode != null ? new ObjectParameter(nameof (cultureCode), (object) cultureCode) : new ObjectParameter(nameof (cultureCode), typeof (string)),
        mainMessage != null ? new ObjectParameter(nameof (mainMessage), (object) mainMessage) : new ObjectParameter(nameof (mainMessage), typeof (string)),
        subMessage != null ? new ObjectParameter(nameof (subMessage), (object) subMessage) : new ObjectParameter(nameof (subMessage), typeof (string)),
        redirectUrl != null ? new ObjectParameter(nameof (redirectUrl), (object) redirectUrl) : new ObjectParameter(nameof (redirectUrl), typeof (string)),
        memo != null ? new ObjectParameter(nameof (memo), (object) memo) : new ObjectParameter(nameof (memo), typeof (string)),
        resultCode
            });
        }

        public virtual int uspSetShutDownInfoUpdUseWeb(
          int? groupContentsNo,
          string cultureCode,
          string mainMessage,
          string subMessage,
          string redirectUrl,
          string memo,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetShutDownInfoUpdUseWeb), new ObjectParameter[7]
            {
        groupContentsNo.HasValue ? new ObjectParameter(nameof (groupContentsNo), (object) groupContentsNo) : new ObjectParameter(nameof (groupContentsNo), typeof (int)),
        cultureCode != null ? new ObjectParameter(nameof (cultureCode), (object) cultureCode) : new ObjectParameter(nameof (cultureCode), typeof (string)),
        mainMessage != null ? new ObjectParameter(nameof (mainMessage), (object) mainMessage) : new ObjectParameter(nameof (mainMessage), typeof (string)),
        subMessage != null ? new ObjectParameter(nameof (subMessage), (object) subMessage) : new ObjectParameter(nameof (subMessage), typeof (string)),
        redirectUrl != null ? new ObjectParameter(nameof (redirectUrl), (object) redirectUrl) : new ObjectParameter(nameof (redirectUrl), typeof (string)),
        memo != null ? new ObjectParameter(nameof (memo), (object) memo) : new ObjectParameter(nameof (memo), typeof (string)),
        resultCode
            });
        }

        public virtual ObjectResult<uspGetShutDownCheckUseWeb_Result> uspGetShutDownCheckUseWeb(
          string cultureCode,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetShutDownCheckUseWeb_Result>(nameof(uspGetShutDownCheckUseWeb), new ObjectParameter[2]
            {
        cultureCode != null ? new ObjectParameter(nameof (cultureCode), (object) cultureCode) : new ObjectParameter(nameof (cultureCode), typeof (string)),
        resultCode
            });
        }

        public virtual int uspGetAddTaxDiscountRate(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter addTaxDiscountRate,
          ObjectParameter familySkillAddTaxDiscountRate)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetAddTaxDiscountRate), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        addTaxDiscountRate,
        familySkillAddTaxDiscountRate
            });
        }

        public virtual int uspGetSecondPwdInfo(
          int? serverNo,
          long? userNo,
          bool? failFlag,
          ObjectParameter failCount)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetSecondPwdInfo), new ObjectParameter[4]
            {
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        failFlag.HasValue ? new ObjectParameter(nameof (failFlag), (object) failFlag) : new ObjectParameter(nameof (failFlag), typeof (bool)),
        failCount
            });
        }

        public virtual ObjectResult<bool?> uspGetAppPushEnable() => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<bool?>(nameof(uspGetAppPushEnable), new ObjectParameter[0]);

        public virtual int uspGetMyWalletInfo(
          string userId,
          ObjectParameter userNo,
          ObjectParameter userNickName,
          ObjectParameter serviceType,
          ObjectParameter worldNo,
          ObjectParameter valuepackage,
          ObjectParameter addWeightBuff,
          ObjectParameter resultCode,
          ObjectParameter resultMsg)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetMyWalletInfo), new ObjectParameter[9]
            {
        userId != null ? new ObjectParameter(nameof (userId), (object) userId) : new ObjectParameter(nameof (userId), typeof (string)),
        userNo,
        userNickName,
        serviceType,
        worldNo,
        valuepackage,
        addWeightBuff,
        resultCode,
        resultMsg
            });
        }

        public virtual int uspPrepareDepositToWorldMarket(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          long? count,
          bool? isSealed,
          long? itemWeight,
          long? maxWeight,
          ObjectParameter payload,
          ObjectParameter isNotError,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspPrepareDepositToWorldMarket), new ObjectParameter[19]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        itemWeight.HasValue ? new ObjectParameter(nameof (itemWeight), (object) itemWeight) : new ObjectParameter(nameof (itemWeight), typeof (long)),
        maxWeight.HasValue ? new ObjectParameter(nameof (maxWeight), (object) maxWeight) : new ObjectParameter(nameof (maxWeight), typeof (long)),
        payload,
        isNotError,
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketDetailByCategory_Result> uspListWorldMarketDetailByCategory(
          int? mainCategory,
          int? subCategory,
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketDetailByCategory_Result>(nameof(uspListWorldMarketDetailByCategory), new ObjectParameter[5]
            {
        mainCategory.HasValue ? new ObjectParameter(nameof (mainCategory), (object) mainCategory) : new ObjectParameter(nameof (mainCategory), typeof (int)),
        subCategory.HasValue ? new ObjectParameter(nameof (subCategory), (object) subCategory) : new ObjectParameter(nameof (subCategory), typeof (int)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketHot_Result> uspListWorldMarketHot(
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketHot_Result>(nameof(uspListWorldMarketHot), new ObjectParameter[3]
            {
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspSearchListWorldMarket_Result> uspSearchListWorldMarket(
          string searchResultString,
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspSearchListWorldMarket_Result>(nameof(uspSearchListWorldMarket), new ObjectParameter[4]
            {
        searchResultString != null ? new ObjectParameter(nameof (searchResultString), (object) searchResultString) : new ObjectParameter(nameof (searchResultString), typeof (string)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual int uspGetItemPrice(
          int? keyType,
          int? mainKey,
          int? subKey,
          ObjectParameter pricePerOne,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetItemPrice), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        pricePerOne,
        symNo,
        rv
            });
        }

        public virtual int uspCreateMyWallet(
          string userId,
          int? nationCode,
          int? serverNo,
          long? userNo,
          string userNickname,
          DateTime? packageExpiration,
          DateTime? addWeightBuffExpiration,
          int? addPearlItemLimitedCount,
          int? maidCount,
          bool? isGameMaster,
          double? addTaxDiscountRate,
          int? familySkillAddTaxDiscountRate,
          int? inceaseWeight,
          int? inceaseWeightByBuff,
          int? ringCount,
          ObjectParameter isCreateWallet,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCreateMyWallet), new ObjectParameter[18]
            {
        userId != null ? new ObjectParameter(nameof (userId), (object) userId) : new ObjectParameter(nameof (userId), typeof (string)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        userNickname != null ? new ObjectParameter(nameof (userNickname), (object) userNickname) : new ObjectParameter(nameof (userNickname), typeof (string)),
        packageExpiration.HasValue ? new ObjectParameter(nameof (packageExpiration), (object) packageExpiration) : new ObjectParameter(nameof (packageExpiration), typeof (DateTime)),
        addWeightBuffExpiration.HasValue ? new ObjectParameter(nameof (addWeightBuffExpiration), (object) addWeightBuffExpiration) : new ObjectParameter(nameof (addWeightBuffExpiration), typeof (DateTime)),
        addPearlItemLimitedCount.HasValue ? new ObjectParameter(nameof (addPearlItemLimitedCount), (object) addPearlItemLimitedCount) : new ObjectParameter(nameof (addPearlItemLimitedCount), typeof (int)),
        maidCount.HasValue ? new ObjectParameter(nameof (maidCount), (object) maidCount) : new ObjectParameter(nameof (maidCount), typeof (int)),
        isGameMaster.HasValue ? new ObjectParameter(nameof (isGameMaster), (object) isGameMaster) : new ObjectParameter(nameof (isGameMaster), typeof (bool)),
        addTaxDiscountRate.HasValue ? new ObjectParameter(nameof (addTaxDiscountRate), (object) addTaxDiscountRate) : new ObjectParameter(nameof (addTaxDiscountRate), typeof (double)),
        familySkillAddTaxDiscountRate.HasValue ? new ObjectParameter(nameof (familySkillAddTaxDiscountRate), (object) familySkillAddTaxDiscountRate) : new ObjectParameter(nameof (familySkillAddTaxDiscountRate), typeof (int)),
        inceaseWeight.HasValue ? new ObjectParameter(nameof (inceaseWeight), (object) inceaseWeight) : new ObjectParameter(nameof (inceaseWeight), typeof (int)),
        inceaseWeightByBuff.HasValue ? new ObjectParameter(nameof (inceaseWeightByBuff), (object) inceaseWeightByBuff) : new ObjectParameter(nameof (inceaseWeightByBuff), typeof (int)),
        ringCount.HasValue ? new ObjectParameter(nameof (ringCount), (object) ringCount) : new ObjectParameter(nameof (ringCount), typeof (int)),
        isCreateWallet,
        symNo,
        rv
            });
        }

        public virtual int uspUpdateRingBuffRate(
          int? ringRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateRingBuffRate), new ObjectParameter[3]
            {
        ringRate.HasValue ? new ObjectParameter(nameof (ringRate), (object) ringRate) : new ObjectParameter(nameof (ringRate), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual int uspGetPearlItemLimitedCount(
          long? userNo,
          int? serverNo,
          int? nationCode,
          ObjectParameter addPearlItemLimitedCount,
          ObjectParameter currentPearlItemLimitedCount,
          ObjectParameter addWeight,
          ObjectParameter ringBuffCount)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetPearlItemLimitedCount), new ObjectParameter[7]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        addPearlItemLimitedCount,
        currentPearlItemLimitedCount,
        addWeight,
        ringBuffCount
            });
        }

        public virtual ObjectResult<uspListUserBiddingSell_Result> uspListUserBiddingSell(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListUserBiddingSell_Result>(nameof(uspListUserBiddingSell), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspGetServantNo(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          ObjectParameter servantNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetServantNo), new ObjectParameter[9]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        servantNo,
        symNo,
        rv
            });
        }

        public virtual int uspInsertBlockUser(
          int? nationCode,
          int? serverNo,
          long? userNo,
          DateTime? dueDate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspInsertBlockUser), new ObjectParameter[6]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        dueDate.HasValue ? new ObjectParameter(nameof (dueDate), (object) dueDate) : new ObjectParameter(nameof (dueDate), typeof (DateTime)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarket_Result> uspListWorldMarket(
          int? keyType,
          int? mainCategory,
          int? subCategory,
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarket_Result>(nameof(uspListWorldMarket), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainCategory.HasValue ? new ObjectParameter(nameof (mainCategory), (object) mainCategory) : new ObjectParameter(nameof (mainCategory), typeof (int)),
        subCategory.HasValue ? new ObjectParameter(nameof (subCategory), (object) subCategory) : new ObjectParameter(nameof (subCategory), typeof (int)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketDetail_Result> uspListWorldMarketDetail(
          int? keyType,
          int? mainKey,
          bool? isUseTotalTradeCount,
          double? biddingRate,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketDetail_Result>(nameof(uspListWorldMarketDetail), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        isUseTotalTradeCount.HasValue ? new ObjectParameter(nameof (isUseTotalTradeCount), (object) isUseTotalTradeCount) : new ObjectParameter(nameof (isUseTotalTradeCount), typeof (bool)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        symNo,
        rv
            });
        }

        public virtual int uspUpdateItemInfo(
          int? keyType,
          int? mainKey,
          int? subKey,
          int? mainGroupNo,
          int? subGroupNo,
          long? baseCount,
          long? minCount,
          long? maxCount,
          long? basePrice,
          long? maxPrice,
          long? minPrice,
          long? realMaxPrice,
          long? realMinPrice,
          long? marketPriceGroupKey,
          bool? isDisplay,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateItemInfo), new ObjectParameter[17]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        mainGroupNo.HasValue ? new ObjectParameter(nameof (mainGroupNo), (object) mainGroupNo) : new ObjectParameter(nameof (mainGroupNo), typeof (int)),
        subGroupNo.HasValue ? new ObjectParameter(nameof (subGroupNo), (object) subGroupNo) : new ObjectParameter(nameof (subGroupNo), typeof (int)),
        baseCount.HasValue ? new ObjectParameter(nameof (baseCount), (object) baseCount) : new ObjectParameter(nameof (baseCount), typeof (long)),
        minCount.HasValue ? new ObjectParameter(nameof (minCount), (object) minCount) : new ObjectParameter(nameof (minCount), typeof (long)),
        maxCount.HasValue ? new ObjectParameter(nameof (maxCount), (object) maxCount) : new ObjectParameter(nameof (maxCount), typeof (long)),
        basePrice.HasValue ? new ObjectParameter(nameof (basePrice), (object) basePrice) : new ObjectParameter(nameof (basePrice), typeof (long)),
        maxPrice.HasValue ? new ObjectParameter(nameof (maxPrice), (object) maxPrice) : new ObjectParameter(nameof (maxPrice), typeof (long)),
        minPrice.HasValue ? new ObjectParameter(nameof (minPrice), (object) minPrice) : new ObjectParameter(nameof (minPrice), typeof (long)),
        realMaxPrice.HasValue ? new ObjectParameter(nameof (realMaxPrice), (object) realMaxPrice) : new ObjectParameter(nameof (realMaxPrice), typeof (long)),
        realMinPrice.HasValue ? new ObjectParameter(nameof (realMinPrice), (object) realMinPrice) : new ObjectParameter(nameof (realMinPrice), typeof (long)),
        marketPriceGroupKey.HasValue ? new ObjectParameter(nameof (marketPriceGroupKey), (object) marketPriceGroupKey) : new ObjectParameter(nameof (marketPriceGroupKey), typeof (long)),
        isDisplay.HasValue ? new ObjectParameter(nameof (isDisplay), (object) isDisplay) : new ObjectParameter(nameof (isDisplay), typeof (bool)),
        symNo,
        rv
            });
        }

        public virtual int uspUpdateWorldMarketPrice(
          int? keyType,
          int? mainKey,
          int? subKey,
          long? newPrice,
          long? newGraphPrice,
          byte? fluctuationType,
          long? fluctuationPrice,
          long? newStockCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateWorldMarketPrice), new ObjectParameter[10]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        newPrice.HasValue ? new ObjectParameter(nameof (newPrice), (object) newPrice) : new ObjectParameter(nameof (newPrice), typeof (long)),
        newGraphPrice.HasValue ? new ObjectParameter(nameof (newGraphPrice), (object) newGraphPrice) : new ObjectParameter(nameof (newGraphPrice), typeof (long)),
        fluctuationType.HasValue ? new ObjectParameter(nameof (fluctuationType), (object) fluctuationType) : new ObjectParameter(nameof (fluctuationType), typeof (byte)),
        fluctuationPrice.HasValue ? new ObjectParameter(nameof (fluctuationPrice), (object) fluctuationPrice) : new ObjectParameter(nameof (fluctuationPrice), typeof (long)),
        newStockCount.HasValue ? new ObjectParameter(nameof (newStockCount), (object) newStockCount) : new ObjectParameter(nameof (newStockCount), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketAccumulateTrade_Result> uspListWorldMarketAccumulateTrade(
          int? mainGroupNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketAccumulateTrade_Result>(nameof(uspListWorldMarketAccumulateTrade), new ObjectParameter[3]
            {
        mainGroupNo.HasValue ? new ObjectParameter(nameof (mainGroupNo), (object) mainGroupNo) : new ObjectParameter(nameof (mainGroupNo), typeof (int)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListGroupBiddingPrice_Result> uspListGroupBiddingPrice(
          long? priceGroupKey,
          double? biddingRate,
          long? pricePerOne,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListGroupBiddingPrice_Result>(nameof(uspListGroupBiddingPrice), new ObjectParameter[5]
            {
        priceGroupKey.HasValue ? new ObjectParameter(nameof (priceGroupKey), (object) priceGroupKey) : new ObjectParameter(nameof (priceGroupKey), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter(nameof (biddingRate), (object) biddingRate) : new ObjectParameter(nameof (biddingRate), typeof (double)),
        pricePerOne.HasValue ? new ObjectParameter(nameof (pricePerOne), (object) pricePerOne) : new ObjectParameter(nameof (pricePerOne), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspUpdateWorldMarketGroupPrice(
          long? priceGroupKey,
          long? newPrice,
          long? newGraphPrice,
          byte? fluctuationType,
          long? fluctuationPrice,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateWorldMarketGroupPrice), new ObjectParameter[7]
            {
        priceGroupKey.HasValue ? new ObjectParameter(nameof (priceGroupKey), (object) priceGroupKey) : new ObjectParameter(nameof (priceGroupKey), typeof (long)),
        newPrice.HasValue ? new ObjectParameter(nameof (newPrice), (object) newPrice) : new ObjectParameter(nameof (newPrice), typeof (long)),
        newGraphPrice.HasValue ? new ObjectParameter(nameof (newGraphPrice), (object) newGraphPrice) : new ObjectParameter(nameof (newGraphPrice), typeof (long)),
        fluctuationType.HasValue ? new ObjectParameter(nameof (fluctuationType), (object) fluctuationType) : new ObjectParameter(nameof (fluctuationType), typeof (byte)),
        fluctuationPrice.HasValue ? new ObjectParameter(nameof (fluctuationPrice), (object) fluctuationPrice) : new ObjectParameter(nameof (fluctuationPrice), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWaitBiddingSell_Result> uspListWaitBiddingSell(
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWaitBiddingSell_Result>(nameof(uspListWaitBiddingSell), new ObjectParameter[2]
            {
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspWorldMarketWaitNoticeList_Result> uspWorldMarketWaitNoticeList(
          int? nationCode,
          int? serverNo,
          long? userNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspWorldMarketWaitNoticeList_Result>(nameof(uspWorldMarketWaitNoticeList), new ObjectParameter[3]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long))
            });
        }

        public virtual int uspIncreaseTickCount(
          int? mainGroupNo,
          ObjectParameter isUpdatePrice,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspIncreaseTickCount), new ObjectParameter[4]
            {
        mainGroupNo.HasValue ? new ObjectParameter(nameof (mainGroupNo), (object) mainGroupNo) : new ObjectParameter(nameof (mainGroupNo), typeof (int)),
        isUpdatePrice,
        symNo,
        rv
            });
        }

        public virtual int uspClearNoticeItemList(ObjectParameter symNo, ObjectParameter rv) => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspClearNoticeItemList), new ObjectParameter[2]
        {
      symNo,
      rv
        });

        public virtual int uspCheckOTPItem(
          int? keyType,
          int? mainKey,
          int? subKey,
          ObjectParameter isOTPItem,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCheckOTPItem), new ObjectParameter[6]
            {
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isOTPItem,
        symNo,
        rv
            });
        }

        public virtual int uspBuyBiddingFromWorldMarket(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? buyKeyType,
          int? buyMainKey,
          int? buySubKey,
          long? buyPrice,
          long? buyCount,
          int? buyChooseKey,
          int? metarialMainKey,
          long? buyerMetarialCount,
          double? biddingRate,
          long? weightPerOne,
          long? maxWeight,
          long? retryBiddingNo,
          ObjectParameter walletMoney,
          ObjectParameter realBuyCount,
          ObjectParameter totalMoneyCount,
          ObjectParameter sellNo,
          ObjectParameter sellUserNo,
          ObjectParameter sellUserId,
          ObjectParameter sellLeftCount,
          ObjectParameter raceCount,
          ObjectParameter stopType,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter beforeCount2,
          ObjectParameter afterCount2,
          ObjectParameter beforeCount3,
          ObjectParameter afterCount3,
          ObjectParameter beforeCount4,
          ObjectParameter afterCount4,
          ObjectParameter leftCount,
          ObjectParameter registerMoneyCount,
          ObjectParameter boughtCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspBuyBiddingFromWorldMarket), new ObjectParameter[37]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        buyKeyType.HasValue ? new ObjectParameter(nameof (buyKeyType), (object) buyKeyType) : new ObjectParameter(nameof (buyKeyType), typeof (int)),
        buyMainKey.HasValue ? new ObjectParameter(nameof (buyMainKey), (object) buyMainKey) : new ObjectParameter(nameof (buyMainKey), typeof (int)),
        buySubKey.HasValue ? new ObjectParameter(nameof (buySubKey), (object) buySubKey) : new ObjectParameter(nameof (buySubKey), typeof (int)),
        buyPrice.HasValue ? new ObjectParameter(nameof (buyPrice), (object) buyPrice) : new ObjectParameter(nameof (buyPrice), typeof (long)),
        buyCount.HasValue ? new ObjectParameter(nameof (buyCount), (object) buyCount) : new ObjectParameter(nameof (buyCount), typeof (long)),
        buyChooseKey.HasValue ? new ObjectParameter(nameof (buyChooseKey), (object) buyChooseKey) : new ObjectParameter(nameof (buyChooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        buyerMetarialCount.HasValue ? new ObjectParameter(nameof (buyerMetarialCount), (object) buyerMetarialCount) : new ObjectParameter(nameof (buyerMetarialCount), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter("BiddingRate", (object) biddingRate) : new ObjectParameter("BiddingRate", typeof (double)),
        weightPerOne.HasValue ? new ObjectParameter(nameof (weightPerOne), (object) weightPerOne) : new ObjectParameter(nameof (weightPerOne), typeof (long)),
        maxWeight.HasValue ? new ObjectParameter(nameof (maxWeight), (object) maxWeight) : new ObjectParameter(nameof (maxWeight), typeof (long)),
        retryBiddingNo.HasValue ? new ObjectParameter(nameof (retryBiddingNo), (object) retryBiddingNo) : new ObjectParameter(nameof (retryBiddingNo), typeof (long)),
        walletMoney,
        realBuyCount,
        totalMoneyCount,
        sellNo,
        sellUserNo,
        sellUserId,
        sellLeftCount,
        raceCount,
        stopType,
        beforeCount1,
        afterCount1,
        beforeCount2,
        afterCount2,
        beforeCount3,
        afterCount3,
        beforeCount4,
        afterCount4,
        leftCount,
        registerMoneyCount,
        boughtCount,
        symNo,
        rv
            });
        }

        public virtual int uspSellBiddingToWorldMarket(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? sellKeyType,
          int? sellMainKey,
          int? sellSubKey,
          int? sellMainCategory,
          bool? isSealed,
          long? sellPrice,
          long? sellCount,
          int? sellChooseKey,
          int? metarialMainKey,
          long? needMetarialCount,
          double? biddingRate,
          bool? isNoticeItem,
          long? weightPerOne,
          long? maxWeight,
          long? maxPearlItemLimitedCount,
          DateTime? currentTime,
          byte? applyRingBuffType,
          long? waitNo,
          bool? isRingBuff,
          long? retryBiddingNo,
          ObjectParameter walletMoney,
          ObjectParameter realSellCount,
          ObjectParameter totalMoneyCount,
          ObjectParameter originalTotalMoneyCount,
          ObjectParameter packageExpiration,
          ObjectParameter buyNo,
          ObjectParameter buyUserNo,
          ObjectParameter buyUserId,
          ObjectParameter buyLeftCount,
          ObjectParameter stopType,
          ObjectParameter isNextApplyRingBuff,
          ObjectParameter resultWaitNo,
          ObjectParameter raceCount,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter beforeCount2,
          ObjectParameter afterCount2,
          ObjectParameter beforeCount3,
          ObjectParameter afterCount3,
          ObjectParameter beforeCount4,
          ObjectParameter afterCount4,
          ObjectParameter soldCount,
          ObjectParameter leftCount,
          ObjectParameter moneyCount,
          ObjectParameter calculateMoney,
          ObjectParameter isCalculateRingBuff,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSellBiddingToWorldMarket), new ObjectParameter[51]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        sellKeyType.HasValue ? new ObjectParameter(nameof (sellKeyType), (object) sellKeyType) : new ObjectParameter(nameof (sellKeyType), typeof (int)),
        sellMainKey.HasValue ? new ObjectParameter(nameof (sellMainKey), (object) sellMainKey) : new ObjectParameter(nameof (sellMainKey), typeof (int)),
        sellSubKey.HasValue ? new ObjectParameter(nameof (sellSubKey), (object) sellSubKey) : new ObjectParameter(nameof (sellSubKey), typeof (int)),
        sellMainCategory.HasValue ? new ObjectParameter(nameof (sellMainCategory), (object) sellMainCategory) : new ObjectParameter(nameof (sellMainCategory), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        sellPrice.HasValue ? new ObjectParameter(nameof (sellPrice), (object) sellPrice) : new ObjectParameter(nameof (sellPrice), typeof (long)),
        sellCount.HasValue ? new ObjectParameter(nameof (sellCount), (object) sellCount) : new ObjectParameter(nameof (sellCount), typeof (long)),
        sellChooseKey.HasValue ? new ObjectParameter(nameof (sellChooseKey), (object) sellChooseKey) : new ObjectParameter(nameof (sellChooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        needMetarialCount.HasValue ? new ObjectParameter(nameof (needMetarialCount), (object) needMetarialCount) : new ObjectParameter(nameof (needMetarialCount), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter("BiddingRate", (object) biddingRate) : new ObjectParameter("BiddingRate", typeof (double)),
        isNoticeItem.HasValue ? new ObjectParameter(nameof (isNoticeItem), (object) isNoticeItem) : new ObjectParameter(nameof (isNoticeItem), typeof (bool)),
        weightPerOne.HasValue ? new ObjectParameter(nameof (weightPerOne), (object) weightPerOne) : new ObjectParameter(nameof (weightPerOne), typeof (long)),
        maxWeight.HasValue ? new ObjectParameter(nameof (maxWeight), (object) maxWeight) : new ObjectParameter(nameof (maxWeight), typeof (long)),
        maxPearlItemLimitedCount.HasValue ? new ObjectParameter(nameof (maxPearlItemLimitedCount), (object) maxPearlItemLimitedCount) : new ObjectParameter(nameof (maxPearlItemLimitedCount), typeof (long)),
        currentTime.HasValue ? new ObjectParameter(nameof (currentTime), (object) currentTime) : new ObjectParameter(nameof (currentTime), typeof (DateTime)),
        applyRingBuffType.HasValue ? new ObjectParameter(nameof (applyRingBuffType), (object) applyRingBuffType) : new ObjectParameter(nameof (applyRingBuffType), typeof (byte)),
        waitNo.HasValue ? new ObjectParameter(nameof (waitNo), (object) waitNo) : new ObjectParameter(nameof (waitNo), typeof (long)),
        isRingBuff.HasValue ? new ObjectParameter(nameof (isRingBuff), (object) isRingBuff) : new ObjectParameter(nameof (isRingBuff), typeof (bool)),
        retryBiddingNo.HasValue ? new ObjectParameter(nameof (retryBiddingNo), (object) retryBiddingNo) : new ObjectParameter(nameof (retryBiddingNo), typeof (long)),
        walletMoney,
        realSellCount,
        totalMoneyCount,
        originalTotalMoneyCount,
        packageExpiration,
        buyNo,
        buyUserNo,
        buyUserId,
        buyLeftCount,
        stopType,
        isNextApplyRingBuff,
        resultWaitNo,
        raceCount,
        beforeCount1,
        afterCount1,
        beforeCount2,
        afterCount2,
        beforeCount3,
        afterCount3,
        beforeCount4,
        afterCount4,
        soldCount,
        leftCount,
        moneyCount,
        calculateMoney,
        isCalculateRingBuff,
        symNo,
        rv
            });
        }

        public virtual int uspUpdateWaitFail(
          long? waitNo,
          long? pushWeight,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateWaitFail), new ObjectParameter[6]
            {
        waitNo.HasValue ? new ObjectParameter(nameof (waitNo), (object) waitNo) : new ObjectParameter(nameof (waitNo), typeof (long)),
        pushWeight.HasValue ? new ObjectParameter(nameof (pushWeight), (object) pushWeight) : new ObjectParameter(nameof (pushWeight), typeof (long)),
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual int uspCalculateBiddingBuy(
          long? buyNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          int? nationCode,
          int? serverNo,
          long? userNo,
          long? weightPerOne,
          long? maxWeight,
          ObjectParameter boughtCount,
          ObjectParameter chooseSubKey,
          ObjectParameter isDelete,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCalculateBiddingBuy), new ObjectParameter[16]
            {
        buyNo.HasValue ? new ObjectParameter(nameof (buyNo), (object) buyNo) : new ObjectParameter(nameof (buyNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        weightPerOne.HasValue ? new ObjectParameter(nameof (weightPerOne), (object) weightPerOne) : new ObjectParameter(nameof (weightPerOne), typeof (long)),
        maxWeight.HasValue ? new ObjectParameter(nameof (maxWeight), (object) maxWeight) : new ObjectParameter(nameof (maxWeight), typeof (long)),
        boughtCount,
        chooseSubKey,
        isDelete,
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual int uspWithdrawBiddingBuy(
          long? buyNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          long? count,
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? chooseSubKey,
          ObjectParameter differenceMoney,
          ObjectParameter withdrawMoneyCount,
          ObjectParameter isDelete,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspWithdrawBiddingBuy), new ObjectParameter[16]
            {
        buyNo.HasValue ? new ObjectParameter(nameof (buyNo), (object) buyNo) : new ObjectParameter(nameof (buyNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        chooseSubKey.HasValue ? new ObjectParameter(nameof (chooseSubKey), (object) chooseSubKey) : new ObjectParameter(nameof (chooseSubKey), typeof (int)),
        differenceMoney,
        withdrawMoneyCount,
        isDelete,
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual int uspCalculateBiddingSell(
          long? sellNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          int? mainCategory,
          bool? isSealed,
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? chooseSubKey,
          ObjectParameter soldCount,
          ObjectParameter isDelete,
          ObjectParameter amountMoney,
          ObjectParameter originalTotalMoneyCount,
          ObjectParameter packageExpiration,
          ObjectParameter isAppledRingBuff,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCalculateBiddingSell), new ObjectParameter[20]
            {
        sellNo.HasValue ? new ObjectParameter(nameof (sellNo), (object) sellNo) : new ObjectParameter(nameof (sellNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        mainCategory.HasValue ? new ObjectParameter(nameof (mainCategory), (object) mainCategory) : new ObjectParameter(nameof (mainCategory), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        chooseSubKey.HasValue ? new ObjectParameter(nameof (chooseSubKey), (object) chooseSubKey) : new ObjectParameter(nameof (chooseSubKey), typeof (int)),
        soldCount,
        isDelete,
        amountMoney,
        originalTotalMoneyCount,
        packageExpiration,
        isAppledRingBuff,
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual int uspWithdrawBiddingSell(
          long? sellNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          long? count,
          int? nationCode,
          int? serverNo,
          long? userNo,
          long? weightPerOne,
          long? maxWeight,
          long? maxPearlItemLimitedCount,
          DateTime? currentTime,
          ObjectParameter chooseSubKey,
          ObjectParameter isDelete,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspWithdrawBiddingSell), new ObjectParameter[19]
            {
        sellNo.HasValue ? new ObjectParameter(nameof (sellNo), (object) sellNo) : new ObjectParameter(nameof (sellNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        weightPerOne.HasValue ? new ObjectParameter(nameof (weightPerOne), (object) weightPerOne) : new ObjectParameter(nameof (weightPerOne), typeof (long)),
        maxWeight.HasValue ? new ObjectParameter(nameof (maxWeight), (object) maxWeight) : new ObjectParameter(nameof (maxWeight), typeof (long)),
        maxPearlItemLimitedCount.HasValue ? new ObjectParameter(nameof (maxPearlItemLimitedCount), (object) maxPearlItemLimitedCount) : new ObjectParameter(nameof (maxPearlItemLimitedCount), typeof (long)),
        currentTime.HasValue ? new ObjectParameter(nameof (currentTime), (object) currentTime) : new ObjectParameter(nameof (currentTime), typeof (DateTime)),
        chooseSubKey,
        isDelete,
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual int uspSellToWorldMarket(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? sellKeyType,
          int? sellMainKey,
          int? sellSubKey,
          int? sellMainCategory,
          bool? isSealed,
          long? sellPrice,
          long? sellCount,
          int? sellChooseKey,
          int? metarialMainKey,
          long? needMetarialCount,
          double? biddingRate,
          bool? isNoticeItem,
          long? weightPerOne,
          long? maxPearlItemLimitedCount,
          DateTime? currentTime,
          byte? applyRingBuffType,
          long? waitNo,
          ObjectParameter sellPricePerOne,
          ObjectParameter realSellCount,
          ObjectParameter totalMoneyCount,
          ObjectParameter originalTotalMoneyCount,
          ObjectParameter packageExpiration,
          ObjectParameter sellNo,
          ObjectParameter isAppledRingBuff,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter beforeCount2,
          ObjectParameter afterCount2,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSellToWorldMarket), new ObjectParameter[33]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        sellKeyType.HasValue ? new ObjectParameter(nameof (sellKeyType), (object) sellKeyType) : new ObjectParameter(nameof (sellKeyType), typeof (int)),
        sellMainKey.HasValue ? new ObjectParameter(nameof (sellMainKey), (object) sellMainKey) : new ObjectParameter(nameof (sellMainKey), typeof (int)),
        sellSubKey.HasValue ? new ObjectParameter(nameof (sellSubKey), (object) sellSubKey) : new ObjectParameter(nameof (sellSubKey), typeof (int)),
        sellMainCategory.HasValue ? new ObjectParameter(nameof (sellMainCategory), (object) sellMainCategory) : new ObjectParameter(nameof (sellMainCategory), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        sellPrice.HasValue ? new ObjectParameter(nameof (sellPrice), (object) sellPrice) : new ObjectParameter(nameof (sellPrice), typeof (long)),
        sellCount.HasValue ? new ObjectParameter(nameof (sellCount), (object) sellCount) : new ObjectParameter(nameof (sellCount), typeof (long)),
        sellChooseKey.HasValue ? new ObjectParameter(nameof (sellChooseKey), (object) sellChooseKey) : new ObjectParameter(nameof (sellChooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        needMetarialCount.HasValue ? new ObjectParameter(nameof (needMetarialCount), (object) needMetarialCount) : new ObjectParameter(nameof (needMetarialCount), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter("BiddingRate", (object) biddingRate) : new ObjectParameter("BiddingRate", typeof (double)),
        isNoticeItem.HasValue ? new ObjectParameter(nameof (isNoticeItem), (object) isNoticeItem) : new ObjectParameter(nameof (isNoticeItem), typeof (bool)),
        weightPerOne.HasValue ? new ObjectParameter(nameof (weightPerOne), (object) weightPerOne) : new ObjectParameter(nameof (weightPerOne), typeof (long)),
        maxPearlItemLimitedCount.HasValue ? new ObjectParameter(nameof (maxPearlItemLimitedCount), (object) maxPearlItemLimitedCount) : new ObjectParameter(nameof (maxPearlItemLimitedCount), typeof (long)),
        currentTime.HasValue ? new ObjectParameter(nameof (currentTime), (object) currentTime) : new ObjectParameter(nameof (currentTime), typeof (DateTime)),
        applyRingBuffType.HasValue ? new ObjectParameter(nameof (applyRingBuffType), (object) applyRingBuffType) : new ObjectParameter(nameof (applyRingBuffType), typeof (byte)),
        waitNo.HasValue ? new ObjectParameter(nameof (waitNo), (object) waitNo) : new ObjectParameter(nameof (waitNo), typeof (long)),
        sellPricePerOne,
        realSellCount,
        totalMoneyCount,
        originalTotalMoneyCount,
        packageExpiration,
        sellNo,
        isAppledRingBuff,
        beforeCount1,
        afterCount1,
        beforeCount2,
        afterCount2,
        symNo,
        rv
            });
        }

        public virtual int uspBuyFromWorldMarket(
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? buyKeyType,
          int? buyMainKey,
          int? buySubKey,
          long? buyPrice,
          long? buyCount,
          int? buyChooseKey,
          int? metarialMainKey,
          long? needMetarialCount,
          double? biddingRate,
          bool? isCashCategory,
          long? weightPerOne,
          long? maxWeight,
          ObjectParameter realBuyCount,
          ObjectParameter totalMoneyCount,
          ObjectParameter buyNo,
          ObjectParameter biddingMoneyCount,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter beforeCount2,
          ObjectParameter afterCount2,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspBuyFromWorldMarket), new ObjectParameter[25]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        buyKeyType.HasValue ? new ObjectParameter(nameof (buyKeyType), (object) buyKeyType) : new ObjectParameter(nameof (buyKeyType), typeof (int)),
        buyMainKey.HasValue ? new ObjectParameter(nameof (buyMainKey), (object) buyMainKey) : new ObjectParameter(nameof (buyMainKey), typeof (int)),
        buySubKey.HasValue ? new ObjectParameter(nameof (buySubKey), (object) buySubKey) : new ObjectParameter(nameof (buySubKey), typeof (int)),
        buyPrice.HasValue ? new ObjectParameter(nameof (buyPrice), (object) buyPrice) : new ObjectParameter(nameof (buyPrice), typeof (long)),
        buyCount.HasValue ? new ObjectParameter(nameof (buyCount), (object) buyCount) : new ObjectParameter(nameof (buyCount), typeof (long)),
        buyChooseKey.HasValue ? new ObjectParameter(nameof (buyChooseKey), (object) buyChooseKey) : new ObjectParameter(nameof (buyChooseKey), typeof (int)),
        metarialMainKey.HasValue ? new ObjectParameter(nameof (metarialMainKey), (object) metarialMainKey) : new ObjectParameter(nameof (metarialMainKey), typeof (int)),
        needMetarialCount.HasValue ? new ObjectParameter(nameof (needMetarialCount), (object) needMetarialCount) : new ObjectParameter(nameof (needMetarialCount), typeof (long)),
        biddingRate.HasValue ? new ObjectParameter("BiddingRate", (object) biddingRate) : new ObjectParameter("BiddingRate", typeof (double)),
        isCashCategory.HasValue ? new ObjectParameter(nameof (isCashCategory), (object) isCashCategory) : new ObjectParameter(nameof (isCashCategory), typeof (bool)),
        weightPerOne.HasValue ? new ObjectParameter(nameof (weightPerOne), (object) weightPerOne) : new ObjectParameter(nameof (weightPerOne), typeof (long)),
        maxWeight.HasValue ? new ObjectParameter(nameof (maxWeight), (object) maxWeight) : new ObjectParameter(nameof (maxWeight), typeof (long)),
        realBuyCount,
        totalMoneyCount,
        buyNo,
        biddingMoneyCount,
        beforeCount1,
        afterCount1,
        beforeCount2,
        afterCount2,
        symNo,
        rv
            });
        }

        public virtual int uspProcessDepositToWorldMarket(
          long? payload,
          ObjectParameter reason,
          ObjectParameter keyType,
          ObjectParameter mainKey,
          ObjectParameter subKey,
          ObjectParameter isSealed,
          ObjectParameter param0,
          ObjectParameter param1,
          ObjectParameter param2,
          ObjectParameter param3,
          ObjectParameter param4,
          ObjectParameter count,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspProcessDepositToWorldMarket), new ObjectParameter[16]
            {
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        reason,
        keyType,
        mainKey,
        subKey,
        isSealed,
        param0,
        param1,
        param2,
        param3,
        param4,
        count,
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual int uspProcessWithdrawFromWorldMarket(
          long? payload,
          ObjectParameter reason,
          ObjectParameter beforeCount1,
          ObjectParameter afterCount1,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspProcessWithdrawFromWorldMarket), new ObjectParameter[6]
            {
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        reason,
        beforeCount1,
        afterCount1,
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListUserBiddingBuy_Result> uspListUserBiddingBuy(
          int? nationCode,
          int? serverNo,
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListUserBiddingBuy_Result>(nameof(uspListUserBiddingBuy), new ObjectParameter[5]
            {
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldMarketWait_Result> uspListWorldMarketWait(
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldMarketWait_Result>(nameof(uspListWorldMarketWait), new ObjectParameter[2]
            {
        symNo,
        rv
            });
        }

        public virtual int uspCheckLastOtpTime(
          long? userNo,
          int? worldNo,
          int? nationCode,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCheckLastOtpTime), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        worldNo.HasValue ? new ObjectParameter(nameof (worldNo), (object) worldNo) : new ObjectParameter(nameof (worldNo), typeof (int)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        resultCode
            });
        }

        public virtual int uspGetLastOtpTime(
          long? userNo,
          int? worldNo,
          int? nationCode,
          ObjectParameter lastConfirmOtpTime,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetLastOtpTime), new ObjectParameter[5]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        worldNo.HasValue ? new ObjectParameter(nameof (worldNo), (object) worldNo) : new ObjectParameter(nameof (worldNo), typeof (int)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        lastConfirmOtpTime,
        resultCode
            });
        }

        public virtual int uspSetLastOtpTime(
          long? userNo,
          int? worldNo,
          int? nationCode,
          ObjectParameter resultCode)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetLastOtpTime), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        worldNo.HasValue ? new ObjectParameter(nameof (worldNo), (object) worldNo) : new ObjectParameter(nameof (worldNo), typeof (int)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        resultCode
            });
        }
    }
}
