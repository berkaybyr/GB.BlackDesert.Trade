// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Models.PayloadFailList
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using GB.BlackDesert.Trade.Web.Lib.DB;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Process.Models
{
    public class PayloadFailList
    {
        public List<uspListFailPayload_Result> _list { get; set; }

        public PayloadFailList() => this._list = new List<uspListFailPayload_Result>();
    }
}
