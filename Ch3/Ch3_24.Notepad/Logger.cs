using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_24.Notepad
{
    public class Logger
    {
        private string _filename;
        public Logger(string filename)
        {
            _filename = filename;
        }
        public void Log(string message)
        {
            string content = DateTime.Now.ToLongDateString() + "-" + message + "\r\n";
            System.IO.File.AppendAllText(_filename, content);
        }

    }
}
