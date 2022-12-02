using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System.Data.Entity.Core.Objects;

namespace BlackDesert.TradeMarket.Process.Api.Controllers
{
    //[ApiController]
    //[Route("[controller]/[action]")]
    public class CommandProcess
    {
        private Dictionary<int, CommandProcess.CommandDelation> _commandList;

        public CommandProcess()
        {
            this._commandList = new Dictionary<int, CommandProcess.CommandDelation>();
            this.makeCommandList();
        }
        private void makeCommandList()
        {
            this._commandList.Add("insertblockitem".GetHashCode(), new CommandProcess.CommandDelation(this.insertBlockItem));
            this._commandList.Add("removeblockitem".GetHashCode(), new CommandProcess.CommandDelation(this.removeBlockItem));
            this._commandList.Add("insertblockuser".GetHashCode(), new CommandProcess.CommandDelation(this.insertBlockUser));
            this._commandList.Add("removeblockuser".GetHashCode(), new CommandProcess.CommandDelation(this.removeBlockUser));
            this._commandList.Add("updatetickcount".GetHashCode(), new CommandProcess.CommandDelation(this.updateTickCount));
            this._commandList.Add("updateprice".GetHashCode(), new CommandProcess.CommandDelation(this.updatePrice));
            this._commandList.Add("setworldmarketstate".GetHashCode(), new CommandProcess.CommandDelation(this.setWorldMarketState));
            this._commandList.Add("setmaxprice".GetHashCode(), new CommandProcess.CommandDelation(this.setMaxPrice));
            this._commandList.Add("addtrade".GetHashCode(), new CommandProcess.CommandDelation(this.addTrade));
            this._commandList.Add("updatetargetprice".GetHashCode(), new CommandProcess.CommandDelation(this.updateTargetPrice));
        }

        public int process(string commandString)
        {
            List<string> argumentList = new List<string>();
            string[] strArray = commandString.Split(new string[1]
            {
        " "
            }, StringSplitOptions.RemoveEmptyEntries);
            if (strArray.Length < 1)
                return 18;
            string str = strArray[0];
            for (int index = 1; index < strArray.Length; ++index)
                argumentList.Add(strArray[index]);
            int hashCode = str.GetHashCode();
            return !this._commandList.ContainsKey(hashCode) ? 19 : this._commandList[hashCode](argumentList);
        }

        private int insertBlockItem(List<string> argumentList)
        {
            if (2 != argumentList.Count)
                return 18;
            int int32_1 = Convert.ToInt32(argumentList[0]);
            int int32_2 = Convert.ToInt32(argumentList[1]);
            if (!ItemInfoManager.This().getInfo(int32_1, int32_2).isValid())
                return 8;
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspInsertBlockItem(new int?(0), new int?(int32_1), new long?((long)int32_2), symNo, rv);
                    int int32_3 = Convert.ToInt32(rv.Value);
                    if (int32_3 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspListWorldTradeMarketCommand({0}/{1}), rv({2})", (object)int32_1, (object)int32_2, (object)int32_3), "WARN");
                        return int32_3;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspInsertBlockItem Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_InsertBlockItem, CommonModule.GetCustomTime(), (long)int32_1, (long)int32_2);
            return 0;
        }

        private int removeBlockItem(List<string> argumentList)
        {
            if (2 != argumentList.Count)
                return 18;
            int int32_1 = Convert.ToInt32(argumentList[0]);
            int int32_2 = Convert.ToInt32(argumentList[1]);
            if (!ItemInfoManager.This().getInfo(int32_1, int32_2).isValid())
                return 8;
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspRemoveBlockItem(new int?(0), new int?(int32_1), new long?((long)int32_2), symNo, rv);
                    int int32_3 = Convert.ToInt32(rv.Value);
                    if (int32_3 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspRemoveBlockItem({0}/{1}), rv({2})", (object)int32_1, (object)int32_2, (object)int32_3), "WARN");
                        return int32_3;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspRemoveBlockItem Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_RemoveBlockItem, CommonModule.GetCustomTime(), (long)int32_1, (long)int32_2);
            return 0;
        }

        private int insertBlockUser(List<string> argumentList)
        {
            if (4 != argumentList.Count)
                return 18;
            int int32_1 = Convert.ToInt32(argumentList[0]);
            int int32_2 = Convert.ToInt32(argumentList[1]);
            long int64_1 = Convert.ToInt64(argumentList[2]);
            long int64_2 = Convert.ToInt64(argumentList[3]);
            if ((long)int.MaxValue < int64_2)
                return 19;
            DateTime dateTime = CommonModule.GetCustomTime().AddSeconds((double)int64_2);
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspInsertBlockUser(new int?(int32_1), new int?(int32_2), new long?(int64_1), new DateTime?(dateTime), symNo, rv);
                    int int32_3 = Convert.ToInt32(rv.Value);
                    if (int32_3 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspInsertBlockUser({0}/{1}/{2}), rv({3})", (object)int32_1, (object)int32_2, (object)int64_1, (object)int32_3), "WARN");
                        return int32_3;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspInsertBlockItem Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_InsertBlockUser, CommonModule.GetCustomTime(), (long)int32_1, (long)int32_2, int64_1);
            return 0;
        }

        private int removeBlockUser(List<string> argumentList)
        {
            if (3 != argumentList.Count)
                return 18;
            int int32_1 = Convert.ToInt32(argumentList[0]);
            int int32_2 = Convert.ToInt32(argumentList[1]);
            long int64 = Convert.ToInt64(argumentList[2]);
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspRemoveBlockUser(new int?(int32_1), new int?(int32_2), new long?(int64), symNo, rv);
                    int int32_3 = Convert.ToInt32(rv.Value);
                    if (int32_3 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspRemoveBlockUser({0}/{1}/{2}), rv({3})", (object)int32_1, (object)int32_2, (object)int64, (object)int32_3), "WARN");
                        return int32_3;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspRemoveBlockUser Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_RemoveBlockUser, CommonModule.GetCustomTime(), (long)int32_1, (long)int32_2, int64);
            return 0;
        }

        private int updateTickCount(List<string> argumentList)
        {
            TickCountManager.This().updateTickCountXXX();
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_UpdateTickCount, CommonModule.GetCustomTime());
            return 0;
        }

        private int updateTargetPrice(List<string> argumentList)
        {
            if (4 != argumentList.Count)
                return 18;
            bool isIncrease = 1 == Convert.ToInt32(argumentList[0]);
            int int32_1 = Convert.ToInt32(argumentList[1]);
            int int32_2 = Convert.ToInt32(argumentList[2]);
            int int32_3 = Convert.ToInt32(argumentList[3]);
            if (!ItemInfoManager.This().getInfo(int32_2, int32_3).isValid())
                return 18;
            TickCountManager.This().updatePriceTargetXXX(isIncrease, int32_1, int32_2, int32_3);
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_UpdateTargetPrice, CommonModule.GetCustomTime(), (long)Convert.ToInt32(isIncrease), (long)int32_1, (long)int32_2, (long)int32_3);
            return 0;
        }

        private int updatePrice(List<string> argumentList)
        {
            if (1 != argumentList.Count)
                return 18;
            int int32 = Convert.ToInt32(argumentList[0]);
            if (!TickCountManager.This().isExistsMainGroupNo(int32))
                return 18;
            TickCountManager.This().updatePriceWorldMarketXXX(int32);
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_UpdatePrice, CommonModule.GetCustomTime(), (long)int32);
            return 0;
        }

        private int setWorldMarketState(List<string> argumentList)
        {
            if (1 != argumentList.Count)
                return 18;
            bool flag = argumentList[0].Equals("1");
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspUpdateMarketState(new bool?(flag), symNo, rv);
                    int int32 = Convert.ToInt32(rv.Value);
                    if (int32 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspUpdateMarketState({0}), rv({1})", (object)flag, (object)int32), "WARN");
                        return int32;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspRemoveBlockUser Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_SetContentsOpen, CommonModule.GetCustomTime(), flag ? 1L : 0L);
            return 0;
        }

        private int setMaxPrice(List<string> argumentList)
        {
            if (3 != argumentList.Count)
                return 18;
            int int32_1 = Convert.ToInt32(argumentList[0]);
            int int32_2 = Convert.ToInt32(argumentList[1]);
            bool flag = argumentList[2].Equals("1");
            if (!ItemInfoManager.This().getInfo(int32_1, int32_2).isValid())
                return 8;
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspSetMaxPrice(new int?(0), new int?(int32_1), new long?((long)int32_2), new bool?(flag), symNo, rv);
                    int int32_3 = Convert.ToInt32(rv.Value);
                    if (int32_3 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspSetMaxPrice({0}/{1}), rv({2})", (object)int32_1, (object)int32_2, (object)int32_3), "WARN");
                        return int32_3;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspSetMaxPrice Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_SetMaxPrice, CommonModule.GetCustomTime(), (long)int32_1, (long)int32_2, (long)Convert.ToInt32(flag));
            return 0;
        }

        private int addTrade(List<string> argumentList)
        {
            if (4 != argumentList.Count)
                return 18;
            int int32_1 = Convert.ToInt32(argumentList[0]);
            int int32_2 = Convert.ToInt32(argumentList[1]);
            long int64_1 = Convert.ToInt64(argumentList[2]);
            long int64_2 = Convert.ToInt64(argumentList[3]);
            if (!ItemInfoManager.This().getInfo(int32_1, int32_2).isValid())
                return 8;
            using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
            {
                ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                try
                {
                    SA_BETA_TRADEDB_0002.uspAddTrade(new int?(0), new int?(int32_1), new long?((long)int32_2), new long?(int64_1), new long?(int64_2), symNo, rv);
                    int int32_3 = Convert.ToInt32(rv.Value);
                    if (int32_3 != 0)
                    {
                        LogUtil.WriteLog(string.Format("[DB Error] uspAddTrade({0}/{1}/{2}/{3}), rv({4})", (object)int32_1, (object)int32_2, (object)int64_1, (object)int64_2, (object)int32_3), "WARN");
                        return int32_3;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspAddTrade Exception : {0}", (object)ex.ToString()), "ERROR");
                    return 1;
                }
            }
            WorldMarketLog.logCommand(WorldMarketLog.CommandReasonType.eCommandType_AddTrade, CommonModule.GetCustomTime(), (long)int32_1, (long)int32_2, int64_1, int64_2);
            return 0;
        }

        private delegate int CommandDelation(List<string> argumentList);
    }
}
