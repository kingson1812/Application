using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public static class Define
    {
        public static string g_prePath = System.IO.Directory.GetCurrentDirectory() + "/../Data";
        public static string g_configPath = "/Config.xml";
        public static string g_currentAlgorithm = "";
    }

    public static class Flag
    {
        public static bool g_needUpdatePanel = false;
        public static bool g_onButtonClick = false;
        public static bool g_needUpdateOptionalPanel = false;
    }

    public static class Key
    {
        public static string[] g_name =
        {
            "comboboxAlgorithm",
            "panelContent:sort",
            "panelContent:seek"
        };
    }
}
