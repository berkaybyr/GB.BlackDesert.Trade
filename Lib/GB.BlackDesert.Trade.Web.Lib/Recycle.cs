namespace BlackDesert.TradeMarket.Lib.Manager
{
    public enum Recycle
    {
        eFetchCommandTime = 10000, // 0x00002710
        eSyncNoticeItemList = 10000, // 0x00002710
        eWaitSellTime = 10000, // 0x00002710
        eUpdateCurrentPrice = 60000, // 0x0000EA60
        eUpdateSystemTime = 600000, // 0x000927C0
        eUpdateTickCountTime = 1800000, // 0x001B7740
    }
}
