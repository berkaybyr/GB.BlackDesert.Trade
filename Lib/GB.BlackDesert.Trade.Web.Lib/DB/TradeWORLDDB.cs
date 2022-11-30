// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DB.TradeWORLDDB
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace GB.BlackDesert.Trade.Web.Lib.DB
{
    public class TradeWORLDDB : DbContext
    {
        public TradeWORLDDB()
          : base("name=TradeWORLDDB")
        {
        }

        protected virtual void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

        public virtual int uspSetWorldTradeMarketCommandResult(
          long? commandNo,
          byte? status,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspSetWorldTradeMarketCommandResult), new ObjectParameter[4]
            {
        commandNo.HasValue ? new ObjectParameter(nameof (commandNo), (object) commandNo) : new ObjectParameter(nameof (commandNo), typeof (long)),
        status.HasValue ? new ObjectParameter(nameof (status), (object) status) : new ObjectParameter(nameof (status), typeof (byte)),
        symNo,
        rv
            });
        }

        public virtual ObjectResult<uspListWorldTradeMarketCommand_Result> uspListWorldTradeMarketCommand(
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspListWorldTradeMarketCommand_Result>(nameof(uspListWorldTradeMarketCommand), new ObjectParameter[2]
            {
        symNo,
        rv
            });
        }

        public virtual int uspGetUserId(
          long? userNo,
          ObjectParameter userId,
          ObjectParameter resultCode,
          ObjectParameter resultMsg)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspGetUserId), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        userId,
        resultCode,
        resultMsg
            });
        }

        public virtual int uspIsGameMaster(
          long? userNo,
          ObjectParameter isGameMaster,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspIsGameMaster), new ObjectParameter[4]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        isGameMaster,
        symNo,
        rv
            });
        }

        public virtual ObjectResult<string> uspGetSecondPwd(long? userNo) => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>(nameof(uspGetSecondPwd), new ObjectParameter[1]
        {
      userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long))
        });

        public virtual int uspAccessByTradeWeb(
          long? userNo,
          ObjectParameter serviceType,
          ObjectParameter worldNo,
          ObjectParameter isAdmissionToSpeedServer,
          ObjectParameter isUpdatePackageBuff,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspAccessByTradeWeb), new ObjectParameter[7]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        serviceType,
        worldNo,
        isAdmissionToSpeedServer,
        isUpdatePackageBuff,
        symNo,
        rv
            });
        }

        public virtual int uspCheckAuthKey(
          long? userNo,
          string certifeidKey,
          DateTime? requestDate,
          ObjectParameter serviceType,
          ObjectParameter worldNo,
          ObjectParameter userNickName,
          ObjectParameter symNo,
          ObjectParameter rv)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCheckAuthKey), new ObjectParameter[8]
            {
        userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
        certifeidKey != null ? new ObjectParameter(nameof (certifeidKey), (object) certifeidKey) : new ObjectParameter(nameof (certifeidKey), typeof (string)),
        requestDate.HasValue ? new ObjectParameter(nameof (requestDate), (object) requestDate) : new ObjectParameter(nameof (requestDate), typeof (DateTime)),
        serviceType,
        worldNo,
        userNickName,
        symNo,
        rv
            });
        }

        public virtual int uspClearTradeAuthHistory(ObjectParameter symNo, ObjectParameter rv) => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspClearTradeAuthHistory), new ObjectParameter[2]
        {
      symNo,
      rv
        });

        public virtual int uspCheckSecondPwd(long? userNo, string secondPW, ObjectParameter resultCode) => ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(nameof(uspCheckSecondPwd), new ObjectParameter[3]
        {
      userNo.HasValue ? new ObjectParameter(nameof (userNo), (object) userNo) : new ObjectParameter(nameof (userNo), typeof (long)),
      secondPW != null ? new ObjectParameter(nameof (secondPW), (object) secondPW) : new ObjectParameter(nameof (secondPW), typeof (string)),
      resultCode
        });
    }
}
