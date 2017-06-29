using System;
using System.Text;

namespace Global
{
    public static class Log
    {
        //Debug         CYAN
        //Verbose       WHITE
        //Success       GREEN
        //Error         RED
        //Fatal         MAGENTA
        //Background    BLACK

        /// <summary>
        /// "[VER] ","[INF] ","[DBG] ","[ERR] ","[FAT] "
        /// </summary>
        public static string[] PrePrototype =
        {
            "[VER] ",
            "[INF] ",
            "[DBG] ",
            "[ERR] ",
            "[FAT] "
        };

        private static void PRINT(string message)
        {
            if (Config.PLATFORM == Config.CONFIG.WIN32)
                Console.WriteLine(message);
        }

        private static void PRINT(string format, params object[] arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                format = format.Replace("{" + i + "}", arg[i].ToString());
            }

            if (Config.PLATFORM == Config.CONFIG.WIN32)
                Console.WriteLine(format);
        }

        #region Console setting
        /// <summary>
        /// Set console fore color
        /// </summary>
        private static void SetConsoleColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        /// <summary>
        /// Set console value, attribute
        /// </summary>
        public static void SetConsoleValue(int width, int height, ConsoleColor color, int bufferWidth, int bufferHeight,
            Encoding enc, string title)
        {
            Console.BackgroundColor = color;
            Console.SetBufferSize(bufferWidth, bufferHeight);
            Console.WindowWidth = width;
            Console.WindowHeight = height;
            Console.Title = title;
            Console.OutputEncoding = enc;
        }
        #endregion

        #region Debug
        //Bare string
        public static void DEBUG(string message)
        {
            SetConsoleColor(ConsoleColor.Cyan);
            PRINT(PrePrototype[2] + message);
        }

        //String with params
        public static void DEBUG(string format, params object[] arg)
        {
            SetConsoleColor(ConsoleColor.Cyan);
            PRINT(PrePrototype[2] + format, arg);
        }
        #endregion

        #region Verbose
        //Bare string
        public static void VERBOSE(string message)
        {
            SetConsoleColor(ConsoleColor.White);
            PRINT(PrePrototype[0] + message);
        }

        //String with params
        public static void VERBOSE(string format, params object[] arg)
        {
            SetConsoleColor(ConsoleColor.White);
            PRINT(PrePrototype[0] + format, arg);
        }
        #endregion

        #region Error
        //Bare string
        public static void ERROR(string message)
        {
            SetConsoleColor(ConsoleColor.Red);
            PRINT(PrePrototype[3] + message);
        }

        //String with params
        public static void ERROR(string format, params object[] arg)
        {
            SetConsoleColor(ConsoleColor.Red);
            PRINT(PrePrototype[3] + format, arg);
        }
        #endregion

        #region Fatal
        //Bare string
        public static void FATAL(string message)
        {
            SetConsoleColor(ConsoleColor.Magenta);
            PRINT(PrePrototype[4] + message);
        }

        //String with params
        public static void FATAL(string format, params object[] arg)
        {
            SetConsoleColor(ConsoleColor.Magenta);
            PRINT(PrePrototype[4] + format, arg);
        }
        #endregion

        #region Success
        //Bare string
        public static void SUCCESS(string message)
        {
            SetConsoleColor(ConsoleColor.Green);
            PRINT(PrePrototype[1] + message);
        }

        //String with params
        public static void SUCCESS(string format, params object[] arg)
        {
            SetConsoleColor(ConsoleColor.Green);
            PRINT(PrePrototype[1] + format, arg);
        }
        #endregion

    }
}
