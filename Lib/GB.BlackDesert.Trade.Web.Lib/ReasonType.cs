using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDesert.TradeMarket.Lib
{
    public enum ReasonType
    {
        eWorldMarket_ReasonType_Buy = 0,
        eWorldMarket_ReasonType_Sell = 1,
        eWorldMarket_ReasonType_BuyBidding = 2,
        eWorldMarket_ReasonType_SellBidding = 3,
        eWorldMarket_ReasonType_Push = 4,
        eWorldMarket_ReasonType_Pop = 5,
        eWorldMarket_ReasonType_PersonalRegister = 6,
        eWorldMarket_ReasonType_PersonalUnRegister = 7,
        eWorldMarket_ReasonType_PersonalBuy = 8,
        eWorldMarket_ReasonType_PersonalReset = 9,
        eWorldMarket_ReasonType_BiddingBuyRegister = 10, // 0x0000000A
        eWorldMarket_ReasonType_BiddingBuyWithdraw = 11, // 0x0000000B
        eWorldMarket_ReasonType_BiddingBuyCalculate = 12, // 0x0000000C
        eWorldMarket_ReasonType_BiddingSellRegister = 13, // 0x0000000D
        eWorldMarket_ReasonType_BiddingSellWithdraw = 14, // 0x0000000E
        eWorldMarket_ReasonType_BiddingSellCalculate = 15, // 0x0000000F
        eWorldMarket_ReasonType_BuySystem = 16, // 0x00000010
        eWorldMarket_ReasonType_BuyBiddingSystem = 17, // 0x00000011
        eWorldMarket_ReasonType_MoneyLog = 18, // 0x00000012
        eWorldMarket_ReasonType_PayloadRestoration = 19, // 0x00000013
        eWorldMarket_ReasonType_Fail_Push = 20, // 0x00000014
        eWorldMarket_ReasonType_Fail_Pop = 21, // 0x00000015
        eWorldMarket_ReasonType_Restoration = 22, // 0x00000016
        eWorldMarket_ReasonType_SellWait = 23, // 0x00000017
        eWorldMarket_ReasonType_SellWaitFailUpdate = 24, // 0x00000018
        eWorldMarket_ReasonType_CreateWallet = 1000, // 0x000003E8
        eWorldMarket_ReasonType_KeyWordInsert = 1001, // 0x000003E9
        eWorldMarket_ReasonType_KeyWordDelete = 1002, // 0x000003EA
        eWorldMarket_ReasonType_End = 1003, // 0x000003EB
    }
}
