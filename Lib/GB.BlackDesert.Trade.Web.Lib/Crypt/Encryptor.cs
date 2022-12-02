// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Encryptor
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System;
using System.IO;
using System.Security.Cryptography;

namespace BlackDesert.TradeMarket.Lib.Crypt
{
    public class Encryptor
    {
        private EncryptTransformer transformer;
        private byte[] initVec;
        private byte[] encKey;

        public Encryptor(EncryptionAlgorithm algId) => transformer = new EncryptTransformer(algId);

        public byte[] Encrypt(byte[] bytesData, byte[] bytesKey)
        {
            MemoryStream memoryStream = new MemoryStream();
            transformer.IV = initVec;
            ICryptoTransform cryptoServiceProvider = transformer.GetCryptoServiceProvider(bytesKey);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider, CryptoStreamMode.Write);
            try
            {
                cryptoStream.Write(bytesData, 0, bytesData.Length);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while writing encrypted data to the stream: \n" + ex.Message);
            }
            encKey = transformer.Key;
            initVec = transformer.IV;
            cryptoStream.FlushFinalBlock();
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        public byte[] IV
        {
            get => initVec;
            set => initVec = value;
        }

        public byte[] Key => encKey;
    }
}
