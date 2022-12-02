using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDesert.TradeMarket.Lib
{
    public enum CommandReasonType
    {
        eCommandType_InsertBlockItem,
        eCommandType_RemoveBlockItem,
        eCommandType_UpdateTickCount,
        eCommandType_UpdatePrice,
        eCommandType_InsertBlockUser,
        eCommandType_RemoveBlockUser,
        eCommandType_SetContentsOpen,
        eCommandType_SetMaxPrice,
        eCommandType_AddTrade,
        eCommandType_UpdateTargetPrice,
        eCommandType_Count,
    }
}
