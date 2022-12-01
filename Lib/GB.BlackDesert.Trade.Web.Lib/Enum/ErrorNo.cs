// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.ErrorNo
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.Common
{
    public enum ErrorNo
    {
        eErrorNo_Not = 0,
        eErrorNo_DBException = 1,
        eErrorNo_HttpException = 2,
        eErrorNo_JSONException = 3,
        eErrorNo_XmlException = 4,
        eErrorNo_JSONIsNull = 5,
        eErrorNo_UserNotExist = 6,
        eErrorNo_InvalidCount = 7,
        eErrorNo_InvalidItem = 8,
        eErrorNo_InvalidItemGroup = 9,
        eErrorNo_BuyBiddingFail = 10, // 0x0000000A
        eErrorNo_BuyBiddingRepeatOverFail = 11, // 0x0000000B
        eErrorNo_SellBiddingFail = 12, // 0x0000000C
        eErrorNo_SellBiddingRepeatOverFail = 13, // 0x0000000D
        eErrorNo_PriceWrong = 14, // 0x0000000E
        eErrorNo_ItemNotExist = 15, // 0x0000000F
        eErrorNo_InvalidItemStack = 16, // 0x00000010
        eErrorNo_PayloadIsZero = 17, // 0x00000011
        eErrorNo_InvalidArgumentCount = 18, // 0x00000012
        eErrorNo_InvalidCommand = 19, // 0x00000013
        eErrorNo_ItemCountOver = 20, // 0x00000014
        eErrorNo_StringOver = 21, // 0x00000015
        eErrorNo_ReserveBuyBiddingFail = 22, // 0x00000016
        eErrorNo_ReserveSellBiddingFail = 23, // 0x00000017
        eErrorNo_BlockedUser = 24, // 0x00000018
        eErrorNo_UnUseOtp = 25, // 0x00000019
        eErrorNo_NotMatchOtp = 26, // 0x0000001A
        eErrorNo_FailCountMax = 27, // 0x0000001B
        eErrorNo_OtpBackUpCodeAlreadyUse = 28, // 0x0000001C
        eErrorNo_WeightOver = 100, // 0x00000064
        eErrorNo_Unauthorized = 2000, // 0x000007D0
        eErrorNo_SearchTextInvalid = 2001, // 0x000007D1
        eErrorNo_UnauthorizedSecondPass = 28877, // 0x000070CD
        eErrorNo_Count = 28878, // 0x000070CE
    }
}
