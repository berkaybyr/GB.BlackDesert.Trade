using BlackDesert.TradeMarket.Lib.Models;
using BlackDesert.TradeMarket.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackDesert.TradeMarket.Application.Xml
{
    public static class Xml_ItemMarketTickCount
    {
        public static Dictionary<int,int> Read(ServerType serverType)
        {
            var dic = new Dictionary<int, int>();
            try
            {
                var xmlFile = CommonModule.GetXmlFile("/" + ConstantMgr._serviceProject + "WorldTradeMarketItemData/" + ConstantMgr._serviceType, "ItemMarketTickCount.xml", serverType);
                while (xmlFile.Read())
                {
                    if (xmlFile.Name.CompareTo("ItemMarketTickCount") == 0 && XmlNodeType.Element == xmlFile.NodeType && xmlFile.MoveToFirstAttribute())
                    {
                        int key = 0;
                        int num = 0;
                        do
                        {
                            string name = xmlFile.Name;
                            if (name.CompareTo("MainGroupNo") == 0)
                                key = Convert.ToInt32(xmlFile.Value);
                            else if (name.CompareTo("NeedTickForUpdate") == 0)
                                num = Convert.ToInt32(xmlFile.Value);
                        }
                        while (xmlFile.MoveToNextAttribute());
                        dic.Add(key, num);
                        //_mainGroupList.Add(key);
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("Xml_ItemMarketTickCount Load XML Fail Exception=" + ex.ToString(), "ERROR");
            }
            return dic;
        }
    }
}
