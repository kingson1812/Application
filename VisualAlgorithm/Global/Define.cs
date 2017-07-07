namespace Global
{
    public static class Define
    {
        public static string g_prePath = System.IO.Directory.GetCurrentDirectory() + "/../VisualAlgorithm/Data";
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
