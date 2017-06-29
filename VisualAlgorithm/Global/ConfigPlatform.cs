namespace Global
{
    public static class Config
    {
        public enum CONFIG
        {
            WIN32 = 0,
            ANDROID = 1,
            IOS = 2
        };

        public static CONFIG PLATFORM = CONFIG.WIN32;
    }
}