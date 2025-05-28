using System.Net;

namespace MyNamespace;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
            
        // var person = Person.parss("Gille");
        // //or var person = new Person("Ahmed");  
        // person.intreduce("ayoub");
        //
        // //var customer = new Customer(34, "yooo");
        //
        // var point = new Point(9, 7);
        // Console.WriteLine("the point is in {0},{1}", point.x, point.y);
        // point.move(5,8);
        // Console.WriteLine("the new point is in {0},{1}", point.x, point.y);
        // var pp = new Point(3, 5);
        // point.move(pp);
        // Console.WriteLine("the new point is in {0},{1}", point.x, point.y);
        //
        // var cal =  new Calculator();
        // Console.WriteLine(cal.Add(1, 2));
        // Console.WriteLine(cal.Add(1, 8));
        // Console.WriteLine(cal.Add(new int[] {1,23,5}));
        //
        //
        // var customer = new Customer(1);
        // customer.orders.Add(new Order() );
        // customer.orders.Add(new Order());
        // //customer.promote(); // we lost all cuz we declare new one 
        // Console.WriteLine(customer.orders.Count);

        // Console.WriteLine("Hello World!"); 
        // var stopWatch =  new Stopwatch();
        // var startval  = stopWatch.Start();
        // Console.WriteLine(startval);
        //
        // var stoptval =  stopWatch.Stop();
        // Console.WriteLine(stoptval);
        
        var text = new Text();
        text.width = 100;
        text.height = 100;
        text.Copy();

        var dbMigrator = new DbMigrator(new Logger());
        var logger = new Logger();
        var installer = new Installer(logger);
        
        dbMigrator.Migrate();
        installer.Install();
        
        var car = new Car("Mercides");
    }
}