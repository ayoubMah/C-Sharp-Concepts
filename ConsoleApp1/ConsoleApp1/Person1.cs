using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace ConsoleApp1;

public class Person1
{
    public int id { get; set; }
    private string name;
    public int Age { get; set; }
    private DateTime birthday;

    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    Person1 person1 = new Person1();
    
    
}