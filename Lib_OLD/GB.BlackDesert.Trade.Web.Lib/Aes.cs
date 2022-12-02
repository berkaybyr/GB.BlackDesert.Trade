// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Aes
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Lib
{
    public class Aes
    {
        public string AESEncrypt256(string Input, string key)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.KeySize = 256;
            rijndaelManaged.BlockSize = 128;
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.Key = Encoding.UTF8.GetBytes(key);
            rijndaelManaged.IV = new byte[16];
            ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
            byte[] inArray = (byte[])null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(Input);
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }
                inArray = memoryStream.ToArray();
            }
            return Convert.ToBase64String(inArray);
        }

        public string AESDecrypt256(string Input, string key)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.KeySize = 256;
            rijndaelManaged.BlockSize = 128;
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.Key = Encoding.UTF8.GetBytes(key);
            rijndaelManaged.IV = new byte[16];
            ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor();
            byte[] bytes = (byte[])null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Write))
                {
                    byte[] buffer = Convert.FromBase64String(Input);
                    cryptoStream.Write(buffer, 0, buffer.Length);
                }
                bytes = memoryStream.ToArray();
            }
            return Encoding.UTF8.GetString(bytes);
        }

        public string AESEncrypt128(string Input, string key)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] bytes1 = Encoding.Unicode.GetBytes(Input);
            byte[] bytes2 = Encoding.ASCII.GetBytes(key.Length.ToString());
            PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(key, bytes2);
            byte[] bytes3 = passwordDeriveBytes.GetBytes(32);
            byte[] bytes4 = passwordDeriveBytes.GetBytes(16);
            ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(bytes3, bytes4);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(bytes1, 0, bytes1.Length);
            cryptoStream.FlushFinalBlock();
            byte[] array = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(array);
        }

        public string AESDecrypt128(string Input, string key)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            byte[] buffer = Convert.FromBase64String(Input);
            byte[] bytes1 = Encoding.ASCII.GetBytes(key.Length.ToString());
            PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(key, bytes1);
            byte[] bytes2 = passwordDeriveBytes.GetBytes(32);
            byte[] bytes3 = passwordDeriveBytes.GetBytes(16);
            ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(bytes2, bytes3);
            MemoryStream memoryStream = new MemoryStream(buffer);
            CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] numArray = new byte[buffer.Length];
            int count = cryptoStream.Read(numArray, 0, numArray.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.Unicode.GetString(numArray, 0, count);
        }
    }
}
