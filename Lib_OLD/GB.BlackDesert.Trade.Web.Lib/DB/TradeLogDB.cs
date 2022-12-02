// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.TradeLogDB
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class TradeLogDB : DbContext
    {
        public TradeLogDB()
          : base("name=TradeLogDB")
        {
        }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

        public virtual int uspLogWorldMarketForOperation(
          short? operationLogType,
          DateTime? registerDate,
          int? nationCode,
          int? serverNo,
          long? userNo,
          int? keyType1,
          int? mainKey1,
          int? subKey1,
          long? count1,
          long? beforeCount1,
          long? afterCount1,
          int? keyType2,
          int? mainKey2,
          int? subKey2,
          long? count2,
          long? beforeCount2,
          long? afterCount2,
          long? param1,
          long? param2,
          long? param3,
          long? param4,
          long? param5,
          long? param6,
          long? param7,
          long? param8,
          long? param9,
          long? param10,
          long? param11,
          long? param12,
          string textParam1,
          string textParam2,
          short? reason,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspLogWorldMarketForOperation), new ObjectParameter[34]
            {
        operationLogType.HasValue ? new ObjectParameter(nameof (operationLogType), (object) operationLogType) : new ObjectParameter(nameof (operationLogType), typeof (short)),
        registerDate.HasValue ? new ObjectParameter(nameof (registerDate), (object) registerDate) : new ObjectParameter(nameof (registerDate), typeof (DateTime)),
        nationCode.HasValue ? new ObjectParameter(nameof (nationCode), (object) nationCode) : new ObjectParameter(nameof (nationCode), typeof (int)),
        serverNo.HasValue ? new ObjectParameter(nameof (serverNo), (object) serverNo) : new ObjectParameter(nameof (serverNo), typeof (int)),
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        keyType1.HasValue ? new ObjectParameter(nameof (keyType1), (object) keyType1) : new ObjectParameter(nameof (keyType1), typeof (int)),
        mainKey1.HasValue ? new ObjectParameter(nameof (mainKey1), (object) mainKey1) : new ObjectParameter(nameof (mainKey1), typeof (int)),
        subKey1.HasValue ? new ObjectParameter(nameof (subKey1), (object) subKey1) : new ObjectParameter(nameof (subKey1), typeof (int)),
        count1.HasValue ? new ObjectParameter(nameof (count1), (object) count1) : new ObjectParameter(nameof (count1), typeof (long)),
        beforeCount1.HasValue ? new ObjectParameter(nameof (beforeCount1), (object) beforeCount1) : new ObjectParameter(nameof (beforeCount1), typeof (long)),
        afterCount1.HasValue ? new ObjectParameter(nameof (afterCount1), (object) afterCount1) : new ObjectParameter(nameof (afterCount1), typeof (long)),
        keyType2.HasValue ? new ObjectParameter(nameof (keyType2), (object) keyType2) : new ObjectParameter(nameof (keyType2), typeof (int)),
        mainKey2.HasValue ? new ObjectParameter(nameof (mainKey2), (object) mainKey2) : new ObjectParameter(nameof (mainKey2), typeof (int)),
        subKey2.HasValue ? new ObjectParameter(nameof (subKey2), (object) subKey2) : new ObjectParameter(nameof (subKey2), typeof (int)),
        count2.HasValue ? new ObjectParameter(nameof (count2), (object) count2) : new ObjectParameter(nameof (count2), typeof (long)),
        beforeCount2.HasValue ? new ObjectParameter(nameof (beforeCount2), (object) beforeCount2) : new ObjectParameter(nameof (beforeCount2), typeof (long)),
        afterCount2.HasValue ? new ObjectParameter(nameof (afterCount2), (object) afterCount2) : new ObjectParameter(nameof (afterCount2), typeof (long)),
        param1.HasValue ? new ObjectParameter(nameof (param1), (object) param1) : new ObjectParameter(nameof (param1), typeof (long)),
        param2.HasValue ? new ObjectParameter(nameof (param2), (object) param2) : new ObjectParameter(nameof (param2), typeof (long)),
        param3.HasValue ? new ObjectParameter(nameof (param3), (object) param3) : new ObjectParameter(nameof (param3), typeof (long)),
        param4.HasValue ? new ObjectParameter(nameof (param4), (object) param4) : new ObjectParameter(nameof (param4), typeof (long)),
        param5.HasValue ? new ObjectParameter(nameof (param5), (object) param5) : new ObjectParameter(nameof (param5), typeof (long)),
        param6.HasValue ? new ObjectParameter(nameof (param6), (object) param6) : new ObjectParameter(nameof (param6), typeof (long)),
        param7.HasValue ? new ObjectParameter(nameof (param7), (object) param7) : new ObjectParameter(nameof (param7), typeof (long)),
        param8.HasValue ? new ObjectParameter(nameof (param8), (object) param8) : new ObjectParameter(nameof (param8), typeof (long)),
        param9.HasValue ? new ObjectParameter(nameof (param9), (object) param9) : new ObjectParameter(nameof (param9), typeof (long)),
        param10.HasValue ? new ObjectParameter(nameof (param10), (object) param10) : new ObjectParameter(nameof (param10), typeof (long)),
        param11.HasValue ? new ObjectParameter(nameof (param11), (object) param11) : new ObjectParameter(nameof (param11), typeof (long)),
        param12.HasValue ? new ObjectParameter(nameof (param12), (object) param12) : new ObjectParameter(nameof (param12), typeof (long)),
        textParam1 != null ? new ObjectParameter(nameof (textParam1), (object) textParam1) : new ObjectParameter(nameof (textParam1), typeof (string)),
        textParam2 != null ? new ObjectParameter(nameof (textParam2), (object) textParam2) : new ObjectParameter(nameof (textParam2), typeof (string)),
        reason.HasValue ? new ObjectParameter(nameof (reason), (object) reason) : new ObjectParameter(nameof (reason), typeof (short)),
        symNo,
        rv
            });
        }
    }
}
