using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDesert.TradeMarket.Lib.Models
{
    public class TradeMarketUserLogInfo
    {
        public int nationCode { get; set; }

        public int serverNo { get; set; }

        public long userNo { get; set; }

        public TradeMarketUserLogInfo()
        {
            this.nationCode = 0;
            this.serverNo = 0;
            this.userNo = 0L;
        }
    }
}
