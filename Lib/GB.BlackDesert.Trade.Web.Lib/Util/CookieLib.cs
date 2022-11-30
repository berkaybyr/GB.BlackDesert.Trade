// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.CookieLib
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using System.Web;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public static class CookieLib
    {
        public static void SaveCookie(string cookieName, string cookieValue) => HttpContext.Current.Response.Cookies.Add(new HttpCookie(cookieName)
        {
            Domain = ConstantMgr._cookieDomain,
            Value = cookieValue,
            HttpOnly = true
        });

        public static void SetCookie(
          string strCookieDomain,
          string strCookieName,
          string strCookieValue)
        {
            HttpCookie cookie = new HttpCookie(strCookieName);
            cookie.Value = strCookieValue;
            cookie.Path = "/";
            cookie.Domain = strCookieDomain;
            cookie.Expires = CommonModule.GetCustomTime().AddMinutes((double)ConstantMgr._authenticationTimeOut);
            if (ConstantMgr._useCookieProtect)
            {
                cookie.HttpOnly = true;
                cookie.Secure = true;
            }
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static string GetCookie(string _cookieName)
        {
            string empty = string.Empty;
            if (HttpContext.Current.Request.Cookies[_cookieName] != null)
                empty = HttpContext.Current.Request.Cookies[_cookieName].Value;
            return empty;
        }

        public static void Delete(string domain, string name)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie == null)
                return;
            cookie.Expires = CommonModule.GetCustomTime().AddYears(-1);
            cookie.Value = (string)null;
            cookie.Path = "/";
            cookie.Domain = domain;
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static void ChangeCookie(string domain, string name, string value)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                cookie.Value = value;
                cookie.Path = "/";
                cookie.Domain = domain;
                cookie.Expires = CommonModule.GetCustomTime().AddMinutes((double)ConstantMgr._authenticationTimeOut);
                if (ConstantMgr._useCookieProtect)
                {
                    cookie.HttpOnly = true;
                    cookie.Secure = true;
                }
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            else
                CookieLib.SetCookie(domain, name, value);
        }
    }
}
