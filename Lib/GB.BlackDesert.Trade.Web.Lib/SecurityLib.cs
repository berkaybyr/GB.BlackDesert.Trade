// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.SecurityLib
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;


namespace GB.BlackDesert.Trade.Web.Lib
{
    public class SecurityLib : SecurityMgr
    {
        public string Encrypt(string strMsg, SecurityMgr.Enum enumType)
        {
            switch (enumType)
            {
                case SecurityMgr.Enum.Rc2:
                    Encryptor encryptor1 = new Encryptor(EncryptionAlgorithm.Rc2);
                    byte[] bytes1 = Encoding.UTF8.GetBytes(strMsg);
                    byte[] bytes2 = Encoding.UTF8.GetBytes(this.CON_RC2_KEY);
                    encryptor1.IV = Encoding.UTF8.GetBytes(this.CON_RC2_IV);
                    return Convert.ToBase64String(encryptor1.Encrypt(bytes1, bytes2));
                case SecurityMgr.Enum.Des:
                    Encryptor encryptor2 = new Encryptor(EncryptionAlgorithm.Des);
                    byte[] bytes3 = Encoding.UTF8.GetBytes(strMsg);
                    byte[] bytes4 = Encoding.UTF8.GetBytes(this.CON_DES_KEY);
                    encryptor2.IV = Encoding.UTF8.GetBytes(this.CON_DES_IV);
                    return Convert.ToBase64String(encryptor2.Encrypt(bytes3, bytes4));
                case SecurityMgr.Enum.TripleDes:
                    Encryptor encryptor3 = new Encryptor(EncryptionAlgorithm.TripleDes);
                    byte[] bytes5 = Encoding.UTF8.GetBytes(strMsg);
                    byte[] bytes6 = Encoding.ASCII.GetBytes(this.CON_TRIPLEDES_KEY);
                    encryptor3.IV = Encoding.ASCII.GetBytes(this.CON_TRIPLEDES_IV);
                    return Convert.ToBase64String(encryptor3.Encrypt(bytes5, bytes6));
                case SecurityMgr.Enum.MD5:
                    byte[] hash1 = MD5.Create().ComputeHash(Encoding.Default.GetBytes(strMsg + this.CON_MD5_KEY + strMsg.Length.ToString()));
                    StringBuilder stringBuilder1 = new StringBuilder();
                    for (int index = 0; index < hash1.Length; ++index)
                        stringBuilder1.Append(hash1[index].ToString("x2"));
                    return stringBuilder1.ToString();
                case SecurityMgr.Enum.HEX:
                    byte[] bytes7 = Encoding.UTF8.GetBytes(this.CON_HEX_KEY);
                    byte[] bytes8 = Encoding.UTF8.GetBytes(this.CON_HEX_IV);
                    byte[] bytes9 = Encoding.UTF8.GetBytes(strMsg);
                    TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
                    cryptoServiceProvider.KeySize = 192;
                    cryptoServiceProvider.Mode = CipherMode.CBC;
                    cryptoServiceProvider.Padding = PaddingMode.Zeros;
                    ICryptoTransform encryptor4 = cryptoServiceProvider.CreateEncryptor(bytes7, bytes8);
                    MemoryStream memoryStream = new MemoryStream();
                    CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor4, CryptoStreamMode.Write);
                    cryptoStream.Write(bytes9, 0, bytes9.Length);
                    cryptoStream.FlushFinalBlock();
                    byte[] array = memoryStream.ToArray();
                    cryptoStream.Close();
                    memoryStream.Close();
                    return BitConverter.ToString(array).Replace("-", "");
                case SecurityMgr.Enum.AES:
                    string HashAlgorithm = "SHA256";
                    string conRijndaePw = this.CON_RIJNDAE_PW;
                    string conRijndaeIv = this.CON_RIJNDAE_IV;
                    string conRijndaeSalt = this.CON_RIJNDAE_SALT;
                    int KeySize = 256;
                    int PasswordIterations = 5;
                    return clsCrypt.Encrypt(strMsg, conRijndaePw, conRijndaeSalt, HashAlgorithm, PasswordIterations, conRijndaeIv, KeySize);
                case SecurityMgr.Enum.SHA256:
                    using (SHA256Managed shA256Managed = new SHA256Managed())
                    {
                        byte[] hash2 = shA256Managed.ComputeHash(Encoding.UTF8.GetBytes(strMsg));
                        StringBuilder stringBuilder2 = new StringBuilder();
                        foreach (byte num in hash2)
                            stringBuilder2.AppendFormat("{0:x2}", (object)num);
                        return stringBuilder2.ToString();
                    }
                default:
                    return (string)null;
            }
        }

        public string Decrypt(string strEn, SecurityMgr.Enum enumType)
        {
            switch (enumType)
            {
                case SecurityMgr.Enum.Rc2:
                    Decryptor decryptor1 = new Decryptor(EncryptionAlgorithm.Rc2);
                    decryptor1.IV = Encoding.UTF8.GetBytes(this.CON_RC2_IV);
                    byte[] bytes1 = Encoding.UTF8.GetBytes(this.CON_RC2_KEY);
                    byte[] bytes2;
                    try
                    {
                        bytes2 = decryptor1.Decrypt(Convert.FromBase64String(WebUtility.UrlDecode(strEn)), bytes1);
                    }
                    catch
                    {
                        bytes2 = decryptor1.Decrypt(Convert.FromBase64String(strEn), bytes1);
                    }
                    return Encoding.UTF8.GetString(bytes2);
                case SecurityMgr.Enum.Des:
                    Decryptor decryptor2 = new Decryptor(EncryptionAlgorithm.Des);
                    decryptor2.IV = Encoding.UTF8.GetBytes(this.CON_DES_IV);
                    byte[] bytes3 = Encoding.UTF8.GetBytes(this.CON_DES_KEY);
                    byte[] bytes4;
                    try
                    {
                        bytes4 = decryptor2.Decrypt(Convert.FromBase64String(WebUtility.UrlDecode(strEn)), bytes3);
                    }
                    catch
                    {
                        bytes4 = decryptor2.Decrypt(Convert.FromBase64String(strEn), bytes3);
                    }
                    return Encoding.UTF8.GetString(bytes4);
                case SecurityMgr.Enum.TripleDes:
                    Decryptor decryptor3 = new Decryptor(EncryptionAlgorithm.TripleDes);
                    decryptor3.IV = Encoding.UTF8.GetBytes(this.CON_TRIPLEDES_IV);
                    byte[] bytes5 = Encoding.UTF8.GetBytes(this.CON_TRIPLEDES_KEY);
                    byte[] bytes6;
                    try
                    {
                        bytes6 = decryptor3.Decrypt(Convert.FromBase64String(WebUtility.UrlDecode(strEn)), bytes5);
                    }
                    catch
                    {
                        bytes6 = decryptor3.Decrypt(Convert.FromBase64String(strEn), bytes5);
                    }
                    return Encoding.UTF8.GetString(bytes6);
                case SecurityMgr.Enum.HEX:
                    byte[] bytes7 = Encoding.UTF8.GetBytes(this.CON_HEX_KEY);
                    byte[] bytes8 = Encoding.UTF8.GetBytes(this.CON_HEX_IV);
                    int length1 = strEn.Length;
                    byte[] inArray = new byte[length1 / 2];
                    for (int startIndex = 0; startIndex < length1; startIndex += 2)
                        inArray[startIndex / 2] = Convert.ToByte(strEn.Substring(startIndex, 2), 16);
                    byte[] buffer1 = Convert.FromBase64String(Convert.ToBase64String(inArray));
                    TripleDESCryptoServiceProvider cryptoServiceProvider1 = new TripleDESCryptoServiceProvider();
                    cryptoServiceProvider1.KeySize = 192;
                    cryptoServiceProvider1.Mode = CipherMode.CBC;
                    cryptoServiceProvider1.Padding = PaddingMode.None;
                    ICryptoTransform decryptor4 = cryptoServiceProvider1.CreateDecryptor(bytes7, bytes8);
                    CryptoStream cryptoStream = new CryptoStream((Stream)new MemoryStream(buffer1), decryptor4, CryptoStreamMode.Read);
                    byte[] bytes9 = new byte[buffer1.Length];
                    byte[] buffer2 = bytes9;
                    int length2 = bytes9.Length;
                    cryptoStream.Read(buffer2, 0, length2);
                    return Encoding.UTF8.GetString(bytes9).TrimEnd(new char[1]);
                case SecurityMgr.Enum.RSA:
                    RSACryptoServiceProvider cryptoServiceProvider2 = new RSACryptoServiceProvider(new CspParameters(1)
                    {
                        KeyContainerName = "RSA",
                        Flags = CspProviderFlags.UseMachineKeyStore
                    });
                    string empty = string.Empty;
                    try
                    {
                        cryptoServiceProvider2.ImportParameters(new RSAParameters()
                        {
                            Modulus = Convert.FromBase64String(this.CON_RSA_N_KEY),
                            Exponent = Convert.FromBase64String(this.CON_RSA_E),
                            P = Convert.FromBase64String(this.CON_RSA_P),
                            Q = Convert.FromBase64String(this.CON_RSA_Q),
                            DP = Convert.FromBase64String(this.CON_RSA_DP),
                            DQ = Convert.FromBase64String(this.CON_RSA_DQ),
                            InverseQ = Convert.FromBase64String(this.CON_RSA_INVERSEQ),
                            D = Convert.FromBase64String(this.CON_RSA_D_KEY)
                        });
                        byte[] rgb = Convert.FromBase64String(strEn);
                        return SecurityLib.ByteToString2(cryptoServiceProvider2.Decrypt(rgb, false));
                    }
                    catch
                    {
                        return "Error";
                    }
                case SecurityMgr.Enum.AES:
                    string HashAlgorithm = "SHA256";
                    string conRijndaePw = this.CON_RIJNDAE_PW;
                    string conRijndaeIv = this.CON_RIJNDAE_IV;
                    string conRijndaeSalt = this.CON_RIJNDAE_SALT;
                    int KeySize = 256;
                    int PasswordIterations = 5;
                    return clsCrypt.Decrypt(strEn, conRijndaePw, conRijndaeSalt, HashAlgorithm, PasswordIterations, conRijndaeIv, KeySize);
                default:
                    return (string)null;
            }
        }

        public static bool blnMD5Hash(string strInput, string strHash) => StringComparer.OrdinalIgnoreCase.Compare(new SecurityLib().Encrypt(strInput, SecurityMgr.Enum.MD5), strHash) == 0;

        private static string ByteToString2(byte[] buff)
        {
            string string2 = "";
            for (int index = 0; index < buff.Length; ++index)
                string2 += ((char)buff[index]).ToString();
            return string2;
        }

        //public static string GetAES256EncryptToUrlTokenEncode(string plainText) => WebUtility.UrlEncodeToBytes(new AESCrypto().EncryptAES256(plainText));

        public static string GetAES256DecryptFromUrlTokenEncode(string ciperText) => new AESCrypto().DecryptAES256(Encoding.Default.GetBytes(ciperText));
    }
}
