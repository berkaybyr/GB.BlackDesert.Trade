// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.CommonDDLB
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Manager;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Lib.Common
{
    public static class CommonDDLB
    {
        public static List<SelectListItem> initLanguageCodeDDLB(string currCulture)
        {
            string empty = string.Empty;
            List<SelectListItem> selectListItemList = new List<SelectListItem>();
            string[] cultureList = ConstantMgr.GetCultureList();
            for (int index = 0; index < cultureList.Length; ++index)
            {
                string resourceValue = CommonModule.GetResourceValue("TRADE_MARKET_LANGUAGE_" + cultureList[index].ToUpper());
                if (cultureList[index].Equals(currCulture))
                    selectListItemList.Add(new SelectListItem()
                    {
                        Text = resourceValue,
                        Value = cultureList[index],
                        Selected = true
                    });
                else
                    selectListItemList.Add(new SelectListItem()
                    {
                        Text = resourceValue,
                        Value = cultureList[index]
                    });
            }
            return selectListItemList;
        }
    }
}
