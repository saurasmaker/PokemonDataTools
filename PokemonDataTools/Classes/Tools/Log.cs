using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tools
{
    class Log
    {
        private static string path = Directory.GetCurrentDirectory() + "\\..\\..\\log.txt";

        public static void Execute(string msg)
        {
            StreamWriter sw = InitializeStream();
            sw.WriteLine(DateTime.Now + " => " + msg);
            sw.Close();
            return;
        }


        public static void Execute(string msg, Exception e)
        {

            StreamWriter sw = InitializeStream();
            sw.WriteLine(" -" + DateTime.Now + " => " + msg + "\n **" + e.Message + "**");
            sw.Close();
            return;
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
