namespace ConsoleApp1
{

    public class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void intreduce(string to)
        {
            Console.WriteLine("HI {0}, I am {1} ", to , name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ahmed");
            //or var person = new Person("Ahmed");  
            person.intreduce("ayoub");
        }
    }
        
}