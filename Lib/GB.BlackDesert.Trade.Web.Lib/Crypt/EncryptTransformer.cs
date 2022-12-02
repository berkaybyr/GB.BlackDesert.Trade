// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.EncryptTransformer
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Security.Cryptography;

namespace BlackDesert.TradeMarket.Lib.Crypt
{
    internal class EncryptTransformer
    {
        private EncryptionAlgorithm algorithmID;
        private byte[] initVec;
        private byte[] encKey;

        internal EncryptTransformer(EncryptionAlgorithm algId) => algorithmID = algId;

        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            switch (algorithmID)
            {
                case EncryptionAlgorithm.Des:
                    DES des = new DESCryptoServiceProvider();
                    des.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        encKey = des.Key;
                    }
                    else
                    {
                        des.Key = bytesKey;
                        encKey = des.Key;
                    }
                    if (initVec == null)
                        initVec = des.IV;
                    else
                        des.IV = initVec;
                    return des.CreateEncryptor();
                case EncryptionAlgorithm.Rc2:
                    RC2 rc2 = new RC2CryptoServiceProvider();
                    rc2.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        encKey = rc2.Key;
                    }
                    else
                    {
                        rc2.Key = bytesKey;
                        encKey = rc2.Key;
                    }
                    if (initVec == null)
                        initVec = rc2.IV;
                    else
                        rc2.IV = initVec;
                    return rc2.CreateEncryptor();
                case EncryptionAlgorithm.Rijndael:
                    Rijndael rijndael = new RijndaelManaged();
                    rijndael.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        encKey = rijndael.Key;
                    }
                    else
                    {
                        rijndael.Key = bytesKey;
                        encKey = rijndael.Key;
                    }
                    if (initVec == null)
                        initVec = rijndael.IV;
                    else
                        rijndael.IV = initVec;
                    return rijndael.CreateEncryptor();
                case EncryptionAlgorithm.TripleDes:
                    TripleDES tripleDes = new TripleDESCryptoServiceProvider();
                    tripleDes.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        encKey = tripleDes.Key;
                    }
                    else
                    {
                        tripleDes.Key = bytesKey;
                        encKey = tripleDes.Key;
                    }
                    if (initVec == null)
                        initVec = tripleDes.IV;
                    else
                        tripleDes.IV = initVec;
                    return tripleDes.CreateEncryptor();
                default:
                    throw new CryptographicException("Algorithm ID '" + algorithmID + "' not supported.");
            }
        }

        internal byte[] IV
        {
            get => initVec;
            set => initVec = value;
        }

        internal byte[] Key => encKey;
    }
}
