// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.TradeMarketItemInfo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Manager;
using System.Collections.Generic;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class TradeMarketItemInfo
    {
        public readonly int _keyType;
        public readonly int _mainKey;
        public readonly int _subKey;
        public readonly int _mainGroupNo;
        public readonly int _subGroupNo;
        public readonly long _maxPrice;
        public readonly long _minPrice;
        public readonly long _realMaxPrice;
        public readonly long _realMinPrice;
        public readonly long _basePrice;
        public readonly bool _isEnchantable;
        public readonly int _enchantGroup;
        public readonly long _enchantNeedCount;
        public readonly bool _isPersonalTrade;
        public readonly int _enchantMaterialKey;
        public readonly long _weight;
        public readonly long _maxStackCount;
        public readonly long _tradeCountToUpdate;
        public readonly int _accumulatePassCount;
        public readonly long _maxRegisterForWorldMarket;
        public readonly bool _noticeAbleItemForWorldMarket;
        public readonly int _grade;
        public readonly long _marketPriceGroup;
        public readonly bool _isForceDisplay;
        public KeyValuePair<int, int> _representativeItemEnchantKey;

        public bool hasPriceGroup() => 0L < this._marketPriceGroup;

        public TradeMarketItemInfo()
        {
            this._keyType = 0;
            this._mainKey = 0;
            this._subKey = 0;
            this._mainGroupNo = 0;
            this._subGroupNo = 0;
            this._maxPrice = 0L;
            this._minPrice = 0L;
            this._realMaxPrice = 0L;
            this._realMinPrice = 0L;
            this._basePrice = 0L;
            this._isEnchantable = false;
            this._enchantGroup = 0;
            this._enchantNeedCount = 0L;
            this._isPersonalTrade = false;
            this._enchantMaterialKey = 0;
            this._weight = 0L;
            this._maxStackCount = 0L;
            this._tradeCountToUpdate = 0L;
            this._accumulatePassCount = 0;
            this._maxRegisterForWorldMarket = 0L;
            this._noticeAbleItemForWorldMarket = false;
            this._grade = 0;
            this._marketPriceGroup = 0L;
            this._isForceDisplay = false;
            this._representativeItemEnchantKey = new KeyValuePair<int, int>(0, 0);
        }

        public TradeMarketItemInfo(
          int keyType,
          int itemKey,
          int enchantLevel,
          int mainGroupNo,
          int subGroupNo,
          long enchantAddPercent,
          long maxPrice,
          long minPrice,
          long basePrice,
          bool isEnchantable,
          int enchantGroup,
          long enchantNeedCount,
          bool isPersonalTrade,
          int enchantMaterialKey,
          long weight,
          long maxStackCount,
          long tradeCountToUpdate,
          int accumulatePassCount,
          long maxRegisterForWorldMarket,
          bool noticeAbleItemForWorldMarket,
          int grade,
          long marketPriceGroup,
          bool isForceDisplay,
          long maxPriceNew,
          long minPriceNew)
        {
            this._keyType = keyType;
            this._mainKey = itemKey;
            this._subKey = enchantLevel;
            this._mainGroupNo = mainGroupNo;
            this._subGroupNo = subGroupNo;
            this._maxPrice = maxPrice;
            this._minPrice = minPrice;
            this._basePrice = basePrice;
            this._isEnchantable = isEnchantable;
            if (enchantAddPercent == 0L)
                enchantAddPercent = 1000000L;
            if (maxPriceNew == 0L)
            {
                if (this._maxPrice != 0L)
                {
                    this._maxPrice = this._basePrice + (long)((double)this._basePrice * ((double)this._maxPrice / 1000000.0));
                    this._maxPrice = (long)((double)this._maxPrice * ((double)enchantAddPercent / 1000000.0));
                    this._maxPrice = VariedPriceInfoManager.This().calculatePrice(this._maxPrice);
                    if (this._maxPrice == 0L)
                        this._maxPrice = this._basePrice;
                }
                else
                    this._maxPrice = this._basePrice;
            }
            else
                this._maxPrice = maxPriceNew;
            this._realMaxPrice = VariedPriceInfoManager.This().calculatePrice((long)((double)this._maxPrice / (1.0 + WorldMarketOptionManager.This().BiddingRatio)), "UP");
            if (minPriceNew == 0L)
            {
                if (this._minPrice != 0L)
                {
                    this._minPrice = this._basePrice - (long)((double)this._basePrice * ((double)this._minPrice / 1000000.0));
                    this._minPrice = VariedPriceInfoManager.This().calculatePrice(this._minPrice);
                    if (this._minPrice == 0L)
                        this._minPrice = this._basePrice;
                }
                else
                    this._minPrice = this._basePrice;
            }
            else
                this._minPrice = minPriceNew;
            this._realMinPrice = VariedPriceInfoManager.This().calculatePrice((long)((double)this._minPrice / (1.0 - WorldMarketOptionManager.This().BiddingRatio)), "DOWN");
            this._enchantGroup = enchantGroup;
            this._enchantNeedCount = enchantNeedCount;
            this._isPersonalTrade = isPersonalTrade;
            if (16 <= this._subKey)
                enchantMaterialKey = 0;
            this._enchantMaterialKey = enchantMaterialKey;
            this._weight = weight;
            this._maxStackCount = maxStackCount;
            this._tradeCountToUpdate = tradeCountToUpdate;
            this._accumulatePassCount = accumulatePassCount;
            this._maxRegisterForWorldMarket = maxRegisterForWorldMarket;
            this._noticeAbleItemForWorldMarket = noticeAbleItemForWorldMarket;
            this._grade = grade;
            this._marketPriceGroup = marketPriceGroup;
            this._isForceDisplay = isForceDisplay;
            this._representativeItemEnchantKey = new KeyValuePair<int, int>(0, 0);
        }

        public bool isValid() => 0 < this._mainKey && 0 <= this._subKey;
    }
}
