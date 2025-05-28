namespace ConsoleApp1;

public class Vihical
{
    private readonly string _registrationNumber;
    
    // public Vihical()
    // {
    //     Console.WriteLine("vehicle is being installed...");
    // }

    public Vihical(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
        Console.WriteLine("vehicle is being initaillized {0}", registrationNumber);
    }
}