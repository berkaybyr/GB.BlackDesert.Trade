// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Models.HttpRequestModel
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace GB.BlackDesert.Trade.Web.Lib.Models
{
    public class HttpRequestModel
    {
        public string _requestUrl { get; set; }

        public string _requestParam { get; set; }

        public string _requestMethod { get; set; }

        public string _requesetContentType { get; set; }

        public string _encodingType { get; set; }

        public bool _useTlsProtocol { get; set; }

        public bool _useCertificate { get; set; }

        public string _accept { get; set; }

        public bool _useExpect100Continue { get; set; }

        public NameValueCollection _reqHeaders { get; set; }

        public X509Certificate2 _wCertification { get; set; }

        public HttpRequestModel()
        {
            this._requestUrl = string.Empty;
            this._requestParam = string.Empty;
            this._requestMethod = string.Empty;
            this._requesetContentType = string.Empty;
            this._encodingType = "default";
            this._useTlsProtocol = false;
            this._useCertificate = false;
            this._accept = string.Empty;
            this._reqHeaders = (NameValueCollection)null;
            this._wCertification = (X509Certificate2)null;
        }

        public HttpRequestModel(
          string _reqUrl,
          string _reqParam,
          string _reqMethod,
          string _reqContentType)
        {
            this._requestUrl = _reqUrl;
            this._requestParam = _reqParam;
            this._requestMethod = _reqMethod;
            this._requesetContentType = _reqContentType;
            this._encodingType = "default";
            this._useTlsProtocol = false;
            this._useCertificate = false;
            this._accept = string.Empty;
            this._reqHeaders = (NameValueCollection)null;
            this._wCertification = (X509Certificate2)null;
        }

        public HttpRequestModel(
          string _reqUrl,
          string _reqParam,
          string _reqMethod,
          string _reqContentType,
          bool _isUseAccessToken)
        {
            this._requestUrl = _reqUrl;
            this._requestParam = _reqParam;
            this._requestMethod = _reqMethod;
            this._requesetContentType = _reqContentType;
            this._encodingType = "default";
            this._useTlsProtocol = false;
            this._useCertificate = false;
            this._accept = string.Empty;
            this._reqHeaders = (NameValueCollection)null;
            this._wCertification = (X509Certificate2)null;
        }

        public HttpRequestModel(
          string _reqUrl,
          string _reqParam,
          string _reqMethod,
          string _reqContentType,
          bool _useTlsProtocol,
          string _encodingType)
        {
            this._requestUrl = _reqUrl;
            this._requestParam = _reqParam;
            this._requestMethod = _reqMethod;
            this._requesetContentType = _reqContentType;
            this._encodingType = _encodingType;
            this._useTlsProtocol = _useTlsProtocol;
            this._useCertificate = false;
            this._accept = string.Empty;
            this._reqHeaders = (NameValueCollection)null;
            this._wCertification = (X509Certificate2)null;
        }
    }
}
