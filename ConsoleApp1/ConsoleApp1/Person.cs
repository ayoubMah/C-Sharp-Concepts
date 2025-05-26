namespace ConsoleApp1
{

    public class Person
    {
        public string name;

        // public Person(string name)
        // {
        //     this.name = name;
        // }

        public void intreduce(string to)
        {
            Console.WriteLine("HI {0}, I am {1} ", to , name);
        }

        public static Person parss(string str)
        {
            var person = new Person();
            person.name = str;
            return person;
        }
    }

    
        
}