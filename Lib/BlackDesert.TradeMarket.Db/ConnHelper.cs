using System.Configuration;

namespace BlackDesert.TradeMarket.Db
{
	public static class ConnHelper
	{
		public static string GetConnString(string connName)
		{
#if DEBUG || TestRelease
			return System.Configuration.ConfigurationManager.ConnectionStrings["Dev" + connName].ConnectionString;
#else
            return ConfigurationManager.ConnectionStrings[connName].ConnectionString;
#endif
		}


	}
}
