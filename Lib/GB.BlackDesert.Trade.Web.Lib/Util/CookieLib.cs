﻿// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.CookieLib
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public static class CookieLib
    {
        public static void SaveCookie(string cookieName, string cookieValue)
        {
            ContextAccess.Current.Response.Cookies.Append(cookieName, cookieValue, new CookieOptions
            {
                Domain = ConstantMgr._cookieDomain,
                HttpOnly = true,
                IsEssential = true,

            });
        }

        public static void SetCookie(
          string strCookieDomain,
          string strCookieName,
          string strCookieValue)
        {

            ContextAccess.Current.Response.Cookies.Append(strCookieName, strCookieValue, new CookieOptions
            {
                Domain = strCookieDomain,
                Path = "/",
                Expires = CommonModule.GetCustomTime().AddMinutes((double)ConstantMgr._authenticationTimeOut),
                HttpOnly = ConstantMgr._useCookieProtect,
                Secure = ConstantMgr._useCookieProtect
            });
        }

        public static string GetCookie(string _cookieName)
        {
            try
            {
                var empty = string.Empty;
                var cookies = ContextAccess.Current.Request.Cookies[_cookieName];
                if (cookies is null || cookies.Length == 0)
                    empty = ContextAccess.Current.Request.Cookies[_cookieName].ToString();
                return empty;
            }
            catch(Exception ex)
            {
                LogUtil.WriteLog("[Cookie Exception] HttpContext Exception: " + ex,"WARN");
                return string.Empty;
            }
        }

        public static void Delete(string domain, string name)
        {

            ContextAccess.Current.Response.Cookies.Delete(name, new CookieOptions
            {
                Domain = domain,
                Path = "/",
                Expires = CommonModule.GetCustomTime().AddYears(-1),
            });
        }

        public static void ChangeCookie(string domain, string name, string value)
        {
            Delete(domain, name);
            SetCookie(domain, name, value);
        }
    }
}
