// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.CommonModule
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Manager.Auth;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity.Core.Objects;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Remoting.Contexts;

namespace GB.BlackDesert.Trade.Web.Lib.Common
{
    public static class CommonModule
    {
        public const string HTTP_REQUEST_METHOD_GET = "GET";
        public const string HTTP_REQUEST_METHOD_DELETE = "DELETE";
        public const string HTTP_REQUEST_METHOD_POST = "POST";
        public const string HTTP_REQUEST_METHOD_PUT = "PUT";
        public const string HTTP_CONTENTS_TYPE_URL_ENC = "application/x-www-form-urlencoded";
        public const string HTTP_CONTENTS_TYPE_JSON = "text/json";
        public const string HTTP_CONTENTS_APP_TYPE_JSON = "application/json";

        public static string SerializeObjectToJsonString<T>(T deserializeObject) => JsonConvert.SerializeObject(deserializeObject);

        public static T DeserializeOjectToJson<T>(string serializeObject) => JsonConvert.DeserializeObject<T>(serializeObject);

        public static string SerializeObjectToQueryString<T>(T deserializeObject)
        {
            string empty = string.Empty;
            return string.Join("&", ((IEnumerable<PropertyInfo>)deserializeObject.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>)(param => param.GetValue((object)(T)deserializeObject, (object[])null) != null)).Select<PropertyInfo, string>((Func<PropertyInfo, string>)(param => param.Name + "=" + WebUtility.UrlEncode(param.GetValue((object)(T)deserializeObject, (object[])null).ToString()))).ToArray<string>());
        }

        public static string GetResourceValue(string _resKey)
        {
            string culture1 = CommonModule.getDefaultCulture();
            //string culture1 = CommonModule.GetCulture();
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string resourceValue;
            try
            {
                bool flag = string.IsNullOrEmpty(culture1);
                if (flag.Equals(false) && culture1.ToUpper().Equals("KEY"))
                    return _resKey;
                flag = string.IsNullOrEmpty(culture1);
                CultureInfo culture2 = !flag.Equals(false) ? new CultureInfo(CommonModule.getBrowserCulture()) : new CultureInfo(culture1);
                string classKey = "Resources";
                //object obj = (ContextAccess.Current.GetGlobalResourceObject(classKey, _resKey, culture2) ?? ContextAccess.Current.GetGlobalResourceObject(classKey, "TRADE_MARKET_WEB_ERROR_" + _resKey, culture2)) ?? ContextAccess.Current.GetGlobalResourceObject(classKey, "TRADE_MARKET_GAME_ERROR_" + _resKey, culture2);
                object obj = null;
                resourceValue = obj != null ? obj.ToString() : _resKey;
            }
            catch (Exception ex)
            {
                resourceValue = _resKey;
                LogUtil.WriteLog("GetResourceValue Exception Error " + ex.ToString(), "ERROR");
            }
            return resourceValue;
        }

        public static string GetCulture(HttpContext context)
        {
            string str = string.Empty;
            try
            {
                if (CookieLib.GetCookie(context , ConstantMgr._cultureCookieName) != null && !string.IsNullOrEmpty(CookieLib.GetCookie(context ,ConstantMgr._cultureCookieName)))
                {
                    str = CookieLib.GetCookie(context, ConstantMgr._cultureCookieName);
                    if (str.IsNotNullOrEmpty() && str.ToUpper().Equals("ES-ES") && ConstantMgr._serviceType.ToUpper().Equals("NA"))
                        str = "es-US";
                }
                if (string.IsNullOrEmpty(str))
                    str = CommonModule.getDefaultCulture();
            }
            catch (Exception ex)
            {
                str = CommonModule.getDefaultCulture();
                LogUtil.WriteLog("getCulture Exception Error " + ex.ToString(), "ERROR");
            }
            return CommonModule.isAccessCulture(str);
        }

        public static string getDefaultCulture()
        {
            string defaultCulture = string.Empty;
            if (ConstantMgr._defaultCulture != null && !string.IsNullOrEmpty(ConstantMgr._defaultCulture))
                defaultCulture = ConstantMgr._defaultCulture;
            return defaultCulture;
        }

        public static string getBrowserCulture()
        {
            return CommonModule.getDefaultCulture();

            //string empty = string.Empty;
            //string browserCulture;
            //try
            //{
            //    string[] userLanguages = ContextAccess.Current.Request.;
            //    if (userLanguages == null || userLanguages.Length == 0)
            //        return CommonModule.getDefaultCulture();
            //    browserCulture = CommonModule.isAccessCulture(CultureInfo.CreateSpecificCulture(userLanguages[0].ToLowerInvariant().Trim()).ToString());
            //}
            //catch (Exception ex)
            //{
            //    browserCulture = CommonModule.getDefaultCulture();
            //    LogUtil.WriteLog(string.Format("Error Occurred. getBrowserCulture {0}", (object)ex.ToString()), "ERROR");
            //}
            //return browserCulture;
        }

        public static string isAccessCulture(string culture)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string str;
            try
            {
                if (new List<string>((IEnumerable<string>)ConstantMgr._cultureList.Split(',')).Contains(culture).Equals(false))
                    return CommonModule.getDefaultCulture();
                str = culture;
            }
            catch (Exception ex)
            {
                str = CommonModule.getDefaultCulture();
                LogUtil.WriteLog(string.Format("Error Occurred. isAccessCulture {0}", (object)ex.ToString()), "ERROR");
            }
            return str;
        }

        public static void SetUserCulture(HttpContext context,string cultureCode)
        {
            string empty = string.Empty;
            try
            {
                if (cultureCode.IsNotNullOrEmpty() && cultureCode.ToUpper().Contains("EN"))
                    cultureCode = "en-US";
                string strCookieValue = CommonModule.isAccessCulture(cultureCode);
                if (CookieLib.GetCookie(context, ConstantMgr._cultureCookieName) != null && string.IsNullOrEmpty(CookieLib.GetCookie(context,ConstantMgr._cultureCookieName)).Equals(false))
                {
                    if (CookieLib.GetCookie(context, ConstantMgr._cultureCookieName).Equals(strCookieValue))
                        return;
                    CookieLib.ChangeCookie(context, ConstantMgr._cookieDomain, ConstantMgr._cultureCookieName, strCookieValue);
                }
                else
                    CookieLib.SetCookie(context, ConstantMgr._cookieDomain, ConstantMgr._cultureCookieName, strCookieValue);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule SetUserCulture Exception Key=" + cultureCode + " Error=" + ex.ToString(), "ERROR");
            }
        }

        public static int HttpRequest(
          string reqUrl,
          string reqParam,
          string httpMethod,
          string httpContentType,
          out string relResult,
          out string errorMsg,
          bool isWriteLog = true)
        {
            relResult = string.Empty;
            errorMsg = string.Empty;
            int num1 = 0;
            byte[] numArray = (byte[])null;
            HttpWebRequest httpWebRequest1 = (HttpWebRequest)null;
            HttpWebResponse httpWebResponse = (HttpWebResponse)null;
            StreamReader streamReader1 = (StreamReader)null;
            int num2 = isWriteLog ? 1 : 0;
            try
            {
                HttpWebRequest httpWebRequest2;
                if (httpMethod.Equals("GET") || httpMethod.Equals("DELETE"))
                {
                    httpWebRequest2 = (HttpWebRequest)WebRequest.Create(string.Format("{0}?{1}", (object)reqUrl, (object)reqParam));
                    httpWebRequest2.Method = httpMethod;
                }
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(reqParam);
                    httpWebRequest2 = (HttpWebRequest)WebRequest.Create(reqUrl);
                    httpWebRequest2.Method = httpMethod;
                    httpWebRequest2.ContentType = httpContentType;
                    httpWebRequest2.ContentLength = (long)bytes.Length;
                    Stream requestStream = httpWebRequest2.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }
                httpWebRequest2.Timeout = 60000;
                HttpWebResponse response = (HttpWebResponse)httpWebRequest2.GetResponse();
                if (!response.StatusCode.Equals((object)HttpStatusCode.OK) && !response.StatusCode.Equals((object)HttpStatusCode.Created) && !response.StatusCode.Equals((object)HttpStatusCode.Accepted))
                {
                    num1 = -10005;
                    errorMsg = "Http Request Error.";
                }
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader2 = new StreamReader(responseStream, Encoding.Default);
                relResult = streamReader2.ReadToEnd();
                responseStream.Close();
            }
            catch (Exception ex)
            {
                num1 = -9999;
                errorMsg = ex.ToString();
            }
            finally
            {
                numArray = (byte[])null;
                httpWebRequest1 = (HttpWebRequest)null;
                httpWebResponse = (HttpWebResponse)null;
                streamReader1 = (StreamReader)null;
            }
            return num1;
        }

        public static int HttpRequestForAuth(
          string reqUrl,
          string reqParam,
          string httpMethod,
          string httpContentType,
          out string relResult,
          out string errorMsg,
          bool useProxy = false)
        {
            relResult = string.Empty;
            errorMsg = string.Empty;
            int num = 0;
            byte[] numArray = (byte[])null;
            HttpWebRequest httpWebRequest1 = (HttpWebRequest)null;
            HttpWebResponse httpWebResponse = (HttpWebResponse)null;
            StreamReader streamReader1 = (StreamReader)null;
            try
            {
                HttpWebRequest httpWebRequest2;
                if (httpMethod.Equals("GET") || httpMethod.Equals("DELETE"))
                {
                    httpWebRequest2 = (HttpWebRequest)WebRequest.Create(string.Format("{0}?{1}", (object)reqUrl, (object)reqParam));
                    httpWebRequest2.Method = httpMethod;
                   
                }
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(reqParam);
                    httpWebRequest2 = (HttpWebRequest)WebRequest.Create(reqUrl);
                    httpWebRequest2.Method = httpMethod;
                    httpWebRequest2.ContentType = httpContentType;
                    httpWebRequest2.ContentLength = (long)reqParam.Length;
                    
                    Stream requestStream = httpWebRequest2.GetRequestStream();
                    requestStream.Write(bytes, 0, reqParam.Length);
                    requestStream.Close();
                }
                httpWebRequest2.Timeout = 60000;
                HttpWebResponse response = (HttpWebResponse)httpWebRequest2.GetResponse();
                if (!response.StatusCode.Equals((object)HttpStatusCode.OK) && !response.StatusCode.Equals((object)HttpStatusCode.Created) && !response.StatusCode.Equals((object)HttpStatusCode.Accepted))
                {
                    num = -10005;
                    errorMsg = "Http Request Error.";
                }
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader2 = new StreamReader(responseStream, Encoding.UTF8);
                relResult = streamReader2.ReadToEnd();
                responseStream.Close();
            }
            catch (Exception ex)
            {
                num = -9999;
                errorMsg = ex.ToString();
            }
            finally
            {
                numArray = (byte[])null;
                httpWebRequest1 = (HttpWebRequest)null;
                httpWebResponse = (HttpWebResponse)null;
                streamReader1 = (StreamReader)null;
            }
            return num;
        }

        public static async Task<int> HttpRequestAsync(
          string reqUrl,
          string reqParam,
          string httpMethod,
          string httpContentType,
          bool useProxy = false,
          bool isWriteLog = true)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            int _resultCode = 0;
            string empty3 = string.Empty;
            HttpWebRequest _wRequest = (HttpWebRequest)null;
            WebProxy _wProxy = (WebProxy)null;
            Stream _reqDataStream = (Stream)null;
            HttpWebResponse _wResponse = (HttpWebResponse)null;
            try
            {
                LogUtil.WriteLog("\r\n\r\n=============================== HttpRequest Start ================================\r\n\r\n", "DEBUG");
                LogUtil.WriteLog("HttpRequest reqUrl=" + reqUrl, "DEBUG");
                LogUtil.WriteLog("HttpRequest httpMethod=" + httpMethod, "DEBUG");
                LogUtil.WriteLog("HttpRequest reqParam=" + reqParam, "DEBUG");
                LogUtil.WriteLog("HttpRequest httpContentType=" + httpContentType, "DEBUG");
                LogUtil.WriteLog("\r\n\r\n=============================== HttpRequest End ================================\r\n\r\n", "DEBUG");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.DefaultConnectionLimit = 99999;
                ServicePointManager.Expect100Continue = true;
                if (httpMethod.Equals("GET") || httpMethod.Equals("DELETE"))
                {
                    _wRequest = (HttpWebRequest)WebRequest.Create(reqUrl + "?" + reqParam);
                    _wRequest.Method = httpMethod;
                    _wRequest.KeepAlive = false;
                    
                }
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(reqParam);
                    _wRequest = (HttpWebRequest)WebRequest.Create(reqUrl);
                    _wRequest.ReadWriteTimeout = 10000;
                    _wRequest.Method = httpMethod;
                    _wRequest.ContentType = httpContentType;
                    _wRequest.ContentLength = (long)bytes.Length;
                    _wRequest.KeepAlive = false;
                   
                    _reqDataStream = _wRequest.GetRequestStream();
                    _reqDataStream.Write(bytes, 0, bytes.Length);
                }
                _wRequest.Timeout = 10000;
                _wResponse = (HttpWebResponse)await _wRequest.GetResponseAsync();
            }
            catch (WebException ex)
            {
                _resultCode = -99970;
                ex.ToString();
                LogUtil.WriteLog("GetWebRequest WebException ReqURL=" + reqUrl + " ReqMethod=" + httpMethod + " ReqParam=" + reqParam + " Error=" + ex.ToString(), "HTTPREQ_ERROR");
                foreach (string allKey in ex.Response.Headers.AllKeys)
                    LogUtil.WriteLog("GetWebRequest WebException Headers Key=" + allKey + " Value=" + ex.Response.Headers[allKey], "HTTPREQ_ERROR");
                LogUtil.WriteLog("GetWebRequest WebException Body=" + new StreamReader(ex.Response.GetResponseStream(), Encoding.Default).ReadToEnd(), "HTTPREQ_ERROR");
            }
            catch (Exception ex)
            {
                _resultCode = -99988;
                ex.ToString();
                LogUtil.WriteLog("GetWebRequest Exception ReqURL=" + reqUrl + " ReqMethod=" + httpMethod + " ReqParam=" + reqParam + " Error=" + ex.ToString(), "HTTPREQ_ERROR");
            }
            finally
            {
                if (_wRequest != null)
                    _wRequest = (HttpWebRequest)null;
                if (_wProxy != null)
                    _wProxy = (WebProxy)null;
                if (_reqDataStream != null)
                {
                    _reqDataStream.Close();
                    _reqDataStream.Dispose();
                    _reqDataStream = (Stream)null;
                }
                if (_wResponse != null)
                {
                    _wResponse.Close();
                    _wResponse.Dispose();
                    _wResponse = (HttpWebResponse)null;
                }
            }
            return _resultCode;
        }

        public static string GetRemoteIP(HttpContext context)
        {
            string remoteIp = string.Empty;
            try
            {
                if (context.Request.Headers["X-Forwarded-For"].ToString() != null && !string.IsNullOrEmpty(context.Request.Headers["X-Forwarded-For"].ToString().Trim()))
                {
                    remoteIp = context.Request.Headers["X-Forwarded-For"];
                    if (remoteIp.IndexOf(",") > 0)
                        remoteIp = remoteIp.Split(',')[0];
                }
                //if (ContextAccess.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && string.IsNullOrEmpty(remoteIp) && !string.IsNullOrEmpty(ContextAccess.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Trim()))
                //{
                //    remoteIp = ContextAccess.Current.Request.Headers["HTTP_X_FORWARDED_FOR"];
                //    if (remoteIp.IndexOf(",") > 0)
                //        remoteIp = remoteIp.Split(',')[0];
                //}
                //if (ContextAccess.Current.Request.Headers["X-PA-IP"] != null && string.IsNullOrEmpty(remoteIp) && !string.IsNullOrEmpty(ContextAccess.Current.Request.Headers["X-PA-IP"].ToString().Trim()))
                //    remoteIp = ContextAccess.Current.Request.Headers["X-PA-IP"];
                //if (ContextAccess.Current..ServerVariables["REMOTE_ADDR"] != null && string.IsNullOrEmpty(remoteIp) && !string.IsNullOrEmpty(ContextAccess.Current.Request.ServerVariables["REMOTE_ADDR"].Trim()))
                //    remoteIp = ContextAccess.Current.Request.ServerVariables["REMOTE_ADDR"];
                //if (string.IsNullOrEmpty(remoteIp))
                //    remoteIp = ContextAccess.Current.Request.UserHostAddress;
            }
            catch (Exception ex)
            {
                remoteIp = string.Empty;
            }
            finally
            {
                if (-1 < remoteIp.IndexOf(':'))
                    remoteIp = remoteIp.Split(':')[0].ToString();
                if (-1 < remoteIp.IndexOf(','))
                    remoteIp = remoteIp.Split(',')[0].ToString();
            }
            return remoteIp;
        }

        public static DateTime GetCustomTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            return utcNow;
            //TODO: Check later already using UTC timezone doesnt really matter
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Utc.StandardName), ConstantMgr._isServerTime ? TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id) : TimeZoneInfo.FindSystemTimeZoneById(ConstantMgr._utcTimeZoneID));
        }

        public static long ConvertUnixTime(DateTime date) => (long)(date - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;

        public static long ConvertUnixTimeMs(DateTime date) => (long)(date - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;

        public static XmlReader GetXmlFile(
          string folder,
          string fileName,
          ServerType serverType)
        {
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            XmlReader xmlFile = (XmlReader)null;
            XmlReaderSettings settings = (XmlReaderSettings)null;
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                folder = string.IsNullOrEmpty(folder) ? "/" : folder + "/";
                xmlFile = XmlReader.Create(ConstantMgr._xmlContentsLocalPath + folder + ConstantMgr._serviceProject + fileName, settings);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule GetXmlFile Exception=" + ex.ToString(), "ERROR");
            }
            return xmlFile;
        }

        public static bool CheckAllowIPAccess(string ipAddress)
        {
            bool flag = false;
            List<string> stringList = new List<string>();
            ipAddress = ipAddress.Split(',')[0].Split(':')[0];
            try
            {
                if (string.IsNullOrEmpty(ConstantMgr._allowIPList))
                    return flag;
                stringList.AddRange((IEnumerable<string>)ConstantMgr._allowIPList.Split('|'));
                if (stringList.Contains(ipAddress))
                    return true;
                foreach (string str in stringList)
                {
                    if (str.Split('.')[3].Equals("*"))
                    {
                        if (ipAddress.IndexOf(str.Split('.')[0] + "." + str.Split('.')[1] + "." + str.Split('.')[2] + ".") > -1)
                        {
                            flag = true;
                            return flag;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                flag = false;
                LogUtil.WriteLog("CommonModule CheckInternalUserAccess Exception Error=" + ex.ToString(), "ERROR");
            }
            return flag;
        }
        public static bool IsMobile(HttpContext context)
        {
            bool isMobile = false;
            string serverVariable = context.Request.Headers["User-Agent"];
            Regex regex1 = new Regex("(android|bb\\d+|meego).+mobile|avantgo|bada\\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex regex2 = new Regex("1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\\-(n|u)|c55\\/|capi|ccwa|cdm\\-|cell|chtm|cldc|cmd\\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\\-s|devi|dica|dmob|do(c|p)o|ds(12|\\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\\-|_)|g1 u|g560|gene|gf\\-5|g\\-mo|go(\\.w|od)|gr(ad|un)|haie|hcit|hd\\-(m|p|t)|hei\\-|hi(pt|ta)|hp( i|ip)|hs\\-c|ht(c(\\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\\-(20|go|ma)|i230|iac( |\\-|\\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\\/)|klon|kpt |kwc\\-|kyo(c|k)|le(no|xi)|lg( g|\\/(k|l|u)|50|54|\\-[a-w])|libw|lynx|m1\\-w|m3ga|m50\\/|ma(te|ui|xo)|mc(01|21|ca)|m\\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\\-2|po(ck|rt|se)|prox|psio|pt\\-g|qa\\-a|qc(07|12|21|32|60|\\-[2-7]|i\\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\\-|oo|p\\-)|sdk\\/|se(c(\\-|0|1)|47|mc|nd|ri)|sgh\\-|shar|sie(\\-|m)|sk\\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\\-|v\\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\\-|tdg\\-|tel(i|m)|tim\\-|t\\-mo|to(pl|sh)|ts(70|m\\-|m3|m5)|tx\\-9|up(\\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\\-|your|zeto|zte\\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex regex3 = new Regex("android|tablet|ipad|playbook|bb10|z30|nexus 10|nexus 7|gt-p|sch-i800|xoom|kindle|silk|kfapwi|pearlApp", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string input = serverVariable;
            if (regex1.IsMatch(input) || regex2.IsMatch(serverVariable.Substring(0, 4)) || regex3.IsMatch(serverVariable))
                isMobile = true;
            return isMobile;
        }
        
        public static bool IsPealApp(HttpContext context)
        {
            bool isPearlApp = false;
            if (new Regex("pearlApp", RegexOptions.IgnoreCase | RegexOptions.Multiline).IsMatch(context.Request.Headers["User-Agent"]))
                isPearlApp = true;
            return isPearlApp;
        } 
      
        public static bool IsAllowBrowser(this HttpContext context)
        {
            var agent = context.GetAgentInfo();
            List<string> list = ((IEnumerable<string>)ConstantMgr._allowBrowserList.Split('|')).ToList<string>();
            if (list == null || list.Count < 1 || agent == null)
                return false;
            string str1 = agent[0];
            foreach (string str2 in list)
            {
                if (str1.ToUpper().Equals(str2.ToUpper()))
                    return true;
            }
            return false;
        }
    

        public static string GetCultureCode(string languageType)
        {
            string cultureCode = string.Empty;
            try
            {
                switch (languageType.ToLower())
                {
                    case "ar-ae":
                        cultureCode = "AE";
                        break;
                    case "de-de":
                        cultureCode = "DE";
                        break;
                    case "en-us":
                        cultureCode = "EN";
                        break;
                    case "es-es":
                        cultureCode = !ConstantMgr._serviceType.ToUpper().Equals("NA") ? "ES" : "SP";
                        break;
                    case "es-us":
                        cultureCode = "SP";
                        break;
                    case "fr-fr":
                        cultureCode = "FR";
                        break;
                    case "id-id":
                        cultureCode = "ID";
                        break;
                    case "ja-jp":
                        cultureCode = "JP";
                        break;
                    case "ko-kr":
                        cultureCode = "KR";
                        break;
                    case "pt-pt":
                        cultureCode = "PT";
                        break;
                    case "ru-ru":
                        cultureCode = "RU";
                        break;
                    case "th-th":
                        cultureCode = "TH";
                        break;
                    case "tr-tr":
                        cultureCode = "TR";
                        break;
                    case "zh-cn":
                        cultureCode = "CH";
                        break;
                    case "zh-tw":
                        cultureCode = "TW";
                        break;
                    default:
                        cultureCode = "KR";
                        break;
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule GetLanguageCode Exception=" + ex.ToString(), "ERROR");
            }
            return cultureCode;
        }
        public static List<string> GetAgentInfo(this HttpContext context)
        {
            string lower = context.Request.Headers["User-Agent"].ToString().ToLower();
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            List<string> agentInfo = new List<string>();
            try
            {
                string str1 = lower.Contains("trident") || lower.Contains("msie") ? "IE" : (!lower.Contains("samsungbrowser") ? (!lower.Contains("miui") ? (!lower.Contains("edge") ? (!lower.Contains("naver") ? (!lower.Contains("daum") ? (lower.Contains("opr/") || lower.Contains("opera") ? "Opera" : (!lower.Contains("chrome/") || !lower.Contains("like gecko") ? (!lower.Contains("safari") ? (!lower.Contains("firefox") ? (!lower.Contains("android") ? (lower.Contains("ipad") || lower.Contains("ipd") || lower.Contains("iphone") ? "IOS Browser" : "ETC Browser") : "Android Browser") : "FireFox") : "Safari") : "Chrome")) : "Daum") : "Naver") : "Edge") : "XiaomiBrowser") : "SamusngBrowser");
                string str2 = !lower.Contains("windows nt 5.1") ? (!lower.Contains("windows nt 6.0") ? (!lower.Contains("windows nt 6.1") ? (!lower.Contains("windows nt 6.2") ? (!lower.Contains("windows nt 6.3") ? (!lower.Contains("windows nt 10.0") ? (!lower.Contains("windows phone 8.1") ? (!lower.Contains("windows phone 10.0") ? (!lower.Contains("android") ? (!lower.Contains("blackberry") ? (!lower.Contains("iphone") ? (!lower.Contains("ipad") ? (!lower.Contains("ipod") ? (!lower.Contains("mac") ? (!lower.Contains("x11") ? (!lower.Contains("tizen") ? "Undefined OS" : "Tizen") : "Linux(X Windows)") : "Mac") : "ipod") : "ipad") : "iphone") : "blackberryOS") : "Android") : "Win phone 10") : "Win phone 8.1") : "Win 10") : "Win 8.1") : "Win 8") : "Win 7") : "Win Vista") : "Win XP";
                agentInfo.Add(str1);
                agentInfo.Add(str2);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule AgentInfo Exception=" + ex.ToString(), "ERROR");
            }
            return agentInfo;
        }

        public static string GetItemString(string itemName, int _subKey)
        {
            string itemString = string.Empty;
            try
            {
                switch (_subKey)
                {
                    case 0:
                        itemString = itemName ?? "";
                        break;
                    case 1:
                        itemString = CommonModule.GetResourceValue("TRADE_MARKET_ITEM_DEAD_ONE") + " " + itemName;
                        break;
                    case 2:
                        itemString = CommonModule.GetResourceValue("TRADE_MARKET_ITEM_DEAD_TWO") + " " + itemName;
                        break;
                    case 3:
                        itemString = CommonModule.GetResourceValue("TRADE_MARKET_ITEM_DEAD_THREE") + " " + itemName;
                        break;
                    case 4:
                        itemString = CommonModule.GetResourceValue("TRADE_MARKET_ITEM_DEAD_FOUR") + " " + itemName;
                        break;
                    case 5:
                        itemString = CommonModule.GetResourceValue("TRADE_MARKET_ITEM_DEAD_FIVE") + " " + itemName;
                        break;
                }
                if (!itemString.Contains("TRADE_MARKET_ITEM_DEAD_ONE") && !itemString.Contains("TRADE_MARKET_ITEM_DEAD_TWO") && !itemString.Contains("TRADE_MARKET_ITEM_DEAD_THREE") && !itemString.Contains("TRADE_MARKET_ITEM_DEAD_FOUR"))
                {
                    if (!itemString.Contains("TRADE_MARKET_ITEM_DEAD_FIVE"))
                        goto label_12;
                }
                itemString = itemName;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule GetItemString Exception=" + ex.ToString(), "ERROR");
                return itemName;
            }
        label_12:
            return itemString;
        }

        public static string GetRandomString(int length = 16)
        {
            string _charList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            Random _random = new Random(DateTime.UtcNow.Millisecond);
            return new string(Enumerable.Range(0, length).Select<int, char>((Func<int, char>)(x => _charList[_random.Next(0, _charList.Length)])).ToArray<char>());
        }

        public static HttpRequestResult HttpRequest(
          HttpRequestModel requestData)
        {
            HttpRequestResult httpRequestResult = new HttpRequestResult();
            byte[] numArray = (byte[])null;
            HttpWebRequest httpWebRequest1 = (HttpWebRequest)null;
            HttpWebResponse httpWebResponse = (HttpWebResponse)null;
            Stream stream = (Stream)null;
            StreamReader streamReader1 = (StreamReader)null;
            try
            {
                if (requestData._useExpect100Continue)
                    ServicePointManager.Expect100Continue = true;
                HttpWebRequest httpWebRequest2;
                if (requestData._requestMethod.Equals("GET") || requestData._requestMethod.Equals("DELETE"))
                {
                    httpWebRequest2 = (HttpWebRequest)WebRequest.Create(requestData._requestUrl + "?" + requestData._requestParam);
                    httpWebRequest2.Method = requestData._requestMethod;
                    if (requestData._accept.IsNotNullOrEmpty())
                        httpWebRequest2.Accept = requestData._accept;
                    if (requestData._reqHeaders != null)
                    {
                        foreach (string allKey in requestData._reqHeaders.AllKeys)
                            httpWebRequest2.Headers.Add(allKey, requestData._reqHeaders[allKey]);
                    }
                    if (requestData._useCertificate)
                        httpWebRequest2.ClientCertificates.Add((X509Certificate)requestData._wCertification);
                }
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(requestData._requestParam);
                    httpWebRequest2 = (HttpWebRequest)WebRequest.Create(requestData._requestUrl);
                    httpWebRequest2.Method = requestData._requestMethod;
                    httpWebRequest2.ContentType = requestData._requesetContentType;
                    httpWebRequest2.ContentLength = (long)bytes.Length;
                    if (requestData._reqHeaders != null)
                    {
                        foreach (string allKey in requestData._reqHeaders.AllKeys)
                            httpWebRequest2.Headers.Add(allKey, requestData._reqHeaders[allKey]);
                    }
                    if (requestData._useCertificate)
                        httpWebRequest2.ClientCertificates.Add((X509Certificate)requestData._wCertification);
                    Stream requestStream = httpWebRequest2.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }
                httpWebRequest2.Timeout = 60000;
                HttpWebResponse response = (HttpWebResponse)httpWebRequest2.GetResponse();
                if (!response.StatusCode.Equals((object)HttpStatusCode.OK))
                {
                    HttpStatusCode statusCode = response.StatusCode;
                    if (!statusCode.Equals((object)HttpStatusCode.Created))
                    {
                        statusCode = response.StatusCode;
                        if (!statusCode.Equals((object)HttpStatusCode.Accepted))
                        {
                            httpRequestResult._resultCode = -10005;
                            httpRequestResult._resultMsg = string.Format("GetResponse HttpWebStatus Error {0}", (object)response.StatusCode);
                        }
                    }
                }
                Stream responseStream = response.GetResponseStream();
                StreamReader streamReader2 = !"utf-8".Equals(requestData._encodingType, StringComparison.OrdinalIgnoreCase) ? new StreamReader(responseStream, Encoding.Default) : new StreamReader(responseStream, Encoding.UTF8);
                httpRequestResult._resultData = streamReader2.ReadToEnd();
                responseStream.Close();
            }
            catch (Exception ex)
            {
                httpRequestResult._resultCode = -99998;
                httpRequestResult._resultMsg = ex.ToString();
                LogUtil.WriteLog("[HttpRequestManager][HttpRequest][Exception] Exception : " + ex.ToString() + " , Param => " + CommonModule.SerializeObjectToJsonString<HttpRequestModel>(requestData), "ERROR");
            }
            finally
            {
                httpWebRequest1 = (HttpWebRequest)null;
                numArray = (byte[])null;
                httpWebResponse = (HttpWebResponse)null;
                stream = (Stream)null;
                streamReader1 = (StreamReader)null;
                if (requestData._reqHeaders != null)
                {
                    foreach (string allKey in requestData._reqHeaders.AllKeys)
                        ;
                }
            }
            return httpRequestResult;
        }

        public static bool CheckPakage(HttpContext context)
        {
            int num = 0;
            bool flag = false;
            string empty = string.Empty;
            try
            {
                AuthenticationInfo authInfo = AuthenticateManager.GetAuthInfo(context);
                DateTime customTime = CommonModule.GetCustomTime(new CustomTimeModel()
                {
                    useServerTime = false,
                    utcTimeZoneID = TimeZoneInfo.Utc.StandardName
                });
                if (authInfo.IsNull<AuthenticationInfo>())
                    return false;
                PakageAuthInfo pakageInfo = AuthenticateManager.GetPakageInfo(context);
                string checkPakageUrl = ConstantMgr._checkPakageUrl;
                switch (ConstantMgr._serviceType.ToUpper())
                {
                    case "CS":
                        num = 301;
                        break;
                    case "ID":
                        flag = true;
                        num = 105;
                        break;
                    case "JP":
                        num = 107;
                        break;
                    case "KR":
                        num = 101;
                        break;
                    case "NA":
                        flag = true;
                        num = 109;
                        break;
                    case "RU":
                        num = 106;
                        break;
                    case "TH":
                        flag = true;
                        num = 104;
                        break;
                    case "TR":
                        flag = true;
                        num = 103;
                        break;
                    case "TW":
                        flag = true;
                        num = 102;
                        break;
                    default:
                        flag = false;
                        break;
                }
                if (flag.Equals(false) || pakageInfo.IsNotNull() && pakageInfo.pakageExpiration.Equals(DateTime.MaxValue))
                    return false;
                if (pakageInfo.IsNotNull() && pakageInfo.pakageExpiration <= customTime)
                {
                    AuthenticateManager.RemoveAuthTicket(context);
                    return true;
                }
                if (pakageInfo.IsNotNull() && customTime < pakageInfo.pakageExpiration)
                    return false;
                if (authInfo.accountNo <= 0L)
                {
                    AuthenticateManager.RemoveAuthTicket(context);
                    return false;
                }
                CheckPakageParamModel deserializeObject = new CheckPakageParamModel()
                {
                    _accountNo = authInfo.accountNo,
                    _gameCode = num
                };
                HttpRequestResult httpRequestResult = CommonModule.HttpRequest(new HttpRequestModel(checkPakageUrl, CommonModule.SerializeObjectToJsonString<CheckPakageParamModel>(deserializeObject), "POST", "application/json"));
                if (httpRequestResult._resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("CommonModule CheckPakage Requset Fail  response._resultCode : {0}", (object)httpRequestResult._resultCode), "WARN");
                    AuthenticateManager.RemoveAuthTicket(context);
                    return false;
                }
                if (string.IsNullOrEmpty(httpRequestResult._resultData))
                {
                    LogUtil.WriteLog("CommonModule CheckPakage Requset Fail  response._resultData Is NULL", "WARN");
                    AuthenticateManager.RemoveAuthTicket(context);
                    return false;
                }
                CheckPakageResultModel json = CommonModule.DeserializeOjectToJson<CheckPakageResultModel>(httpRequestResult._resultData);
                if (json._result.resultCode.Equals(0).Equals(false) || json._list._accountNo <= 0L)
                {
                    LogUtil.WriteLog("CommonModule CheckPakage Requset Fail : checkPakageResultModel " + CommonModule.SerializeObjectToJsonString<CheckPakageResultModel>(json), "WARN");
                    AuthenticateManager.RemoveAuthTicket(context);
                    return false;
                }
                if (json._list._expireDateUnixTime.IsNullOrEmpty())
                    AuthenticateManager.SetPakageInfo(context, new PakageAuthInfo()
                    {
                        _accountNo = authInfo.accountNo,
                        _gameCode = num,
                        pakageExpiration = DateTime.MaxValue
                    });
                if (json._list._expireDateUnixTime.IsNotNullOrEmpty())
                {
                    if (CommonModule.ConvertUnixTimeStampToDateTime(json._list._expireDateUnixTime) <= customTime)
                        AuthenticateManager.RemoveAuthTicket(context);
                    else
                        AuthenticateManager.SetPakageInfo(context, new PakageAuthInfo()
                        {
                            _accountNo = authInfo.accountNo,
                            _gameCode = num,
                            pakageExpiration = CommonModule.ConvertUnixTimeStampToDateTime(json._list._expireDateUnixTime)
                        });
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule CheckPakage Exception : " + ex.ToString(), "ERROR");
                AuthenticateManager.RemoveAuthTicket(context);
                return false;
            }
            return true;
        }

        public static DateTime ConvertUnixTimeStampToDateTime(string unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(Convert.ToDouble(unixTimeStamp, (IFormatProvider)CultureInfo.InvariantCulture));
            return dateTime;
        }

        public static double ConvertDateTimeToUnixTimeStamp(DateTime dateTime)
        {
            double unixTimeStamp = 0.0;
            if (dateTime.IsNotNull())
                unixTimeStamp = dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            return unixTimeStamp;
        }

        public static DateTime GetCustomTime(CustomTimeModel model)
        {

            DateTime utcNow = DateTime.UtcNow;
            return utcNow;
            //TODO: Check later already using UTC timezone doesnt really matter
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, 
                TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Utc.StandardName), 
                model.useServerTime ? TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id) : 
                TimeZoneInfo.FindSystemTimeZoneById(model.utcTimeZoneID));
        }

        public static CommonResult Otpauth(OtpAuthModel otpAuthModel)
        {
            CommonResult commonResult = (CommonResult)null;
            string empty1 = string.Empty;
            string empty2 = string.Empty;
            string str = "false";
            try
            {
                commonResult = new CommonResult();
                bool flag1 = ConstantMgr._serviceType.ToLower().Equals("kr");
                if (flag1.Equals(false))
                {
                    flag1 = ConstantMgr._serviceType.ToLower().Equals("dev");
                    if (flag1.Equals(false))
                    {
                        commonResult.resultCode = 0;
                        commonResult.resultMsg = string.Empty;
                        return commonResult;
                    }
                }
                string otpAuthUrl = ConstantMgr._otpAuthUrl;
                if (otpAuthUrl.IsNullOrEmpty())
                {
                    LogUtil.WriteLog("CommonModule Otpauth ConstantMgr._otpAuthUrl IS NULL OR EMPTY", "WARN");
                    commonResult.resultCode = -10000;
                    commonResult.resultMsg = string.Empty;
                    return commonResult;
                }
                if (otpAuthModel.userNo <= 0L || otpAuthModel.otpKey.IsNullOrEmpty())
                {
                    LogUtil.WriteLog("CommonModule Otpauth accountNo <= 0 || otpKey.IsNullOrEmpty()", "WARN");
                    commonResult.resultCode = -10001;
                    commonResult.resultMsg = string.Empty;
                    return commonResult;
                }
                using (SA_BETA_WORLDDB_0002 SA_BETA_WORLDDB_0002 = new SA_BETA_WORLDDB_0002())
                {
                    ObjectParameter userId = new ObjectParameter("userId", typeof(string));
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    ObjectParameter resultMsg = new ObjectParameter("resultMsg", typeof(string));
                    SA_BETA_WORLDDB_0002.uspGetUserId(new long?(otpAuthModel.userNo), userId, resultCode, resultMsg);
                    empty2 = userId.Value.ToString();
                    if (Convert.ToInt32(resultCode.Value) != 0)
                        LogUtil.WriteLog(string.Format("[DB Exception] Otpauth - uspGetUserId({0} {1})", (object)Convert.ToInt32(resultCode.Value), (object)Convert.ToString(resultMsg.Value)), "WARN");
                }
                if (Convert.ToInt64(empty2) <= 0L)
                {
                    LogUtil.WriteLog("CommonModule Otpauth Convert.ToInt64(accountNo) <= 0", "WARN");
                    commonResult.resultCode = -10002;
                    commonResult.resultMsg = string.Empty;
                    return commonResult;
                }
                switch (otpAuthModel.otpKey.Length)
                {
                    case 6:
                        str = "false";
                        break;
                    case 8:
                        str = "true";
                        break;
                }
                OtpAuthParamModel deserializeObject = new OtpAuthParamModel()
                {
                    accountNo = Convert.ToInt64(empty2),
                    secret = otpAuthModel.otpKey,
                    isOtpBackupCode = str
                };
                HttpRequestModel requestData = new HttpRequestModel(otpAuthUrl, CommonModule.SerializeObjectToJsonString<OtpAuthParamModel>(deserializeObject), "POST", "application/json");
                WebHeaderCollection headerCollection = new WebHeaderCollection();
                headerCollection.Add("WWW-Authenticate", string.Format("Basic realm=\"{0}\"", (object)"BlackDesert_Web"));
                requestData._reqHeaders = (NameValueCollection)headerCollection;
                HttpRequestResult httpRequestResult = CommonModule.HttpRequest(requestData);
                if (httpRequestResult._resultCode != 0)
                {
                    LogUtil.WriteLog(string.Format("CommonModule Otpauth Requset Fail  response._resultCode : {0}", (object)httpRequestResult._resultCode), "WARN");
                    commonResult.resultCode = -10003;
                    commonResult.resultMsg = string.Empty;
                    return commonResult;
                }
                if (string.IsNullOrEmpty(httpRequestResult._resultData))
                {
                    LogUtil.WriteLog("CommonModule Otpauth Requset Fail  response._resultData Is NULL", "WARN");
                    commonResult.resultCode = -10004;
                    commonResult.resultMsg = string.Empty;
                    return commonResult;
                }
                CommonResultModel json = CommonModule.DeserializeOjectToJson<CommonResultModel>(httpRequestResult._resultData);
                int num = json.resultCode;
                bool flag2 = num.Equals(0);
                if (flag2.Equals(false))
                {
                    commonResult.resultCode = json.resultCode;
                    commonResult.resultMsg = string.Empty;
                    return commonResult;
                }
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    SA_BETA_TRADEDB_0002.uspSetLastOtpTime(new long?(otpAuthModel.userNo), new int?(otpAuthModel.worldNo), new int?(otpAuthModel.nationCode), resultCode);
                    num = Convert.ToInt32(resultCode.Value);
                    flag2 = num.Equals(0);
                    if (flag2.Equals(false))
                        LogUtil.WriteLog("CommonModule Otpauth lastConfirmOtp Update Fail", "WARN");
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule Otpauth Exception : " + ex.ToString(), "ERROR");
                commonResult.resultCode = -8888;
                commonResult.resultMsg = string.Empty;
                return commonResult;
            }
            return commonResult;
        }

        public static bool CheckLastOtpTime(CheckOtpParamModel checkOtpParam)
        {
            bool flag = false;
            try
            {
                if (checkOtpParam.userNo <= 0L || checkOtpParam.nationCode <= 0 || checkOtpParam.worldNo <= 0)
                {
                    LogUtil.WriteLog("CommonModule checkLastOtpTime PARAM Warn " + CommonModule.SerializeObjectToJsonString<CheckOtpParamModel>(checkOtpParam), "WARN");
                    flag = true;
                }
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    SA_BETA_TRADEDB_0002.uspCheckLastOtpTime(new long?(checkOtpParam.userNo), new int?(checkOtpParam.worldNo), new int?(checkOtpParam.nationCode), resultCode);
                    if (Convert.ToInt32(resultCode.Value).Equals(0).Equals(false))
                        flag = true;
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule CheckLastOtpTime Exception : " + ex.ToString(), "ERROR");
                return true;
            }
            return flag;
        }

        public static int GetLastOtpTimeUtc(CheckOtpParamModel checkOtpParam)
        {
            int lastOtpTimeUtc = 0;
            try
            {
                if (checkOtpParam.userNo <= 0L || checkOtpParam.nationCode <= 0 || checkOtpParam.worldNo <= 0)
                {
                    LogUtil.WriteLog("CommonModule GetLastOtpTimeUtc PARAM Warn " + CommonModule.SerializeObjectToJsonString<CheckOtpParamModel>(checkOtpParam), "WARN");
                    lastOtpTimeUtc = 0;
                }
                using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                {
                    ObjectParameter resultCode = new ObjectParameter("resultCode", typeof(int));
                    ObjectParameter lastConfirmOtpTime = new ObjectParameter("lastConfirmOtpTime", typeof(DateTime));
                    SA_BETA_TRADEDB_0002.uspGetLastOtpTime(new long?(checkOtpParam.userNo), new int?(checkOtpParam.worldNo), new int?(checkOtpParam.nationCode), lastConfirmOtpTime, resultCode);
                    Convert.ToInt32(resultCode.Value);
                    lastOtpTimeUtc = Convert.ToInt32(CommonModule.ConvertUnixTime(Convert.ToDateTime(lastConfirmOtpTime.Value).ToUniversalTime()));
                }
                if (lastOtpTimeUtc < 0)
                    lastOtpTimeUtc = 0;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("CommonModule GetLastOtpTimeUtc Exception : " + ex.ToString(), "ERROR");
                return lastOtpTimeUtc;
            }
            return lastOtpTimeUtc;
        }
    }
}
