using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Logger
    {
        private static Logger instance;
        private string filePath;

        public Logger(string filePath)
        {
            this.filePath = filePath;
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger("/Users/Ana/Documents/ana.csv");
            }
            return instance;
        }

        public String Filepath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void Log(string message)
        {
            using (System.IO.StreamWriter fileWriter = new System.IO.StreamWriter(this.filePath, true))
            {
                fileWriter.WriteLine(message);
            }
        }
    }
}
