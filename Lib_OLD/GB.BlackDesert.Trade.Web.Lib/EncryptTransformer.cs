// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.EncryptTransformer
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using System.Security.Cryptography;

namespace GB.BlackDesert.Trade.Web.Lib
{
    internal class EncryptTransformer
    {
        private EncryptionAlgorithm algorithmID;
        private byte[] initVec;
        private byte[] encKey;

        internal EncryptTransformer(EncryptionAlgorithm algId) => this.algorithmID = algId;

        internal ICryptoTransform GetCryptoServiceProvider(byte[] bytesKey)
        {
            switch (this.algorithmID)
            {
                case EncryptionAlgorithm.Des:
                    DES des = (DES)new DESCryptoServiceProvider();
                    des.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        this.encKey = des.Key;
                    }
                    else
                    {
                        des.Key = bytesKey;
                        this.encKey = des.Key;
                    }
                    if (this.initVec == null)
                        this.initVec = des.IV;
                    else
                        des.IV = this.initVec;
                    return des.CreateEncryptor();
                case EncryptionAlgorithm.Rc2:
                    RC2 rc2 = (RC2)new RC2CryptoServiceProvider();
                    rc2.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        this.encKey = rc2.Key;
                    }
                    else
                    {
                        rc2.Key = bytesKey;
                        this.encKey = rc2.Key;
                    }
                    if (this.initVec == null)
                        this.initVec = rc2.IV;
                    else
                        rc2.IV = this.initVec;
                    return rc2.CreateEncryptor();
                case EncryptionAlgorithm.Rijndael:
                    Rijndael rijndael = (Rijndael)new RijndaelManaged();
                    rijndael.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        this.encKey = rijndael.Key;
                    }
                    else
                    {
                        rijndael.Key = bytesKey;
                        this.encKey = rijndael.Key;
                    }
                    if (this.initVec == null)
                        this.initVec = rijndael.IV;
                    else
                        rijndael.IV = this.initVec;
                    return rijndael.CreateEncryptor();
                case EncryptionAlgorithm.TripleDes:
                    TripleDES tripleDes = (TripleDES)new TripleDESCryptoServiceProvider();
                    tripleDes.Mode = CipherMode.CBC;
                    if (bytesKey == null)
                    {
                        this.encKey = tripleDes.Key;
                    }
                    else
                    {
                        tripleDes.Key = bytesKey;
                        this.encKey = tripleDes.Key;
                    }
                    if (this.initVec == null)
                        this.initVec = tripleDes.IV;
                    else
                        tripleDes.IV = this.initVec;
                    return tripleDes.CreateEncryptor();
                default:
                    throw new CryptographicException("Algorithm ID '" + (object)this.algorithmID + "' not supported.");
            }
        }

        internal byte[] IV
        {
            get => this.initVec;
            set => this.initVec = value;
        }

        internal byte[] Key => this.encKey;
    }
}
