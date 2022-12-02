// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.FamilySkillManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class FamilySkillManager
    {
        private static volatile FamilySkillManager _singleton;
        private static object _locker = new object();
        private Dictionary<int, int> _familySkillList;
        private bool _isOpen;
        private const string _managerName = "FamilySkillManager";

        public FamilySkillManager()
        {
            this._familySkillList = new Dictionary<int, int>();
            this._isOpen = false;
        }

        public static FamilySkillManager This()
        {
            if (FamilySkillManager._singleton == null)
            {
                lock (FamilySkillManager._locker)
                {
                    if (FamilySkillManager._singleton == null)
                        FamilySkillManager._singleton = new FamilySkillManager();
                }
            }
            return FamilySkillManager._singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (FamilySkillManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(FamilySkillManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(FamilySkillManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("", "WorldTradeMarketFamilySkill.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("FamilySkill") == 0 && XmlNodeType.Element == xmlFile.NodeType)
                        {
                            int key = 0;
                            int num = 0;
                            try
                            {
                                if (xmlFile.MoveToFirstAttribute())
                                {
                                    do
                                    {
                                        string name = xmlFile.Name;
                                        if (name.CompareTo("FamilySkillKey") == 0)
                                            key = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("TaxDiscountRate") == 0)
                                            num = Convert.ToInt32(xmlFile.Value);
                                    }
                                    while (xmlFile.MoveToNextAttribute());
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("FamilySkillManager fail read Attribute - {0}", (object)ex.ToString()), "ERROR");
                                return -1;
                            }
                            if (!this._familySkillList.ContainsKey(key))
                                this._familySkillList.Add(key, num);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("FamilySkillManager fail load xml - {0}", (object)ex.ToString()), "ERROR");
                    return -1;
                }
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(FamilySkillManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int getAddTaxDiscountRateByFamilySkill(
          List<uspFamilySKillListFromWorldMarket_Result> familySkillList)
        {
            int rateByFamilySkill = 0;
            int num = 0;
            int count = familySkillList.Count;
            for (int index = 0; index < count; ++index)
            {
                if (this._familySkillList.TryGetValue(familySkillList[index].C_skillNo, out num))
                    rateByFamilySkill += num;
            }
            return rateByFamilySkill;
        }
    }
}
