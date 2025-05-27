namespace ConsoleApp1;

public class HttpCoki
{
    private readonly Dictionary<string, string> _dictionary;

    public HttpCoki()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public string this[string key]
    {
        get {return _dictionary[key];}
        set { _dictionary[key] = value; }
    }
}