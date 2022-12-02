using BlackDesert.TradeMarket.Application.Manager;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
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
            _familySkillList = new Dictionary<int, int>();
            _isOpen = false;
        }

        public static FamilySkillManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new FamilySkillManager();
                }
            }
            return _singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
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
                                LogUtil.WriteLog(string.Format("FamilySkillManager fail read Attribute - {0}", ex.ToString()), "ERROR");
                                return -1;
                            }
                            if (!_familySkillList.ContainsKey(key))
                                _familySkillList.Add(key, num);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("FamilySkillManager fail load xml - {0}", ex.ToString()), "ERROR");
                    return -1;
                }
                _isOpen = true;
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
                if (_familySkillList.TryGetValue(familySkillList[index].C_skillNo, out num))
                    rateByFamilySkill += num;
            }
            return rateByFamilySkill;
        }
    }
}
