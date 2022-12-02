// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.DecryptTransformer
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Security.Cryptography;

namespace GB.BlackDesert.Trade.Web.Lib
{
    internal class DecryptTransformer
    {
        private EncryptionAlgorithm algorithmID;
        private byte[] initVec;

        internal DecryptTransformer(EncryptionAlgorithm deCryptId) => this.algorithmID = deCryptId;

        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            switch (this.algorithmID)
            {
                case EncryptionAlgorithm.Des:
                    DESCryptoServiceProvider cryptoServiceProvider1 = new DESCryptoServiceProvider();
                    cryptoServiceProvider1.Mode = CipherMode.CBC;
                    cryptoServiceProvider1.Key = bytesKey;
                    cryptoServiceProvider1.IV = this.initVec;
                    return cryptoServiceProvider1.CreateDecryptor();
                case EncryptionAlgorithm.Rc2:
                    RC2CryptoServiceProvider cryptoServiceProvider2 = new RC2CryptoServiceProvider();
                    cryptoServiceProvider2.Mode = CipherMode.CBC;
                    return cryptoServiceProvider2.CreateDecryptor(bytesKey, this.initVec);
                case EncryptionAlgorithm.Rijndael:
                    RijndaelManaged rijndaelManaged = new RijndaelManaged();
                    rijndaelManaged.Mode = CipherMode.CBC;
                    return rijndaelManaged.CreateDecryptor(bytesKey, this.initVec);
                case EncryptionAlgorithm.TripleDes:
                    TripleDESCryptoServiceProvider cryptoServiceProvider3 = new TripleDESCryptoServiceProvider();
                    cryptoServiceProvider3.Mode = CipherMode.CBC;
                    return cryptoServiceProvider3.CreateDecryptor(bytesKey, this.initVec);
                default:
                    throw new CryptographicException("Algorithm ID '" + (object)this.algorithmID + "' not supported.");
            }
        }

        internal byte[] IV
        {
            set => this.initVec = value;
        }
    }
}
