// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.AESCrypto
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public class AESCrypto
    {
        private readonly byte[] _key = Encoding.UTF8.GetBytes("UGVhcmxBYnlzcy5XZWIuQmxhY2tEZXNl");
        private readonly byte[] _iv = Encoding.UTF8.GetBytes("TW9iaWxlLkJsYWNr");

        private System.Security.Cryptography.Aes CreateCiper()
        {
            System.Security.Cryptography.Aes ciper = System.Security.Cryptography.Aes.Create();
            ciper.Key = this._key;
            ciper.IV = this._iv;
            ciper.Mode = CipherMode.CBC;
            ciper.Padding = PaddingMode.ISO10126;
            return ciper;
        }

        public byte[] EncryptAES(string plainText)
        {
            if (string.IsNullOrEmpty(plainText) || plainText.Length == 0)
                throw new ArgumentException("plainText is null");
            byte[] numArray;
            using (System.Security.Cryptography.Aes ciper = this.CreateCiper())
            {
                using (ICryptoTransform encryptor = ciper.CreateEncryptor())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(plainText);
                    numArray = encryptor.TransformFinalBlock(bytes, 0, bytes.Length);
                    ciper.Clear();
                }
            }
            return numArray;
        }

        public string DecryptAES(byte[] ciperText)
        {
            string empty = string.Empty;
            if (ciperText == null || ciperText.Length == 0)
                throw new ArgumentException("ciperText is null");
            using (System.Security.Cryptography.Aes ciper = this.CreateCiper())
            {
                using (ICryptoTransform decryptor = ciper.CreateDecryptor())
                    return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(ciperText, 0, ciperText.Length));
            }
        }

        public byte[] EncryptAES256(string plainText)
        {
            try
            {
                using (AesManaged aesManaged = new AesManaged())
                {
                    aesManaged.Key = this._key;
                    aesManaged.IV = this._iv;
                    ICryptoTransform encryptor = aesManaged.CreateEncryptor(aesManaged.Key, aesManaged.IV);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                                streamWriter.Write(plainText);
                            return memoryStream.ToArray();
                        }
                    }
                }
            }
            catch
            {
                return (byte[])null;
            }
        }

        public string DecryptAES256(byte[] ciperText)
        {
            string empty = string.Empty;
            try
            {
                using (System.Security.Cryptography.Aes aes = System.Security.Cryptography.Aes.Create())
                {
                    aes.Key = this._key;
                    aes.IV = this._iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    using (MemoryStream memoryStream = new MemoryStream(ciperText))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                                return streamReader.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
