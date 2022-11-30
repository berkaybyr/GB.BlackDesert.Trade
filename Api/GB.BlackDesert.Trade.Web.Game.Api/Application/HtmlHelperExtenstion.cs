// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Application.HtmlHelperExtenstion
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace GB.BlackDesert.Trade.Web.Game.Api.Application
{
    public static class HtmlHelperExtenstion
    {
        public static string GetResourceValue(this HtmlHelper htmlHelper, string _strKey) => CommonModule.GetResourceValue(_strKey).ToString();
    }
}
