namespace Ch_4._1._9_EventExample;

public class Magazine
{
    private string name;
    public event Action<string> MagazinePublished;
    public Magazine(string magName)
    {
        this.name = magName;
    }

    public void Publish()
    {
        MagazinePublished?.Invoke("Magazine "+name+" published at "+ DateTime.Now.ToString());
    }
}