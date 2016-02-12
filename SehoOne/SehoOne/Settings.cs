using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehoOne
{
    class Settings
    {
        #region Singleton

        private static readonly Settings _Instance = new Settings();
        public static Settings Instance { get { return _Instance; } }

        // Constructor (singleton)
        private Settings()
        {
            SetDeafults();
        }

        #endregion // Singleton

        public String SiteRoot { get; private set; }
        public String BaseUrl { get; private set; }

        private void SetDeafults()
        {
            SiteRoot = ConfigurationManager.AppSettings["SiteRoot"];
            BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        }

    }
}
