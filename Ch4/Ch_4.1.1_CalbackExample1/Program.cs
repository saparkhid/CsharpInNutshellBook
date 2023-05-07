using Ch_4._1._1_CalbackExample1;



MyDownloader downloader = new MyDownloader();

downloader.Download("http://www.myfiles.co/data.txt", Shutdown);

var udata = ReadUserData();
Console.WriteLine(udata.Item3);

Tuple<string, string, int> ReadUserData()
{
    Tuple<string,string,int> result = Tuple.Create("Ali", "372813782",40);
    return result;

}

void Shutdown()
{
    Console.WriteLine("Shutting down the PC Now");
}
void EmailWaitThenShutDown()
{

}

void Restart()
{
    Console.WriteLine("Restarting  the PC Now");
}

void Email()
{
    Console.WriteLine("Notify the user by sending an email");
}

Console.ReadKey();