namespace DataEncapsulation
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Alice";
            person.Age = 30;

            System.Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}