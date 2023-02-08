namespace Ch3_21.InterfacePassing;

public class FileLogger : ILogger
{
    private string _filename;
    public FileLogger(string filename)
    {
        this._filename = filename;
    }
    public void Log(string message)
    {
        System.IO.File.AppendAllText(_filename,message +" ");
    }
}