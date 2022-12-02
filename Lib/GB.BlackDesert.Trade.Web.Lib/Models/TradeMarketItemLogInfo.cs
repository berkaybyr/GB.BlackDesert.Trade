using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDesert.TradeMarket.Lib.Models
{

    public class TradeMarketItemLogInfo
    {
        public int keyType1 { get; set; }

        public int itemKey1 { get; set; }

        public int enchantLevel1 { get; set; }

        public long count1 { get; set; }

        public long beforeCount1 { get; set; }

        public long afterCount1 { get; set; }

        public int keyType2 { get; set; }

        public int itemKey2 { get; set; }

        public int enchantLevel2 { get; set; }

        public long count2 { get; set; }

        public long beforeCount2 { get; set; }

        public long afterCount2 { get; set; }

        public TradeMarketItemLogInfo()
        {
            this.keyType1 = 0;
            this.itemKey1 = 0;
            this.enchantLevel1 = 0;
            this.count1 = 0L;
            this.beforeCount1 = 0L;
            this.afterCount1 = 0L;
            this.keyType2 = 0;
            this.itemKey2 = 0;
            this.enchantLevel2 = 0;
            this.count2 = 0L;
            this.beforeCount2 = 0L;
            this.afterCount2 = 0L;
        }
    }
}
