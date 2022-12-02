using BlackDesert.TradeMarket.Lib;
using BlackDesert.TradeMarket.Lib.Manager;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class BiddingInfoManager
    {
        private static volatile BiddingInfoManager _singleton;
        private static object _locker = new object();
        private Dictionary<KeyValuePair<int, int>, TradeMarketBiddingInfo> _biddinginfoList;
        private Dictionary<KeyValuePair<int, int>, DateTime> _biddingTimeList;
        private bool _isOpen;
        private const string _managerName = "BiddingInfoManager";

        public BiddingInfoManager()
        {
            _biddinginfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketBiddingInfo>();
            _biddingTimeList = new Dictionary<KeyValuePair<int, int>, DateTime>();
            _isOpen = false;
        }

        public static BiddingInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new BiddingInfoManager();
                }
            }
            return _singleton;
        }

        public int open(ServerType serverType)
        {
            if (!ItemInfoManager.This().isOpen())
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, "BiddingInfoManager-ItemInfoManager");
                return -1;
            }
            Stopwatch stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(BiddingInfoManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(BiddingInfoManager));
                stopwatch.Start();
                foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in ItemInfoManager.This().getItemListXXX())
                {
                    int mainKey = keyValuePair.Value._mainKey;
                    int subKey = keyValuePair.Value._subKey;
                    _biddinginfoList[keyValuePair.Key] = new TradeMarketBiddingInfo(mainKey, subKey);
                    _biddingTimeList[keyValuePair.Key] = new DateTime();
                }
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(BiddingInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public bool checkBiddingUpdateTimeXXX(int mainKey, int subKey, DateTime currentTime)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, subKey);
            lock (_locker)
            {
                if (!_biddingTimeList.ContainsKey(key))
                    return false;
                DateTime biddingTime = _biddingTimeList[key];
                if (currentTime < biddingTime.AddSeconds(1.0))
                    return false;
                _biddingTimeList[key] = currentTime;
            }
            return true;
        }

        public bool updateBiddingInfoListXXX(
          int mainKey,
          int subKey,
          ref CommonDBResult<uspListBiddingInfo_Result> list)
        {
            if (list.list.Count <= 0)
                return false;
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, subKey);
            lock (_locker)
            {
                if (!_biddinginfoList.ContainsKey(key))
                    return false;
                _biddinginfoList[key]._biddingList.Clear();
                foreach (uspListBiddingInfo_Result biddingInfoResult in list.list)
                {
                    long cSellCount = biddingInfoResult.C_sellCount;
                    long cBuyCount = biddingInfoResult.C_buyCount;
                    long cPricePerOne = biddingInfoResult.C_pricePerOne;
                    if (!_biddinginfoList[key]._biddingList.ContainsKey(cPricePerOne))
                    {
                        _biddinginfoList[key]._biddingList[cPricePerOne] = new TradeMarketBiddingCount();
                        _biddinginfoList[key]._biddingList[cPricePerOne]._buyCount = cBuyCount;
                        _biddinginfoList[key]._biddingList[cPricePerOne]._sellCount = cSellCount;
                    }
                    else
                    {
                        _biddinginfoList[key]._biddingList[cPricePerOne]._buyCount += cBuyCount;
                        _biddinginfoList[key]._biddingList[cPricePerOne]._sellCount += cSellCount;
                    }
                }
            }
            return true;
        }

        public void getJsonStringByBiddingListXXX(int mainKey, int subKey, ref CommonResult jsonResult)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, subKey);
            lock (_locker)
            {
                if (!_biddinginfoList.ContainsKey(key))
                    jsonResult.resultMsg = "0";
                else if (_biddinginfoList[key]._biddingList.Count <= 0)
                {
                    jsonResult.resultMsg = "0";
                }
                else
                {
                    foreach (KeyValuePair<long, TradeMarketBiddingCount> bidding in _biddinginfoList[key]._biddingList)
                        jsonResult.resultMsg = jsonResult.resultMsg + Convert.ToString(bidding.Key) + "-" + Convert.ToString(bidding.Value._sellCount) + "-" + Convert.ToString(bidding.Value._buyCount) + "|";
                }
            }
        }
    }
}
