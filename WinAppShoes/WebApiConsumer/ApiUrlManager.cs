using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppShoes.WebApiConsumer
{
    public static class ApiUrlManager
    {
        static ApiUrlManager()
        {
            _baseUrlLocal = Convert.ToString(ConfigurationManager.AppSettings["BaseUrlLocal"]);
        }

        private static string _baseUrlLocal;
        public static string BaseUrlLocal { get { return _baseUrlLocal; } }

    }
}
