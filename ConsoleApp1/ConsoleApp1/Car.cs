namespace ConsoleApp1;

public class Car : Vihical
{
    public Car(string registrationNumber)
        : base(registrationNumber)
    {
        Console.WriteLine("car is being installed... {0}" , registrationNumber);
    }
}