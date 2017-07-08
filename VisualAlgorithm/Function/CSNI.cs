using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Function
{
    public static class CSNI
    {
        [MarshalAs(UnmanagedType.SafeArray)]
        public static List<int> g_dataArray;

        [DllImport("Algorithm.dll")]
        public static extern void CreateAlgorithm();

        [DllImport("Algorithm.dll")]
        public static extern IntPtr GetAlgorithm();

        [DllImport("Algorithm.dll",CallingConvention=CallingConvention.Cdecl)]
        public static extern void SetData(string array);

        [DllImport("Algorithm.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetData();

        [DllImport("Algorithm.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Sort(int sortType, bool asc);

        public static string ConvertToString(List<int> list)
        {
            string output = "";
            for(int i=0;i<list.Count;i++)
            {
                output += list[i];
                if (i < list.Count - 1)
                    output += ";";
            }
            return output;
        }
    }
}
