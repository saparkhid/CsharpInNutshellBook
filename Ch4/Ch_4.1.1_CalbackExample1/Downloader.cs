using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._1_CalbackExample1
{
    public class Downloader
    {
        public delegate void DownloadFinishedCallback();
        public void Download(string url, DownloadFinishedCallback callback)
        {
            Console.WriteLine("downloading file from {0}",url);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("file downloaded successfully");
            callback.Invoke();
            // or simply    callback();
        }
    }
}
