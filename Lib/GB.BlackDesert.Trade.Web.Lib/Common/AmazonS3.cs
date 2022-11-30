// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Common.AmazonS3
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GB.BlackDesert.Trade.Web.Lib.Common
{
    public class AmazonS3
    {
        private static IAmazonS3 client;
        private string _baseBuket = ConstantMgr._AWSBaseBuketName;
        private string _subBuket = "";
        private string _s1BaseUrl = ConstantMgr._AWSBaseUrl;
        private string _s1SubUrl = "";
        private string _staticBucketName = ConstantMgr._AWSStaticBuketName;
        private static volatile AmazonS3 _uniqueinstance;
        private static object _locker = new object();
        private static TransferUtility _transfer;

        private AmazonS3()
        {
            try
            {
                if (ConstantMgr._isUseProxy)
                {
                    AWSConfigs.ProxyConfig.Host = ConstantMgr._webProxyUrl;
                    AWSConfigs.ProxyConfig.Port = new int?(ConstantMgr._webProxyPort);
                }
                RegionEndpoint bySystemName = RegionEndpoint.GetBySystemName(ConstantMgr._s3RegionName.ToLower());
                if (AmazonS3.client == null)
                {
                    AmazonS3.client = (IAmazonS3)new AmazonS3Client(bySystemName);
                    LogUtil.WriteLog("S3-AmazonS3Client.Config.RegionEndpointServiceName=" + ((IAmazonService)AmazonS3.client).Config.RegionEndpointServiceName, "INFO");
                    LogUtil.WriteLog("S3-AmazonS3Client.Config.RegionEndpoint.DisplayName=" + ((IAmazonService)AmazonS3.client).Config.RegionEndpoint.DisplayName, "INFO");
                    LogUtil.WriteLog("S3-AmazonS3Client.Config.RegionEndpoint.SystemName=" + ((IAmazonService)AmazonS3.client).Config.RegionEndpoint.SystemName, "INFO");
                }
                if (AmazonS3._transfer == null)
                {
                    AmazonS3._transfer = new TransferUtility(bySystemName);
                    LogUtil.WriteLog("S3-TransferUtility.S3Client.Config.RegionEndpointServiceName=" + ((IAmazonService)AmazonS3._transfer.S3Client).Config.RegionEndpointServiceName, "INFO");
                    LogUtil.WriteLog("S3-TransferUtility.S3Client.Config.RegionEndpoint.DisplayName=" + ((IAmazonService)AmazonS3._transfer.S3Client).Config.RegionEndpoint.DisplayName, "INFO");
                    LogUtil.WriteLog("S3-TransferUtility.S3Client.Config.RegionEndpoint.SystemName=" + ((IAmazonService)AmazonS3._transfer.S3Client).Config.RegionEndpoint.SystemName, "INFO");
                }
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("Constructor Exception=" + ex.ToString(), "ERROR");
                if (AmazonS3.client == null)
                    AmazonS3.client = (IAmazonS3)new AmazonS3Client(RegionEndpoint.APNortheast2);
                if (AmazonS3._transfer != null)
                    return;
                AmazonS3._transfer = new TransferUtility(RegionEndpoint.APNortheast2);
            }
        }

        public static AmazonS3 Current
        {
            get
            {
                if (AmazonS3._uniqueinstance == null)
                {
                    lock (AmazonS3._locker)
                    {
                        if (AmazonS3._uniqueinstance == null)
                            AmazonS3._uniqueinstance = new AmazonS3();
                    }
                }
                return AmazonS3._uniqueinstance;
            }
        }

        public string S1Url => this._s1BaseUrl + ConstantMgr._AWSNationalDir + this._s1SubUrl;

        private string uploadBaseString => this._baseBuket + ConstantMgr._AWSNationalDir + this._subBuket;

        public string AmazonS3FileUpload(
          string _bucketSubName,
          string _AWSKey,
          string _AWSMetaTitle,
          string _contentType,
          Stream _uploadData)
        {
            string empty = string.Empty;
            string str1 = (this.uploadBaseString + _bucketSubName).Replace("//", "/");
            string str2;
            try
            {
                PutObjectRequest putObjectRequest1 = new PutObjectRequest()
                {
                    BucketName = str1,
                    Key = _AWSKey
                };
                PutObjectResponse putObjectResponse = AmazonS3.client.PutObject(putObjectRequest1);
                if (((AmazonWebServiceResponse)putObjectResponse).HttpStatusCode.ToString() == "OK")
                {
                    PutObjectRequest putObjectRequest2 = new PutObjectRequest()
                    {
                        BucketName = str1,
                        Key = _AWSKey,
                        InputStream = _uploadData,
                        ContentType = _contentType
                    };
                    putObjectRequest2.Metadata.Add("x-amz-meta-title", _AWSMetaTitle);
                    str2 = ((AmazonWebServiceResponse)AmazonS3.client.PutObject(putObjectRequest2)).HttpStatusCode.ToString();
                }
                else
                    str2 = ((AmazonWebServiceResponse)putObjectResponse).HttpStatusCode.ToString();
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog(((object)ex).ToString(), "ERROR");
                str2 = "ERROR : " + ((Exception)ex).Message;
            }
            return str2;
        }

        public string AmazonS3TextUpload(string _bucketSubName, string _AWSKey, string _uploadData)
        {
            string empty = string.Empty;
            string str1 = (this.uploadBaseString + _bucketSubName).Replace("//", "/");
            string str2;
            try
            {
                PutObjectRequest putObjectRequest1 = new PutObjectRequest()
                {
                    BucketName = str1,
                    Key = _AWSKey,
                    ContentBody = _uploadData
                };
                PutObjectResponse putObjectResponse = AmazonS3.client.PutObject(putObjectRequest1);
                if (((AmazonWebServiceResponse)putObjectResponse).HttpStatusCode.ToString() == "OK")
                {
                    PutObjectRequest putObjectRequest2 = new PutObjectRequest()
                    {
                        BucketName = str1,
                        Key = _AWSKey,
                        FilePath = this.uploadBaseString,
                        ContentType = "text/plain"
                    };
                    putObjectRequest2.Metadata.Add("x-amz-meta-title", "text");
                    str2 = ((AmazonWebServiceResponse)AmazonS3.client.PutObject(putObjectRequest2)).HttpStatusCode.ToString();
                }
                else
                    str2 = ((AmazonWebServiceResponse)putObjectResponse).HttpStatusCode.ToString();
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog(((object)ex).ToString(), "ERROR");
                str2 = "ERROR : " + ((Exception)ex).Message;
            }
            return str2;
        }

        public MemoryStream AmazonS3ObjectToStream(string _bucketSubName, string _AWSKey)
        {
            string str = (this.uploadBaseString + _bucketSubName).Replace("//", "/");
            MemoryStream stream;
            try
            {
                stream = new MemoryStream();
                StreamWriter streamWriter = new StreamWriter((Stream)stream);
                GetObjectRequest getObjectRequest = new GetObjectRequest()
                {
                    BucketName = str,
                    Key = _AWSKey
                };
                using (GetObjectResponse getObjectResponse = AmazonS3.client.GetObject(getObjectRequest))
                {
                    byte[] buffer = new byte[20480];
                    int count;
                    while ((count = ((StreamResponse)getObjectResponse).ResponseStream.Read(buffer, 0, buffer.Length)) > 0)
                        stream.Write(buffer, 0, count);
                }
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog("AmazonS3ObjectToStream AmazonS3Exception Error=" + ((object)ex).ToString(), "ERROR");
                stream = (MemoryStream)null;
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("AmazonS3ObjectToStream Exception Error=" + ex.ToString(), "ERROR");
                stream = (MemoryStream)null;
            }
            return stream;
        }

        public string AmazonS3ObjectToString(string _bucketSubName, string _AWSKey)
        {
            string empty = string.Empty;
            string str = (this.uploadBaseString + _bucketSubName).Replace("//", "/");
            try
            {
                GetObjectRequest getObjectRequest = new GetObjectRequest()
                {
                    BucketName = str,
                    Key = _AWSKey
                };
                using (GetObjectResponse getObjectResponse = AmazonS3.client.GetObject(getObjectRequest))
                {
                    using (StreamReader streamReader = new StreamReader(((StreamResponse)getObjectResponse).ResponseStream))
                        return streamReader.ReadToEnd();
                }
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog("AmazonS3ObjectToString AmazonS3Exception _saveBucketName=" + str + " | _AWSKey=" + _AWSKey + " \nError=" + ((object)ex).ToString(), "ERROR");
                return "ERROR : " + ((object)ex).ToString();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog("AmazonS3ObjectToString Exception _saveBucketName=" + str + " | _AWSKey=" + _AWSKey + " \nError=" + ex.ToString(), "ERROR");
                return string.Empty;
            }
        }

        public byte[] AmazonS3ObjectToByte(string _bucketSubName, string _AWSKey)
        {
            MemoryStream memoryStream1 = (MemoryStream)null;
            string str = (this.uploadBaseString + _bucketSubName).Replace("//", "/");
            byte[] numArray = new byte[0];
            try
            {
                GetObjectRequest getObjectRequest = new GetObjectRequest()
                {
                    BucketName = str,
                    Key = _AWSKey
                };
                using (GetObjectResponse getObjectResponse = AmazonS3.client.GetObject(getObjectRequest))
                {
                    MemoryStream memoryStream2 = new MemoryStream();
                    using (new StreamWriter((Stream)memoryStream2))
                    {
                        byte[] buffer = new byte[2048];
                        int count;
                        while ((count = ((StreamResponse)getObjectResponse).ResponseStream.Read(buffer, 0, buffer.Length)) > 0)
                            memoryStream2.Write(buffer, 0, count);
                    }
                    numArray = memoryStream2.GetBuffer();
                }
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog(((object)ex).ToString(), "ERROR");
                memoryStream1 = (MemoryStream)null;
            }
            return numArray;
        }

        public string AmazonS3DeleteSingleObject(string _targetBucketSubName, string _targetAWSKey)
        {
            string empty = string.Empty;
            string str = (this.uploadBaseString + _targetBucketSubName).Replace("//", "/");
            try
            {
                DeleteObjectRequest deleteObjectRequest = new DeleteObjectRequest()
                {
                    BucketName = str,
                    Key = _targetAWSKey
                };
                return ((AmazonWebServiceResponse)AmazonS3.client.DeleteObject(deleteObjectRequest)).HttpStatusCode.ToString();
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog(((object)ex).ToString(), "ERROR");
                return "ERROR : " + ((object)ex).ToString();
            }
        }

        public AWSS3ObjectList AmazonS3GetObjectList(string _bucketName, int _listSize)
        {
            AWSS3ObjectList objectList = new AWSS3ObjectList();
            List<string> stringList = new List<string>();
            List<long> longList = new List<long>();
            try
            {
                _bucketName = "s1/" + ConstantMgr._AWSNationalDir + this._subBuket + (string.IsNullOrEmpty(_bucketName) ? "" : _bucketName);
                _listSize = _listSize == 0 ? 10000 : _listSize;
                ListObjectsV2Request objectsV2Request = new ListObjectsV2Request()
                {
                    BucketName = this._staticBucketName,
                    MaxKeys = _listSize,
                    Prefix = _bucketName
                };
                ListObjectsV2Response objectsV2Response;
                do
                {
                    objectsV2Response = AmazonS3.client.ListObjectsV2(objectsV2Request);
                    foreach (S3Object s3Object in objectsV2Response.S3Objects)
                    {
                        stringList.Add(this.S1Url + s3Object.Key.Replace("s1/" + ConstantMgr._AWSNationalDir + this._subBuket, ""));
                        longList.Add(s3Object.Size);
                    }
                    objectsV2Request.ContinuationToken = objectsV2Response.NextContinuationToken;
                }
                while (objectsV2Response.IsTruncated);
                objectList.objectKeyList = stringList;
                objectList.objectSizeList = longList;
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog(((object)ex).ToString(), "ERROR");
                objectList = (AWSS3ObjectList)null;
            }
            return objectList;
        }

        public async Task<byte[]> AwsGetObjectToByte(string _bucketSubName, string _AWSKey)
        {
            MemoryStream _stream = (MemoryStream)null;
            string str = (this.uploadBaseString + _bucketSubName).Replace("//", "/");
            byte[] _result = new byte[0];
            try
            {
                GetObjectRequest getObjectRequest = new GetObjectRequest()
                {
                    BucketName = str,
                    Key = _AWSKey
                };
                using (GetObjectResponse response = AmazonS3.client.GetObject(getObjectRequest))
                {
                    _stream = new MemoryStream();
                    await ((StreamResponse)response).ResponseStream.CopyToAsync((Stream)_stream);
                    _result = _stream.ToArray();
                }
            }
            catch (AmazonS3Exception ex)
            {
                LogUtil.WriteLog(((object)ex).ToString(), "ERROR");
                _stream = (MemoryStream)null;
            }
            return _result;
        }
    }
}
