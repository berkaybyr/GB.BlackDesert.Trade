// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Controllers.BaseController
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using Microsoft.AspNetCore.Mvc;

namespace GB.BlackDesert.Trade.Web.Api.Controllers
{
    public class BaseController : Controller
    {
        public AuthenticationInfo _userinfo = AuthenticateManager.GetAuthInfo();

        public UserInfomationModel AuthUserInfo
        {
            get
            {
                UserInfomationModel userInfo = (UserInfomationModel)null;
                try
                {
                    if (this._userinfo == null)
                        return new UserInfomationModel();
                    if (TradeModule.CheckAuthKey(ref userInfo, this._userinfo.accountNo, this._userinfo.certifiedKey).resultCode != 0)
                        userInfo = new UserInfomationModel();
                }
                catch (Exception ex)
                {
                    userInfo = new UserInfomationModel();
                }
                return userInfo;
            }
        }
    }
}
