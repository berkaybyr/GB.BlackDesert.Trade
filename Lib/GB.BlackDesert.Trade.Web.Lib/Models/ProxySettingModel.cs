// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.ProxySettingModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class ProxySettingModel
    {
        public bool _useProxy { get; set; }

        public string _proxyUrl { get; set; }

        public int _proxyPort { get; set; }

        public bool _useTls12 { get; set; }

        public ProxySettingModel()
        {
            this._useProxy = false;
            this._proxyUrl = string.Empty;
            this._proxyPort = 0;
            this._useTls12 = false;
        }

        public ProxySettingModel(bool _useProxy, string _proxyUrl, int _proxyPort, bool _useTls12)
        {
            this._useProxy = _useProxy;
            this._proxyUrl = _proxyUrl;
            this._proxyPort = _proxyPort;
            this._useTls12 = _useTls12;
        }
    }
}
