namespace ConsoleApp1;

public class Stopwatch
{
    public TimeSpan Start()
    {
        return DateTime.Now.TimeOfDay;
    }

    public TimeSpan Stop()
    {
        return DateTime.Now.TimeOfDay;
    }
    
    
}