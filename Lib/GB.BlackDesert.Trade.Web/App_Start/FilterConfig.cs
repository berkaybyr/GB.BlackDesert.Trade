// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.App_Start.FilterConfig
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) => filters.Add((object)new WebFilter());
    }
}
