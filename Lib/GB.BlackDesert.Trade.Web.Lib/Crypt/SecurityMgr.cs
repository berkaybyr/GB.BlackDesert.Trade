// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.SecurityMgr
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

namespace BlackDesert.TradeMarket.Lib.Crypt
{
    public class SecurityMgr
    {
        protected readonly string CON_TRIPLEDES_KEY = "sIMPLEiSbESTwAYS";
        protected readonly string CON_TRIPLEDES_IV = "xhdgkq12";
        protected readonly string CON_RIJNDAE_KEY = "SiMplEisBesTwaYs";
        protected readonly string CON_RIJNDAE_IV = "qwertyuiqwertyui";
        protected readonly string CON_RIJNDAE_PW = "WEBDEV99";
        protected readonly string CON_RIJNDAE_SALT = "AQAB";
        protected readonly string CON_RC2_KEY = "MUBIZWEB";
        protected readonly string CON_RC2_IV = "DL7FLEFT";
        protected readonly string CON_DES_KEY = "WEBZEN99";
        protected readonly string CON_DES_IV = "WEBDEV99";
        protected readonly string CON_HEX_KEY = "SiMplEisBesTwaYs";
        protected readonly string CON_HEX_IV = "WebDev10";
        protected readonly string CON_MD5_KEY = "SiMplEisBesTwaYs";
        protected readonly string CON_RSA_N_KEY = "2TuWVagX+tzFgmK9siIpHAfGHkVlJsZ/IBLVMWyvOJgxqtmmj3uTDBfrz1XcZ5L71zHJAWqpeJvaSJZRX0CdW0IkalkeBAVQ5qYO1Kflsdu2ZUckVeKpXDtx+LflLL7dHbEZQWPg8RJsMbbGceaRxu2f+qrg5FxK4fD414OC6uM=";
        protected readonly string CON_RSA_D_KEY = "nxEv+xb0QECq69fL2gWDnr/ehcoA0IznB6BitidEgyeGrvljKoutWFyn0pGnq7wIZ0JQUpY89FEDXMWdXiddUN0v3LBk4alTxj5fPZva+oM6D5Sq17vKNtnJqH9ZipN2CQsdMQD4+YRJPq0/6Pi0A2sU66NgSbFS9+wJ2OsvB6E=";
        protected readonly string CON_RSA_E = "AQAB";
        protected readonly string CON_RSA_P = "8xBr1EUGWFSp21OHwR7Qkpzlb+YtE97pBEF9PU8pkZ9o6KdUzNzoHV8xyRAPaYT8SkugmD3biwXNXMvjZ0lNEQ==";
        protected readonly string CON_RSA_Q = "5Ms7Rdft1hito2nTaWrBb+kone5xaF96ZrZUhUKeISpp6sLOW6ydcXWQAyTACurPTiPiMW2lVdyui3MSOUGIsw==";
        protected readonly string CON_RSA_DP = "S/9HZ7BJQpb+INhmKsjCuAScbDdQwtTAkJcVXHUC70gjWhLvnbo4TO61t0LxPrHY3DX3OYKlwTsIMcqCCIpPsQ==";
        protected readonly string CON_RSA_DQ = "y8Ch3KVbzZrUp/8Ko4rLEdrWrS84F/dPjkE6LCMTp/2ZrdQm6kVjQTOtON91l0Ndsv0J53L6FukdGFs2E39lOQ==";
        protected readonly string CON_RSA_INVERSEQ = "XULNULjj9g6SHgX5GGdhuWBtr+ogrXFZkwyMmLPYBZjSIr1wZr6Wmdjp0l8lmAukIbxU3Iw6P7iJs6ahLTmEpA==";

        public enum Enum
        {
            Rc2,
            Des,
            TripleDes,
            MD5,
            HEX,
            RSA,
            AES,
            SHA256,
        }
    }
}
