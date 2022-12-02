// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DecryptTransformer
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Security.Cryptography;

namespace BlackDesert.TradeMarket.Lib.Crypt
{
    internal class DecryptTransformer
    {
        private EncryptionAlgorithm algorithmID;
        private byte[] initVec;

        internal DecryptTransformer(EncryptionAlgorithm deCryptId) => algorithmID = deCryptId;

        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            switch (algorithmID)
            {
                case EncryptionAlgorithm.Des:
                    DESCryptoServiceProvider cryptoServiceProvider1 = new DESCryptoServiceProvider();
                    cryptoServiceProvider1.Mode = CipherMode.CBC;
                    cryptoServiceProvider1.Key = bytesKey;
                    cryptoServiceProvider1.IV = initVec;
                    return cryptoServiceProvider1.CreateDecryptor();
                case EncryptionAlgorithm.Rc2:
                    RC2CryptoServiceProvider cryptoServiceProvider2 = new RC2CryptoServiceProvider();
                    cryptoServiceProvider2.Mode = CipherMode.CBC;
                    return cryptoServiceProvider2.CreateDecryptor(bytesKey, initVec);
                case EncryptionAlgorithm.Rijndael:
                    RijndaelManaged rijndaelManaged = new RijndaelManaged();
                    rijndaelManaged.Mode = CipherMode.CBC;
                    return rijndaelManaged.CreateDecryptor(bytesKey, initVec);
                case EncryptionAlgorithm.TripleDes:
                    TripleDESCryptoServiceProvider cryptoServiceProvider3 = new TripleDESCryptoServiceProvider();
                    cryptoServiceProvider3.Mode = CipherMode.CBC;
                    return cryptoServiceProvider3.CreateDecryptor(bytesKey, initVec);
                default:
                    throw new CryptographicException("Algorithm ID '" + algorithmID + "' not supported.");
            }
        }

        internal byte[] IV
        {
            set => initVec = value;
        }
    }
}
