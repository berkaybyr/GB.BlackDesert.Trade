// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.clsCrypt
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Lib
{
    public class clsCrypt
    {
        public static string Encrypt(
          string PlainText,
          string Password,
          string Salt,
          string HashAlgorithm,
          int PasswordIterations,
          string InitialVector,
          int KeySize)
        {
            try
            {
                byte[] bytes1 = Encoding.ASCII.GetBytes(InitialVector);
                byte[] bytes2 = Encoding.ASCII.GetBytes(Salt);
                byte[] bytes3 = Encoding.UTF8.GetBytes(PlainText);
                byte[] bytes4 = new PasswordDeriveBytes(Password, bytes2, HashAlgorithm, PasswordIterations).GetBytes(KeySize / 8);
                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(bytes4, bytes1);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(bytes3, 0, bytes3.Length);
                cryptoStream.FlushFinalBlock();
                byte[] array = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                encryptor.Dispose();
                return Convert.ToBase64String(array);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Decrypt(
          string CipherText,
          string Password,
          string Salt,
          string HashAlgorithm,
          int PasswordIterations,
          string InitialVector,
          int KeySize)
        {
            try
            {
                byte[] bytes1 = Encoding.ASCII.GetBytes(InitialVector);
                byte[] bytes2 = Encoding.ASCII.GetBytes(Salt);
                byte[] buffer = Convert.FromBase64String(CipherText);
                byte[] bytes3 = new PasswordDeriveBytes(Password, bytes2, HashAlgorithm, PasswordIterations).GetBytes(KeySize / 8);
                RijndaelManaged rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(bytes3, bytes1);
                MemoryStream memoryStream = new MemoryStream(buffer);
                CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] numArray = new byte[buffer.Length];
                int count = cryptoStream.Read(numArray, 0, numArray.Length);
                memoryStream.Close();
                cryptoStream.Close();
                decryptor.Dispose();
                return Encoding.UTF8.GetString(numArray, 0, count);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GeByteString(byte[] bytes)
        {
            StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);
            stringBuilder.Append("0x");
            foreach (byte num in bytes)
                stringBuilder.Append(num.ToString("X2"));
            return stringBuilder.ToString().ToUpper();
        }
    }
}
