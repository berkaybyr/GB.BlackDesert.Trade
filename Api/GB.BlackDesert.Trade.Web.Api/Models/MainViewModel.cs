// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Models.MainViewModel
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

namespace GB.BlackDesert.Trade.Web.Api.Models
{
    public class MainViewModel
    {
        public string userNickName { get; set; }

        public Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>> categoryList { get; set; }

        public bool _secondPwdPass { get; set; }

        public MainViewModel() => this.categoryList = new Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>>();
    }
}
