namespace Global
{
    //Store path, current macros
    public static class Define
    {
        public static string g_prePath = System.IO.Directory.GetCurrentDirectory() + "/../VisualAlgorithm/Data";
        public static string g_configPath = "/Config.xml";
        public static string g_currentAlgorithm = "";
        public static bool g_isASC = true;
    }

    //Boolean values to switch signal
    public static class Flag
    {
        public static bool g_needUpdateContentPanel = false;
        public static bool g_onButtonClick = false;
        public static bool g_needUpdateOptionalPanel = false;
        public static bool g_processing = false;
    }

    //Key to search or update data config
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
