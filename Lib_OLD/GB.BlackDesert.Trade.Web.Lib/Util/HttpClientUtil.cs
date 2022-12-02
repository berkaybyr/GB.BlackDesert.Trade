// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.HttpClientUtil
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Manager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public static class HttpClientUtil
    {
        private static HttpClient GetHttpClient()
        {
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpClientHandler handler = new HttpClientHandler();
            return new HttpClient((HttpMessageHandler)handler);
        }

        public static async Task<string> HttpClientPostAsync(
          Dictionary<string, string> nameValueCollection,
          string requestUri)
        {
            string str = string.Empty;
            try
            {
                using (HttpClient httpClient = HttpClientUtil.GetHttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMilliseconds(300000.0);
                    using (HttpContent httpContent = (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)nameValueCollection))
                    {
                        using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(requestUri, httpContent))
                        {
                            if (httpResponseMessage.IsSuccessStatusCode)
                            {
                                using (Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync())
                                {
                                    using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                                        str = await streamReader.ReadToEndAsync();
                                }
                            }
                            else
                                str = "ERROR";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("Exception=>{0}", (object)ex), "ERROR");
                str = string.Format("Exception=>{0}", (object)ex);
            }
            return str;
        }

        public static async Task<string> HttpClientGetAsync(string requestUri)
        {
            string async = string.Empty;
            try
            {
                using (HttpClient httpClient = HttpClientUtil.GetHttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMilliseconds(300000.0);
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestUri))
                    {
                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            using (Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync())
                            {
                                using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                                    async = await streamReader.ReadToEndAsync();
                            }
                        }
                        else
                            async = "ERROR";
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("HttpClientGetAsync.Exception=>{0}", (object)ex), "ERROR");
                async = string.Format("Exception=>{0}", (object)ex);
            }
            return async;
        }

        public static async Task<string> HttpClientDeleteAsync(string requestUri)
        {
            string str = string.Empty;
            try
            {
                using (HttpClient httpClient = HttpClientUtil.GetHttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMilliseconds(300000.0);
                    using (HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync(requestUri))
                    {
                        using (Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync())
                        {
                            using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                                str = await streamReader.ReadToEndAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("Exception=>{0}", (object)ex), "ERROR");
                str = string.Format("Exception=>{0}", (object)ex);
            }
            return str;
        }

        public static async Task<byte[]> HttpClientGetStreamAsync(string requestUri)
        {
            byte[] byteArrayData = new byte[0];
            try
            {
                using (HttpClient httpClient = HttpClientUtil.GetHttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMilliseconds(300000.0);
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(requestUri))
                    {
                        using (Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync())
                        {
                            using (MemoryStream memoryStream = new MemoryStream())
                            {
                                await stream.CopyToAsync((Stream)memoryStream);
                                byteArrayData = memoryStream.ToArray();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("HttpClientGetAsync.Exception=>{0}", (object)ex), "ERROR");
            }
            return byteArrayData;
        }
    }
}
