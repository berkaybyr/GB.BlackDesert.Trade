// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.TradeGameDB
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class TradeGameDB : DbContext
    {
        public TradeGameDB(string name)
          : base("name=" + name)
        {
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
        }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

        public virtual int uspUpdateForWithdrawToWorldMarket(
          long? payload,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateForWithdrawToWorldMarket), new ObjectParameter[3]
            {
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspGetPremiumPackageExpiration(
          long? userNo,
          ObjectParameter packageExpiration,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetPremiumPackageExpiration), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        packageExpiration,
        symNo,
        rv
            });
        }

        public virtual int uspRemoveForDepositToWorldMarket(
          long? payload,
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          long? count,
          short? state,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspRemoveForDepositToWorldMarket), new ObjectParameter[17]
            {
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        state.HasValue ? new ObjectParameter(nameof (state), (object) state) : new ObjectParameter(nameof (state), typeof (short)),
        symNo,
        rv
            });
        }

        public virtual int uspCreateForWithdrawToWorldMarket(
          long? payload,
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType,
          int? mainKey,
          int? subKey,
          bool? isSealed,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          long? count,
          short? state,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCreateForWithdrawToWorldMarket), new ObjectParameter[17]
            {
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        count.HasValue ? new ObjectParameter(nameof (count), (object) count) : new ObjectParameter(nameof (count), typeof (long)),
        state.HasValue ? new ObjectParameter(nameof (state), (object) state) : new ObjectParameter(nameof (state), typeof (short)),
        symNo,
        rv
            });
        }

        public virtual int uspGetFamilyPointForWorldTradeMarket(
          long? userNo,
          ObjectParameter levelPoint,
          ObjectParameter lifeLevelPoint,
          ObjectParameter etcPoint,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetFamilyPointForWorldTradeMarket), new ObjectParameter[6]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        levelPoint,
        lifeLevelPoint,
        etcPoint,
        rv,
        symNo
            });
        }

        public virtual int uspInsertToNoticeItem(
          long? registtimeStamp,
          int? keyType,
          int? mainKey,
          int? subKey,
          long? price,
          long? changedValue,
          short? noticeType,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspInsertToNoticeItem), new ObjectParameter[9]
            {
        registtimeStamp.HasValue ? new ObjectParameter(nameof (registtimeStamp), (object) registtimeStamp) : new ObjectParameter(nameof (registtimeStamp), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        price.HasValue ? new ObjectParameter(nameof (price), (object) price) : new ObjectParameter(nameof (price), typeof (long)),
        changedValue.HasValue ? new ObjectParameter(nameof (changedValue), (object) changedValue) : new ObjectParameter(nameof (changedValue), typeof (long)),
        noticeType.HasValue ? new ObjectParameter(nameof (noticeType), (object) noticeType) : new ObjectParameter(nameof (noticeType), typeof (short)),
        rv,
        symNo
            });
        }

        public virtual int uspGetTradeMaidCount(
          long? userNo,
          ObjectParameter maidCount,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetTradeMaidCount), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        maidCount,
        rv,
        symNo
            });
        }

        public virtual int uspUpdateCurrentPrice(
          int? mainKey,
          int? subKey,
          long? pricePerOne,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdateCurrentPrice), new ObjectParameter[5]
            {
        mainKey.HasValue ? new ObjectParameter(nameof (mainKey), (object) mainKey) : new ObjectParameter(nameof (mainKey), typeof (int)),
        subKey.HasValue ? new ObjectParameter(nameof (subKey), (object) subKey) : new ObjectParameter(nameof (subKey), typeof (int)),
        pricePerOne.HasValue ? new ObjectParameter(nameof (pricePerOne), (object) pricePerOne) : new ObjectParameter(nameof (pricePerOne), typeof (long)),
        rv,
        symNo
            });
        }

        public virtual ObjectResult<uspListFailPayload_Result> uspListFailPayload(
          int? serviceType,
          int? worldNo,
          long? userNo,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListFailPayload_Result>(nameof(uspListFailPayload), new ObjectParameter[5]
            {
        serviceType.HasValue ? new ObjectParameter(nameof (serviceType), (object) serviceType) : new ObjectParameter(nameof (serviceType), typeof (int)),
        worldNo.HasValue ? new ObjectParameter(nameof (worldNo), (object) worldNo) : new ObjectParameter(nameof (worldNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        rv,
        symNo
            });
        }

        public virtual int uspUsingTicket(
          long? userNo,
          byte? ticketType,
          string ticketNo,
          ObjectParameter rv,
          ObjectParameter symNo)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUsingTicket), new ObjectParameter[5]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        ticketType.HasValue ? new ObjectParameter(nameof (ticketType), (object) ticketType) : new ObjectParameter(nameof (ticketType), typeof (byte)),
        ticketNo != null ? new ObjectParameter(nameof (ticketNo), (object) ticketNo) : new ObjectParameter(nameof (ticketNo), typeof (string)),
        rv,
        symNo
            });
        }

        public virtual int uspCheckPayloadForRegisterItem(
          int? serviceType,
          int? worldNo,
          long? userNo,
          int? keyType,
          int? itemKey,
          int? enchantLevel,
          long? itemCount,
          bool? isSealed,
          long? payload,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCheckPayloadForRegisterItem), new ObjectParameter[16]
            {
        serviceType.HasValue ? new ObjectParameter(nameof (serviceType), (object) serviceType) : new ObjectParameter(nameof (serviceType), typeof (int)),
        worldNo.HasValue ? new ObjectParameter(nameof (worldNo), (object) worldNo) : new ObjectParameter(nameof (worldNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        itemKey.HasValue ? new ObjectParameter(nameof (itemKey), (object) itemKey) : new ObjectParameter(nameof (itemKey), typeof (int)),
        enchantLevel.HasValue ? new ObjectParameter(nameof (enchantLevel), (object) enchantLevel) : new ObjectParameter(nameof (enchantLevel), typeof (int)),
        itemCount.HasValue ? new ObjectParameter(nameof (itemCount), (object) itemCount) : new ObjectParameter(nameof (itemCount), typeof (long)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspCompletePayloadForRegisterItem(
          int? serviceType,
          int? worldNo,
          long? userNo,
          int? keyType,
          int? itemKey,
          int? enchantLevel,
          long? itemCount,
          bool? isSealed,
          long? payload,
          long? param0,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCompletePayloadForRegisterItem), new ObjectParameter[16]
            {
        serviceType.HasValue ? new ObjectParameter(nameof (serviceType), (object) serviceType) : new ObjectParameter(nameof (serviceType), typeof (int)),
        worldNo.HasValue ? new ObjectParameter(nameof (worldNo), (object) worldNo) : new ObjectParameter(nameof (worldNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType.HasValue ? new ObjectParameter(nameof (keyType), (object) keyType) : new ObjectParameter(nameof (keyType), typeof (int)),
        itemKey.HasValue ? new ObjectParameter(nameof (itemKey), (object) itemKey) : new ObjectParameter(nameof (itemKey), typeof (int)),
        enchantLevel.HasValue ? new ObjectParameter(nameof (enchantLevel), (object) enchantLevel) : new ObjectParameter(nameof (enchantLevel), typeof (int)),
        itemCount.HasValue ? new ObjectParameter(nameof (itemCount), (object) itemCount) : new ObjectParameter(nameof (itemCount), typeof (long)),
        isSealed.HasValue ? new ObjectParameter(nameof (isSealed), (object) isSealed) : new ObjectParameter(nameof (isSealed), typeof (bool)),
        payload.HasValue ? new ObjectParameter(nameof (payload), (object) payload) : new ObjectParameter(nameof (payload), typeof (long)),
        param0.HasValue ? new ObjectParameter(nameof (param0), (object) param0) : new ObjectParameter(nameof (param0), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspWithdrawPayloadDestroy(
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
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspWithdrawPayloadDestroy), new ObjectParameter[15]
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
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspFamilySKillListFromWorldMarket_Result> uspFamilySKillListFromWorldMarket(
          long? userNo,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspFamilySKillListFromWorldMarket_Result>(nameof(uspFamilySKillListFromWorldMarket), new ObjectParameter[3]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        symNo,
        rv
            });
        }

        public virtual int uspGetChargeBuffExpiration(
          long? userNo,
          byte? type,
          ObjectParameter packageExpiration,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetChargeBuffExpiration), new ObjectParameter[5]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        type.HasValue ? new ObjectParameter(nameof (type), (object) type) : new ObjectParameter(nameof (type), typeof (byte)),
        packageExpiration,
        symNo,
        rv
            });
        }

        public virtual int uspGetTradeRingBuff(
          long? userNo,
          ObjectParameter ringBuffMaxCount,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetTradeRingBuff), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        ringBuffMaxCount,
        symNo,
        rv
            });
        }

        public virtual int uspUpdatePackageBuffByWeb(
          long? userNo,
          short? serviceType,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspUpdatePackageBuffByWeb), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        serviceType.HasValue ? new ObjectParameter(nameof (serviceType), (object) serviceType) : new ObjectParameter(nameof (serviceType), typeof (short)),
        symNo,
        rv
            });
        }

        public virtual int uspClearNoticeItemList(ObjectParameter symNo, ObjectParameter rv) => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspClearNoticeItemList), new ObjectParameter[2]
        {
      symNo,
      rv
        });
    }
}
