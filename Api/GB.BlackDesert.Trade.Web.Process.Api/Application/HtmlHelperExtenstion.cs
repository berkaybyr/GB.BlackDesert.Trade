// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Process.Application.HtmlHelperExtenstion
// Assembly: GB.BlackDesert.Trade.Web.Process, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768E4CB8-8595-4E03-AC99-A267D947E7AC
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Process.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace GB.BlackDesert.Trade.Web.Process.Api.Application
{
    public static class HtmlHelperExtenstion
    {
        public static string GetResourceValue(this HtmlHelper htmlHelper, string _strKey) => CommonModule.GetResourceValue(_strKey).ToString();
    }
}
