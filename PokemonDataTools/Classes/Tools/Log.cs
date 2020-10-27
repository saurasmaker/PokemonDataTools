using System;
using System.IO;

namespace Tools
{
    static class Log
    {
        private static readonly string path = Directory.GetCurrentDirectory() + "\\..\\..\\log.txt";

        public static void Execute(string msg)
        {
            StreamWriter sw = InitializeStream();
            sw.WriteLine(DateTime.Now + " => " + msg);
            sw.Close();
        }


        public static void Execute(string msg, Exception e)
        {

            StreamWriter sw = InitializeStream();
            sw.WriteLine(" -" + DateTime.Now + " => " + msg + "\n **" + e.Message + "**");
            sw.Close();
        }

        private static StreamWriter InitializeStream()
        {
            StreamWriter sw = null;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);

                sw.WriteLine(" =============================");
                sw.WriteLine("||*********** LOG ***********||");
                sw.WriteLine(" =============================");
                sw.Close();
            }


            return File.AppendText(path);
        }

    }
}
