// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Controllers.BaseController
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using System.Web.Mvc;

namespace GB.BlackDesert.Trade.Web.Game.Controllers
{
    public class BaseController : Controller
    {
        public AuthenticationInfo _userinfo = AuthenticateManager.GetAuthInfo();
        private bool _isPakageCheck = CommonModule.CheckPakage();
    }
}
