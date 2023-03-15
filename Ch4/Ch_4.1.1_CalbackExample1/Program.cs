using Ch_4._1._1_CalbackExample1;

Downloader downloader = new Downloader();

downloader.Download("http://www.myfiles.co/data.txt", Email);

downloader.Download("http://www.myfiles.co/data.txt", () =>
{
    Console.WriteLine("Shutting down the PC Now");
});

void Shutdown()
{
    Console.WriteLine("Shutting down the PC Now");
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