// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Application.AjaxOptionsEx
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using System.Web.Mvc.Ajax;

namespace BlackDesert.TradeMarket.Lib.Extensions
{
    public class AjaxOptionsEx : AjaxOptions
    {
        public AjaxOptionsEx()
        {
            this.HttpMethod = "POST";
            this.OnBegin = "fnAjaxOnBegin";
            this.OnSuccess = "fnAjaxOnSuccess";
            this.OnFailure = "fnAjaxOnFailure";
            this.OnComplete = "fnAjaxOnComplete";
        }
    }
}
