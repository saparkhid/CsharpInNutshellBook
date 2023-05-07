using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_4._1._1_CalbackExample1
{
    public class MyDownloader
    {
        public delegate void DownloadCallback();

        public delegate int MyCallback(int b,int a );

        public delegate StringBuilder SplushDelegate(string xml);
        public delegate MyDownloader DownloaderDelegate(MyDownloader d);

        public delegate DateTime ConvertDelegate(long ticks);

        public delegate Tuple ReadDataDelegate(string query);
        //signature

        public void Download(string url, DownloadCallback callback)
        {
            Console.WriteLine("downloading file from {0}",url);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("file downloaded successfully");
            
            callback.Invoke();
            // or simply    callback();
        }
  
    }
}
