using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public static class ContextAccess
    {
        public static HttpContext Current 
        {
            get
            {
                if (_accessor == null) return null;
                return _accessor.HttpContext;
            }
        }
        private static IHttpContextAccessor _accessor; 

        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _accessor = httpContextAccessor;
        }
    }
}
